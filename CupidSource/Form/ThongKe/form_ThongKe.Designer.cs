namespace Cupid
{
    partial class form_ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ThongKe));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.combobox_ThongKeTheo = new Cupid.Combobox_Custom();
            this.combobox_XemTheo = new Cupid.Combobox_Custom();
            this.combobox_HinhThuc = new Cupid.Combobox_Custom();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Bottom = new System.Windows.Forms.Panel();
            this.label_GiaTriTong = new System.Windows.Forms.Label();
            this.label_Tong = new System.Windows.Forms.Label();
            this.button_XuatFile = new Cupid.Toolbox_Custom.Button_Custom();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_Top.SuspendLayout();
            this.panel_Bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel_Top.Controls.Add(this.combobox_ThongKeTheo);
            this.panel_Top.Controls.Add(this.combobox_XemTheo);
            this.panel_Top.Controls.Add(this.combobox_HinhThuc);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(850, 50);
            this.panel_Top.TabIndex = 1;
            // 
            // combobox_ThongKeTheo
            // 
            this.combobox_ThongKeTheo.BackColor = System.Drawing.Color.White;
            this.combobox_ThongKeTheo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.combobox_ThongKeTheo.BorderSize = 3;
            this.combobox_ThongKeTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combobox_ThongKeTheo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.combobox_ThongKeTheo.ForeColor = System.Drawing.Color.DarkGray;
            this.combobox_ThongKeTheo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.combobox_ThongKeTheo.Items.AddRange(new object[] {
            "Ngày trong tháng",
            "Tháng trong năm",
            "Năm"});
            this.combobox_ThongKeTheo.ListBackColor = System.Drawing.Color.White;
            this.combobox_ThongKeTheo.ListTextColor = System.Drawing.Color.Black;
            this.combobox_ThongKeTheo.Location = new System.Drawing.Point(10, 8);
            this.combobox_ThongKeTheo.MinimumSize = new System.Drawing.Size(140, 35);
            this.combobox_ThongKeTheo.Name = "combobox_ThongKeTheo";
            this.combobox_ThongKeTheo.Padding = new System.Windows.Forms.Padding(3);
            this.combobox_ThongKeTheo.Size = new System.Drawing.Size(168, 35);
            this.combobox_ThongKeTheo.TabIndex = 5;
            this.combobox_ThongKeTheo.Texts = "Thống kê theo";
            this.combobox_ThongKeTheo.OnSelectedIndexChanged += new System.EventHandler(this.combobox_ThongKeTheo_OnSelectedIndexChanged);
            // 
            // combobox_XemTheo
            // 
            this.combobox_XemTheo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combobox_XemTheo.BackColor = System.Drawing.Color.White;
            this.combobox_XemTheo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.combobox_XemTheo.BorderSize = 3;
            this.combobox_XemTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combobox_XemTheo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.combobox_XemTheo.ForeColor = System.Drawing.Color.DarkGray;
            this.combobox_XemTheo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.combobox_XemTheo.Items.AddRange(new object[] {
            "Biểu đồ cột",
            "Biểu đổ đường",
            "Biểu đồ miền"});
            this.combobox_XemTheo.ListBackColor = System.Drawing.Color.White;
            this.combobox_XemTheo.ListTextColor = System.Drawing.Color.Black;
            this.combobox_XemTheo.Location = new System.Drawing.Point(670, 8);
            this.combobox_XemTheo.MinimumSize = new System.Drawing.Size(140, 35);
            this.combobox_XemTheo.Name = "combobox_XemTheo";
            this.combobox_XemTheo.Padding = new System.Windows.Forms.Padding(3);
            this.combobox_XemTheo.Size = new System.Drawing.Size(168, 35);
            this.combobox_XemTheo.TabIndex = 4;
            this.combobox_XemTheo.Texts = "Xem theo";
            this.combobox_XemTheo.OnSelectedIndexChanged += new System.EventHandler(this.combobox_XemTheo_OnSelectedIndexChanged);
            // 
            // combobox_HinhThuc
            // 
            this.combobox_HinhThuc.BackColor = System.Drawing.Color.White;
            this.combobox_HinhThuc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.combobox_HinhThuc.BorderSize = 3;
            this.combobox_HinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combobox_HinhThuc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.combobox_HinhThuc.ForeColor = System.Drawing.Color.DarkGray;
            this.combobox_HinhThuc.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.combobox_HinhThuc.ListBackColor = System.Drawing.Color.White;
            this.combobox_HinhThuc.ListTextColor = System.Drawing.Color.Black;
            this.combobox_HinhThuc.Location = new System.Drawing.Point(195, 8);
            this.combobox_HinhThuc.MinimumSize = new System.Drawing.Size(140, 35);
            this.combobox_HinhThuc.Name = "combobox_HinhThuc";
            this.combobox_HinhThuc.Padding = new System.Windows.Forms.Padding(3);
            this.combobox_HinhThuc.Size = new System.Drawing.Size(168, 35);
            this.combobox_HinhThuc.TabIndex = 3;
            this.combobox_HinhThuc.Texts = "Chọn thời gian";
            this.combobox_HinhThuc.OnSelectedIndexChanged += new System.EventHandler(this.combobox_HinhThuc_OnSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(107, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 3;
            // 
            // panel_Bottom
            // 
            this.panel_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel_Bottom.Controls.Add(this.label1);
            this.panel_Bottom.Controls.Add(this.label_GiaTriTong);
            this.panel_Bottom.Controls.Add(this.label_Tong);
            this.panel_Bottom.Controls.Add(this.button_XuatFile);
            this.panel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Bottom.Location = new System.Drawing.Point(0, 550);
            this.panel_Bottom.Name = "panel_Bottom";
            this.panel_Bottom.Size = new System.Drawing.Size(850, 50);
            this.panel_Bottom.TabIndex = 4;
            // 
            // label_GiaTriTong
            // 
            this.label_GiaTriTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_GiaTriTong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_GiaTriTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(100)))));
            this.label_GiaTriTong.Location = new System.Drawing.Point(670, 9);
            this.label_GiaTriTong.Margin = new System.Windows.Forms.Padding(0);
            this.label_GiaTriTong.Name = "label_GiaTriTong";
            this.label_GiaTriTong.Size = new System.Drawing.Size(170, 30);
            this.label_GiaTriTong.TabIndex = 0;
            this.label_GiaTriTong.Text = "000.000.000.000VNĐ";
            this.label_GiaTriTong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Tong
            // 
            this.label_Tong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Tong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label_Tong.ForeColor = System.Drawing.Color.DarkGray;
            this.label_Tong.Location = new System.Drawing.Point(612, 9);
            this.label_Tong.Name = "label_Tong";
            this.label_Tong.Size = new System.Drawing.Size(55, 30);
            this.label_Tong.TabIndex = 0;
            this.label_Tong.Text = "Tổng:";
            this.label_Tong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_XuatFile
            // 
            this.button_XuatFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_XuatFile.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_XuatFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250)))));
            this.button_XuatFile.BorderRadius = 5;
            this.button_XuatFile.BorderSize = 0;
            this.button_XuatFile.FlatAppearance.BorderSize = 0;
            this.button_XuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_XuatFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_XuatFile.ForeColor = System.Drawing.Color.White;
            this.button_XuatFile.Location = new System.Drawing.Point(12, 10);
            this.button_XuatFile.Name = "button_XuatFile";
            this.button_XuatFile.Size = new System.Drawing.Size(80, 30);
            this.button_XuatFile.TabIndex = 2;
            this.button_XuatFile.Text = "Xuất File";
            this.button_XuatFile.TextColor = System.Drawing.Color.White;
            this.button_XuatFile.UseVisualStyleBackColor = false;
            this.button_XuatFile.Click += new System.EventHandler(this.button_XuatFile_Click);
            // 
            // chart
            // 
            chartArea1.AxisX2.CustomLabels.Add(customLabel1);
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Name = "Legend1";
            legend1.TitleAlignment = System.Drawing.StringAlignment.Far;
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 50);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(80)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(250))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(80))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(80))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(250))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(80)))), ((int)(((byte)(250))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(150)))), ((int)(((byte)(200))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))))};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Nạp tiền";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Thuê";
            series2.YValuesPerPoint = 4;
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(850, 500);
            this.chart.TabIndex = 5;
            this.chart.Text = "chart";
            title1.BackColor = System.Drawing.Color.Transparent;
            title1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            title1.BackSecondaryColor = System.Drawing.Color.Transparent;
            title1.BorderColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title";
            title1.Text = "Thống kê doanh thu";
            this.chart.Titles.Add(title1);
            // 
            // form_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panel_Bottom);
            this.Controls.Add(this.panel_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_ThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.form_ThongKe_Load);
            this.panel_Top.ResumeLayout(false);
            this.panel_Bottom.ResumeLayout(false);
            this.panel_Bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private Combobox_Custom combobox_HinhThuc;
        private System.Windows.Forms.Panel panel_Bottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_GiaTriTong;
        private System.Windows.Forms.Label label_Tong;
        private Toolbox_Custom.Button_Custom button_XuatFile;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Combobox_Custom combobox_XemTheo;
        private Combobox_Custom combobox_ThongKeTheo;
    }
}