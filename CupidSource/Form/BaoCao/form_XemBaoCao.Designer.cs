
namespace Cupid
{
    partial class form_XemBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_XemBaoCao));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.button_PhanHoi = new Cupid.Toolbox_Custom.Button_Custom();
            this.textbox_NoiDung = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.textbox_NguoiGui = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.textbox_ChuDe = new Cupid.Toolbox_Custom.Textbox_Custom();
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
            this.panel_Top.Size = new System.Drawing.Size(600, 30);
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
            this.label_Title.Size = new System.Drawing.Size(81, 15);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Xem báo cáo";
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
            // button_PhanHoi
            // 
            this.button_PhanHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_PhanHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_PhanHoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_PhanHoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_PhanHoi.BorderRadius = 5;
            this.button_PhanHoi.BorderSize = 0;
            this.button_PhanHoi.FlatAppearance.BorderSize = 0;
            this.button_PhanHoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PhanHoi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_PhanHoi.ForeColor = System.Drawing.Color.White;
            this.button_PhanHoi.Location = new System.Drawing.Point(508, 310);
            this.button_PhanHoi.Name = "button_PhanHoi";
            this.button_PhanHoi.Size = new System.Drawing.Size(80, 30);
            this.button_PhanHoi.TabIndex = 0;
            this.button_PhanHoi.Text = "Phản hồi";
            this.button_PhanHoi.TextColor = System.Drawing.Color.White;
            this.button_PhanHoi.UseVisualStyleBackColor = false;
            this.button_PhanHoi.Click += new System.EventHandler(this.button_PhanHoi_Click);
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
            // form_XemBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.button_PhanHoi);
            this.Controls.Add(this.textbox_NoiDung);
            this.Controls.Add(this.textbox_NguoiGui);
            this.Controls.Add(this.textbox_ChuDe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(616, 389);
            this.MinimumSize = new System.Drawing.Size(616, 389);
            this.Name = "form_XemBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xem báo cáo";
            this.Load += new System.EventHandler(this.form_XemBaoCao_Load);
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
        private Toolbox_Custom.Button_Custom button_PhanHoi;
        private Toolbox_Custom.Textbox_Custom textbox_NoiDung;
        private Toolbox_Custom.Textbox_Custom textbox_NguoiGui;
        private Toolbox_Custom.Textbox_Custom textbox_ChuDe;
    }
}