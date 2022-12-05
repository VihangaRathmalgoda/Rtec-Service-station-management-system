
namespace login
{
    partial class frmBilling5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilling5));
            this.btnPrint5 = new System.Windows.Forms.Button();
            this.btnPrevious5 = new System.Windows.Forms.Button();
            this.btnClose5 = new System.Windows.Forms.Button();
            this.btnClear5 = new System.Windows.Forms.Button();
            this.dgvBilling5 = new System.Windows.Forms.DataGridView();
            this.dgvCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVehicleNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvServicePrice5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIteam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIteamPrice5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd5 = new System.Windows.Forms.Button();
            this.cmbIteam5 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbService5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVehicleNumber5 = new System.Windows.Forms.TextBox();
            this.txtCustomerName5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServiceCost5 = new System.Windows.Forms.TextBox();
            this.txtIteamPrice5 = new System.Windows.Forms.TextBox();
            this.dateTimePickerBilling = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint5
            // 
            this.btnPrint5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrint5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint5.ForeColor = System.Drawing.Color.White;
            this.btnPrint5.Location = new System.Drawing.Point(889, 236);
            this.btnPrint5.Name = "btnPrint5";
            this.btnPrint5.Size = new System.Drawing.Size(167, 271);
            this.btnPrint5.TabIndex = 61;
            this.btnPrint5.Text = "PRINT";
            this.btnPrint5.UseVisualStyleBackColor = false;
            this.btnPrint5.Click += new System.EventHandler(this.btnPrint5_Click);
            // 
            // btnPrevious5
            // 
            this.btnPrevious5.BackColor = System.Drawing.Color.Gray;
            this.btnPrevious5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious5.ForeColor = System.Drawing.Color.White;
            this.btnPrevious5.Location = new System.Drawing.Point(15, 532);
            this.btnPrevious5.Name = "btnPrevious5";
            this.btnPrevious5.Size = new System.Drawing.Size(155, 72);
            this.btnPrevious5.TabIndex = 60;
            this.btnPrevious5.Text = "Previous";
            this.btnPrevious5.UseVisualStyleBackColor = false;
            this.btnPrevious5.Click += new System.EventHandler(this.btnPrevious5_Click);
            // 
            // btnClose5
            // 
            this.btnClose5.BackColor = System.Drawing.Color.Gray;
            this.btnClose5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose5.ForeColor = System.Drawing.Color.White;
            this.btnClose5.Location = new System.Drawing.Point(878, 532);
            this.btnClose5.Name = "btnClose5";
            this.btnClose5.Size = new System.Drawing.Size(177, 72);
            this.btnClose5.TabIndex = 59;
            this.btnClose5.Text = "Close";
            this.btnClose5.UseVisualStyleBackColor = false;
            this.btnClose5.Click += new System.EventHandler(this.btnClose5_Click);
            // 
            // btnClear5
            // 
            this.btnClear5.BackColor = System.Drawing.Color.Gray;
            this.btnClear5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear5.ForeColor = System.Drawing.Color.White;
            this.btnClear5.Location = new System.Drawing.Point(427, 532);
            this.btnClear5.Name = "btnClear5";
            this.btnClear5.Size = new System.Drawing.Size(145, 72);
            this.btnClear5.TabIndex = 58;
            this.btnClear5.Text = "Clear";
            this.btnClear5.UseVisualStyleBackColor = false;
            this.btnClear5.Click += new System.EventHandler(this.btnClear5_Click);
            // 
            // dgvBilling5
            // 
            this.dgvBilling5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilling5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCustomerName,
            this.dgvVehicleNumber,
            this.dgvService,
            this.dgvServicePrice5,
            this.dgvIteam,
            this.dgvIteamPrice5});
            this.dgvBilling5.Location = new System.Drawing.Point(17, 236);
            this.dgvBilling5.Name = "dgvBilling5";
            this.dgvBilling5.RowHeadersWidth = 51;
            this.dgvBilling5.RowTemplate.Height = 24;
            this.dgvBilling5.Size = new System.Drawing.Size(852, 271);
            this.dgvBilling5.TabIndex = 57;
            // 
            // dgvCustomerName
            // 
            this.dgvCustomerName.HeaderText = "Customer Name";
            this.dgvCustomerName.MinimumWidth = 6;
            this.dgvCustomerName.Name = "dgvCustomerName";
            this.dgvCustomerName.Width = 125;
            // 
            // dgvVehicleNumber
            // 
            this.dgvVehicleNumber.HeaderText = "Vehicle Number";
            this.dgvVehicleNumber.MinimumWidth = 6;
            this.dgvVehicleNumber.Name = "dgvVehicleNumber";
            this.dgvVehicleNumber.Width = 125;
            // 
            // dgvService
            // 
            this.dgvService.HeaderText = "Service";
            this.dgvService.MinimumWidth = 6;
            this.dgvService.Name = "dgvService";
            this.dgvService.Width = 125;
            // 
            // dgvServicePrice5
            // 
            this.dgvServicePrice5.HeaderText = "Service Cost";
            this.dgvServicePrice5.MinimumWidth = 6;
            this.dgvServicePrice5.Name = "dgvServicePrice5";
            this.dgvServicePrice5.Width = 125;
            // 
            // dgvIteam
            // 
            this.dgvIteam.HeaderText = "Iteam";
            this.dgvIteam.MinimumWidth = 6;
            this.dgvIteam.Name = "dgvIteam";
            this.dgvIteam.Width = 125;
            // 
            // dgvIteamPrice5
            // 
            this.dgvIteamPrice5.HeaderText = "Iteam Price";
            this.dgvIteamPrice5.MinimumWidth = 6;
            this.dgvIteamPrice5.Name = "dgvIteamPrice5";
            this.dgvIteamPrice5.Width = 125;
            // 
            // btnAdd5
            // 
            this.btnAdd5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd5.ForeColor = System.Drawing.Color.White;
            this.btnAdd5.Location = new System.Drawing.Point(734, 145);
            this.btnAdd5.Name = "btnAdd5";
            this.btnAdd5.Size = new System.Drawing.Size(321, 70);
            this.btnAdd5.TabIndex = 56;
            this.btnAdd5.Text = "Add";
            this.btnAdd5.UseVisualStyleBackColor = false;
            this.btnAdd5.Click += new System.EventHandler(this.btnAdd5_Click);
            // 
            // cmbIteam5
            // 
            this.cmbIteam5.FormattingEnabled = true;
            this.cmbIteam5.Location = new System.Drawing.Point(205, 184);
            this.cmbIteam5.Name = "cmbIteam5";
            this.cmbIteam5.Size = new System.Drawing.Size(121, 24);
            this.cmbIteam5.TabIndex = 55;
            this.cmbIteam5.Text = "Empty";
            this.cmbIteam5.SelectedIndexChanged += new System.EventHandler(this.cmbItem5_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "Item";
            // 
            // cmbService5
            // 
            this.cmbService5.FormattingEnabled = true;
            this.cmbService5.Location = new System.Drawing.Point(205, 143);
            this.cmbService5.Name = "cmbService5";
            this.cmbService5.Size = new System.Drawing.Size(121, 24);
            this.cmbService5.TabIndex = 53;
            this.cmbService5.Text = "Empty";
            this.cmbService5.SelectedIndexChanged += new System.EventHandler(this.cmbSrvice5_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(729, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Vehicle Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Customer Name :";
            // 
            // txtVehicleNumber5
            // 
            this.txtVehicleNumber5.BackColor = System.Drawing.Color.LightGray;
            this.txtVehicleNumber5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVehicleNumber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleNumber5.Location = new System.Drawing.Point(732, 107);
            this.txtVehicleNumber5.Multiline = true;
            this.txtVehicleNumber5.Name = "txtVehicleNumber5";
            this.txtVehicleNumber5.Size = new System.Drawing.Size(323, 32);
            this.txtVehicleNumber5.TabIndex = 49;
            // 
            // txtCustomerName5
            // 
            this.txtCustomerName5.BackColor = System.Drawing.Color.LightGray;
            this.txtCustomerName5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName5.Location = new System.Drawing.Point(17, 107);
            this.txtCustomerName5.Multiline = true;
            this.txtCustomerName5.Name = "txtCustomerName5";
            this.txtCustomerName5.Size = new System.Drawing.Size(308, 32);
            this.txtCustomerName5.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 69);
            this.label2.TabIndex = 47;
            this.label2.Text = "Billing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 63;
            this.label6.Text = "Item Price     :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(332, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 62;
            this.label7.Text = "Service Cost :";
            // 
            // txtServiceCost5
            // 
            this.txtServiceCost5.BackColor = System.Drawing.Color.LightGray;
            this.txtServiceCost5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServiceCost5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceCost5.Location = new System.Drawing.Point(487, 135);
            this.txtServiceCost5.Multiline = true;
            this.txtServiceCost5.Name = "txtServiceCost5";
            this.txtServiceCost5.Size = new System.Drawing.Size(186, 32);
            this.txtServiceCost5.TabIndex = 64;
            this.txtServiceCost5.Text = "00";
            // 
            // txtIteamPrice5
            // 
            this.txtIteamPrice5.BackColor = System.Drawing.Color.LightGray;
            this.txtIteamPrice5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIteamPrice5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIteamPrice5.Location = new System.Drawing.Point(487, 180);
            this.txtIteamPrice5.Multiline = true;
            this.txtIteamPrice5.Name = "txtIteamPrice5";
            this.txtIteamPrice5.Size = new System.Drawing.Size(186, 32);
            this.txtIteamPrice5.TabIndex = 65;
            this.txtIteamPrice5.Text = "00";
            // 
            // dateTimePickerBilling
            // 
            this.dateTimePickerBilling.Location = new System.Drawing.Point(732, 26);
            this.dateTimePickerBilling.Name = "dateTimePickerBilling";
            this.dateTimePickerBilling.Size = new System.Drawing.Size(324, 22);
            this.dateTimePickerBilling.TabIndex = 66;
            // 
            // frmBilling5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1082, 625);
            this.Controls.Add(this.dateTimePickerBilling);
            this.Controls.Add(this.txtIteamPrice5);
            this.Controls.Add(this.txtServiceCost5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrint5);
            this.Controls.Add(this.btnPrevious5);
            this.Controls.Add(this.btnClose5);
            this.Controls.Add(this.btnClear5);
            this.Controls.Add(this.dgvBilling5);
            this.Controls.Add(this.btnAdd5);
            this.Controls.Add(this.cmbIteam5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbService5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVehicleNumber5);
            this.Controls.Add(this.txtCustomerName5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBilling5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.frmBilling5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilling5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint5;
        private System.Windows.Forms.Button btnPrevious5;
        private System.Windows.Forms.Button btnClose5;
        private System.Windows.Forms.Button btnClear5;
        private System.Windows.Forms.DataGridView dgvBilling5;
        private System.Windows.Forms.Button btnAdd5;
        private System.Windows.Forms.ComboBox cmbIteam5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbService5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVehicleNumber5;
        private System.Windows.Forms.TextBox txtCustomerName5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVehicleNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvService;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvServicePrice5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIteam;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIteamPrice5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtServiceCost5;
        private System.Windows.Forms.TextBox txtIteamPrice5;
        private System.Windows.Forms.DateTimePicker dateTimePickerBilling;
    }
}