using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

//AlphaBlendTextBox Tester
//2003 Bob Bradley / ZBobb@hotmail.com

namespace ABTestCS
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private ZBobb.AlphaBlendTextBox alphaBlendTextBox1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Button buttonColor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private ZBobb.AlphaBlendTextBox alphaBlendTextBox2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.alphaBlendTextBox1 = new ZBobb.AlphaBlendTextBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.buttonColor = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.alphaBlendTextBox2 = new ZBobb.AlphaBlendTextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.alphaBlendTextBox2);
			this.panel1.Location = new System.Drawing.Point(216, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(152, 192);
			this.panel1.TabIndex = 2;
			// 
			// alphaBlendTextBox1
			// 
			this.alphaBlendTextBox1.BackAlpha = 10;
			this.alphaBlendTextBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(255)));
			this.alphaBlendTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.alphaBlendTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.alphaBlendTextBox1.Location = new System.Drawing.Point(32, 16);
			this.alphaBlendTextBox1.Multiline = true;
			this.alphaBlendTextBox1.Name = "alphaBlendTextBox1";
			this.alphaBlendTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.alphaBlendTextBox1.Size = new System.Drawing.Size(176, 112);
			this.alphaBlendTextBox1.TabIndex = 9;
			this.alphaBlendTextBox1.Text = "This is a test of the AlphaBlendTextBox control.  Notice how you can see the back" +
				"ground behind these textboxes?  Change the options below to see how they look.";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(88, 144);
			this.trackBar1.Maximum = 255;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(112, 45);
			this.trackBar1.TabIndex = 5;
			this.trackBar1.TickFrequency = 15;
			this.trackBar1.Value = 20;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// buttonColor
			// 
			this.buttonColor.Location = new System.Drawing.Point(88, 192);
			this.buttonColor.Name = "buttonColor";
			this.buttonColor.Size = new System.Drawing.Size(56, 23);
			this.buttonColor.TabIndex = 6;
			this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "Alpha:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 192);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "Color:";
			// 
			// alphaBlendTextBox2
			// 
			this.alphaBlendTextBox2.BackAlpha = 10;
			this.alphaBlendTextBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.alphaBlendTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.alphaBlendTextBox2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.alphaBlendTextBox2.ForeColor = System.Drawing.Color.Yellow;
			this.alphaBlendTextBox2.Location = new System.Drawing.Point(8, 16);
			this.alphaBlendTextBox2.Multiline = true;
			this.alphaBlendTextBox2.Name = "alphaBlendTextBox2";
			this.alphaBlendTextBox2.Size = new System.Drawing.Size(128, 160);
			this.alphaBlendTextBox2.TabIndex = 0;
			this.alphaBlendTextBox2.Text = "Bob Bradley";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(384, 230);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonColor);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.alphaBlendTextBox1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Form1";
			this.Text = "AlphaBlendTextBox Tester";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void trackBar1_Scroll(object sender, System.EventArgs e)
		{
			alphaBlendTextBox2.BackAlpha = trackBar1.Value;
			alphaBlendTextBox1.BackAlpha = trackBar1.Value;

		}

		private void buttonColor_Click(object sender, System.EventArgs e)
		{
			ColorDialog c = new ColorDialog();

			c.Color = buttonColor.BackColor;
			if (c.ShowDialog() == DialogResult.OK)
			{
				buttonColor.BackColor = c.Color;
				alphaBlendTextBox1.BackColor = c.Color;
				alphaBlendTextBox2.BackColor = c.Color;
			}
			c.Dispose();
		}


	}
}
