using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanVeMayBay
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }
        private void Input_Load(object sender, EventArgs e)
        {

        }
        private void Binput_Click(object sender, EventArgs e)
        {

        }
        private void Bsearch_Click(object sender, EventArgs e)
        {
            this.Close();
            Search Sea = new Search();
            Sea.ShowDialog();         
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
            this.Close();
            Change Cha = new Change();
            Cha.ShowDialog();
        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

