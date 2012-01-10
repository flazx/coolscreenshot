/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/5
 * Time: 21:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DrawTools
{
	/// <summary>
	/// Description of DrawArrow.
	/// </summary>
	public class DrawArrow: DrawTools.DrawLine
	{
		public DrawArrow(int x1,int y1,int x2,int y2):base(x1,y1,x2,y2){}
		public override void Draw(System.Drawing.Graphics g)
		{
			 g.SmoothingMode = SmoothingMode.AntiAlias;

            //pen.EndCap = LineCap.ArrowAnchor;
            
            using(Pen p = new Pen(Color, PenWidth))
			using(GraphicsPath capPath = new GraphicsPath())
			{
			    // A triangle
			    //capPath.AddLine(-20, -20, 20, -20);
			    capPath.AddLine(-3, -3, 3, -3);
			    capPath.AddLine(-3, -3, 0, 0);
			    capPath.AddLine(0, 0, 3, -3);
			    
			    GraphicsPath capPath2 = new GraphicsPath();
			    capPath2.AddLine(-4, -8, 0, 0);
			    capPath2.AddLine(0, 0, 4, -8);
			
			    p.CustomEndCap = new System.Drawing.Drawing2D.CustomLineCap(
			    	null, capPath2);
			    
			    g.DrawLine(p, startPoint.X, startPoint.Y, endPoint.X, endPoint.Y);
			    
			    capPath2.Dispose();
			}
		}
	}
}
