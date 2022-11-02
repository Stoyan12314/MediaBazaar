namespace WinFormsApp1
{
    partial class EmployeeManagment
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbShift = new System.Windows.Forms.Label();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbEmployeesOnShift = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
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
            this.lbEmployees.Location = new System.Drawing.Point(358, 95);
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
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(28, 95);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.lbShift);
            this.groupBox1.Controls.Add(this.lbDepartment);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(28, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 165);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set shift";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set shift";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(111, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // lbShift
            // 
            this.lbShift.AutoSize = true;
            this.lbShift.Location = new System.Drawing.Point(6, 74);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(37, 20);
            this.lbShift.TabIndex = 2;
            this.lbShift.Text = "shift";
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(6, 32);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(89, 20);
            this.lbDepartment.TabIndex = 1;
            this.lbDepartment.Text = "Department";
            this.lbDepartment.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // lbEmployeesOnShift
            // 
            this.lbEmployeesOnShift.FormattingEnabled = true;
            this.lbEmployeesOnShift.ItemHeight = 20;
            this.lbEmployeesOnShift.Location = new System.Drawing.Point(358, 556);
            this.lbEmployeesOnShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbEmployeesOnShift.Name = "lbEmployeesOnShift";
            this.lbEmployeesOnShift.Size = new System.Drawing.Size(776, 384);
            this.lbEmployeesOnShift.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(709, 947);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Set shift";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(34, 556);
            this.monthCalendar2.MaxSelectionCount = 1;
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 19;
            // 
            // EmployeeManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 1055);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbEmployeesOnShift);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnShift);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbEmployees);
            this.Name = "EmployeeManagment";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.EmployeeManagment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbShift;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbEmployeesOnShift;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
    }
}