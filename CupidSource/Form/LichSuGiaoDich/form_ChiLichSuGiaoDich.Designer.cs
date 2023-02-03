namespace Cupid
{
    partial class form_ChiLichSuGiaoDich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ChiLichSuGiaoDich));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.label_Value_SoTienDaThue = new System.Windows.Forms.Label();
            this.label_Value_SoTienDaNap = new System.Windows.Forms.Label();
            this.label_Value_TaiKhoan = new System.Windows.Forms.Label();
            this.label_SoTienDaThue = new System.Windows.Forms.Label();
            this.label_SoTienDaNap = new System.Windows.Forms.Label();
            this.label_TaiKhoan = new System.Windows.Forms.Label();
            this.button_DongY = new Cupid.Toolbox_Custom.Button_Custom();
            this.label_Value_SoTienDuocThue = new System.Windows.Forms.Label();
            this.label_SoTienDuocThue = new System.Windows.Forms.Label();
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
            this.panel_Top.Size = new System.Drawing.Size(400, 30);
            this.panel_Top.TabIndex = 38;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(34, 8);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(142, 15);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Chi tiết lịch sử giao dịch";
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
            this.button_Close.Location = new System.Drawing.Point(370, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 0;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // label_Value_SoTienDaThue
            // 
            this.label_Value_SoTienDaThue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Value_SoTienDaThue.BackColor = System.Drawing.Color.Transparent;
            this.label_Value_SoTienDaThue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Value_SoTienDaThue.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Value_SoTienDaThue.Location = new System.Drawing.Point(150, 113);
            this.label_Value_SoTienDaThue.Name = "label_Value_SoTienDaThue";
            this.label_Value_SoTienDaThue.Size = new System.Drawing.Size(238, 23);
            this.label_Value_SoTienDaThue.TabIndex = 50;
            this.label_Value_SoTienDaThue.Text = "...";
            this.label_Value_SoTienDaThue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Value_SoTienDaNap
            // 
            this.label_Value_SoTienDaNap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Value_SoTienDaNap.BackColor = System.Drawing.Color.Transparent;
            this.label_Value_SoTienDaNap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Value_SoTienDaNap.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Value_SoTienDaNap.Location = new System.Drawing.Point(147, 79);
            this.label_Value_SoTienDaNap.Name = "label_Value_SoTienDaNap";
            this.label_Value_SoTienDaNap.Size = new System.Drawing.Size(241, 23);
            this.label_Value_SoTienDaNap.TabIndex = 49;
            this.label_Value_SoTienDaNap.Text = "...";
            this.label_Value_SoTienDaNap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Value_TaiKhoan
            // 
            this.label_Value_TaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Value_TaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.label_Value_TaiKhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Value_TaiKhoan.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Value_TaiKhoan.Location = new System.Drawing.Point(112, 45);
            this.label_Value_TaiKhoan.Name = "label_Value_TaiKhoan";
            this.label_Value_TaiKhoan.Size = new System.Drawing.Size(276, 23);
            this.label_Value_TaiKhoan.TabIndex = 48;
            this.label_Value_TaiKhoan.Text = "...";
            this.label_Value_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_SoTienDaThue
            // 
            this.label_SoTienDaThue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_SoTienDaThue.BackColor = System.Drawing.Color.Transparent;
            this.label_SoTienDaThue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoTienDaThue.ForeColor = System.Drawing.Color.DarkGray;
            this.label_SoTienDaThue.Location = new System.Drawing.Point(24, 113);
            this.label_SoTienDaThue.Name = "label_SoTienDaThue";
            this.label_SoTienDaThue.Size = new System.Drawing.Size(135, 23);
            this.label_SoTienDaThue.TabIndex = 47;
            this.label_SoTienDaThue.Text = "Số tiền đã thuê:";
            this.label_SoTienDaThue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_SoTienDaNap
            // 
            this.label_SoTienDaNap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_SoTienDaNap.BackColor = System.Drawing.Color.Transparent;
            this.label_SoTienDaNap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoTienDaNap.ForeColor = System.Drawing.Color.DarkGray;
            this.label_SoTienDaNap.Location = new System.Drawing.Point(24, 79);
            this.label_SoTienDaNap.Name = "label_SoTienDaNap";
            this.label_SoTienDaNap.Size = new System.Drawing.Size(130, 23);
            this.label_SoTienDaNap.TabIndex = 46;
            this.label_SoTienDaNap.Text = "Số tiền đã nạp:";
            this.label_SoTienDaNap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label_TaiKhoan.TabIndex = 45;
            this.label_TaiKhoan.Text = "Tài khoản:";
            this.label_TaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.button_DongY.Location = new System.Drawing.Point(308, 178);
            this.button_DongY.Name = "button_DongY";
            this.button_DongY.Size = new System.Drawing.Size(80, 30);
            this.button_DongY.TabIndex = 51;
            this.button_DongY.Text = "Đồng ý";
            this.button_DongY.TextColor = System.Drawing.Color.White;
            this.button_DongY.UseVisualStyleBackColor = false;
            this.button_DongY.Click += new System.EventHandler(this.button_DongY_Click);
            // 
            // label_Value_SoTienDuocThue
            // 
            this.label_Value_SoTienDuocThue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Value_SoTienDuocThue.BackColor = System.Drawing.Color.Transparent;
            this.label_Value_SoTienDuocThue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Value_SoTienDuocThue.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Value_SoTienDuocThue.Location = new System.Drawing.Point(173, 147);
            this.label_Value_SoTienDuocThue.Name = "label_Value_SoTienDuocThue";
            this.label_Value_SoTienDuocThue.Size = new System.Drawing.Size(215, 23);
            this.label_Value_SoTienDuocThue.TabIndex = 53;
            this.label_Value_SoTienDuocThue.Text = "...";
            this.label_Value_SoTienDuocThue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_SoTienDuocThue
            // 
            this.label_SoTienDuocThue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_SoTienDuocThue.BackColor = System.Drawing.Color.Transparent;
            this.label_SoTienDuocThue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoTienDuocThue.ForeColor = System.Drawing.Color.DarkGray;
            this.label_SoTienDuocThue.Location = new System.Drawing.Point(24, 147);
            this.label_SoTienDuocThue.Name = "label_SoTienDuocThue";
            this.label_SoTienDuocThue.Size = new System.Drawing.Size(155, 23);
            this.label_SoTienDuocThue.TabIndex = 52;
            this.label_SoTienDuocThue.Text = "Số tiền được thuê:";
            this.label_SoTienDuocThue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // form_ChiLichSuGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.label_Value_SoTienDuocThue);
            this.Controls.Add(this.label_SoTienDuocThue);
            this.Controls.Add(this.button_DongY);
            this.Controls.Add(this.label_Value_SoTienDaThue);
            this.Controls.Add(this.label_Value_SoTienDaNap);
            this.Controls.Add(this.label_Value_TaiKhoan);
            this.Controls.Add(this.label_SoTienDaThue);
            this.Controls.Add(this.label_SoTienDaNap);
            this.Controls.Add(this.label_TaiKhoan);
            this.Controls.Add(this.panel_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(416, 259);
            this.MinimumSize = new System.Drawing.Size(416, 259);
            this.Name = "form_ChiLichSuGiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết lịch sử giao dịch";
            this.Load += new System.EventHandler(this.form_ChiLichSuGiaoDich_Load);
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
        private System.Windows.Forms.Label label_Value_SoTienDaThue;
        private System.Windows.Forms.Label label_Value_SoTienDaNap;
        private System.Windows.Forms.Label label_Value_TaiKhoan;
        private System.Windows.Forms.Label label_SoTienDaThue;
        private System.Windows.Forms.Label label_SoTienDaNap;
        private System.Windows.Forms.Label label_TaiKhoan;
        private Toolbox_Custom.Button_Custom button_DongY;
        private System.Windows.Forms.Label label_Value_SoTienDuocThue;
        private System.Windows.Forms.Label label_SoTienDuocThue;
    }
}