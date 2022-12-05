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
    public partial class frmAdminOnly : Form
    {
        public frmAdminOnly()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsernameAdmin.Text == "admin")
                {
                    if (txtPasswordAdmin.Text == "1234")
                    {
                        new frmAdminWorkRoom().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Enter the correct User Name And Password ");
                        txtUsernameAdmin.Text = "";
                        txtPasswordAdmin.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill the details");
            }
        }

        private void checkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPassword.Checked)
            {
                txtPasswordAdmin.PasswordChar = '\0';

            }
            else
            {
                txtPasswordAdmin.PasswordChar = '*';

            }
        }
    }
}
