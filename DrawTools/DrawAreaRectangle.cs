using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;

namespace DrawTools
{
	/// <summary>
	/// Description of DrawAreaRectangle.
	/// </summary>
	public class DrawAreaRectangle: DrawRectangle
	{
		public DrawAreaRectangle(int x, int y, int width, int height) : base(x,y,width,height)
		{
			
		}
		
		 /// <summary>
        /// Draw rectangle
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.FromArgb(255,0,122,236), 1);

            g.DrawRectangle(pen, DrawRectangle.GetNormalizedRectangle(Rectangle));

            pen.Dispose();
        }
        
         /// <summary>
        /// Draw tracker for selected object
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTracker(Graphics g)
        {
        	SolidBrush brush = new SolidBrush(Color.FromArgb(255,0,122,236));

            for ( int i = 1; i <= HandleCount; i++ )
            {
                g.FillRectangle(brush, GetHandleRectangle(i));
            }

            brush.Dispose();
        }
        
         /// <summary>
        /// Get handle rectangle by 1-based number
        /// </summary>
        /// <param name="handleNumber"></param>
        /// <returns></returns>
        public override Rectangle GetHandleRectangle(int handleNumber)
        {
            Point point = GetHandle(handleNumber);

            return new Rectangle(point.X - 2, point.Y - 2, 4, 4);
        }
	}
}
