
namespace phanmemquanlibanve
{
    partial class Congviec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Congviec));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnquanly = new System.Windows.Forms.Button();
            this.btnnhanvien = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btntrove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(167, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 63);
            this.label2.TabIndex = 1;
            this.label2.Text = "Công Việc";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhân Viên";
            // 
            // btnquanly
            // 
            this.btnquanly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnquanly.BackgroundImage")));
            this.btnquanly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnquanly.Location = new System.Drawing.Point(335, 149);
            this.btnquanly.Name = "btnquanly";
            this.btnquanly.Size = new System.Drawing.Size(115, 105);
            this.btnquanly.TabIndex = 2;
            this.btnquanly.UseVisualStyleBackColor = true;
            this.btnquanly.Click += new System.EventHandler(this.btnquanly_Click);
            // 
            // btnnhanvien
            // 
            this.btnnhanvien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnhanvien.BackgroundImage")));
            this.btnnhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnhanvien.Location = new System.Drawing.Point(98, 149);
            this.btnnhanvien.Name = "btnnhanvien";
            this.btnnhanvien.Size = new System.Drawing.Size(115, 105);
            this.btnnhanvien.TabIndex = 0;
            this.btnnhanvien.UseVisualStyleBackColor = true;
            this.btnnhanvien.Click += new System.EventHandler(this.btnnhanvien_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(335, 437);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(115, 47);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btntrove
            // 
            this.btntrove.Location = new System.Drawing.Point(194, 437);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(115, 47);
            this.btntrove.TabIndex = 3;
            this.btntrove.Text = "Quay lại";
            this.btntrove.UseVisualStyleBackColor = true;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // Congviec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(546, 496);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnquanly);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnnhanvien);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Congviec";
            this.Text = "Congviec";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnquanly;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntrove;
    }
}