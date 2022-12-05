using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace login
{
    public partial class frmDailyTransaction : Form
    {
        public frmDailyTransaction()
        {
            InitializeComponent();
           
        }
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:\\test\\login\\login\\bin\\Debug\\New folder\\db_users1.mdb");
        OleDbCommand cmd1 = new OleDbCommand();
        OleDbDataAdapter da1 = new OleDbDataAdapter();

        private void btnDailyIteamShow_Click(object sender, EventArgs e)
        {

            conn.Open();
            OleDbCommand cmd1 = new OleDbCommand();
            cmd1.Connection = conn;
            String qu = "select * from dailyItemTransction";
            cmd1.CommandText = qu;

            OleDbDataAdapter d = new OleDbDataAdapter(cmd1);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dgvIteamTransactionTable.DataSource = dt;
            conn.Close();

            conn.Open();
            OleDbCommand cmd2 = new OleDbCommand();
            cmd2.Connection = conn;
            String qu1 = "select * from DailyServiceTransaction";
            cmd2.CommandText = qu1;

            OleDbDataAdapter d1 = new OleDbDataAdapter(cmd2);
            DataTable dt1 = new DataTable();
            d1.Fill(dt1);
            dgvDailyServiceTransactionTable.DataSource = dt1;
            conn.Close();

            int IteamDaily = 0;
            for (int i = 0; i < dgvIteamTransactionTable.Rows.Count; i++)
            {
                IteamDaily += Convert.ToInt32(dgvIteamTransactionTable.Rows[i].Cells[1].Value);

            }
            lblDailyIteam.Text = IteamDaily.ToString();

            int ServiceDaily = 0;
            for (int j = 0; j < dgvDailyServiceTransactionTable.Rows.Count; j++)
            {
                ServiceDaily += Convert.ToInt32(dgvDailyServiceTransactionTable.Rows[j].Cells[1].Value);

            }
            lblDailyService.Text = ServiceDaily.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDailyServiceShow_Click(object sender, EventArgs e)
        {
            

            
        }

        private void btnDailyIteam_Click(object sender, EventArgs e)
        {
            
            
        }
        

        private void btnDailyService_Click(object sender, EventArgs e)
        {
           



        }

        private void btnPrevious6_Click(object sender, EventArgs e)
        {
            new frmAdminWorkRoom().Show();
            this.Hide();
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            double totalIncome = Convert.ToInt32(lblDailyIteam.Text) + Convert.ToInt32(lblDailyService.Text);
            conn.Open();
            String TotalIeam = "INSERT INTO MonthlyIteamReport VALUES('" + this.dateTimePicker1Iteam.Text + "','" + totalIncome.ToString() + "')";
            cmd1 = new OleDbCommand(TotalIeam, conn);
            cmd1.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            String TotalIeam1 = "DELETE * FROM dailyItemTransction ";
            cmd1 = new OleDbCommand(TotalIeam1, conn);
            cmd1.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            String TotalIeam2 = "DELETE * FROM DailyServiceTransaction ";
            cmd1 = new OleDbCommand(TotalIeam2, conn);
            cmd1.ExecuteNonQuery();
            conn.Close();

            dgvIteamTransactionTable.DataSource = null;
            dgvIteamTransactionTable.Refresh();
            dgvDailyServiceTransactionTable.DataSource=null;
            dgvDailyServiceTransactionTable.Refresh();
            lblDailyIteam.Text = "";
            lblDailyService.Text = "";
            MessageBox.Show("All Daily TRansactions are cleared");


        }

        private void btnServiceDelete_Click(object sender, EventArgs e)
        {

            


            
        }
    }
}
