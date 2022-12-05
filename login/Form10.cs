using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class frmAdminWorkRoom : Form
    {
        public frmAdminWorkRoom()
        {
            InitializeComponent();
        }

        private void btnEmployeeRegi_Click(object sender, EventArgs e)
        {
            new frmRegi().Show();
            this.Hide();
        }

        private void btnClose3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckStock3_Click(object sender, EventArgs e)
        {
            //1=normal user
            //2=admin user
            new frmCheckStock6(2).Show();
            this.Hide();
        }

        private void btnDailyIncome_Click(object sender, EventArgs e)
        {
            new frmDailyTransaction().Show();
            this.Hide();
        }

        private void btnMonthlyReview_Click(object sender, EventArgs e)
        {
            new frmMonthlyReview().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
