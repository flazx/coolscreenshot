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
        private bool isJustCreated;

        Rectangle area;
        public Rectangle Area { get { return this.area; } set { this.area = value; } }

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
        
        
		public DrawText() : this("", new Rectangle())
		{
		}

        
        public DrawText(string text, Rectangle area) : base()
        {
            this.text = text;
            this.area = area;
            
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
            drawText.area = this.area;

            FillDrawObjectFields(drawText);
            return drawText;
        }
        
        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);

            g.DrawString(this.text, new Font("Arial", 8),brush, this.area);

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
            return new Point((int)this.area.Location.X, (int)this.area.Location.Y);
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
			return this.area.Contains(point);
		}
        
         public override void MoveHandleTo(Point point, int handleNumber)
        {
            if ( handleNumber == 1 )
                this.area.Location = point;
        }
         
        public override void Move(int deltaX, int deltaY)
        {
            this.area.Location = new Point(this.area.Location.X + deltaX, this.area.Location.Y + deltaY);
        }
	}
}
