namespace OOP_PROJECT_WINDOW_FORM
{
    partial class PatientRecords
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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientlbl = new System.Windows.Forms.Label();
            this.Symptomslb = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(9, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(100, 28);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(51, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(754, 436);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            // 
            // patientlbl
            // 
            this.patientlbl.AutoSize = true;
            this.patientlbl.BackColor = System.Drawing.SystemColors.Desktop;
            this.patientlbl.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientlbl.Location = new System.Drawing.Point(238, 24);
            this.patientlbl.Name = "patientlbl";
            this.patientlbl.Size = new System.Drawing.Size(107, 26);
            this.patientlbl.TabIndex = 1;
            this.patientlbl.Text = "label1";
            // 
            // Symptomslb
            // 
            this.Symptomslb.FormattingEnabled = true;
            this.Symptomslb.Location = new System.Drawing.Point(825, 64);
            this.Symptomslb.Name = "Symptomslb";
            this.Symptomslb.Size = new System.Drawing.Size(140, 225);
            this.Symptomslb.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(869, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "&BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(83, 449);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(58, 16);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "lblNote";
            // 
            // PatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(977, 523);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Symptomslb);
            this.Controls.Add(this.patientlbl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PatientRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PateintRecords";
            this.Load += new System.EventHandler(this.PatientRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label patientlbl;
        private System.Windows.Forms.ListBox Symptomslb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNote;
    }
}