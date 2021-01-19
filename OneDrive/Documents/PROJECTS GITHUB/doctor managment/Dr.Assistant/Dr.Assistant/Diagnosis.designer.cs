namespace OOP_PROJECT_WINDOW_FORM
{
    partial class Diagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnosis));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbSymptoms = new System.Windows.Forms.ListBox();
            this.view = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.txtDiagnose = new System.Windows.Forms.TextBox();
            this.lblSuggested = new System.Windows.Forms.Label();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 426);
            this.panel1.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "DR.ASSISTANT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::OOP_PROJECT_WINDOW_FORM.Properties.Resources._960x01;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 24);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(280, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Enter Today\'s Date : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(271, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Select The Symptoms :";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Abdominal Cramps",
            "Asthma that\'s hard to control",
            "Bloating",
            "Bloody stools",
            "Body pain",
            "Breathing Noisly",
            "Chest pain",
            "Chest Tightness",
            "Difficulty hearing",
            "Difficulty swallowing",
            "Dry cough",
            "Ear Ache",
            "Ear Drainage",
            "Enlarged tonsils",
            "Extreme tiredness",
            "Eye irritation",
            "Fatigue",
            "Fever",
            "Fluttering in chest",
            "Headache",
            "Irregular heartbeat",
            "Loose stools",
            "Loss of balance",
            "Loss of Speech and Movement",
            "Mild tiredness",
            "Muffled Hearing",
            "Nausea",
            "Red and Swollen Tonsils",
            "Scratchy Throat",
            "Severe Muscle or Body Aches",
            "Shortness of breath",
            "Sinus Pressure",
            "SneezingInflamed",
            "Sore throat",
            "Stubborn Cough",
            "Stuffy nose",
            "Sweating or chills",
            "Swollen Feet or Swollen Ankles , Legs and Abdomen",
            "Trouble breathing",
            "Watery eyes",
            "White patches on back of the throat"});
            this.checkedListBox1.Location = new System.Drawing.Point(393, 204);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(242, 154);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 76;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(336, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 35);
            this.label3.TabIndex = 77;
            this.label3.Text = "DISEASE PREDICTION ENGINE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(279, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(618, 44);
            this.label5.TabIndex = 78;
            this.label5.Text = "Note : Welcome ! You can enter the symptoms you are facing and our system \r\nwill " +
    "predict not only disease but will also prescribe you the appropriate doctor";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(364, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 42);
            this.btnBack.TabIndex = 70;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(393, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 79;
            this.dateTimePicker1.Value = new System.DateTime(2020, 6, 8, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbSymptoms
            // 
            this.lbSymptoms.FormattingEnabled = true;
            this.lbSymptoms.Location = new System.Drawing.Point(652, 204);
            this.lbSymptoms.Name = "lbSymptoms";
            this.lbSymptoms.Size = new System.Drawing.Size(116, 147);
            this.lbSymptoms.TabIndex = 80;
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.view.Location = new System.Drawing.Point(519, 407);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(116, 42);
            this.view.TabIndex = 82;
            this.view.Text = "View Symtoms";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // btnFix
            // 
            this.btnFix.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFix.Location = new System.Drawing.Point(806, 324);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(222, 54);
            this.btnFix.TabIndex = 83;
            this.btnFix.Text = "Fix Appointment";
            this.btnFix.UseVisualStyleBackColor = false;
            this.btnFix.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(674, 407);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 42);
            this.btnSubmit.TabIndex = 70;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.AutoSize = true;
            this.lblDiagnosis.BackColor = System.Drawing.Color.Transparent;
            this.lblDiagnosis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDiagnosis.Location = new System.Drawing.Point(803, 160);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(105, 13);
            this.lblDiagnosis.TabIndex = 81;
            this.lblDiagnosis.Text = "Disease Diagnosed :";
            // 
            // txtDiagnose
            // 
            this.txtDiagnose.Location = new System.Drawing.Point(806, 191);
            this.txtDiagnose.Name = "txtDiagnose";
            this.txtDiagnose.Size = new System.Drawing.Size(222, 20);
            this.txtDiagnose.TabIndex = 84;
            // 
            // lblSuggested
            // 
            this.lblSuggested.AutoSize = true;
            this.lblSuggested.BackColor = System.Drawing.Color.Transparent;
            this.lblSuggested.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSuggested.Location = new System.Drawing.Point(803, 238);
            this.lblSuggested.Name = "lblSuggested";
            this.lblSuggested.Size = new System.Drawing.Size(99, 13);
            this.lblSuggested.TabIndex = 81;
            this.lblSuggested.Text = "Doctor Suggested :";
            // 
            // txtDoctor
            // 
            this.txtDoctor.Location = new System.Drawing.Point(806, 269);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(222, 20);
            this.txtDoctor.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(649, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 81;
            this.label6.Text = "Symptoms Selected :";
            // 
            // Diagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP_PROJECT_WINDOW_FORM.Properties.Resources._960x01;
            this.ClientSize = new System.Drawing.Size(1048, 476);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.txtDiagnose);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.view);
            this.Controls.Add(this.lblSuggested);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbSymptoms);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Diagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FourthPage";
            this.Load += new System.EventHandler(this.Diagnosis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox lbSymptoms;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.TextBox txtDiagnose;
        private System.Windows.Forms.Label lblSuggested;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Label label6;
    }
}