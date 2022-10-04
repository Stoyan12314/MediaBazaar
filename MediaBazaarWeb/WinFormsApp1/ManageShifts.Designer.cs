namespace WinFormsApp1
{
    partial class ManageShifts
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
            this.cbShifts = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbShifts
            // 
            this.cbShifts.FormattingEnabled = true;
            this.cbShifts.Items.AddRange(new object[] {
            "morning",
            "afternoon",
            "evening"});
            this.cbShifts.Location = new System.Drawing.Point(56, 34);
            this.cbShifts.Name = "cbShifts";
            this.cbShifts.Size = new System.Drawing.Size(151, 28);
            this.cbShifts.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(95, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ManageShifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 119);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbShifts);
            this.Name = "ManageShifts";
            this.Text = "ManageShifts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbShifts;
        private System.Windows.Forms.Button btnSave;
    }
}