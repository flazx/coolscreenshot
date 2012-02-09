using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CoolScreenShot.UserControls;

namespace CoolScreenShot
{
    public partial class SettingForm : Form
    {
        private Color[] colors;

        public SettingForm()
        {
            InitializeComponent();

            InitializeUIControls();
        }

        private void InitializeUIControls()
        {
            this.runCheckBox.CheckState = UtilHelps.HasAddToStart() ? CheckState.Checked : CheckState.Unchecked;

            for (int i = 8; i <= 20; i++)
            {
                this.textsizeComboBox.Items.Add(i);

                if (i == DrawTools.DrawSettings.DefaultTextSize)
                {
                    this.textsizeComboBox.SelectedItem = i;
                }
            }

            for (int i = 1; i <= 3; i++)
            {
                this.penWidthComboBox.Items.Add(i);

                if (i == DrawTools.DrawSettings.DefaultPenWidth)
                {
                    this.penWidthComboBox.SelectedItem = i;
                }
            }


            this.colors = new Color[]{
				Color.FromArgb(255,0,0,0),
				Color.FromArgb(255,128,0,0),
				Color.FromArgb(255,128,128,128),
				Color.FromArgb(255,128,128,0),
				Color.FromArgb(255,128,0,128),
				Color.FromArgb(255,0,128,0),
				Color.FromArgb(255,0,0,128),
				Color.FromArgb(255,0,128,128),
				
				Color.FromArgb(255,255,255,255),
				Color.FromArgb(255,192,192,192),
				Color.FromArgb(255,255,0,0),
				Color.FromArgb(255,255,255,0),
				Color.FromArgb(255,255,0,255),
				Color.FromArgb(255,0,255,0),
				Color.FromArgb(255,0,0,255),
				Color.FromArgb(255,0,255,255)
			};

            foreach (Color c in colors)
            {
                this.colorComboBox.Items.Add(c);

                if (c.ToArgb() == DrawTools.DrawSettings.DefaultColor.ToArgb())
                {
                    this.colorComboBox.SelectedItem = c;
                    this.colorComboBox.BackColor = c;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.runCheckBox.CheckState == CheckState.Checked)
                UtilHelps.AddWhenStart();
            else
                UtilHelps.RemoveWhenStart();

            DrawTools.DrawSettings.Quality = this.trackBar1.Value;
            DrawTools.DrawSettings.LastUsedColor = (Color)this.colorComboBox.SelectedItem;
            DrawTools.DrawSettings.LastUsedPenWidth = (int)this.penWidthComboBox.SelectedItem;
            DrawTools.DrawSettings.LastUsedTextSize = (int)this.textsizeComboBox.SelectedItem;

            DrawTools.DrawSettings.Save();

            this.Hide();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = this.trackBar1.Value.ToString();
        }

        private void colorComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {   
            string text = this.colorComboBox.Items[e.Index].ToString();
            Color color = (Color)this.colorComboBox.Items[e.Index];

            Brush brush = new SolidBrush(color);

            e.Graphics.FillRectangle(brush, e.Bounds);
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.colorComboBox.BackColor = (Color)colorComboBox.SelectedItem;
        }

        private void makeDefaultButton_Click(object sender, EventArgs e)
        {
            this.textsizeComboBox.SelectedItem = DrawTools.DrawSettings.LastUsedTextSize;
            this.colorComboBox.SelectedItem = DrawTools.DrawSettings.LastUsedColor;
            this.penWidthComboBox.SelectedItem = DrawTools.DrawSettings.LastUsedPenWidth;
        }
    }
}
