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
    public partial class frmBilling5 : Form
    {
        public frmBilling5()
        {
            InitializeComponent();
            loadItemCombo();
            loadServiceCombo();
            
        }
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:\\test\\login\\login\\bin\\Debug\\New folder\\db_users1.mdb");
        OleDbCommand cmd1 = new OleDbCommand();
        OleDbDataAdapter da1 = new OleDbDataAdapter();

        private void btnPrevious5_Click(object sender, EventArgs e)
        {
            new frmDashboard().Show();
            this.Hide();
        }

        private void btnClose5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear5_Click(object sender, EventArgs e)
        {
            cmbIteam5.Text = "";
            cmbService5.Text = "";
            txtServiceCost5.Text = "";
            txtIteamPrice5.Text = "";
        }

        private void cmbSrvice5_SelectedIndexChanged(object sender, EventArgs e)
        {


            string serviceName = cmbService5.Text;
            conn.Open();
            String Manage = "SELECT ServiceCost FROM Service WHERE Service='" + serviceName + "'";
            cmd1 = new OleDbCommand(Manage, conn);
            OleDbDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                txtServiceCost5.Text = reader["ServiceCost"].ToString();

            }
            reader.Close();
            conn.Close();

        }

        private void cmbItem5_SelectedIndexChanged(object sender, EventArgs e)
        {

            string itemName=cmbIteam5.Text;
            conn.Open();
            String Manage = "SELECT IteamPrice FROM Manage WHERE Iteam='"+itemName+"'";
            cmd1 = new OleDbCommand(Manage, conn);
            OleDbDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
               txtIteamPrice5.Text = reader["IteamPrice"].ToString();

            }
            reader.Close();
            conn.Close();


        }

        private void frmBilling5_Load(object sender, EventArgs e)
        {
          
        }

        private void btnAdd5_Click(object sender, EventArgs e)
        {
            try
            {
                //if (cmbIteam5.SelectedIndex > -1 || cmbService5.SelectedIndex > -1)
                //{
                    conn.Open();
                    String billing = "INSERT INTO Billing VALUES('" + txtCustomerName5.Text + "','" + txtVehicleNumber5.Text + "','" + cmbService5.SelectedItem + "','" + txtServiceCost5.Text + "','" + cmbIteam5.SelectedItem + "','" + txtIteamPrice5.Text + "')";
                    cmd1 = new OleDbCommand(billing, conn);
                    cmd1.ExecuteNonQuery();

                    MessageBox.Show("Succefully Completed", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                    dailyIteams();
                    dailyService();

                    dgvBilling5.Rows.Add(txtCustomerName5.Text, txtVehicleNumber5.Text, cmbService5.SelectedItem, txtServiceCost5.Text, cmbIteam5.SelectedItem, txtIteamPrice5.Text);
                //}
                //else
                //{
                //    MessageBox.Show("Fill the details");
                //}
            }
            catch (Exception ex)
            {

            }
        }
        private void dailyIteams()
        {
            conn.Open();
            String TotalIeam = "INSERT INTO dailyItemTransction VALUES('" + this.dateTimePickerBilling.Text + "','" + txtIteamPrice5.Text + "')";
            cmd1 = new OleDbCommand(TotalIeam, conn);
            cmd1.ExecuteNonQuery();
            conn.Close();
        }
        private void dailyService()
        {
            conn.Open();
            String TotalIeam = "INSERT INTO DailyServiceTransaction VALUES('" + this.dateTimePickerBilling.Text + "','" + txtServiceCost5.Text + "')";
            cmd1 = new OleDbCommand(TotalIeam, conn);
            cmd1.ExecuteNonQuery();
            conn.Close();
        }
        private void btnPrint5_Click(object sender, EventArgs e)
        {
            try
            {

                int IteamsSum = 0;
                int ServiceSum = 0;
                int Total = 0;
                String Name = txtCustomerName5.Text;
                String Vnumber = txtVehicleNumber5.Text;

                for (int i = 0; i < dgvBilling5.Rows.Count; i++)
                {
                    IteamsSum += Convert.ToInt32(dgvBilling5.Rows[i].Cells[3].Value);
                    ServiceSum += Convert.ToInt32(dgvBilling5.Rows[i].Cells[5].Value);
                    Total = IteamsSum + ServiceSum;

                }

                itemsum();



                MessageBox.Show("-------------Rtec Service Company------------\n\n" +
                    "Customer Name :" + Name + "\n" +
                    "Total Bill Is :" + Total.ToString() + "\n" +
                                "        ---Thanks For Choosing US---");
                conn.Open();
                String TotalIeam = "INSERT INTO DailyServiceTransaction VALUES('" + this.dateTimePickerBilling.Text + "','" + ServiceSum.ToString() + "')";
                cmd1 = new OleDbCommand(TotalIeam, conn);
                cmd1.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show("ENTER THE DETAILS CORRECTLY");
            }
        }
        private void itemsum()

        {
            try
            {
                int IteamsSum = 0;
                int ServiceSum = 0;
                int Total = 0;
                String Name = txtCustomerName5.Text;
                String Vnumber = txtVehicleNumber5.Text;

                for (int i = 0; i < dgvBilling5.Rows.Count; i++)
                {
                    IteamsSum += Convert.ToInt32(dgvBilling5.Rows[i].Cells[3].Value);
                    ServiceSum += Convert.ToInt32(dgvBilling5.Rows[i].Cells[5].Value);
                    Total = IteamsSum + ServiceSum;

                }
                conn.Open();
                String TotalIeam = "INSERT INTO dailyItemTransction VALUES('" + this.dateTimePickerBilling.Text + "','" + IteamsSum.ToString() + "')";
                cmd1 = new OleDbCommand(TotalIeam, conn);
                cmd1.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception EX)
            {
                MessageBox.Show("ENTER THE DETAILS CORRECTLY");
            }


        }


        public void loadItemCombo()
        {
            DataRow dr;
            string qry = "SELECT Iteam from Manage";
            conn.Open();
            cmd1 = new OleDbCommand(qry, conn);
            OleDbDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                cmbIteam5.Items.Add(reader["Iteam"]);

            }
            reader.Close();
            conn.Close();
        }

        public void loadServiceCombo()
        {
            DataRow dr;
            string qry = "SELECT Service from Service";
            conn.Open();
            cmd1 = new OleDbCommand(qry, conn);
            OleDbDataReader reader = cmd1.ExecuteReader();

            while (reader.Read())
            {
                cmbService5.Items.Add(reader["Service"]);

            }
            reader.Close();
            conn.Close();
        }
       
    }
}
