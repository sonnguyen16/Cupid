using Cupid.DAO;
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
    public partial class form_TaoKhuyenMai : Form
    {
        string tk;
        bool check_giaodien, check_ngonngu;
        public form_TaoKhuyenMai(string tk)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
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
            var f = (form_KhuyenMai)this.Owner;
            f.dataGridView.ClearSelection();
            f.vt = -1;
            f.OnOffBtn(false);
        }

        private void button_Tao_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                string day = dateTimePicker_NgayBatDau.Text;
                string hour = textbox_Gio1.Texts;
                string minute = textbox_Phut1.Texts;
                string day2 = dateTimePicker_NgayKetThuc.Text;
                string hour2 = textbox_Gio2.Texts;
                string minute2 = textbox_Phut2.Texts;
                if (textbox_Gio1.Texts.Trim().Equals("") && textbox_Phut1.Texts.Trim().Equals("") && textbox_Gio2.Texts.Trim().Equals("") && textbox_Phut2.Texts.Trim().Equals(""))
                {
                    hour = "00";
                    minute = "00";
                    hour2 = "00";
                    minute2 = "00";
                }
                DateTime dt1 = Convert.ToDateTime(day + " " + hour + ":" + minute);
                DateTime dt2 = Convert.ToDateTime(day2 + " " + hour2 + ":" + minute2);
                bool data = KhuyenMaiDAO.Instance.ThemKhuyenMai(textbox_TenKhuyenMai.Texts,textbox_NoiDungKhuyenMai.Texts,dt1,dt2);
                if (data)
                {
                    this.Close();
                    var f = (form_KhuyenMai)this.Owner;
                    f.dataGridView.DataSource = KhuyenMaiDAO.Instance.getKhuyenMai();
                    f.vt = -1;
                    f.OnOffBtn(false);
                }
                else
                {
                    if (!check_ngonngu)
                    {
                        label_Loi.Text = "Có lỗi xảy ra";
                    }
                    else
                    {
                        label_Loi.Text = "An error occurred";
                    }
                }
            }
           
        }

        private void form_TaoKhuyenMai_Load(object sender, EventArgs e)
        {
            
        }
        private bool KiemTra()
        {
            if (!check_ngonngu)
            {
                if (!KhuyenMaiDAO.Instance.KiemTraMaKM(textbox_TenKhuyenMai.Texts))
                {
                    label_Loi.Text = "Mã khuyến mãi đã tồn tại";
                    return false;
                }
                if (textbox_TenKhuyenMai.Texts.Trim().Equals(""))
                {
                    label_Loi.Text = "Bạn chưa nhập tên khuyến mãi";
                    return false;
                }
                if (textbox_NoiDungKhuyenMai.Texts.Trim().Equals(""))
                {
                    label_Loi.Text = "Bạn chưa nhập nội dung khuyến mãi";
                    return false;
                }
                int a = DateTime.Compare(dateTimePicker_NgayKetThuc.Value, dateTimePicker_NgayBatDau.Value);
                if (a < 0)
                {
                    label_Loi.Text = "Ngày không hợp lệ";
                    return false;
                }
                if (textbox_Gio1.Texts.Trim().Equals("") || textbox_Phut1.Texts.Trim().Equals("") || textbox_Gio2.Texts.Trim().Equals("") || textbox_Phut2.Texts.Trim().Equals(""))
                {
                    label_Loi.Text = "Vui lòng nhập đầy đủ giờ ";
                    return false;
                }
                else if (textbox_Gio1.Texts.Trim().Equals("") && textbox_Phut1.Texts.Trim().Equals("") && textbox_Gio2.Texts.Trim().Equals("") && textbox_Phut2.Texts.Trim().Equals(""))
                {

                }
                else
                {
                    int b = Convert.ToInt32(textbox_Gio1.Texts);
                    if (b >= 24 || b < 0)
                    {
                        label_Loi.Text = "Giờ bắt đầu ko hợp lệ";
                        return false;
                    }
                    int c = Convert.ToInt32(textbox_Phut1.Texts);
                    if (c > 60 || c < 0)
                    {
                        label_Loi.Text = "Phút bắt đầu ko hợp lệ";
                        return false;
                    }
                    int d = Convert.ToInt32(textbox_Gio2.Texts);
                    if (d >= 24 || d < 0)
                    {
                        label_Loi.Text = "Giờ kết thúc ko hợp lệ";
                        return false;
                    }
                    int e = Convert.ToInt32(textbox_Phut2.Texts);
                    if (e > 60 || e < 0)
                    {
                        label_Loi.Text = "Phút kết thúc ko hợp lệ";
                        return false;
                    }

                }
                if (dateTimePicker_NgayBatDau.Text == dateTimePicker_NgayKetThuc.Text)
                {
                    int f = Convert.ToInt16(textbox_Gio1.Texts);
                    int b = Convert.ToInt16(textbox_Gio2.Texts);
                    if (f > b)
                    {
                        label_Loi.Text = "Giờ không hợp lệ";
                        return false;
                    }
                }

            }
            else
            {
                if (!KhuyenMaiDAO.Instance.KiemTraMaKM(textbox_TenKhuyenMai.Texts))
                {
                    label_Loi.Text = "Promo code already exists";
                    return false;
                }
                if (textbox_TenKhuyenMai.Texts.Trim().Equals(""))
                {
                    label_Loi.Text = "You have not entered the promotion name";
                    return false;
                }
                if (textbox_NoiDungKhuyenMai.Texts.Trim().Equals(""))
                {
                    label_Loi.Text = "You have not entered promotional content";
                    return false;
                }
                int a = DateTime.Compare(dateTimePicker_NgayKetThuc.Value, dateTimePicker_NgayBatDau.Value);
                if (a < 0)
                {
                    label_Loi.Text = "Invalid date";
                    return false;
                }
                if (textbox_Gio1.Texts.Trim().Equals("") || textbox_Phut1.Texts.Trim().Equals("") || textbox_Gio2.Texts.Trim().Equals("") || textbox_Phut2.Texts.Trim().Equals(""))
                {
                    label_Loi.Text = "Please enter the time in full or leave it all blank";
                    return false;
                }
                else if (textbox_Gio1.Texts.Trim().Equals("") && textbox_Phut1.Texts.Trim().Equals("") && textbox_Gio2.Texts.Trim().Equals("") && textbox_Phut2.Texts.Trim().Equals(""))
                {

                }
                else
                {
                    int b = Convert.ToInt32(textbox_Gio1.Texts);
                    if (b >= 24 || b < 0)
                    {
                        label_Loi.Text = "Invalid start time";
                        return false;
                    }
                    int c = Convert.ToInt32(textbox_Phut1.Texts);
                    if (c > 60 || c < 0)
                    {
                        label_Loi.Text = "Invalid start minute";
                        return false;
                    }
                    int d = Convert.ToInt32(textbox_Gio2.Texts);
                    if (d >=  24 || d < 0)
                    {
                        label_Loi.Text = "Invalid end time";
                        return false;
                    }
                    int e = Convert.ToInt32(textbox_Phut2.Texts);
                    if (e > 60 || e < 0)
                    {
                        label_Loi.Text = "Invalid end minute";
                        return false;
                    }

                }
                if (dateTimePicker_NgayBatDau.Text == dateTimePicker_NgayKetThuc.Text)
                {
                    int f = Convert.ToInt16(textbox_Gio1.Texts);
                    int b = Convert.ToInt16(textbox_Gio2.Texts);
                    if (f > b)
                    {
                        label_Loi.Text = "Invalid time";
                        return false;
                    }
                }
            }

            return true;
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
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon;

            //Button
            button_Tao.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            //Textbox
            textbox_TenKhuyenMai.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TenKhuyenMai.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TenKhuyenMai.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NoiDungKhuyenMai.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_NoiDungKhuyenMai.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_NoiDungKhuyenMai.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Gio1.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Gio1.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Gio1.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Phut1.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Phut1.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Phut1.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Gio2.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Gio2.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Gio2.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Phut2.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Phut2.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Phut2.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            //DateTimePicker
            dateTimePicker_NgayBatDau.SkinColor = CaiDatDAO.Instance.color_BG_White_01;
            dateTimePicker_NgayKetThuc.SkinColor = CaiDatDAO.Instance.color_BG_White_01;

        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon_Black;

            //Button
            button_Tao.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            //Textbox
            textbox_TenKhuyenMai.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TenKhuyenMai.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TenKhuyenMai.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NoiDungKhuyenMai.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_NoiDungKhuyenMai.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_NoiDungKhuyenMai.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Gio1.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Gio1.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Gio1.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Phut1.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Phut1.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Phut1.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Gio2.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Gio2.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Gio2.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Phut2.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Phut2.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Phut2.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            //DateTimePicker
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
            //Label
            label_Title.Text = "Tạo khuyến mãi";
            label_Den.Text = "đến";
            //Textbox
            textbox_TenKhuyenMai.PlaceholderText = "Tên khuyến mãi";
            textbox_NoiDungKhuyenMai.PlaceholderText = "Nội dung khuyến mãi";
            textbox_Gio1.PlaceholderText = "Giờ";
            textbox_Phut1.PlaceholderText = "Phút";
            textbox_Gio2.PlaceholderText = "Giờ";
            textbox_Phut2.PlaceholderText = "Phút";
            //Button
            button_Tao.Text = "Tạo";
        }

        private void textbox_Gio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textbox_Phut1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

       

        private void textbox_Phut2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void textbox_Gio2_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
                {
                    e.Handled = true;
                }
        }
        
        public void Change_Language_EN()
        {

            //Label
            label_Title.Text = "Create a promotion";
            label_Den.Text = "to";
            //Textbox
            textbox_TenKhuyenMai.PlaceholderText = "Promotion name";
            textbox_NoiDungKhuyenMai.PlaceholderText = "Promo details";
            textbox_Gio1.PlaceholderText = "Hour";
            textbox_Phut1.PlaceholderText = "Min";
            textbox_Gio2.PlaceholderText = "Hour";
            textbox_Phut2.PlaceholderText = "Min";
            //Button
            button_Tao.Text = "Create";
        }
        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            dateTimePicker_NgayBatDau.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dateTimePicker_NgayKetThuc.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_TenKhuyenMai.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TenKhuyenMai.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_NoiDungKhuyenMai.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_NoiDungKhuyenMai.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_Gio1.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Gio1.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Gio2.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Gio2.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_Phut1.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Phut1.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Phut2.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Phut2.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_Tao.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}