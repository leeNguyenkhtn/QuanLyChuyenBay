using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadLabel();
        }
        private void loadLabel()
        {
            Label label3 = new Label();
            this.Controls.Add(label3);
            label3.Text = "LB3";
        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "10 điểm đồ án";
        }

        private void form1_Click(object sender, EventArgs e)
        {
            label1.Text = "10 điểm đồ án";
            MessageBox.Show(label1.Font.Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
