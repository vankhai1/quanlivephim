
namespace phanmemquanlibanve
{
    partial class Nhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nhanvien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthoat1 = new System.Windows.Forms.Button();
            this.btntrogiup = new System.Windows.Forms.Button();
            this.btndktv = new System.Windows.Forms.Button();
            this.btnbanve = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnthoat1);
            this.panel1.Controls.Add(this.btntrogiup);
            this.panel1.Controls.Add(this.btndktv);
            this.panel1.Controls.Add(this.btnbanve);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 139);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bán vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đăng kí thành viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trợ Giúp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thoát";
            // 
            // btnthoat1
            // 
            this.btnthoat1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnthoat1.BackgroundImage")));
            this.btnthoat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnthoat1.Location = new System.Drawing.Point(693, 12);
            this.btnthoat1.Name = "btnthoat1";
            this.btnthoat1.Size = new System.Drawing.Size(100, 100);
            this.btnthoat1.TabIndex = 0;
            this.btnthoat1.UseVisualStyleBackColor = true;
            this.btnthoat1.Click += new System.EventHandler(this.btnthoat1_Click);
            // 
            // btntrogiup
            // 
            this.btntrogiup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntrogiup.BackgroundImage")));
            this.btntrogiup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntrogiup.Location = new System.Drawing.Point(461, 12);
            this.btntrogiup.Name = "btntrogiup";
            this.btntrogiup.Size = new System.Drawing.Size(100, 100);
            this.btntrogiup.TabIndex = 0;
            this.btntrogiup.UseVisualStyleBackColor = true;
            // 
            // btndktv
            // 
            this.btndktv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndktv.BackgroundImage")));
            this.btndktv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndktv.Location = new System.Drawing.Point(245, 12);
            this.btndktv.Name = "btndktv";
            this.btndktv.Size = new System.Drawing.Size(100, 100);
            this.btndktv.TabIndex = 0;
            this.btndktv.UseVisualStyleBackColor = true;
            this.btndktv.Click += new System.EventHandler(this.btndktv_Click);
            // 
            // btnbanve
            // 
            this.btnbanve.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbanve.BackgroundImage")));
            this.btnbanve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnbanve.Location = new System.Drawing.Point(29, 12);
            this.btnbanve.Name = "btnbanve";
            this.btnbanve.Size = new System.Drawing.Size(100, 100);
            this.btnbanve.TabIndex = 0;
            this.btnbanve.UseVisualStyleBackColor = true;
            this.btnbanve.Click += new System.EventHandler(this.btnbanve_Click);
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 578);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.nhanvien);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthoat1;
        private System.Windows.Forms.Button btntrogiup;
        private System.Windows.Forms.Button btndktv;
        private System.Windows.Forms.Button btnbanve;
    }
}