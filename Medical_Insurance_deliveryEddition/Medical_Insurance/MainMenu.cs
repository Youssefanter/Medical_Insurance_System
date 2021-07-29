using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Insurance
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Insert_Person_Click(object sender, EventArgs e)
        {
            InsertPerson ins = new InsertPerson();
            ins.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Search_Person_Click(object sender, EventArgs e)
        {
            SearchPolicy sp = new SearchPolicy();
            sp.Show();
            this.Hide();
        }

        private void Dependent_Click(object sender, EventArgs e)
        {
            ManageDependent md = new ManageDependent();
            md.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonReport pr = new PersonReport();
            pr.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DepReport dr = new DepReport();
            dr.Show();
            this.Hide();
        }
    }
}
