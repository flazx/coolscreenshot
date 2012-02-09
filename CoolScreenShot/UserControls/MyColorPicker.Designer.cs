/*
 * Created by SharpDevelop.
 * User: xiaoqiang
 * Date: 2012/1/7
 * Time: 22:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CoolScreenShot.UserControls
{
	partial class MyColorPicker
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyColorPicker));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bigColorButton = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.textPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textSizeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.textPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(124, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(131, 34);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.bigColorButton);
            this.panel1.Location = new System.Drawing.Point(89, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 29);
            this.panel1.TabIndex = 1;
            // 
            // bigColorButton
            // 
            this.bigColorButton.BackColor = System.Drawing.Color.Red;
            this.bigColorButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bigColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bigColorButton.Location = new System.Drawing.Point(1, 1);
            this.bigColorButton.Name = "bigColorButton";
            this.bigColorButton.Size = new System.Drawing.Size(27, 27);
            this.bigColorButton.TabIndex = 0;
            this.bigColorButton.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(8, 8);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(22, 22);
            this.btn1.TabIndex = 2;
            this.btn1.Text = ".";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.MouseClick);
            this.btn1.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.btn1.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(32, 8);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(22, 22);
            this.btn2.TabIndex = 3;
            this.btn2.Text = ".";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.MouseClick);
            this.btn2.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.btn2.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3.BackgroundImage")));
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(60, 8);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(22, 22);
            this.btn3.TabIndex = 4;
            this.btn3.Text = ".";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.MouseClick);
            this.btn3.MouseLeave += new System.EventHandler(this.MouseLeave);
            this.btn3.MouseHover += new System.EventHandler(this.MouseHover);
            // 
            // textPanel
            // 
            this.textPanel.Controls.Add(this.label1);
            this.textPanel.Controls.Add(this.textSizeComboBox);
            this.textPanel.Location = new System.Drawing.Point(2, 4);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(84, 30);
            this.textPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "T";
            // 
            // textSizeComboBox
            // 
            this.textSizeComboBox.FormattingEnabled = true;
            this.textSizeComboBox.Location = new System.Drawing.Point(32, 5);
            this.textSizeComboBox.Name = "textSizeComboBox";
            this.textSizeComboBox.Size = new System.Drawing.Size(44, 20);
            this.textSizeComboBox.TabIndex = 0;
            this.textSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.textSizeComboBox_SelectedIndexChanged);
            // 
            // MyColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textPanel);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MyColorPicker";
            this.Size = new System.Drawing.Size(264, 39);
            this.Load += new System.EventHandler(this.MyColorPickerLoad);
            this.panel1.ResumeLayout(false);
            this.textPanel.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button bigColorButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel textPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox textSizeComboBox;
	}
}
