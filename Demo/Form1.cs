/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/5
 * Time: 9:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Demo
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1(){
			InitializeComponent();
		}
		
		Point startPos;      // mouse-down position
	    Point currentPos;    // current mouse position
	    bool drawing;        // busy drawing
	    List<Rectangle> rectangles = new List<Rectangle>();  // previous rectangles
	
	    private Rectangle getRectangle() {
	        return new Rectangle(
	            Math.Min(startPos.X, currentPos.X),
	            Math.Min(startPos.Y, currentPos.Y),
	            Math.Abs(startPos.X - currentPos.X),
	            Math.Abs(startPos.Y - currentPos.Y));
	    }
	
	    private void canevas_MouseDown(object sender, MouseEventArgs e) {
	        currentPos = startPos = e.Location;
	        drawing = true;
	    }
	
	    private void canevas_MouseMove(object sender, MouseEventArgs e) {
	        currentPos = e.Location;
	        if (drawing) this.Invalidate();
	    }
	
	    private void canevas_MouseUp(object sender, MouseEventArgs e) {
	        if (drawing) {
	            drawing = false;
	            var rc = getRectangle();
	            if (rc.Width > 0 && rc.Height > 0) rectangles.Add(rc);
	            this.Invalidate();
	        }
	    }
	
	    private void canevas_Paint(object sender, PaintEventArgs e) {
	        if (rectangles.Count > 0) e.Graphics.DrawRectangles(Pens.Black, rectangles.ToArray());
	        if (drawing) e.Graphics.DrawRectangle(Pens.Red, getRectangle());
	    }
		
		void Form1Load(object sender, EventArgs e)
		{
			InitializeComponent();
		}
	}
}
