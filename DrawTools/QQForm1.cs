/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/4
 * Time: 17:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using DocToolkit;
	
namespace DrawTools
{
	public partial class QQForm1 : Form,IDrawAreaOwner
	{
		private enum SelectionMode
        {
            None,
            NetSelection,   // group selection is active
            Move,           // object(s) are moves
            Size            // object is resized
        }
		
		#region properties
		DocManager docManager;
		Graphics g;
		DrawRectangle drawRect;
		
		Point lastPoint;
		
		Point firstStartPoint = Point.Empty;
		Point firstEndPoint = Point.Empty;
		bool drawAreaCreated = false;
		
		bool wasMove;
		int resizedObjectHandle;
		SelectionMode selectMode = SelectionMode.None;
		#endregion
		
		#region initialize
		public QQForm1()
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
			
			// Create draw area
            
            drawArea.Location = new System.Drawing.Point(0, 0);
            drawArea.Size = new System.Drawing.Size(200, 200);
            drawArea.Owner = this;
            drawArea.Visible = false;
            drawArea.Initialize(this, docManager);
		}
		
		void QQForm1Load(object sender, EventArgs e)
		{
			Rectangle b = Screen.PrimaryScreen.Bounds;
			Size s = new Size(b.Width,b.Height);
			Bitmap memoryImage = new Bitmap(s.Width, s.Height, g);
			
			Graphics memoryGraphics = Graphics.FromImage(memoryImage);
			memoryGraphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
			                              Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size,
			                              CopyPixelOperation.SourceCopy);
			
			//memoryImage.Save(@"c:\test.jpg");
			this.BackgroundImage = memoryImage;
			this.drawArea.OriginalBackgroundImage = memoryImage;
			this.toolStrip1.BringToFront();
			
			g = this.CreateGraphics();
			
			FormBorderStyle = FormBorderStyle.None;
			WindowState = FormWindowState.Maximized;
			TopMost = true;
			
			this.SetStyle(
				ControlStyles.AllPaintingInWmPaint |
				ControlStyles.UserPaint |
				ControlStyles.DoubleBuffer,true);
		}
		#endregion
		
		#region tools event
		
        private void toolStripButtonPointer_Click(object sender, EventArgs e)
        {
            CommandPointer();
        }

        private void toolStripButtonRectangle_Click(object sender, EventArgs e)
        {
            CommandRectangle();
        }

        private void toolStripButtonEllipse_Click(object sender, EventArgs e)
        {
            CommandEllipse();
        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            CommandLine();
        }

        private void toolStripButtonPencil_Click(object sender, EventArgs e)
        {
            CommandPolygon();
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e)
        {
            CommandUndo();
        }

        private void toolStripButtonRedo_Click(object sender, EventArgs e)
        {
            CommandRedo();
        }
        
        void ToolStripButtonSaveClick(object sender, EventArgs e)
		{
        	CommandSave();
		}
		
		   /// <summary>
        /// Set Pointer draw tool
        /// </summary>
        private void CommandPointer()
        {
            drawArea.ActiveTool = DrawArea.DrawToolType.Pointer;
        }

        /// <summary>
        /// Set Rectangle draw tool
        /// </summary>
        private void CommandRectangle()
        {
            drawArea.ActiveTool = DrawArea.DrawToolType.Rectangle;
        }

        /// <summary>
        /// Set Ellipse draw tool
        /// </summary>
        private void CommandEllipse()
        {
            drawArea.ActiveTool = DrawArea.DrawToolType.Ellipse;
        }

        /// <summary>
        /// Set Line draw tool
        /// </summary>
        private void CommandLine()
        {
            drawArea.ActiveTool = DrawArea.DrawToolType.Line;
        }

        /// <summary>
        /// Set Polygon draw tool
        /// </summary>
        private void CommandPolygon()
        {
            drawArea.ActiveTool = DrawArea.DrawToolType.Polygon;
        }
		
        /// <summary>
        /// Undo
        /// </summary>
        private void CommandUndo()
        {
            drawArea.Undo();
        }

        /// <summary>
        /// Redo
        /// </summary>
        private void CommandRedo()
        {
            drawArea.Redo();
        }
        
        
        private void CommandSave(){
        	Bitmap bmp = new System.Drawing.Bitmap(drawArea.ClientRectangle.Width, drawArea.ClientRectangle.Height);
        	drawArea.DrawToBitmap(bmp, drawArea.ClientRectangle);
        	
        	bmp.Save(@"c:\test.jpg");
        }

		
		#endregion
		
		#region mouse event
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if(!drawAreaCreated && e.Button == MouseButtons.Left){
				firstStartPoint = new Point(e.X, e.Y);
			}
			
		//	if(!HasDrawRectangleArea) return;
			
//			wasMove = false;
//
//            selectMode = SelectionMode.None;
//            Point point = new Point(e.X, e.Y);
//            int handleNumber = drawRect.HitTest(point);
//
//            if (handleNumber > 0)
//            {
//                selectMode = SelectionMode.Size;
//                resizedObjectHandle = handleNumber;
//            }
//            
//            // Test for move (cursor is on the object)
//            if ( selectMode == SelectionMode.None )
//            {
//                if ( drawRect.HitTest(point) == 0 )
//                {
//                    selectMode = SelectionMode.Move;
//                    drawArea.Cursor = Cursors.SizeAll;
//                }
//            }
			
			base.OnMouseDown(e);
		}
		
		protected override void OnMouseUp(MouseEventArgs e)
		{
			if(!drawAreaCreated && e.Button == MouseButtons.Left){
				firstEndPoint = new Point(e.X, e.Y);
				drawRect = new DrawRectangle(firstStartPoint.X,firstStartPoint.Y, firstEndPoint.X - firstStartPoint.X,firstEndPoint.Y - firstStartPoint.Y);
				drawRect.Draw(g);
				drawRect.Selected = true;
				drawRect.DrawTracker(g);
				
				drawAreaCreated = true;
				
				this.Refresh();
			}
			
			if(HasDrawRectangleArea){
				resizeDrawArea();
				this.drawArea.Visible = true;
				this.toolStrip1.Visible = true;
			}
				
			base.OnMouseUp(e);
		}
		
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if(!drawAreaCreated && firstStartPoint != Point.Empty){
				firstEndPoint = new Point(e.X, e.Y);
				this.Refresh();
				return;
			}
			
			if(!HasDrawRectangleArea) return;
			
			Point point = new Point(e.X, e.Y);
            Point oldPoint = lastPoint;

            wasMove = true;

            // set cursor when mouse button is not pressed
            if (e.Button == MouseButtons.None)
            {
                Cursor cursor = null;
                int n = drawRect.HitTest(point);
                resizedObjectHandle = n;
                if(n > 0){
                	cursor = drawRect.GetHandleCursor(n);
                }
                
                //if(n == 0) MessageBox.Show("!!!");

                if (cursor == null)
                    cursor = Cursors.Default;
                
                this.Cursor = cursor;
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
            	this.toolStrip1.Visible = false;
            	
            	this.resizeDrawArea();
                drawRect.MoveHandleTo(point, resizedObjectHandle);
                this.Refresh();
            }
		}
		#endregion
		
		#region draw UI
		private void resizeDrawArea(){
			this.drawArea.Location = new Point(this.DrawRectangle.Location.X + 2, this.DrawRectangle.Location.Y +2);
			this.drawArea.Width = this.DrawRectangle.Width - 2;
			this.drawArea.Height = this.DrawRectangle.Height - 2;
			this.drawArea.Visible = true;
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			
			this.PaintUI(e.Graphics);
		}
		
		private void PaintUI(Graphics g){
			if(!drawAreaCreated && firstEndPoint != Point.Empty){
				DrawAreaRectangle(g);
			}
			
			if(HasDrawRectangleArea){
				DrawCropArea(g);
				DrawBG(g);
				UpdateToolsPanelLocation();
			}
			
			
		}
		
		private bool HasDrawRectangleArea{
			get { return drawRect != null && drawRect.Rectangle.Width != 0; } 
		}
		
		private Rectangle DrawRectangle{
			get{ return this.drawRect.Rectangle; }
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
			
			Rectangle r = this.DrawRectangle;
			Rectangle b = Screen.PrimaryScreen.Bounds;
			
			g.FillPolygon(brush, new PointF[] {
			    new PointF(0,0),
		        new PointF(r.X + r.Width, 0),
		        new PointF(r.X + r.Width, r.Y),
		        new PointF(r.X, r.Y),
		        new PointF(r.X, r.Y + r.Height),
		        new PointF(r.X + r.Width, r.Y + r.Height),
		        new PointF(r.X + r.Width, b.Height),
		        new PointF(0, b.Height),
		    });
			
			g.FillRectangle(brush, r.X + r.Width, 0, b.Width - r.X - r.Width, b.Height);
		}
		
		void DrawAreaRectangle(Graphics g){
			Pen pen = Pens.Red;
			g.DrawRectangle(pen, firstStartPoint.X, firstStartPoint.Y, 
			                firstEndPoint.X - firstStartPoint.X,
			                firstEndPoint.Y - firstStartPoint.Y);
		}
		
		void UpdateToolsPanelLocation(){
			Rectangle r  = DrawRectangle;
			Rectangle b = Screen.PrimaryScreen.Bounds;
			
			int h = this.toolStrip1.Height;
			int w = this.toolStrip1.Width;
			int marginTop = 5;
			
			int x, y;
			
			if(r.Bottom  + marginTop + h > b.Height){
				if(r.Top - marginTop - h < 0){
					y = r.Top;
				}
				else{
					y = r.Top - marginTop - h;
				}
			}
			else{
				y = r.Top + r.Height + marginTop;
			}
			
			if(r.Left + r.Width < this.toolStrip1.Width){
				x = r.Left;
			}
			else{
				x = r.Left + r.Width - this.toolStrip1.Width;
			}
			
			
			this.toolStrip1.Location = new Point(x, y);
		}
		
		void SetVisibleOfControls(){
			
		}
		
		#endregion
		
		#region others
		void QQForm1KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (int)Keys.Escape) {
				this.WindowState = FormWindowState.Minimized;
			}
		}
		#endregion
		
		#region IDrawArea methods
		public void SetStateOfControls(){}
		public ToolStripMenuItem ContextParent{ get { return this.editToolStripMenuItem ;} }
		public Form getForm(){return this;}
		#endregion
		
		
	}
}
