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
		
		public void RegisterAppHotKey()
		{
			Hotkey hk = new Hotkey(Keys.A, false, true, true, true);
			hk.Register(this);
			
			if (hk.GetCanRegister(this)) {
				MessageBox.Show("register hotkey fail!");
			}
			
			hk.Pressed+= delegate(object sender1, HandledEventArgs ee) {
				this.ShowMainForm();
			};
		}
		
		public void ShowMainForm(){
			distoryMainFormInstance();
			this.mainForm = new CoolScreenShot.MainForm();
			this.mainForm.Resize += delegate(object sender, EventArgs e) { 
				distoryMainFormInstance();
			};
			
			this.mainForm.Activate();
			this.mainForm.Show();
		}
		
		private void distoryMainFormInstance(){
			if (this.mainForm!= null && this.mainForm.WindowState == FormWindowState.Minimized) {
				this.mainForm.Hide();
				this.mainForm.Dispose();
				this.mainForm = null;
			}
		}
	}
}
