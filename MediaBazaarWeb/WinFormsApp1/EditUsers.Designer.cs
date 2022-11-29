namespace WinFormsApp1
{
    partial class EditUsers
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
            this.lbusername = new System.Windows.Forms.Label();
            this.lbfirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbpassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbPossitions = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.DateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbusername.Location = new System.Drawing.Point(30, 68);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(73, 20);
            this.lbusername.TabIndex = 1;
            this.lbusername.Text = "username";
            // 
            // lbfirstName
            // 
            this.lbfirstName.AutoSize = true;
            this.lbfirstName.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbfirstName.Location = new System.Drawing.Point(30, 113);
            this.lbfirstName.Name = "lbfirstName";
            this.lbfirstName.Size = new System.Drawing.Size(75, 20);
            this.lbfirstName.TabIndex = 2;
            this.lbfirstName.Text = "first name";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbLastName.Location = new System.Drawing.Point(30, 164);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(73, 20);
            this.lbLastName.TabIndex = 3;
            this.lbLastName.Text = "last name";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbAddress.Location = new System.Drawing.Point(30, 209);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(60, 20);
            this.lbAddress.TabIndex = 4;
            this.lbAddress.Text = "address";
            // 
            // lbpassword
            // 
            this.lbpassword.AutoSize = true;
            this.lbpassword.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbpassword.Location = new System.Drawing.Point(30, 264);
            this.lbpassword.Name = "lbpassword";
            this.lbpassword.Size = new System.Drawing.Size(72, 20);
            this.lbpassword.TabIndex = 5;
            this.lbpassword.Text = "password";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbEmail.Location = new System.Drawing.Point(30, 311);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "email";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.BackColor = System.Drawing.Color.LemonChiffon;
            this.lbDateOfBirth.Location = new System.Drawing.Point(30, 353);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(96, 20);
            this.lbDateOfBirth.TabIndex = 7;
            this.lbDateOfBirth.Text = "date of birth ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LemonChiffon;
            this.label9.Location = new System.Drawing.Point(30, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Position";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(132, 61);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(125, 27);
            this.tbUsername.TabIndex = 10;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(132, 110);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(125, 27);
            this.tbFirstName.TabIndex = 11;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(132, 161);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(125, 27);
            this.tbLastName.TabIndex = 12;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(132, 206);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(125, 27);
            this.tbAddress.TabIndex = 13;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(132, 257);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(125, 27);
            this.tbPassword.TabIndex = 14;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(132, 308);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(125, 27);
            this.tbEmail.TabIndex = 15;
            // 
            // cbPossitions
            // 
            this.cbPossitions.FormattingEnabled = true;
            this.cbPossitions.Items.AddRange(new object[] {
            "Employee",
            "Manager",
            "Depot_worker"});
            this.cbPossitions.Location = new System.Drawing.Point(132, 394);
            this.cbPossitions.Name = "cbPossitions";
            this.cbPossitions.Size = new System.Drawing.Size(125, 28);
            this.cbPossitions.TabIndex = 18;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(94, 451);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(94, 486);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DateTimePickerBirth
            // 
            this.DateTimePickerBirth.Location = new System.Drawing.Point(132, 348);
            this.DateTimePickerBirth.Name = "DateTimePickerBirth";
            this.DateTimePickerBirth.Size = new System.Drawing.Size(125, 27);
            this.DateTimePickerBirth.TabIndex = 21;
            this.DateTimePickerBirth.ValueChanged += new System.EventHandler(this.DateTimePickerBirth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "User information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTimePickerBirth);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbPossitions);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbDateOfBirth);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbpassword);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbfirstName);
            this.Controls.Add(this.lbusername);
            this.Name = "EditUsers";
            this.Text = "EditUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label lbfirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbpassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbPossitions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker DateTimePickerBirth;
        private System.Windows.Forms.Label label1;
    }
}