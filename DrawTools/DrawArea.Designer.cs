namespace DrawTools
{
    partial class DrawArea
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolTextBox = new DrawTools.ExpandTextBox();
            this.SuspendLayout();
            // 
            // toolTextBox
            // 
            this.toolTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolTextBox.Font = new System.Drawing.Font("Arial Narrow", 8F);
            this.toolTextBox.Location = new System.Drawing.Point(3, 44);
            this.toolTextBox.Multiline = true;
            this.toolTextBox.Name = "toolTextBox";
            this.toolTextBox.Size = new System.Drawing.Size(47, 21);
            this.toolTextBox.TabIndex = 1;
            this.toolTextBox.Visible = false;
            this.toolTextBox.TextChanged += new System.EventHandler(this.ToolTextBoxTextChanged);
            this.toolTextBox.MouseEnter += new System.EventHandler(this.ToolTextBoxMouseEnter);
            // 
            // DrawArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.toolTextBox);
            this.Name = "DrawArea";
            this.Size = new System.Drawing.Size(327, 265);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawArea_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawArea_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ExpandTextBox toolTextBox;
    }
}
