﻿using System;
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
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }
        private void Sell_Load(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}