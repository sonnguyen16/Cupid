namespace Cupid
{
    partial class form_NapTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_NapTien));
            this.label_Loi = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.switch_Check = new Cupid.Switch_Custom();
            this.button_Nap = new Cupid.Toolbox_Custom.Button_Custom();
            this.textbox_SoTienNap = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.textbox_TaiKhoan = new Cupid.Toolbox_Custom.Textbox_Custom();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Loi
            // 
            this.label_Loi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Loi.AutoSize = true;
            this.label_Loi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Loi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label_Loi.Location = new System.Drawing.Point(12, 146);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(0, 15);
            this.label_Loi.TabIndex = 34;
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(34, 8);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(53, 15);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Nạp tiền";
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
            this.panel_Top.TabIndex = 25;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // switch_Check
            // 
            this.switch_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.switch_Check.BackColor = System.Drawing.Color.White;
            this.switch_Check.BorderColor = System.Drawing.Color.Transparent;
            this.switch_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switch_Check.ForeColor = System.Drawing.Color.White;
            this.switch_Check.IsOn = false;
            this.switch_Check.Location = new System.Drawing.Point(196, 138);
            this.switch_Check.Name = "switch_Check";
            this.switch_Check.OffColor = System.Drawing.Color.DarkGray;
            this.switch_Check.OffText = "";
            this.switch_Check.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.switch_Check.OnText = "";
            this.switch_Check.Size = new System.Drawing.Size(56, 30);
            this.switch_Check.TabIndex = 3;
            this.switch_Check.Text = "switch_Check";
            this.switch_Check.TextEnabled = true;
            this.switch_Check.Click += new System.EventHandler(this.switch_Check_Click);
            this.switch_Check.DoubleClick += new System.EventHandler(this.switch_Check_DoubleClick);
            // 
            // button_Nap
            // 
            this.button_Nap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Nap.BackColor = System.Drawing.Color.DarkGray;
            this.button_Nap.BackgroundColor = System.Drawing.Color.DarkGray;
            this.button_Nap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_Nap.BorderRadius = 5;
            this.button_Nap.BorderSize = 0;
            this.button_Nap.FlatAppearance.BorderSize = 0;
            this.button_Nap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Nap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Nap.ForeColor = System.Drawing.Color.White;
            this.button_Nap.Location = new System.Drawing.Point(258, 138);
            this.button_Nap.Name = "button_Nap";
            this.button_Nap.Size = new System.Drawing.Size(80, 30);
            this.button_Nap.TabIndex = 0;
            this.button_Nap.Text = "Nạp";
            this.button_Nap.TextColor = System.Drawing.Color.White;
            this.button_Nap.UseVisualStyleBackColor = false;
            this.button_Nap.Click += new System.EventHandler(this.button_Nap_Click);
            // 
            // textbox_SoTienNap
            // 
            this.textbox_SoTienNap.BackColor = System.Drawing.Color.White;
            this.textbox_SoTienNap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_SoTienNap.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_SoTienNap.BorderRadius = 0;
            this.textbox_SoTienNap.BorderSize = 4;
            this.textbox_SoTienNap.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_SoTienNap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_SoTienNap.IsPlaceHolder = true;
            this.textbox_SoTienNap.Location = new System.Drawing.Point(11, 81);
            this.textbox_SoTienNap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbox_SoTienNap.Multiline = true;
            this.textbox_SoTienNap.Name = "textbox_SoTienNap";
            this.textbox_SoTienNap.Padding = new System.Windows.Forms.Padding(9, 9, 9, 7);
            this.textbox_SoTienNap.PasswordChar = false;
            this.textbox_SoTienNap.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_SoTienNap.PlaceholderText = "Số tiền nạp";
            this.textbox_SoTienNap.Size = new System.Drawing.Size(328, 35);
            this.textbox_SoTienNap.TabIndex = 2;
            this.textbox_SoTienNap.Texts = "";
            this.textbox_SoTienNap.UnderlinedStyle = true;
            // 
            // textbox_TaiKhoan
            // 
            this.textbox_TaiKhoan.BackColor = System.Drawing.Color.White;
            this.textbox_TaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_TaiKhoan.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_TaiKhoan.BorderRadius = 0;
            this.textbox_TaiKhoan.BorderSize = 4;
            this.textbox_TaiKhoan.Enabled = false;
            this.textbox_TaiKhoan.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textbox_TaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_TaiKhoan.IsPlaceHolder = true;
            this.textbox_TaiKhoan.Location = new System.Drawing.Point(11, 42);
            this.textbox_TaiKhoan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textbox_TaiKhoan.Multiline = false;
            this.textbox_TaiKhoan.Name = "textbox_TaiKhoan";
            this.textbox_TaiKhoan.Padding = new System.Windows.Forms.Padding(9, 9, 9, 7);
            this.textbox_TaiKhoan.PasswordChar = false;
            this.textbox_TaiKhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_TaiKhoan.PlaceholderText = "Tài khoản";
            this.textbox_TaiKhoan.Size = new System.Drawing.Size(328, 33);
            this.textbox_TaiKhoan.TabIndex = 1;
            this.textbox_TaiKhoan.Texts = "";
            this.textbox_TaiKhoan.UnderlinedStyle = true;
            // 
            // form_NapTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 180);
            this.Controls.Add(this.switch_Check);
            this.Controls.Add(this.label_Loi);
            this.Controls.Add(this.button_Nap);
            this.Controls.Add(this.textbox_SoTienNap);
            this.Controls.Add(this.textbox_TaiKhoan);
            this.Controls.Add(this.panel_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(366, 219);
            this.MinimumSize = new System.Drawing.Size(366, 219);
            this.Name = "form_NapTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nạp tiền";
            this.Load += new System.EventHandler(this.form_NapTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Loi;
        private Toolbox_Custom.Button_Custom button_Nap;
        private Toolbox_Custom.Textbox_Custom textbox_SoTienNap;
        private Toolbox_Custom.Textbox_Custom textbox_TaiKhoan;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private FontAwesome.Sharp.IconButton button_Close;
        private System.Windows.Forms.Panel panel_Top;
        private Switch_Custom switch_Check;
    }
}