
namespace login
{
    partial class frmManageStock7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageStock7));
            this.btnPrevious7 = new System.Windows.Forms.Button();
            this.btnClear7 = new System.Windows.Forms.Button();
            this.btnClose7 = new System.Windows.Forms.Button();
            this.dgvServiceTable7 = new System.Windows.Forms.DataGridView();
            this.dgvBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvService7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSservicePrice7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIteamTable7 = new System.Windows.Forms.DataGridView();
            this.dgvIteamBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIteam7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuantity7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIteamPrice7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtServicePrice7 = new System.Windows.Forms.TextBox();
            this.txtService7 = new System.Windows.Forms.TextBox();
            this.txtIteamPrice7 = new System.Windows.Forms.TextBox();
            this.txtQuantity7 = new System.Windows.Forms.TextBox();
            this.txtIteam7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd7 = new System.Windows.Forms.Button();
            this.btnShow7 = new System.Windows.Forms.Button();
            this.txtVehicleBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddService7 = new System.Windows.Forms.Button();
            this.txtIteamBrand = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteamTable7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevious7
            // 
            this.btnPrevious7.BackColor = System.Drawing.Color.Gray;
            this.btnPrevious7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious7.ForeColor = System.Drawing.Color.White;
            this.btnPrevious7.Location = new System.Drawing.Point(17, 625);
            this.btnPrevious7.Name = "btnPrevious7";
            this.btnPrevious7.Size = new System.Drawing.Size(155, 58);
            this.btnPrevious7.TabIndex = 76;
            this.btnPrevious7.Text = "Previous";
            this.btnPrevious7.UseVisualStyleBackColor = false;
            this.btnPrevious7.Click += new System.EventHandler(this.btnPrevious7_Click);
            // 
            // btnClear7
            // 
            this.btnClear7.BackColor = System.Drawing.Color.Gray;
            this.btnClear7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear7.ForeColor = System.Drawing.Color.White;
            this.btnClear7.Location = new System.Drawing.Point(399, 627);
            this.btnClear7.Name = "btnClear7";
            this.btnClear7.Size = new System.Drawing.Size(145, 58);
            this.btnClear7.TabIndex = 75;
            this.btnClear7.Text = "Clear";
            this.btnClear7.UseVisualStyleBackColor = false;
            this.btnClear7.Click += new System.EventHandler(this.btnClear7_Click);
            // 
            // btnClose7
            // 
            this.btnClose7.BackColor = System.Drawing.Color.Gray;
            this.btnClose7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose7.ForeColor = System.Drawing.Color.White;
            this.btnClose7.Location = new System.Drawing.Point(726, 625);
            this.btnClose7.Name = "btnClose7";
            this.btnClose7.Size = new System.Drawing.Size(184, 60);
            this.btnClose7.TabIndex = 74;
            this.btnClose7.Text = "Close";
            this.btnClose7.UseVisualStyleBackColor = false;
            this.btnClose7.Click += new System.EventHandler(this.btnClose7_Click);
            // 
            // dgvServiceTable7
            // 
            this.dgvServiceTable7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceTable7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBrand,
            this.dgvService7,
            this.dgvSservicePrice7});
            this.dgvServiceTable7.Location = new System.Drawing.Point(476, 321);
            this.dgvServiceTable7.Name = "dgvServiceTable7";
            this.dgvServiceTable7.RowHeadersWidth = 51;
            this.dgvServiceTable7.RowTemplate.Height = 24;
            this.dgvServiceTable7.Size = new System.Drawing.Size(433, 284);
            this.dgvServiceTable7.TabIndex = 73;
            // 
            // dgvBrand
            // 
            this.dgvBrand.HeaderText = "Brand";
            this.dgvBrand.MinimumWidth = 6;
            this.dgvBrand.Name = "dgvBrand";
            this.dgvBrand.Width = 125;
            // 
            // dgvService7
            // 
            this.dgvService7.HeaderText = "Service";
            this.dgvService7.MinimumWidth = 6;
            this.dgvService7.Name = "dgvService7";
            this.dgvService7.Width = 125;
            // 
            // dgvSservicePrice7
            // 
            this.dgvSservicePrice7.HeaderText = "Price";
            this.dgvSservicePrice7.MinimumWidth = 6;
            this.dgvSservicePrice7.Name = "dgvSservicePrice7";
            this.dgvSservicePrice7.Width = 125;
            // 
            // dgvIteamTable7
            // 
            this.dgvIteamTable7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIteamTable7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvIteamBrand,
            this.dgvIteam7,
            this.dgvQuantity7,
            this.dgvIteamPrice7});
            this.dgvIteamTable7.Location = new System.Drawing.Point(18, 321);
            this.dgvIteamTable7.Name = "dgvIteamTable7";
            this.dgvIteamTable7.RowHeadersWidth = 51;
            this.dgvIteamTable7.RowTemplate.Height = 24;
            this.dgvIteamTable7.Size = new System.Drawing.Size(436, 284);
            this.dgvIteamTable7.TabIndex = 72;
            // 
            // dgvIteamBrand
            // 
            this.dgvIteamBrand.HeaderText = "Brand";
            this.dgvIteamBrand.MinimumWidth = 6;
            this.dgvIteamBrand.Name = "dgvIteamBrand";
            this.dgvIteamBrand.Width = 125;
            // 
            // dgvIteam7
            // 
            this.dgvIteam7.HeaderText = "Iteam";
            this.dgvIteam7.MinimumWidth = 6;
            this.dgvIteam7.Name = "dgvIteam7";
            this.dgvIteam7.Width = 125;
            // 
            // dgvQuantity7
            // 
            this.dgvQuantity7.HeaderText = "Quantity";
            this.dgvQuantity7.MinimumWidth = 6;
            this.dgvQuantity7.Name = "dgvQuantity7";
            this.dgvQuantity7.Width = 125;
            // 
            // dgvIteamPrice7
            // 
            this.dgvIteamPrice7.HeaderText = "Price";
            this.dgvIteamPrice7.MinimumWidth = 6;
            this.dgvIteamPrice7.Name = "dgvIteamPrice7";
            this.dgvIteamPrice7.Width = 125;
            // 
            // txtServicePrice7
            // 
            this.txtServicePrice7.Location = new System.Drawing.Point(626, 161);
            this.txtServicePrice7.Multiline = true;
            this.txtServicePrice7.Name = "txtServicePrice7";
            this.txtServicePrice7.Size = new System.Drawing.Size(283, 30);
            this.txtServicePrice7.TabIndex = 71;
            // 
            // txtService7
            // 
            this.txtService7.Location = new System.Drawing.Point(626, 125);
            this.txtService7.Multiline = true;
            this.txtService7.Name = "txtService7";
            this.txtService7.Size = new System.Drawing.Size(283, 30);
            this.txtService7.TabIndex = 70;
            // 
            // txtIteamPrice7
            // 
            this.txtIteamPrice7.Location = new System.Drawing.Point(168, 199);
            this.txtIteamPrice7.Multiline = true;
            this.txtIteamPrice7.Name = "txtIteamPrice7";
            this.txtIteamPrice7.Size = new System.Drawing.Size(286, 30);
            this.txtIteamPrice7.TabIndex = 69;
            // 
            // txtQuantity7
            // 
            this.txtQuantity7.Location = new System.Drawing.Point(168, 163);
            this.txtQuantity7.Multiline = true;
            this.txtQuantity7.Name = "txtQuantity7";
            this.txtQuantity7.Size = new System.Drawing.Size(286, 30);
            this.txtQuantity7.TabIndex = 68;
            // 
            // txtIteam7
            // 
            this.txtIteam7.Location = new System.Drawing.Point(168, 127);
            this.txtIteam7.Multiline = true;
            this.txtIteam7.Name = "txtIteam7";
            this.txtIteam7.Size = new System.Drawing.Size(286, 30);
            this.txtIteam7.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 32);
            this.label6.TabIndex = 66;
            this.label6.Text = "Price      :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 65;
            this.label3.Text = "Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 32);
            this.label4.TabIndex = 64;
            this.label4.Text = "Price     :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 63;
            this.label1.Text = "Iteam      :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 32);
            this.label5.TabIndex = 62;
            this.label5.Text = "Service :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 69);
            this.label2.TabIndex = 61;
            this.label2.Text = "Manage Stock";
            // 
            // btnAdd7
            // 
            this.btnAdd7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd7.Location = new System.Drawing.Point(316, 233);
            this.btnAdd7.Name = "btnAdd7";
            this.btnAdd7.Size = new System.Drawing.Size(138, 61);
            this.btnAdd7.TabIndex = 77;
            this.btnAdd7.Text = "Add";
            this.btnAdd7.UseVisualStyleBackColor = true;
            this.btnAdd7.Click += new System.EventHandler(this.btnAdd7_Click);
            // 
            // btnShow7
            // 
            this.btnShow7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow7.Location = new System.Drawing.Point(771, 263);
            this.btnShow7.Name = "btnShow7";
            this.btnShow7.Size = new System.Drawing.Size(138, 52);
            this.btnShow7.TabIndex = 78;
            this.btnShow7.Text = "Show";
            this.btnShow7.UseVisualStyleBackColor = true;
            this.btnShow7.Click += new System.EventHandler(this.btnShow7_Click);
            // 
            // txtVehicleBrand
            // 
            this.txtVehicleBrand.Location = new System.Drawing.Point(626, 84);
            this.txtVehicleBrand.Multiline = true;
            this.txtVehicleBrand.Name = "txtVehicleBrand";
            this.txtVehicleBrand.Size = new System.Drawing.Size(283, 30);
            this.txtVehicleBrand.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 32);
            this.label7.TabIndex = 79;
            this.label7.Text = "Brand    :";
            // 
            // btnAddService7
            // 
            this.btnAddService7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService7.Location = new System.Drawing.Point(771, 197);
            this.btnAddService7.Name = "btnAddService7";
            this.btnAddService7.Size = new System.Drawing.Size(138, 61);
            this.btnAddService7.TabIndex = 81;
            this.btnAddService7.Text = "Add";
            this.btnAddService7.UseVisualStyleBackColor = true;
            this.btnAddService7.Click += new System.EventHandler(this.btnAddService7_Click);
            // 
            // txtIteamBrand
            // 
            this.txtIteamBrand.Location = new System.Drawing.Point(171, 91);
            this.txtIteamBrand.Multiline = true;
            this.txtIteamBrand.Name = "txtIteamBrand";
            this.txtIteamBrand.Size = new System.Drawing.Size(283, 30);
            this.txtIteamBrand.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 32);
            this.label8.TabIndex = 82;
            this.label8.Text = "Brand     :";
            // 
            // frmManageStock7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(937, 687);
            this.Controls.Add(this.txtIteamBrand);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddService7);
            this.Controls.Add(this.txtVehicleBrand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnShow7);
            this.Controls.Add(this.btnAdd7);
            this.Controls.Add(this.btnPrevious7);
            this.Controls.Add(this.btnClear7);
            this.Controls.Add(this.btnClose7);
            this.Controls.Add(this.dgvServiceTable7);
            this.Controls.Add(this.dgvIteamTable7);
            this.Controls.Add(this.txtServicePrice7);
            this.Controls.Add(this.txtService7);
            this.Controls.Add(this.txtIteamPrice7);
            this.Controls.Add(this.txtQuantity7);
            this.Controls.Add(this.txtIteam7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageStock7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.frmManageStock7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteamTable7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious7;
        private System.Windows.Forms.Button btnClear7;
        private System.Windows.Forms.Button btnClose7;
        private System.Windows.Forms.DataGridView dgvServiceTable7;
        private System.Windows.Forms.DataGridView dgvIteamTable7;
        private System.Windows.Forms.TextBox txtServicePrice7;
        private System.Windows.Forms.TextBox txtService7;
        private System.Windows.Forms.TextBox txtIteamPrice7;
        private System.Windows.Forms.TextBox txtQuantity7;
        private System.Windows.Forms.TextBox txtIteam7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd7;
        private System.Windows.Forms.Button btnShow7;
        private System.Windows.Forms.TextBox txtVehicleBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvService7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSservicePrice7;
        private System.Windows.Forms.Button btnAddService7;
        private System.Windows.Forms.TextBox txtIteamBrand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIteamBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIteam7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQuantity7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIteamPrice7;
    }
}