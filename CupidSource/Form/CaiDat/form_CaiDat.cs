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
    public partial class form_CaiDat : Form
    {
        string tk;
        int colorApp;
        public form_CaiDat(string tk)
        {
            InitializeComponent();
            this.tk = tk;
        }
        private void form_CaiDat_Load(object sender, EventArgs e)
        {
            // Giao diện
            if(KiemTraGiaoDien(tk))
            {
                Change_Color_Black();
                radioButton_Bat.Checked = true;
            }
            else
            {
                Change_Color_White();
                radioButton_Tat.Checked = true;
            }
            // Ngôn ngữ
            if(KiemTraNgonNgu(tk))
            {
                Change_Language_EN();
                radioButton_English.Checked = true;
            }
            else
            {
                Change_Language_VI();
                radioButton_TiengViet.Checked = true;
            }
            //Color App
            colorApp = KiemTraColorApp(tk);
            if (colorApp == 0)
            {
                radioButton_Blue.Checked = true;
            }
            else if (colorApp == 1)
            {
                radioButton_Red.Checked = true;
            }
            if (colorApp == 2)
            {
                radioButton_Green.Checked = true;
            }
            if (colorApp == 3)
            {
                radioButton_Orange.Checked = true;
            }
            if (colorApp == 4)
            {
                radioButton_Yellow.Checked = true;
            }
            if (colorApp == 5)
            {
                radioButton_BlueDark.Checked = true;
            }
            if (colorApp == 6)
            {
                radioButton_Violet.Checked = true;
            }
            if (colorApp == 7)
            {
                radioButton_Pink.Checked = true;
            }
            if (colorApp == 8)
            {
                radioButton_Brown.Checked = true;
            }
            if (colorApp == 9)
            {
                radioButton_Grey.Checked = true;
            }
        }
        // Giao diện
        public void CapNhatGiaoDien()
        {
            if (radioButton_Bat.Checked)
            {
                CaiDatDAO.Instance.CapNhatGiaoDien(tk, 1);
            }
            else
            {
                CaiDatDAO.Instance.CapNhatGiaoDien(tk, 0);
            }
        }
        public bool KiemTraGiaoDien(string userName)
        {
            string query = "SELECT * FROM dbo.CAI_DAT WHERE TAI_KHOAN = N'" + userName + "' AND GIAO_DIEN = 1";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Color_White()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            panel_Bottom.BackColor = CaiDatDAO.Instance.color_BG_White_02;
            //Textbox
            textbox_MatKhauHienTai.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_MatKhauHienTai.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_MatKhauHienTai.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_MatKhauMoi1.BackColor = CaiDatDAO.Instance.color_BG_White_01;           
            textbox_MatKhauMoi1.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_MatKhauMoi1.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_MatKhauMoi2.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_MatKhauMoi2.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_MatKhauMoi2.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            //Label
            label_NgonNgu.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            label_CheDoToi.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            label_MatKhau.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            label_MauChuDao.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            //Button
            button_CapNhat.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            //Form Chính
            (this.Owner as form_Chinh).button_ThongTin.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_KhuyenMai.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_BangXepHang.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_HopThu.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_DonDangKyIdol.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_BaoCao.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_ThongKe.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_LichSuHoatDong.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_LichSuGiaoDich.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_CaiDat.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_DangXuat.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            (this.Owner as form_Chinh).button_ThongTin.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_KhuyenMai.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_BangXepHang.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_HopThu.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_DonDangKyIdol.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_BaoCao.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_ThongKe.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_LichSuHoatDong.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_LichSuGiaoDich.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_CaiDat.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_DangXuat.IconColor = CaiDatDAO.Instance.color_Text_Black_01;

            (this.Owner as form_Chinh).label_Select.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).pictureBox_Select.IconColor = CaiDatDAO.Instance.color_Text_Black_01;

            (this.Owner as form_Chinh).button_Close.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_Maximize.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            (this.Owner as form_Chinh).button_Minimize.IconColor = CaiDatDAO.Instance.color_Text_Black_01;

            (this.Owner as form_Chinh).leftBorderBtn.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            (this.Owner as form_Chinh).pictureBox_Logo.Image = Cupid.Properties.Resources.Logo;
            if (!(this.Owner as form_Chinh).check_TabMenu)
            {
                (this.Owner as form_Chinh).pictureBox_Logo.Image = Cupid.Properties.Resources.Logo;
            }
            else
            {
                (this.Owner as form_Chinh).pictureBox_Logo.Image = Cupid.Properties.Resources.Icon;
            }
            (this.Owner as form_Chinh).pictureBox_TabMenu.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            panel_Bottom.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            //Textbox
            textbox_MatKhauHienTai.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_MatKhauMoi1.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_MatKhauMoi2.BackColor = CaiDatDAO.Instance.color_BG_Black_01;

            textbox_MatKhauHienTai.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_MatKhauMoi1.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_MatKhauMoi2.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;

            textbox_MatKhauHienTai.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;
            textbox_MatKhauMoi1.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;
            textbox_MatKhauMoi2.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            //Label
            label_NgonNgu.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            label_CheDoToi.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            label_MatKhau.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            label_MauChuDao.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            //Button
            button_CapNhat.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            //Form chính
            (this.Owner as form_Chinh).button_ThongTin.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_KhuyenMai.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_BangXepHang.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_HopThu.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_DonDangKyIdol.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_BaoCao.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_ThongKe.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_LichSuHoatDong.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_LichSuGiaoDich.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_CaiDat.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_DangXuat.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            (this.Owner as form_Chinh).button_ThongTin.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_KhuyenMai.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_BangXepHang.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_HopThu.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_DonDangKyIdol.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_BaoCao.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_ThongKe.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_LichSuHoatDong.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_LichSuGiaoDich.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_CaiDat.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_DangXuat.IconColor = CaiDatDAO.Instance.color_Text_White_01;

            (this.Owner as form_Chinh).label_Select.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).pictureBox_Select.IconColor = CaiDatDAO.Instance.color_Text_White_01;

            (this.Owner as form_Chinh).button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_Maximize.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            (this.Owner as form_Chinh).button_Minimize.IconColor = CaiDatDAO.Instance.color_Text_White_01;

            (this.Owner as form_Chinh).leftBorderBtn.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            if (!(this.Owner as form_Chinh).check_TabMenu)
            {
                (this.Owner as form_Chinh).pictureBox_Logo.Image = Cupid.Properties.Resources.Logo_Black;
            }
            else
            {
                (this.Owner as form_Chinh).pictureBox_Logo.Image = Cupid.Properties.Resources.Icon_Black;
            }
            (this.Owner as form_Chinh).pictureBox_TabMenu.IconColor = CaiDatDAO.Instance.color_Text_White_01;
        }
        // Ngôn ngữ
        public void CapNhatNgonNgu()
        {
            if (radioButton_English.Checked)
            {
                CaiDatDAO.Instance.CapNhatNgonNgu(tk, 1);
            }
            else
            {
                CaiDatDAO.Instance.CapNhatNgonNgu(tk, 0);
            }
        }
        public bool KiemTraNgonNgu(string userName)
        {
            string query = "SELECT * FROM dbo.CAI_DAT WHERE TAI_KHOAN = N'" + userName + "' AND NGON_NGU = 1";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Language_VI()
        {
            // Label
            label_NgonNgu.Text = "Ngôn ngữ";
            label_NgonNguNoiDung.Text = "Hãy điều chỉnh ngôn ngữ phù hợp với bạn.";
            label_CheDoToi.Text = "Chế độ tối";
            label_CheDoToiNoiDung.Text = "Điều chỉnh giao diện của Cupid để giảm độ chói và cho đôi mắt được nghỉ ngơi.";
            label_MatKhau.Text = "Mật khẩu";
            label_NoiDungMatKhau.Text = "Đổi mật khẩu thường xuyên sẽ giúp bạn bảo mật tài khoản tốt hơn.";
            // Radio Button
            radioButton_Bat.Text = "Bật";
            radioButton_Tat.Text = "Tắt";
            radioButton_TiengViet.Text = "Tiếng Việt";
            radioButton_English.Text = "English";
            // Textbox
            textbox_MatKhauHienTai.PlaceholderText = "Nhập mật khẩu cũ";
            textbox_MatKhauMoi1.PlaceholderText = "Nhập mật khẩu mới";
            textbox_MatKhauMoi2.PlaceholderText = "Nhập lại mật khẩu mới";
            //Button
            button_CapNhat.Text = "Cập nhật";

            //Form Chính
            (this.Owner as form_Chinh).button_ThongTin.Text = "Thông tin";
            (this.Owner as form_Chinh).button_KhuyenMai.Text = "Khuyến mãi";
            (this.Owner as form_Chinh).button_BangXepHang.Text = "Bảng xếp hạng";
            (this.Owner as form_Chinh).button_HopThu.Text = "Hộp thư";
            (this.Owner as form_Chinh).button_DonDangKyIdol.Text = "Đơn đăng ký Idol";
            (this.Owner as form_Chinh).button_BaoCao.Text = "Báo cáo";
            (this.Owner as form_Chinh).button_ThongKe.Text = "Thống kê";
            (this.Owner as form_Chinh).button_LichSuHoatDong.Text = "Lịch sử hoạt động";
            (this.Owner as form_Chinh).button_LichSuGiaoDich.Text = "Lịch sử giao dịch";
            (this.Owner as form_Chinh).button_CaiDat.Text = "Cài đặt";
            (this.Owner as form_Chinh).button_DangXuat.Text = "Đăng xuất";

            (this.Owner as form_Chinh).label_Select.Text = "Cài đặt";
        }
        public void Change_Language_EN()
        {
            // Label
            label_NgonNgu.Text = "Language";
            label_NgonNguNoiDung.Text = "Adjust Cupid’s language to suit you.";
            label_CheDoToi.Text = "Dark mode";
            label_CheDoToiNoiDung.Text = "Adjust Cupid’s interface to reduce brightness and make your eyes feel better.";
            label_MatKhau.Text = "Password";
            label_NoiDungMatKhau.Text = "Change your password often will make your account more safer.";
            // Radio Button
            radioButton_Bat.Text = "On";
            radioButton_Tat.Text = "Off";
            radioButton_TiengViet.Text = "Tiếng Việt";
            radioButton_English.Text = "English";
            // Textbox
            textbox_MatKhauHienTai.PlaceholderText = "Enter your current password";
            textbox_MatKhauMoi1.PlaceholderText = "Enter a new password";
            textbox_MatKhauMoi2.PlaceholderText = "Enter your new password again";
            //Button
            button_CapNhat.Text = "Update";

            //Form Chính
            (this.Owner as form_Chinh).button_ThongTin.Text = "Information";
            (this.Owner as form_Chinh).button_KhuyenMai.Text = "Promotion";
            (this.Owner as form_Chinh).button_BangXepHang.Text = "Leaderboard";
            (this.Owner as form_Chinh).button_HopThu.Text = "Mailbox";
            (this.Owner as form_Chinh).button_DonDangKyIdol.Text = "Idol registration";
            (this.Owner as form_Chinh).button_BaoCao.Text = "Report";
            (this.Owner as form_Chinh).button_ThongKe.Text = "Statistical";
            (this.Owner as form_Chinh).button_LichSuHoatDong.Text = "Operation history";
            (this.Owner as form_Chinh).button_LichSuGiaoDich.Text = "Transaction history";
            (this.Owner as form_Chinh).button_CaiDat.Text = "Settings";
            (this.Owner as form_Chinh).button_DangXuat.Text = "Log Out";

            (this.Owner as form_Chinh).label_Select.Text = "Settings";
        }
        // Mật khẩu
        public void CapNhatMatKhau()
        {
            if (radioButton_TiengViet.Checked == true)
            {
                if (textbox_MatKhauHienTai.Texts == "" && textbox_MatKhauMoi1.Texts == "" && textbox_MatKhauMoi2.Texts == "")
                {
                    label_Loi.Text = "";
                }
                else if (textbox_MatKhauHienTai.Texts.Trim().Length > 0 || textbox_MatKhauMoi1.Texts.Trim().Length > 0 || textbox_MatKhauMoi2.Texts.Length > 0)
                {
                    label_Loi.ForeColor = CaiDatDAO.Instance.color_Text_Red;
                    if (textbox_MatKhauMoi1.Texts == "" || textbox_MatKhauMoi2.Texts == "")
                    {
                        label_Loi.Text = "Mật khẩu không được để trống";
                    }
                    else if (textbox_MatKhauMoi1.Texts != textbox_MatKhauMoi2.Texts)
                    {
                        label_Loi.Text = "Mật khẩu mới không trùng khớp";
                    }
                    else
                    {
                        if (!KiemTraMatKhau(tk, textbox_MatKhauHienTai.Texts))
                        {
                            label_Loi.Text = "Mật khẩu cũ không chính xác";
                        }
                        else
                        {
                            if (textbox_MatKhauHienTai.Texts == textbox_MatKhauMoi1.Texts)
                            {
                                label_Loi.Text = "Mật khẩu mới không được giống mật khẩu cũ";
                            }
                            else
                            {
                                if (!NguoiDungDAO.Instance.DoiMatKhau(tk, textbox_MatKhauMoi1.Texts))
                                {
                                    label_Loi.Text = "Đổi mật khẩu thất bại";
                                }
                                else
                                {
                                    textbox_MatKhauMoi1.Texts = "";
                                    textbox_MatKhauMoi2.Texts = "";
                                    textbox_MatKhauHienTai.Texts = "";
                                    label_Loi.Text = "Đổi mật khẩu thành công";
                                    label_Loi.ForeColor = CaiDatDAO.Instance.color_Text_Green;
                                }
                            }

                        }
                    }
                }
            }
            else
            {
                if (textbox_MatKhauHienTai.Texts == "" && textbox_MatKhauMoi1.Texts == "" && textbox_MatKhauMoi2.Texts == "")
                {
                    label_Loi.Text = "";
                }
                else if (textbox_MatKhauHienTai.Texts.Trim().Length > 0 || textbox_MatKhauMoi1.Texts.Trim().Length > 0 || textbox_MatKhauMoi2.Texts.Length > 0)
                {
                    label_Loi.ForeColor = CaiDatDAO.Instance.color_Text_Red;
                    if (textbox_MatKhauMoi1.Texts == "" || textbox_MatKhauMoi2.Texts == "")
                    {
                        label_Loi.Text = "Password can not be blank";
                    }
                    else if (textbox_MatKhauMoi1.Texts != textbox_MatKhauMoi2.Texts)
                    {
                        label_Loi.Text = "New password does not match";
                    }
                    else
                    {
                        if (!KiemTraMatKhau(tk, textbox_MatKhauHienTai.Texts))
                        {
                            label_Loi.Text = "Old password is incorrect";
                        }
                        else
                        {
                            if (textbox_MatKhauHienTai.Texts == textbox_MatKhauMoi1.Texts)
                            {
                                label_Loi.Text = "The new password cannot be the same as the old password";
                            }
                            else
                            {
                                if (!NguoiDungDAO.Instance.DoiMatKhau(tk, textbox_MatKhauMoi1.Texts))
                                {
                                    label_Loi.Text = "Change password failed";
                                }
                                else
                                {
                                    textbox_MatKhauMoi1.Texts = "";
                                    textbox_MatKhauMoi2.Texts = "";
                                    textbox_MatKhauHienTai.Texts = "";
                                    label_Loi.Text = "Change password successfully";
                                    label_Loi.ForeColor = CaiDatDAO.Instance.color_Text_Green;
                                }
                            }

                        }
                    }
                }
            }
        }
        public bool KiemTraMatKhau(string userName, string passWord)
        {
            string query = "SELECT * FROM dbo.NGUOI_DUNG WHERE TAI_KHOAN = N'" + userName + "' AND MAT_KHAU = N'" + passWord + "' ";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        private void radioButton_Bat_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Bat.Checked == true)
            {
                Change_Color_Black();
            }
            else
            {
                Change_Color_White();
            }
            label_Loi.Text = "";
            CapNhatGiaoDien();
        }
        private void radioButton_TiengViet_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_TiengViet.Checked == true)
            {
                Change_Language_VI();
            }
            else
            {
                Change_Language_EN();
            }
            label_Loi.Text = "";
            CapNhatNgonNgu();
        }
        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            CapNhatMatKhau();
        }
        // Color App
        public int KiemTraColorApp(string userName)
        {
            string query = "SELECT COLOR_APP FROM dbo.CAI_DAT WHERE TAI_KHOAN = N'" + userName + "'";

            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
        public void CapNhatColorApp()
        {
            if (radioButton_Blue.Checked)
            {
                CaiDatDAO.Instance.CapNhatColorApp(tk, 0);
            }
            else if (radioButton_Red.Checked)
            {
                CaiDatDAO.Instance.CapNhatColorApp(tk, 1);
            }
            else if (radioButton_Green.Checked)
            {
                CaiDatDAO.Instance.CapNhatColorApp(tk, 2);
            }
            else if (radioButton_Orange.Checked)
            {
                CaiDatDAO.Instance.CapNhatColorApp(tk, 3);
            }
            else if (radioButton_Yellow.Checked)
            {
                CaiDatDAO.Instance.CapNhatColorApp(tk, 4);
            }
            else if (radioButton_BlueDark.Checked)
            {
                CaiDatDAO.Instance.CapNhatColorApp(tk, 5);
            }
            else if (radioButton_Violet.Checked)
            {
                CaiDatDAO.Instance.CapNhatColorApp(tk, 6);
            }
            else if (radioButton_Pink.Checked)
            {
                CaiDatDAO.Instance.CapNhatColorApp(tk, 7);
            }
            else if (radioButton_Brown.Checked)
            {
                CaiDatDAO.Instance.CapNhatColorApp(tk, 8);
            }
            else
            {
                CaiDatDAO.Instance.CapNhatColorApp(tk, 9);
            }
            colorApp = KiemTraColorApp(tk);
            if (colorApp == 0)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Blue_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Blue_02;
            }
            else if (colorApp == 1)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Red_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Red_02;
            }
            if (colorApp == 2)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Green_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Green_02;
            }
            if (colorApp == 3)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Orange_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Orange_02;
            }
            if (colorApp == 4)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Yellow_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Yellow_02;
            }
            if (colorApp == 5)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_BlueDark_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_BlueDark_02;
            }
            if (colorApp == 6)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Violet_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Violet_02;
            }
            if (colorApp == 7)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Pink_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Pink_02;
            }
            if (colorApp == 8)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Brown_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Brown_02;
            }
            if (colorApp == 9)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Grey_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Grey_02;
            }
            (this.Owner as form_Chinh).panel_Title.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            (this.Owner as form_Chinh).button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            (this.Owner as form_Chinh).button_Maximize.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            (this.Owner as form_Chinh).button_Minimize.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            (this.Owner as form_Chinh).panel_Menu.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            (this.Owner as form_Chinh).button_ThongTin.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_KhuyenMai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_BangXepHang.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_HopThu.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_DonDangKyIdol.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_BaoCao.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_ThongKe.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_LichSuHoatDong.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_LichSuGiaoDich.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_CaiDat.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            (this.Owner as form_Chinh).button_DangXuat.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            (this.Owner as form_Chinh).label_XinChao.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Time.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).label_ThoiGian.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).label_NgayThangNam.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            (this.Owner as form_Chinh).button_Facebook.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Youtube.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Twitter.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Instagram.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Tiktok.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Gmail.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Website.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            (this.Owner as form_Chinh).button_Facebook.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Youtube.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Twitter.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Instagram.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Tiktok.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Gmail.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).button_Website.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            (this.Owner as form_Chinh).label_GhiChu.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).textbox_GhiChu.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            (this.Owner as form_Chinh).textbox_GhiChu.PlaceholderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            ChangeColorApp();
        }
        public void ChangeColorApp()
        {
            radioButton_TiengViet.CheckedColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            radioButton_English.CheckedColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            radioButton_Bat.CheckedColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            radioButton_Tat.CheckedColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_MatKhauHienTai.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_MatKhauHienTai.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            textbox_MatKhauMoi1.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_MatKhauMoi1.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            textbox_MatKhauMoi2.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_MatKhauMoi2.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            button_CapNhat.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
        private void radioButton_Blue_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Brown_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Green_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Orange_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Yellow_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_BlueDark_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Violet_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Pink_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Red_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
        private void radioButton_Grey_CheckedChanged(object sender, EventArgs e)
        {
            CapNhatColorApp();
        }
    }
}
