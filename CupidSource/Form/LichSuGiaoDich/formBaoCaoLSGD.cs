using Cupid.DAO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupid
{
    public partial class formBaoCaoLSGD : Form
    {
        public formBaoCaoLSGD()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            combobox_HinhThuc.SelectedIndex = 0;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Remove transparent border in maximized state

        private void HinhAnh_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void formBaoCaoLSGD_Load(object sender, EventArgs e)
        {
            string homnay = DateTime.Now.ToString().Split(' ')[0];
            var f = (form_LichSuGiaoDich)this.Owner;
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT HO_TEN FROM NGUOI_DUNG WHERE TAI_KHOAN = '"+f.tk+"'");
            ReportParameterCollection para = new ReportParameterCollection();
            this.BaoCaoLSGDTableAdapter.Fill(this.CUPIDDataSet.BaoCaoLSGD, dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, combobox_HinhThuc.SelectedIndex);
            para.Add(new ReportParameter("NgayBatDau",dateTimePicker_NgayBatDau.Text));
            para.Add(new ReportParameter("NgayKetThuc", dateTimePicker_NgayKetThuc.Text));
            para.Add(new ReportParameter("NgayLap", homnay));
            para.Add(new ReportParameter("NguoiLap", dt.Rows[0][0].ToString()));
            label_Loi.Text = "";

            reportViewer1.LocalReport.SetParameters(para);  
            this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker_NgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (Kt())
            {
                ReportParameterCollection para = new ReportParameterCollection();
                this.BaoCaoLSGDTableAdapter.Fill(this.CUPIDDataSet.BaoCaoLSGD, dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, combobox_HinhThuc.SelectedIndex);
                para.Add(new ReportParameter("NgayBatDau", dateTimePicker_NgayBatDau.Text));
                para.Add(new ReportParameter("NgayKetThuc", dateTimePicker_NgayKetThuc.Text));
                reportViewer1.LocalReport.SetParameters(para);
                this.reportViewer1.RefreshReport();
            }
        }

        private void dateTimePicker_NgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if (Kt())
            {
                ReportParameterCollection para = new ReportParameterCollection();
                this.BaoCaoLSGDTableAdapter.Fill(this.CUPIDDataSet.BaoCaoLSGD, dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, combobox_HinhThuc.SelectedIndex);
                para.Add(new ReportParameter("NgayBatDau", dateTimePicker_NgayBatDau.Text));
                para.Add(new ReportParameter("NgayKetThuc", dateTimePicker_NgayKetThuc.Text));
                reportViewer1.LocalReport.SetParameters(para);
                this.reportViewer1.RefreshReport();
            }
        }

        private void combobox_HinhThuc_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            ReportParameterCollection para = new ReportParameterCollection();
            this.BaoCaoLSGDTableAdapter.Fill(this.CUPIDDataSet.BaoCaoLSGD, dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, combobox_HinhThuc.SelectedIndex);
            para.Add(new ReportParameter("NgayBatDau", dateTimePicker_NgayBatDau.Text));
            para.Add(new ReportParameter("NgayKetThuc", dateTimePicker_NgayKetThuc.Text));
            reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }

        bool Kt()
        {
            int check = DateTime.Compare(dateTimePicker_NgayKetThuc.Value, dateTimePicker_NgayBatDau.Value);

            if (check < 0)
            {
               
                label_Loi.Text = "Ngày không hợp lệ";
               
                return false;
            }
            label_Loi.Text = "";
            return true;
        }
    }
}
