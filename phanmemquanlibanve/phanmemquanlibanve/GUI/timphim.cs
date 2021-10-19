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
    public partial class timphim : Form
    {
        public timphim()
        {
            InitializeComponent();
        }

        private void timphim_Load(object sender, EventArgs e)
        {           
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void btnphong_Click(object sender, EventArgs e)
        {
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
        }
        private void btntieptheo_Click(object sender, EventArgs e)
        {
            Phong p = new Phong();
            p.MdiParent = Nhanvien.ActiveForm;
            p.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
