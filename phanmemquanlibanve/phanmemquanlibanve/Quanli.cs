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
    public partial class Quanli : Form
    {
        public Quanli()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panel1.Visible = false;
        }
        private void hideMenu()
        {
            if (panel1.Visible == true) ;
            panel1.Visible = false;
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            qlnhanvien qlnv = new qlnhanvien();
            qlnv.MdiParent = Quanli.ActiveForm;
            qlnv.Show();

        }

        private void Quanli_Load(object sender, EventArgs e)
        {

        }

        private void btndata_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void lban_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnqlphim_Click(object sender, EventArgs e)
        {
            qlphim qlp = new qlphim();
            qlp.MdiParent = Quanli.ActiveForm;
            qlp.Show();
        }

        private void btndoanhthu_Click(object sender, EventArgs e)
        {
            thongke tk = new thongke();
            tk.MdiParent = Quanli.ActiveForm;
            tk.Show();

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            qltk ql = new qltk();
            ql.MdiParent = Quanli.ActiveForm;
            ql.Show();

        }

        private void btnMovieUC_Click(object sender, EventArgs e)
        {
            qlphim qlp = new qlphim();
            qlp.MdiParent = Quanli.ActiveForm;
            qlp.Show();
        }

        private void btnFormatMovieUC_Click(object sender, EventArgs e)
        {
            dinhdang dd = new dinhdang();
            dd.MdiParent = Quanli.ActiveForm;
            dd.Show();

        }

        private void btnCinemaUC_Click(object sender, EventArgs e)
        {
            phongchieu pc = new phongchieu();
            pc.MdiParent = Quanli.ActiveForm;
            pc.Show();

        }
    }
}
