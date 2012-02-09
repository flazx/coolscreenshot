using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

using CoolScreenShot.UserControls;
using DocToolkit;
using DrawTools;

namespace CoolScreenShot
{
    public partial class MainForm : Form, IDrawAreaOwner
    {
        #region properties
        
        private enum SelectionMode
        {
            None,
            NetSelection,   // group selection is active
            Move,           // object(s) are moves
            Size            // object is resized
        }

        DocManager docManager;
        Graphics g;
        DrawAreaRectangle drawRect;

        Point lastPoint;
        Point firstStartPoint = Point.Empty;
        Point firstEndPoint = Point.Empty;
        bool isDrawRectAreaCreated = false;

        int resizedObjectHandle;
        SelectionMode selectMode = SelectionMode.None;

        string currentCommandName;

        #endregion

        #region initialize
        public MainForm()
        {
            InitializeComponent();

            g = this.CreateGraphics();

            DocManagerData data = new DocManagerData();
            data.FormOwner = this;
            data.UpdateTitle = true;
            data.FileDialogFilter = "DrawTools files (*.dtl)|*.dtl|All Files (*.*)|*.*";
            data.NewDocName = "Untitled.dtl";

            docManager = new DocManager(data);
            docManager.RegisterFileType("dtl", "dtlfile", "DrawTools File");

            this.Cursor = Cursors.Cross;

            drawArea.Location = new System.Drawing.Point(0, 0);
            drawArea.Size = new System.Drawing.Size(200, 200);
            drawArea.Owner = this;
            drawArea.Visible = false;
            drawArea.Initialize(this, docManager);

            GraphicsProperties graphicProperties = drawArea.GraphicsList.GetProperties();
            this.myColorPicker.SelectedColor = DrawSettings.LastUsedColor;
            this.myColorPicker.PenWidth = graphicProperties.PenWidth;
            this.drawArea.ToolTextBox.ForeColor = DrawSettings.LastUsedColor;

            this.myColorPicker.PropertyChanged += delegate(object sender, PropertyChangedEventArgs e)
            {
                GraphicsProperties p = new GraphicsProperties();
                p.Color = e.Color;
                p.PenWidth = e.Width;
                this.drawArea.ToolTextBox.ForeColor = e.Color.Value;
                this.drawArea.ToolTextBox.Font = new System.Drawing.Font("Arial Narrow", e.TextSize);

                if (drawArea.GraphicsList.ShowColorPickerPanel(drawArea, p))
                {
                    drawArea.SetDirty();
                    drawArea.Refresh();
                }
            };
        }
        #endregion

        #region tools event

        private void toolClick(object sender, EventArgs e)
        {
            string command = "";
            ToolStripButton btn = sender as ToolStripButton;
            ToolStripMenuItem btnItem = sender as ToolStripMenuItem;

            if (btn != null)
            {
                command = btn.Tag.ToString();

                foreach (ToolStripItem item in this.toolStrip1.Items)
                {
                    ToolStripButton b = item as ToolStripButton;
                    if (b != null) b.Checked = b == btn;
                }
            }
            else if (btnItem != null)
            {
                command = btnItem.Tag.ToString();

                btnItem.Checked = true;
            }
            else
            {
                System.Diagnostics.Debug.Assert(1 == 0, sender.ToString() + " command haven't handle.");
            }

            command = command.ToLower();

            this.currentCommandName = command;
            ExecuteCommand(command);

            this.myColorPicker.Visible = IsCurrentCommandNeedColorPicker();
        }

        private bool IsCurrentCommandNeedColorPicker()
        {
            return
                currentCommandName == "rectangle" ||
                currentCommandName == "ellipse" ||
                currentCommandName == "text" ||
                currentCommandName == "line" ||
                currentCommandName == "arrow" ||
                currentCommandName == "pencil";
        }

        private void ExecuteCommand(string command)
        {
            ResizeDrawArea();

            this.drawArea.Visible = true;

            if (command != "text")
            {
                this.drawArea.ToolTextBox.Visible = false;
            }

            this.myColorPicker.SwitchMode(command == "text");

            switch (command)
            {
                case "pointer":
                    drawArea.ActiveTool = DrawArea.DrawToolType.Pointer;
                    break;
                case "rectangle":
                    drawArea.ActiveTool = DrawArea.DrawToolType.Rectangle;
                    break;
                case "ellipse":
                    drawArea.ActiveTool = DrawArea.DrawToolType.Ellipse;
                    break;
                case "line":
                    drawArea.ActiveTool = DrawArea.DrawToolType.Line;
                    break;
                case "arrow":
                    drawArea.ActiveTool = DrawArea.DrawToolType.Arrow;
                    break;
                case "pencil":
                    drawArea.ActiveTool = DrawArea.DrawToolType.Polygon;
                    break;
                case "text":
                    drawArea.ActiveTool = DrawArea.DrawToolType.Text;
                    break;
                case "undo":
                    drawArea.Undo();
                    break;
                case "redo":
                    drawArea.Redo();
                    break;
                case "save":
                    CommandSave();
                    break;
                case "complete":
                    CommandComplete();
                    break;
                case "properties":
                    if (drawArea.GraphicsList.ShowPropertiesDialog(drawArea))
                    {
                        drawArea.SetDirty();
                        drawArea.Refresh();
                    }
                    break;
                case "selectall":
                    drawArea.GraphicsList.SelectAll();
                    drawArea.Refresh();
                    break;
                case "unselectall":
                    drawArea.GraphicsList.UnselectAll();
                    drawArea.Refresh();
                    break;
                case "delete":
                    CommandDelete c = new CommandDelete(drawArea.GraphicsList);

                    if (drawArea.GraphicsList.DeleteSelection())
                    {
                        drawArea.SetDirty();
                        drawArea.Refresh();
                        drawArea.AddCommandToHistory(c);
                    }
                    break;
                case "deleteall":
                    CommandDeleteAll cc = new CommandDeleteAll(drawArea.GraphicsList);

                    if (drawArea.GraphicsList.Clear())
                    {
                        drawArea.SetDirty();
                        drawArea.Refresh();
                        drawArea.AddCommandToHistory(cc);
                    }
                    break;
                case "movetofront":
                    if (drawArea.GraphicsList.MoveSelectionToFront())
                    {
                        drawArea.SetDirty();
                        drawArea.Refresh();
                    }
                    break;
                case "movetoback":
                    if (drawArea.GraphicsList.MoveSelectionToBack())
                    {
                        drawArea.SetDirty();
                        drawArea.Refresh();
                    }
                    break;

                case "about":
                    FrmAbout frm = new FrmAbout();
                    frm.ShowDialog(this);
                    break;
                case "new":
                    docManager.NewDocument(); break;
                case "open":
                    docManager.OpenDocument(""); break;
                case "saveas":
                    docManager.SaveDocument(DocManager.SaveType.SaveAs);
                    break;
                case "exit":
                    this.Exit();
                    break;
                case "preferences":
                    Form sf = new SettingForm();
                    sf.Show();
                    break;
            }
        }

        private void CommandSave()
        {
            ImageFormat[] formats = new ImageFormat[] { ImageFormat.Png, ImageFormat.Jpeg, ImageFormat.Bmp, ImageFormat.Gif };
            string fileName = String.Format("CoolShot{0}.png", DateTime.Now.ToString("yyyyMMddhhmmss"));
            saveCropFileDialog.FileName = fileName;

            if (saveCropFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = this.GetCurrentCropAnnotateImage();
                bmp.Save(saveCropFileDialog.FileName, formats[saveCropFileDialog.FilterIndex]);
                this.Exit();
            }
        }

        private void CommandComplete()
        {
            Clipboard.SetImage(this.GetCurrentCropAnnotateImage());
            this.Exit();
        }


        #endregion

        #region mouse event
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (!isDrawRectAreaCreated && e.Button == MouseButtons.Left)
            {
                firstStartPoint = new Point(e.X, e.Y);
            }

            if (!isDrawRectAreaCreated) 
                return;

            lastPoint.X = e.X;
            lastPoint.Y = e.Y;

            selectMode = SelectionMode.None;
            Point point = new Point(e.X, e.Y);
            int handleNumber = drawRect.HitTest(point);

            // resize
            if (handleNumber > 0)
            {
                selectMode = SelectionMode.Size;
                resizedObjectHandle = handleNumber;
            }

            // move
            if (selectMode == SelectionMode.None)
            {
                if (handleNumber == 0)
                {
                    selectMode = SelectionMode.Move;
                    drawArea.Cursor = Cursors.SizeAll;
                }
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (!isDrawRectAreaCreated && e.Button == MouseButtons.Left)
            {
                if (this.firstStartPoint.X == e.X || this.firstStartPoint.Y == e.Y)
                {
                    return;
                }

                firstEndPoint = new Point(e.X, e.Y);
                drawRect = new DrawAreaRectangle(firstStartPoint.X, firstStartPoint.Y, firstEndPoint.X - firstStartPoint.X, firstEndPoint.Y - firstStartPoint.Y);
                drawRect.Draw(g);
                drawRect.Selected = true;
                drawRect.DrawTracker(g);

                isDrawRectAreaCreated = true;

                this.Refresh();
            }

            if (HasDrawRectangleArea)
            {
                ResizeDrawArea();
                this.toolStripPanel.Visible = true;
                this.myColorPicker.Visible = IsCurrentCommandNeedColorPicker();
            }

            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (!isDrawRectAreaCreated && firstStartPoint != Point.Empty)
            {
                firstEndPoint = new Point(e.X, e.Y);
                lastPoint = firstStartPoint;
                this.Refresh();
                return;
            }

            if (!HasDrawRectangleArea) return;

            Point point = new Point(e.X, e.Y);
            Point oldPoint = lastPoint;

            // set cursor when mouse button is not pressed
            if (e.Button == MouseButtons.None)
            {
                Cursor cursor = null;
                int n = drawRect.HitTest(point);

                if (n > 0)
                {
                    cursor = drawRect.GetHandleCursor(n);
                }

                if (cursor == null)
                {
                    cursor = Cursors.Default;
                }

                this.Cursor = cursor;

                return;
            }


            if (e.Button != MouseButtons.Left)
                return;

            int dx = e.X - lastPoint.X;
            int dy = e.Y - lastPoint.Y;

            lastPoint.X = e.X;
            lastPoint.Y = e.Y;

            // resize
            if (drawRect != null)
            {
                //this.drawArea.Visible = false;
                this.toolStripPanel.Visible = false;
                this.myColorPicker.Visible = false;

                this.ResizeDrawArea();

                if (selectMode == SelectionMode.Size)
                {
                    drawRect.MoveHandleTo(point, resizedObjectHandle);
                }
                else if (selectMode == SelectionMode.Move)
                {
                    this.Cursor = Cursors.SizeAll;
                    drawRect.Move(dx, dy);
                }

                this.Refresh();
            }

            base.OnMouseMove(e);
        }

        #endregion

        #region draw UI
        private void ResizeDrawArea()
        {
            Rectangle r = this.CropAreaRectangle;

            int top, left;

            top = r.Height < 0 ? r.Y + r.Height : r.Y;
            left = r.Width < 0 ? r.X + r.Width : r.X;

            this.drawArea.Location = new Point(left, top);
            this.drawArea.Width = Math.Abs(r.Width);
            this.drawArea.Height = Math.Abs(r.Height);
            this.drawArea.Visible = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            this.PaintUI(e.Graphics);
        }

        private void PaintUI(Graphics g)
        {
            if (!isDrawRectAreaCreated && firstEndPoint != Point.Empty)
            {
                DrawCropAreaRectangle(g);
            }

            DrawBG(g);

            if (HasDrawRectangleArea)
            {
                DrawCropArea(g);
                UpdateToolsPanelColorPickerLocation();
                DrawCropAreaWHIndicator(g);
            }
        }

        private bool HasDrawRectangleArea
        {
            get { return drawRect != null && drawRect.Rectangle.Width != 0; }
        }

        private Rectangle CropAreaRectangle
        {
            get { return this.drawRect.Rectangle; }
        }

        void DrawCropArea(Graphics g)
        {
            drawRect.Draw(g);
            drawRect.Selected = true;
            drawRect.DrawTracker(g);
        }

        void DrawBG(Graphics g)
        {
            Color colorRed = Color.Gray;
            Color color = Color.FromArgb(77, colorRed.R, colorRed.G, colorRed.B);
            SolidBrush brush = new SolidBrush(color);

            Rectangle b = Screen.PrimaryScreen.Bounds;

            if (this.drawRect == null || this.drawRect.Rectangle == Rectangle.Empty)
            {
                g.FillRectangle(brush, 0, 0, b.Width, b.Height);
            }
            else
            {
                Rectangle r = this.CropAreaRectangle;

                int top, left, w = Math.Abs(r.Width), h = Math.Abs(r.Height);
                top = r.Height < 0 ? r.Y + r.Height : r.Y;
                left = r.Width < 0 ? r.X + r.Width : r.X;

                g.FillPolygon(brush, new PointF[] {
			              	new PointF(0,0),
			              	new PointF(left + w, 0),
			              	new PointF(left + w, top),
			              	new PointF(left, top),
			              	new PointF(left, top + h),
			              	new PointF(left + w, top + h),
			              	new PointF(left + w, b.Height),
			              	new PointF(0, b.Height),
			              });

                g.FillRectangle(brush, left + w, 0, b.Width - left - w, b.Height);
            }
        }

        void DrawCropAreaWHIndicator(Graphics g)
        {
            Color bgColor = Color.FromArgb(56, 63, 68);
            SolidBrush brush = new SolidBrush(bgColor);

            int indicatorWidth = 80;
            int indicatorHeight = 20;
            int y, top, left;

            Rectangle r = this.CropAreaRectangle;

            left = r.Width < 0 ? r.X + r.Width : r.X;
            top = r.Top < 0 ? r.Y + r.Height : r.Y;

            if (r.Top < indicatorHeight)
            {
                y = top;
            }
            else
            {
                y = top - indicatorHeight;
            }

            String indicatorContent = String.Format("{0} x {1}", Math.Abs(r.Width), Math.Abs(r.Height));

            g.FillRectangle(brush, left, y, indicatorWidth, indicatorHeight);
            g.DrawString(indicatorContent, new Font("Arial", 8f), Brushes.White, left + 15, y + 3);
        }

        void DrawCropAreaRectangle(Graphics g)
        {
            Pen pen = Pens.Red;
            g.DrawRectangle(pen, firstStartPoint.X, firstStartPoint.Y,
                            firstEndPoint.X - firstStartPoint.X,
                            firstEndPoint.Y - firstStartPoint.Y);
        }

        void UpdateToolsPanelColorPickerLocation()
        {
            Rectangle r = CropAreaRectangle;
            Rectangle b = Screen.PrimaryScreen.Bounds;

            int h = this.toolStripPanel.Height;
            int w = this.toolStripPanel.Width;
            int marginTop = 5;
            int top, left;

            int colorPickerHeight = 39, colorPickerStripPanelSpace = 5;

            top = r.Height < 0 ? r.Y + r.Height : r.Y;
            left = r.Width < 0 ? r.X + r.Width : r.X;

            int x, y, x1, y1;

            if (r.Bottom + marginTop + h + colorPickerHeight + colorPickerStripPanelSpace > b.Height)
            {
                if (top - marginTop - h - colorPickerHeight - colorPickerStripPanelSpace < 0)
                {
                    y = top;
                    y1 = y + colorPickerStripPanelSpace + h;
                }
                else
                {
                    y = top - marginTop - h;
                    y1 = y - colorPickerStripPanelSpace - colorPickerHeight;
                }
            }
            else
            {
                y = top + Math.Abs(r.Height) + marginTop;
                y1 = y + colorPickerStripPanelSpace + h;
            }

            if (left + Math.Abs(r.Width) < this.toolStripPanel.Width)
            {
                x = left;
            }
            else
            {
                x = left + Math.Abs(r.Width) - this.toolStripPanel.Width;
            }

            x1 = x;

            this.toolStripPanel.Location = new Point(x, y);
            this.myColorPicker.Location = new Point(x1, y1);
        }

        #endregion

        #region override Form Event
        protected override void OnLoad(EventArgs e)
        {
            Rectangle b = Screen.PrimaryScreen.Bounds;
            Size s = new Size(b.Width, b.Height);
            Bitmap memoryImage = new Bitmap(s.Width, s.Height, g);

            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                          Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size,
                                          CopyPixelOperation.SourceCopy);

            this.BackgroundImage = memoryImage;
            this.drawArea.OriginalBackgroundImage = memoryImage;
            this.toolStripPanel.BringToFront();

            g = this.CreateGraphics();

            /*
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            TopMost = true;*/

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer, true);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // if it is a hotkey, return true; otherwise, return false
            switch (keyData)
            {
                case Keys.Escape:
                    this.Exit();
                    return true;
                default:
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region implements IDrawArea methods
        public void SetStateOfControls() { }
        public ToolStripMenuItem ContextParent { get { return this.editToolStripMenuItem; } }
        public Form getForm() { return this; }
        #endregion

        #region helper methods
        private Bitmap GetCurrentCropAnnotateImage()
        {
            Bitmap bmp = new System.Drawing.Bitmap(drawArea.ClientRectangle.Width, drawArea.ClientRectangle.Height);
            drawArea.DrawToBitmap(bmp, drawArea.ClientRectangle);


            return bmp;
        }

        private void Exit()
        {
            this.WindowState = FormWindowState.Minimized;
            this.Hide();
        }
        #endregion
    }
}
