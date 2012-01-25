/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/5
 * Time: 23:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DrawTools
{
	/// <summary>
	/// Description of ToolText.
	/// </summary>
	public class ToolText: DrawTools.ToolObject
	{

		public ToolText()
		{
            Cursor = Cursors.IBeam;
		}

        public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
        {
        	DrawText drawText = new DrawText("", new Rectangle(new Point(e.X,e.Y), new Size(0,0)));
            AddNewObject(drawArea, drawText);
            drawArea.ToolTextBox.Text = "";
            drawArea.ToolTextBox.Visible = true;
            drawArea.ToolTextBox.Location = new Point(e.X, e.Y);
        }

        public override void OnMouseMove(DrawArea drawArea, MouseEventArgs e)
        {
            drawArea.Cursor = Cursor;

            if ( e.Button == MouseButtons.Left )
            {
                Point point = new Point(e.X, e.Y);
                drawArea.GraphicsList[0].MoveHandleTo(point, 1);
                drawArea.Refresh();
            }
        }
	}
}
