/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/5
 * Time: 16:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Demo
{
	partial class DrawImageForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.emptyUserControl1 = new Demo.EmptyUserControl();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(229, 242);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "draw image";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// emptyUserControl1
			// 
			this.emptyUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.emptyUserControl1.Location = new System.Drawing.Point(82, 31);
			this.emptyUserControl1.Name = "emptyUserControl1";
			this.emptyUserControl1.Size = new System.Drawing.Size(150, 150);
			this.emptyUserControl1.TabIndex = 1;
			// 
			// DrawImageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 350);
			this.Controls.Add(this.emptyUserControl1);
			this.Controls.Add(this.button1);
			this.Name = "DrawImageForm";
			this.Text = "DrawImageForm";
			this.ResumeLayout(false);
		}
		private Demo.EmptyUserControl emptyUserControl1;
		private System.Windows.Forms.Button button1;
	}
}
