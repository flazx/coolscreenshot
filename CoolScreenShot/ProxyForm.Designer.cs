/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/10
 * Time: 10:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CoolScreenShot
{
	partial class ProxyForm
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
			this.asdf = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// asdf
			// 
			this.asdf.Location = new System.Drawing.Point(80, 45);
			this.asdf.Name = "asdf";
			this.asdf.Size = new System.Drawing.Size(100, 23);
			this.asdf.TabIndex = 0;
			this.asdf.Text = "HOTKEY TEST!";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.asdf);
			this.Name = "Form1";
			this.Text = "Form1";;
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label asdf;
	}
}
