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
using Microsoft.Office.Interop.Excel;

namespace Cupid
{
    public partial class form_LichSuGiaoDich : Form
    {
        public string tk;
        bool check_giaodien, check_ngonngu;
        public form_LichSuGiaoDich(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            label_Loi.Text = "";
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
        }
        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                dataGridView2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        void showData(bool e,bool v,bool s)
        {
            dataGridView.Visible = e;   
            dataGridView1.Visible = v;
            dataGridView2.Visible = s;
        }
        private void form_LichSuGiaoDich_Load(object sender, EventArgs e)
        {
            showData(false,false,true);
            combobox_HinhThuc.SelectedItem = combobox_HinhThuc.Items[0];
            combobox_TrangThai.SelectedItem = combobox_TrangThai.Items[0];
            dataGridView2.DataSource = LichSuGiaoDichDAO.Instance.getLichSuNap(dateTimePicker_NgayBatDau.Value,dateTimePicker_NgayKetThuc.Value,true);
            if (!check_giaodien)
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_White_01;
                dataGridView.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_White_01;
            }
            else
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_Black_01;
                dataGridView.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            }
        }

        private void dateTimePicker_NgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (Kt())
            {
                if (combobox_HinhThuc.SelectedIndex == 0)
                {
                    showData(false, false, true);
                    if (combobox_TrangThai.SelectedIndex == 0)
                    {
                        dataGridView2.DataSource = LichSuGiaoDichDAO.Instance.getLichSuNap(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, true);
                    }
                    else
                    {
                        dataGridView2.DataSource = LichSuGiaoDichDAO.Instance.getLichSuNap(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, false);
                    }
                }
                else if (combobox_HinhThuc.SelectedIndex == 1)
                {
                    showData(true, false, false);
                    if (combobox_TrangThai.SelectedIndex == 0)
                    {
                        dataGridView.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 0, true);
                    }
                    else
                    {
                        dataGridView.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 0, false);

                    }

                }
                else
                {
                    showData(false, true, false);
                    if (combobox_TrangThai.SelectedIndex == 0)
                    {
                        dataGridView1.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich2(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 1, true);
                    }
                    else
                    {
                        dataGridView1.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich2(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 1, false);

                    }
                }
            }
            textbox_TimKiem.Texts = "";
        }

        bool Kt()
        {
            int check = DateTime.Compare(dateTimePicker_NgayKetThuc.Value,dateTimePicker_NgayBatDau.Value );

            if (check < 0)
            {
                if (!check_ngonngu)
                {
                    label_Loi.Text = "Ngày không hợp lệ";
                }
                else
                {
                    label_Loi.Text = "Invalid date";
                }
                return false;
            }
            label_Loi.Text = "";
            return true;
        }

        private void dateTimePicker_NgayKetThuc_ValueChanged(object sender, EventArgs e)
        {

            if (Kt())
            {
                if (combobox_HinhThuc.SelectedIndex == 0)
                {
                    if (combobox_TrangThai.SelectedIndex == 0)
                    {
                        showData(false, false, true);
                        dataGridView2.DataSource = LichSuGiaoDichDAO.Instance.getLichSuNap(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, true);
                    }
                    else
                    {
                        showData(false, false, true);
                        dataGridView2.DataSource = LichSuGiaoDichDAO.Instance.getLichSuNap(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, false);
                    }
                }
                else if (combobox_HinhThuc.SelectedIndex == 1)
                {
                    showData(true, false, false);
                    if (combobox_TrangThai.SelectedIndex == 0)
                    {
                        dataGridView.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 0, true);
                    }
                    else
                    {
                        dataGridView.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 0, false);

                    }

                }
                else
                {
                    showData(false, true, false);
                    if (combobox_TrangThai.SelectedIndex == 0)
                    {
                        dataGridView1.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich2(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 1, true);
                    }
                    else
                    {
                        dataGridView1.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich2(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 1, false);

                    }
                }
                textbox_TimKiem.Texts = "";
            }
            else
            {
                dateTimePicker_NgayKetThuc.Value = DateTime.Now;
                dateTimePicker_NgayBatDau.Value = DateTime.Now;
            }
        }

        private void combobox_HinhThuc_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_HinhThuc.SelectedIndex == 0)
            {
                if (combobox_TrangThai.SelectedIndex == 0)
                {
                    showData(false, false, true);
                    dataGridView2.DataSource = LichSuGiaoDichDAO.Instance.getLichSuNap(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, true);
                }
                else
                {
                    showData(false, false, true);
                    dataGridView2.DataSource = LichSuGiaoDichDAO.Instance.getLichSuNap(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, false);
                }
            }
            else if (combobox_HinhThuc.SelectedIndex == 1)
            {
                showData(true, false, false);
                if (combobox_TrangThai.SelectedIndex == 0)
                {
                    dataGridView.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 0, true);
                }
                else
                {
                    dataGridView.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 0, false);

                }

            }
            else
            {
                showData(false, true, false);
                if (combobox_TrangThai.SelectedIndex == 0)
                {
                    dataGridView1.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich2(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 1, true);
                }
                else
                {
                    dataGridView1.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich2(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 1, false);

                }
            }
        }

        private void combobox_TrangThai_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_HinhThuc.SelectedIndex == 0)
            {
                if (combobox_TrangThai.SelectedIndex == 0)
                {
                    showData(false, false, true);
                    dataGridView2.DataSource = LichSuGiaoDichDAO.Instance.getLichSuNap(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, true);
                }
                else
                {
                    showData(false, false, true);
                    dataGridView2.DataSource = LichSuGiaoDichDAO.Instance.getLichSuNap(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, false);
                }
                
            }
            else if (combobox_HinhThuc.SelectedIndex == 1)
            {
                showData(true, false, false);
                if (combobox_TrangThai.SelectedIndex == 0)
                {
                    dataGridView.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 0, true);
                }
                else
                {
                    dataGridView.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 0, false);

                }

            }
            else
            {
                showData(false, true, false);
                if (combobox_TrangThai.SelectedIndex == 0)
                {
                    dataGridView1.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich2(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 1, true);
                }
                else
                {
                    dataGridView1.DataSource = LichSuGiaoDichDAO.Instance.getLichSuGiaoDich2(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, 1, false);

                }
            }
        }
        private void dataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                label_GiaTriTong.Text = "0 VND";
                button_XuatFile.BackColor = Color.DarkGray;
            }
            else
            {
                double tongTien = 0;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    tongTien += Convert.ToDouble(dataGridView.Rows[i].Cells[dataGridView.Columns.Count - 1].Value.ToString());
                }
                label_GiaTriTong.Text = tongTien.ToString("###,###,###,###") + " VND";
                button_XuatFile.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            }
           
        }

        private void dataGridView2_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                label_GiaTriTong.Text = "0 VND";
                button_XuatFile.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
            }
            else
            {
                double tongTien = 0;
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    tongTien += Convert.ToDouble(dataGridView2.Rows[i].Cells[dataGridView2.Columns.Count - 1].Value.ToString());
                }
                label_GiaTriTong.Text = tongTien.ToString("###,###,###,###") + " VND";
                button_XuatFile.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            }

        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                label_GiaTriTong.Text = "0 VND";
                button_XuatFile.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
            }
            else
            {
                double tongTien = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    tongTien += Convert.ToDouble(dataGridView1.Rows[i].Cells[dataGridView1.Columns.Count - 1].Value.ToString());
                }
                label_GiaTriTong.Text = tongTien.ToString("###,###,###,###") + " VND";
                button_XuatFile.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            }

        }

        private void button_XuatFile_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0 && dataGridView.Visible == true || dataGridView1.Rows.Count > 0 && dataGridView1.Visible == true || dataGridView2.Rows.Count > 0 && dataGridView2.Visible == true)
            {
                try
                {
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    try
                    {


                        //Getting the location and file name of the excel to save from user. 
                        SaveFileDialog saveDialog = new SaveFileDialog();
                        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                        saveDialog.FilterIndex = 2;
                        saveDialog.FileName = "Lịch Sử " + combobox_HinhThuc.Texts ;
                       
                        if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            workbook.SaveAs(saveDialog.FileName);
                            app.Visible = true;
                            worksheet = workbook.ActiveSheet;
                            worksheet.Name = "Lich su " + combobox_HinhThuc.Texts ;
                            worksheet = workbook.Sheets["Lich su " + combobox_HinhThuc.Texts];

                            if (dataGridView.Visible == true)
                            {
                                for (int i = 0; i < dataGridView.Columns.Count; i++)
                                {
                                    worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                                }
                                for (int i = 0; i < dataGridView.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                                    {
                                        if (dataGridView.Rows[i].Cells[j].Value != null)
                                        {
                                            worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                                        }
                                        else
                                        {
                                            worksheet.Cells[i + 2, j + 1] = "";
                                        }
                                    }
                                }
                                workbook.Save();
                            }
                            else if (dataGridView1.Visible == true)
                            {
                                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                {
                                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                                }
                                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                    {
                                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                                        {
                                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                                        }
                                        else
                                        {
                                            worksheet.Cells[i + 2, j + 1] = "";
                                        }
                                    }
                                }
                                workbook.Save();
                            }
                            else if (dataGridView2.Visible == true)
                            {
                                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                                {
                                    worksheet.Cells[1, i + 1] = dataGridView2.Columns[i].HeaderText;
                                }
                                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                                    {
                                        if (dataGridView2.Rows[i].Cells[j].Value != null)
                                        {
                                            worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                                        }
                                        else
                                        {
                                            worksheet.Cells[i + 2, j + 1] = "";
                                        }
                                    }
                                }
                                workbook.Save();
                            }

                           
                            //MessageBox.Show("Export Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            }
            else
            {

            }
        }

        private void textbox_TimKiem__TextChanged(object sender, EventArgs e)
        {
            if (textbox_TimKiem.Texts.Trim().Length > 0)
            {
                if (combobox_TrangThai.SelectedIndex == 0)
                {
                    if (combobox_HinhThuc.SelectedIndex == 0)
                    {
                        dataGridView2.DataSource = LichSuGiaoDichDAO.Instance.getLichSuNapById(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, true, textbox_TimKiem.Texts);
                    }
                    else if (combobox_HinhThuc.SelectedIndex == 1)
                    {
                        dataGridView.DataSource = LichSuGiaoDichDAO.Instance.getLichSuThueById(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, true, textbox_TimKiem.Texts);
                    }
                    else
                    {
                        dataGridView1.DataSource = LichSuGiaoDichDAO.Instance.getLichSuIdolById(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, true, textbox_TimKiem.Texts);
                    }
                }
                else
                {
                    if (combobox_HinhThuc.SelectedIndex == 0)
                    {
                        dataGridView2.DataSource = LichSuGiaoDichDAO.Instance.getLichSuNapById(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, false, textbox_TimKiem.Texts);
                    }
                    else if (combobox_HinhThuc.SelectedIndex == 1)
                    {
                        dataGridView.DataSource = LichSuGiaoDichDAO.Instance.getLichSuThueById(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, false, textbox_TimKiem.Texts);
                    }
                    else
                    {
                        dataGridView1.DataSource = LichSuGiaoDichDAO.Instance.getLichSuIdolById(dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value, false, textbox_TimKiem.Texts);
                    }
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

            button_XuatFile.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            //Textbox
            textbox_TimKiem.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TimKiem.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TimKiem.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            //Combobox
            combobox_HinhThuc.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_HinhThuc.ListBackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_HinhThuc.ListTextColor = CaiDatDAO.Instance.color_Text_White_01;

            combobox_TrangThai.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_TrangThai.ListBackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_TrangThai.ListTextColor = CaiDatDAO.Instance.color_Text_White_01;

            //DataGirdview
            dataGridView.BackgroundColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            dataGridView.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_White;
            dataGridView.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_White_01;

            //DataGirdview
            dataGridView1.BackgroundColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView1.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            dataGridView1.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView1.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView1.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_White_01;

            //DataGirdview
            dataGridView2.BackgroundColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView2.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView2.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            dataGridView2.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView2.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView2.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_White;
            dataGridView2.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_White_01;

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

            button_XuatFile.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            //Textbox
            textbox_TimKiem.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TimKiem.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TimKiem.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            //Combobox
            combobox_HinhThuc.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_HinhThuc.ListBackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_HinhThuc.ListTextColor = CaiDatDAO.Instance.color_Text_Black_01;

            combobox_TrangThai.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_TrangThai.ListBackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_TrangThai.ListTextColor = CaiDatDAO.Instance.color_Text_Black_01;

            //DataGirdview
            dataGridView.BackgroundColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            dataGridView.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_Black;
            dataGridView.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            //DataGirdview
            dataGridView1.BackgroundColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView1.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            dataGridView1.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView1.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView1.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_Black;
            dataGridView1.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            //DataGirdview
            dataGridView2.BackgroundColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView2.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView2.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            dataGridView2.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView2.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView2.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_Black;
            dataGridView2.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_Black_01;

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
            label_Tong.Text = "Tổng:";
            label_TuNgay.Text = "Từ ngày:";
            label_DenNgay.Text = "đến ngày:";
            button_XuatFile.Text = "Xuất file";
            combobox_HinhThuc.Texts = "Hình thức";
            combobox_TrangThai.Texts = "Trạng thái";
            textbox_TimKiem.PlaceholderText = "Tìm kiếm...";

            dataGridView.Columns[0].HeaderText = "Người thuê";
            dataGridView.Columns[1].HeaderText = "Idol";
            dataGridView.Columns[2].HeaderText = "Ngày giao dịch";
            dataGridView.Columns[3].HeaderText = "Số tiền";

            dataGridView1.Columns[0].HeaderText = "Idol";
            dataGridView1.Columns[1].HeaderText = "Người thuê";
            dataGridView1.Columns[2].HeaderText = "Ngày giao dịch";
            dataGridView1.Columns[3].HeaderText = "Số tiền";

            dataGridView2.Columns[0].HeaderText = "Người thuê";
            dataGridView2.Columns[1].HeaderText = "Ngày giao dịch";
            dataGridView2.Columns[2].HeaderText = "Số tiền";

            combobox_HinhThuc.Items.Add("Nạp tiền");
            combobox_HinhThuc.Items.Add("Người thuê");
            combobox_HinhThuc.Items.Add("Người cho thuê");

            combobox_TrangThai.Items.Add("Hoàn thành");
            combobox_TrangThai.Items.Add("Hủy");
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!check_giaodien)
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_White;
            }
            else
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_Black;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!check_giaodien)
            {
                dataGridView1.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_White;
            }
            else
            {
                dataGridView1.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_Black;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!check_giaodien)
            {
                dataGridView2.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_White;
            }
            else
            {
                dataGridView2.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_Black;
            }
        }

        int vt = -1;
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1)
            {
                return;
            }
            System.Data.DataTable dt = LichSuGiaoDichDAO.Instance.ThongKeUser(dataGridView2.Rows[vt].Cells[0].Value.ToString());
            System.Data.DataTable dt1 = LichSuGiaoDichDAO.Instance.ThongKeUser1(dataGridView2.Rows[vt].Cells[0].Value.ToString());
            System.Data.DataTable dt2 = LichSuGiaoDichDAO.Instance.ThongKeUser2(dataGridView2.Rows[vt].Cells[0].Value.ToString());


            form_ChiLichSuGiaoDich fctlsgd = new form_ChiLichSuGiaoDich(tk,dt,dt1,dt2, dataGridView2.Rows[vt].Cells[0].Value.ToString());
            fctlsgd.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1)
            {
                return;
            }
            System.Data.DataTable dt = LichSuGiaoDichDAO.Instance.ThongKeUser(dataGridView1.Rows[vt].Cells[0].Value.ToString());
            System.Data.DataTable dt1 = LichSuGiaoDichDAO.Instance.ThongKeUser1(dataGridView1.Rows[vt].Cells[0].Value.ToString());
            System.Data.DataTable dt2 = LichSuGiaoDichDAO.Instance.ThongKeUser2(dataGridView1.Rows[vt].Cells[0].Value.ToString());

            form_ChiLichSuGiaoDich fctlsgd = new form_ChiLichSuGiaoDich(tk,dt,dt1,dt2, dataGridView1.Rows[vt].Cells[0].Value.ToString());
            fctlsgd.ShowDialog();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1)
            {
                return;
            }
            System.Data.DataTable dt = LichSuGiaoDichDAO.Instance.ThongKeUser(dataGridView.Rows[vt].Cells[0].Value.ToString());
            System.Data.DataTable dt1 = LichSuGiaoDichDAO.Instance.ThongKeUser1(dataGridView.Rows[vt].Cells[0].Value.ToString());
            System.Data.DataTable dt2 = LichSuGiaoDichDAO.Instance.ThongKeUser2(dataGridView.Rows[vt].Cells[0].Value.ToString());

            form_ChiLichSuGiaoDich fctlsgd = new form_ChiLichSuGiaoDich(tk,dt,dt1,dt2, dataGridView.Rows[vt].Cells[0].Value.ToString());
            fctlsgd.ShowDialog();
        }

        public void Change_Language_EN()
        {
            label_Tong.Text = "Total:";
            label_TuNgay.Text = "From:";
            label_DenNgay.Text = "to:";
            button_XuatFile.Text = "Export";
            combobox_HinhThuc.Texts = "Formality";
            combobox_TrangThai.Texts = "Status";
            textbox_TimKiem.PlaceholderText = "Search...";

            dataGridView.Columns[0].HeaderText = "Hirer";
            dataGridView.Columns[1].HeaderText = "Idol";
            dataGridView.Columns[2].HeaderText = "Transaction Date";
            dataGridView.Columns[3].HeaderText = "Amount";

            dataGridView1.Columns[0].HeaderText = "Idol";
            dataGridView1.Columns[1].HeaderText = "Hirer";
            dataGridView1.Columns[2].HeaderText = "Transaction Date";
            dataGridView1.Columns[3].HeaderText = "Amount";

            dataGridView2.Columns[0].HeaderText = "Hirer";
            dataGridView2.Columns[1].HeaderText = "Transaction Date";
            dataGridView2.Columns[2].HeaderText = "Amount";

            combobox_HinhThuc.Items.Add("Top up");
            combobox_HinhThuc.Items.Add("Hiree");
            combobox_HinhThuc.Items.Add("Hirer");

            combobox_TrangThai.Items.Add("Complete");
            combobox_TrangThai.Items.Add("Cancel");
        }

        private void button_BaoCao_Click(object sender, EventArgs e)
        {
            formBaoCaoLSGD f = new formBaoCaoLSGD();
            f.Owner = this;
            f.ShowDialog();
        }

        public void UpdateColorApp()
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dataGridView2.ColumnHeadersDefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_XuatFile.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_BaoCao.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dateTimePicker_NgayBatDau.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dateTimePicker_NgayKetThuc.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_HinhThuc.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_HinhThuc.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_TrangThai.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_TrangThai.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}
