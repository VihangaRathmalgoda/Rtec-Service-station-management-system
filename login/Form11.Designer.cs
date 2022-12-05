
namespace login
{
    partial class frmDailyTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDailyTransaction));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvIteamTransactionTable = new System.Windows.Forms.DataGridView();
            this.dgvDailyServiceTransactionTable = new System.Windows.Forms.DataGridView();
            this.lblDailyIteam = new System.Windows.Forms.Label();
            this.lblDailyService = new System.Windows.Forms.Label();
            this.btnDailyIteamShow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1Iteam = new System.Windows.Forms.DateTimePicker();
            this.btnPrevious6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteamTransactionTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyServiceTransactionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 54);
            this.label2.TabIndex = 30;
            this.label2.Text = "Today Transaction";
            // 
            // dgvIteamTransactionTable
            // 
            this.dgvIteamTransactionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIteamTransactionTable.Location = new System.Drawing.Point(15, 107);
            this.dgvIteamTransactionTable.Name = "dgvIteamTransactionTable";
            this.dgvIteamTransactionTable.RowHeadersWidth = 51;
            this.dgvIteamTransactionTable.RowTemplate.Height = 24;
            this.dgvIteamTransactionTable.Size = new System.Drawing.Size(305, 257);
            this.dgvIteamTransactionTable.TabIndex = 31;
            // 
            // dgvDailyServiceTransactionTable
            // 
            this.dgvDailyServiceTransactionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyServiceTransactionTable.Location = new System.Drawing.Point(359, 107);
            this.dgvDailyServiceTransactionTable.Name = "dgvDailyServiceTransactionTable";
            this.dgvDailyServiceTransactionTable.RowHeadersWidth = 51;
            this.dgvDailyServiceTransactionTable.RowTemplate.Height = 24;
            this.dgvDailyServiceTransactionTable.Size = new System.Drawing.Size(329, 257);
            this.dgvDailyServiceTransactionTable.TabIndex = 32;
            // 
            // lblDailyIteam
            // 
            this.lblDailyIteam.AutoSize = true;
            this.lblDailyIteam.BackColor = System.Drawing.Color.White;
            this.lblDailyIteam.Location = new System.Drawing.Point(19, 374);
            this.lblDailyIteam.Name = "lblDailyIteam";
            this.lblDailyIteam.Size = new System.Drawing.Size(21, 16);
            this.lblDailyIteam.TabIndex = 33;
            this.lblDailyIteam.Text = "00";
            // 
            // lblDailyService
            // 
            this.lblDailyService.AutoSize = true;
            this.lblDailyService.BackColor = System.Drawing.Color.White;
            this.lblDailyService.Location = new System.Drawing.Point(360, 369);
            this.lblDailyService.Name = "lblDailyService";
            this.lblDailyService.Size = new System.Drawing.Size(21, 16);
            this.lblDailyService.TabIndex = 34;
            this.lblDailyService.Text = "00";
            // 
            // btnDailyIteamShow
            // 
            this.btnDailyIteamShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDailyIteamShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDailyIteamShow.FlatAppearance.BorderSize = 0;
            this.btnDailyIteamShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailyIteamShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyIteamShow.ForeColor = System.Drawing.Color.White;
            this.btnDailyIteamShow.Location = new System.Drawing.Point(12, 408);
            this.btnDailyIteamShow.Name = "btnDailyIteamShow";
            this.btnDailyIteamShow.Size = new System.Drawing.Size(676, 94);
            this.btnDailyIteamShow.TabIndex = 37;
            this.btnDailyIteamShow.Text = "Show";
            this.btnDailyIteamShow.UseVisualStyleBackColor = false;
            this.btnDailyIteamShow.Click += new System.EventHandler(this.btnDailyIteamShow_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(522, 627);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(166, 53);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnItemDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemDelete.FlatAppearance.BorderSize = 0;
            this.btnItemDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnItemDelete.Location = new System.Drawing.Point(12, 508);
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(676, 73);
            this.btnItemDelete.TabIndex = 40;
            this.btnItemDelete.Text = "DELETE";
            this.btnItemDelete.UseVisualStyleBackColor = false;
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(356, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Date :";
            // 
            // dateTimePicker1Iteam
            // 
            this.dateTimePicker1Iteam.Location = new System.Drawing.Point(433, 79);
            this.dateTimePicker1Iteam.Name = "dateTimePicker1Iteam";
            this.dateTimePicker1Iteam.Size = new System.Drawing.Size(255, 22);
            this.dateTimePicker1Iteam.TabIndex = 54;
            // 
            // btnPrevious6
            // 
            this.btnPrevious6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrevious6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious6.ForeColor = System.Drawing.Color.White;
            this.btnPrevious6.Location = new System.Drawing.Point(15, 627);
            this.btnPrevious6.Name = "btnPrevious6";
            this.btnPrevious6.Size = new System.Drawing.Size(155, 53);
            this.btnPrevious6.TabIndex = 63;
            this.btnPrevious6.Text = "Previous";
            this.btnPrevious6.UseVisualStyleBackColor = false;
            this.btnPrevious6.Click += new System.EventHandler(this.btnPrevious6_Click);
            // 
            // frmDailyTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(712, 692);
            this.Controls.Add(this.btnPrevious6);
            this.Controls.Add(this.dateTimePicker1Iteam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnItemDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDailyIteamShow);
            this.Controls.Add(this.lblDailyService);
            this.Controls.Add(this.lblDailyIteam);
            this.Controls.Add(this.dgvDailyServiceTransactionTable);
            this.Controls.Add(this.dgvIteamTransactionTable);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDailyTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIteamTransactionTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyServiceTransactionTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvIteamTransactionTable;
        private System.Windows.Forms.DataGridView dgvDailyServiceTransactionTable;
        private System.Windows.Forms.Label lblDailyIteam;
        private System.Windows.Forms.Label lblDailyService;
        private System.Windows.Forms.Button btnDailyIteamShow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnItemDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Iteam;
        private System.Windows.Forms.Button btnPrevious6;
    }
}