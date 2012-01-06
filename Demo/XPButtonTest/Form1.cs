using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Resources;
using System.Reflection;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

using PinkieControls;

namespace TestsApplication
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : PinkieControls.FormEx
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private int iStyle = 0;
		private int iPicture = 0;
		private int iEnabled = 0;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;

		/*private static Image image1;
		private static Image image2;
		private static Image image3;*/

		private static LinearGradientBrush brush0;
		private static SolidBrush brush1;
		private static Pen pen;
		private System.Windows.Forms.Label label6;
		private PinkieControls.ButtonXP buttonExit;
		private PinkieControls.ButtonXP buttonStyle;
		private PinkieControls.ButtonXP buttonPicture;
		private PinkieControls.ButtonXP buttonEnabled;
		private PinkieControls.ButtonXP buttonXP1;
		private PinkieControls.ButtonXP buttonXP2;
		private PinkieControls.ButtonXP buttonXP3;
		private System.Windows.Forms.TextBox textBox1;



		static ResourceManager rm;

		public Form1()
		{
			rm = new ResourceManager("TestApp.Images", Assembly.GetCallingAssembly());
			InitializeComponent();

			this.buttonXP3 = new PinkieControls.ButtonXP();
			this.buttonXP3.Image = GetImage("Save2");
			this.buttonXP3.Text = @"Save";
			this.buttonXP3.Location = new System.Drawing.Point(152, 144);
			this.buttonXP3.Name = "buttonXP3";
			this.buttonXP3.Scheme = PinkieControls.ButtonXP.Schemes.Silver;
			this.buttonXP3.Size = new System.Drawing.Size(112, 26);
			this.buttonXP3.TabIndex = 6;
			this.buttonXP3.Click += new System.EventHandler(this.buttonXP3Click);
			this.Controls.Add(buttonXP3);

			this.Icon = GetIcon("Icon");
			this.CenterToScreen();
		}

		public static Bitmap GetImage(string bmName)
		{
			return (Bitmap)rm.GetObject(bmName);
		}

		public static Icon GetIcon(string bmName)
		{
			return (Icon)rm.GetObject(bmName);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				brush0.Dispose();
				brush1.Dispose();
				pen.Dispose();
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonExit = new PinkieControls.ButtonXP();
			this.buttonStyle = new PinkieControls.ButtonXP();
			this.buttonPicture = new PinkieControls.ButtonXP();
			this.buttonEnabled = new PinkieControls.ButtonXP();
			this.buttonXP1 = new PinkieControls.ButtonXP();
			this.buttonXP2 = new PinkieControls.ButtonXP();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 168);
			this.label2.Name = "label2";
			this.label2.TabIndex = 10;
			this.label2.Text = "Picture Property";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 216);
			this.label3.Name = "label3";
			this.label3.TabIndex = 11;
			this.label3.Text = "Enabled Property";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(136, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(136, 48);
			this.label4.TabIndex = 14;
			this.label4.Text = "Selected color scheme: Blue, Olive Green and Silver";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(136, 184);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 15;
			this.label5.Text = "Information:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 120);
			this.label1.Name = "label1";
			this.label1.TabIndex = 9;
			this.label1.Text = "Scheme Property";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(136, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(136, 48);
			this.label6.TabIndex = 18;
			this.label6.Text = "Selected color scheme: Blue, Olive Green and Silver";
			// 
			// buttonExit
			// 
			this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(236)), ((System.Byte)(233)), ((System.Byte)(216)));
			this.buttonExit.DefaultScheme = true;
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.None;
			this.buttonExit.Hint = "";
			this.buttonExit.Location = new System.Drawing.Point(224, 280);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
			this.buttonExit.Size = new System.Drawing.Size(72, 23);
			this.buttonExit.TabIndex = 7;
			this.buttonExit.Text = "E&xit";
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonStyle
			// 
			this.buttonStyle.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(236)), ((System.Byte)(233)), ((System.Byte)(216)));
			this.buttonStyle.DefaultScheme = true;
			this.buttonStyle.DialogResult = System.Windows.Forms.DialogResult.None;
			this.buttonStyle.Hint = "";
			this.buttonStyle.Location = new System.Drawing.Point(16, 136);
			this.buttonStyle.Name = "buttonStyle";
			this.buttonStyle.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
			this.buttonStyle.Size = new System.Drawing.Size(100, 24);
			this.buttonStyle.TabIndex = 1;
			this.buttonStyle.Text = "&Mixed ->";
			this.buttonStyle.Click += new System.EventHandler(this.buttonStyle_Click);
			// 
			// buttonPicture
			// 
			this.buttonPicture.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(236)), ((System.Byte)(233)), ((System.Byte)(216)));
			this.buttonPicture.DefaultScheme = true;
			this.buttonPicture.DialogResult = System.Windows.Forms.DialogResult.None;
			this.buttonPicture.Hint = "";
			this.buttonPicture.Location = new System.Drawing.Point(16, 184);
			this.buttonPicture.Name = "buttonPicture";
			this.buttonPicture.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
			this.buttonPicture.Size = new System.Drawing.Size(100, 24);
			this.buttonPicture.TabIndex = 2;
			this.buttonPicture.Text = "Hide Picture";
			this.buttonPicture.Click += new System.EventHandler(this.buttonPicture_Click);
			// 
			// buttonEnabled
			// 
			this.buttonEnabled.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(236)), ((System.Byte)(233)), ((System.Byte)(216)));
			this.buttonEnabled.DefaultScheme = true;
			this.buttonEnabled.DialogResult = System.Windows.Forms.DialogResult.None;
			this.buttonEnabled.Hint = "";
			this.buttonEnabled.Location = new System.Drawing.Point(16, 232);
			this.buttonEnabled.Name = "buttonEnabled";
			this.buttonEnabled.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
			this.buttonEnabled.Size = new System.Drawing.Size(100, 24);
			this.buttonEnabled.TabIndex = 3;
			this.buttonEnabled.Text = "Disable Buttons";
			this.buttonEnabled.Click += new System.EventHandler(this.buttonEnabled_Click);
			// 
			// buttonXP1
			// 
			this.buttonXP1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(236)), ((System.Byte)(233)), ((System.Byte)(216)));
			this.buttonXP1.DefaultScheme = false;
			this.buttonXP1.DialogResult = System.Windows.Forms.DialogResult.None;
			this.buttonXP1.Hint = "";
			this.buttonXP1.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonXP1.Image")));
			this.buttonXP1.Location = new System.Drawing.Point(152, 64);
			this.buttonXP1.Name = "buttonXP1";
			this.buttonXP1.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
			this.buttonXP1.Size = new System.Drawing.Size(112, 26);
			this.buttonXP1.TabIndex = 4;
			this.buttonXP1.Text = "Save";
			this.buttonXP1.Click += new System.EventHandler(this.buttonXP1_Click);
			// 
			// buttonXP2
			// 
			this.buttonXP2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(236)), ((System.Byte)(233)), ((System.Byte)(216)));
			this.buttonXP2.DefaultScheme = false;
			this.buttonXP2.DialogResult = System.Windows.Forms.DialogResult.None;
			this.buttonXP2.Hint = "";
			this.buttonXP2.Image = ((System.Drawing.Bitmap)(resources.GetObject("buttonXP2.Image")));
			this.buttonXP2.Location = new System.Drawing.Point(152, 104);
			this.buttonXP2.Name = "buttonXP2";
			this.buttonXP2.Scheme = PinkieControls.ButtonXP.Schemes.OliveGreen;
			this.buttonXP2.Size = new System.Drawing.Size(112, 26);
			this.buttonXP2.TabIndex = 5;
			this.buttonXP2.Text = "Paste";
			this.buttonXP2.Click += new System.EventHandler(this.buttonXP2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 88);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 20;
			this.textBox1.Text = "";
			// 
			// Form1
			// 
			this.AcceptButton = this.buttonStyle;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(306, 319);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.buttonEnabled,
																		  this.buttonPicture,
																		  this.buttonStyle,
																		  this.buttonExit,
																		  this.textBox1,
																		  this.buttonXP2,
																		  this.buttonXP1,
																		  this.label6,
																		  this.label5,
																		  this.label3,
																		  this.label2,
																		  this.label1});
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Test Form";
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

		private void buttonStyle_Click(object sender, System.EventArgs e)
		{
			switch(iStyle)
			{
				case 0:
					this.buttonStyle.Text = @"&Blue ->";
					this.label4.Text = @"Selected color scheme: Blue";

					if (this.buttonXP1.Image != null)
					{
						this.buttonXP1.Image = GetImage("Save0");
						this.buttonXP2.Image = GetImage("Paste0");
						this.buttonXP3.Image = GetImage("Save2");
					}
					this.buttonXP1.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
					this.buttonXP2.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
					this.buttonXP3.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
					this.Invalidate();
					iStyle++;
					break;

				case 1:
					this.label4.Text = @"Selected color scheme: Olive Green";
					this.buttonStyle.Text = @"&Olive Green ->";

					if (this.buttonXP1.Image != null)
					{
						this.buttonXP1.Image = GetImage("Save0");
						this.buttonXP2.Image = GetImage("Paste1");
						this.buttonXP3.Image = GetImage("Save2");
					}
					this.buttonXP1.Scheme = PinkieControls.ButtonXP.Schemes.OliveGreen;
					this.buttonXP2.Scheme = PinkieControls.ButtonXP.Schemes.OliveGreen;
					this.buttonXP3.Scheme = PinkieControls.ButtonXP.Schemes.OliveGreen;
					this.Invalidate();
					iStyle++;
					break;

				case 2:
					this.label4.Text = @"Selected color scheme: Silver";
					this.buttonStyle.Text = @"&Silver ->";

					if (this.buttonXP1.Image != null)
					{
						this.buttonXP1.Image = GetImage("Save0");
						this.buttonXP2.Image = GetImage("Paste2");
						this.buttonXP3.Image = GetImage("Save2");
					}
					this.buttonXP1.Scheme = PinkieControls.ButtonXP.Schemes.Silver;
					this.buttonXP2.Scheme = PinkieControls.ButtonXP.Schemes.Silver;
					this.buttonXP3.Scheme = PinkieControls.ButtonXP.Schemes.Silver;
					this.Invalidate();
					iStyle++;
					break;

				case 3:
					this.label4.Text = @"Selected color scheme: Blue, Olive Green and Silver";
					this.buttonStyle.Text = @"&Mixed ->";

					if (this.buttonXP1.Image != null)
					{
						this.buttonXP1.Image = GetImage("Save0");
						this.buttonXP2.Image = GetImage("Paste1");
						this.buttonXP3.Image = GetImage("Save2");
					}
					this.buttonXP1.Scheme = PinkieControls.ButtonXP.Schemes.Blue;
					this.buttonXP2.Scheme = PinkieControls.ButtonXP.Schemes.OliveGreen;
					this.buttonXP3.Scheme = PinkieControls.ButtonXP.Schemes.Silver;
					this.Invalidate();
					iStyle = 0;
					break;
			}
		}

		private void buttonPicture_Click(object sender, System.EventArgs e)
		{

			switch(iPicture)
			{
				case 0:
					this.buttonPicture.Text = @"Show Picture";
					/*image1 = this.buttonXP1.Image; 
					image2 = this.buttonXP2.Image; 
					image3 = this.buttonXP3.Image;*/
					this.buttonXP1.Image = null;
					this.buttonXP2.Image = null;
					this.buttonXP3.Image = null;
					iPicture++;
					break;

				case 1:
					this.buttonPicture.Text = @"Hide Picture";
				switch (iStyle)
				{
					case 1:
						this.buttonXP1.Image = GetImage("Save0");
						this.buttonXP2.Image = GetImage("Paste0");
						this.buttonXP3.Image = GetImage("Save2");
						break;

					case 3:
						this.buttonXP1.Image = GetImage("Save0");
						this.buttonXP2.Image = GetImage("Paste2");
						this.buttonXP3.Image = GetImage("Save2");
						break;

					case 0:
					case 2:
						this.buttonXP1.Image = GetImage("Save0");
						this.buttonXP2.Image = GetImage("Paste1");
						this.buttonXP3.Image = GetImage("Save2");
						break;
				}
					/*this.buttonXP1.Image = image1;
					this.buttonXP2.Image = image2;
					this.buttonXP3.Image = image3;*/
					iPicture = 0;
					break;
			}
		}

		private void buttonEnabled_Click(object sender, System.EventArgs e)
		{
			switch(iEnabled)
			{
				case 0:
					this.buttonEnabled.Text = @"Enable Buttons";
					this.buttonXP1.Enabled = false;
					this.buttonXP2.Enabled = false;
					this.buttonXP3.Enabled = false;
					iEnabled++;
					break;

				case 1:
					this.buttonEnabled.Text = @"Disable Buttons";
					this.buttonXP1.Enabled = true;
					this.buttonXP2.Enabled = true;
					this.buttonXP3.Enabled = true;
					iEnabled = 0;
					break;
			}
		}

		private void buttonExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			PointF[] points = {	  new Point(132, 40),
								  new Point(300, 40),
								  new Point(300, 260),
								  new Point(131, 260),
								  new Point(131, 39)};

			if (pen != null) pen.Dispose();
			if (brush0 != null) brush0.Dispose();
			if (brush1 != null) brush0.Dispose();
		
			switch (iStyle)
			{
				case 3:
					pen = new Pen(Color.FromArgb(102, 102, 126), 2); 
					brush1 = new SolidBrush(Color.FromArgb(102, 102, 126));
					brush0 = new LinearGradientBrush(new Rectangle(132, 40, 168, 220), Color.FromArgb(242, 241, 243), Color.FromArgb(204, 206, 210), 90.0f); 
					break;

				case 1:
					pen = new Pen(Color.FromArgb(0, 60, 116), 2); 
					brush1 = new SolidBrush(Color.FromArgb(0, 60, 116));
					brush0 = new LinearGradientBrush(new Rectangle(132, 40, 168, 220), Color.FromArgb(244, 243, 238), Color.FromArgb(213, 208, 238), 90.0f); 
					break;

				case 0:
					//break;
				case 2:
					//break;
					pen = new Pen(Color.FromArgb(128, 128, 64), 2); 
					brush1 = new SolidBrush(Color.FromArgb(128, 128, 64));
					brush0 = new LinearGradientBrush(new Rectangle(132, 40, 168, 220), Color.FromArgb(236, 233, 216), Color.FromArgb(220, 215, 184), 90.0f); 
					break;
			}

			float[] relativeIntensities = {0.0f, 0.3f, 1.0f};
			float[] relativePositions   = {0.0f, 0.7f, 1.0f};

			Blend blend = new Blend();
			blend.Factors = relativeIntensities;
			blend.Positions = relativePositions;
			brush0.Blend = blend;


			e.Graphics.FillRectangle(brush0, 132, 40, 168, 220);
			e.Graphics.DrawLines(pen, points);

			String text0 = @"XP-Style Button";
			Font font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold, GraphicsUnit.Point);
			StringFormat format = new StringFormat();
			format.FormatFlags = StringFormatFlags.DirectionVertical;
			e.Graphics.DrawString(text0, font, brush1, 274.0f, 104.0f, format);
		}


		private void buttonXP1_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("First button pressed") ;
		}

		private void buttonXP2_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Second button pressed") ;
		}

		private void buttonXP3Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Third button pressed") ;
		}
	}
}
