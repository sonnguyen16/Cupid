
namespace Cupid
{
    partial class form_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_DangNhap));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.label_Loi = new System.Windows.Forms.Label();
            this.pictureBox_HienMatKhau = new FontAwesome.Sharp.IconPictureBox();
            this.textbox_MatKhau = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.textbox_TaiKhoan = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.button_DangNhap = new Cupid.Toolbox_Custom.Button_Custom();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Error = new System.Windows.Forms.PictureBox();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HienMatKhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Error)).BeginInit();
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
            this.panel_Top.Size = new System.Drawing.Size(740, 30);
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
            this.label_Title.Size = new System.Drawing.Size(68, 15);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Đăng nhập";
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
            this.button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.button_Close.IconColor = System.Drawing.Color.White;
            this.button_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_Close.IconSize = 30;
            this.button_Close.Location = new System.Drawing.Point(710, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 0;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_Loi
            // 
            this.label_Loi.BackColor = System.Drawing.Color.Transparent;
            this.label_Loi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Loi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label_Loi.Location = new System.Drawing.Point(425, 385);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(295, 20);
            this.label_Loi.TabIndex = 0;
            this.label_Loi.Text = "Lỗi...";
            this.label_Loi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_HienMatKhau
            // 
            this.pictureBox_HienMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_HienMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.pictureBox_HienMatKhau.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.pictureBox_HienMatKhau.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.pictureBox_HienMatKhau.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureBox_HienMatKhau.IconSize = 34;
            this.pictureBox_HienMatKhau.Location = new System.Drawing.Point(686, 330);
            this.pictureBox_HienMatKhau.Name = "pictureBox_HienMatKhau";
            this.pictureBox_HienMatKhau.Size = new System.Drawing.Size(34, 34);
            this.pictureBox_HienMatKhau.TabIndex = 33;
            this.pictureBox_HienMatKhau.TabStop = false;
            this.pictureBox_HienMatKhau.UseGdi = true;
            this.pictureBox_HienMatKhau.Click += new System.EventHandler(this.pictureBox_HienMatKhau_Click);
            this.pictureBox_HienMatKhau.DoubleClick += new System.EventHandler(this.pictureBox_HienMatKhau_DoubleClick);
            // 
            // textbox_MatKhau
            // 
            this.textbox_MatKhau.BackColor = System.Drawing.Color.White;
            this.textbox_MatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_MatKhau.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_MatKhau.BorderRadius = 0;
            this.textbox_MatKhau.BorderSize = 4;
            this.textbox_MatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_MatKhau.IsPlaceHolder = true;
            this.textbox_MatKhau.Location = new System.Drawing.Point(425, 330);
            this.textbox_MatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_MatKhau.Multiline = false;
            this.textbox_MatKhau.Name = "textbox_MatKhau";
            this.textbox_MatKhau.Padding = new System.Windows.Forms.Padding(12, 10, 12, 8);
            this.textbox_MatKhau.PasswordChar = true;
            this.textbox_MatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_MatKhau.PlaceholderText = "Mật khẩu";
            this.textbox_MatKhau.Size = new System.Drawing.Size(295, 37);
            this.textbox_MatKhau.TabIndex = 2;
            this.textbox_MatKhau.Texts = "";
            this.textbox_MatKhau.UnderlinedStyle = true;
            // 
            // textbox_TaiKhoan
            // 
            this.textbox_TaiKhoan.BackColor = System.Drawing.Color.White;
            this.textbox_TaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_TaiKhoan.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_TaiKhoan.BorderRadius = 0;
            this.textbox_TaiKhoan.BorderSize = 4;
            this.textbox_TaiKhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_TaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_TaiKhoan.IsPlaceHolder = true;
            this.textbox_TaiKhoan.Location = new System.Drawing.Point(425, 285);
            this.textbox_TaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_TaiKhoan.Multiline = false;
            this.textbox_TaiKhoan.Name = "textbox_TaiKhoan";
            this.textbox_TaiKhoan.Padding = new System.Windows.Forms.Padding(12, 10, 12, 8);
            this.textbox_TaiKhoan.PasswordChar = false;
            this.textbox_TaiKhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_TaiKhoan.PlaceholderText = "Tài khoản";
            this.textbox_TaiKhoan.Size = new System.Drawing.Size(295, 37);
            this.textbox_TaiKhoan.TabIndex = 1;
            this.textbox_TaiKhoan.Texts = "";
            this.textbox_TaiKhoan.UnderlinedStyle = true;
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_DangNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_DangNhap.BorderColor = System.Drawing.Color.White;
            this.button_DangNhap.BorderRadius = 5;
            this.button_DangNhap.BorderSize = 0;
            this.button_DangNhap.FlatAppearance.BorderSize = 0;
            this.button_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DangNhap.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_DangNhap.ForeColor = System.Drawing.Color.White;
            this.button_DangNhap.Location = new System.Drawing.Point(425, 425);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Size = new System.Drawing.Size(295, 50);
            this.button_DangNhap.TabIndex = 0;
            this.button_DangNhap.Text = "Đăng nhập";
            this.button_DangNhap.TextColor = System.Drawing.Color.White;
            this.button_DangNhap.UseVisualStyleBackColor = false;
            this.button_DangNhap.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.pictureBox_Image.Location = new System.Drawing.Point(0, 220);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(350, 350);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Image.TabIndex = 34;
            this.pictureBox_Image.TabStop = false;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.BackColor = System.Drawing.Color.White;
            this.label_Login.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Login.Location = new System.Drawing.Point(420, 180);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(180, 37);
            this.label_Login.TabIndex = 35;
            this.label_Login.Text = "Đăng nhập";
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.BackColor = System.Drawing.Color.White;
            this.label_Welcome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Welcome.Location = new System.Drawing.Point(425, 229);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(275, 16);
            this.label_Welcome.TabIndex = 36;
            this.label_Welcome.Text = "Chào mừng bạn đã quay trở lại với Cupid!";
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox_Error
            // 
            this.pictureBox_Error.BackColor = System.Drawing.Color.White;
            this.pictureBox_Error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_Error.Image = global::Cupid.Properties.Resources.BG_Error;
            this.pictureBox_Error.Location = new System.Drawing.Point(0, 30);
            this.pictureBox_Error.Name = "pictureBox_Error";
            this.pictureBox_Error.Size = new System.Drawing.Size(740, 516);
            this.pictureBox_Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Error.TabIndex = 37;
            this.pictureBox_Error.TabStop = false;
            // 
            // form_DangNhap
            // 
            this.AcceptButton = this.button_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.BackgroundImage = global::Cupid.Properties.Resources.BG_Login;
            this.ClientSize = new System.Drawing.Size(740, 546);
            this.Controls.Add(this.pictureBox_Error);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.pictureBox_Image);
            this.Controls.Add(this.pictureBox_HienMatKhau);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.textbox_MatKhau);
            this.Controls.Add(this.textbox_TaiKhoan);
            this.Controls.Add(this.button_DangNhap);
            this.Controls.Add(this.label_Loi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(756, 585);
            this.MinimumSize = new System.Drawing.Size(756, 585);
            this.Name = "form_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.form_DangNhap_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HienMatKhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private FontAwesome.Sharp.IconButton button_Close;
        private Toolbox_Custom.Textbox_Custom textbox_MatKhau;
        private Toolbox_Custom.Textbox_Custom textbox_TaiKhoan;
        private Toolbox_Custom.Button_Custom button_DangNhap;
        private System.Windows.Forms.Label label_Loi;
        private FontAwesome.Sharp.IconPictureBox pictureBox_HienMatKhau;
        private System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox_Error;
    }
}

