/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/5
 * Time: 15:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Demo
{
	partial class TestTransparentUserControlForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestTransparentUserControlForm));
			this.transparentBGUserControl1 = new Demo.TransparentBGUserControl();
			this.SuspendLayout();
			// 
			// transparentBGUserControl1
			// 
			this.transparentBGUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.transparentBGUserControl1.Location = new System.Drawing.Point(76, 12);
			this.transparentBGUserControl1.Name = "transparentBGUserControl1";
			this.transparentBGUserControl1.Opacity = 1;
			this.transparentBGUserControl1.Size = new System.Drawing.Size(150, 150);
			this.transparentBGUserControl1.TabIndex = 0;
			// 
			// TestTransparentUserControlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.transparentBGUserControl1);
			this.Name = "TestTransparentUserControlForm";
			this.Text = "TestTransparentUserControlForm";
			this.ResumeLayout(false);
		}
		private Demo.TransparentBGUserControl transparentBGUserControl1;
	}
}
