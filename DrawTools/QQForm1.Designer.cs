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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QQForm1));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonNew = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonPointer = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRectangle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonPencil = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
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
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripButtonNew,
									this.toolStripButtonOpen,
									this.toolStripButtonSave,
									this.toolStripSeparator1,
									this.toolStripButtonPointer,
									this.toolStripButtonRectangle,
									this.toolStripButtonEllipse,
									this.toolStripButtonLine,
									this.toolStripButtonPencil,
									this.toolStripSeparator2,
									this.toolStripButtonUndo,
									this.toolStripButtonRedo,
									this.toolStripSeparator3,
									this.toolStripButtonAbout});
			this.toolStrip1.Location = new System.Drawing.Point(38, 174);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(285, 27);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStrip1.Visible = false;
			// 
			// toolStripButtonNew
			// 
			this.toolStripButtonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNew.Image")));
			this.toolStripButtonNew.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonNew.Name = "toolStripButtonNew";
			this.toolStripButtonNew.Size = new System.Drawing.Size(24, 24);
			this.toolStripButtonNew.Text = "New";
			// 
			// toolStripButtonOpen
			// 
			this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
			this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonOpen.Name = "toolStripButtonOpen";
			this.toolStripButtonOpen.Size = new System.Drawing.Size(24, 24);
			this.toolStripButtonOpen.Text = "Open";
			// 
			// toolStripButtonSave
			// 
			this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
			this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonSave.Name = "toolStripButtonSave";
			this.toolStripButtonSave.Size = new System.Drawing.Size(24, 24);
			this.toolStripButtonSave.Text = "Save";
			this.toolStripButtonSave.Click += new System.EventHandler(this.ToolStripButtonSaveClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripButtonPointer
			// 
			this.toolStripButtonPointer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPointer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPointer.Image")));
			this.toolStripButtonPointer.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonPointer.Name = "toolStripButtonPointer";
			this.toolStripButtonPointer.Size = new System.Drawing.Size(24, 24);
			this.toolStripButtonPointer.Text = "Pointer";
			this.toolStripButtonPointer.Click += new System.EventHandler(this.toolStripButtonPointer_Click);
			// 
			// toolStripButtonRectangle
			// 
			this.toolStripButtonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRectangle.Image")));
			this.toolStripButtonRectangle.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonRectangle.Name = "toolStripButtonRectangle";
			this.toolStripButtonRectangle.Size = new System.Drawing.Size(24, 24);
			this.toolStripButtonRectangle.Text = "Rectangle";
			this.toolStripButtonRectangle.Click += new System.EventHandler(this.toolStripButtonRectangle_Click);
			// 
			// toolStripButtonEllipse
			// 
			this.toolStripButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEllipse.Image")));
			this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
			this.toolStripButtonEllipse.Size = new System.Drawing.Size(24, 24);
			this.toolStripButtonEllipse.Text = "Ellipse";
			this.toolStripButtonEllipse.Click += new System.EventHandler(this.toolStripButtonEllipse_Click);
			// 
			// toolStripButtonLine
			// 
			this.toolStripButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonLine.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLine.Image")));
			this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonLine.Name = "toolStripButtonLine";
			this.toolStripButtonLine.Size = new System.Drawing.Size(24, 24);
			this.toolStripButtonLine.Text = "Line";
			this.toolStripButtonLine.Click += new System.EventHandler(this.toolStripButtonLine_Click);
			// 
			// toolStripButtonPencil
			// 
			this.toolStripButtonPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPencil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPencil.Image")));
			this.toolStripButtonPencil.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonPencil.Name = "toolStripButtonPencil";
			this.toolStripButtonPencil.Size = new System.Drawing.Size(24, 24);
			this.toolStripButtonPencil.Text = "Pencil";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripButtonUndo
			// 
			this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
			this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonUndo.Name = "toolStripButtonUndo";
			this.toolStripButtonUndo.Size = new System.Drawing.Size(24, 24);
			this.toolStripButtonUndo.Text = "Undo";
			this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
			// 
			// toolStripButtonRedo
			// 
			this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
			this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonRedo.Name = "toolStripButtonRedo";
			this.toolStripButtonRedo.Size = new System.Drawing.Size(24, 24);
			this.toolStripButtonRedo.Text = "Redo";
			this.toolStripButtonRedo.Click += new System.EventHandler(this.toolStripButtonRedo_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripButtonAbout
			// 
			this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
			this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Silver;
			this.toolStripButtonAbout.Name = "toolStripButtonAbout";
			this.toolStripButtonAbout.Size = new System.Drawing.Size(24, 24);
			this.toolStripButtonAbout.Text = "About";
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
			this.menuStrip1.Size = new System.Drawing.Size(375, 25);
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
			this.newToolStripMenuItem.Text = "New";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.openToolStripMenuItem.Text = "Open";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
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
			this.selectAllToolStripMenuItem.Text = "Select All";
			// 
			// unselectAllToolStripMenuItem
			// 
			this.unselectAllToolStripMenuItem.Name = "unselectAllToolStripMenuItem";
			this.unselectAllToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.unselectAllToolStripMenuItem.Text = "Unselect All";
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.deleteToolStripMenuItem.Text = "Delete";
			// 
			// deleteAllToolStripMenuItem
			// 
			this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
			this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
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
			this.moveToFrontToolStripMenuItem.Text = "Move to Front";
			// 
			// moveToBackToolStripMenuItem
			// 
			this.moveToBackToolStripMenuItem.Name = "moveToBackToolStripMenuItem";
			this.moveToBackToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.moveToBackToolStripMenuItem.Text = "Move to Back";
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
			this.undoToolStripMenuItem.Text = "Undo";
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
			this.redoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.redoToolStripMenuItem.Text = "Redo";
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
			this.propertiesToolStripMenuItem.Text = "Properties";
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
			this.pointerToolStripMenuItem.Text = "Pointer";
			// 
			// rectangleToolStripMenuItem
			// 
			this.rectangleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rectangleToolStripMenuItem.Image")));
			this.rectangleToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
			this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.rectangleToolStripMenuItem.Text = "Rectangle";
			// 
			// ellipseToolStripMenuItem
			// 
			this.ellipseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ellipseToolStripMenuItem.Image")));
			this.ellipseToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
			this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.ellipseToolStripMenuItem.Text = "Ellipse";
			// 
			// lineToolStripMenuItem
			// 
			this.lineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lineToolStripMenuItem.Image")));
			this.lineToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
			this.lineToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.lineToolStripMenuItem.Text = "Line";
			// 
			// pencilToolStripMenuItem
			// 
			this.pencilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pencilToolStripMenuItem.Image")));
			this.pencilToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Silver;
			this.pencilToolStripMenuItem.Name = "pencilToolStripMenuItem";
			this.pencilToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
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
			this.drawArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
			// toolStrip2
			// 
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(375, 25);
			this.toolStrip2.TabIndex = 5;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// QQForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(375, 326);
			this.Controls.Add(this.toolStrip2);
			this.Controls.Add(this.drawArea);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Name = "QQForm1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "QQForm1";
			this.Load += new System.EventHandler(this.QQForm1Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QQForm1KeyPress);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStrip toolStrip2;
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
		private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
		private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton toolStripButtonPencil;
		private System.Windows.Forms.ToolStripButton toolStripButtonLine;
		private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
		private System.Windows.Forms.ToolStripButton toolStripButtonRectangle;
		private System.Windows.Forms.ToolStripButton toolStripButtonPointer;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
		private System.Windows.Forms.ToolStripButton toolStripButtonNew;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
