
namespace login
{
    partial class frmMonthlyReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonthlyReview));
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerMonth = new System.Windows.Forms.DateTimePicker();
            this.dgvMonthlyTable = new System.Windows.Forms.DataGridView();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMonthlyClear = new System.Windows.Forms.Button();
            this.btnCloseMonthly = new System.Windows.Forms.Button();
            this.btnPreviousMonthly = new System.Windows.Forms.Button();
            this.btnCheckMonthly = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(27, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 54);
            this.label2.TabIndex = 31;
            this.label2.Text = "Monthly Review";
            // 
            // dateTimePickerMonth
            // 
            this.dateTimePickerMonth.Location = new System.Drawing.Point(28, 84);
            this.dateTimePickerMonth.Name = "dateTimePickerMonth";
            this.dateTimePickerMonth.Size = new System.Drawing.Size(165, 22);
            this.dateTimePickerMonth.TabIndex = 32;
            // 
            // dgvMonthlyTable
            // 
            this.dgvMonthlyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthlyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDate,
            this.dgvIncome});
            this.dgvMonthlyTable.Location = new System.Drawing.Point(28, 133);
            this.dgvMonthlyTable.Name = "dgvMonthlyTable";
            this.dgvMonthlyTable.RowHeadersWidth = 51;
            this.dgvMonthlyTable.RowTemplate.Height = 24;
            this.dgvMonthlyTable.Size = new System.Drawing.Size(376, 344);
            this.dgvMonthlyTable.TabIndex = 33;
            // 
            // dgvDate
            // 
            this.dgvDate.HeaderText = "Date";
            this.dgvDate.MinimumWidth = 6;
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.Width = 125;
            // 
            // dgvIncome
            // 
            this.dgvIncome.HeaderText = "Income";
            this.dgvIncome.MinimumWidth = 6;
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.Width = 125;
            // 
            // btnMonthlyClear
            // 
            this.btnMonthlyClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMonthlyClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthlyClear.FlatAppearance.BorderSize = 0;
            this.btnMonthlyClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthlyClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyClear.ForeColor = System.Drawing.Color.White;
            this.btnMonthlyClear.Location = new System.Drawing.Point(27, 487);
            this.btnMonthlyClear.Name = "btnMonthlyClear";
            this.btnMonthlyClear.Size = new System.Drawing.Size(377, 76);
            this.btnMonthlyClear.TabIndex = 36;
            this.btnMonthlyClear.Text = "Clear";
            this.btnMonthlyClear.UseVisualStyleBackColor = false;
            this.btnMonthlyClear.Click += new System.EventHandler(this.btnMonthlyClear_Click);
            // 
            // btnCloseMonthly
            // 
            this.btnCloseMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCloseMonthly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseMonthly.FlatAppearance.BorderSize = 0;
            this.btnCloseMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseMonthly.ForeColor = System.Drawing.Color.White;
            this.btnCloseMonthly.Location = new System.Drawing.Point(238, 583);
            this.btnCloseMonthly.Name = "btnCloseMonthly";
            this.btnCloseMonthly.Size = new System.Drawing.Size(166, 53);
            this.btnCloseMonthly.TabIndex = 64;
            this.btnCloseMonthly.Text = "Close";
            this.btnCloseMonthly.UseVisualStyleBackColor = false;
            this.btnCloseMonthly.Click += new System.EventHandler(this.btnCloseMonthly_Click);
            // 
            // btnPreviousMonthly
            // 
            this.btnPreviousMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPreviousMonthly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousMonthly.FlatAppearance.BorderSize = 0;
            this.btnPreviousMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousMonthly.ForeColor = System.Drawing.Color.White;
            this.btnPreviousMonthly.Location = new System.Drawing.Point(27, 583);
            this.btnPreviousMonthly.Name = "btnPreviousMonthly";
            this.btnPreviousMonthly.Size = new System.Drawing.Size(166, 53);
            this.btnPreviousMonthly.TabIndex = 65;
            this.btnPreviousMonthly.Text = "Previous";
            this.btnPreviousMonthly.UseVisualStyleBackColor = false;
            this.btnPreviousMonthly.Click += new System.EventHandler(this.btnPreviousMonthly_Click);
            // 
            // btnCheckMonthly
            // 
            this.btnCheckMonthly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCheckMonthly.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckMonthly.FlatAppearance.BorderSize = 0;
            this.btnCheckMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckMonthly.ForeColor = System.Drawing.Color.White;
            this.btnCheckMonthly.Location = new System.Drawing.Point(199, 82);
            this.btnCheckMonthly.Name = "btnCheckMonthly";
            this.btnCheckMonthly.Size = new System.Drawing.Size(205, 45);
            this.btnCheckMonthly.TabIndex = 66;
            this.btnCheckMonthly.Text = "Check";
            this.btnCheckMonthly.UseVisualStyleBackColor = false;
            this.btnCheckMonthly.Click += new System.EventHandler(this.btnCheckMonthly_Click);
            // 
            // frmMonthlyReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(435, 658);
            this.Controls.Add(this.btnCheckMonthly);
            this.Controls.Add(this.btnPreviousMonthly);
            this.Controls.Add(this.btnCloseMonthly);
            this.Controls.Add(this.btnMonthlyClear);
            this.Controls.Add(this.dgvMonthlyTable);
            this.Controls.Add(this.dateTimePickerMonth);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMonthlyReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form12";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthlyTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerMonth;
        private System.Windows.Forms.DataGridView dgvMonthlyTable;
        private System.Windows.Forms.Button btnMonthlyClear;
        private System.Windows.Forms.Button btnCloseMonthly;
        private System.Windows.Forms.Button btnPreviousMonthly;
        private System.Windows.Forms.Button btnCheckMonthly;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIncome;
    }
}