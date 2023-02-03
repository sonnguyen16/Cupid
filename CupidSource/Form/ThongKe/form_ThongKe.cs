using Cupid.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cupid
{
    public partial class form_ThongKe : Form
    {
        public DataTable dt;
        public DataTable dt1;
        public DataTable dt2;
        string tk;
        bool check_giaodien, check_ngonngu;
        public form_ThongKe(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
        }

        private void form_ThongKe_Load(object sender, EventArgs e)
        {
            combobox_HinhThuc.Enabled = false;
        }

        private void combobox_ThongKeTheo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            combobox_HinhThuc.Items.Clear();
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            if (combobox_ThongKeTheo.SelectedIndex == 0)
            {
                combobox_HinhThuc.Enabled = true;
                dt = LichSuGiaoDichDAO.Instance.getComboBox();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    combobox_HinhThuc.Items.Add(dt.Rows[i][0].ToString() + "/" + dt.Rows[i][1].ToString());
                }
            }
            else if (combobox_ThongKeTheo.SelectedIndex == 1)
            {
                combobox_HinhThuc.Enabled = true;
                dt = LichSuGiaoDichDAO.Instance.getComboBox2();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    combobox_HinhThuc.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            else
            {
                double tong = 0;
                combobox_HinhThuc.Enabled = false;
                dt1 = LichSuGiaoDichDAO.Instance.ThongKe3(2);
                dt2 = LichSuGiaoDichDAO.Instance.ThongKe3(1);
                chart.Titles[0].Text = "Thống kê doanh thu theo năm ";


                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    chart.Series["Nạp tiền"].Points.AddXY(dt1.Rows[i][0].ToString(), Convert.ToDouble(dt1.Rows[i][1]).ToString("###,###,###,###"));
                    chart.Series["Nạp tiền"].Points[i].Label = Convert.ToDouble(dt1.Rows[i][1]).ToString("###,###,###,###");
                    tong += Convert.ToDouble(dt1.Rows[i][1]);
                }

                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    chart.Series["Thuê"].Points.AddXY(dt2.Rows[i][0].ToString(), Convert.ToDouble(dt2.Rows[i][1]).ToString("###,###,###,###"));
                    chart.Series["Thuê"].Points[i].Label = Convert.ToDouble(dt2.Rows[i][1]).ToString("###,###,###,###");
                    tong += Convert.ToDouble(dt2.Rows[i][1]);
                }
                label_GiaTriTong.Text = tong.ToString("###,###,###,###") + " VND";
               
            }
        }

        private void combobox_XemTheo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_XemTheo.SelectedIndex == 0)
            {
                chart.Series["Nạp tiền"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart.Series["Thuê"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
            if (combobox_XemTheo.SelectedIndex == 1)
            {
                chart.Series["Nạp tiền"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart.Series["Thuê"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }
            if (combobox_XemTheo.SelectedIndex == 2)
            {
                chart.Series["Nạp tiền"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                chart.Series["Thuê"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            }

        }

        private void combobox_HinhThuc_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            if (combobox_ThongKeTheo.SelectedIndex == 0)
            {
                double tong = 0;
                string [] arr = combobox_HinhThuc.Texts.Split('/');
                string month = arr[0];
                string year = arr[1];
                dt1 = LichSuGiaoDichDAO.Instance.ThongKe(month, year, 2);
                dt2 = LichSuGiaoDichDAO.Instance.ThongKe(month, year, 1);
                chart.Titles[0].Text = "Thống kê doanh thu tháng " + month + "/" + year;


                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    chart.Series["Nạp tiền"].Points.AddXY(dt1.Rows[i][0].ToString(), Convert.ToDouble(dt1.Rows[i][1]).ToString("###,###,###,###"));
                    chart.Series["Nạp tiền"].Points[i].Label = Convert.ToDouble(dt1.Rows[i][1]).ToString("###,###,###,###");
                    tong += Convert.ToDouble(dt1.Rows[i][1]);
                }

                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    chart.Series["Thuê"].Points.AddXY(dt2.Rows[i][0].ToString(), Convert.ToDouble(dt2.Rows[i][1]).ToString("###,###,###,###"));
                    chart.Series["Thuê"].Points[i].Label = Convert.ToDouble(dt2.Rows[i][1]).ToString("###,###,###,###");
                    tong += Convert.ToDouble(dt2.Rows[i][1]);
                }
                label_GiaTriTong.Text = tong.ToString("###,###,###,###") + " VND";
            }
            else if (combobox_ThongKeTheo.SelectedIndex == 1)
            {
                double tong = 0;
                string year = combobox_HinhThuc.Texts;

                dt1 = LichSuGiaoDichDAO.Instance.ThongKe2(year, 2);
                dt2 = LichSuGiaoDichDAO.Instance.ThongKe2(year, 1);
                chart.Titles[0].Text = "Thống kê doanh thu năm " + year;


                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    chart.Series["Nạp tiền"].Points.AddXY(dt1.Rows[i][0].ToString(), Convert.ToDouble(dt1.Rows[i][1]).ToString("###,###,###,###"));
                    chart.Series["Nạp tiền"].Points[i].Label = Convert.ToDouble(dt1.Rows[i][1]).ToString("###,###,###,###");
                    tong += Convert.ToDouble(dt1.Rows[i][1]);
                }

                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    chart.Series["Thuê"].Points.AddXY(dt2.Rows[i][0].ToString(), Convert.ToDouble(dt2.Rows[i][1]).ToString("###,###,###,###"));
                    chart.Series["Thuê"].Points[i].Label = Convert.ToDouble(dt2.Rows[i][1]).ToString("###,###,###,###");
                    tong += Convert.ToDouble(dt2.Rows[i][1]);
                }
                label_GiaTriTong.Text = tong.ToString("###,###,###,###") + " VND";
            }
          
        }

       
        private void button_XuatFile_Click(object sender, EventArgs e)
        {
             string fileName;
            fileName = Application.StartupPath + "\\chartExport";
            fileName = fileName + ".gif";

            this.chart.SaveImage(fileName,System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Gif);
            System.Diagnostics.Process.Start(fileName);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void Update_GiaoDien_NgonNgu()
        {
            // Giao diện
            if (KiemTraGiaoDien(tk))
            {
                Change_Color_Black();
                check_giaodien = true;
            }
            else
            {
                Change_Color_White();
                check_giaodien = false;
            }
            // Ngôn ngữ
            if (KiemTraNgonNgu(tk))
            {
                Change_Language_EN();
                check_ngonngu = true;
            }
            else
            {
                Change_Language_VI();
                check_ngonngu = false;
            }
        }
        public bool KiemTraGiaoDien(string userName)
        {
            string query = "SELECT * FROM dbo.CAI_DAT WHERE TAI_KHOAN = N'" + userName + "' AND GIAO_DIEN = 1";

            System.Data.DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Color_White()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_White_02;
            panel_Bottom.BackColor = CaiDatDAO.Instance.color_BG_White_02;

            combobox_ThongKeTheo.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_XemTheo.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_HinhThuc.BackColor = CaiDatDAO.Instance.color_BG_White_01;

            chart.BackColor = CaiDatDAO.Instance.color_BG_White_01;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            panel_Bottom.BackColor = CaiDatDAO.Instance.color_BG_Black_02;

            combobox_ThongKeTheo.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_XemTheo.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_HinhThuc.BackColor = CaiDatDAO.Instance.color_BG_Black_01;

            chart.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
        }
        public bool KiemTraNgonNgu(string userName)
        {
            string query = "SELECT * FROM dbo.CAI_DAT WHERE TAI_KHOAN = N'" + userName + "' AND NGON_NGU = 1";

            System.Data.DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Language_VI()
        {


        }
        public void Change_Language_EN()
        {

        }

        private void button_BaoCao_Click(object sender, EventArgs e)
        {
            
        }

        public void UpdateColorApp()
        {
            combobox_ThongKeTheo.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_ThongKeTheo.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            combobox_XemTheo.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_XemTheo.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            combobox_HinhThuc.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_HinhThuc.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_XuatFile.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}
