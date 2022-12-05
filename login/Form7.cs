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
    public partial class frmManageStock7 : Form
    {
        public frmManageStock7()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:\\test\\login\\login\\bin\\Debug\\New folder\\db_users1.mdb");
        OleDbCommand cmd1 = new OleDbCommand();
        OleDbDataAdapter da1 = new OleDbDataAdapter();

        private void btnPrevious7_Click(object sender, EventArgs e)
        {
           
            new frmDashboard().Show();
            this.Hide();
        }

        private void btnClose7_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frmManageStock7_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd7_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                String Manage = "INSERT INTO Manage VALUES ('" + txtIteam7.Text + "','" + txtQuantity7.Text + "','" + txtIteamPrice7.Text + "','" + txtIteamBrand.Text + "')";
                cmd1 = new OleDbCommand(Manage, conn);
                cmd1.ExecuteNonQuery();
          
                 MessageBox.Show("Succefully Completed","Completed",MessageBoxButtons.OK,MessageBoxIcon.Information);
                 conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill all the details");
                conn.Close();
            }
        }
      
        private void btnShow7_Click(object sender, EventArgs e)
        {
            conn.Open();
            String Manage = "SELECT*FROM Manage";
            cmd1 = new OleDbCommand(Manage, conn);
            OleDbDataReader reader = cmd1.ExecuteReader();

           


            while (reader.Read())
            {
                dgvIteamTable7.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());

            }
            reader.Close();
            conn.Close();
            showdatagservice();
            
        }

        private void btnAddService7_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                String Service = "INSERT INTO Service VALUES ('" + txtVehicleBrand.Text + "','" + txtService7.Text + "','" + txtServicePrice7.Text + "')";
                cmd1 = new OleDbCommand(Service, conn);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("Succefully Completed", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fill all the details");
                conn.Close();
            }
     
        }
        private void showdatagservice()
        {
            conn.Open();
            String Service = "SELECT*FROM Service";
            cmd1 = new OleDbCommand(Service, conn);
            OleDbDataReader reader = cmd1.ExecuteReader();


            while (reader.Read())
            {
                dgvServiceTable7.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());

            }
            reader.Close();
            conn.Close();

        }

        private void btnClear7_Click(object sender, EventArgs e)
        {
            txtIteam7.Text = "";
            txtIteamPrice7.Text = "";
            txtQuantity7.Text = "";
            txtVehicleBrand.Text = "";
            txtService7.Text = "";
            txtServicePrice7.Text = "";
            txtIteamBrand.Text = "";
        }
    }
}
