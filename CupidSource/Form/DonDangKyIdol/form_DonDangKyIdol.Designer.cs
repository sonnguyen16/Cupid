
namespace Cupid
{
    partial class form_DonDangKyIdol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_DonDangKyIdol));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.button_DaXem = new Cupid.Toolbox_Custom.Button_Custom();
            this.button_ChuaXem = new Cupid.Toolbox_Custom.Button_Custom();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.textbox_TimKiem = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.button_Xoa = new Cupid.Toolbox_Custom.Button_Custom();
            this.button_PhanHoi = new Cupid.Toolbox_Custom.Button_Custom();
            this.button_Xem = new Cupid.Toolbox_Custom.Button_Custom();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.clMadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaygui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrangthai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel_Top.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel_Top.Controls.Add(this.button_DaXem);
            this.panel_Top.Controls.Add(this.button_ChuaXem);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(850, 50);
            this.panel_Top.TabIndex = 1;
            // 
            // button_DaXem
            // 
            this.button_DaXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.button_DaXem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.button_DaXem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_DaXem.BorderRadius = 0;
            this.button_DaXem.BorderSize = 0;
            this.button_DaXem.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_DaXem.FlatAppearance.BorderSize = 0;
            this.button_DaXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DaXem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button_DaXem.ForeColor = System.Drawing.Color.DarkGray;
            this.button_DaXem.Location = new System.Drawing.Point(120, 0);
            this.button_DaXem.Name = "button_DaXem";
            this.button_DaXem.Size = new System.Drawing.Size(120, 50);
            this.button_DaXem.TabIndex = 2;
            this.button_DaXem.Text = "Đã xem";
            this.button_DaXem.TextColor = System.Drawing.Color.DarkGray;
            this.button_DaXem.UseVisualStyleBackColor = false;
            this.button_DaXem.Click += new System.EventHandler(this.button_DaXem_Click);
            // 
            // button_ChuaXem
            // 
            this.button_ChuaXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.button_ChuaXem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.button_ChuaXem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_ChuaXem.BorderRadius = 0;
            this.button_ChuaXem.BorderSize = 0;
            this.button_ChuaXem.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_ChuaXem.FlatAppearance.BorderSize = 0;
            this.button_ChuaXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ChuaXem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.button_ChuaXem.ForeColor = System.Drawing.Color.DarkGray;
            this.button_ChuaXem.Location = new System.Drawing.Point(0, 0);
            this.button_ChuaXem.Name = "button_ChuaXem";
            this.button_ChuaXem.Size = new System.Drawing.Size(120, 50);
            this.button_ChuaXem.TabIndex = 1;
            this.button_ChuaXem.Text = "Chưa xem";
            this.button_ChuaXem.TextColor = System.Drawing.Color.DarkGray;
            this.button_ChuaXem.UseVisualStyleBackColor = false;
            this.button_ChuaXem.Click += new System.EventHandler(this.button_ChuaXem_Click);
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel_Bottom.Controls.Add(this.textbox_TimKiem);
            this.panel_Bottom.Controls.Add(this.button_Xoa);
            this.panel_Bottom.Controls.Add(this.button_PhanHoi);
            this.panel_Bottom.Controls.Add(this.button_Xem);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 550);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(850, 50);
            this.panel_Bottom.TabIndex = 3;
            // 
            // textbox_TimKiem
            // 
            this.textbox_TimKiem.BackColor = System.Drawing.Color.White;
            this.textbox_TimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.textbox_TimKiem.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.textbox_TimKiem.BorderRadius = 5;
            this.textbox_TimKiem.BorderSize = 2;
            this.textbox_TimKiem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_TimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(21)))));
            this.textbox_TimKiem.IsPlaceHolder = true;
            this.textbox_TimKiem.Location = new System.Drawing.Point(10, 9);
            this.textbox_TimKiem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_TimKiem.Multiline = false;
            this.textbox_TimKiem.Name = "textbox_TimKiem";
            this.textbox_TimKiem.Padding = new System.Windows.Forms.Padding(12, 8, 12, 6);
            this.textbox_TimKiem.PasswordChar = false;
            this.textbox_TimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textbox_TimKiem.PlaceholderText = "Tìm kiếm...";
            this.textbox_TimKiem.Size = new System.Drawing.Size(250, 30);
            this.textbox_TimKiem.TabIndex = 1;
            this.textbox_TimKiem.Texts = "";
            this.textbox_TimKiem.UnderlinedStyle = false;
            this.textbox_TimKiem._TextChanged += new System.EventHandler(this.textbox_TimKiem__TextChanged);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Xoa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Xoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_Xoa.BorderRadius = 5;
            this.button_Xoa.BorderSize = 0;
            this.button_Xoa.FlatAppearance.BorderSize = 0;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Xoa.ForeColor = System.Drawing.Color.White;
            this.button_Xoa.Location = new System.Drawing.Point(586, 9);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(80, 30);
            this.button_Xoa.TabIndex = 2;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.TextColor = System.Drawing.Color.White;
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
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
            this.button_PhanHoi.Location = new System.Drawing.Point(672, 9);
            this.button_PhanHoi.Name = "button_PhanHoi";
            this.button_PhanHoi.Size = new System.Drawing.Size(80, 30);
            this.button_PhanHoi.TabIndex = 3;
            this.button_PhanHoi.Text = "Phản hồi";
            this.button_PhanHoi.TextColor = System.Drawing.Color.White;
            this.button_PhanHoi.UseVisualStyleBackColor = false;
            this.button_PhanHoi.Click += new System.EventHandler(this.button_PhanHoi_Click);
            // 
            // button_Xem
            // 
            this.button_Xem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Xem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Xem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_Xem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.button_Xem.BorderRadius = 5;
            this.button_Xem.BorderSize = 0;
            this.button_Xem.FlatAppearance.BorderSize = 0;
            this.button_Xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_Xem.ForeColor = System.Drawing.Color.White;
            this.button_Xem.Location = new System.Drawing.Point(758, 9);
            this.button_Xem.Name = "button_Xem";
            this.button_Xem.Size = new System.Drawing.Size(80, 30);
            this.button_Xem.TabIndex = 4;
            this.button_Xem.Text = "Xem";
            this.button_Xem.TextColor = System.Drawing.Color.White;
            this.button_Xem.UseVisualStyleBackColor = false;
            this.button_Xem.Click += new System.EventHandler(this.button_Xem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 36;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMadon,
            this.clTaikhoan,
            this.clChude,
            this.clNoidung,
            this.clNgaygui,
            this.clTrangthai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(208)))), ((int)(((byte)(212)))));
            this.dataGridView.Location = new System.Drawing.Point(0, 50);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 40;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(850, 500);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
            // 
            // clMadon
            // 
            this.clMadon.DataPropertyName = "MA_DON";
            this.clMadon.HeaderText = "Mã đơn";
            this.clMadon.Name = "clMadon";
            this.clMadon.ReadOnly = true;
            this.clMadon.Visible = false;
            // 
            // clTaikhoan
            // 
            this.clTaikhoan.DataPropertyName = "TAI_KHOAN";
            this.clTaikhoan.HeaderText = "Tài khoản";
            this.clTaikhoan.Name = "clTaikhoan";
            this.clTaikhoan.ReadOnly = true;
            // 
            // clChude
            // 
            this.clChude.DataPropertyName = "CHU_DE";
            this.clChude.HeaderText = "Chủ đề";
            this.clChude.Name = "clChude";
            this.clChude.ReadOnly = true;
            // 
            // clNoidung
            // 
            this.clNoidung.DataPropertyName = "NOI_DUNG";
            this.clNoidung.HeaderText = "Nội dung";
            this.clNoidung.Name = "clNoidung";
            this.clNoidung.ReadOnly = true;
            // 
            // clNgaygui
            // 
            this.clNgaygui.DataPropertyName = "NGAY_GUI";
            this.clNgaygui.HeaderText = "Ngày gửi";
            this.clNgaygui.Name = "clNgaygui";
            this.clNgaygui.ReadOnly = true;
            // 
            // clTrangthai
            // 
            this.clTrangthai.DataPropertyName = "TRANG_THAI";
            this.clTrangthai.HeaderText = "Trạng thái";
            this.clTrangthai.Name = "clTrangthai";
            this.clTrangthai.ReadOnly = true;
            this.clTrangthai.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // form_DonDangKyIdol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_DonDangKyIdol";
            this.Text = "Đơn đăng ký Idol";
            this.Load += new System.EventHandler(this.form_DonDangKyIdol_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Bottom;
        private Toolbox_Custom.Textbox_Custom textbox_TimKiem;
        private Toolbox_Custom.Button_Custom button_Xoa;
        private Toolbox_Custom.Button_Custom button_PhanHoi;
        private Toolbox_Custom.Button_Custom button_Xem;
        public Toolbox_Custom.Button_Custom button_DaXem;
        public Toolbox_Custom.Button_Custom button_ChuaXem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChude;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaygui;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clTrangthai;
        public System.Windows.Forms.DataGridView dataGridView;
    }
}