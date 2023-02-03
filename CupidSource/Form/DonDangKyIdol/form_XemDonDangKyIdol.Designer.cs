
namespace Cupid
{
    partial class form_XemDonDangKyIdol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_XemDonDangKyIdol));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.textbox_NoiDung = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.textbox_NguoiGui = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.textbox_ChuDe = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.panel_HinhAnh = new System.Windows.Forms.Panel();
            this.pictureBox_HinhAnh = new System.Windows.Forms.PictureBox();
            this.button_PhanHoi = new Cupid.Toolbox_Custom.Button_Custom();
            this.button_Facebook = new FontAwesome.Sharp.IconButton();
            this.button_Tiktok = new FontAwesome.Sharp.IconButton();
            this.button_Instagram = new FontAwesome.Sharp.IconButton();
            this.button_Twitter = new FontAwesome.Sharp.IconButton();
            this.panel_SoTrang = new System.Windows.Forms.Panel();
            this.label_TongSoTrang = new System.Windows.Forms.Label();
            this.label_TrangHienTai = new System.Windows.Forms.Label();
            this.button_QuayLai = new FontAwesome.Sharp.IconButton();
            this.button_TienLen = new FontAwesome.Sharp.IconButton();
            this.button_QuayLai2 = new FontAwesome.Sharp.IconButton();
            this.button_TienLen2 = new FontAwesome.Sharp.IconButton();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.panel_HinhAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HinhAnh)).BeginInit();
            this.panel_SoTrang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.panel_Top.Controls.Add(this.label_Title);
            this.panel_Top.Controls.Add(this.pictureBox_Icon);
            this.panel_Top.Controls.Add(this.button_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(600, 30);
            this.panel_Top.TabIndex = 13;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(34, 8);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(129, 15);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Xem đơn đăng ký Idol";
            // 
            // pictureBox_Icon
            // 
            this.pictureBox_Icon.Image = global::Cupid.Properties.Resources.Icon;
            this.pictureBox_Icon.Location = new System.Drawing.Point(3, 2);
            this.pictureBox_Icon.Name = "pictureBox_Icon";
            this.pictureBox_Icon.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Icon.TabIndex = 1;
            this.pictureBox_Icon.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.button_Close.IconColor = System.Drawing.Color.White;
            this.button_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_Close.IconSize = 30;
            this.button_Close.Location = new System.Drawing.Point(570, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 0;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // textbox_NoiDung
            // 
            this.textbox_NoiDung.BackColor = System.Drawing.Color.White;
            this.textbox_NoiDung.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_NoiDung.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_NoiDung.BorderRadius = 5;
            this.textbox_NoiDung.BorderSize = 2;
            this.textbox_NoiDung.Enabled = false;
            this.textbox_NoiDung.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_NoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_NoiDung.IsPlaceHolder = true;
            this.textbox_NoiDung.Location = new System.Drawing.Point(12, 109);
            this.textbox_NoiDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_NoiDung.Multiline = true;
            this.textbox_NoiDung.Name = "textbox_NoiDung";
            this.textbox_NoiDung.Padding = new System.Windows.Forms.Padding(10, 7, 10, 6);
            this.textbox_NoiDung.PasswordChar = false;
            this.textbox_NoiDung.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_NoiDung.PlaceholderText = "Nội dung";
            this.textbox_NoiDung.Size = new System.Drawing.Size(576, 194);
            this.textbox_NoiDung.TabIndex = 3;
            this.textbox_NoiDung.Texts = "";
            this.textbox_NoiDung.UnderlinedStyle = false;
            // 
            // textbox_NguoiGui
            // 
            this.textbox_NguoiGui.BackColor = System.Drawing.Color.White;
            this.textbox_NguoiGui.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_NguoiGui.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_NguoiGui.BorderRadius = 5;
            this.textbox_NguoiGui.BorderSize = 2;
            this.textbox_NguoiGui.Enabled = false;
            this.textbox_NguoiGui.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_NguoiGui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_NguoiGui.IsPlaceHolder = true;
            this.textbox_NguoiGui.Location = new System.Drawing.Point(12, 37);
            this.textbox_NguoiGui.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_NguoiGui.Multiline = false;
            this.textbox_NguoiGui.Name = "textbox_NguoiGui";
            this.textbox_NguoiGui.Padding = new System.Windows.Forms.Padding(10, 7, 10, 6);
            this.textbox_NguoiGui.PasswordChar = false;
            this.textbox_NguoiGui.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_NguoiGui.PlaceholderText = "Người gửi";
            this.textbox_NguoiGui.Size = new System.Drawing.Size(576, 30);
            this.textbox_NguoiGui.TabIndex = 1;
            this.textbox_NguoiGui.Texts = "";
            this.textbox_NguoiGui.UnderlinedStyle = false;
            // 
            // textbox_ChuDe
            // 
            this.textbox_ChuDe.BackColor = System.Drawing.Color.White;
            this.textbox_ChuDe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_ChuDe.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_ChuDe.BorderRadius = 5;
            this.textbox_ChuDe.BorderSize = 2;
            this.textbox_ChuDe.Enabled = false;
            this.textbox_ChuDe.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_ChuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_ChuDe.IsPlaceHolder = true;
            this.textbox_ChuDe.Location = new System.Drawing.Point(12, 73);
            this.textbox_ChuDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_ChuDe.Multiline = false;
            this.textbox_ChuDe.Name = "textbox_ChuDe";
            this.textbox_ChuDe.Padding = new System.Windows.Forms.Padding(10, 7, 10, 6);
            this.textbox_ChuDe.PasswordChar = false;
            this.textbox_ChuDe.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_ChuDe.PlaceholderText = "Chủ đề";
            this.textbox_ChuDe.Size = new System.Drawing.Size(576, 30);
            this.textbox_ChuDe.TabIndex = 2;
            this.textbox_ChuDe.Texts = "";
            this.textbox_ChuDe.UnderlinedStyle = false;
            // 
            // panel_HinhAnh
            // 
            this.panel_HinhAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.panel_HinhAnh.Controls.Add(this.pictureBox_HinhAnh);
            this.panel_HinhAnh.Location = new System.Drawing.Point(12, 310);
            this.panel_HinhAnh.Name = "panel_HinhAnh";
            this.panel_HinhAnh.Size = new System.Drawing.Size(369, 160);
            this.panel_HinhAnh.TabIndex = 8;
            // 
            // pictureBox_HinhAnh
            // 
            this.pictureBox_HinhAnh.BackColor = System.Drawing.Color.White;
            this.pictureBox_HinhAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_HinhAnh.Location = new System.Drawing.Point(2, 2);
            this.pictureBox_HinhAnh.Name = "pictureBox_HinhAnh";
            this.pictureBox_HinhAnh.Size = new System.Drawing.Size(365, 156);
            this.pictureBox_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_HinhAnh.TabIndex = 53;
            this.pictureBox_HinhAnh.TabStop = false;
            this.pictureBox_HinhAnh.Click += new System.EventHandler(this.pictureBox_HinhAnh_Click);
            // 
            // button_PhanHoi
            // 
            this.button_PhanHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_PhanHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_PhanHoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_PhanHoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_PhanHoi.BorderRadius = 5;
            this.button_PhanHoi.BorderSize = 0;
            this.button_PhanHoi.FlatAppearance.BorderSize = 0;
            this.button_PhanHoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PhanHoi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_PhanHoi.ForeColor = System.Drawing.Color.White;
            this.button_PhanHoi.Location = new System.Drawing.Point(508, 480);
            this.button_PhanHoi.Name = "button_PhanHoi";
            this.button_PhanHoi.Size = new System.Drawing.Size(80, 30);
            this.button_PhanHoi.TabIndex = 0;
            this.button_PhanHoi.Text = "Phản hồi";
            this.button_PhanHoi.TextColor = System.Drawing.Color.White;
            this.button_PhanHoi.UseVisualStyleBackColor = false;
            this.button_PhanHoi.Click += new System.EventHandler(this.button_PhanHoi_Click);
            // 
            // button_Facebook
            // 
            this.button_Facebook.BackColor = System.Drawing.Color.White;
            this.button_Facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Facebook.FlatAppearance.BorderSize = 0;
            this.button_Facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Facebook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Facebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Facebook.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            this.button_Facebook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Facebook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_Facebook.IconSize = 50;
            this.button_Facebook.Location = new System.Drawing.Point(384, 310);
            this.button_Facebook.Margin = new System.Windows.Forms.Padding(0);
            this.button_Facebook.Name = "button_Facebook";
            this.button_Facebook.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.button_Facebook.Size = new System.Drawing.Size(100, 80);
            this.button_Facebook.TabIndex = 4;
            this.button_Facebook.TabStop = false;
            this.button_Facebook.Text = "Facebook";
            this.button_Facebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Facebook.UseVisualStyleBackColor = false;
            this.button_Facebook.Click += new System.EventHandler(this.button_Facebook_Click);
            // 
            // button_Tiktok
            // 
            this.button_Tiktok.BackColor = System.Drawing.Color.White;
            this.button_Tiktok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Tiktok.FlatAppearance.BorderSize = 0;
            this.button_Tiktok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Tiktok.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Tiktok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Tiktok.IconChar = FontAwesome.Sharp.IconChar.Tiktok;
            this.button_Tiktok.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Tiktok.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_Tiktok.IconSize = 50;
            this.button_Tiktok.Location = new System.Drawing.Point(488, 310);
            this.button_Tiktok.Margin = new System.Windows.Forms.Padding(0);
            this.button_Tiktok.Name = "button_Tiktok";
            this.button_Tiktok.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.button_Tiktok.Size = new System.Drawing.Size(100, 80);
            this.button_Tiktok.TabIndex = 6;
            this.button_Tiktok.TabStop = false;
            this.button_Tiktok.Text = "Tiktok";
            this.button_Tiktok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Tiktok.UseVisualStyleBackColor = false;
            this.button_Tiktok.Click += new System.EventHandler(this.button_Tiktok_Click);
            // 
            // button_Instagram
            // 
            this.button_Instagram.BackColor = System.Drawing.Color.White;
            this.button_Instagram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Instagram.FlatAppearance.BorderSize = 0;
            this.button_Instagram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Instagram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Instagram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Instagram.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            this.button_Instagram.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Instagram.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_Instagram.IconSize = 50;
            this.button_Instagram.Location = new System.Drawing.Point(488, 390);
            this.button_Instagram.Margin = new System.Windows.Forms.Padding(0);
            this.button_Instagram.Name = "button_Instagram";
            this.button_Instagram.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.button_Instagram.Size = new System.Drawing.Size(100, 80);
            this.button_Instagram.TabIndex = 7;
            this.button_Instagram.TabStop = false;
            this.button_Instagram.Text = "Instagram";
            this.button_Instagram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Instagram.UseVisualStyleBackColor = false;
            this.button_Instagram.Click += new System.EventHandler(this.button_Instagram_Click);
            // 
            // button_Twitter
            // 
            this.button_Twitter.BackColor = System.Drawing.Color.White;
            this.button_Twitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Twitter.FlatAppearance.BorderSize = 0;
            this.button_Twitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Twitter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Twitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Twitter.IconChar = FontAwesome.Sharp.IconChar.Twitter;
            this.button_Twitter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Twitter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_Twitter.IconSize = 50;
            this.button_Twitter.Location = new System.Drawing.Point(384, 390);
            this.button_Twitter.Margin = new System.Windows.Forms.Padding(0);
            this.button_Twitter.Name = "button_Twitter";
            this.button_Twitter.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.button_Twitter.Size = new System.Drawing.Size(100, 80);
            this.button_Twitter.TabIndex = 5;
            this.button_Twitter.TabStop = false;
            this.button_Twitter.Text = "Twitter";
            this.button_Twitter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_Twitter.UseVisualStyleBackColor = false;
            this.button_Twitter.Click += new System.EventHandler(this.button_Youtube_Click);
            // 
            // panel_SoTrang
            // 
            this.panel_SoTrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_SoTrang.Controls.Add(this.button_QuayLai2);
            this.panel_SoTrang.Controls.Add(this.button_TienLen2);
            this.panel_SoTrang.Controls.Add(this.label_TongSoTrang);
            this.panel_SoTrang.Controls.Add(this.label_TrangHienTai);
            this.panel_SoTrang.Controls.Add(this.button_QuayLai);
            this.panel_SoTrang.Controls.Add(this.button_TienLen);
            this.panel_SoTrang.Location = new System.Drawing.Point(96, 474);
            this.panel_SoTrang.Name = "panel_SoTrang";
            this.panel_SoTrang.Size = new System.Drawing.Size(200, 36);
            this.panel_SoTrang.TabIndex = 14;
            // 
            // label_TongSoTrang
            // 
            this.label_TongSoTrang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_TongSoTrang.ForeColor = System.Drawing.Color.DarkGray;
            this.label_TongSoTrang.Location = new System.Drawing.Point(96, 9);
            this.label_TongSoTrang.Name = "label_TongSoTrang";
            this.label_TongSoTrang.Size = new System.Drawing.Size(35, 19);
            this.label_TongSoTrang.TabIndex = 0;
            this.label_TongSoTrang.Text = "/ 0";
            this.label_TongSoTrang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_TrangHienTai
            // 
            this.label_TrangHienTai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_TrangHienTai.ForeColor = System.Drawing.Color.DarkGray;
            this.label_TrangHienTai.Location = new System.Drawing.Point(72, 9);
            this.label_TrangHienTai.Name = "label_TrangHienTai";
            this.label_TrangHienTai.Size = new System.Drawing.Size(27, 19);
            this.label_TrangHienTai.TabIndex = 0;
            this.label_TrangHienTai.Text = "1";
            this.label_TrangHienTai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_QuayLai
            // 
            this.button_QuayLai.BackColor = System.Drawing.Color.DarkGray;
            this.button_QuayLai.FlatAppearance.BorderSize = 0;
            this.button_QuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_QuayLai.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.button_QuayLai.IconColor = System.Drawing.Color.White;
            this.button_QuayLai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_QuayLai.IconSize = 30;
            this.button_QuayLai.Location = new System.Drawing.Point(38, 3);
            this.button_QuayLai.Name = "button_QuayLai";
            this.button_QuayLai.Padding = new System.Windows.Forms.Padding(0, 4, 2, 0);
            this.button_QuayLai.Size = new System.Drawing.Size(30, 30);
            this.button_QuayLai.TabIndex = 1;
            this.button_QuayLai.TabStop = false;
            this.button_QuayLai.UseVisualStyleBackColor = false;
            this.button_QuayLai.Click += new System.EventHandler(this.button_QuayLai_Click);
            // 
            // button_TienLen
            // 
            this.button_TienLen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_TienLen.FlatAppearance.BorderSize = 0;
            this.button_TienLen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TienLen.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.button_TienLen.IconColor = System.Drawing.Color.White;
            this.button_TienLen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_TienLen.IconSize = 30;
            this.button_TienLen.Location = new System.Drawing.Point(132, 3);
            this.button_TienLen.Name = "button_TienLen";
            this.button_TienLen.Padding = new System.Windows.Forms.Padding(0, 4, 2, 0);
            this.button_TienLen.Size = new System.Drawing.Size(30, 30);
            this.button_TienLen.TabIndex = 2;
            this.button_TienLen.TabStop = false;
            this.button_TienLen.UseVisualStyleBackColor = false;
            this.button_TienLen.Click += new System.EventHandler(this.button_TienLen_Click);
            // 
            // button_QuayLai2
            // 
            this.button_QuayLai2.BackColor = System.Drawing.Color.DarkGray;
            this.button_QuayLai2.FlatAppearance.BorderSize = 0;
            this.button_QuayLai2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_QuayLai2.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.button_QuayLai2.IconColor = System.Drawing.Color.White;
            this.button_QuayLai2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_QuayLai2.IconSize = 30;
            this.button_QuayLai2.Location = new System.Drawing.Point(2, 3);
            this.button_QuayLai2.Name = "button_QuayLai2";
            this.button_QuayLai2.Padding = new System.Windows.Forms.Padding(0, 4, 2, 0);
            this.button_QuayLai2.Size = new System.Drawing.Size(30, 30);
            this.button_QuayLai2.TabIndex = 4;
            this.button_QuayLai2.TabStop = false;
            this.button_QuayLai2.UseVisualStyleBackColor = false;
            this.button_QuayLai2.Visible = false;
            // 
            // button_TienLen2
            // 
            this.button_TienLen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_TienLen2.FlatAppearance.BorderSize = 0;
            this.button_TienLen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TienLen2.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.button_TienLen2.IconColor = System.Drawing.Color.White;
            this.button_TienLen2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_TienLen2.IconSize = 30;
            this.button_TienLen2.Location = new System.Drawing.Point(168, 3);
            this.button_TienLen2.Name = "button_TienLen2";
            this.button_TienLen2.Padding = new System.Windows.Forms.Padding(0, 4, 2, 0);
            this.button_TienLen2.Size = new System.Drawing.Size(30, 30);
            this.button_TienLen2.TabIndex = 3;
            this.button_TienLen2.TabStop = false;
            this.button_TienLen2.UseVisualStyleBackColor = false;
            this.button_TienLen2.Visible = false;
            // 
            // form_XemDonDangKyIdol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.panel_SoTrang);
            this.Controls.Add(this.button_Tiktok);
            this.Controls.Add(this.button_Instagram);
            this.Controls.Add(this.button_Twitter);
            this.Controls.Add(this.button_Facebook);
            this.Controls.Add(this.button_PhanHoi);
            this.Controls.Add(this.panel_HinhAnh);
            this.Controls.Add(this.textbox_NoiDung);
            this.Controls.Add(this.textbox_NguoiGui);
            this.Controls.Add(this.textbox_ChuDe);
            this.Controls.Add(this.panel_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(616, 559);
            this.MinimumSize = new System.Drawing.Size(616, 559);
            this.Name = "form_XemDonDangKyIdol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xem đơn đăng ký Idol";
            this.Load += new System.EventHandler(this.form_XemDonDangKyIdol_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.panel_HinhAnh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HinhAnh)).EndInit();
            this.panel_SoTrang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private FontAwesome.Sharp.IconButton button_Close;
        private Toolbox_Custom.Textbox_Custom textbox_NoiDung;
        private Toolbox_Custom.Textbox_Custom textbox_NguoiGui;
        private Toolbox_Custom.Textbox_Custom textbox_ChuDe;
        private System.Windows.Forms.Panel panel_HinhAnh;
        private System.Windows.Forms.PictureBox pictureBox_HinhAnh;
        private Toolbox_Custom.Button_Custom button_PhanHoi;
        private FontAwesome.Sharp.IconButton button_Facebook;
        private FontAwesome.Sharp.IconButton button_Tiktok;
        private FontAwesome.Sharp.IconButton button_Instagram;
        private FontAwesome.Sharp.IconButton button_Twitter;
        private System.Windows.Forms.Panel panel_SoTrang;
        private System.Windows.Forms.Label label_TongSoTrang;
        private System.Windows.Forms.Label label_TrangHienTai;
        private FontAwesome.Sharp.IconButton button_QuayLai;
        private FontAwesome.Sharp.IconButton button_TienLen;
        private FontAwesome.Sharp.IconButton button_QuayLai2;
        private FontAwesome.Sharp.IconButton button_TienLen2;
    }
}