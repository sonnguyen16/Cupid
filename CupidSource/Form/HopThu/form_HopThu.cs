using Cupid.DAO;
using Cupid.Toolbox_Custom;
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
    public partial class form_HopThu : Form
    {
        public Button_Custom currentBtn;
        private Panel leftBorderBtn;
        string tk;
        bool check_giaodien, check_ngonngu;
        public DataGridViewRow row;
        public form_HopThu(string tk)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(120, 3);
            panel_Top.Controls.Add(leftBorderBtn);
            this.tk = tk;
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
            currentBtn = button_ChuaXem;
            timer1.Start();
            timer2.Start();
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
            OnOffBtn(false);
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
                button_Xem.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                button_Xoa.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                if (currentBtn.Text != "Đã gửi" && currentBtn.Text != "Thư nháp" && currentBtn.Text != "Sent" && currentBtn.Text != "Draft")
                {
                    button_PhanHoi.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                }
            }
            else
            {
                button_Xem.BackColor = Color.DarkGray;
                button_Xoa.BackColor = Color.DarkGray;

                button_PhanHoi.BackColor = Color.DarkGray;

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
                leftBorderBtn.Location = new Point(currentBtn.Location.X, 47);
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
        private void button_Soan_Click(object sender, EventArgs e)
        {
            form_SoanTinNhan ttn = new form_SoanTinNhan(tk);
            ttn.Owner = this;
            ttn.ShowDialog();
        }
        private void button_Xem_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                if (row.Cells[6].Value.ToString() == "2")
                {
                    form_SoanTinNhan f = new form_SoanTinNhan(row.Cells[0].Value.ToString(),tk,row.Cells[2].Value.ToString(),row.Cells[3].Value.ToString(),row.Cells[4].Value.ToString());
                    f.Owner = this;
                    f.Show();
                }
                else
                {
                    form_XemTinNhan xtn = new form_XemTinNhan(row, tk);
                    if (currentBtn == null || currentBtn == button_ChuaXem || currentBtn == button_DaXem)
                    {
                        HopThuDAO.Instance.DaXem(row.Cells[0].Value.ToString());
                    }
                    xtn.Owner = this;
                    xtn.ShowDialog();
                }
               
                
            }
           
        }
        private void button_PhanHoi_Click(object sender, EventArgs e)
        {
            if (currentBtn == null || currentBtn == button_ChuaXem || currentBtn == button_DaXem)
            {
                if (vt != -1)
                {
                    form_PhanHoiTinNhan phtn = new form_PhanHoiTinNhan(row,tk);
                    phtn.Owner = this;
                    phtn.ShowDialog();
                }
            }
           
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (vt != -1)
            {
                form_XoaTinNhan xtn = new form_XoaTinNhan(row.Cells[0].Value.ToString(), tk);
                xtn.Owner = this;
                xtn.ShowDialog();
            }
           
        }
        public void button_ChuaXem_Click(object sender, EventArgs e)
        {
            OnOffBtn(false);
            vt = -1;
            ActivateButton(sender);
            dataGridView.Columns[1].Visible = true;
            dataGridView.Columns[2].Visible = false;
            dataGridView.DataSource = HopThuDAO.Instance.getThuDaNhan(tk,0);
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
        }
        public void button_DaXem_Click(object sender, EventArgs e)
        {
            OnOffBtn(false);
            vt = -1;
            ActivateButton(sender);
            dataGridView.Columns[1].Visible = true;
            dataGridView.Columns[2].Visible = false;
            dataGridView.DataSource = HopThuDAO.Instance.getThuDaNhan(tk,1);
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
        }
        public void button_DaGui_Click(object sender, EventArgs e)
        {
            vt = -1;
            OnOffBtn(false);
            ActivateButton(sender);
            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[2].Visible = true;
            dataGridView.DataSource = HopThuDAO.Instance.getThuDaGui(tk);
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
        }
        public void button_ThuNhap_Click(object sender, EventArgs e)
        {
            vt = -1;
            ActivateButton(sender);
            OnOffBtn(false);
            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[2].Visible = true;
            dataGridView.DataSource = HopThuDAO.Instance.getThuNhap(tk);
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
        }
        private void form_HopThu_Load(object sender, EventArgs e)
        {
            ActivateButton(button_ChuaXem);
            dataGridView.Columns[1].Visible = true;
            dataGridView.Columns[2].Visible = false;
            dataGridView.DataSource = HopThuDAO.Instance.getThuDaNhan(tk,0);
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
        private void textbox_TimKiem__TextChanged(object sender, EventArgs e)
        {
            if (currentBtn == button_ChuaXem || currentBtn == null)
            {
                dataGridView.DataSource = HopThuDAO.Instance.getThuChuaXemTheoTk(textbox_TimKiem.Texts, tk);
            }
            else if (currentBtn == button_DaXem)
            {
                dataGridView.DataSource = HopThuDAO.Instance.getThuDaXemTheoTk(textbox_TimKiem.Texts, tk);

            }
            else if (currentBtn == button_DaGui)
            {
                dataGridView.DataSource = HopThuDAO.Instance.getThuDaGuiTheoTk(tk, textbox_TimKiem.Texts);

            }
            else
            {
                dataGridView.DataSource = HopThuDAO.Instance.getThuNhap2(tk,textbox_TimKiem.Texts);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            var f = (form_Chinh)this.Owner;
            f.LoadThongBao1();
            if (f.ThuMoi == true)
            {
                if (currentBtn == button_ChuaXem || currentBtn == null)
                {
                    dataGridView.DataSource = HopThuDAO.Instance.getThuDaNhan(tk, 0);
                    timer1.Stop();
                }
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            var f = (form_Chinh)this.Owner;
            f.LoadThongBao1();
            if (f.ThuMoi == false)
            {
                timer1.Start();
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
            //Button
            button_ChuaXem.BackColor = CaiDatDAO.Instance.color_BG_White_02;
            button_DaXem.BackColor = CaiDatDAO.Instance.color_BG_White_02;
            button_DaGui.BackColor = CaiDatDAO.Instance.color_BG_White_02;
            button_ThuNhap.BackColor = CaiDatDAO.Instance.color_BG_White_02;

            button_Soan.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Xem.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_PhanHoi.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Xoa.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            //Textbox
            textbox_TimKiem.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TimKiem.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TimKiem.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

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
            //Button
            button_ChuaXem.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            button_DaXem.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            button_DaGui.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            button_ThuNhap.BackColor = CaiDatDAO.Instance.color_BG_Black_02;

            button_Soan.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Xem.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_PhanHoi.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Xoa.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            //Textbox
            textbox_TimKiem.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TimKiem.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TimKiem.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

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
            button_ChuaXem.Text = "Chưa xem";
            button_DaXem.Text = "Đã Xem";
            button_DaGui.Text = "Đã gửi";
            button_ThuNhap.Text = "Thư nháp";
            button_Soan.Text = "Soạn";
            button_Xem.Text = "Xem";
            button_PhanHoi.Text = "Phản hồi";
            button_Xoa.Text = "Xóa";
            textbox_TimKiem.PlaceholderText = "Tìm kiếm...";

            dataGridView.Columns[0].HeaderText = "Mã";
            dataGridView.Columns[1].HeaderText = "Người gửi";
            dataGridView.Columns[2].HeaderText = "Người nhận";
            dataGridView.Columns[3].HeaderText = "Chủ đề";
            dataGridView.Columns[4].HeaderText = "Nội dung";
            dataGridView.Columns[5].HeaderText = "Ngày gửi";
            dataGridView.Columns[6].HeaderText = "Trạng thái";
        }
        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vt != -1)
            {
                if (row.Cells[6].Value.ToString() == "2")
                {
                    form_SoanTinNhan f = new form_SoanTinNhan(row.Cells[0].Value.ToString(), tk, row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString());
                    f.Owner = this;
                    f.Show();
                }
                else
                {
                    form_XemTinNhan xtn = new form_XemTinNhan(row, tk);
                    if (currentBtn == null || currentBtn == button_ChuaXem || currentBtn == button_DaXem)
                    {
                        HopThuDAO.Instance.DaXem(row.Cells[0].Value.ToString());
                    }
                    xtn.Owner = this;
                    xtn.ShowDialog();
                }
            }

        }

        private void dataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        public void Change_Language_EN()
        {
            button_ChuaXem.Text = "Unread";
            button_DaXem.Text = "Read";
            button_DaGui.Text = "Sent";
            button_ThuNhap.Text = "Draft";
            button_Soan.Text = "Compose";
            button_Xem.Text = "Read";
            button_PhanHoi.Text = "Reply";
            button_Xoa.Text = "Delete";
            textbox_TimKiem.PlaceholderText = "Search...";

            dataGridView.Columns[0].HeaderText = "ID";
            dataGridView.Columns[1].HeaderText = "Sender";
            dataGridView.Columns[2].HeaderText = "Recipient";
            dataGridView.Columns[3].HeaderText = "Subject";
            dataGridView.Columns[4].HeaderText = "Messages";
            dataGridView.Columns[5].HeaderText = "Date sent";
            dataGridView.Columns[6].HeaderText = "Status";
        }
        public void UpdateColorApp()
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Soan.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Xem.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_PhanHoi.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Xoa.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}