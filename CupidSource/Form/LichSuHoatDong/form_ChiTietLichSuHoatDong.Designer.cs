namespace Cupid
{
    partial class form_ChiTietLichSuHoatDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ChiTietLichSuHoatDong));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.label_Value_NgaythaoTac = new System.Windows.Forms.Label();
            this.label_Value_ThaoTac = new System.Windows.Forms.Label();
            this.label_Value_TaiKhoan = new System.Windows.Forms.Label();
            this.label_NgayThaoTac = new System.Windows.Forms.Label();
            this.label_ThaoTac = new System.Windows.Forms.Label();
            this.label_TaiKhoan = new System.Windows.Forms.Label();
            this.label_ChiTiet = new System.Windows.Forms.Label();
            this.button_DongY = new Cupid.Toolbox_Custom.Button_Custom();
            this.label_Value_ChiTiet = new System.Windows.Forms.Label();
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
            this.panel_Top.Size = new System.Drawing.Size(684, 30);
            this.panel_Top.TabIndex = 37;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(34, 8);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(147, 15);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Chi tiết lịch sử hoạt động";
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
            this.button_Close.Location = new System.Drawing.Point(654, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 0;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_Value_NgaythaoTac
            // 
            this.label_Value_NgaythaoTac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Value_NgaythaoTac.BackColor = System.Drawing.Color.Transparent;
            this.label_Value_NgaythaoTac.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Value_NgaythaoTac.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Value_NgaythaoTac.Location = new System.Drawing.Point(141, 113);
            this.label_Value_NgaythaoTac.Name = "label_Value_NgaythaoTac";
            this.label_Value_NgaythaoTac.Size = new System.Drawing.Size(531, 23);
            this.label_Value_NgaythaoTac.TabIndex = 44;
            this.label_Value_NgaythaoTac.Text = "...";
            this.label_Value_NgaythaoTac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Value_ThaoTac
            // 
            this.label_Value_ThaoTac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Value_ThaoTac.BackColor = System.Drawing.Color.Transparent;
            this.label_Value_ThaoTac.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Value_ThaoTac.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Value_ThaoTac.Location = new System.Drawing.Point(103, 79);
            this.label_Value_ThaoTac.Name = "label_Value_ThaoTac";
            this.label_Value_ThaoTac.Size = new System.Drawing.Size(569, 23);
            this.label_Value_ThaoTac.TabIndex = 43;
            this.label_Value_ThaoTac.Text = "...";
            this.label_Value_ThaoTac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Value_TaiKhoan
            // 
            this.label_Value_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Value_TaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.label_Value_TaiKhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Value_TaiKhoan.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Value_TaiKhoan.Location = new System.Drawing.Point(112, 45);
            this.label_Value_TaiKhoan.Name = "label_Value_TaiKhoan";
            this.label_Value_TaiKhoan.Size = new System.Drawing.Size(560, 23);
            this.label_Value_TaiKhoan.TabIndex = 42;
            this.label_Value_TaiKhoan.Text = "...";
            this.label_Value_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_NgayThaoTac
            // 
            this.label_NgayThaoTac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_NgayThaoTac.BackColor = System.Drawing.Color.Transparent;
            this.label_NgayThaoTac.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayThaoTac.ForeColor = System.Drawing.Color.DarkGray;
            this.label_NgayThaoTac.Location = new System.Drawing.Point(24, 113);
            this.label_NgayThaoTac.Name = "label_NgayThaoTac";
            this.label_NgayThaoTac.Size = new System.Drawing.Size(125, 23);
            this.label_NgayThaoTac.TabIndex = 41;
            this.label_NgayThaoTac.Text = "Ngày thao tác:";
            this.label_NgayThaoTac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ThaoTac
            // 
            this.label_ThaoTac.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ThaoTac.BackColor = System.Drawing.Color.Transparent;
            this.label_ThaoTac.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThaoTac.ForeColor = System.Drawing.Color.DarkGray;
            this.label_ThaoTac.Location = new System.Drawing.Point(24, 79);
            this.label_ThaoTac.Name = "label_ThaoTac";
            this.label_ThaoTac.Size = new System.Drawing.Size(90, 23);
            this.label_ThaoTac.TabIndex = 40;
            this.label_ThaoTac.Text = "Thao tác:";
            this.label_ThaoTac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_TaiKhoan
            // 
            this.label_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_TaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.label_TaiKhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TaiKhoan.ForeColor = System.Drawing.Color.DarkGray;
            this.label_TaiKhoan.Location = new System.Drawing.Point(24, 45);
            this.label_TaiKhoan.Name = "label_TaiKhoan";
            this.label_TaiKhoan.Size = new System.Drawing.Size(105, 23);
            this.label_TaiKhoan.TabIndex = 39;
            this.label_TaiKhoan.Text = "Tài khoản:";
            this.label_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ChiTiet
            // 
            this.label_ChiTiet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ChiTiet.BackColor = System.Drawing.Color.Transparent;
            this.label_ChiTiet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChiTiet.ForeColor = System.Drawing.Color.DarkGray;
            this.label_ChiTiet.Location = new System.Drawing.Point(24, 146);
            this.label_ChiTiet.Name = "label_ChiTiet";
            this.label_ChiTiet.Size = new System.Drawing.Size(80, 23);
            this.label_ChiTiet.TabIndex = 45;
            this.label_ChiTiet.Text = "Chi tiết:";
            this.label_ChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_DongY
            // 
            this.button_DongY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DongY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_DongY.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_DongY.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_DongY.BorderRadius = 5;
            this.button_DongY.BorderSize = 0;
            this.button_DongY.FlatAppearance.BorderSize = 0;
            this.button_DongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DongY.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_DongY.ForeColor = System.Drawing.Color.White;
            this.button_DongY.Location = new System.Drawing.Point(592, 473);
            this.button_DongY.Name = "button_DongY";
            this.button_DongY.Size = new System.Drawing.Size(80, 30);
            this.button_DongY.TabIndex = 38;
            this.button_DongY.Text = "Đồng ý";
            this.button_DongY.TextColor = System.Drawing.Color.White;
            this.button_DongY.UseVisualStyleBackColor = false;
            this.button_DongY.Click += new System.EventHandler(this.button_DongY_Click);
            // 
            // label_Value_ChiTiet
            // 
            this.label_Value_ChiTiet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Value_ChiTiet.BackColor = System.Drawing.Color.Transparent;
            this.label_Value_ChiTiet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Value_ChiTiet.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Value_ChiTiet.Location = new System.Drawing.Point(90, 149);
            this.label_Value_ChiTiet.Name = "label_Value_ChiTiet";
            this.label_Value_ChiTiet.Size = new System.Drawing.Size(582, 321);
            this.label_Value_ChiTiet.TabIndex = 46;
            this.label_Value_ChiTiet.Text = "...";
            // 
            // form_ChiTietLichSuHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.label_Value_ChiTiet);
            this.Controls.Add(this.label_ChiTiet);
            this.Controls.Add(this.label_Value_NgaythaoTac);
            this.Controls.Add(this.label_Value_ThaoTac);
            this.Controls.Add(this.label_Value_TaiKhoan);
            this.Controls.Add(this.label_NgayThaoTac);
            this.Controls.Add(this.label_ThaoTac);
            this.Controls.Add(this.label_TaiKhoan);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.button_DongY);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 550);
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "form_ChiTietLichSuHoatDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết lịch sử hoạt động";
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private FontAwesome.Sharp.IconButton button_Close;
        private Toolbox_Custom.Button_Custom button_DongY;
        private System.Windows.Forms.Label label_Value_NgaythaoTac;
        private System.Windows.Forms.Label label_Value_ThaoTac;
        private System.Windows.Forms.Label label_Value_TaiKhoan;
        private System.Windows.Forms.Label label_NgayThaoTac;
        private System.Windows.Forms.Label label_ThaoTac;
        private System.Windows.Forms.Label label_TaiKhoan;
        private System.Windows.Forms.Label label_ChiTiet;
        private System.Windows.Forms.Label label_Value_ChiTiet;
    }
}