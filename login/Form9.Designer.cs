
namespace login
{
    partial class frmAdminOnly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminOnly));
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkbxShowPassword = new System.Windows.Forms.CheckBox();
            this.txtPasswordAdmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsernameAdmin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(90, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(27, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbxShowPassword
            // 
            this.checkbxShowPassword.AutoSize = true;
            this.checkbxShowPassword.BackColor = System.Drawing.Color.Gray;
            this.checkbxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkbxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkbxShowPassword.ForeColor = System.Drawing.Color.Black;
            this.checkbxShowPassword.Location = new System.Drawing.Point(150, 235);
            this.checkbxShowPassword.Name = "checkbxShowPassword";
            this.checkbxShowPassword.Size = new System.Drawing.Size(121, 20);
            this.checkbxShowPassword.TabIndex = 21;
            this.checkbxShowPassword.Text = "Show Password";
            this.checkbxShowPassword.UseVisualStyleBackColor = false;
            this.checkbxShowPassword.CheckedChanged += new System.EventHandler(this.checkbxShowPassword_CheckedChanged);
            // 
            // txtPasswordAdmin
            // 
            this.txtPasswordAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPasswordAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordAdmin.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordAdmin.Location = new System.Drawing.Point(27, 179);
            this.txtPasswordAdmin.Multiline = true;
            this.txtPasswordAdmin.Name = "txtPasswordAdmin";
            this.txtPasswordAdmin.PasswordChar = '*';
            this.txtPasswordAdmin.Size = new System.Drawing.Size(248, 28);
            this.txtPasswordAdmin.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password";
            // 
            // txtUsernameAdmin
            // 
            this.txtUsernameAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUsernameAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameAdmin.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameAdmin.Location = new System.Drawing.Point(27, 82);
            this.txtUsernameAdmin.Multiline = true;
            this.txtUsernameAdmin.Name = "txtUsernameAdmin";
            this.txtUsernameAdmin.Size = new System.Drawing.Size(248, 28);
            this.txtUsernameAdmin.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Username";
            // 
            // frmAdminOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(308, 463);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkbxShowPassword);
            this.Controls.Add(this.txtPasswordAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsernameAdmin);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminOnly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkbxShowPassword;
        private System.Windows.Forms.TextBox txtPasswordAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsernameAdmin;
        private System.Windows.Forms.Label label2;
    }
}