namespace OOP_PROJECT_WINDOW_FORM
{
    partial class Approve_drugs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnapprove = new System.Windows.Forms.Button();
            this.lblSno = new System.Windows.Forms.Label();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.btndiscard = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblApprove = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSuggest = new System.Windows.Forms.Label();
            this.btnDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(171, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnAdded);
            // 
            // btnapprove
            // 
            this.btnapprove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnapprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapprove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnapprove.Location = new System.Drawing.Point(545, 430);
            this.btnapprove.Name = "btnapprove";
            this.btnapprove.Size = new System.Drawing.Size(87, 34);
            this.btnapprove.TabIndex = 1;
            this.btnapprove.Text = "Approve";
            this.btnapprove.UseVisualStyleBackColor = false;
            this.btnapprove.Click += new System.EventHandler(this.btnapprove_Click);
            // 
            // lblSno
            // 
            this.lblSno.AutoSize = true;
            this.lblSno.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSno.Location = new System.Drawing.Point(358, 441);
            this.lblSno.Name = "lblSno";
            this.lblSno.Size = new System.Drawing.Size(51, 16);
            this.lblSno.TabIndex = 2;
            this.lblSno.Text = "S_No : ";
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(421, 438);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(69, 20);
            this.txtSno.TabIndex = 3;
            // 
            // btndiscard
            // 
            this.btndiscard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiscard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndiscard.Location = new System.Drawing.Point(652, 430);
            this.btndiscard.Name = "btndiscard";
            this.btndiscard.Size = new System.Drawing.Size(92, 34);
            this.btndiscard.TabIndex = 1;
            this.btndiscard.Text = "Discard";
            this.btndiscard.UseVisualStyleBackColor = false;
            this.btndiscard.Click += new System.EventHandler(this.btndiscard_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(919, 430);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 37);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "&BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 480);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(10, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Doctors Info";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(10, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "Approve Drugs";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(10, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 66);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add Tablets";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(10, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 64);
            this.button4.TabIndex = 2;
            this.button4.Text = "View Tablets";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(10, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 68);
            this.button5.TabIndex = 3;
            this.button5.Text = "Search Doctor";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblApprove
            // 
            this.lblApprove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApprove.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApprove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblApprove.Location = new System.Drawing.Point(390, 9);
            this.lblApprove.Name = "lblApprove";
            this.lblApprove.Size = new System.Drawing.Size(275, 39);
            this.lblApprove.TabIndex = 8;
            this.lblApprove.Text = "APPROVE DRUGS";
            this.lblApprove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(862, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 33;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(793, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Date :";
            // 
            // lblSuggest
            // 
            this.lblSuggest.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSuggest.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSuggest.Location = new System.Drawing.Point(376, 9);
            this.lblSuggest.Name = "lblSuggest";
            this.lblSuggest.Size = new System.Drawing.Size(310, 39);
            this.lblSuggest.TabIndex = 34;
            this.lblSuggest.Text = "SUGGESTED DRUGS";
            this.lblSuggest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDoc
            // 
            this.btnDoc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDoc.Location = new System.Drawing.Point(919, 430);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(88, 37);
            this.btnDoc.TabIndex = 35;
            this.btnDoc.Text = "&BACK";
            this.btnDoc.UseVisualStyleBackColor = false;
            this.btnDoc.Click += new System.EventHandler(this.button6_Click);
            // 
            // Approve_drugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OOP_PROJECT_WINDOW_FORM.Properties.Resources._960x01;
            this.ClientSize = new System.Drawing.Size(1040, 478);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.lblSuggest);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblApprove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.lblSno);
            this.Controls.Add(this.btndiscard);
            this.Controls.Add(this.btnapprove);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Approve_drugs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Approve_drugs";
            this.Load += new System.EventHandler(this.Approve_drugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnapprove;
        private System.Windows.Forms.Label lblSno;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.Button btndiscard;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblApprove;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Label lblSuggest;
    }
}