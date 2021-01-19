namespace OOP_PROJECT_WINDOW_FORM
{
    partial class SignUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.txtback = new System.Windows.Forms.Button();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.PostalCodeLbl = new System.Windows.Forms.Label();
            this.PostalCodeTb = new System.Windows.Forms.TextBox();
            this.AgeTb = new System.Windows.Forms.TextBox();
            this.UserNameTb = new System.Windows.Forms.TextBox();
            this.PhoneNoLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.UserNameLbl = new System.Windows.Forms.Label();
            this.SpecialityLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSignup = new System.Windows.Forms.Button();
            this.SpecialityCb = new System.Windows.Forms.ComboBox();
            this.FirstNameTb = new System.Windows.Forms.TextBox();
            this.FIrstNameLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LastNameTb = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DescriptionTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PhoneNoTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtback
            // 
            this.txtback.BackColor = System.Drawing.Color.DimGray;
            this.txtback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtback.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtback.Location = new System.Drawing.Point(446, 454);
            this.txtback.Name = "txtback";
            this.txtback.Size = new System.Drawing.Size(142, 59);
            this.txtback.TabIndex = 65;
            this.txtback.Text = "Back";
            this.txtback.UseVisualStyleBackColor = false;
            this.txtback.Click += new System.EventHandler(this.txtback_Click);
            // 
            // GenderCb
            // 
            this.GenderCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCb.Location = new System.Drawing.Point(428, 163);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(160, 21);
            this.GenderCb.TabIndex = 4;
            this.GenderCb.Leave += new System.EventHandler(this.GenderCb_Leave);
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GenderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GenderLbl.Location = new System.Drawing.Point(341, 168);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(75, 20);
            this.GenderLbl.TabIndex = 60;
            this.GenderLbl.Text = "Gender : ";
            // 
            // PostalCodeLbl
            // 
            this.PostalCodeLbl.AutoSize = true;
            this.PostalCodeLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PostalCodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostalCodeLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PostalCodeLbl.Location = new System.Drawing.Point(308, 327);
            this.PostalCodeLbl.Name = "PostalCodeLbl";
            this.PostalCodeLbl.Size = new System.Drawing.Size(107, 20);
            this.PostalCodeLbl.TabIndex = 58;
            this.PostalCodeLbl.Text = "Postal Code : ";
            // 
            // PostalCodeTb
            // 
            this.PostalCodeTb.Location = new System.Drawing.Point(429, 325);
            this.PostalCodeTb.Name = "PostalCodeTb";
            this.PostalCodeTb.Size = new System.Drawing.Size(123, 20);
            this.PostalCodeTb.TabIndex = 8;
            this.PostalCodeTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PostalCodeTb_KeyPress);
            this.PostalCodeTb.Leave += new System.EventHandler(this.PostalCodeTb_Leave);
            // 
            // AgeTb
            // 
            this.AgeTb.Location = new System.Drawing.Point(744, 167);
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.Size = new System.Drawing.Size(73, 20);
            this.AgeTb.TabIndex = 5;
            this.AgeTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgeTb_KeyPress);
            this.AgeTb.Leave += new System.EventHandler(this.AgeTb_Leave);
            // 
            // UserNameTb
            // 
            this.UserNameTb.Location = new System.Drawing.Point(429, 125);
            this.UserNameTb.Name = "UserNameTb";
            this.UserNameTb.Size = new System.Drawing.Size(160, 20);
            this.UserNameTb.TabIndex = 2;
            this.UserNameTb.TextChanged += new System.EventHandler(this.UserNameTb_TextChanged);
            this.UserNameTb.Leave += new System.EventHandler(this.UserNameTb_Leave);
            // 
            // PhoneNoLbl
            // 
            this.PhoneNoLbl.AutoSize = true;
            this.PhoneNoLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PhoneNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNoLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PhoneNoLbl.Location = new System.Drawing.Point(323, 209);
            this.PhoneNoLbl.Name = "PhoneNoLbl";
            this.PhoneNoLbl.Size = new System.Drawing.Size(91, 20);
            this.PhoneNoLbl.TabIndex = 46;
            this.PhoneNoLbl.Text = "Phone No : ";
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AgeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgeLbl.Location = new System.Drawing.Point(678, 166);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(46, 20);
            this.AgeLbl.TabIndex = 45;
            this.AgeLbl.Text = "Age :";
            // 
            // UserNameLbl
            // 
            this.UserNameLbl.AutoSize = true;
            this.UserNameLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UserNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserNameLbl.Location = new System.Drawing.Point(314, 129);
            this.UserNameLbl.Name = "UserNameLbl";
            this.UserNameLbl.Size = new System.Drawing.Size(101, 20);
            this.UserNameLbl.TabIndex = 43;
            this.UserNameLbl.Text = "User Name : ";
            // 
            // SpecialityLbl
            // 
            this.SpecialityLbl.AutoSize = true;
            this.SpecialityLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SpecialityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialityLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SpecialityLbl.Location = new System.Drawing.Point(637, 328);
            this.SpecialityLbl.Name = "SpecialityLbl";
            this.SpecialityLbl.Size = new System.Drawing.Size(88, 20);
            this.SpecialityLbl.TabIndex = 41;
            this.SpecialityLbl.Text = "Speciality : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(516, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 35);
            this.label1.TabIndex = 40;
            this.label1.Text = "Sign Up";
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.DimGray;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignup.Location = new System.Drawing.Point(660, 454);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(183, 59);
            this.btnSignup.TabIndex = 66;
            this.btnSignup.Text = "Email Verification";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // SpecialityCb
            // 
            this.SpecialityCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecialityCb.FormattingEnabled = true;
            this.SpecialityCb.Items.AddRange(new object[] {
            "General Physician",
            "Otolaryngologist",
            "Cardiologist",
            "Pulmonologist",
            "Infectologist"});
            this.SpecialityCb.Location = new System.Drawing.Point(744, 325);
            this.SpecialityCb.Name = "SpecialityCb";
            this.SpecialityCb.Size = new System.Drawing.Size(160, 21);
            this.SpecialityCb.TabIndex = 9;
            this.SpecialityCb.Leave += new System.EventHandler(this.SpecialityCb_Leave);
            // 
            // FirstNameTb
            // 
            this.FirstNameTb.Location = new System.Drawing.Point(429, 85);
            this.FirstNameTb.Name = "FirstNameTb";
            this.FirstNameTb.Size = new System.Drawing.Size(160, 20);
            this.FirstNameTb.TabIndex = 0;
            this.FirstNameTb.TextChanged += new System.EventHandler(this.FirstNameTb_TextChanged);
            this.FirstNameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNameTb_KeyPress);
            this.FirstNameTb.Leave += new System.EventHandler(this.FirstNameTb_Leave);
            // 
            // FIrstNameLbl
            // 
            this.FIrstNameLbl.AutoSize = true;
            this.FIrstNameLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FIrstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIrstNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FIrstNameLbl.Location = new System.Drawing.Point(315, 86);
            this.FIrstNameLbl.Name = "FIrstNameLbl";
            this.FIrstNameLbl.Size = new System.Drawing.Size(98, 20);
            this.FIrstNameLbl.TabIndex = 69;
            this.FIrstNameLbl.Text = "First Name : ";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddressLbl.Location = new System.Drawing.Point(334, 264);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(80, 20);
            this.AddressLbl.TabIndex = 71;
            this.AddressLbl.Text = "Address : ";
            // 
            // AddressTb
            // 
            this.AddressTb.Location = new System.Drawing.Point(429, 242);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(475, 65);
            this.AddressTb.TabIndex = 7;
            this.AddressTb.Leave += new System.EventHandler(this.AddressTb_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LastNameTb
            // 
            this.LastNameTb.Location = new System.Drawing.Point(744, 85);
            this.LastNameTb.Name = "LastNameTb";
            this.LastNameTb.Size = new System.Drawing.Size(160, 20);
            this.LastNameTb.TabIndex = 1;
            this.LastNameTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNameTb_KeyPress);
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LastNameLbl.Location = new System.Drawing.Point(627, 85);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(98, 20);
            this.LastNameLbl.TabIndex = 73;
            this.LastNameLbl.Text = "Last Name : ";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(744, 128);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(160, 20);
            this.PasswordTb.TabIndex = 3;
            this.PasswordTb.TextChanged += new System.EventHandler(this.PasswordTb_TextChanged);
            this.PasswordTb.Leave += new System.EventHandler(this.PasswordTb_Leave);
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLbl.Location = new System.Drawing.Point(636, 130);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(86, 20);
            this.PasswordLbl.TabIndex = 75;
            this.PasswordLbl.Text = "Password :";
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Location = new System.Drawing.Point(428, 364);
            this.DescriptionTb.Multiline = true;
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(475, 63);
            this.DescriptionTb.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(314, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Description : ";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(30, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(43, 525);
            this.menuStrip1.TabIndex = 67;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 462);
            this.panel1.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(17, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "DR.ASSISTANT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // PhoneNoTb
            // 
            this.PhoneNoTb.Location = new System.Drawing.Point(429, 207);
            this.PhoneNoTb.MaxLength = 12;
            this.PhoneNoTb.Name = "PhoneNoTb";
            this.PhoneNoTb.Size = new System.Drawing.Size(160, 20);
            this.PhoneNoTb.TabIndex = 6;
            this.PhoneNoTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNoTb_KeyPress);
            this.PhoneNoTb.Leave += new System.EventHandler(this.PhoneNoTb_Leave);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP_PROJECT_WINDOW_FORM.Properties.Resources._960x01;
            this.ClientSize = new System.Drawing.Size(1046, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DescriptionTb);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.LastNameTb);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.AddressLbl);
            this.Controls.Add(this.FirstNameTb);
            this.Controls.Add(this.FIrstNameLbl);
            this.Controls.Add(this.SpecialityCb);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.txtback);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.PostalCodeLbl);
            this.Controls.Add(this.PostalCodeTb);
            this.Controls.Add(this.PhoneNoTb);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.UserNameTb);
            this.Controls.Add(this.PhoneNoLbl);
            this.Controls.Add(this.AgeLbl);
            this.Controls.Add(this.UserNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpecialityLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtback;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label PostalCodeLbl;
        private System.Windows.Forms.TextBox PostalCodeTb;
        private System.Windows.Forms.TextBox AgeTb;
        private System.Windows.Forms.TextBox UserNameTb;
        private System.Windows.Forms.Label PhoneNoLbl;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label UserNameLbl;
        private System.Windows.Forms.Label SpecialityLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.ComboBox SpecialityCb;
        private System.Windows.Forms.TextBox FirstNameTb;
        private System.Windows.Forms.Label FIrstNameLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox LastNameTb;
        private System.Windows.Forms.Label LastNameLbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox DescriptionTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox PhoneNoTb;
    }
}