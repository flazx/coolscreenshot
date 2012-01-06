//
// Copyright (c) 2004, O&O Services GmbH.
// Am Borsigturm 48
// 13507 Berlin
// GERMANY
// Tel: +49 30 43 03 43-03, Fax: +49 30 43 03 43-99
// E-mail: info@oo-services.com
// Web: http://www.oo-services.com
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions are met:
//
// * Redistributions of source code must retain the above copyright notice, 
//   this list of conditions and the following disclaimer.
// * Redistributions in binary form must reproduce the above copyright notice, 
//   this list of conditions and the following disclaimer in the documentation 
//   and/or other materials provided with the distribution.
// * Neither the name of O&O Services GmbH nor the names of its contributors 
//   may be used to endorse or promote products derived from this software
//   without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, 
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR
// PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR 
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, 
// EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, 
// PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; 
// OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
// WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR 
// OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, 
// EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
//

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Resources;

using OOGroup.Windows.Forms;

namespace ImageButtonTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ImageButtonForm : System.Windows.Forms.Form
	{
		private OOGroup.Windows.Forms.ImageButton SearchImageButton;
		private OOGroup.Windows.Forms.ImageButton GoImageButton;
		private OOGroup.Windows.Forms.ImageButton DisableButton;
		private OOGroup.Windows.Forms.ImageButton DropDownButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private ResourceManager resourceMgr = new ResourceManager(typeof(ImageButtonForm));

		public ImageButtonForm()
		{
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("de");

			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			Bitmap searchBitmap = new Bitmap("Search_16X16_32bpp.png");
			SearchImageButton.SetImage(searchBitmap, ImageButton.Alignment.Left, 2, 2, 0, 0);

			Bitmap goBitmap = new Bitmap("Go_48X48_32bpp.png");
			Bitmap goHoverBitmap = new Bitmap("Go!_48X48_32bpp.png");
			Bitmap goDisabledBitmap = new Bitmap("GoDisabled_48X48_32bpp.png");
			GoImageButton.SetImage(goBitmap, goHoverBitmap, goBitmap, goBitmap, goBitmap, ImageButton.Alignment.Center);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ImageButtonForm));
			this.SearchImageButton = new OOGroup.Windows.Forms.ImageButton();
			this.GoImageButton = new OOGroup.Windows.Forms.ImageButton();
			this.DisableButton = new OOGroup.Windows.Forms.ImageButton();
			this.DropDownButton = new OOGroup.Windows.Forms.ImageButton();
			this.SuspendLayout();
			// 
			// SearchImageButton
			// 
			this.SearchImageButton.AccessibleDescription = resources.GetString("SearchImageButton.AccessibleDescription");
			this.SearchImageButton.AccessibleName = resources.GetString("SearchImageButton.AccessibleName");
			this.SearchImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("SearchImageButton.Anchor")));
			this.SearchImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchImageButton.BackgroundImage")));
			this.SearchImageButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("SearchImageButton.Dock")));
			this.SearchImageButton.Enabled = ((bool)(resources.GetObject("SearchImageButton.Enabled")));
			this.SearchImageButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("SearchImageButton.FlatStyle")));
			this.SearchImageButton.Font = ((System.Drawing.Font)(resources.GetObject("SearchImageButton.Font")));
			this.SearchImageButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchImageButton.Image")));
			this.SearchImageButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("SearchImageButton.ImageAlign")));
			this.SearchImageButton.ImageIndex = ((int)(resources.GetObject("SearchImageButton.ImageIndex")));
			this.SearchImageButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("SearchImageButton.ImeMode")));
			this.SearchImageButton.Location = ((System.Drawing.Point)(resources.GetObject("SearchImageButton.Location")));
			this.SearchImageButton.Name = "SearchImageButton";
			this.SearchImageButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("SearchImageButton.RightToLeft")));
			this.SearchImageButton.Size = ((System.Drawing.Size)(resources.GetObject("SearchImageButton.Size")));
			this.SearchImageButton.TabIndex = ((int)(resources.GetObject("SearchImageButton.TabIndex")));
			this.SearchImageButton.Text = resources.GetString("SearchImageButton.Text");
			this.SearchImageButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("SearchImageButton.TextAlign")));
			this.SearchImageButton.Visible = ((bool)(resources.GetObject("SearchImageButton.Visible")));
			// 
			// GoImageButton
			// 
			this.GoImageButton.AccessibleDescription = resources.GetString("GoImageButton.AccessibleDescription");
			this.GoImageButton.AccessibleName = resources.GetString("GoImageButton.AccessibleName");
			this.GoImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("GoImageButton.Anchor")));
			this.GoImageButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoImageButton.BackgroundImage")));
			this.GoImageButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("GoImageButton.Dock")));
			this.GoImageButton.Enabled = ((bool)(resources.GetObject("GoImageButton.Enabled")));
			this.GoImageButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("GoImageButton.FlatStyle")));
			this.GoImageButton.Font = ((System.Drawing.Font)(resources.GetObject("GoImageButton.Font")));
			this.GoImageButton.GenerateDisabledImage = true;
			this.GoImageButton.Image = ((System.Drawing.Image)(resources.GetObject("GoImageButton.Image")));
			this.GoImageButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("GoImageButton.ImageAlign")));
			this.GoImageButton.ImageIndex = ((int)(resources.GetObject("GoImageButton.ImageIndex")));
			this.GoImageButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("GoImageButton.ImeMode")));
			this.GoImageButton.Location = ((System.Drawing.Point)(resources.GetObject("GoImageButton.Location")));
			this.GoImageButton.Name = "GoImageButton";
			this.GoImageButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("GoImageButton.RightToLeft")));
			this.GoImageButton.Size = ((System.Drawing.Size)(resources.GetObject("GoImageButton.Size")));
			this.GoImageButton.TabIndex = ((int)(resources.GetObject("GoImageButton.TabIndex")));
			this.GoImageButton.Text = resources.GetString("GoImageButton.Text");
			this.GoImageButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("GoImageButton.TextAlign")));
			this.GoImageButton.Visible = ((bool)(resources.GetObject("GoImageButton.Visible")));
			// 
			// DisableButton
			// 
			this.DisableButton.AccessibleDescription = resources.GetString("DisableButton.AccessibleDescription");
			this.DisableButton.AccessibleName = resources.GetString("DisableButton.AccessibleName");
			this.DisableButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("DisableButton.Anchor")));
			this.DisableButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DisableButton.BackgroundImage")));
			this.DisableButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("DisableButton.Dock")));
			this.DisableButton.Enabled = ((bool)(resources.GetObject("DisableButton.Enabled")));
			this.DisableButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("DisableButton.FlatStyle")));
			this.DisableButton.Font = ((System.Drawing.Font)(resources.GetObject("DisableButton.Font")));
			this.DisableButton.Image = ((System.Drawing.Image)(resources.GetObject("DisableButton.Image")));
			this.DisableButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("DisableButton.ImageAlign")));
			this.DisableButton.ImageIndex = ((int)(resources.GetObject("DisableButton.ImageIndex")));
			this.DisableButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("DisableButton.ImeMode")));
			this.DisableButton.Location = ((System.Drawing.Point)(resources.GetObject("DisableButton.Location")));
			this.DisableButton.Name = "DisableButton";
			this.DisableButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("DisableButton.RightToLeft")));
			this.DisableButton.Size = ((System.Drawing.Size)(resources.GetObject("DisableButton.Size")));
			this.DisableButton.TabIndex = ((int)(resources.GetObject("DisableButton.TabIndex")));
			this.DisableButton.Text = resources.GetString("DisableButton.Text");
			this.DisableButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("DisableButton.TextAlign")));
			this.DisableButton.Visible = ((bool)(resources.GetObject("DisableButton.Visible")));
			this.DisableButton.Click += new System.EventHandler(this.DisableButton_Click);
			// 
			// DropDownButton
			// 
			this.DropDownButton.AccessibleDescription = resources.GetString("DropDownButton.AccessibleDescription");
			this.DropDownButton.AccessibleName = resources.GetString("DropDownButton.AccessibleName");
			this.DropDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("DropDownButton.Anchor")));
			this.DropDownButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DropDownButton.BackgroundImage")));
			this.DropDownButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("DropDownButton.Dock")));
			this.DropDownButton.DropDown = true;
			this.DropDownButton.Enabled = ((bool)(resources.GetObject("DropDownButton.Enabled")));
			this.DropDownButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("DropDownButton.FlatStyle")));
			this.DropDownButton.Font = ((System.Drawing.Font)(resources.GetObject("DropDownButton.Font")));
			this.DropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("DropDownButton.Image")));
			this.DropDownButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("DropDownButton.ImageAlign")));
			this.DropDownButton.ImageIndex = ((int)(resources.GetObject("DropDownButton.ImageIndex")));
			this.DropDownButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("DropDownButton.ImeMode")));
			this.DropDownButton.Location = ((System.Drawing.Point)(resources.GetObject("DropDownButton.Location")));
			this.DropDownButton.Name = "DropDownButton";
			this.DropDownButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("DropDownButton.RightToLeft")));
			this.DropDownButton.Size = ((System.Drawing.Size)(resources.GetObject("DropDownButton.Size")));
			this.DropDownButton.TabIndex = ((int)(resources.GetObject("DropDownButton.TabIndex")));
			this.DropDownButton.Text = resources.GetString("DropDownButton.Text");
			this.DropDownButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("DropDownButton.TextAlign")));
			this.DropDownButton.Visible = ((bool)(resources.GetObject("DropDownButton.Visible")));
			// 
			// ImageButtonForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.DropDownButton);
			this.Controls.Add(this.DisableButton);
			this.Controls.Add(this.GoImageButton);
			this.Controls.Add(this.SearchImageButton);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "ImageButtonForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ImageButtonForm());
		}

		private void DisableButton_Click(object sender, System.EventArgs e)
		{
			GoImageButton.Enabled = !GoImageButton.Enabled;
			DisableButton.Text = GoImageButton.Enabled ? resourceMgr.GetString("DisableButton.Text") 
				: resourceMgr.GetString("DisableButton.EnableText");
		}
	}
}
