/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/5
 * Time: 22:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace DrawTools
{
	/// <summary>
	/// Description of DrawText.
	/// </summary>
	public class DrawText: DrawObject
	{
        private const string entryText = "Text";
        private PointF startPoint;
        private PointF endPoint;
        private bool isJustCreated;

        private String text;
        public String Text{
        	get{
        		return text;
        	}
        	set{
        		text = value;
        	}
        }
        
        public bool IsJustCreated{
        	get{
        		return isJustCreated;
        	}
        	set{
        		isJustCreated = value;
        	}
        }
        
        
		public DrawText() : this("", 0, 0)
		{
		}

        
        public DrawText(string text, int x, int y) : base()
        {
            this.text = text;
            this.startPoint.X = x;
            this.startPoint.Y = y;
            
            this.endPoint.Y = this.startPoint.Y;
            
            isJustCreated = true;
            Initialize();
        }

        /// <summary>
        /// Clone this instance
        /// </summary>
        public override DrawObject Clone()
        {
            DrawText drawText = new DrawText();
            drawText.text = this.text;
            drawText.startPoint = this.startPoint;

            FillDrawObjectFields(drawText);
            return drawText;
        }
        
        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);

            g.DrawString(this.text, new Font("Arial", 8),brush, startPoint.X, startPoint.Y);
            
            System.Diagnostics.Trace.WriteLine(String.Format("{0} -- {1}", startPoint.X, startPoint.Y));
            
            SizeF s = g.MeasureString(this.text,new Font("Arial", 8));
                                      
            this.endPoint.X = this.startPoint.X + s.Width;
            this.endPoint.Y = this.startPoint.Y;

            brush.Dispose();
        }
        
        public override int HandleCount
        {
            get
            {
                return 1;
            }
        }

        /// <summary>
        /// Get handle point by 1-based number
        /// </summary>
        /// <param name="handleNumber"></param>
        /// <returns></returns>
        public override Point GetHandle(int handleNumber)
        {
        	return new Point((int)startPoint.X, (int)startPoint.Y);
        }
        
        public override int HitTest(Point point)
        {
            if ( PointInObject(point) )
                return 0;

            return -1;
        }
        
        public override Cursor GetHandleCursor(int handleNumber)
        {
            switch ( handleNumber )
            {
            	case 0: case 1:
                    return Cursors.SizeAll;
                default:
                    return Cursors.Default;
            }
        }
        
		protected override bool PointInObject(Point point)
		{
			return new RectangleF(startPoint, new SizeF(endPoint.X - startPoint.X, 50))
				.Contains(point);
		}
        
         public override void MoveHandleTo(Point point, int handleNumber)
        {
            if ( handleNumber == 1 )
                startPoint = point;
        }
         
        public override void Move(int deltaX, int deltaY)
        {
            startPoint.X += deltaX;
            startPoint.Y += deltaY;
        }
	}
}
