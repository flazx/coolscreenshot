namespace CoolScreenShot
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.penWidthComboBox = new System.Windows.Forms.ComboBox();
            this.textsizeComboBox = new System.Windows.Forms.ComboBox();
            this.makeDefaultButton = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.windowsCheckBox = new System.Windows.Forms.CheckBox();
            this.altCheckBox = new System.Windows.Forms.CheckBox();
            this.controlCheckBox = new System.Windows.Forms.CheckBox();
            this.shiftCheckBox = new System.Windows.Forms.CheckBox();
            this.hotKeyComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.runCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 386);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 50);
            this.panel2.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(441, 8);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 35);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "OK";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.makeDefaultButton);
            this.tabPage3.Controls.Add(this.textsizeComboBox);
            this.tabPage3.Controls.Add(this.penWidthComboBox);
            this.tabPage3.Controls.Add(this.colorComboBox);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(587, 360);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Default Drawing Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Color(RGB):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pen Width:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Text Size:";
            // 
            // colorComboBox
            // 
            this.colorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(124, 42);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(99, 22);
            this.colorComboBox.TabIndex = 2;
            this.colorComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.colorComboBox_DrawItem);
            this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
            // 
            // penWidthComboBox
            // 
            this.penWidthComboBox.FormattingEnabled = true;
            this.penWidthComboBox.Location = new System.Drawing.Point(124, 81);
            this.penWidthComboBox.Name = "penWidthComboBox";
            this.penWidthComboBox.Size = new System.Drawing.Size(99, 20);
            this.penWidthComboBox.TabIndex = 2;
            // 
            // textsizeComboBox
            // 
            this.textsizeComboBox.FormattingEnabled = true;
            this.textsizeComboBox.Location = new System.Drawing.Point(124, 118);
            this.textsizeComboBox.Name = "textsizeComboBox";
            this.textsizeComboBox.Size = new System.Drawing.Size(99, 20);
            this.textsizeComboBox.TabIndex = 2;
            // 
            // makeDefaultButton
            // 
            this.makeDefaultButton.Location = new System.Drawing.Point(261, 71);
            this.makeDefaultButton.Name = "makeDefaultButton";
            this.makeDefaultButton.Size = new System.Drawing.Size(230, 38);
            this.makeDefaultButton.TabIndex = 3;
            this.makeDefaultButton.Text = "Make current drawing value default";
            this.makeDefaultButton.UseVisualStyleBackColor = true;
            this.makeDefaultButton.Click += new System.EventHandler(this.makeDefaultButton_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.hotKeyComboBox);
            this.tabPage4.Controls.Add(this.shiftCheckBox);
            this.tabPage4.Controls.Add(label5);
            this.tabPage4.Controls.Add(this.controlCheckBox);
            this.tabPage4.Controls.Add(this.altCheckBox);
            this.tabPage4.Controls.Add(this.windowsCheckBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(587, 360);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "HotKey";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // windowsCheckBox
            // 
            this.windowsCheckBox.AutoSize = true;
            this.windowsCheckBox.Location = new System.Drawing.Point(241, 51);
            this.windowsCheckBox.Name = "windowsCheckBox";
            this.windowsCheckBox.Size = new System.Drawing.Size(66, 16);
            this.windowsCheckBox.TabIndex = 11;
            this.windowsCheckBox.Text = "&Windows";
            this.windowsCheckBox.UseVisualStyleBackColor = true;
            this.windowsCheckBox.Click += new System.EventHandler(this.UpdateHotKey);
            // 
            // altCheckBox
            // 
            this.altCheckBox.AutoSize = true;
            this.altCheckBox.Checked = true;
            this.altCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.altCheckBox.Location = new System.Drawing.Point(196, 51);
            this.altCheckBox.Name = "altCheckBox";
            this.altCheckBox.Size = new System.Drawing.Size(42, 16);
            this.altCheckBox.TabIndex = 10;
            this.altCheckBox.Text = "&Alt";
            this.altCheckBox.UseVisualStyleBackColor = true;
            this.altCheckBox.Click += new System.EventHandler(this.UpdateHotKey);
            // 
            // controlCheckBox
            // 
            this.controlCheckBox.AutoSize = true;
            this.controlCheckBox.Checked = true;
            this.controlCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.controlCheckBox.Location = new System.Drawing.Point(129, 51);
            this.controlCheckBox.Name = "controlCheckBox";
            this.controlCheckBox.Size = new System.Drawing.Size(66, 16);
            this.controlCheckBox.TabIndex = 9;
            this.controlCheckBox.Text = "&Control";
            this.controlCheckBox.UseVisualStyleBackColor = true;
            this.controlCheckBox.Click += new System.EventHandler(this.UpdateHotKey);
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(16, 24);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 18);
            label5.TabIndex = 6;
            label5.Text = "&Hotkey2:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shiftCheckBox
            // 
            this.shiftCheckBox.AutoSize = true;
            this.shiftCheckBox.Location = new System.Drawing.Point(75, 51);
            this.shiftCheckBox.Name = "shiftCheckBox";
            this.shiftCheckBox.Size = new System.Drawing.Size(54, 16);
            this.shiftCheckBox.TabIndex = 8;
            this.shiftCheckBox.Text = "&Shift";
            this.shiftCheckBox.UseVisualStyleBackColor = true;
            this.shiftCheckBox.Click += new System.EventHandler(this.UpdateHotKey);
            // 
            // hotKeyComboBox
            // 
            this.hotKeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hotKeyComboBox.FormattingEnabled = true;
            this.hotKeyComboBox.Location = new System.Drawing.Point(75, 24);
            this.hotKeyComboBox.Name = "hotKeyComboBox";
            this.hotKeyComboBox.Size = new System.Drawing.Size(235, 20);
            this.hotKeyComboBox.TabIndex = 7;
            this.hotKeyComboBox.SelectedIndexChanged += new System.EventHandler(this.UpdateHotKey);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.runCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(587, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Options";
            // 
            // runCheckBox
            // 
            this.runCheckBox.AutoSize = true;
            this.runCheckBox.Location = new System.Drawing.Point(43, 60);
            this.runCheckBox.Name = "runCheckBox";
            this.runCheckBox.Size = new System.Drawing.Size(252, 16);
            this.runCheckBox.TabIndex = 0;
            this.runCheckBox.Text = "Launch CoolShot when windows starts up";
            this.runCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 386);
            this.tabControl1.TabIndex = 0;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 386);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingForm";
            this.Text = "Preferences";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox runCheckBox;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox hotKeyComboBox;
        private System.Windows.Forms.CheckBox shiftCheckBox;
        private System.Windows.Forms.CheckBox controlCheckBox;
        private System.Windows.Forms.CheckBox altCheckBox;
        private System.Windows.Forms.CheckBox windowsCheckBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button makeDefaultButton;
        private System.Windows.Forms.ComboBox textsizeComboBox;
        private System.Windows.Forms.ComboBox penWidthComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}