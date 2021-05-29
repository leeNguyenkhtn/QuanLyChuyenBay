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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }
        private void Binput_Click(object sender, EventArgs e)
        {
            this.Hide();
            Input In = new Input();
            In.ShowDialog();
            this.Show();
        }
        private void Bsearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search Sea = new Search();
            Sea.ShowDialog();
            this.Show();
        }
        private void Bbook_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book Bo = new Book();
            Bo.ShowDialog();
            this.Show();
        }
        private void Bsell_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sell Sel = new Sell();
            Sel.ShowDialog();
            this.Show();
        }
        private void Btotal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Total To = new Total();
            To.ShowDialog();
            this.Show();
        }
        private void Bchange_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change Ch = new Change();
            Ch.ShowDialog();
            this.Show();
        }

        private void Bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
