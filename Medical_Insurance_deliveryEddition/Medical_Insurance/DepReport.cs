using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Medical_Insurance
{
    public partial class DepReport : Form
    {
        CrystalReport4 CR2;
        string scottDB = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        OracleCommand cmd;
        public DepReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR2.SetParameterValue(0, comboBox1.SelectedItem);
            crystalReportViewer1.ReportSource = CR2;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DepReport_Load(object sender, EventArgs e)
        {
            CR2 = new CrystalReport4();
            conn = new OracleConnection(scottDB);
            conn.Open();
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select SSN from Person";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            dr.Close();
            conn.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Hide();
        }
    }
}
