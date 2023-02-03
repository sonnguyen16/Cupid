
namespace Cupid
{
    partial class form_PhanHoiBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_PhanHoiBaoCao));
            this.button_Gui = new Cupid.Toolbox_Custom.Button_Custom();
            this.textbox_NoiDung = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.textbox_NguoiNhan = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.textbox_ChuDe = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.checkBox_Gmail = new Cupid.CheckBox_Custom();
            this.checkBox_SoDienThoai = new Cupid.CheckBox_Custom();
            this.label_Loi = new System.Windows.Forms.Label();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Gui
            // 
            this.button_Gui.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Gui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Gui.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Gui.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Gui.BorderRadius = 5;
            this.button_Gui.BorderSize = 0;
            this.button_Gui.FlatAppearance.BorderSize = 0;
            this.button_Gui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Gui.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Gui.ForeColor = System.Drawing.Color.White;
            this.button_Gui.Location = new System.Drawing.Point(508, 308);
            this.button_Gui.Name = "button_Gui";
            this.button_Gui.Size = new System.Drawing.Size(80, 30);
            this.button_Gui.TabIndex = 0;
            this.button_Gui.Text = "Gửi";
            this.button_Gui.TextColor = System.Drawing.Color.White;
            this.button_Gui.UseVisualStyleBackColor = false;
            this.button_Gui.Click += new System.EventHandler(this.button_Gui_Click);
            // 
            // textbox_NoiDung
            // 
            this.textbox_NoiDung.BackColor = System.Drawing.Color.White;
            this.textbox_NoiDung.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_NoiDung.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_NoiDung.BorderRadius = 5;
            this.textbox_NoiDung.BorderSize = 2;
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
            // textbox_NguoiNhan
            // 
            this.textbox_NguoiNhan.BackColor = System.Drawing.Color.White;
            this.textbox_NguoiNhan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_NguoiNhan.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_NguoiNhan.BorderRadius = 5;
            this.textbox_NguoiNhan.BorderSize = 2;
            this.textbox_NguoiNhan.Enabled = false;
            this.textbox_NguoiNhan.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_NguoiNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_NguoiNhan.IsPlaceHolder = true;
            this.textbox_NguoiNhan.Location = new System.Drawing.Point(12, 37);
            this.textbox_NguoiNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_NguoiNhan.Multiline = false;
            this.textbox_NguoiNhan.Name = "textbox_NguoiNhan";
            this.textbox_NguoiNhan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 6);
            this.textbox_NguoiNhan.PasswordChar = false;
            this.textbox_NguoiNhan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_NguoiNhan.PlaceholderText = "Người nhận";
            this.textbox_NguoiNhan.Size = new System.Drawing.Size(576, 30);
            this.textbox_NguoiNhan.TabIndex = 1;
            this.textbox_NguoiNhan.Texts = "";
            this.textbox_NguoiNhan.UnderlinedStyle = false;
            // 
            // textbox_ChuDe
            // 
            this.textbox_ChuDe.BackColor = System.Drawing.Color.White;
            this.textbox_ChuDe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_ChuDe.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_ChuDe.BorderRadius = 5;
            this.textbox_ChuDe.BorderSize = 2;
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
            this.label_Title.Size = new System.Drawing.Size(104, 15);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Phản hồi báo cáo";
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
            // checkBox_Gmail
            // 
            this.checkBox_Gmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_Gmail.AutoSize = true;
            this.checkBox_Gmail.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.checkBox_Gmail.ForeColor = System.Drawing.Color.Gray;
            this.checkBox_Gmail.Location = new System.Drawing.Point(16, 317);
            this.checkBox_Gmail.MinimumSize = new System.Drawing.Size(0, 21);
            this.checkBox_Gmail.Name = "checkBox_Gmail";
            this.checkBox_Gmail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkBox_Gmail.Size = new System.Drawing.Size(62, 21);
            this.checkBox_Gmail.TabIndex = 4;
            this.checkBox_Gmail.Text = "Gmail";
            this.checkBox_Gmail.UnCheckedColor = System.Drawing.Color.Gray;
            this.checkBox_Gmail.UseVisualStyleBackColor = true;
            // 
            // checkBox_SoDienThoai
            // 
            this.checkBox_SoDienThoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_SoDienThoai.AutoSize = true;
            this.checkBox_SoDienThoai.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.checkBox_SoDienThoai.ForeColor = System.Drawing.Color.Gray;
            this.checkBox_SoDienThoai.Location = new System.Drawing.Point(84, 317);
            this.checkBox_SoDienThoai.MinimumSize = new System.Drawing.Size(0, 21);
            this.checkBox_SoDienThoai.Name = "checkBox_SoDienThoai";
            this.checkBox_SoDienThoai.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkBox_SoDienThoai.Size = new System.Drawing.Size(99, 21);
            this.checkBox_SoDienThoai.TabIndex = 5;
            this.checkBox_SoDienThoai.Text = "Số điện thoại";
            this.checkBox_SoDienThoai.UnCheckedColor = System.Drawing.Color.Gray;
            this.checkBox_SoDienThoai.UseVisualStyleBackColor = true;
            // 
            // label_Loi
            // 
            this.label_Loi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Loi.AutoSize = true;
            this.label_Loi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Loi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label_Loi.Location = new System.Drawing.Point(189, 323);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(0, 15);
            this.label_Loi.TabIndex = 10;
            // 
            // form_PhanHoiBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.label_Loi);
            this.Controls.Add(this.checkBox_Gmail);
            this.Controls.Add(this.checkBox_SoDienThoai);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.button_Gui);
            this.Controls.Add(this.textbox_NoiDung);
            this.Controls.Add(this.textbox_NguoiNhan);
            this.Controls.Add(this.textbox_ChuDe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(616, 389);
            this.MinimumSize = new System.Drawing.Size(616, 389);
            this.Name = "form_PhanHoiBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phản hồi báo cáo";
            this.Load += new System.EventHandler(this.form_PhanHoiBaoCao_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Toolbox_Custom.Button_Custom button_Gui;
        private Toolbox_Custom.Textbox_Custom textbox_NoiDung;
        private Toolbox_Custom.Textbox_Custom textbox_NguoiNhan;
        private Toolbox_Custom.Textbox_Custom textbox_ChuDe;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private FontAwesome.Sharp.IconButton button_Close;
        private CheckBox_Custom checkBox_Gmail;
        private CheckBox_Custom checkBox_SoDienThoai;
        private System.Windows.Forms.Label label_Loi;
    }
}