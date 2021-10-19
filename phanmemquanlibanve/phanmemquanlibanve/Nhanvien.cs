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
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
            
        }

        private void btndktv_Click(object sender, EventArgs e)
        {
           
            dktv dk = new dktv();
            dk.MdiParent = Nhanvien.ActiveForm;
            dk.Show();
        }

        private void nhanvien(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

        }

        private void btnbanve_Click(object sender, EventArgs e)
        {
            timphim tp = new timphim();
            tp.MdiParent = Nhanvien.ActiveForm;
            tp.Show();
        }

        private void bnttimphim_Click(object sender, EventArgs e)
        {
            
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
           

        }

        private void btnthoat1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnphong_Click(object sender, EventArgs e)
        {
            
        }
    }
}
