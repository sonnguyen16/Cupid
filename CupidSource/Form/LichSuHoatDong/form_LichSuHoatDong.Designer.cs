namespace Cupid
{
    partial class form_LichSuHoatDong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_LichSuHoatDong));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_DenNgay = new System.Windows.Forms.Label();
            this.dateTimePicker_NgayKetThuc = new Cupid.DateTimePicker_Custom();
            this.label_TuNgay = new System.Windows.Forms.Label();
            this.dateTimePicker_NgayBatDau = new Cupid.DateTimePicker_Custom();
            this.label_Loi = new System.Windows.Forms.Label();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.combobox_TimKiemTheo = new Cupid.Combobox_Custom();
            this.textbox_TimKiem = new Cupid.Toolbox_Custom.Textbox_Custom();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.clTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThaoTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChitiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Top.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel_Top.Controls.Add(this.label_DenNgay);
            this.panel_Top.Controls.Add(this.dateTimePicker_NgayKetThuc);
            this.panel_Top.Controls.Add(this.label_TuNgay);
            this.panel_Top.Controls.Add(this.dateTimePicker_NgayBatDau);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(850, 50);
            this.panel_Top.TabIndex = 2;
            // 
            // label_DenNgay
            // 
            this.label_DenNgay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_DenNgay.ForeColor = System.Drawing.Color.DarkGray;
            this.label_DenNgay.Location = new System.Drawing.Point(245, 16);
            this.label_DenNgay.Name = "label_DenNgay";
            this.label_DenNgay.Size = new System.Drawing.Size(100, 19);
            this.label_DenNgay.TabIndex = 0;
            this.label_DenNgay.Text = "đến ngày:";
            this.label_DenNgay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_NgayKetThuc
            // 
            this.dateTimePicker_NgayKetThuc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.dateTimePicker_NgayKetThuc.BorderSize = 3;
            this.dateTimePicker_NgayKetThuc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateTimePicker_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayKetThuc.Location = new System.Drawing.Point(351, 8);
            this.dateTimePicker_NgayKetThuc.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePicker_NgayKetThuc.Name = "dateTimePicker_NgayKetThuc";
            this.dateTimePicker_NgayKetThuc.Size = new System.Drawing.Size(140, 35);
            this.dateTimePicker_NgayKetThuc.SkinColor = System.Drawing.Color.White;
            this.dateTimePicker_NgayKetThuc.TabIndex = 2;
            this.dateTimePicker_NgayKetThuc.TextColor = System.Drawing.Color.DarkGray;
            this.dateTimePicker_NgayKetThuc.ValueChanged += new System.EventHandler(this.dateTimePicker_NgayKetThuc_ValueChanged);
            // 
            // label_TuNgay
            // 
            this.label_TuNgay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_TuNgay.ForeColor = System.Drawing.Color.DarkGray;
            this.label_TuNgay.Location = new System.Drawing.Point(12, 16);
            this.label_TuNgay.Name = "label_TuNgay";
            this.label_TuNgay.Size = new System.Drawing.Size(80, 19);
            this.label_TuNgay.TabIndex = 0;
            this.label_TuNgay.Text = "Từ ngày:";
            this.label_TuNgay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker_NgayBatDau
            // 
            this.dateTimePicker_NgayBatDau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.dateTimePicker_NgayBatDau.BorderSize = 3;
            this.dateTimePicker_NgayBatDau.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateTimePicker_NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayBatDau.Location = new System.Drawing.Point(98, 8);
            this.dateTimePicker_NgayBatDau.MinimumSize = new System.Drawing.Size(4, 35);
            this.dateTimePicker_NgayBatDau.Name = "dateTimePicker_NgayBatDau";
            this.dateTimePicker_NgayBatDau.Size = new System.Drawing.Size(140, 35);
            this.dateTimePicker_NgayBatDau.SkinColor = System.Drawing.Color.White;
            this.dateTimePicker_NgayBatDau.TabIndex = 1;
            this.dateTimePicker_NgayBatDau.TextColor = System.Drawing.Color.DarkGray;
            this.dateTimePicker_NgayBatDau.ValueChanged += new System.EventHandler(this.dateTimePicker_NgayBatDau_ValueChanged);
            // 
            // label_Loi
            // 
            this.label_Loi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Loi.AutoSize = true;
            this.label_Loi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Loi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label_Loi.Location = new System.Drawing.Point(434, 18);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(0, 15);
            this.label_Loi.TabIndex = 3;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel_Bottom.Controls.Add(this.combobox_TimKiemTheo);
            this.panel_Bottom.Controls.Add(this.label_Loi);
            this.panel_Bottom.Controls.Add(this.textbox_TimKiem);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 550);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(850, 50);
            this.panel_Bottom.TabIndex = 4;
            // 
            // combobox_TimKiemTheo
            // 
            this.combobox_TimKiemTheo.BackColor = System.Drawing.Color.White;
            this.combobox_TimKiemTheo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.combobox_TimKiemTheo.BorderSize = 2;
            this.combobox_TimKiemTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combobox_TimKiemTheo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.combobox_TimKiemTheo.ForeColor = System.Drawing.Color.DarkGray;
            this.combobox_TimKiemTheo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.combobox_TimKiemTheo.Items.AddRange(new object[] {
            "Tạo tài khoản",
            "Sửa tài khoản",
            "Xóa tài khoản",
            "Nạp tiền",
            "Duyệt đơn Idol",
            "Khóa tài khoản"});
            this.combobox_TimKiemTheo.ListBackColor = System.Drawing.Color.White;
            this.combobox_TimKiemTheo.ListTextColor = System.Drawing.Color.Black;
            this.combobox_TimKiemTheo.Location = new System.Drawing.Point(267, 9);
            this.combobox_TimKiemTheo.MinimumSize = new System.Drawing.Size(124, 30);
            this.combobox_TimKiemTheo.Name = "combobox_TimKiemTheo";
            this.combobox_TimKiemTheo.Padding = new System.Windows.Forms.Padding(2);
            this.combobox_TimKiemTheo.Size = new System.Drawing.Size(161, 30);
            this.combobox_TimKiemTheo.TabIndex = 2;
            this.combobox_TimKiemTheo.Texts = "Tìm kiếm theo";
            this.combobox_TimKiemTheo.OnSelectedIndexChanged += new System.EventHandler(this.combobox_TimKiemTheo_OnSelectedIndexChanged);
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
            this.clTaiKhoan,
            this.clThaoTac,
            this.clChitiet,
            this.clNgay});
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
            this.dataGridView.TabIndex = 3;
            this.dataGridView.TabStop = false;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_DataBindingComplete);
            // 
            // clTaiKhoan
            // 
            this.clTaiKhoan.DataPropertyName = "TAI_KHOAN";
            this.clTaiKhoan.HeaderText = "Tài khoản";
            this.clTaiKhoan.Name = "clTaiKhoan";
            this.clTaiKhoan.ReadOnly = true;
            // 
            // clThaoTac
            // 
            this.clThaoTac.DataPropertyName = "THAO_TAC";
            this.clThaoTac.HeaderText = "Thao tác";
            this.clThaoTac.Name = "clThaoTac";
            this.clThaoTac.ReadOnly = true;
            // 
            // clChitiet
            // 
            this.clChitiet.DataPropertyName = "CHI_TIET";
            this.clChitiet.HeaderText = "Chi tiết";
            this.clChitiet.Name = "clChitiet";
            this.clChitiet.ReadOnly = true;
            // 
            // clNgay
            // 
            this.clNgay.DataPropertyName = "NGAY_THAO_TAC";
            this.clNgay.HeaderText = "Ngày thao tác";
            this.clNgay.Name = "clNgay";
            this.clNgay.ReadOnly = true;
            // 
            // form_LichSuHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_LichSuHoatDong";
            this.Text = "Lịch sử hoạt động";
            this.Load += new System.EventHandler(this.form_LichSuHoatDong_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_DenNgay;
        private DateTimePicker_Custom dateTimePicker_NgayKetThuc;
        private System.Windows.Forms.Label label_TuNgay;
        private DateTimePicker_Custom dateTimePicker_NgayBatDau;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Label label_Loi;
        private Toolbox_Custom.Textbox_Custom textbox_TimKiem;
        private System.Windows.Forms.DataGridView dataGridView;
        private Combobox_Custom combobox_TimKiemTheo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThaoTac;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChitiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgay;
    }
}