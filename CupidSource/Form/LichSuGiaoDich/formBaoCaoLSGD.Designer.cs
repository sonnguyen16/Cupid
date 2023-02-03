namespace Cupid
{
    partial class formBaoCaoLSGD
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBaoCaoLSGD));
            this.BaoCaoLSGDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CUPIDDataSet = new Cupid.CUPIDDataSet();
            this.BaoCaoLSGDTableAdapter = new Cupid.CUPIDDataSetTableAdapters.BaoCaoLSGDTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.button_Maximize = new FontAwesome.Sharp.IconButton();
            this.button_Minimize = new FontAwesome.Sharp.IconButton();
            this.button_Close = new FontAwesome.Sharp.IconButton();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Loi = new System.Windows.Forms.Label();
            this.label_DenNgay = new System.Windows.Forms.Label();
            this.combobox_HinhThuc = new Cupid.Combobox_Custom();
            this.dateTimePicker_NgayKetThuc = new Cupid.DateTimePicker_Custom();
            this.label_TuNgay = new System.Windows.Forms.Label();
            this.dateTimePicker_NgayBatDau = new Cupid.DateTimePicker_Custom();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoLSGDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUPIDDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaoCaoLSGDBindingSource
            // 
            this.BaoCaoLSGDBindingSource.DataMember = "BaoCaoLSGD";
            this.BaoCaoLSGDBindingSource.DataSource = this.CUPIDDataSet;
            // 
            // CUPIDDataSet
            // 
            this.CUPIDDataSet.DataSetName = "CUPIDDataSet";
            this.CUPIDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BaoCaoLSGDTableAdapter
            // 
            this.BaoCaoLSGDTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.label_Title);
            this.panel1.Controls.Add(this.pictureBox_Icon);
            this.panel1.Controls.Add(this.button_Maximize);
            this.panel1.Controls.Add(this.button_Minimize);
            this.panel1.Controls.Add(this.button_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 30);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Top_MouseDown);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(34, 8);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(149, 15);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Báo cáo lịch sử giao dịch";
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
            this.button_Maximize.Location = new System.Drawing.Point(995, 0);
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
            this.button_Minimize.Location = new System.Drawing.Point(965, 0);
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
            this.button_Close.Location = new System.Drawing.Point(1025, 0);
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
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel_Top.Controls.Add(this.label_Loi);
            this.panel_Top.Controls.Add(this.label_DenNgay);
            this.panel_Top.Controls.Add(this.combobox_HinhThuc);
            this.panel_Top.Controls.Add(this.dateTimePicker_NgayKetThuc);
            this.panel_Top.Controls.Add(this.label_TuNgay);
            this.panel_Top.Controls.Add(this.dateTimePicker_NgayBatDau);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 30);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1055, 50);
            this.panel_Top.TabIndex = 8;
            // 
            // label_Loi
            // 
            this.label_Loi.AutoSize = true;
            this.label_Loi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label_Loi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label_Loi.Location = new System.Drawing.Point(497, 20);
            this.label_Loi.Name = "label_Loi";
            this.label_Loi.Size = new System.Drawing.Size(33, 15);
            this.label_Loi.TabIndex = 4;
            this.label_Loi.Text = "Lỗi...";
            this.label_Loi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // combobox_HinhThuc
            // 
            this.combobox_HinhThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combobox_HinhThuc.BackColor = System.Drawing.Color.White;
            this.combobox_HinhThuc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.combobox_HinhThuc.BorderSize = 3;
            this.combobox_HinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combobox_HinhThuc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.combobox_HinhThuc.ForeColor = System.Drawing.Color.DarkGray;
            this.combobox_HinhThuc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(217)))), ((int)(((byte)(243)))));
            this.combobox_HinhThuc.Items.AddRange(new object[] {
            "Thuê",
            "Được thuê",
            "Nạp tiền"});
            this.combobox_HinhThuc.ListBackColor = System.Drawing.Color.White;
            this.combobox_HinhThuc.ListTextColor = System.Drawing.Color.Black;
            this.combobox_HinhThuc.Location = new System.Drawing.Point(875, 8);
            this.combobox_HinhThuc.MinimumSize = new System.Drawing.Size(140, 35);
            this.combobox_HinhThuc.Name = "combobox_HinhThuc";
            this.combobox_HinhThuc.Padding = new System.Windows.Forms.Padding(3);
            this.combobox_HinhThuc.Size = new System.Drawing.Size(168, 35);
            this.combobox_HinhThuc.TabIndex = 3;
            this.combobox_HinhThuc.Texts = "Hình thức";
            this.combobox_HinhThuc.OnSelectedIndexChanged += new System.EventHandler(this.combobox_HinhThuc_OnSelectedIndexChanged);
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
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BaoCaoLSGDBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cupid.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1055, 501);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.ZoomPercent = 85;
            // 
            // formBaoCaoLSGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 581);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formBaoCaoLSGD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo lịch sử giao dịch";
            this.Load += new System.EventHandler(this.formBaoCaoLSGD_Load);
            this.Resize += new System.EventHandler(this.HinhAnh_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoLSGDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUPIDDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource BaoCaoLSGDBindingSource;
        private CUPIDDataSet CUPIDDataSet;
        private CUPIDDataSetTableAdapters.BaoCaoLSGDTableAdapter BaoCaoLSGDTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private FontAwesome.Sharp.IconButton button_Maximize;
        private FontAwesome.Sharp.IconButton button_Minimize;
        private FontAwesome.Sharp.IconButton button_Close;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Label label_Loi;
        private System.Windows.Forms.Label label_DenNgay;
        private Combobox_Custom combobox_HinhThuc;
        private DateTimePicker_Custom dateTimePicker_NgayKetThuc;
        private System.Windows.Forms.Label label_TuNgay;
        private DateTimePicker_Custom dateTimePicker_NgayBatDau;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}