using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_management
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void lbLichChuyenBay_Click(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            fManage Manage = new fManage();
            this.Hide();
            Manage.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
