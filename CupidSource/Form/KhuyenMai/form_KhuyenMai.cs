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
    public partial class form_KhuyenMai : Form
    {
        private Button_Custom currentBtn;
        private Panel leftBorderBtn;
        public int checkButton = 1;
        string tk;
        bool check_giaodien, check_ngonngu;
        public form_KhuyenMai(string tk)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(120, 3);
            panel_Top.Controls.Add(leftBorderBtn);
            dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
            OnOffBtn(false);
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
        }
        // Bỏ lọc trên header, mũi tên trỏ xuống
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
        }

        public void OnOffBtn(bool e)
        {
            if (e == true)
            {
                button_ChinhSua.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                button_Xoa.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            }
            else
            {
                button_ChinhSua.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
                button_Xoa.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
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
                dataGridView.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView.DefaultCellStyle.BackColor;

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
            if (checkButton == 1)
            {
                form_TaoKhuyenMai tkm = new form_TaoKhuyenMai(tk);
                tkm.Owner = this;
                tkm.ShowDialog();
            }
            else
            {
                form_TaoMaGiamGia tmgg = new form_TaoMaGiamGia(tk);
                tmgg.Owner = this;
                tmgg.ShowDialog();
            }
        }
        private void button_ChinhSua_Click(object sender, EventArgs e)
        {
            if (checkButton == 1)
            {
                if (vt == -1)
                {
                   
                }
                else
                {
                    form_ChinhSuaKhuyenMai cskm = new form_ChinhSuaKhuyenMai(row, tk);
                    cskm.Owner = this;
                    cskm.ShowDialog();
                }
            }
            else
            {
                if (vt == -1)
                {

                }
                else
                {
                    form_ChinhSuaMaGiamGia csmgg = new form_ChinhSuaMaGiamGia(row, tk);
                    csmgg.Owner = this;
                    csmgg.ShowDialog();
                }
            }
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (checkButton == 1)
            {
                if (vt == -1)
                {

                }
                else
                {
                    form_XoaKhuyenMai xkm = new form_XoaKhuyenMai(row.Cells[0].Value.ToString(), tk);
                    xkm.Owner = this;
                    xkm.ShowDialog();
                }
            }
            else
            {
                if (vt == -1)
                {

                }
                else
                {
                    form_XoaMaGiamGia xmgg = new form_XoaMaGiamGia(row.Cells[0].Value.ToString(), tk);
                    xmgg.Owner = this;
                    xmgg.ShowDialog();
                }
            }
        }
        public void button_KhuyenMai_Click(object sender, EventArgs e)
        {
            OnOffBtn(false);
            vt = -1;
            checkButton = 1;
            ActivateButton(sender);
            ActiveDataGridView(true);
            dataGridView.DataSource = KhuyenMaiDAO.Instance.getKhuyenMai();
        }
        public void button_MaGiamGia_Click(object sender, EventArgs e)
        {
            OnOffBtn(false);
            vt = -1;
            checkButton = 2;
            ActivateButton(sender);
            ActiveDataGridView(false);
            dataGridView1.DataSource = MaGiamGiaDAO.Instance.getMaGiamGia();
           
        }
        private void form_KhuyenMai_Load(object sender, EventArgs e)
        {
            ActiveDataGridView(true);
            dataGridView.DataSource = KhuyenMaiDAO.Instance.getKhuyenMai();
            ActivateButton(button_KhuyenMai);
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

        void ActiveDataGridView(bool v)
        {
            dataGridView.Visible = v;
            dataGridView1.Visible = !v;
        }

        public int vt = -1;
        DataGridViewRow row;
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
            vt = e.RowIndex;
            if (vt == -1)
            {
                return;
            }
            OnOffBtn(true);
            row = dataGridView.Rows[vt];
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
            vt = e.RowIndex;
            if (vt == -1)
            {
                return;
            }
            OnOffBtn(true);
            row = dataGridView1.Rows[vt];
        }
        private void textbox_TimKiem__TextChanged(object sender, EventArgs e)
        {
            if (textbox_TimKiem.Texts.Trim().Length > 0)
            {
                if (currentBtn == null || currentBtn == button_KhuyenMai)
                {
                    dataGridView.DataSource = KhuyenMaiDAO.Instance.getKhuyenMaiById(textbox_TimKiem.Texts);
                }
                else
                {
                    dataGridView1.DataSource = MaGiamGiaDAO.Instance.getMaGiamGiaById(textbox_TimKiem.Texts);

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

            //Button
            button_KhuyenMai.BackColor = CaiDatDAO.Instance.color_BG_White_02;
            button_MaGiamGia.BackColor = CaiDatDAO.Instance.color_BG_White_02;

            button_Tao.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_ChinhSua.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
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

            //DataGirdview
            dataGridView1.BackgroundColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView1.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            dataGridView1.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            dataGridView1.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView1.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_White_01;

        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            panel_Bottom.BackColor = CaiDatDAO.Instance.color_BG_Black_02;

            //Button
            button_KhuyenMai.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            button_MaGiamGia.BackColor = CaiDatDAO.Instance.color_BG_Black_02;

            button_Tao.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_ChinhSua.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
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

            //DataGirdview
            dataGridView1.BackgroundColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView1.GridColor = CaiDatDAO.Instance.color_Grid;

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            dataGridView1.RowHeadersDefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            dataGridView1.DefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            dataGridView1.DefaultCellStyle.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            dataGridView1.DefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_Gridview_Hover_Black;
            dataGridView1.DefaultCellStyle.SelectionForeColor = CaiDatDAO.Instance.color_Text_Black_01;
        }
        public bool KiemTraNgonNgu(string userName)
        {
            string query = "SELECT * FROM dbo.CAI_DAT WHERE TAI_KHOAN = N'" + userName + "' AND NGON_NGU = 1";

            System.Data.DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Language_VI()
        {
            button_KhuyenMai.Text = "Khuyến mãi";
            button_MaGiamGia.Text = "Mã giảm giá";
            button_Tao.Text = "Tạo";
            button_ChinhSua.Text = "Chỉnh sửa";
            button_Xoa.Text = "Xóa";
            textbox_TimKiem.PlaceholderText = "Tìm kiếm...";

            dataGridView.Columns[0].HeaderText = "Mã khuyến mãi";
            dataGridView.Columns[1].HeaderText = "Nội dung khuyến mãi";
            dataGridView.Columns[2].HeaderText = "Ngày bắt đầu";
            dataGridView.Columns[3].HeaderText = "Ngày kết thúc";

            dataGridView1.Columns[0].HeaderText = "Mã giảm giá";
            dataGridView1.Columns[1].HeaderText = "Giảm %";
            dataGridView1.Columns[2].HeaderText = "Ngày bắt đầu";
            dataGridView1.Columns[3].HeaderText = "Ngày kết thúc";
        }
        public void Change_Language_EN()
        {
            button_KhuyenMai.Text = "Promotion";
            button_MaGiamGia.Text = "Discount code";
            button_Tao.Text = "Create";
            button_ChinhSua.Text = "Edit";
            button_Xoa.Text = "Delete";
            textbox_TimKiem.PlaceholderText = "Search...";

            dataGridView.Columns[0].HeaderText = "Promo code";
            dataGridView.Columns[1].HeaderText = "Promo details";
            dataGridView.Columns[2].HeaderText = "Start date";
            dataGridView.Columns[3].HeaderText = "End date";

            dataGridView1.Columns[0].HeaderText = "Discount code";
            dataGridView1.Columns[1].HeaderText = "% discount";
            dataGridView1.Columns[2].HeaderText = "Start Date";
            dataGridView1.Columns[3].HeaderText = "End Date";
        }
        public void UpdateColorApp()
        {
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Tao.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_ChinhSua.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Xoa.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TimKiem.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}