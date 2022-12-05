
namespace login
{
    partial class frmBooking4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooking4));
            this.btnAdd4 = new System.Windows.Forms.Button();
            this.btncheck4 = new System.Windows.Forms.Button();
            this.btnPrevious4 = new System.Windows.Forms.Button();
            this.btnClose4 = new System.Windows.Forms.Button();
            this.btnClear4 = new System.Windows.Forms.Button();
            this.cmbTimePeriod4 = new System.Windows.Forms.ComboBox();
            this.cmbService4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBooking4 = new System.Windows.Forms.DataGridView();
            this.dgvTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStation1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStation2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStation3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbBookingTime4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCustomer1Name4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomer2Name4 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomer3Name4 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd4
            // 
            this.btnAdd4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd4.ForeColor = System.Drawing.Color.White;
            this.btnAdd4.Location = new System.Drawing.Point(555, 374);
            this.btnAdd4.Name = "btnAdd4";
            this.btnAdd4.Size = new System.Drawing.Size(169, 98);
            this.btnAdd4.TabIndex = 54;
            this.btnAdd4.Text = "Add";
            this.btnAdd4.UseVisualStyleBackColor = false;
            this.btnAdd4.Click += new System.EventHandler(this.btnAdd4_Click);
            // 
            // btncheck4
            // 
            this.btncheck4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncheck4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck4.ForeColor = System.Drawing.Color.White;
            this.btncheck4.Location = new System.Drawing.Point(555, 87);
            this.btncheck4.Name = "btncheck4";
            this.btncheck4.Size = new System.Drawing.Size(169, 49);
            this.btncheck4.TabIndex = 53;
            this.btncheck4.Text = "Check";
            this.btncheck4.UseVisualStyleBackColor = false;
            this.btncheck4.Click += new System.EventHandler(this.btncheck4_Click);
            // 
            // btnPrevious4
            // 
            this.btnPrevious4.BackColor = System.Drawing.Color.Gray;
            this.btnPrevious4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious4.ForeColor = System.Drawing.Color.White;
            this.btnPrevious4.Location = new System.Drawing.Point(12, 521);
            this.btnPrevious4.Name = "btnPrevious4";
            this.btnPrevious4.Size = new System.Drawing.Size(155, 42);
            this.btnPrevious4.TabIndex = 52;
            this.btnPrevious4.Text = "Previous";
            this.btnPrevious4.UseVisualStyleBackColor = false;
            this.btnPrevious4.Click += new System.EventHandler(this.btnPrevious4_Click);
            // 
            // btnClose4
            // 
            this.btnClose4.BackColor = System.Drawing.Color.Gray;
            this.btnClose4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose4.ForeColor = System.Drawing.Color.White;
            this.btnClose4.Location = new System.Drawing.Point(562, 521);
            this.btnClose4.Name = "btnClose4";
            this.btnClose4.Size = new System.Drawing.Size(162, 42);
            this.btnClose4.TabIndex = 51;
            this.btnClose4.Text = "Close";
            this.btnClose4.UseVisualStyleBackColor = false;
            this.btnClose4.Click += new System.EventHandler(this.btnClose4_Click);
            // 
            // btnClear4
            // 
            this.btnClear4.BackColor = System.Drawing.Color.Gray;
            this.btnClear4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear4.ForeColor = System.Drawing.Color.White;
            this.btnClear4.Location = new System.Drawing.Point(195, 521);
            this.btnClear4.Name = "btnClear4";
            this.btnClear4.Size = new System.Drawing.Size(145, 42);
            this.btnClear4.TabIndex = 50;
            this.btnClear4.Text = "Clear";
            this.btnClear4.UseVisualStyleBackColor = false;
            this.btnClear4.Click += new System.EventHandler(this.btnClear4_Click);
            // 
            // cmbTimePeriod4
            // 
            this.cmbTimePeriod4.FormattingEnabled = true;
            this.cmbTimePeriod4.Items.AddRange(new object[] {
            "08-09",
            "09-10",
            "10-11",
            "12-01",
            "01-02",
            "02-03",
            "03-04",
            "04-05"});
            this.cmbTimePeriod4.Location = new System.Drawing.Point(209, 447);
            this.cmbTimePeriod4.Name = "cmbTimePeriod4";
            this.cmbTimePeriod4.Size = new System.Drawing.Size(121, 24);
            this.cmbTimePeriod4.TabIndex = 49;
            this.cmbTimePeriod4.SelectedIndexChanged += new System.EventHandler(this.cmbTimePeriod4_SelectedIndexChanged);
            // 
            // cmbService4
            // 
            this.cmbService4.FormattingEnabled = true;
            this.cmbService4.Items.AddRange(new object[] {
            "Body Wash",
            "Oil Change",
            "Under Wash",
            "Vaccum Cleaning",
            "Alignment Check",
            "Full Service",
            "Inspection and Scan",
            "Engine Room wash",
            "Battery Recharge",
            "Inside cleaning",
            "Tyer side Change"});
            this.cmbService4.Location = new System.Drawing.Point(210, 407);
            this.cmbService4.Name = "cmbService4";
            this.cmbService4.Size = new System.Drawing.Size(121, 24);
            this.cmbService4.TabIndex = 48;
            this.cmbService4.SelectedIndexChanged += new System.EventHandler(this.cmbService4_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Time Period";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Service";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Customer Name :";
            // 
            // dgvBooking4
            // 
            this.dgvBooking4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooking4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTime,
            this.dgvStation1,
            this.dgvStation2,
            this.dgvStation3});
            this.dgvBooking4.Location = new System.Drawing.Point(17, 151);
            this.dgvBooking4.Name = "dgvBooking4";
            this.dgvBooking4.RowHeadersWidth = 51;
            this.dgvBooking4.RowTemplate.Height = 24;
            this.dgvBooking4.Size = new System.Drawing.Size(707, 163);
            this.dgvBooking4.TabIndex = 41;
            // 
            // dgvTime
            // 
            this.dgvTime.HeaderText = "Time";
            this.dgvTime.MinimumWidth = 6;
            this.dgvTime.Name = "dgvTime";
            this.dgvTime.Width = 125;
            // 
            // dgvStation1
            // 
            this.dgvStation1.HeaderText = "Station1";
            this.dgvStation1.MinimumWidth = 6;
            this.dgvStation1.Name = "dgvStation1";
            this.dgvStation1.Width = 125;
            // 
            // dgvStation2
            // 
            this.dgvStation2.HeaderText = "Station2";
            this.dgvStation2.MinimumWidth = 6;
            this.dgvStation2.Name = "dgvStation2";
            this.dgvStation2.Width = 125;
            // 
            // dgvStation3
            // 
            this.dgvStation3.HeaderText = "Station3";
            this.dgvStation3.MinimumWidth = 6;
            this.dgvStation3.Name = "dgvStation3";
            this.dgvStation3.Width = 125;
            // 
            // cmbBookingTime4
            // 
            this.cmbBookingTime4.FormattingEnabled = true;
            this.cmbBookingTime4.Items.AddRange(new object[] {
            "08-09",
            "09-10",
            "10-11",
            "12-01",
            "01-02",
            "02-03",
            "03-04",
            "04-05"});
            this.cmbBookingTime4.Location = new System.Drawing.Point(175, 109);
            this.cmbBookingTime4.Name = "cmbBookingTime4";
            this.cmbBookingTime4.Size = new System.Drawing.Size(121, 24);
            this.cmbBookingTime4.TabIndex = 40;
            this.cmbBookingTime4.SelectedIndexChanged += new System.EventHandler(this.cmbBookingTime4_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Booking Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 69);
            this.label2.TabIndex = 38;
            this.label2.Text = "Booking";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(381, 521);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 42);
            this.btnDelete.TabIndex = 57;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCustomer1Name4
            // 
            this.txtCustomer1Name4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomer1Name4.DefaultText = "";
            this.txtCustomer1Name4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomer1Name4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomer1Name4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomer1Name4.DisabledState.Parent = this.txtCustomer1Name4;
            this.txtCustomer1Name4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomer1Name4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomer1Name4.FocusedState.Parent = this.txtCustomer1Name4;
            this.txtCustomer1Name4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomer1Name4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomer1Name4.HoverState.Parent = this.txtCustomer1Name4;
            this.txtCustomer1Name4.Location = new System.Drawing.Point(210, 325);
            this.txtCustomer1Name4.Name = "txtCustomer1Name4";
            this.txtCustomer1Name4.PasswordChar = '\0';
            this.txtCustomer1Name4.PlaceholderText = "Name for sec.01";
            this.txtCustomer1Name4.SelectedText = "";
            this.txtCustomer1Name4.ShadowDecoration.Parent = this.txtCustomer1Name4;
            this.txtCustomer1Name4.Size = new System.Drawing.Size(166, 35);
            this.txtCustomer1Name4.TabIndex = 58;
            // 
            // txtCustomer2Name4
            // 
            this.txtCustomer2Name4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomer2Name4.DefaultText = "";
            this.txtCustomer2Name4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomer2Name4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomer2Name4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomer2Name4.DisabledState.Parent = this.txtCustomer2Name4;
            this.txtCustomer2Name4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomer2Name4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomer2Name4.FocusedState.Parent = this.txtCustomer2Name4;
            this.txtCustomer2Name4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomer2Name4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomer2Name4.HoverState.Parent = this.txtCustomer2Name4;
            this.txtCustomer2Name4.Location = new System.Drawing.Point(382, 324);
            this.txtCustomer2Name4.Name = "txtCustomer2Name4";
            this.txtCustomer2Name4.PasswordChar = '\0';
            this.txtCustomer2Name4.PlaceholderText = "Name for sec.02";
            this.txtCustomer2Name4.SelectedText = "";
            this.txtCustomer2Name4.ShadowDecoration.Parent = this.txtCustomer2Name4;
            this.txtCustomer2Name4.Size = new System.Drawing.Size(167, 36);
            this.txtCustomer2Name4.TabIndex = 59;
            // 
            // txtCustomer3Name4
            // 
            this.txtCustomer3Name4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomer3Name4.DefaultText = "";
            this.txtCustomer3Name4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomer3Name4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomer3Name4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomer3Name4.DisabledState.Parent = this.txtCustomer3Name4;
            this.txtCustomer3Name4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomer3Name4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomer3Name4.FocusedState.Parent = this.txtCustomer3Name4;
            this.txtCustomer3Name4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomer3Name4.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomer3Name4.HoverState.Parent = this.txtCustomer3Name4;
            this.txtCustomer3Name4.Location = new System.Drawing.Point(555, 324);
            this.txtCustomer3Name4.Name = "txtCustomer3Name4";
            this.txtCustomer3Name4.PasswordChar = '\0';
            this.txtCustomer3Name4.PlaceholderText = "Name for sec.03";
            this.txtCustomer3Name4.SelectedText = "";
            this.txtCustomer3Name4.ShadowDecoration.Parent = this.txtCustomer3Name4;
            this.txtCustomer3Name4.Size = new System.Drawing.Size(169, 36);
            this.txtCustomer3Name4.TabIndex = 60;
            // 
            // frmBooking4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(763, 576);
            this.Controls.Add(this.txtCustomer3Name4);
            this.Controls.Add(this.txtCustomer2Name4);
            this.Controls.Add(this.txtCustomer1Name4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd4);
            this.Controls.Add(this.btncheck4);
            this.Controls.Add(this.btnPrevious4);
            this.Controls.Add(this.btnClose4);
            this.Controls.Add(this.btnClear4);
            this.Controls.Add(this.cmbTimePeriod4);
            this.Controls.Add(this.cmbService4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBooking4);
            this.Controls.Add(this.cmbBookingTime4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBooking4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.frmBooking4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooking4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd4;
        private System.Windows.Forms.Button btncheck4;
        private System.Windows.Forms.Button btnPrevious4;
        private System.Windows.Forms.Button btnClose4;
        private System.Windows.Forms.Button btnClear4;
        private System.Windows.Forms.ComboBox cmbTimePeriod4;
        private System.Windows.Forms.ComboBox cmbService4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBooking4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStation1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStation2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStation3;
        private System.Windows.Forms.ComboBox cmbBookingTime4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomer1Name4;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomer2Name4;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomer3Name4;
    }
}