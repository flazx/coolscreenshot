/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/7
 * Time: 23:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Demo.MyControls
{
	/// <summary>
	/// Description of ColorItemButton.
	/// </summary>
	public class ColorItemButton: Button
	{
		
		public ColorItemButton()
		{
			base.FlatStyle = FlatStyle.Flat;
			base.FlatAppearance.BorderSize = 1;
			base.FlatAppearance.BorderColor = Color.Black;
			base.Size = new System.Drawing.Size(12, 12);
			base.Text = "";
		}
		
		protected override void OnMouseHover(EventArgs e)
		{
			base.FlatAppearance.BorderSize = 1;
			base.FlatAppearance.BorderColor = Color.White;
			
			base.OnMouseHover(e);
		}
		
		protected override void OnMouseLeave(EventArgs e)
		{
			base.FlatAppearance.BorderSize = 1;
			base.FlatAppearance.BorderColor = Color.Black;
			
			base.OnMouseLeave(e);
		}
	}
}
