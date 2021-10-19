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
    public partial class Congviec : Form
    {
        public Congviec()
        {
            InitializeComponent();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.Show();
            this.Hide();
        }

        private void btnquanly_Click(object sender, EventArgs e)
        {
            Quanli ql = new Quanli();
            ql.Show();
            this.Hide();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btntrove_Click(object sender, EventArgs e)
        {
            this.Hide();
            dangnhap dn = new dangnhap();
            dn.Show();
        }
    }
}
