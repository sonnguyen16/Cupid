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
    public partial class form_LichSuHoatDong : Form
    {
        string tk;
        bool check_giaodien, check_ngonngu;
        public form_LichSuHoatDong(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
        }

        private void form_LichSuHoatDong_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD(-1, "");
        }
        // Bỏ lọc trên header, mũi tên trỏ xuống
        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        int vt = -1;
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1)
            {
                return;
            }
            form_ChiTietLichSuHoatDong f = new form_ChiTietLichSuHoatDong(tk,dataGridView.Rows[vt]);
            f.ShowDialog();
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

        private void dateTimePicker_NgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (Kt())
            {
                if (textbox_TimKiem.Texts.Trim().Length == 0 && combobox_TimKiemTheo.SelectedItem == null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(-1, "",dateTimePicker_NgayBatDau.Value,dateTimePicker_NgayKetThuc.Value);
                }
                else if (textbox_TimKiem.Texts.Trim().Length == 0 && combobox_TimKiemTheo.SelectedItem != null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(combobox_TimKiemTheo.SelectedIndex, "", dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
                else if (textbox_TimKiem.Texts.Trim().Length > 0 && combobox_TimKiemTheo.SelectedItem != null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(combobox_TimKiemTheo.SelectedIndex, textbox_TimKiem.Texts.Trim(), dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
            }
        }

        private void dateTimePicker_NgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if (Kt())
            {
                if (textbox_TimKiem.Texts.Trim().Length == 0 && combobox_TimKiemTheo.SelectedItem == null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(-1, "", dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
                else if (textbox_TimKiem.Texts.Trim().Length == 0 && combobox_TimKiemTheo.SelectedItem != null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(combobox_TimKiemTheo.SelectedIndex, "", dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
                else if (textbox_TimKiem.Texts.Trim().Length > 0 && combobox_TimKiemTheo.SelectedItem != null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(combobox_TimKiemTheo.SelectedIndex, textbox_TimKiem.Texts.Trim(), dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
                else if (textbox_TimKiem.Texts.Trim().Length > 0 && combobox_TimKiemTheo.SelectedItem == null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(-1, textbox_TimKiem.Texts.Trim(), dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
            }
        }

        private void textbox_TimKiem__TextChanged(object sender, EventArgs e)
        {
            if (textbox_TimKiem.Texts.Trim().Length > 0)
            {
                if (textbox_TimKiem.Texts.Trim().Length == 0 && combobox_TimKiemTheo.SelectedItem == null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(-1, "", dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
                else if (textbox_TimKiem.Texts.Trim().Length == 0 && combobox_TimKiemTheo.SelectedItem != null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(combobox_TimKiemTheo.SelectedIndex, "", dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
                else if (textbox_TimKiem.Texts.Trim().Length > 0 && combobox_TimKiemTheo.SelectedItem != null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(combobox_TimKiemTheo.SelectedIndex, textbox_TimKiem.Texts.Trim(), dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
                else if (textbox_TimKiem.Texts.Trim().Length > 0 && combobox_TimKiemTheo.SelectedItem == null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(-1, textbox_TimKiem.Texts.Trim(), dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
            }
           
        }

        private void combobox_TimKiemTheo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (textbox_TimKiem.Texts.Trim().Length > 0)
            {
                if (textbox_TimKiem.Texts.Trim().Length == 0 && combobox_TimKiemTheo.SelectedItem == null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(-1, "", dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
                else if (textbox_TimKiem.Texts.Trim().Length == 0 && combobox_TimKiemTheo.SelectedItem != null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(combobox_TimKiemTheo.SelectedIndex, "", dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
                else if (textbox_TimKiem.Texts.Trim().Length > 0 && combobox_TimKiemTheo.SelectedItem != null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(combobox_TimKiemTheo.SelectedIndex, textbox_TimKiem.Texts.Trim(), dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
                else if (textbox_TimKiem.Texts.Trim().Length > 0 && combobox_TimKiemTheo.SelectedItem == null)
                {
                    dataGridView.DataSource = LichSuHoatDongDAO.Instance.getLSHD2(-1, textbox_TimKiem.Texts.Trim(), dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                }
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

            //Textbox
            textbox_TimKiem.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TimKiem.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TimKiem.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            combobox_TimKiemTheo.BackColor = CaiDatDAO.Instance.color_BG_White_01;

            //DataGirdview
            dataGridView.BackgroundColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            dataGridView.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_White;
            dataGridView.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_White_01;

            // DateTimePicker
            dateTimePicker_NgayBatDau.SkinColor = CaiDatDAO.Instance.color_BG_White_01;
            dateTimePicker_NgayKetThuc.SkinColor = CaiDatDAO.Instance.color_BG_White_01;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            panel_Bottom.BackColor = CaiDatDAO.Instance.color_BG_Black_02;

            //Textbox
            textbox_TimKiem.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TimKiem.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TimKiem.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            combobox_TimKiemTheo.BackColor = CaiDatDAO.Instance.color_BG_Black_01;

            //DataGirdview
            dataGridView.BackgroundColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            dataGridView.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_Black;
            dataGridView.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            // DateTimePicker
            dateTimePicker_NgayBatDau.SkinColor = CaiDatDAO.Instance.color_BG_Black_01;
            dateTimePicker_NgayKetThuc.SkinColor = CaiDatDAO.Instance.color_BG_Black_01;
        }
        public bool KiemTraNgonNgu(string userName)
        {
            string query = "SELECT * FROM dbo.CAI_DAT WHERE TAI_KHOAN = N'" + userName + "' AND NGON_NGU = 1";

            System.Data.DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Language_VI()
        {
            label_TuNgay.Text = "Từ ngày:";
            label_DenNgay.Text = "đến ngày:";
            textbox_TimKiem.PlaceholderText = "Tìm kiếm...";

            dataGridView.Columns[0].HeaderText = "Tài khoản";
            dataGridView.Columns[1].HeaderText = "Thao tác";
            dataGridView.Columns[2].HeaderText = "Chi tiết";
            dataGridView.Columns[3].HeaderText = "Ngày thao tác";

        }
        public void Change_Language_EN()
        {
            label_TuNgay.Text = "From:";
            label_DenNgay.Text = "to:";
            textbox_TimKiem.PlaceholderText = "Search...";

            dataGridView.Columns[0].HeaderText = "User";
            dataGridView.Columns[1].HeaderText = "Action";
            dataGridView.Columns[2].HeaderText = "Details";
            dataGridView.Columns[3].HeaderText = "Date of Operation";
        }
        public void UpdateColorApp()
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dateTimePicker_NgayBatDau.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dateTimePicker_NgayKetThuc.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_TimKiemTheo.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_TimKiemTheo.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}
