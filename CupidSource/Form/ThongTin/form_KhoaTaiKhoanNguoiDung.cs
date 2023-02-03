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
    public partial class form_KhoaTaiKhoanNguoiDung : Form
    {
        string tk;
        bool check_giaodien, check_ngonngu;
        public form_KhoaTaiKhoanNguoiDung(string tk)
        {
            InitializeComponent();
            this.tk = tk;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            label_Loi.ResetText();
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
        }
        private void form_KhoaTaiKhoanNguoiDung_Load(object sender, EventArgs e)
        {
            
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
            var f = (form_ChinhSuaTaiKhoanNguoiDung)this.Owner;
            f.pictureBox_Lock.IconChar = FontAwesome.Sharp.IconChar.Unlock;
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
            var f = (form_ChinhSuaTaiKhoanNguoiDung)this.Owner;
            f.pictureBox_Lock.IconChar = FontAwesome.Sharp.IconChar.Unlock;
        }

        private void button_DongY_Click(object sender, EventArgs e)
        {
            var f = (form_ChinhSuaTaiKhoanNguoiDung)this.Owner;

            if (combobox_ThoiGianKhoa.SelectedItem == null || combobox_LyDo.SelectedItem == null)
            {
                if (!check_ngonngu)
                {
                    label_Loi.Text = "Vui lòng chọn" + Environment.NewLine + "Đầy đủ dữ liệu";
                }
                else
                {
                    label_Loi.Text = "Please choose" + Environment.NewLine + "Full data";
                }
            }
            else
            {
                string day = combobox_ThoiGianKhoa.SelectedItem.ToString();

                string[] arr = day.Split(' ');

                int daylock = 0;

                if (day == "Vĩnh viễn" || day == "Forever")
                {
                    daylock = 36500;
                }
                else
                {
                    daylock = Convert.ToInt32(arr[0]);
                }


                bool a = NguoiDungDAO.Instance.KhoaNguoiDung(f.textbox_TaiKhoan.Texts, daylock,combobox_LyDo.Texts);
                if (a == false)
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
                LichSuHoatDongDAO.Instance.insertLSHD(this.tk, 5, "Khóa tài khoản " + f.textbox_TaiKhoan.Texts + " " + combobox_ThoiGianKhoa.Texts);

                f.SoNgayKhoaConLai();
               

                this.Close();
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
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon;

            //Combobox
            combobox_ThoiGianKhoa.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_ThoiGianKhoa.ListBackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_ThoiGianKhoa.ListTextColor = CaiDatDAO.Instance.color_Text_White_01;

            combobox_LyDo.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_LyDo.ListBackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_LyDo.ListTextColor = CaiDatDAO.Instance.color_Text_White_01;

            //Button
            button_DongY.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Huy.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon_Black;

            //Combobox
            combobox_ThoiGianKhoa.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_ThoiGianKhoa.ListBackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_ThoiGianKhoa.ListTextColor = CaiDatDAO.Instance.color_Text_Black_01;

            combobox_LyDo.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_LyDo.ListBackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_LyDo.ListTextColor = CaiDatDAO.Instance.color_Text_Black_01;
            //Button
            button_DongY.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Huy.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

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
            label_Title.Text = "Thông báo";
            //Textbox
            label_NoiDung.Text = "Bạn có chắc chắn muốn khóa tài khoản này?";
            //Combobox
            combobox_ThoiGianKhoa.Texts = "Thời gian khóa";
            combobox_LyDo.Texts = "Lý do vi phạm";
            //Button
            button_DongY.Text = "Đồng ý";
            button_Huy.Text = "Hủy";

            combobox_ThoiGianKhoa.Items.Add("1 ngày");
            combobox_ThoiGianKhoa.Items.Add("3 ngày");
            combobox_ThoiGianKhoa.Items.Add("7 ngày");
            combobox_ThoiGianKhoa.Items.Add("14 ngày");
            combobox_ThoiGianKhoa.Items.Add("30 ngày");
            combobox_ThoiGianKhoa.Items.Add("60 ngày");
            combobox_ThoiGianKhoa.Items.Add("90 ngày");
            combobox_ThoiGianKhoa.Items.Add("180 ngày");
            combobox_ThoiGianKhoa.Items.Add("365 ngày");
            combobox_ThoiGianKhoa.Items.Add("Vĩnh viễn");

            combobox_LyDo.Items.Add("Khỏa thân");
            combobox_LyDo.Items.Add("Dưới 16 tuổi");
            combobox_LyDo.Items.Add("Quấy rối");
            combobox_LyDo.Items.Add("Bạo lực");
            combobox_LyDo.Items.Add("Tự tử/ Tự gây thương tích");
            combobox_LyDo.Items.Add("Thông tin sai sự thật");
            combobox_LyDo.Items.Add("Spam");
            combobox_LyDo.Items.Add("Bán hàng trái phép");
            combobox_LyDo.Items.Add("Ngôn từ gây thù ghét");
            combobox_LyDo.Items.Add("Khủng bố");
            combobox_LyDo.Items.Add("Nội dung gớm ghiếc");
            combobox_LyDo.Items.Add("Vấn đề khác");
        }

        public void Change_Language_EN()
        {
            //Label
            label_Title.Text = "Notification";
            //Textbox
            label_NoiDung.Text = "Are you sure you want to block this account?";
            //Combo box
            combobox_ThoiGianKhoa.Texts = "Lock Time";
            combobox_LyDo.Texts = "Reason for violation";
            //Button
            button_DongY.Text = "Ok";
            button_Huy.Text = "Cancel";

            combobox_ThoiGianKhoa.Items.Add("1 day");
            combobox_ThoiGianKhoa.Items.Add("3 days");
            combobox_ThoiGianKhoa.Items.Add("7 days");
            combobox_ThoiGianKhoa.Items.Add("14 days");
            combobox_ThoiGianKhoa.Items.Add("30 days");
            combobox_ThoiGianKhoa.Items.Add("60 days");
            combobox_ThoiGianKhoa.Items.Add("90 days");
            combobox_ThoiGianKhoa.Items.Add("180 days");
            combobox_ThoiGianKhoa.Items.Add("365 days");
            combobox_ThoiGianKhoa.Items.Add("Forever");

            combobox_LyDo.Items.Add("Nude/Sexy");
            combobox_LyDo.Items.Add("Under 16");
            combobox_LyDo.Items.Add("Harass");
            combobox_LyDo.Items.Add("Violence");
            combobox_LyDo.Items.Add("Suicide/Self-harm and dangerous acts");
            combobox_LyDo.Items.Add("Incorrect information");
            combobox_LyDo.Items.Add("Spam");
            combobox_LyDo.Items.Add("illegal trade");
            combobox_LyDo.Items.Add("Verbal abuse");
            combobox_LyDo.Items.Add("Terrorism");
            combobox_LyDo.Items.Add("NSFW contents");
            combobox_LyDo.Items.Add("Other");
        }
        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            button_DongY.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            pictureBox_IconThongBao.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            combobox_ThoiGianKhoa.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_LyDo.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            combobox_ThoiGianKhoa.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_LyDo.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}