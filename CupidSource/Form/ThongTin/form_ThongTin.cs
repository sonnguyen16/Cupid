using Cupid.DAO;
using Cupid.Toolbox_Custom;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Cupid
{
    public partial class form_ThongTin : Form
    {
        public Button_Custom currentBtn;
        private Panel leftBorderBtn;
        internal object btn;
        internal EventArgs ea;
        internal object btn1;
        internal EventArgs ea1;
        public DataGridViewRow row;
        string tk;
        bool check_giaodien, check_ngonngu;
        private int TotalPage = 0;
        private const int PgSize = 20;
        private int CurrentPageIndex = 1;
        private int TotalPageSearch = 0;
        private int CurrentPageIndexSearch = 1;
        public int loaitk = 1;
        public form_ThongTin(string tk)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(120, 3);
            panel_Top.Controls.Add(leftBorderBtn);
            OnOffBtn(false);
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
            panel_Loading.BackColor = this.BackColor;
            combobox_TimKiemTheo.SelectedIndex = 0;
        }

        private void btnNxtPage_Click(object sender, EventArgs e)
        {
            vt = -1;
            dataGridView.ClearSelection();
            OnOffBtn(false);
            if (textbox_TimKiem.Texts.Trim().Length > 0 && combobox_TimKiemTheo.SelectedItem != null)
            {
                if (this.CurrentPageIndexSearch < this.TotalPageSearch)
                {
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    this.CurrentPageIndexSearch++;
                    label_TrangHienTai.Text = CurrentPageIndexSearch.ToString();
                    this.dataGridView.DataSource =
              DataProvider.Instance.GetCurrentRecords2(this.CurrentPageIndexSearch, loaitk, combobox_TimKiemTheo.SelectedIndex, textbox_TimKiem.Texts);
                }
                if (CurrentPageIndexSearch == TotalPageSearch)
                {
                    button_TienLen.BackColor = Color.DarkGray;
                    button_TienLen2.BackColor = Color.DarkGray;


                }
                else
                {
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                }
                if (TotalPageSearch != 0 && TotalPageSearch != 1)
                {
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
            }
            else
            {
                if (this.CurrentPageIndex < this.TotalPage)
                {
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    this.CurrentPageIndex++;
                    label_TrangHienTai.Text = CurrentPageIndex.ToString();
                    this.dataGridView.DataSource =
                DataProvider.Instance.GetCurrentRecords(this.CurrentPageIndex, loaitk);
                }
                if (CurrentPageIndex == TotalPage)
                {
                    button_TienLen.BackColor = Color.DarkGray;
                    button_TienLen2.BackColor = Color.DarkGray;

                }
                else
                {
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

                }
                if (TotalPage != 0 && TotalPage != 1)
                {
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

                }
            }
        }
        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            vt = -1;
            dataGridView.ClearSelection();
            OnOffBtn(false);
            if (textbox_TimKiem.Texts.Trim().Length > 0 && combobox_TimKiemTheo.SelectedItem != null)
            {
                if (this.CurrentPageIndexSearch > 1)
                {
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    this.CurrentPageIndexSearch--;
                    label_TrangHienTai.Text = CurrentPageIndexSearch.ToString();
                    this.dataGridView.DataSource =
                DataProvider.Instance.GetCurrentRecords2(this.CurrentPageIndexSearch, loaitk, combobox_TimKiemTheo.SelectedIndex, textbox_TimKiem.Texts);
                }
                if (CurrentPageIndexSearch == 1)
                {
                    button_QuayLai.BackColor = Color.DarkGray;
                    button_QuayLai2.BackColor = Color.DarkGray;

                }
                else
                {
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
                if (TotalPageSearch != 0 && TotalPageSearch != 1)
                {
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
            }
            else
            {
                if (this.CurrentPageIndex > 1)
                {
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    this.CurrentPageIndex--;
                    label_TrangHienTai.Text = CurrentPageIndex.ToString();
                    this.dataGridView.DataSource =
                DataProvider.Instance.GetCurrentRecords(this.CurrentPageIndex, loaitk);
                }
                if (CurrentPageIndex == 1)
                {
                    button_QuayLai.BackColor = Color.DarkGray;
                    button_QuayLai2.BackColor = Color.DarkGray;

                }
                else
                {
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

                }
                if (TotalPage != 0 && TotalPage != 1)
                {
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

                }
            }


        }
        private void CalculateTotalPages()
        {
            CurrentPageIndex = 1;
            int rowCount = 0;
            if (loaitk == 1)
            {
                rowCount = (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM NGUOI_DUNG WHERE LOAI_NGUOI_DUNG  = 1");

            }
            else
            {
                rowCount = (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM NGUOI_DUNG WHERE LOAI_NGUOI_DUNG  = 2");

            }
            TotalPage = rowCount / PgSize;
            // if any row left after calculated pages, add one more page 
            if (rowCount % PgSize > 0)
                TotalPage += 1;
            if (TotalPage == 1 || TotalPage == 0)
            {
                button_TienLen.BackColor = Color.DarkGray;
                button_TienLen2.BackColor = Color.DarkGray;
                button_QuayLai.BackColor = Color.DarkGray;
                button_QuayLai2.BackColor = Color.DarkGray;
            }
            else
            {
                button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                button_QuayLai.BackColor = Color.DarkGray;
                button_QuayLai2.BackColor = Color.DarkGray;
            }
            label_TongSoTrang.Text = "/ " + TotalPage.ToString();
            label_TrangHienTai.Text = CurrentPageIndex.ToString();
        }
        private void CalculateTotalPagesSearch()
        {
            CurrentPageIndexSearch = 1;
            int rowCount = 0;
            if (loaitk == 1)
            {
                rowCount = DataProvider.Instance.CountResult(combobox_TimKiemTheo.SelectedIndex, 1, textbox_TimKiem.Texts);

            }
            else
            {
                rowCount = DataProvider.Instance.CountResult(combobox_TimKiemTheo.SelectedIndex, 2, textbox_TimKiem.Texts);

            }
            TotalPageSearch = rowCount / PgSize;
            // if any row left after calculated pages, add one more page 
            if (rowCount % PgSize > 0)
                TotalPageSearch += 1;
            if (TotalPageSearch == 1 || TotalPageSearch == 0)
            {
                button_TienLen.BackColor = Color.DarkGray;
                button_TienLen2.BackColor = Color.DarkGray;
                button_QuayLai.BackColor = Color.DarkGray;
                button_QuayLai2.BackColor = Color.DarkGray;
            }
            else
            {
                button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                button_QuayLai.BackColor = Color.DarkGray;
                button_QuayLai2.BackColor = Color.DarkGray;
            }
            label_TongSoTrang.Text = "/ " + TotalPageSearch.ToString();
            label_TrangHienTai.Text = CurrentPageIndexSearch.ToString();
        }
        // Bỏ lọc trên header, mũi tên trỏ xuống
        private void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        public void OnOffBtn(bool e)
        {
            if (e == true)
            {
                button_ChinhSua.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                button_Xoa.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                button_NapTien.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            }
            else
            {
                button_ChinhSua.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
                button_Xoa.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
                button_NapTien.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;

            }
        }
        public void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Button_Custom)senderBtn;
                if (!check_giaodien)
                {
                    currentBtn.BackColor = CaiDatDAO.Instance.color_BG_White_02;
                    currentBtn.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
                }
                else
                {
                    currentBtn.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
                    currentBtn.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
                }
                //Left border button
                leftBorderBtn.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
                leftBorderBtn.Location = new System.Drawing.Point(currentBtn.Location.X, 47);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                if (!check_giaodien)
                {
                    currentBtn.BackColor = CaiDatDAO.Instance.color_BG_White_02;
                }
                else
                {
                    currentBtn.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
                }
                currentBtn.ForeColor = CaiDatDAO.Instance.color_Text_DarkGray;
            }
        }
        private void button_Tao_Click(object sender, EventArgs e)
        {
            form_TaoTaiKhoanNguoiDung fttknd = new form_TaoTaiKhoanNguoiDung(tk);
            fttknd.Owner = this;
            fttknd.ShowDialog();
        }
        private void button_ChinhSua_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                form_ChinhSuaTaiKhoanNguoiDung fcstknd = new form_ChinhSuaTaiKhoanNguoiDung(row, tk);
                fcstknd.Owner = this;
                fcstknd.ShowDialog();
            }

        }
        private void button_NapTien_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                form_NapTien fnt = new form_NapTien(tk, row.Cells[0].Value.ToString());
                fnt.Owner = this;
                fnt.ShowDialog();
            }
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                if (dataGridView.SelectedRows.Count == 1)
                {
                    form_XoaTaiKhoanNguoiDung fxtknd = new form_XoaTaiKhoanNguoiDung(row, tk);
                    fxtknd.Owner = this;
                    fxtknd.ShowDialog();
                }
                else
                {
                    List<string> listtk = new List<string>();
                    for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                    {
                        listtk.Add(dataGridView.SelectedRows[i].Cells[0].Value.ToString());
                    }
                    form_XoaTaiKhoanNguoiDung fxtknd = new form_XoaTaiKhoanNguoiDung(listtk, tk);
                    fxtknd.Owner = this;
                    fxtknd.ShowDialog();
                }
               
            }

        }
        public void button_BinhThuong_Click(object sender, EventArgs e)
        {
            vt = -1;
            loaitk = 1;
            CurrentPageIndex = 1;
            CurrentPageIndexSearch = 1;
            textbox_TimKiem.Texts = String.Empty;
            this.btn = sender;
            this.ea = e;
            ActivateButton(sender);
            OnOffBtn(false);
            CalculateTotalPages();
            dataGridView.DataSource = DataProvider.Instance.GetCurrentRecords(CurrentPageIndex, 1);
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
        public void button_Idol_Click(object sender, EventArgs e)
        {
            vt = -1;
            loaitk = 2;
            this.btn1 = sender;
            textbox_TimKiem.Texts = String.Empty;
            this.ea1 = e;
            OnOffBtn(false);
            CurrentPageIndex = 1;
            CurrentPageIndexSearch = 1;
            CalculateTotalPages();
            ActivateButton(sender);
            dataGridView.DataSource = DataProvider.Instance.GetCurrentRecords(CurrentPageIndex, 2);
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

        public int vt = -1;
        public void form_ThongTin_Load(object sender, EventArgs e)
        {
            panel_Loading.Visible = true;
            timer1.Start();
            ActivateButton(button_BinhThuong);
            OnOffBtn(false);
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
        private void textbox_TimKiem__TextChanged(object sender, EventArgs e)
        {

            if (combobox_TimKiemTheo.SelectedItem != null)
            {
                if (textbox_TimKiem.Texts.Trim().Length > 0)
                {
                    dataGridView.DataSource = DataProvider.Instance.GetCurrentRecords2(CurrentPageIndexSearch, loaitk, combobox_TimKiemTheo.SelectedIndex, textbox_TimKiem.Texts);
                    CalculateTotalPagesSearch();
                    if (TotalPageSearch > 0)
                    {
                        if (TotalPageSearch == 1)
                        {
                            button_QuayLai.BackColor = Color.DarkGray;
                            button_QuayLai2.BackColor = Color.DarkGray;
                            button_TienLen.BackColor = Color.DarkGray;
                            button_TienLen2.BackColor = Color.DarkGray;
                        }
                        else
                        {
                            button_QuayLai.BackColor = Color.DarkGray;
                            button_QuayLai2.BackColor = Color.DarkGray;
                            button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                            button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                        }
                    }
                    else
                    {
                        button_QuayLai.BackColor = Color.DarkGray;
                        button_QuayLai2.BackColor = Color.DarkGray;
                        button_TienLen.BackColor = Color.DarkGray;
                        button_TienLen2.BackColor = Color.DarkGray;
                    }
                }
                else
                {
                    dataGridView.DataSource = DataProvider.Instance.GetCurrentRecords(1, loaitk);
                    CalculateTotalPages();
                    if (TotalPage > 0)
                    {
                        if (TotalPage == 1)
                        {
                            button_QuayLai.BackColor = Color.DarkGray;
                            button_QuayLai2.BackColor = Color.DarkGray;
                            button_TienLen.BackColor = Color.DarkGray;
                            button_TienLen2.BackColor = Color.DarkGray;
                        }
                        else
                        {
                            button_QuayLai.BackColor = Color.DarkGray;
                            button_QuayLai2.BackColor = Color.DarkGray;
                            button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                            button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                        }
                    }
                    else
                    {
                        button_QuayLai.BackColor = Color.DarkGray;
                        button_QuayLai2.BackColor = Color.DarkGray;
                        button_TienLen.BackColor = Color.DarkGray;
                        button_TienLen2.BackColor = Color.DarkGray;
                    }
                }
            }


        }
        private void button_XuatFile_Click(object sender, EventArgs e)
        {
            if (textbox_TimKiem.Texts.Trim().Length > 0)
            {
                dataGridView.DataSource = DataProvider.Instance.GetCurrentRecords2(-1, loaitk, combobox_TimKiemTheo.SelectedIndex, textbox_TimKiem.Texts);
            }

            if (textbox_TimKiem.Texts.Trim().Length < 0)
            {
                if (loaitk == 1)
                {
                    dataGridView.DataSource = NguoiDungDAO.Instance.getNguoiDung(1);
                }
                else
                {
                    dataGridView.DataSource = NguoiDungDAO.Instance.getNguoiDung(2);

                }
            }
            
            if (dataGridView.Rows.Count > 0)
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
                        saveDialog.FileName = "Danh_sach";

                        if (currentBtn == button_BinhThuong)
                        {
                            saveDialog.FileName = "Danh_sach_nguoi_dung";
                        }
                        else
                        {
                            saveDialog.FileName = "Danh_sach_idol";
                        }

                        if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            workbook.SaveAs(saveDialog.FileName);
                            app.Visible = true;
                            worksheet = workbook.ActiveSheet;
                            if (dataGridView.Rows[0].Cells[2].Value.ToString() == "1")
                            {
                                worksheet.Name = "Danh_sach_nguoi_dung";
                                worksheet = workbook.Sheets["Danh_sach_nguoi_dung"];
                            }
                            else
                            {
                                worksheet.Name = "Danh_sach_idol";
                                worksheet = workbook.Sheets["Danh_sach_idol"];
                            }

                            for (int i = 0; i < dataGridView.Columns.Count; i++)
                            {
                                if (i == 3 || i == dataGridView.Columns.Count - 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                                }

                            }
                            for (int i = 0; i < dataGridView.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView.Columns.Count; j++)
                                {
                                    if (j == 3 || j == dataGridView.Columns.Count - 1)
                                    {
                                        continue;
                                    }
                                    else
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
                            }
                            workbook.Save();
                            //MessageBox.Show("Export Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if(textbox_TimKiem.Texts.Trim().Length > 0)
                        {
                            dataGridView.DataSource = DataProvider.Instance.GetCurrentRecords2(CurrentPageIndexSearch, loaitk, combobox_TimKiemTheo.SelectedIndex, textbox_TimKiem.Texts);

                        }
                        else
                        {
                            if (loaitk == 1)
                            {
                                dataGridView.DataSource = DataProvider.Instance.GetCurrentRecords(1, 1);
                            }
                            else
                            {
                                dataGridView.DataSource = DataProvider.Instance.GetCurrentRecords(1, 2);

                            }
                        }
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
            }
            else
            {

            }


        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            vt = e.RowIndex;
            if (vt == -1)
            {
                return;
            }

            row = dataGridView.Rows[vt];
            OnOffBtn(true);
            if (!check_giaodien)
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_White;
            }
            else
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_Black;
            }

        }
        private void combobox_TimKiemTheo_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (textbox_TimKiem.Texts.Trim().Length > 0)
            {
                dataGridView.DataSource = DataProvider.Instance.GetCurrentRecords2(CurrentPageIndexSearch, loaitk, combobox_TimKiemTheo.SelectedIndex, textbox_TimKiem.Texts);
                CalculateTotalPagesSearch();
                if (TotalPageSearch > 0)
                {
                    if (TotalPageSearch == 1)
                    {
                        button_QuayLai.BackColor = Color.DarkGray;
                        button_QuayLai2.BackColor = Color.DarkGray;
                        button_TienLen.BackColor = Color.DarkGray;
                        button_TienLen2.BackColor = Color.DarkGray;
                    }
                    else
                    {
                        button_QuayLai.BackColor = Color.DarkGray;
                        button_QuayLai2.BackColor = Color.DarkGray;
                        button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                        button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    }
                }
                else
                {
                    button_QuayLai.BackColor = Color.DarkGray;
                    button_QuayLai2.BackColor = Color.DarkGray;
                    button_TienLen.BackColor = Color.DarkGray;
                    button_TienLen2.BackColor = Color.DarkGray;
                }
            }

        }
        private void dataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 0)
            {
                button_XuatFile.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
            }
            else
            {
                button_XuatFile.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
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
            panel_Bottom2.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            //Button
            button_BinhThuong.BackColor = CaiDatDAO.Instance.color_BG_White_02;
            button_Idol.BackColor = CaiDatDAO.Instance.color_BG_White_02;

            button_Tao.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_ChinhSua.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_NapTien.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Xoa.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_XuatFile.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            //Textbox
            textbox_TimKiem.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TimKiem.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TimKiem.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            //Combobox
            combobox_TimKiemTheo.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_TimKiemTheo.ListBackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_TimKiemTheo.ListTextColor = CaiDatDAO.Instance.color_Text_White_01;

            //DataGirdview
            dataGridView.BackgroundColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            dataGridView.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_White;
            dataGridView.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_White_01;

        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            panel_Bottom.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            panel_Bottom2.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            //Button
            button_BinhThuong.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            button_Idol.BackColor = CaiDatDAO.Instance.color_BG_Black_02;

            button_Tao.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_ChinhSua.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_NapTien.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Xoa.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_XuatFile.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            //Textbox
            textbox_TimKiem.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TimKiem.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TimKiem.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            //Combobox
            combobox_TimKiemTheo.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_TimKiemTheo.ListBackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_TimKiemTheo.ListTextColor = CaiDatDAO.Instance.color_Text_Black_01;

            //DataGirdview
            dataGridView.BackgroundColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            dataGridView.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_Black;
            dataGridView.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_Black_01;
        }
        public bool KiemTraNgonNgu(string userName)
        {
            string query = "SELECT * FROM dbo.CAI_DAT WHERE TAI_KHOAN = N'" + userName + "' AND NGON_NGU = 1";

            System.Data.DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Language_VI()
        {
            button_BinhThuong.Text = "Bình thường";
            button_Idol.Text = "Idol";
            button_Tao.Text = "Tạo";
            button_ChinhSua.Text = "Chỉnh sửa";
            button_NapTien.Text = "Nạp tiền";
            button_Xoa.Text = "Xóa";
            button_XuatFile.Text = "Xuất file";
            combobox_TimKiemTheo.Texts = "Tìm kiếm theo";
            textbox_TimKiem.PlaceholderText = "Tìm kiếm...";

            dataGridView.Columns[2].HeaderText = "Họ tên";
            dataGridView.Columns[3].HeaderText = "Giới tính";
            dataGridView.Columns[4].HeaderText = "Ngày sinh";
            dataGridView.Columns[6].HeaderText = "Nơi ở hiện tại";
            dataGridView.Columns[1].HeaderText = "Tài khoản";

            combobox_TimKiemTheo.Items.Add("Tài khoản");
            combobox_TimKiemTheo.Items.Add("Tên người dùng");
            combobox_TimKiemTheo.Items.Add("Địa điểm hẹn hò");
            combobox_TimKiemTheo.Items.Add("Nghề nghiệp");
            combobox_TimKiemTheo.Items.Add("Cung hoàng đạo");
        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vt != -1)
            {
                form_XemThongTin fxtt = new form_XemThongTin(row, tk);
                fxtt.ShowDialog();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            CalculateTotalPages();
            dataGridView.DataSource = DataProvider.Instance.GetCurrentRecords(CurrentPageIndex, 1);
            panel_Loading.Visible = false;
            timer1.Stop();
        }

        private void button_TienLen2_Click(object sender, EventArgs e)
        {
            vt = -1;
            dataGridView.ClearSelection();
            OnOffBtn(false);
            if (textbox_TimKiem.Texts.Trim().Length > 0 && combobox_TimKiemTheo.SelectedItem != null)
            {
                if (this.CurrentPageIndexSearch < this.TotalPageSearch)
                {
                    button_TienLen2.BackColor = Color.DarkGray;
                    this.CurrentPageIndexSearch = TotalPageSearch;
                    label_TrangHienTai.Text = CurrentPageIndexSearch.ToString();
                    this.dataGridView.DataSource =
              DataProvider.Instance.GetCurrentRecords2(this.TotalPageSearch, loaitk, combobox_TimKiemTheo.SelectedIndex, textbox_TimKiem.Texts);
                }
                if (CurrentPageIndexSearch == TotalPageSearch)
                {
                    button_TienLen2.BackColor = Color.DarkGray;
                    button_TienLen.BackColor = Color.DarkGray;
                }
                else
                {
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
                if (TotalPage != 0 && TotalPage != 1)
                {
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
            }
            else
            {
                if (this.CurrentPageIndex < this.TotalPage)
                {
                    button_TienLen2.BackColor = Color.DarkGray;
                    this.CurrentPageIndex = TotalPage;
                    label_TrangHienTai.Text = CurrentPageIndex.ToString();
                    this.dataGridView.DataSource =
                DataProvider.Instance.GetCurrentRecords(this.TotalPage, loaitk);
                }
                if (CurrentPageIndex == TotalPage)
                {
                    button_TienLen2.BackColor = Color.DarkGray;
                    button_TienLen.BackColor = Color.DarkGray;
                }
                else
                {
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
                if (TotalPage != 0 && TotalPage != 1)
                {
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
            }
        }

        private void button_QuayLai2_Click(object sender, EventArgs e)
        {
            vt = -1;
            dataGridView.ClearSelection();
            OnOffBtn(false);
            if (textbox_TimKiem.Texts.Trim().Length > 0 && combobox_TimKiemTheo.SelectedItem != null)
            {
                if (this.CurrentPageIndexSearch > 1)
                {
                    button_QuayLai2.BackColor = Color.DarkGray;
                    this.CurrentPageIndexSearch = 1;
                    label_TrangHienTai.Text = CurrentPageIndexSearch.ToString();
                    this.dataGridView.DataSource =
                DataProvider.Instance.GetCurrentRecords2(this.CurrentPageIndexSearch, loaitk, combobox_TimKiemTheo.SelectedIndex, textbox_TimKiem.Texts);
                }
                if (CurrentPageIndexSearch == 1)
                {
                    button_QuayLai2.BackColor = Color.DarkGray;
                    button_QuayLai.BackColor = Color.DarkGray;

                }
                else
                {
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
                if (TotalPageSearch != 0 && TotalPageSearch != 1)
                {
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
            }
            else
            {
                if (this.CurrentPageIndex > 1)
                {
                    button_QuayLai2.BackColor = Color.DarkGray;
                    this.CurrentPageIndex = 1;
                    label_TrangHienTai.Text = CurrentPageIndex.ToString();
                    this.dataGridView.DataSource =
                DataProvider.Instance.GetCurrentRecords(this.CurrentPageIndex, loaitk);
                }
                if (CurrentPageIndex == 1)
                {
                    button_QuayLai2.BackColor = Color.DarkGray;
                    button_QuayLai.BackColor = Color.DarkGray;

                }
                else
                {
                    button_QuayLai2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
                if (TotalPage != 0 && TotalPage != 1)
                {
                    button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                    button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;


                }
            }
        }

        public void Change_Language_EN()
        {
            button_BinhThuong.Text = "Normal";
            button_Idol.Text = "Idol";
            button_Tao.Text = "Create";
            button_ChinhSua.Text = "Edit";
            button_NapTien.Text = "Top up";
            button_Xoa.Text = "Delete";
            button_XuatFile.Text = "Export";
            combobox_TimKiemTheo.Texts = "Search by";
            textbox_TimKiem.PlaceholderText = "Search...";

            dataGridView.Columns[2].HeaderText = "Full name";
            dataGridView.Columns[3].HeaderText = "Gender";
            dataGridView.Columns[4].HeaderText = "Date of Birth";
            dataGridView.Columns[6].HeaderText = "Current Location";
            dataGridView.Columns[1].HeaderText = "Account";

            combobox_TimKiemTheo.Items.Add("Username");
            combobox_TimKiemTheo.Items.Add("Full name");
            combobox_TimKiemTheo.Items.Add("Dating place");
            combobox_TimKiemTheo.Items.Add("Career");
            combobox_TimKiemTheo.Items.Add("Zodiac");
        }
        public void UpdateColorApp()
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Tao.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_ChinhSua.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_NapTien.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_XuatFile.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Xoa.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_TimKiemTheo.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_TimKiemTheo.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}
