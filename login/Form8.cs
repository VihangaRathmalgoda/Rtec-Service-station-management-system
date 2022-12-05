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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();

        }

        private void btnCloseHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2ProgressBar1.Value < 100)
            {
                guna2ProgressBar1.Value += 1;
                lblLoad.Text = guna2ProgressBar1.Value.ToString() + "%";




            }
            else
            {
                timer1.Stop();
                this.Hide();
                frmLogin frm1 = new frmLogin();
                frm1.ShowDialog();
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
