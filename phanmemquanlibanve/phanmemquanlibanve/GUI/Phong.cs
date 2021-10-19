using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phanmemquanlibanve
{
    public partial class Phong : Form
    {
        public Phong()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
           thanhtoan tt = new thanhtoan();
            tt.MdiParent = Nhanvien.ActiveForm;
           tt.Show();
            this.Hide();
        }

        private void btnquaylai1_Click(object sender, EventArgs e)
        {
            this.Hide();
            timphim tp = new timphim();
            tp.MdiParent = Nhanvien.ActiveForm;
            tp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Phong_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
