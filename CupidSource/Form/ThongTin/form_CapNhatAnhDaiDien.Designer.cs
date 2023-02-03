namespace Cupid
{
    partial class form_CapNhatAnhDaiDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_CapNhatAnhDaiDien));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.crop_PictureBox_Custom = new Cupid.Crop_PictureBox_Custom();
            this.button_DongY = new Cupid.Toolbox_Custom.Button_Custom();
            this.button_Huy = new Cupid.Toolbox_Custom.Button_Custom();
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
            this.panel_Top.Size = new System.Drawing.Size(500, 30);
            this.panel_Top.TabIndex = 1;
            this.panel_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(34, 8);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(128, 15);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Cập nhật ảnh đại điện";
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
            this.button_Close.Location = new System.Drawing.Point(470, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.button_Close.Size = new System.Drawing.Size(30, 30);
            this.button_Close.TabIndex = 0;
            this.button_Close.TabStop = false;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // crop_PictureBox_Custom
            // 
            this.crop_PictureBox_Custom.Location = new System.Drawing.Point(42, 36);
            this.crop_PictureBox_Custom.Name = "crop_PictureBox_Custom";
            this.crop_PictureBox_Custom.Selection = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.crop_PictureBox_Custom.SelectionBorderDashPattern = null;
            this.crop_PictureBox_Custom.Size = new System.Drawing.Size(416, 416);
            this.crop_PictureBox_Custom.TabIndex = 2;
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
            this.button_DongY.Location = new System.Drawing.Point(322, 458);
            this.button_DongY.Name = "button_DongY";
            this.button_DongY.Size = new System.Drawing.Size(80, 30);
            this.button_DongY.TabIndex = 3;
            this.button_DongY.Text = "Đồng ý";
            this.button_DongY.TextColor = System.Drawing.Color.White;
            this.button_DongY.UseVisualStyleBackColor = false;
            this.button_DongY.Click += new System.EventHandler(this.button_DongY_Click);
            // 
            // button_Huy
            // 
            this.button_Huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Huy.BackColor = System.Drawing.Color.DarkGray;
            this.button_Huy.BackgroundColor = System.Drawing.Color.DarkGray;
            this.button_Huy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_Huy.BorderRadius = 5;
            this.button_Huy.BorderSize = 0;
            this.button_Huy.FlatAppearance.BorderSize = 0;
            this.button_Huy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Huy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Huy.ForeColor = System.Drawing.Color.White;
            this.button_Huy.Location = new System.Drawing.Point(408, 458);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(80, 30);
            this.button_Huy.TabIndex = 4;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.TextColor = System.Drawing.Color.White;
            this.button_Huy.UseVisualStyleBackColor = false;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // form_CapNhatAnhDaiDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.button_DongY);
            this.Controls.Add(this.button_Huy);
            this.Controls.Add(this.crop_PictureBox_Custom);
            this.Controls.Add(this.panel_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(516, 539);
            this.MinimumSize = new System.Drawing.Size(516, 539);
            this.Name = "form_CapNhatAnhDaiDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật ảnh đại điện";
            this.Load += new System.EventHandler(this.form_CapNhatAnhDaiDien_Load);
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
        private Crop_PictureBox_Custom crop_PictureBox_Custom;
        private Toolbox_Custom.Button_Custom button_DongY;
        private Toolbox_Custom.Button_Custom button_Huy;
    }
}