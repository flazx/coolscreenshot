using System;
using System.Windows.Forms;
using System.Drawing;
using MovablePython;

namespace CoolScreenShot
{
	public class CoolShotApplicationContext : ApplicationContext 
	{
		private System.ComponentModel.IContainer	components;						// a list of components to dispose when the context is disposed
		private System.Windows.Forms.NotifyIcon		notifyIcon;				// the icon that sits in the system tray
		private System.Windows.Forms.ContextMenu	notifyIconContextMenu;	// the context menu for the notify icon
		private System.Windows.Forms.MenuItem		exitContextMenuItem;			// exit menu command for context menu 
        private System.Windows.Forms.MenuItem       preferencesMenuItem;
        private System.Windows.Forms.MenuItem		showContextMenuItem;			// open menu command for context menu 	
		private ProxyForm registerHotkeyForm;				// the current form we're displaying
        private Form sf;
		
		/// <summary>
		/// This class should be created and passed into Application.Run( ... )
		/// </summary>
		public CoolShotApplicationContext() 
		{
			InitializeContext();

            if (UtilHelps.IsFirstRunApp())
            {
                UtilHelps.AddWhenStart();
            }
		}

		/// <summary>
		/// Create the NotifyIcon UI, the ContextMenu for the NotifyIcon and an Exit menu item. 
		/// </summary>
		private void InitializeContext() 
		{
			this.components = new System.ComponentModel.Container();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.notifyIconContextMenu = new System.Windows.Forms.ContextMenu();
			this.showContextMenuItem = new System.Windows.Forms.MenuItem();
            this.preferencesMenuItem = new System.Windows.Forms.MenuItem();	
			this.exitContextMenuItem = new System.Windows.Forms.MenuItem();
		
			// 
			// calendarNotifyIcon
			// 
			this.notifyIcon.ContextMenu = this.notifyIconContextMenu;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.Icon = CoolScreenShot.Properties.Resources.SystemIcon;

            this.ShowBalloonTip();

            this.notifyIcon.Visible = true;
            this.notifyIcon.ShowBalloonTip(3000);
            
			// 
			// calendarNotifyIconContextMenu
			// 
			this.notifyIconContextMenu.MenuItems.AddRange(new MenuItem[] { showContextMenuItem,preferencesMenuItem,exitContextMenuItem });

			// 
			// showContextMenuItem
			// 
			this.showContextMenuItem.Index = 0;
            this.showContextMenuItem.Text = String.Format("&Start Shot ({0})", Config.GetCurrentHotkeys());
			this.showContextMenuItem.DefaultItem = true;
			this.showContextMenuItem.Click += new System.EventHandler(this.showContextMenuItem_Click);


            // 
            // showContextMenuItem
            // 
            this.preferencesMenuItem.Index = 1;
            this.preferencesMenuItem.Text = "&Preferences";
            this.preferencesMenuItem.Click += new EventHandler(preferencesMenuItem_Click);

			// 
			// exitContextMenuItem
			// 
			this.exitContextMenuItem.Index = 2;
			this.exitContextMenuItem.Text = "&Exit";
			this.exitContextMenuItem.Click += new System.EventHandler(this.exitContextMenuItem_Click);

            this.registerHotkeyForm = ProxyForm.Instance;
            this.registerHotkeyForm.AppContext = this;
			this.registerHotkeyForm.RegisterAppHotKey();
		}

        private void notifyIcon_DoubleClick(object sender, System.EventArgs e)
        {
            ShowForm();
        }

        void notifyIcon_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        void preferencesMenuItem_Click(object sender, EventArgs e)
        {
            if (this.sf != null)
            {
                this.sf.Dispose();
                this.sf = null;
            }

            this.sf = new SettingForm();
            this.sf.Show();
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
		/// This function will either create a new CalendarForm or activate the existing one, bringing the 
		/// window to front.
		/// </summary>
		public void ShowForm() 
		{
			registerHotkeyForm.ShowMainForm();
		}

        public void ShowBalloonTip() {
            this.notifyIcon.Text = String.Format("CoolShot (press {0} to crop)", Config.GetCurrentHotkeys());
            this.notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = String.Format("Cool Shot\nStart crop: {0}", Config.GetCurrentHotkeys());
        }


		private void mainForm_Closed (object sender, EventArgs e) 
		{
			// null out the main form so we know to create a new one.
			this.registerHotkeyForm = null;
		}

		/// <summary>
		/// If we are presently showing a mainForm, clean it up.
		/// </summary>
		protected override void ExitThreadCore()
		{
			if (registerHotkeyForm != null) 
			{
				// before we exit, give the main form a chance to clean itself up.
				registerHotkeyForm.Close();
			}
			base.ExitThreadCore ();
		}
		
	}
}
