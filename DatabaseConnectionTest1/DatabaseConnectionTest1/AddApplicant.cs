using System;
using System.Data.OleDb;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnectionTest1
{
    public partial class AddApplicant : Form
    {
        public AddApplicant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection vconn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Kummy\\Documents\\happytech database.accdb");
            vconn.Open();
            string ID = IDBox.Text;
            string fullName = NameBox.Text;
            string DOB = DOBBox.Text;
            string phoneNo = phoneNoBox.Text;
            string email = emailBox.Text;
            string address = addressBox.Text;
            string postcode = postcodeBox.Text;

            string vquery = "INSERT INTO Applicants values (@ID, @fullName, @DOB, @phoneNo, @email, @address, @postcode)";
            OleDbCommand vcomm = new OleDbCommand(vquery, vconn);
            vcomm.Parameters.AddWithValue("@ID", ID);
            vcomm.Parameters.AddWithValue("@fullName", fullName);
            vcomm.Parameters.AddWithValue("@DOB", DOB);
            vcomm.Parameters.AddWithValue("@phoneNo", phoneNo);
            vcomm.Parameters.AddWithValue("@email", email);
            vcomm.Parameters.AddWithValue("@address", address);
            vcomm.Parameters.AddWithValue("@postcode", postcode);
            vcomm.ExecuteNonQuery();
            MessageBox.Show("Your entry has been inputted");
            vconn.Close();
        }

        private void AddApplicant_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
