using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay
{
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }
        private void Change_Load(object sender, EventArgs e)
        {

        }
        private void Binput_Click(object sender, EventArgs e)
        {
            this.Close();
            Input In = new Input();
            In.ShowDialog();
        }
        private void Bsearch_Click(object sender, EventArgs e)
        {
            this.Close();
            Search Se = new Search();
            Se.ShowDialog();
        }
        private void Bbook_Click(object sender, EventArgs e)
        {
            this.Close();
            Book Bo = new Book();
            Bo.ShowDialog();
        }
        private void Bsell_Click(object sender, EventArgs e)
        {
            this.Close();
            Sell Se = new Sell();
            Se.ShowDialog();
        }
        private void Btotal_Click(object sender, EventArgs e)
        {
            this.Close();
            Total To = new Total();
            To.ShowDialog();
        }
        private void Bchange_Click(object sender, EventArgs e)
        {

        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
