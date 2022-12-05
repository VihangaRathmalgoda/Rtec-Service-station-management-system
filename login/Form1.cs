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
    public partial class frmRegi : Form
    {
        public frmRegi()
        {
            InitializeComponent();

            
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                if (txtPassword.Text == "" && txtUsername.Text == "" && txtConfirm.Text == "")
                {
                    MessageBox.Show("Username and Password fields are empty", "Ragistration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtPassword.Text == txtConfirm.Text)
                {
                try
                {

                    con.Open();
                    string register = "INSERT INTO tbl_users VALUES('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                    

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConfirm.Text = "";

                    MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                 
                catch (Exception ex)
                {
                    MessageBox.Show("This user name Already Use");
                }
                con.Close();


            }
                else
                {
                    MessageBox.Show("Passwords does not match, Please Re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtConfirm.Text = "";
                    txtPassword.Focus();

                }
           

        }

        private void checkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirm.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirm.PasswordChar = '*';
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirm.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void frmRegi_Load(object sender, EventArgs e)
        {

        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBacktoAdminWorkRoom_Click(object sender, EventArgs e)
        {
            new frmAdminWorkRoom().Show();
            this.Hide();
        }
    }
}
