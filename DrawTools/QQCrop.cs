/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/3
 * Time: 22:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace DrawTools
{
	/// <summary>
	/// Description of QQCrop.
	/// </summary>
	public partial class QQCrop : Form
	{
		public QQCrop()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			g = this.CreateGraphics();
			
			//this.FormBorderStyle = FormBorderStyle.None;
			
			//this.LayerOpacity = 1;
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private Graphics g;
		
		void QQCropLoad(object sender, EventArgs e)
		{
			this.SetStyle(
				ControlStyles.AllPaintingInWmPaint |
				ControlStyles.UserPaint |
				ControlStyles.DoubleBuffer,true);
			
			darwRect = new DrawRectangle(100,100,100,100);
			darwRect.Draw(g);
			darwRect.Selected = true;
			darwRect.DrawTracker(g);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			g = this.CreateGraphics();
			Pen pen = new Pen(Color.Red, 1);
	        SolidBrush brush = new SolidBrush(Color.FromArgb(255, 255, 192));
	        g.DrawRectangle(pen, new Rectangle(0,0,200,200));
		}
		
		void Button2Click(object sender, EventArgs ee)
		{
			Graphics e = this.CreateGraphics();
			//SolidBrush brush = new SolidBrush(Color.FromArgb(128, 255, 255, 255));
			//e.FillRectangle(brush,this.ClientRectangle);
			
			//Bitmap bitmap = new Bitmap("winter.jpg");
		    //TextureBrush brush = new TextureBrush(bitmap);
		    //e.Graphics.FillRectangle(brush, ClientRectangle);
            //bitmap.Dispose();

		    Color color = Color.Yellow;
		    int penWidth = 80;
		    Pen opaquePen = new Pen(color, penWidth);
		    e.DrawLine(opaquePen, 0, 50, 200, 20);
	        opaquePen.Dispose();
	
	    	Color semiTransparentColor = Color.FromArgb(128, color.R, color.G, color.B);
	    	Pen semiTransparentPen = new Pen(semiTransparentColor, penWidth);
	    	e.DrawLine(semiTransparentPen, 0, 200, 200, 140);
	        semiTransparentPen.Dispose();
	
	    	Color veryTransparentColor = Color.FromArgb(77, color.R, color.G, color.B);
	    	Pen veryTransparentPen = new Pen(veryTransparentColor, penWidth);
	    	e.DrawLine(veryTransparentPen, 0, 350, 200, 260);
	        veryTransparentPen.Dispose();
	  
	    	Brush transparentBrush = new SolidBrush(semiTransparentColor);
	    	e.DrawString("www.java2s.com", new Font("Verdana", 36, FontStyle.Bold),
	      	transparentBrush, 80, 150);
		}
		
		
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			if (DesignMode)
			{
				base.OnPaintBackground(pevent);

				return;
			}
			
			base.OnPaintBackground(pevent);

			// Eat event to prevent rendering error when WM_PAINT message 
			// is sent.
		}
		
		protected override void OnSizeChanged(EventArgs e)
		{
			//this.PaintLayeredWindow();
			base.OnSizeChanged(e);
			this.Refresh();
		}
		
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
		}
		
		
		
		#region Event
		
		
		Point lastPoint;
		DrawRectangle darwRect;
		private int resizedObjectHandle;
		
		protected override void OnMouseMove(MouseEventArgs e)
		{
			Point point = new Point(e.X, e.Y);
            Point oldPoint = lastPoint;

            // set cursor when mouse button is not pressed
            if (e.Button == MouseButtons.None)
            {
                Cursor cursor = null;
                int n = darwRect.HitTest(point);
                resizedObjectHandle = n;
                if(n > 0){
                	cursor = darwRect.GetHandleCursor(n);
                }

                if (cursor == null)
                    cursor = Cursors.Default;
                
                this.Cursor = cursor;
            }
            
            
            if (e.Button != MouseButtons.Left)
                return;

            /// Left button is pressed

            // Find difference between previous and current position
            int dx = e.X - lastPoint.X;
            int dy = e.Y - lastPoint.Y;

            lastPoint.X = e.X;
            lastPoint.Y = e.Y;

            // resize
            if (darwRect != null)
            {
                darwRect.MoveHandleTo(point, resizedObjectHandle);
                this.Refresh();
            }
		}
		
		
	
		
		void Button3Click(object sender, EventArgs e)
		{
			darwRect.DrawTracker(g);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			this.Refresh();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			this.label1.CreateGraphics().Clear(Color.White);
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			if(this.darwRect != null){
				darwRect.Draw(e.Graphics);
				darwRect.Selected = true;
			}
			
			base.OnPaint(e);
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			//Trace.WriteLine("log !!!");
		}
	}
		
		#endregion
	
}
