/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/4
 * Time: 17:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DrawTools
{
	partial class QQForm1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QQForm1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.unselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.moveToFrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.moveToBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.drawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pointerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pencilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.drawArea = new DrawTools.DrawArea();
			this.saveCropFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.myColorPicker = new DrawTools.UserControls.MyColorPicker();
			this.toolStripPanel = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.rectangle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonPointer = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.notifyIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.toolStripPanel.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.editToolStripMenuItem,
									this.drawToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(555, 25);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Visible = false;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.openToolStripMenuItem,
									this.saveToolStripMenuItem,
									this.saveAsToolStripMenuItem,
									this.toolStripMenuItem1,
									this.recentFilesToolStripMenuItem,
									this.toolStripMenuItem2,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.newToolStripMenuItem.Tag = "New";
			this.newToolStripMenuItem.Text = "New";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.openToolStripMenuItem.Tag = "Open";
			this.openToolStripMenuItem.Text = "Open";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.saveToolStripMenuItem.Tag = "Save";
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.saveAsToolStripMenuItem.Tag = "Save As";
			this.saveAsToolStripMenuItem.Text = "Save As";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(141, 6);
			// 
			// recentFilesToolStripMenuItem
			// 
			this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
			this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.recentFilesToolStripMenuItem.Tag = "Recent Files";
			this.recentFilesToolStripMenuItem.Text = "Recent Files";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(141, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.exitToolStripMenuItem.Tag = "Exit";
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.selectAllToolStripMenuItem,
									this.unselectAllToolStripMenuItem,
									this.deleteToolStripMenuItem,
									this.deleteAllToolStripMenuItem,
									this.toolStripMenuItem3,
									this.moveToFrontToolStripMenuItem,
									this.moveToBackToolStripMenuItem,
									this.toolStripMenuItem5,
									this.undoToolStripMenuItem,
									this.redoToolStripMenuItem,
									this.toolStripMenuItem4,
									this.propertiesToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.selectAllToolStripMenuItem.Tag = "SelectAll";
			this.selectAllToolStripMenuItem.Text = "Select All";
			this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.toolClick);
			// 
			// unselectAllToolStripMenuItem
			// 
			this.unselectAllToolStripMenuItem.Name = "unselectAllToolStripMenuItem";
			this.unselectAllToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.unselectAllToolStripMenuItem.Tag = "UnselectAll";
			this.unselectAllToolStripMenuItem.Text = "Unselect All";
			this.unselectAllToolStripMenuItem.Click += new System.EventHandler(this.toolClick);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.deleteToolStripMenuItem.Tag = "Delete";
			this.deleteToolStripMenuItem.Text = "Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.toolClick);
			// 
			// deleteAllToolStripMenuItem
			// 
			this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
			this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.deleteAllToolStripMenuItem.Tag = "DeleteAll";
			this.deleteAllToolStripMenuItem.Text = "Delete All";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(156, 6);
			// 
			// moveToFrontToolStripMenuItem
			// 
			this.moveToFrontToolStripMenuItem.Name = "moveToFrontToolStripMenuItem";
			this.moveToFrontToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.moveToFrontToolStripMenuItem.Tag = "MoveToFront";
			this.moveToFrontToolStripMenuItem.Text = "Move to Front";
			this.moveToFrontToolStripMenuItem.Click += new System.EventHandler(this.toolClick);
			// 
			// moveToBackToolStripMenuItem
			// 
			this.moveToBackToolStripMenuItem.Name = "moveToBackToolStripMenuItem";
			this.moveToBackToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.moveToBackToolStripMenuItem.Tag = "MoveToBack";
			this.moveToBackToolStripMenuItem.Text = "Move to Back";
			this.moveToBackToolStripMenuItem.Click += new System.EventHandler(this.toolClick);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(156, 6);
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
			this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.undoToolStripMenuItem.Tag = "Undo";
			this.undoToolStripMenuItem.Text = "Undo";
			this.undoToolStripMenuItem.Click += new System.EventHandler(this.toolClick);
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
			this.redoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.redoToolStripMenuItem.Tag = "Redo";
			this.redoToolStripMenuItem.Text = "Redo";
			this.redoToolStripMenuItem.Click += new System.EventHandler(this.toolClick);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(156, 6);
			// 
			// propertiesToolStripMenuItem
			// 
			this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
			this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.propertiesToolStripMenuItem.Tag = "Properties";
			this.propertiesToolStripMenuItem.Text = "Properties";
			this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.toolClick);
			// 
			// drawToolStripMenuItem
			// 
			this.drawToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.pointerToolStripMenuItem,
									this.rectangleToolStripMenuItem,
									this.ellipseToolStripMenuItem,
									this.lineToolStripMenuItem,
									this.pencilToolStripMenuItem});
			this.drawToolStripMenuItem.Name = "drawToolStripMenuItem";
			this.drawToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
			this.drawToolStripMenuItem.Text = "Draw";
			// 
			// pointerToolStripMenuItem
			// 
			this.pointerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pointerToolStripMenuItem.Image")));
			this.pointerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.pointerToolStripMenuItem.Name = "pointerToolStripMenuItem";
			this.pointerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.pointerToolStripMenuItem.Tag = "Pointer";
			this.pointerToolStripMenuItem.Text = "Pointer";
			// 
			// rectangleToolStripMenuItem
			// 
			this.rectangleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rectangleToolStripMenuItem.Image")));
			this.rectangleToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
			this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.rectangleToolStripMenuItem.Tag = "Rectangle";
			this.rectangleToolStripMenuItem.Text = "Rectangle";
			// 
			// ellipseToolStripMenuItem
			// 
			this.ellipseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ellipseToolStripMenuItem.Image")));
			this.ellipseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
			this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.ellipseToolStripMenuItem.Tag = "Ellipse";
			this.ellipseToolStripMenuItem.Text = "Ellipse";
			// 
			// lineToolStripMenuItem
			// 
			this.lineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lineToolStripMenuItem.Image")));
			this.lineToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
			this.lineToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.lineToolStripMenuItem.Tag = "Line";
			this.lineToolStripMenuItem.Text = "Line";
			// 
			// pencilToolStripMenuItem
			// 
			this.pencilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pencilToolStripMenuItem.Image")));
			this.pencilToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.pencilToolStripMenuItem.Name = "pencilToolStripMenuItem";
			this.pencilToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.pencilToolStripMenuItem.Tag = "Pencil";
			this.pencilToolStripMenuItem.Text = "Pencil";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
			this.aboutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// drawArea
			// 
			this.drawArea.ActiveTool = DrawTools.DrawArea.DrawToolType.Pointer;
			this.drawArea.BackColor = System.Drawing.Color.Transparent;
			this.drawArea.DocManager = null;
			this.drawArea.GraphicsList = null;
			this.drawArea.Location = new System.Drawing.Point(12, 30);
			this.drawArea.Name = "drawArea";
			this.drawArea.OriginalBackgroundImage = null;
			this.drawArea.Owner = null;
			this.drawArea.Size = new System.Drawing.Size(41, 28);
			this.drawArea.TabIndex = 4;
			this.drawArea.Visible = false;
			// 
			// saveCropFileDialog
			// 
			this.saveCropFileDialog.Filter = "png|*.png|jpg|*.jpg,*.jpeg|bmp|*.bmp|gif|*.gif";
			// 
			// toolStrip2
			// 
			this.toolStrip2.AutoSize = false;
			this.toolStrip2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.toolStrip2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip2.BackgroundImage")));
			this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButton4,
									this.toolStripButton5,
									this.toolStripButton6,
									this.toolStripButton7,
									this.toolStripButton8,
									this.toolStripSeparator5,
									this.toolStripButton9,
									this.toolStripButton10,
									this.toolStripSeparator6,
									this.toolStripButton11,
									this.toolStripButton12,
									this.toolStripButton13,
									this.toolStripButton14,
									this.toolStripButton15,
									this.toolStripSeparator7,
									this.toolStripButton16,
									this.toolStripSeparator8});
			this.toolStrip2.Location = new System.Drawing.Point(90, 185);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip2.ShowItemToolTips = false;
			this.toolStrip2.Size = new System.Drawing.Size(374, 28);
			this.toolStrip2.TabIndex = 5;
			this.toolStrip2.Text = "toolStrip2";
			this.toolStrip2.Visible = false;
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(24, 25);
			this.toolStripButton4.Tag = "Rectangle";
			this.toolStripButton4.Text = "Rectangle";
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(24, 25);
			this.toolStripButton5.Tag = "ellipse";
			this.toolStripButton5.Text = "Ellipse";
			// 
			// toolStripButton6
			// 
			this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
			this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton6.Name = "toolStripButton6";
			this.toolStripButton6.Size = new System.Drawing.Size(24, 25);
			this.toolStripButton6.Tag = "Arrow";
			this.toolStripButton6.Text = "Arrow";
			// 
			// toolStripButton7
			// 
			this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
			this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButton7.Name = "toolStripButton7";
			this.toolStripButton7.Size = new System.Drawing.Size(24, 25);
			this.toolStripButton7.Tag = "pencil";
			this.toolStripButton7.Text = "Pencil";
			// 
			// toolStripButton8
			// 
			this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
			this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButton8.Name = "toolStripButton8";
			this.toolStripButton8.Size = new System.Drawing.Size(24, 25);
			this.toolStripButton8.Tag = "text";
			this.toolStripButton8.Text = "text";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
			// 
			// toolStripButton9
			// 
			this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
			this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButton9.Name = "toolStripButton9";
			this.toolStripButton9.Size = new System.Drawing.Size(24, 25);
			this.toolStripButton9.Tag = "undo";
			this.toolStripButton9.Text = "Undo";
			// 
			// toolStripButton10
			// 
			this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
			this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButton10.Name = "toolStripButton10";
			this.toolStripButton10.Size = new System.Drawing.Size(24, 25);
			this.toolStripButton10.Tag = "save";
			this.toolStripButton10.Text = "Save";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
			// 
			// toolStripButton11
			// 
			this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
			this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton11.Name = "toolStripButton11";
			this.toolStripButton11.Size = new System.Drawing.Size(24, 25);
			this.toolStripButton11.Tag = "exit";
			this.toolStripButton11.Text = "exit";
			// 
			// toolStripButton12
			// 
			this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
			this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButton12.Name = "toolStripButton12";
			this.toolStripButton12.Size = new System.Drawing.Size(24, 25);
			this.toolStripButton12.Tag = "open";
			this.toolStripButton12.Text = "Open";
			// 
			// toolStripButton13
			// 
			this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
			this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButton13.Name = "toolStripButton13";
			this.toolStripButton13.Size = new System.Drawing.Size(24, 25);
			this.toolStripButton13.Tag = "pointer";
			this.toolStripButton13.Text = "Pointer";
			// 
			// toolStripButton14
			// 
			this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
			this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButton14.Name = "toolStripButton14";
			this.toolStripButton14.Size = new System.Drawing.Size(24, 25);
			this.toolStripButton14.Tag = "line";
			this.toolStripButton14.Text = "Line";
			// 
			// toolStripButton15
			// 
			this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
			this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButton15.Name = "toolStripButton15";
			this.toolStripButton15.Size = new System.Drawing.Size(24, 25);
			this.toolStripButton15.Tag = "Text";
			this.toolStripButton15.Text = "Text";
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 28);
			// 
			// toolStripButton16
			// 
			this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
			this.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButton16.Name = "toolStripButton16";
			this.toolStripButton16.Size = new System.Drawing.Size(24, 25);
			this.toolStripButton16.Tag = "redo";
			this.toolStripButton16.Text = "Redo";
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 28);
			// 
			// myColorPicker
			// 
			this.myColorPicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myColorPicker.BackgroundImage")));
			this.myColorPicker.Location = new System.Drawing.Point(82, 193);
			this.myColorPicker.Name = "myColorPicker";
			this.myColorPicker.PenWidth = 1;
			this.myColorPicker.SelectedColor = System.Drawing.Color.Red;
			this.myColorPicker.Size = new System.Drawing.Size(264, 39);
			this.myColorPicker.TabIndex = 6;
			this.myColorPicker.Visible = false;
			// 
			// toolStripPanel
			// 
			this.toolStripPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripPanel.BackgroundImage")));
			this.toolStripPanel.Controls.Add(this.toolStrip1);
			this.toolStripPanel.Location = new System.Drawing.Point(82, 238);
			this.toolStripPanel.Name = "toolStripPanel";
			this.toolStripPanel.Padding = new System.Windows.Forms.Padding(2);
			this.toolStripPanel.Size = new System.Drawing.Size(304, 28);
			this.toolStripPanel.TabIndex = 7;
			this.toolStripPanel.Visible = false;
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
			this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.rectangle,
									this.toolStripButtonEllipse,
									this.toolStripButton1,
									this.toolStripButtonLine,
									this.toolStripButton2,
									this.toolStripButtonNew,
									this.toolStripSeparator1,
									this.toolStripButtonUndo,
									this.toolStripButtonPointer,
									this.toolStripButtonSave,
									this.toolStripSeparator4,
									this.toolStripButton3,
									this.toolStripButton17});
			this.toolStrip1.Location = new System.Drawing.Point(2, 2);
			this.toolStrip1.Margin = new System.Windows.Forms.Padding(5);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.toolStrip1.ShowItemToolTips = false;
			this.toolStrip1.Size = new System.Drawing.Size(300, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// rectangle
			// 
			this.rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.rectangle.Image = ((System.Drawing.Image)(resources.GetObject("rectangle.Image")));
			this.rectangle.ImageTransparentColor = System.Drawing.Color.Silver;
			this.rectangle.Name = "rectangle";
			this.rectangle.Size = new System.Drawing.Size(24, 22);
			this.rectangle.Tag = "Rectangle";
			this.rectangle.Text = "Rectangle";
			this.rectangle.Click += new System.EventHandler(this.toolClick);
			// 
			// toolStripButtonEllipse
			// 
			this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEllipse.Image")));
			this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
			this.toolStripButtonEllipse.Size = new System.Drawing.Size(24, 22);
			this.toolStripButtonEllipse.Tag = "ellipse";
			this.toolStripButtonEllipse.Text = "Ellipse";
			this.toolStripButtonEllipse.Click += new System.EventHandler(this.toolClick);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(24, 22);
			this.toolStripButton1.Tag = "Arrow";
			this.toolStripButton1.Text = "Arrow";
			this.toolStripButton1.Click += new System.EventHandler(this.toolClick);
			// 
			// toolStripButtonLine
			// 
			this.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLine.Image")));
			this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonLine.Name = "toolStripButtonLine";
			this.toolStripButtonLine.Size = new System.Drawing.Size(24, 22);
			this.toolStripButtonLine.Tag = "line";
			this.toolStripButtonLine.Text = "Line";
			this.toolStripButtonLine.Click += new System.EventHandler(this.toolClick);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(24, 22);
			this.toolStripButton2.Tag = "pencil";
			this.toolStripButton2.Text = "Pencil";
			this.toolStripButton2.Click += new System.EventHandler(this.toolClick);
			// 
			// toolStripButtonNew
			// 
			this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
			this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonNew.Name = "toolStripButtonNew";
			this.toolStripButtonNew.Size = new System.Drawing.Size(24, 22);
			this.toolStripButtonNew.Tag = "text";
			this.toolStripButtonNew.Text = "text";
			this.toolStripButtonNew.Click += new System.EventHandler(this.toolClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonUndo
			// 
			this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
			this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonUndo.Name = "toolStripButtonUndo";
			this.toolStripButtonUndo.Size = new System.Drawing.Size(24, 22);
			this.toolStripButtonUndo.Tag = "undo";
			this.toolStripButtonUndo.Text = "Undo";
			this.toolStripButtonUndo.Click += new System.EventHandler(this.toolClick);
			// 
			// toolStripButtonPointer
			// 
			this.toolStripButtonPointer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPointer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPointer.Image")));
			this.toolStripButtonPointer.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonPointer.Name = "toolStripButtonPointer";
			this.toolStripButtonPointer.Size = new System.Drawing.Size(24, 22);
			this.toolStripButtonPointer.Tag = "pointer";
			this.toolStripButtonPointer.Text = "Pointer";
			this.toolStripButtonPointer.Click += new System.EventHandler(this.toolClick);
			// 
			// toolStripButtonSave
			// 
			this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
			this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonSave.Name = "toolStripButtonSave";
			this.toolStripButtonSave.Size = new System.Drawing.Size(24, 22);
			this.toolStripButtonSave.Tag = "save";
			this.toolStripButtonSave.Text = "Save";
			this.toolStripButtonSave.Click += new System.EventHandler(this.toolClick);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(24, 22);
			this.toolStripButton3.Tag = "exit";
			this.toolStripButton3.Text = "exit";
			this.toolStripButton3.Click += new System.EventHandler(this.toolClick);
			// 
			// toolStripButton17
			// 
			this.toolStripButton17.AutoSize = false;
			this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
			this.toolStripButton17.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton17.Name = "toolStripButton17";
			this.toolStripButton17.Size = new System.Drawing.Size(45, 25);
			this.toolStripButton17.Tag = "complete";
			this.toolStripButton17.Text = "complete";
			this.toolStripButton17.Click += new System.EventHandler(this.toolClick);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.notifyIconContextMenu;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "notifyIcon";
			this.notifyIcon.Visible = true;
			// 
			// notifyIconContextMenu
			// 
			this.notifyIconContextMenu.Name = "notifyIconContextMenu";
			this.notifyIconContextMenu.Size = new System.Drawing.Size(61, 4);
			// 
			// QQForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(555, 399);
			this.Controls.Add(this.toolStripPanel);
			this.Controls.Add(this.myColorPicker);
			this.Controls.Add(this.drawArea);
			this.Controls.Add(this.toolStrip2);
			this.Controls.Add(this.menuStrip1);
			this.Name = "QQForm1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "QQForm1";
			this.Load += new System.EventHandler(this.QQForm1Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QQForm1KeyPress);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.toolStripPanel.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ContextMenuStrip notifyIconContextMenu;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.Panel toolStripPanel;
		private DrawTools.UserControls.MyColorPicker myColorPicker;
		private System.Windows.Forms.ToolStripButton toolStripButton17;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripButton toolStripButton16;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton toolStripButton15;
		private System.Windows.Forms.ToolStripButton toolStripButton14;
		private System.Windows.Forms.ToolStripButton toolStripButton13;
		private System.Windows.Forms.ToolStripButton toolStripButton12;
		private System.Windows.Forms.ToolStripButton toolStripButton11;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton toolStripButton10;
		private System.Windows.Forms.ToolStripButton toolStripButton9;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton toolStripButton8;
		private System.Windows.Forms.ToolStripButton toolStripButton7;
		private System.Windows.Forms.ToolStripButton toolStripButton6;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.SaveFileDialog saveCropFileDialog;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton rectangle;
		private DrawTools.DrawArea drawArea;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pencilToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pointerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem drawToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem moveToBackToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem moveToFrontToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem unselectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
		private System.Windows.Forms.ToolStripButton toolStripButtonLine;
		private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
		private System.Windows.Forms.ToolStripButton toolStripButtonPointer;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.ToolStripButton toolStripButtonNew;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
