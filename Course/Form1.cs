using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddDataBase_Click(object sender, EventArgs e)
        {
            FormChooseDB frm = new FormChooseDB(this);
            Form1 frm1 = new Form1();
            frm.Show();
            this.Hide();
        }

        private void buttonReportPriceList_Click(object sender, EventArgs e)
        {
            FormDBPriceList frm = new FormDBPriceList();
            Form1 frm1 = new Form1();
            frm.Show();
            this.Hide();
        }

        private void buttonDeleteDB_Click(object sender, EventArgs e)
        {
            FormRemoveDB frm1 = new FormRemoveDB();
            frm1.Show();
            this.Hide();
        }

        private void buttonReportOutputDB_Click(object sender, EventArgs e)
        {
            FormOutputDB frm1 = new FormOutputDB();
            frm1.Show();
            this.Hide();
        }

        private void buttonReport100InPack_Click(object sender, EventArgs e)
        {
            FormMoreThen100 frm1 = new FormMoreThen100();
            frm1.Show();
            this.Hide();
        }

        private void buttonAddFieldDB_Click(object sender, EventArgs e)
        {
            FormChooseExistDB frm1 = new FormChooseExistDB();
            frm1.Show();
            this.Hide();
        }

        private void buttonSearchFieldDB_Click(object sender, EventArgs e)
        {
            FormChooseReadDB frm1 = new FormChooseReadDB("name");
            frm1.Show();
            this.Hide();
        }

        private void buttonReportProductsInPharmacy_Click(object sender, EventArgs e)
        {
            FormChooseReadDB frm1 = new FormChooseReadDB("pharmacy");
            frm1.Show();
            this.Hide();
        }

        private void buttonDeleteExpired_Click(object sender, EventArgs e)
        {
            FormRemoveExpired frm1 = new FormRemoveExpired();
            frm1.Show();
            this.Hide();
        }

        private void buttonEditDB_Click(object sender, EventArgs e)
        {
            FormChooseReadDB frm1 = new FormChooseReadDB("edit");
            frm1.Show();
            this.Hide();
        }

        private void CloseProgram(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
