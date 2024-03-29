﻿
namespace Cupid
{
    partial class form_TaoKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_TaoKhuyenMai));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.label_Den = new System.Windows.Forms.Label();
            this.label_Loi = new System.Windows.Forms.Label();
            this.textbox_Phut1 = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.button_Tao = new Cupid.Toolbox_Custom.Button_Custom();
            this.dateTimePicker_NgayKetThuc = new Cupid.DateTimePicker_Custom();
            this.dateTimePicker_NgayBatDau = new Cupid.DateTimePicker_Custom();
            this.textbox_NoiDungKhuyenMai = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.textbox_TenKhuyenMai = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.textbox_Gio1 = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.textbox_Phut2 = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.textbox_Gio2 = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.label_HaiCham1 = new System.Windows.Forms.Label();
            this.label_HaiCham2 = new System.Windows.Forms.Label();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
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
            this.panel_Top.Size = new System.Drawing.Size(350, 30);
            this.panel_Top.TabIndex = 0;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(34, 8);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(96, 15);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Tạo khuyến mãi";
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
            this.button_Close.Location = new System.Drawing.Point(320, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 0;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_Den
            // 
            this.label_Den.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_Den.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Den.Location = new System.Drawing.Point(138, 147);
            this.label_Den.Name = "label_Den";
            this.label_Den.Size = new System.Drawing.Size(75, 19);
            this.label_Den.TabIndex = 0;
            this.label_Den.Text = "đến";
            this.label_Den.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Loi
            // 
            this.label_Loi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Loi.AutoSize = true;
            this.label_Loi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Loi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label_Loi.Location = new System.Drawing.Point(12, 207);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(0, 15);
            this.label_Loi.TabIndex = 0;
            // 
            // textbox_Phut1
            // 
            this.textbox_Phut1.BackColor = System.Drawing.Color.White;
            this.textbox_Phut1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_Phut1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.textbox_Phut1.BorderRadius = 0;
            this.textbox_Phut1.BorderSize = 3;
            this.textbox_Phut1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_Phut1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_Phut1.IsPlaceHolder = true;
            this.textbox_Phut1.Location = new System.Drawing.Point(76, 157);
            this.textbox_Phut1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbox_Phut1.Multiline = true;
            this.textbox_Phut1.Name = "textbox_Phut1";
            this.textbox_Phut1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 7);
            this.textbox_Phut1.PasswordChar = false;
            this.textbox_Phut1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_Phut1.PlaceholderText = "Phút";
            this.textbox_Phut1.Size = new System.Drawing.Size(55, 35);
            this.textbox_Phut1.TabIndex = 5;
            this.textbox_Phut1.Texts = "";
            this.textbox_Phut1.UnderlinedStyle = false;
            this.textbox_Phut1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Phut1_KeyPress);
            // 
            // button_Tao
            // 
            this.button_Tao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Tao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Tao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Tao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Tao.BorderRadius = 5;
            this.button_Tao.BorderSize = 0;
            this.button_Tao.FlatAppearance.BorderSize = 0;
            this.button_Tao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Tao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Tao.ForeColor = System.Drawing.Color.White;
            this.button_Tao.Location = new System.Drawing.Point(258, 199);
            this.button_Tao.Name = "button_Tao";
            this.button_Tao.Size = new System.Drawing.Size(80, 30);
            this.button_Tao.TabIndex = 0;
            this.button_Tao.Text = "Tạo";
            this.button_Tao.TextColor = System.Drawing.Color.White;
            this.button_Tao.UseVisualStyleBackColor = false;
            this.button_Tao.Click += new System.EventHandler(this.button_Tao_Click);
            // 
            // dateTimePicker_NgayKetThuc
            // 
            this.dateTimePicker_NgayKetThuc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.dateTimePicker_NgayKetThuc.BorderSize = 3;
            this.dateTimePicker_NgayKetThuc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateTimePicker_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayKetThuc.Location = new System.Drawing.Point(218, 116);
            this.dateTimePicker_NgayKetThuc.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePicker_NgayKetThuc.Name = "dateTimePicker_NgayKetThuc";
            this.dateTimePicker_NgayKetThuc.Size = new System.Drawing.Size(120, 35);
            this.dateTimePicker_NgayKetThuc.SkinColor = System.Drawing.Color.White;
            this.dateTimePicker_NgayKetThuc.TabIndex = 6;
            this.dateTimePicker_NgayKetThuc.TextColor = System.Drawing.Color.DarkGray;
            // 
            // dateTimePicker_NgayBatDau
            // 
            this.dateTimePicker_NgayBatDau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.dateTimePicker_NgayBatDau.BorderSize = 3;
            this.dateTimePicker_NgayBatDau.Checked = false;
            this.dateTimePicker_NgayBatDau.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateTimePicker_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayBatDau.Location = new System.Drawing.Point(11, 116);
            this.dateTimePicker_NgayBatDau.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePicker_NgayBatDau.Name = "dateTimePicker_NgayBatDau";
            this.dateTimePicker_NgayBatDau.Size = new System.Drawing.Size(120, 35);
            this.dateTimePicker_NgayBatDau.SkinColor = System.Drawing.Color.White;
            this.dateTimePicker_NgayBatDau.TabIndex = 3;
            this.dateTimePicker_NgayBatDau.TextColor = System.Drawing.Color.DarkGray;
            // 
            // textbox_NoiDungKhuyenMai
            // 
            this.textbox_NoiDungKhuyenMai.BackColor = System.Drawing.Color.White;
            this.textbox_NoiDungKhuyenMai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_NoiDungKhuyenMai.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_NoiDungKhuyenMai.BorderRadius = 0;
            this.textbox_NoiDungKhuyenMai.BorderSize = 4;
            this.textbox_NoiDungKhuyenMai.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_NoiDungKhuyenMai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_NoiDungKhuyenMai.IsPlaceHolder = true;
            this.textbox_NoiDungKhuyenMai.Location = new System.Drawing.Point(11, 75);
            this.textbox_NoiDungKhuyenMai.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbox_NoiDungKhuyenMai.Multiline = true;
            this.textbox_NoiDungKhuyenMai.Name = "textbox_NoiDungKhuyenMai";
            this.textbox_NoiDungKhuyenMai.Padding = new System.Windows.Forms.Padding(9, 9, 9, 7);
            this.textbox_NoiDungKhuyenMai.PasswordChar = false;
            this.textbox_NoiDungKhuyenMai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_NoiDungKhuyenMai.PlaceholderText = "Nội dung khuyến mãi";
            this.textbox_NoiDungKhuyenMai.Size = new System.Drawing.Size(328, 35);
            this.textbox_NoiDungKhuyenMai.TabIndex = 2;
            this.textbox_NoiDungKhuyenMai.Texts = "";
            this.textbox_NoiDungKhuyenMai.UnderlinedStyle = true;
            // 
            // textbox_TenKhuyenMai
            // 
            this.textbox_TenKhuyenMai.BackColor = System.Drawing.Color.White;
            this.textbox_TenKhuyenMai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_TenKhuyenMai.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_TenKhuyenMai.BorderRadius = 0;
            this.textbox_TenKhuyenMai.BorderSize = 4;
            this.textbox_TenKhuyenMai.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_TenKhuyenMai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_TenKhuyenMai.IsPlaceHolder = true;
            this.textbox_TenKhuyenMai.Location = new System.Drawing.Point(11, 36);
            this.textbox_TenKhuyenMai.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbox_TenKhuyenMai.Multiline = false;
            this.textbox_TenKhuyenMai.Name = "textbox_TenKhuyenMai";
            this.textbox_TenKhuyenMai.Padding = new System.Windows.Forms.Padding(9, 9, 9, 7);
            this.textbox_TenKhuyenMai.PasswordChar = false;
            this.textbox_TenKhuyenMai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_TenKhuyenMai.PlaceholderText = "Tên khuyến mãi";
            this.textbox_TenKhuyenMai.Size = new System.Drawing.Size(328, 33);
            this.textbox_TenKhuyenMai.TabIndex = 1;
            this.textbox_TenKhuyenMai.Texts = "";
            this.textbox_TenKhuyenMai.UnderlinedStyle = true;
            // 
            // textbox_Gio1
            // 
            this.textbox_Gio1.BackColor = System.Drawing.Color.White;
            this.textbox_Gio1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_Gio1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.textbox_Gio1.BorderRadius = 0;
            this.textbox_Gio1.BorderSize = 3;
            this.textbox_Gio1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_Gio1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_Gio1.IsPlaceHolder = true;
            this.textbox_Gio1.Location = new System.Drawing.Point(10, 157);
            this.textbox_Gio1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbox_Gio1.Multiline = true;
            this.textbox_Gio1.Name = "textbox_Gio1";
            this.textbox_Gio1.Padding = new System.Windows.Forms.Padding(9, 9, 9, 7);
            this.textbox_Gio1.PasswordChar = false;
            this.textbox_Gio1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_Gio1.PlaceholderText = "Giờ";
            this.textbox_Gio1.Size = new System.Drawing.Size(55, 35);
            this.textbox_Gio1.TabIndex = 4;
            this.textbox_Gio1.Texts = "";
            this.textbox_Gio1.UnderlinedStyle = false;
            this.textbox_Gio1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Gio1_KeyPress);
            // 
            // textbox_Phut2
            // 
            this.textbox_Phut2.BackColor = System.Drawing.Color.White;
            this.textbox_Phut2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_Phut2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.textbox_Phut2.BorderRadius = 0;
            this.textbox_Phut2.BorderSize = 3;
            this.textbox_Phut2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_Phut2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_Phut2.IsPlaceHolder = true;
            this.textbox_Phut2.Location = new System.Drawing.Point(284, 157);
            this.textbox_Phut2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbox_Phut2.Multiline = true;
            this.textbox_Phut2.Name = "textbox_Phut2";
            this.textbox_Phut2.Padding = new System.Windows.Forms.Padding(9, 9, 9, 7);
            this.textbox_Phut2.PasswordChar = false;
            this.textbox_Phut2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_Phut2.PlaceholderText = "Phút";
            this.textbox_Phut2.Size = new System.Drawing.Size(55, 35);
            this.textbox_Phut2.TabIndex = 8;
            this.textbox_Phut2.Texts = "";
            this.textbox_Phut2.UnderlinedStyle = false;
            this.textbox_Phut2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Phut2_KeyPress);
            // 
            // textbox_Gio2
            // 
            this.textbox_Gio2.BackColor = System.Drawing.Color.White;
            this.textbox_Gio2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_Gio2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.textbox_Gio2.BorderRadius = 0;
            this.textbox_Gio2.BorderSize = 3;
            this.textbox_Gio2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_Gio2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_Gio2.IsPlaceHolder = true;
            this.textbox_Gio2.Location = new System.Drawing.Point(218, 157);
            this.textbox_Gio2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbox_Gio2.Multiline = true;
            this.textbox_Gio2.Name = "textbox_Gio2";
            this.textbox_Gio2.Padding = new System.Windows.Forms.Padding(9, 9, 9, 7);
            this.textbox_Gio2.PasswordChar = false;
            this.textbox_Gio2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_Gio2.PlaceholderText = "Giờ";
            this.textbox_Gio2.Size = new System.Drawing.Size(55, 35);
            this.textbox_Gio2.TabIndex = 7;
            this.textbox_Gio2.Texts = "";
            this.textbox_Gio2.UnderlinedStyle = false;
            this.textbox_Gio2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Gio2_KeyPress);
            // 
            // label_HaiCham1
            // 
            this.label_HaiCham1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_HaiCham1.AutoSize = true;
            this.label_HaiCham1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_HaiCham1.ForeColor = System.Drawing.Color.DarkGray;
            this.label_HaiCham1.Location = new System.Drawing.Point(66, 166);
            this.label_HaiCham1.Name = "label_HaiCham1";
            this.label_HaiCham1.Size = new System.Drawing.Size(10, 15);
            this.label_HaiCham1.TabIndex = 9;
            this.label_HaiCham1.Text = ":";
            // 
            // label_HaiCham2
            // 
            this.label_HaiCham2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_HaiCham2.AutoSize = true;
            this.label_HaiCham2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_HaiCham2.ForeColor = System.Drawing.Color.DarkGray;
            this.label_HaiCham2.Location = new System.Drawing.Point(274, 166);
            this.label_HaiCham2.Name = "label_HaiCham2";
            this.label_HaiCham2.Size = new System.Drawing.Size(10, 15);
            this.label_HaiCham2.TabIndex = 10;
            this.label_HaiCham2.Text = ":";
            // 
            // form_TaoKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 241);
            this.Controls.Add(this.label_HaiCham2);
            this.Controls.Add(this.label_HaiCham1);
            this.Controls.Add(this.textbox_Phut2);
            this.Controls.Add(this.textbox_Gio2);
            this.Controls.Add(this.textbox_Phut1);
            this.Controls.Add(this.textbox_Gio1);
            this.Controls.Add(this.label_Loi);
            this.Controls.Add(this.button_Tao);
            this.Controls.Add(this.label_Den);
            this.Controls.Add(this.dateTimePicker_NgayKetThuc);
            this.Controls.Add(this.dateTimePicker_NgayBatDau);
            this.Controls.Add(this.textbox_NoiDungKhuyenMai);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.textbox_TenKhuyenMai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(366, 280);
            this.MinimumSize = new System.Drawing.Size(366, 280);
            this.Name = "form_TaoKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tạo khuyến mãi";
            this.Load += new System.EventHandler(this.form_TaoKhuyenMai_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Toolbox_Custom.Textbox_Custom textbox_TenKhuyenMai;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private FontAwesome.Sharp.IconButton button_Close;
        private Toolbox_Custom.Textbox_Custom textbox_NoiDungKhuyenMai;
        private System.Windows.Forms.Label label_Den;
        private DateTimePicker_Custom dateTimePicker_NgayKetThuc;
        private DateTimePicker_Custom dateTimePicker_NgayBatDau;
        private Toolbox_Custom.Button_Custom button_Tao;
        private System.Windows.Forms.Label label_Loi;
        private Toolbox_Custom.Textbox_Custom textbox_Phut1;
        private Toolbox_Custom.Textbox_Custom textbox_Gio1;
        private Toolbox_Custom.Textbox_Custom textbox_Phut2;
        private Toolbox_Custom.Textbox_Custom textbox_Gio2;
        private System.Windows.Forms.Label label_HaiCham1;
        private System.Windows.Forms.Label label_HaiCham2;
    }
}