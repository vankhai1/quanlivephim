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
    public partial class dangnhap : DevExpress.XtraEditors.XtraForm
    {
        //tk ql
        string tentaikhoan = "admin";
        string matkhau = "123";
        public dangnhap()
        {
            InitializeComponent();
        }
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void btnnhanvien_Click(object sender, EventArgs e)
        {


        }
        private void textpass_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnquanli_Click(object sender, EventArgs e)
        {

        }
        bool Kiemtradangnhapql(string tentaikhoan, string matkhau)
        {

            if (tentaikhoan == this.tentaikhoan && matkhau == this.matkhau)
            {
                return true;
            }
            return false;
        }
        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            
        }
        private void checkshow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkshow.Checked)
            {
                textpass.UseSystemPasswordChar = false;
            }
            else
            {
                textpass.UseSystemPasswordChar = true;
            }

        }

        private void btndangnhap_Click_1(object sender, EventArgs e)
        {
            {
                if (textdangnhap.Text == "" || textpass.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu", "Thông báo");
                }
                else
                {
                    if (tentaikhoan.Equals(textdangnhap.Text) && matkhau.Equals(textpass.Text))
                    {
                        
                        Congviec f = new Congviec();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show(" Sai tài khoản hoặc mật khẩu");
                        textpass.Clear();
                    }
                }
            } this.Hide();
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }
    }
}
