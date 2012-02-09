/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/10
 * Time: 10:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using MovablePython;
using DrawTools;

namespace CoolScreenShot
{
	/// <summary>
	/// HACK! 
	/// since couldn't register the hotkey for MainForm
	/// I couldn't find the reason for that yet.
	/// TODO: remove this, and register hotkey on MainForm
	/// </summary>
	public partial class ProxyForm : Form
	{
		public ProxyForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		private MainForm mainForm;
        public Hotkey2 userHotkey;
        private CoolShotApplicationContext appContext;
		
		public void RegisterAppHotKey()
		{
            INIFile root = Config.IniFile;
            this.userHotkey = new Hotkey2(Hotkey2.KeyCodeFromString(Config.KeyCode), Config.ShiftKey, Config.ControlKey, Config.AltKey, Config.WindowsKey);
            // Catch the 'Pressed' event
            this.userHotkey.Pressed += delegate(object sender1, HandledEventArgs ee)
            {
                this.ShowMainForm();
            };

            this.userHotkey.Register(this);
            if (this.userHotkey.GetCanRegister(this))
            {
                MessageBox.Show("register hotkey fail!");
            }
            

            /*
			Hotkey2 hk = new Hotkey2(Keys.A, false, true, false, true);
			hk.Register(this);
			
			if (hk.GetCanRegister(this)) {
				MessageBox.Show("register hotkey fail!");
			}
			
			hk.Pressed+= delegate(object sender1, HandledEventArgs ee) {
				this.ShowMainForm();
			};*/
		}
		
		public void ShowMainForm(){
			distoryMainFormInstance();
			this.mainForm = new CoolScreenShot.MainForm();
            /*
			this.mainForm.Resize += delegate(object sender, EventArgs e) { 
				distoryMainFormInstance();
			};*/
			
			this.mainForm.Activate();
			this.mainForm.Show();
		}
		
		private void distoryMainFormInstance(){
			if (this.mainForm!= null) {
				this.mainForm.Hide();
				this.mainForm.Dispose();
				this.mainForm = null;
			}
		}

        public CoolShotApplicationContext AppContext {
            get {
                return this.appContext;
            }
            set {
                this.appContext = value;
            }
        }

        private static ProxyForm _instance;
        public static ProxyForm Instance {
            get {
                if (ProxyForm._instance == null)
                {
                    ProxyForm._instance = new ProxyForm();
                }

                return ProxyForm._instance;
            }
        }
	}
}
