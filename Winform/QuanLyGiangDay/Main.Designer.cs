
namespace QuanLyGiangDay
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpDanhSáchGVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpDanhSáchMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giáoViênTheoKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêGiờDạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhVượtGiờToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.nhậpDữLiệuToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dăngNhậpToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // dăngNhậpToolStripMenuItem
            // 
            this.dăngNhậpToolStripMenuItem.Name = "dăngNhậpToolStripMenuItem";
            this.dăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.dăngNhậpToolStripMenuItem.Text = "Dăng Nhập";
            this.dăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.dăngNhậpToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // nhậpDữLiệuToolStripMenuItem
            // 
            this.nhậpDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpDanhSáchGVToolStripMenuItem,
            this.nhậpDanhSáchMônHọcToolStripMenuItem});
            this.nhậpDữLiệuToolStripMenuItem.Name = "nhậpDữLiệuToolStripMenuItem";
            this.nhậpDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.nhậpDữLiệuToolStripMenuItem.Text = "Nhập Dữ Liệu";
            this.nhậpDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.nhậpDữLiệuToolStripMenuItem_Click);
            // 
            // nhậpDanhSáchGVToolStripMenuItem
            // 
            this.nhậpDanhSáchGVToolStripMenuItem.Name = "nhậpDanhSáchGVToolStripMenuItem";
            this.nhậpDanhSáchGVToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.nhậpDanhSáchGVToolStripMenuItem.Text = "Nhập danh sách GV";
            this.nhậpDanhSáchGVToolStripMenuItem.Click += new System.EventHandler(this.nhậpDanhSáchGVToolStripMenuItem_Click);
            // 
            // nhậpDanhSáchMônHọcToolStripMenuItem
            // 
            this.nhậpDanhSáchMônHọcToolStripMenuItem.Name = "nhậpDanhSáchMônHọcToolStripMenuItem";
            this.nhậpDanhSáchMônHọcToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.nhậpDanhSáchMônHọcToolStripMenuItem.Text = "Nhập danh sách môn học ";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giáoViênTheoKhoaToolStripMenuItem,
            this.thốngKêGiờDạyToolStripMenuItem,
            this.tínhVượtGiờToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // giáoViênTheoKhoaToolStripMenuItem
            // 
            this.giáoViênTheoKhoaToolStripMenuItem.Name = "giáoViênTheoKhoaToolStripMenuItem";
            this.giáoViênTheoKhoaToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.giáoViênTheoKhoaToolStripMenuItem.Text = "Giáo viên theo khoa";
            this.giáoViênTheoKhoaToolStripMenuItem.Click += new System.EventHandler(this.giáoViênTheoKhoaToolStripMenuItem_Click);
            // 
            // thốngKêGiờDạyToolStripMenuItem
            // 
            this.thốngKêGiờDạyToolStripMenuItem.Name = "thốngKêGiờDạyToolStripMenuItem";
            this.thốngKêGiờDạyToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.thốngKêGiờDạyToolStripMenuItem.Text = "Thống kê giờ dạy";
            this.thốngKêGiờDạyToolStripMenuItem.Click += new System.EventHandler(this.thốngKêGiờDạyToolStripMenuItem_Click);
            // 
            // tínhVượtGiờToolStripMenuItem
            // 
            this.tínhVượtGiờToolStripMenuItem.Name = "tínhVượtGiờToolStripMenuItem";
            this.tínhVượtGiờToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.tínhVượtGiờToolStripMenuItem.Text = "Tính vượt giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(12, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Người Làm: Đoàn Tân Thành";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 210);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Quản Lý Giảng Dạy";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpDanhSáchGVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpDanhSáchMônHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giáoViênTheoKhoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêGiờDạyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhVượtGiờToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}

