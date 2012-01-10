using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SampleNotifyIconApplication
{
	/// <summary>
	/// Summary description for CalendarForm
	/// </summary>
	public class CalendarForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MonthCalendar monthCalendar1;
	
		private System.ComponentModel.IContainer components;

		public CalendarForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// change the text to be relevant to today
			this.Text = "Calendar  - " + DateTime.Now.ToLongDateString();
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
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.SuspendLayout();
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 4);
			this.monthCalendar1.Location = new System.Drawing.Point(16, 16);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 0;
			this.monthCalendar1.TitleBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.Control;
			this.monthCalendar1.TrailingForeColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
			// 
			// CalendarForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.ClientSize = new System.Drawing.Size(640, 614);
			this.Controls.Add(this.monthCalendar1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(648, 648);
			this.MinimumSize = new System.Drawing.Size(648, 648);
			this.Name = "CalendarForm";
			this.Text = "Calendar - 2004";
			this.SizeChanged += new System.EventHandler(this.CalendarForm_SizeChanged);
			this.ResumeLayout(false);

		}
		#endregion


		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			CalendarApplicationContext applicationContext = new CalendarApplicationContext();
			Application.Run(applicationContext);
		}

		/// <summary>
		/// Occurs when the size has changed for the form.
		/// We'll check to see if the form has minimized.  If so, close it.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CalendarForm_SizeChanged(object sender, System.EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized) 
			{
				this.Close();
			}
			
		}


	}

	
}

