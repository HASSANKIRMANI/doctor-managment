namespace OOP_PROJECT_WINDOW_FORM
{
    partial class First_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First_Page));
            this.txtcombo2 = new System.Windows.Forms.ComboBox();
            this.txtoption2 = new System.Windows.Forms.Label();
            this.txtoption1 = new System.Windows.Forms.Label();
            this.txtwelcomelabel = new System.Windows.Forms.Label();
            this.txtcombo1 = new System.Windows.Forms.ComboBox();
            this.txtproceed = new System.Windows.Forms.Button();
            this.txtexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcombo2
            // 
            this.txtcombo2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcombo2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtcombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcombo2.FormattingEnabled = true;
            this.txtcombo2.Items.AddRange(new object[] {
            "Login",
            "Sign Up "});
            this.txtcombo2.Location = new System.Drawing.Point(551, 205);
            this.txtcombo2.Name = "txtcombo2";
            this.txtcombo2.Size = new System.Drawing.Size(220, 21);
            this.txtcombo2.TabIndex = 27;
            // 
            // txtoption2
            // 
            this.txtoption2.AutoSize = true;
            this.txtoption2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtoption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoption2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtoption2.Location = new System.Drawing.Point(417, 203);
            this.txtoption2.Name = "txtoption2";
            this.txtoption2.Size = new System.Drawing.Size(113, 20);
            this.txtoption2.TabIndex = 26;
            this.txtoption2.Text = "Select Option :";
            // 
            // txtoption1
            // 
            this.txtoption1.AutoSize = true;
            this.txtoption1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtoption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoption1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtoption1.Location = new System.Drawing.Point(441, 138);
            this.txtoption1.Name = "txtoption1";
            this.txtoption1.Size = new System.Drawing.Size(89, 20);
            this.txtoption1.TabIndex = 23;
            this.txtoption1.Text = "User Type :";
            // 
            // txtwelcomelabel
            // 
            this.txtwelcomelabel.AutoSize = true;
            this.txtwelcomelabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtwelcomelabel.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwelcomelabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtwelcomelabel.Location = new System.Drawing.Point(363, 26);
            this.txtwelcomelabel.Name = "txtwelcomelabel";
            this.txtwelcomelabel.Size = new System.Drawing.Size(474, 30);
            this.txtwelcomelabel.TabIndex = 22;
            this.txtwelcomelabel.Text = "WELCOME TO THE DR.ASSISTANT ! ";
            // 
            // txtcombo1
            // 
            this.txtcombo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcombo1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtcombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcombo1.FormattingEnabled = true;
            this.txtcombo1.Items.AddRange(new object[] {
            "Doctor",
            "Patient",
            "Admin"});
            this.txtcombo1.Location = new System.Drawing.Point(551, 137);
            this.txtcombo1.Name = "txtcombo1";
            this.txtcombo1.Size = new System.Drawing.Size(220, 21);
            this.txtcombo1.TabIndex = 21;
            this.txtcombo1.SelectedIndexChanged += new System.EventHandler(this.txtcombo1_SelectedIndexChanged);
            // 
            // txtproceed
            // 
            this.txtproceed.BackColor = System.Drawing.Color.DimGray;
            this.txtproceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproceed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtproceed.Location = new System.Drawing.Point(640, 284);
            this.txtproceed.Name = "txtproceed";
            this.txtproceed.Size = new System.Drawing.Size(131, 45);
            this.txtproceed.TabIndex = 24;
            this.txtproceed.Text = "&NEXT";
            this.txtproceed.UseVisualStyleBackColor = false;
            this.txtproceed.Click += new System.EventHandler(this.txtproceed_Click);
            // 
            // txtexit
            // 
            this.txtexit.BackColor = System.Drawing.Color.DimGray;
            this.txtexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtexit.Location = new System.Drawing.Point(468, 284);
            this.txtexit.Name = "txtexit";
            this.txtexit.Size = new System.Drawing.Size(126, 45);
            this.txtexit.TabIndex = 25;
            this.txtexit.Text = "E&XIT";
            this.txtexit.UseVisualStyleBackColor = false;
            this.txtexit.Click += new System.EventHandler(this.txtexit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 462);
            this.panel1.TabIndex = 28;
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
            // First_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = global::OOP_PROJECT_WINDOW_FORM.Properties.Resources._960x01;
            this.ClientSize = new System.Drawing.Size(1052, 486);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtcombo2);
            this.Controls.Add(this.txtoption2);
            this.Controls.Add(this.txtexit);
            this.Controls.Add(this.txtproceed);
            this.Controls.Add(this.txtoption1);
            this.Controls.Add(this.txtwelcomelabel);
            this.Controls.Add(this.txtcombo1);
            this.Name = "First_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTRODUCTION_PAGE";
            this.Load += new System.EventHandler(this.First_Page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox txtcombo2;
        private System.Windows.Forms.Label txtoption2;
        private System.Windows.Forms.Label txtoption1;
        private System.Windows.Forms.Label txtwelcomelabel;
        private System.Windows.Forms.ComboBox txtcombo1;
        private System.Windows.Forms.Button txtproceed;
        private System.Windows.Forms.Button txtexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

