/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/5
 * Time: 15:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DrawTools
{
	/// <summary>
	/// Description of UserControl1.
	/// </summary>
	public partial class UserControl1 : UserControl
	{
		public UserControl1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			 SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		#region Transparent BG
        private int opacity;
 
        public int Opacity
        {
            get { return opacity; }
            set {
                opacity = value;
                this.InvalidateEx();
            }
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020;//WS_EX_TRANSPARENT
                return cp;
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Color bk = Color.FromArgb(Opacity, this.BackColor);
            e.Graphics.FillRectangle(new SolidBrush(bk), e.ClipRectangle);
        }
 
        protected void InvalidateEx()
        {
            if (Parent == null)
                return;
            Rectangle rc = new Rectangle(this.Location, this.Size);
            Parent.Invalidate(rc, true);
        }
        #endregion
	}
}
