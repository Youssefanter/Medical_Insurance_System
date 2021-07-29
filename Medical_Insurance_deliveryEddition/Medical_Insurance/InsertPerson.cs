using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Medical_Insurance
{
    public partial class InsertPerson : Form
    {
        string scottDB = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleCommand cmd;
        public InsertPerson()
        {
            InitializeComponent();
        }

        private void InsertPerson_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(scottDB);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select SSN from Person";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Inserted_Person.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void Confirm_insertion_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Person values (:id,:name,:email,:Phonenumber,:Status,:Gender,:Address)";
            cmd.Parameters.Add("id", Person_SSNT.Text);
            cmd.Parameters.Add("name", NameT.Text);
            cmd.Parameters.Add("email", EmailT.Text);
            cmd.Parameters.Add("Phonenumber", Phone_NumberT.Text);
            cmd.Parameters.Add("Status", StatusT.Text);
            cmd.Parameters.Add("Gender", GenderT.Text);
            cmd.Parameters.Add("Address", AddressT.Text);
            int i = cmd.ExecuteNonQuery();
            if (i!=-1)
            {
                Inserted_Person.Items.Add(Person_SSNT.Text);
                MessageBox.Show("New person is added succesfully...Press cancel to go to MainMenu");
            }
        }

        private void InsertPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void Inserted_Person_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select PERSON_NAME,EMAIL,PHONE_NUMBER,STATUS,GENDER,PERSON_ADDRESS from Person where SSN=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", Inserted_Person.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                Person_SSNT.Text = Inserted_Person.SelectedItem.ToString();
                NameT.Text = dr[0].ToString();
                EmailT.Text = dr[1].ToString();
                Phone_NumberT.Text = dr[2].ToString();
                StatusT.Text = dr[3].ToString();
                GenderT.Text = dr[4].ToString();
                AddressT.Text = dr[5].ToString();
            }
            dr.Close();
        }

        private void Cancel1_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PolT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
