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
    public partial class frmCheckStock6 : Form
    {
        int interfaceId;
        public frmCheckStock6(int interfaceId)
        {
            this.interfaceId = interfaceId;
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:\\test\\login\\login\\bin\\Debug\\New folder\\db_users1.mdb");
        OleDbCommand cmd1 = new OleDbCommand();
        OleDbDataAdapter da1 = new OleDbDataAdapter();

        private void btnPrevious6_Click(object sender, EventArgs e)
        {
            if (interfaceId == 1)
            {
                new frmDashboard().Show();
                this.Hide();
            }
            else if(interfaceId==2){
                new frmAdminWorkRoom().Show();
                this.Hide();
            }
            
        }

        private void btnClose6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbIteamBrand6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmCheckStock6_Load(object sender, EventArgs e)
        {
            

            cmbIteam6.Items.Add("Headlight");
            cmbIteam6.Items.Add("Mirror");
            cmbIteam6.Items.Add("Window");
            cmbIteam6.Items.Add("Brake light");
            cmbIteam6.Items.Add("Hubcap");
            cmbIteam6.Items.Add("Bumper");
            cmbIteam6.Items.Add("Rear-view mirror");
            cmbIteam6.Items.Add("Turn signal/ Blinker");
            cmbIteam6.Items.Add("Gas tank (US)/ Petrol tank (UK)");
            cmbIteam6.Items.Add("Roof");


            cmbSrvice6.Items.Add("Body Wash");
            cmbSrvice6.Items.Add("Oil Change");
            cmbSrvice6.Items.Add("Under Wash");
            cmbSrvice6.Items.Add("Vaccum Cleaning");
            cmbSrvice6.Items.Add("Alignment Check");
            cmbSrvice6.Items.Add("Full Service");
            cmbSrvice6.Items.Add("Inspection and Scan");
            cmbSrvice6.Items.Add("Engine Room wash");
            cmbSrvice6.Items.Add("Battery Recharge");
            cmbSrvice6.Items.Add("Inside cleaning");
            cmbSrvice6.Items.Add("Tyer side Change");
            
        }

        private void btncheckIteam6_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                String Manage = "SELECT * FROM Manage WHERE Iteam= '" + cmbIteam6.SelectedItem + "'";

                OleDbCommand cdb = new OleDbCommand(Manage, conn);
                OleDbDataReader reader = cdb.ExecuteReader();

                while (reader.Read())
                {
                    dgvIteamTable6.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString());

                }
                reader.Close();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fill the details");
            }
              
            
        }

        private void cmbServiceBrand6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCheckService6_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String Service = "SELECT * FROM Service WHERE Service= '" + cmbSrvice6.SelectedItem + "'";

                OleDbCommand cdb = new OleDbCommand(Service, conn);
                OleDbDataReader reader = cdb.ExecuteReader();

                while (reader.Read())
                {
                    dgvServiceTable6.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());

                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill the details");
            }

        }

        private void cmbIteam6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIteam6.Items.Add("Headlight");
            cmbIteam6.Items.Add("Mirror");
            cmbIteam6.Items.Add("Window");
            cmbIteam6.Items.Add("Brake light");
            cmbIteam6.Items.Add("Hubcap");
            cmbIteam6.Items.Add("Bumper");
            cmbIteam6.Items.Add("Rear-view mirror");
            cmbIteam6.Items.Add("Turn signal/ Blinker");
            cmbIteam6.Items.Add("Gas tank (US)/ Petrol tank (UK)");
            cmbIteam6.Items.Add("Roof");
            
        }

        private void btnClear6_Click(object sender, EventArgs e)
        {
           
            cmbIteam6.Text = "";
            
            cmbSrvice6.Text = "";
            dgvIteamTable6.Rows.Clear();
            dgvServiceTable6.Rows.Clear();
        }
    }
}
