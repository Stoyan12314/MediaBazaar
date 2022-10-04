namespace WinFormsApp1
{
    partial class Form2
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
            this.btnAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.btnShift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(509, 27);
            this.btnAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(163, 40);
            this.btnAll.TabIndex = 7;
            this.btnAll.Text = "Show all";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(307, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 40);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(19, 27);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(220, 39);
            this.tbSearch.TabIndex = 5;
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.ItemHeight = 20;
            this.lbEmployees.Location = new System.Drawing.Point(19, 114);
            this.lbEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(776, 384);
            this.lbEmployees.TabIndex = 4;
            // 
            // btnShift
            // 
            this.btnShift.Location = new System.Drawing.Point(709, 27);
            this.btnShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(163, 40);
            this.btnShift.TabIndex = 8;
            this.btnShift.Text = "Assign shift";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 625);
            this.Controls.Add(this.btnShift);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbEmployees);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.Button btnShift;
    }
}