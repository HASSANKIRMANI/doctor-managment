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
            this.txtfull = new System.Windows.Forms.Button();
            this.txtcombo2 = new System.Windows.Forms.ComboBox();
            this.txtoption2 = new System.Windows.Forms.Label();
            this.txtproceed = new System.Windows.Forms.Button();
            this.txtoption1 = new System.Windows.Forms.Label();
            this.txtwelcomelabel = new System.Windows.Forms.Label();
            this.txtcombo1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtpicturelabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtexit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfull
            // 
            this.txtfull.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfull.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtfull.Location = new System.Drawing.Point(320, 244);
            this.txtfull.Name = "txtfull";
            this.txtfull.Size = new System.Drawing.Size(106, 38);
            this.txtfull.TabIndex = 29;
            this.txtfull.Text = "Full Screen";
            this.txtfull.UseVisualStyleBackColor = true;
            this.txtfull.Click += new System.EventHandler(this.txtfull_Click);
            // 
            // txtcombo2
            // 
            this.txtcombo2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcombo2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtcombo2.FormattingEnabled = true;
            this.txtcombo2.Items.AddRange(new object[] {
            "Login",
            "Sign Up "});
            this.txtcombo2.Location = new System.Drawing.Point(432, 169);
            this.txtcombo2.Name = "txtcombo2";
            this.txtcombo2.Size = new System.Drawing.Size(220, 21);
            this.txtcombo2.TabIndex = 27;
            this.txtcombo2.Text = "Do you want to Sign In / Sign Up";
            // 
            // txtoption2
            // 
            this.txtoption2.AutoSize = true;
            this.txtoption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoption2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtoption2.Location = new System.Drawing.Point(321, 168);
            this.txtoption2.Name = "txtoption2";
            this.txtoption2.Size = new System.Drawing.Size(105, 18);
            this.txtoption2.TabIndex = 26;
            this.txtoption2.Text = "Select Option :";
            // 
            // txtproceed
            // 
            this.txtproceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproceed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtproceed.Location = new System.Drawing.Point(455, 244);
            this.txtproceed.Name = "txtproceed";
            this.txtproceed.Size = new System.Drawing.Size(106, 38);
            this.txtproceed.TabIndex = 24;
            this.txtproceed.Text = "PROCEED";
            this.txtproceed.UseVisualStyleBackColor = true;
            this.txtproceed.Click += new System.EventHandler(this.txtproceed_Click);
            // 
            // txtoption1
            // 
            this.txtoption1.AutoSize = true;
            this.txtoption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtoption1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtoption1.Location = new System.Drawing.Point(321, 111);
            this.txtoption1.Name = "txtoption1";
            this.txtoption1.Size = new System.Drawing.Size(105, 18);
            this.txtoption1.TabIndex = 23;
            this.txtoption1.Text = "Select Option :";
            // 
            // txtwelcomelabel
            // 
            this.txtwelcomelabel.AutoSize = true;
            this.txtwelcomelabel.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwelcomelabel.Location = new System.Drawing.Point(315, 24);
            this.txtwelcomelabel.Name = "txtwelcomelabel";
            this.txtwelcomelabel.Size = new System.Drawing.Size(363, 25);
            this.txtwelcomelabel.TabIndex = 22;
            this.txtwelcomelabel.Text = "WELCOME TO THE DR.ASSISTANT ! ";
            // 
            // txtcombo1
            // 
            this.txtcombo1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcombo1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtcombo1.FormattingEnabled = true;
            this.txtcombo1.Items.AddRange(new object[] {
            "Doctor",
            "Patient"});
            this.txtcombo1.Location = new System.Drawing.Point(432, 112);
            this.txtcombo1.Name = "txtcombo1";
            this.txtcombo1.Size = new System.Drawing.Size(220, 21);
            this.txtcombo1.TabIndex = 21;
            this.txtcombo1.Text = "Whom would you like to proceed ?";
//            this.txtcombo1.SelectedIndexChanged += new System.EventHandler(this.txtcombo1_SelectedIndex);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.txtpicturelabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 399);
            this.panel1.TabIndex = 20;
            // 
            // txtpicturelabel
            // 
            this.txtpicturelabel.AutoSize = true;
            this.txtpicturelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpicturelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtpicturelabel.Location = new System.Drawing.Point(12, 6);
            this.txtpicturelabel.Name = "txtpicturelabel";
            this.txtpicturelabel.Size = new System.Drawing.Size(226, 31);
            this.txtpicturelabel.TabIndex = 8;
            this.txtpicturelabel.Text = "DR.ASSISTANT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtexit
            // 
            this.txtexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtexit.Location = new System.Drawing.Point(593, 244);
            this.txtexit.Name = "txtexit";
            this.txtexit.Size = new System.Drawing.Size(81, 38);
            this.txtexit.TabIndex = 25;
            this.txtexit.Text = "E&XIT";
            this.txtexit.UseVisualStyleBackColor = true;
            this.txtexit.Click += new System.EventHandler(this.txtexit_Click);
            // 
            // First_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(787, 433);
            this.Controls.Add(this.txtfull);
            this.Controls.Add(this.txtcombo2);
            this.Controls.Add(this.txtoption2);
            this.Controls.Add(this.txtexit);
            this.Controls.Add(this.txtproceed);
            this.Controls.Add(this.txtoption1);
            this.Controls.Add(this.txtwelcomelabel);
            this.Controls.Add(this.txtcombo1);
            this.Controls.Add(this.panel1);
            this.Name = "First_Page";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtfull;
        private System.Windows.Forms.ComboBox txtcombo2;
        private System.Windows.Forms.Label txtoption2;
        private System.Windows.Forms.Button txtproceed;
        private System.Windows.Forms.Label txtoption1;
        private System.Windows.Forms.Label txtwelcomelabel;
        private System.Windows.Forms.ComboBox txtcombo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtpicturelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button txtexit;
    }
}

