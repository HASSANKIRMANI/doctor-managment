namespace WindowsFormsApplication3
{
    partial class firstpage
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
            this.nxtbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nxtbutton
            // 
            this.nxtbutton.BackColor = System.Drawing.Color.Black;
            this.nxtbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nxtbutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxtbutton.ForeColor = System.Drawing.Color.White;
            this.nxtbutton.Location = new System.Drawing.Point(401, 410);
            this.nxtbutton.Name = "nxtbutton";
            this.nxtbutton.Size = new System.Drawing.Size(110, 37);
            this.nxtbutton.TabIndex = 2;
            this.nxtbutton.Text = "NEXT";
            this.nxtbutton.UseVisualStyleBackColor = false;
            this.nxtbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Black;
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.White;
            this.exitbutton.Location = new System.Drawing.Point(231, 410);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(110, 37);
            this.exitbutton.TabIndex = 3;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // firstpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 694);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.nxtbutton);
            this.Name = "firstpage";
            this.Text = "firstpage";
            this.Controls.SetChildIndex(this.nxtbutton, 0);
            this.Controls.SetChildIndex(this.exitbutton, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nxtbutton;
        private System.Windows.Forms.Button exitbutton;
    }
}