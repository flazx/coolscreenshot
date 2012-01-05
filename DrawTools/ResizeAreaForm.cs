/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/5
 * Time: 11:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrawTools
{
	/// <summary>
	/// Description of ResizeAreaForm.
	/// </summary>
	public partial class ResizeAreaForm : Form
	{
		public ResizeAreaForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private Graphics g;
		
		void ResizeAreaFormLoad(object sender, EventArgs e)
		{
			this.SetStyle(
				ControlStyles.AllPaintingInWmPaint |
				ControlStyles.UserPaint |
				ControlStyles.DoubleBuffer,true);
			
			g = this.CreateGraphics();
			
			drawRect = new DrawRectangle(100,100,100,100);
			drawRect.Draw(g);
			drawRect.Selected = true;
		}
		
		
		Point lastPoint;
		bool wasMove;
		DrawRectangle drawRect;
		private int resizedObjectHandle;
		
		protected override void OnMouseMove(MouseEventArgs e)
		{
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
                drawRect.MoveHandleTo(point, resizedObjectHandle);
                this.Refresh();
            }
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			if(this.drawRect != null){
				drawRect.Draw(e.Graphics);
				drawRect.Selected = true;
				drawRect.DrawTracker(e.Graphics);
			}
			
			base.OnPaint(e);
		}
	}
}
