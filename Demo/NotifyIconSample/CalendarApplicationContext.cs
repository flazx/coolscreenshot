using System;
using System.Windows.Forms;
using System.Drawing;

namespace SampleNotifyIconApplication
{
	/// <summary>
	/// CalendarApplicationContext.
	/// This class has several jobs:
	///		- Create the NotifyIcon UI
	///		- Manage the CalendarForm that pops up
	///		- Determines when the Application should exit
	/// </summary>
	public class CalendarApplicationContext : ApplicationContext 
	{
		private System.ComponentModel.IContainer	components;						// a list of components to dispose when the context is disposed
		private System.Windows.Forms.NotifyIcon		calendarNotifyIcon;				// the icon that sits in the system tray
		private System.Windows.Forms.ContextMenu	calendarNotifyIconContextMenu;	// the context menu for the notify icon
		private System.Windows.Forms.MenuItem		exitContextMenuItem;			// exit menu command for context menu 
		private System.Windows.Forms.MenuItem		showContextMenuItem;			// open menu command for context menu 	
		private System.Windows.Forms.Form			mainForm;						// the current form we're displaying

		/// <summary>
		/// This class should be created and passed into Application.Run( ... )
		/// </summary>
		public CalendarApplicationContext() 
		{
			// create the notify icon and it's associated context menu
			InitializeContext();
		}

		/// <summary>
		/// Create the NotifyIcon UI, the ContextMenu for the NotifyIcon and an Exit menu item. 
		/// </summary>
		private void InitializeContext() 
		{
			this.components = new System.ComponentModel.Container();
			this.calendarNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.calendarNotifyIconContextMenu = new System.Windows.Forms.ContextMenu();
			this.showContextMenuItem = new System.Windows.Forms.MenuItem();		
			this.exitContextMenuItem = new System.Windows.Forms.MenuItem();
		
			// 
			// calendarNotifyIcon
			// 
			this.calendarNotifyIcon.ContextMenu = this.calendarNotifyIconContextMenu;
			this.calendarNotifyIcon.DoubleClick += new System.EventHandler(this.calendarNotifyIcon_DoubleClick);
			this.calendarNotifyIcon.Icon = new Icon(typeof(CalendarApplicationContext), "CLOCK05.ICO");
			this.calendarNotifyIcon.Text = DateTime.Now.ToLongDateString();
			this.calendarNotifyIcon.Visible = true;

			// 
			// calendarNotifyIconContextMenu
			// 
			this.calendarNotifyIconContextMenu.MenuItems.AddRange(new MenuItem[] { showContextMenuItem, exitContextMenuItem });

			
			// 
			// showContextMenuItem
			// 
			this.showContextMenuItem.Index = 0;
			this.showContextMenuItem.Text = "&Show Calendar";
			this.showContextMenuItem.DefaultItem = true;
			this.showContextMenuItem.Click += new System.EventHandler(this.showContextMenuItem_Click);

			// 
			// exitContextMenuItem
			// 
			this.exitContextMenuItem.Index = 1;
			this.exitContextMenuItem.Text = "&Exit";
			this.exitContextMenuItem.Click += new System.EventHandler(this.exitContextMenuItem_Click);
		
		}


		/// <summary>
		/// When the application context is disposed, dispose things like the notify icon.
		/// </summary>
		/// <param name="disposing"></param>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}		
		}		


		/// <summary>
		/// When the open menu item is clicked, make a call to Show the form.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void showContextMenuItem_Click(object sender, EventArgs e) 
		{
			ShowForm();
		}
		/// <summary>
		/// When the exit menu item is clicked, make a call to terminate the ApplicationContext.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void exitContextMenuItem_Click(object sender, EventArgs e) 
		{
			ExitThread();
		}
		
		/// <summary>
		/// When the notify icon is double clicked in the system tray, bring up a form with a calendar on it.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void calendarNotifyIcon_DoubleClick(object sender,System.EventArgs e)
		{
			ShowForm();
		}

		/// <summary>
		/// This function will either create a new CalendarForm or activate the existing one, bringing the 
		/// window to front.
		/// </summary>
		private void ShowForm() 
		{
			if (mainForm == null) 
			{
				// create a fresh new CalendarForm and show it.
				mainForm = new CalendarForm();
				mainForm.Show();
				
				// hook onto the closed event so we can null out the main form...  this avoids reshowing
				// a disposed form.
				mainForm.Closed +=new EventHandler(mainForm_Closed);		
			}
			else 
			{
				// the form is currently visible, go ahead and bring it to the front so the user can interact
				mainForm.Activate();
			}
		}


		private void mainForm_Closed (object sender, EventArgs e) 
		{
			// null out the main form so we know to create a new one.
			this.mainForm = null;
		}

		/// <summary>
		/// If we are presently showing a mainForm, clean it up.
		/// </summary>
		protected override void ExitThreadCore()
		{
			if (mainForm != null) 
			{
				// before we exit, give the main form a chance to clean itself up.
				mainForm.Close();
			}
			base.ExitThreadCore ();
		}
		
	}
}
