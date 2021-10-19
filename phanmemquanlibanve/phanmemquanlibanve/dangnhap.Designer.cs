
namespace phanmemquanlibanve
{
    partial class dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangnhap));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textdangnhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.checkshow = new DevExpress.XtraEditors.CheckEdit();
            this.textpass = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textdangnhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkshow.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(331, 98);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Đăng Nhập:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(386, 156);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Mật Khẩu:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // textdangnhap
            // 
            this.textdangnhap.Location = new System.Drawing.Point(513, 94);
            this.textdangnhap.Margin = new System.Windows.Forms.Padding(4);
            this.textdangnhap.Name = "textdangnhap";
            this.textdangnhap.Size = new System.Drawing.Size(231, 28);
            this.textdangnhap.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(513, 36);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(150, 36);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Đăng Nhập";
            this.labelControl3.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // checkshow
            // 
            this.checkshow.Location = new System.Drawing.Point(1026, 240);
            this.checkshow.Margin = new System.Windows.Forms.Padding(4);
            this.checkshow.Name = "checkshow";
            this.checkshow.Properties.Caption = "Show";
            this.checkshow.Size = new System.Drawing.Size(112, 29);
            this.checkshow.TabIndex = 4;
            this.checkshow.CheckedChanged += new System.EventHandler(this.checkshow_CheckedChanged);
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(513, 153);
            this.textpass.Name = "textpass";
            this.textpass.Size = new System.Drawing.Size(231, 27);
            this.textpass.TabIndex = 5;
            this.textpass.UseSystemPasswordChar = true;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(439, 220);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(122, 35);
            this.btndangnhap.TabIndex = 6;
            this.btndangnhap.Text = "Đăng Nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click_1);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(622, 220);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(122, 35);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1040, 287);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.checkshow);
            this.Controls.Add(this.textdangnhap);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("dangnhap.IconOptions.Image")));
            this.Name = "dangnhap";
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.textdangnhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkshow.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textdangnhap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit checkshow;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnthoat;
    }
}

