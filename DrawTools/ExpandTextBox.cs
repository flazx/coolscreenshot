using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DrawTools
{
    public class ExpandTextBox : TextBox
    {
        public ExpandTextBox()
            : base()
        {
            this.Multiline = true;
        }

        protected override void OnTextChanged(EventArgs e)
        {
           Size sz = new Size(this.ClientSize.Width, int.MaxValue);
            TextFormatFlags flags = TextFormatFlags.WordBreak;
            int borders = this.Height - this.ClientSize.Height;
            int borderW = this.Width - this.ClientSize.Width;
            sz = TextRenderer.MeasureText(this.Text, this.Font, sz, flags);

            int h = sz.Height + borders + 20;
            int w = sz.Width + borderW + 20;

            if (w + this.Left > this.Parent.Width)
            {
                w = this.Parent.Width - this.Left;
            }

            if (h + this.Top> this.Parent.Height)
            {
                h = this.Parent.Height - this.Top;
            }

            this.Height = h;
            this.Width = w;

            base.OnTextChanged(e);
        }
    }
}