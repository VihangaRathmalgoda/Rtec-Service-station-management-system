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
    public partial class frmBooking4 : Form
    {
        public frmBooking4()
        {
            InitializeComponent();
        }
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:\\test\\login\\login\\bin\\Debug\\New folder\\db_users1.mdb");
        OleDbCommand cmd1 = new OleDbCommand();
        OleDbDataAdapter da1 = new OleDbDataAdapter();


        private void btnPrevious4_Click(object sender, EventArgs e)
        {
            
            new frmDashboard().Show();
            this.Hide();
        }

        private void btnClose4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String booking = "INSERT INTO Booking VALUES('" + cmbTimePeriod4.SelectedItem + "','" + cmbService4.SelectedItem + "','" + txtCustomer1Name4.Text + "','" + txtCustomer2Name4.Text + "','" + txtCustomer3Name4.Text + "')";
                cmd1 = new OleDbCommand(booking, conn);
                cmd1.ExecuteNonQuery();



                MessageBox.Show("Succefully Completed", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill the details");
            }





        }

        private void cmbService4_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void frmBooking4_Load(object sender, EventArgs e)
        {

        }

        private void cmbTimePeriod4_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }

        private void cmbBookingTime4_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btncheck4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                String Booking = "SELECT * FROM Booking WHERE TimePeriod= '" + cmbBookingTime4.SelectedItem + "'";

                OleDbCommand cdb = new OleDbCommand(Booking, conn);
                OleDbDataReader reader = cdb.ExecuteReader();

                while (reader.Read())
                {
                    dgvBooking4.Rows.Add(reader[0].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString());

                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill the details");
            }
        }

        private void btnClear4_Click(object sender, EventArgs e)
        {
            txtCustomer1Name4.Text = "";
            txtCustomer2Name4.Text = "";
            txtCustomer3Name4.Text = "";
            cmbService4.Text = "";
            cmbBookingTime4.Text = "";
            cmbTimePeriod4.Text = "";
            dgvBooking4.Rows.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cdb = new OleDbCommand();
            cdb = conn.CreateCommand();
            cdb.CommandType = CommandType.Text;
            cdb.CommandText = "delete from Booking where Section01='" + txtCustomer1Name4.Text + "'";

            cdb.ExecuteReader();
            conn.Close();
            DeleteSection02();
            DeleteSection03();
            MessageBox.Show("Record Deleted Successfully");


        }
        private void DeleteSection02()
        {
            conn.Open();
            OleDbCommand cdb = new OleDbCommand();
            cdb = conn.CreateCommand();
            cdb.CommandType = CommandType.Text;
            cdb.CommandText = "delete from Booking where Section02='" + txtCustomer2Name4.Text + "'";

            cdb.ExecuteReader();
            conn.Close();
            //MessageBox.Show("Record Deleted Successfully");
        }
        private void DeleteSection03()
        {
            conn.Open();
            OleDbCommand cdb = new OleDbCommand();
            cdb = conn.CreateCommand();
            cdb.CommandType = CommandType.Text;
            cdb.CommandText = "delete from Booking where Section03='" + txtCustomer3Name4.Text + "'";

            cdb.ExecuteReader();
            conn.Close();
            //MessageBox.Show("Record Deleted Successfully");
        }

    }
}
