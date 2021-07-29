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
    public partial class SearchPolicy : Form
    {
        string scottDB = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleCommand cmd;
        int PID;
        public SearchPolicy()
        {
            InitializeComponent();
        }

        private void SearchPolicy_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(scottDB);
            conn.Open();

            Start_DateT.Text = DateTime.Now.ToString();
            End_DateT.Text = DateTime.Now.AddMonths(6).ToString();
        }

        private void ShowNames_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETPERSONID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Name", NameT.Text);
            cmd.Parameters.Add("id", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                Inserted_SSNS.Items.Add(dr[0]);
            dr.Close();
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "ICREAMENTID";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("PolicyID", OracleDbType.Int64).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            try {
                PID = Convert.ToInt32(cmd.Parameters["PolicyID"].Value.ToString());
                PID++;
                PolicyIDT.Text = PID.ToString();
            }
            catch
            {
                PID = 1;
                PolicyIDT.Text = PID.ToString();
            }
        }

        private void SSNT_TextChanged(object sender, EventArgs e)
        {
        }

        private void Confirm_insertion_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into POLICY values (:Pid,:Pkind,:Phistory,:Pstart,:Pend,:ssn)";
            cmd.Parameters.Add("Pid", PID);
            cmd.Parameters.Add("Pkind", PolicyTypeT.Text);
            cmd.Parameters.Add("Phistory", Medical_historyT.Text);
            cmd.Parameters.Add("Pstart", Start_DateT.Text);
            cmd.Parameters.Add("Pend", End_DateT.Text);
            cmd.Parameters.Add("ssn", SSNT.Text);
            int i = cmd.ExecuteNonQuery();
            if (i != -1)
            {
                MessageBox.Show("New Policy is added succesfully...Press Back to go to MainMenu");
            }
        }

        private void Inserted_SSNS_SelectedIndexChanged(object sender, EventArgs e)
        {
            SSNT.Text = Inserted_SSNS.SelectedItem.ToString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            //cmd = new OracleCommand();
            //cmd.Connection = conn;
            //cmd.CommandText = "GETPOLICYID";
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("SSN", "1");
            //cmd.Parameters.Add("Name","Antar");
            //cmd.Parameters.Add("POLICYID",OracleDbType.Varchar2,ParameterDirection.Output);
            //int i = cmd.ExecuteNonQuery();
            //if (i!=-1)
            //{
            //    PolicyIDT.Text = cmd.Parameters["POLICYID"].Value.ToString();
            //}
        }

        private void SearchPolicy_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
