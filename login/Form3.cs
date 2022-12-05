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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
       
        private void btnManageStock3_Click(object sender, EventArgs e)
        {
            
            new frmManageStock7().Show();
            this.Hide();
        }

        private void btnCheckStock3_Click(object sender, EventArgs e)
        {
            //1=normal user
            //2=admin user
            new frmCheckStock6(1).Show();
            this.Hide();
        }

        private void btnBooking3_Click(object sender, EventArgs e)
        {
           
            new frmBooking4().Show();
            this.Hide();
        }

        private void btnBilling3_Click(object sender, EventArgs e)
        {
           
            new frmBilling5().Show();
            this.Hide();
        }

        private void btnClose3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
