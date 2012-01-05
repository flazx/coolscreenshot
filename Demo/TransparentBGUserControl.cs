/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/5
 * Time: 15:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Demo
{
	/// <summary>
	/// Description of TransparentBGUserControl.
	/// </summary>
	public partial class TransparentBGUserControl : UserControl
	{
		public TransparentBGUserControl()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
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
 
        private int opacity;
 
        public int Opacity
        {
            get { return opacity; }
            set {
                opacity = value;
                this.InvalidateEx();
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
	}
}
