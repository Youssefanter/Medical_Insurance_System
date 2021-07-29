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
    public partial class ManageDependent : Form
    {
        string scottDB = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public ManageDependent()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            string command;
            if (DependentT.Text=="")
            {
                command = "select * from dependent";
                adapter = new OracleDataAdapter(command, scottDB);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                command = "select * from dependent where SSN=:Did";
                adapter = new OracleDataAdapter(command, scottDB);
                adapter.SelectCommand.Parameters.Add("Did", DependentT.Text);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Action Done");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }

        private void ManageDependent_Load(object sender, EventArgs e)
        {

        }

        private void ManageDependent_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
