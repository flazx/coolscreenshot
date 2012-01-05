/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/5
 * Time: 16:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo
{
	/// <summary>
	/// Description of DrawImageForm.
	/// </summary>
	public partial class DrawImageForm : Form
	{
		public DrawImageForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			this.DrawImagePara();
		}
		
		private void DrawImagePara()
		{
			
			Image OriginalIMG= Image.FromFile("Image.png");
  			Bitmap bmp = new Bitmap(100, 100);
			Graphics g = Graphics.FromImage(bmp);
			
			g.DrawImage(OriginalIMG, 0,0, new Rectangle(50,50,emptyUserControl1.Width,emptyUserControl1.Height), GraphicsUnit.Pixel);
			g.Save();
			g.Dispose();
			
			bmp.Save(@"c:\test1.png", System.Drawing.Imaging.ImageFormat.Png);
			
			this.emptyUserControl1.BackgroundImage = bmp;
		}
	}
}
