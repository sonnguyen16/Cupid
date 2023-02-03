using Cupid.DAO;
using Cupid.Toolbox_Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cupid
{
    public partial class form_BaoCao : Form
    {
        public Button_Custom currentBtn;
        private Panel leftBorderBtn;
        public object btn;
        public EventArgs ea;
        public int vt = -1;
        public DataGridViewRow row;
        public string tk;
        bool check_giaodien, check_ngonngu;
        public form_BaoCao(string tk)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(120, 3);
            panel_Top.Controls.Add(leftBorderBtn);
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
            this.tk = tk;
            currentBtn = this.button_ChuaXem;
            timer1.Start();
            timer2.Start();
            dataGridView.ClearSelection();
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
                button_PhanHoi.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            }
            else
            {
                button_Xem.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
                button_Xoa.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
                button_PhanHoi.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
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
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {

            }
            else
            {
                form_XoaBaoCao xddki = new form_XoaBaoCao(tk);
                xddki.Owner = this;
                xddki.ShowDialog();
            }

        }

        private void button_Xem_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {

            }
            else
            {
                form_XemBaoCao xddki = new form_XemBaoCao(tk);
                xddki.Owner = this;
                xddki.ShowDialog();
            }

        }

        private void button_PhanHoi_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {

            }
            else
            {
                form_PhanHoiBaoCao phddki = new form_PhanHoiBaoCao(this.row, this.tk);
                phddki.Owner = this;
                phddki.ShowDialog();
            }

        }
        public void button_ChuaXem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OnOffBtn(false);
            vt = -1;
            this.btn = sender;
            this.ea = e;
            dataGridView.DataSource = BaoCaoDAO.Instance.getDon(true);
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
        }
        public void button_DaXem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OnOffBtn(false);
            vt = -1;
            this.btn = sender;
            this.ea = e;
            dataGridView.DataSource = BaoCaoDAO.Instance.getDon(false);
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
        }

        private void form_BaoCao_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = BaoCaoDAO.Instance.getDon(true);
            ActivateButton(button_ChuaXem);
            if (!check_giaodien)
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_White_02;
            }
            else
            {
                dataGridView.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_Black_02;
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(228, 230, 233);
            vt = e.RowIndex;
            if (vt == -1)
            {
                return;
            }
            OnOffBtn(true);
            row = dataGridView.Rows[vt];
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

            if (textbox_TimKiem.Texts.Trim().Length > 0)
            {
                if (currentBtn == button_ChuaXem)
                {
                    dataGridView.DataSource = BaoCaoDAO.Instance.getDonById(textbox_TimKiem.Texts, true);
                }
                else
                {
                    dataGridView.DataSource = BaoCaoDAO.Instance.getDonById(textbox_TimKiem.Texts, false);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var f = (form_Chinh)this.Owner;
            f.LoadThongBao2();
            if (f.BaoMoi == true)
            {
                if (currentBtn == button_ChuaXem || currentBtn == null)
                {
                    dataGridView.DataSource = BaoCaoDAO.Instance.getDon(true);
                    timer1.Stop();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var f = (form_Chinh)this.Owner;
            f.LoadThongBao2();
            if (f.BaoMoi == false)
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
            button_Xem.Text = "Xem";
            button_PhanHoi.Text = "Phản hồi";
            button_Xoa.Text = "Xóa";
            textbox_TimKiem.PlaceholderText = "Tìm kiếm...";

            dataGridView.Columns[0].HeaderText = "Mã báo cáo";
            dataGridView.Columns[1].HeaderText = "Tài khoản báo cáo";
            dataGridView.Columns[2].HeaderText = "Tài khoản bị báo cáo";
            dataGridView.Columns[3].HeaderText = "Chủ đề";
            dataGridView.Columns[4].HeaderText = "Nội dung";
            dataGridView.Columns[5].HeaderText = "Ngày gửi";
            dataGridView.Columns[6].HeaderText = "Trạng thái";
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (vt == -1)
            {

            }
            else
            {
                form_XemBaoCao xddki = new form_XemBaoCao(tk);
                xddki.Owner = this;
                xddki.ShowDialog();
            }
        }

        public void Change_Language_EN()
        {
            button_ChuaXem.Text = "Not Viewed";
            button_DaXem.Text = "Viewed";
            button_Xem.Text = "View";
            button_PhanHoi.Text = "Feedback";
            button_Xoa.Text = "Delete";
            textbox_TimKiem.PlaceholderText = "Search...";

            dataGridView.Columns[0].HeaderText = "Report ID";
            dataGridView.Columns[1].HeaderText = "Report Username";
            dataGridView.Columns[2].HeaderText = "Reported Username";
            dataGridView.Columns[3].HeaderText = "Subject";
            dataGridView.Columns[4].HeaderText = "Content";
            dataGridView.Columns[5].HeaderText = "Date sent";
            dataGridView.Columns[6].HeaderText = "Status";
        }

        public void UpdateColorApp()
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Xem.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_PhanHoi.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Xoa.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}
