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
    public partial class frmMonthlyReview : Form
    {
        public frmMonthlyReview()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:\\test\\login\\login\\bin\\Debug\\New folder\\db_users1.mdb");
        OleDbCommand cmd1 = new OleDbCommand();
        OleDbDataAdapter da1 = new OleDbDataAdapter();


        private void btnCloseMonthly_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPreviousMonthly_Click(object sender, EventArgs e)
        {
            new frmAdminWorkRoom().Show();
            this.Hide();
        }

        private void btnMonthlyClear_Click(object sender, EventArgs e)
        {
            dgvMonthlyTable.Rows.Clear();
        }

        private void btnCheckMonthly_Click(object sender, EventArgs e)
        {
            conn.Open();
            String Monthly = "SELECT * FROM MonthlyIteamReport WHERE Date= '" + this.dateTimePickerMonth.Text + "'";

            OleDbCommand cdb = new OleDbCommand(Monthly, conn);
            OleDbDataReader reader = cdb.ExecuteReader();

            while (reader.Read())
            {
                dgvMonthlyTable.Rows.Add(reader[0].ToString(), reader[1].ToString());

            }
            reader.Close();
            conn.Close();
        }
    }
}
