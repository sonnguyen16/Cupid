namespace Cupid
{
    partial class form_XemThongTinHinhAnhNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_XemThongTinHinhAnhNguoiDung));
            this.pictureBox_HinhAnh = new System.Windows.Forms.PictureBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Maximize = new FontAwesome.Sharp.IconButton();
            this.button_Minimize = new FontAwesome.Sharp.IconButton();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.panel_SoTrang = new System.Windows.Forms.Panel();
            this.label_TongSoTrang = new System.Windows.Forms.Label();
            this.label_TrangHienTai = new System.Windows.Forms.Label();
            this.button_QuayLai = new FontAwesome.Sharp.IconButton();
            this.button_TienLen = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HinhAnh)).BeginInit();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.panel_Bottom.SuspendLayout();
            this.panel_SoTrang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_HinhAnh
            // 
            this.pictureBox_HinhAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_HinhAnh.Location = new System.Drawing.Point(0, 30);
            this.pictureBox_HinhAnh.Name = "pictureBox_HinhAnh";
            this.pictureBox_HinhAnh.Size = new System.Drawing.Size(1023, 529);
            this.pictureBox_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_HinhAnh.TabIndex = 14;
            this.pictureBox_HinhAnh.TabStop = false;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.panel_Top.Controls.Add(this.label_Title);
            this.panel_Top.Controls.Add(this.pictureBox_Icon);
            this.panel_Top.Controls.Add(this.button_Maximize);
            this.panel_Top.Controls.Add(this.button_Minimize);
            this.panel_Top.Controls.Add(this.button_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1023, 30);
            this.panel_Top.TabIndex = 12;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(34, 8);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(205, 15);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Xem thông tin hình ảnh người dùng";
            // 
            // pictureBox_Icon
            // 
            this.pictureBox_Icon.Image = global::Cupid.Properties.Resources.Icon;
            this.pictureBox_Icon.Location = new System.Drawing.Point(3, 2);
            this.pictureBox_Icon.Name = "pictureBox_Icon";
            this.pictureBox_Icon.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Icon.TabIndex = 7;
            this.pictureBox_Icon.TabStop = false;
            // 
            // button_Maximize
            // 
            this.button_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.button_Maximize.FlatAppearance.BorderSize = 0;
            this.button_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.button_Maximize.IconColor = System.Drawing.Color.White;
            this.button_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_Maximize.IconSize = 30;
            this.button_Maximize.Location = new System.Drawing.Point(963, 0);
            this.button_Maximize.Name = "button_Maximize";
            this.button_Maximize.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.button_Maximize.Size = new System.Drawing.Size(30, 30);
            this.button_Maximize.TabIndex = 1;
            this.button_Maximize.TabStop = false;
            this.button_Maximize.UseVisualStyleBackColor = false;
            this.button_Maximize.Click += new System.EventHandler(this.button_Maximize_Click);
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.button_Minimize.IconColor = System.Drawing.Color.White;
            this.button_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_Minimize.IconSize = 30;
            this.button_Minimize.Location = new System.Drawing.Point(933, 0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.button_Minimize.Size = new System.Drawing.Size(30, 30);
            this.button_Minimize.TabIndex = 2;
            this.button_Minimize.TabStop = false;
            this.button_Minimize.UseVisualStyleBackColor = false;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
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
            this.button_Close.Location = new System.Drawing.Point(993, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 0;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel_Bottom.Controls.Add(this.panel_SoTrang);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 559);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(1023, 50);
            this.panel_Bottom.TabIndex = 13;
            // 
            // panel_SoTrang
            // 
            this.panel_SoTrang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_SoTrang.Controls.Add(this.label_TongSoTrang);
            this.panel_SoTrang.Controls.Add(this.label_TrangHienTai);
            this.panel_SoTrang.Controls.Add(this.button_QuayLai);
            this.panel_SoTrang.Controls.Add(this.button_TienLen);
            this.panel_SoTrang.Location = new System.Drawing.Point(446, 7);
            this.panel_SoTrang.Name = "panel_SoTrang";
            this.panel_SoTrang.Size = new System.Drawing.Size(130, 36);
            this.panel_SoTrang.TabIndex = 2;
            // 
            // label_TongSoTrang
            // 
            this.label_TongSoTrang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_TongSoTrang.ForeColor = System.Drawing.Color.DarkGray;
            this.label_TongSoTrang.Location = new System.Drawing.Point(61, 9);
            this.label_TongSoTrang.Name = "label_TongSoTrang";
            this.label_TongSoTrang.Size = new System.Drawing.Size(31, 19);
            this.label_TongSoTrang.TabIndex = 0;
            this.label_TongSoTrang.Text = "/ 0";
            this.label_TongSoTrang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_TrangHienTai
            // 
            this.label_TrangHienTai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_TrangHienTai.ForeColor = System.Drawing.Color.DarkGray;
            this.label_TrangHienTai.Location = new System.Drawing.Point(37, 9);
            this.label_TrangHienTai.Name = "label_TrangHienTai";
            this.label_TrangHienTai.Size = new System.Drawing.Size(26, 19);
            this.label_TrangHienTai.TabIndex = 0;
            this.label_TrangHienTai.Text = "0";
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
            this.button_QuayLai.Location = new System.Drawing.Point(3, 3);
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
            this.button_TienLen.Location = new System.Drawing.Point(97, 3);
            this.button_TienLen.Name = "button_TienLen";
            this.button_TienLen.Padding = new System.Windows.Forms.Padding(0, 4, 2, 0);
            this.button_TienLen.Size = new System.Drawing.Size(30, 30);
            this.button_TienLen.TabIndex = 2;
            this.button_TienLen.TabStop = false;
            this.button_TienLen.UseVisualStyleBackColor = false;
            this.button_TienLen.Click += new System.EventHandler(this.button_TienLen_Click);
            // 
            // form_XemThongTinHinhAnhNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 609);
            this.Controls.Add(this.pictureBox_HinhAnh);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Bottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "form_XemThongTinHinhAnhNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xem thông tin hình ảnh người dùng";
            this.Load += new System.EventHandler(this.form_XemThongTinHinhAnhNguoiDung_Load);
            this.Resize += new System.EventHandler(this.From_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HinhAnh)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.panel_Bottom.ResumeLayout(false);
            this.panel_SoTrang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_HinhAnh;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private FontAwesome.Sharp.IconButton button_Maximize;
        private FontAwesome.Sharp.IconButton button_Minimize;
        private FontAwesome.Sharp.IconButton button_Close;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Panel panel_SoTrang;
        private System.Windows.Forms.Label label_TongSoTrang;
        private System.Windows.Forms.Label label_TrangHienTai;
        private FontAwesome.Sharp.IconButton button_QuayLai;
        private FontAwesome.Sharp.IconButton button_TienLen;
    }
}