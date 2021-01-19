namespace WindowsFormsApplication3
{
    partial class secondpage
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.usertext = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(768, 138);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Black;
            this.username.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(219, 189);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(115, 28);
            this.username.TabIndex = 2;
            this.username.Text = "USERNAME";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.Color.Black;
            this.password.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(219, 250);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(117, 28);
            this.password.TabIndex = 3;
            this.password.Text = "PASSWORD";
            // 
            // usertext
            // 
            this.usertext.Location = new System.Drawing.Point(369, 197);
            this.usertext.Multiline = true;
            this.usertext.Name = "usertext";
            this.usertext.Size = new System.Drawing.Size(174, 20);
            this.usertext.TabIndex = 4;
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(369, 260);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(174, 20);
            this.passtext.TabIndex = 5;
            this.passtext.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.MediumOrchid;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Black;
            this.login.Location = new System.Drawing.Point(320, 326);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(103, 51);
            this.login.TabIndex = 6;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // secondpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 694);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.usertext);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "secondpage";
            this.Text = "secondpage";
            this.Load += new System.EventHandler(this.secondpage_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.username, 0);
            this.Controls.SetChildIndex(this.password, 0);
            this.Controls.SetChildIndex(this.usertext, 0);
            this.Controls.SetChildIndex(this.passtext, 0);
            this.Controls.SetChildIndex(this.login, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usertext;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Button login;
    }
}