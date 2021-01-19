namespace OOP_PROJECT_WINDOW_FORM
{
    partial class patientFunctions
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
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnDiagnosis = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.lblerror2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.VoiceCalling = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInfo.Location = new System.Drawing.Point(22, 37);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(144, 55);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "INFO";
            this.toolTip1.SetToolTip(this.btnInfo, "General Info");
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnDiagnosis
            // 
            this.btnDiagnosis.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnosis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDiagnosis.Location = new System.Drawing.Point(22, 116);
            this.btnDiagnosis.Name = "btnDiagnosis";
            this.btnDiagnosis.Size = new System.Drawing.Size(144, 50);
            this.btnDiagnosis.TabIndex = 2;
            this.btnDiagnosis.Text = "DIAGNOSIS";
            this.btnDiagnosis.UseVisualStyleBackColor = false;
            this.btnDiagnosis.Click += new System.EventHandler(this.btnDiagnosis_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRecord.Location = new System.Drawing.Point(22, 357);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(144, 56);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "View Medical Records";
            this.btnRecord.UseVisualStyleBackColor = false;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(766, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "&EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InfoText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(632, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "&LOGOUT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(22, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 56);
            this.button4.TabIndex = 6;
            this.button4.Text = "View Apointment";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBook.Location = new System.Drawing.Point(22, 191);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(144, 58);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "Book Appointment";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblerror2
            // 
            this.lblerror2.AutoSize = true;
            this.lblerror2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblerror2.Location = new System.Drawing.Point(26, 258);
            this.lblerror2.Name = "lblerror2";
            this.lblerror2.Size = new System.Drawing.Size(35, 13);
            this.lblerror2.TabIndex = 7;
            this.lblerror2.Text = "label2";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(22, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 53);
            this.button3.TabIndex = 8;
            this.button3.Text = "Generate Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lblerror2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnBook);
            this.panel1.Controls.Add(this.btnRecord);
            this.panel1.Controls.Add(this.btnDiagnosis);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 525);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Algerian", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(398, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient\'s Portal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::OOP_PROJECT_WINDOW_FORM.Properties.Resources.patientfun;
            this.pictureBox1.Location = new System.Drawing.Point(183, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(731, 525);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // VoiceCalling
            // 
            this.VoiceCalling.DoWork += new System.ComponentModel.DoWorkEventHandler(this.VoiceCalling_DoWork);
            // 
            // patientFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(915, 527);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "patientFunctions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patientFunctions";
            this.Load += new System.EventHandler(this.patientFunctions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnDiagnosis;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label lblerror2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker VoiceCalling;
    }
}