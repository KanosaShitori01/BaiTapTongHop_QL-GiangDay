
namespace QuanLyGiangDay
{
    partial class DSGV
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_page = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_themmt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_vetrai = new System.Windows.Forms.Button();
            this.btn_trai = new System.Windows.Forms.Button();
            this.btn_phai = new System.Windows.Forms.Button();
            this.btn_vephai = new System.Windows.Forms.Button();
            this.txt_magv = new System.Windows.Forms.TextBox();
            this.txt_hodem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_dienthoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sogiochuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_makhoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_hsluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_hocvi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tengv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cb_makhoa = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã GV";
            // 
            // txt_page
            // 
            this.txt_page.Location = new System.Drawing.Point(117, 19);
            this.txt_page.Name = "txt_page";
            this.txt_page.Size = new System.Drawing.Size(100, 20);
            this.txt_page.TabIndex = 1;
            this.txt_page.Text = "0/0";
            this.txt_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_capnhat);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.btn_themmt);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(311, 19);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(206, 19);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(75, 23);
            this.btn_capnhat.TabIndex = 2;
            this.btn_capnhat.Text = "Cập Nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Enabled = false;
            this.btn_luu.Location = new System.Drawing.Point(105, 19);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 1;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_themmt
            // 
            this.btn_themmt.Location = new System.Drawing.Point(10, 19);
            this.btn_themmt.Name = "btn_themmt";
            this.btn_themmt.Size = new System.Drawing.Size(75, 23);
            this.btn_themmt.TabIndex = 0;
            this.btn_themmt.Text = "Thêm MT";
            this.btn_themmt.UseVisualStyleBackColor = true;
            this.btn_themmt.Click += new System.EventHandler(this.btn_themmt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_vetrai);
            this.groupBox2.Controls.Add(this.btn_trai);
            this.groupBox2.Controls.Add(this.txt_page);
            this.groupBox2.Controls.Add(this.btn_phai);
            this.groupBox2.Controls.Add(this.btn_vephai);
            this.groupBox2.Location = new System.Drawing.Point(38, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 56);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btn_vetrai
            // 
            this.btn_vetrai.Location = new System.Drawing.Point(17, 17);
            this.btn_vetrai.Name = "btn_vetrai";
            this.btn_vetrai.Size = new System.Drawing.Size(42, 23);
            this.btn_vetrai.TabIndex = 5;
            this.btn_vetrai.Text = "|<";
            this.btn_vetrai.UseVisualStyleBackColor = true;
            this.btn_vetrai.Click += new System.EventHandler(this.btn_vetrai_Click);
            // 
            // btn_trai
            // 
            this.btn_trai.Location = new System.Drawing.Point(65, 17);
            this.btn_trai.Name = "btn_trai";
            this.btn_trai.Size = new System.Drawing.Size(46, 23);
            this.btn_trai.TabIndex = 4;
            this.btn_trai.Text = "<";
            this.btn_trai.UseVisualStyleBackColor = true;
            this.btn_trai.Click += new System.EventHandler(this.btn_trai_Click);
            // 
            // btn_phai
            // 
            this.btn_phai.Location = new System.Drawing.Point(224, 17);
            this.btn_phai.Name = "btn_phai";
            this.btn_phai.Size = new System.Drawing.Size(42, 23);
            this.btn_phai.TabIndex = 3;
            this.btn_phai.Text = ">";
            this.btn_phai.UseVisualStyleBackColor = true;
            this.btn_phai.Click += new System.EventHandler(this.btn_phai_Click);
            // 
            // btn_vephai
            // 
            this.btn_vephai.Location = new System.Drawing.Point(272, 17);
            this.btn_vephai.Name = "btn_vephai";
            this.btn_vephai.Size = new System.Drawing.Size(46, 23);
            this.btn_vephai.TabIndex = 2;
            this.btn_vephai.Text = ">|";
            this.btn_vephai.UseVisualStyleBackColor = true;
            this.btn_vephai.Click += new System.EventHandler(this.btn_vephai_Click);
            // 
            // txt_magv
            // 
            this.txt_magv.Enabled = false;
            this.txt_magv.Location = new System.Drawing.Point(92, 52);
            this.txt_magv.Name = "txt_magv";
            this.txt_magv.Size = new System.Drawing.Size(100, 20);
            this.txt_magv.TabIndex = 6;
            // 
            // txt_hodem
            // 
            this.txt_hodem.Location = new System.Drawing.Point(92, 78);
            this.txt_hodem.Name = "txt_hodem";
            this.txt_hodem.Size = new System.Drawing.Size(100, 20);
            this.txt_hodem.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ Đệm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ngày Sinh";
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.Location = new System.Drawing.Point(92, 130);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(100, 20);
            this.txt_dienthoai.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Điện Thoại";
            // 
            // txt_sogiochuan
            // 
            this.txt_sogiochuan.Location = new System.Drawing.Point(92, 156);
            this.txt_sogiochuan.Name = "txt_sogiochuan";
            this.txt_sogiochuan.Size = new System.Drawing.Size(100, 20);
            this.txt_sogiochuan.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số Giờ Chuẩn";
            // 
            // txt_makhoa
            // 
            this.txt_makhoa.Location = new System.Drawing.Point(286, 155);
            this.txt_makhoa.Name = "txt_makhoa";
            this.txt_makhoa.Size = new System.Drawing.Size(100, 20);
            this.txt_makhoa.TabIndex = 24;
            this.txt_makhoa.TextChanged += new System.EventHandler(this.txt_makhoa_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mã Khoa";
            // 
            // txt_hsluong
            // 
            this.txt_hsluong.Location = new System.Drawing.Point(286, 130);
            this.txt_hsluong.Name = "txt_hsluong";
            this.txt_hsluong.Size = new System.Drawing.Size(100, 20);
            this.txt_hsluong.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "HS Lương";
            // 
            // txt_hocvi
            // 
            this.txt_hocvi.Location = new System.Drawing.Point(286, 104);
            this.txt_hocvi.Name = "txt_hocvi";
            this.txt_hocvi.Size = new System.Drawing.Size(100, 20);
            this.txt_hocvi.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Học Vị";
            // 
            // txt_tengv
            // 
            this.txt_tengv.Location = new System.Drawing.Point(286, 78);
            this.txt_tengv.Name = "txt_tengv";
            this.txt_tengv.Size = new System.Drawing.Size(100, 20);
            this.txt_tengv.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tên GV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "DANH SÁCH GIẢNG VIÊN";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(92, 104);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(100, 20);
            this.dtp_ngaysinh.TabIndex = 26;
            // 
            // cb_makhoa
            // 
            this.cb_makhoa.FormattingEnabled = true;
            this.cb_makhoa.Location = new System.Drawing.Point(286, 155);
            this.cb_makhoa.Name = "cb_makhoa";
            this.cb_makhoa.Size = new System.Drawing.Size(100, 21);
            this.cb_makhoa.TabIndex = 27;
            this.cb_makhoa.Visible = false;
            this.cb_makhoa.TextUpdate += new System.EventHandler(this.cb_makhoa_TextUpdate);
            // 
            // DSGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 341);
            this.Controls.Add(this.dtp_ngaysinh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_hsluong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_hocvi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_tengv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_sogiochuan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_dienthoai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_hodem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_magv);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_makhoa);
            this.Controls.Add(this.cb_makhoa);
            this.Name = "DSGV";
            this.Text = "DSGV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DSGV_FormClosed);
            this.Load += new System.EventHandler(this.DSGV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_page;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_themmt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_vetrai;
        private System.Windows.Forms.Button btn_trai;
        private System.Windows.Forms.Button btn_phai;
        private System.Windows.Forms.Button btn_vephai;
        private System.Windows.Forms.TextBox txt_magv;
        private System.Windows.Forms.TextBox txt_hodem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_dienthoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sogiochuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_makhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_hsluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_hocvi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tengv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.ComboBox cb_makhoa;
    }
}