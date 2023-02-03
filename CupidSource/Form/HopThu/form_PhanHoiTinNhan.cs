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
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Cupid
{
    public partial class form_PhanHoiTinNhan : Form
    {
        string tk;
        bool check_giaodien, check_ngonngu;
        public form_PhanHoiTinNhan(DataGridViewRow row, string tk)
        {
            InitializeComponent();
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            textbox_NguoiNhan.Texts = row.Cells[1].Value.ToString();
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
            if (textbox_ChuDe.Texts.Trim().Equals("") && textbox_NoiDung.Texts.Trim().Equals(""))
            {
                string tk_gui = this.tk;
                string tk_nhan = textbox_NguoiNhan.Texts;
                string query = "select top 1 ma_thu from hop_thu where ma_thu like '" + tk_gui + "_" + tk_nhan + "_%' order by ngay_gui desc";
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                string mathu = this.tk + "_" + textbox_NguoiNhan.Texts + "_";
                if (dt.Rows.Count == 0)
                {
                    mathu += "0";
                }
                else
                {
                    string ma = dt.Rows[0][0].ToString();
                    string[] arr = ma.Split('_');
                    int a = Convert.ToInt32(arr[2]) + 1;
                    mathu += a.ToString();
                }
                string chude = textbox_ChuDe.Texts;
                string noidung = textbox_NoiDung.Texts;
                DateTime ngaygui = DateTime.Now;
                int trangthai = 2;
                HopThuDAO.Instance.LuuThuNhap(mathu, tk_gui, tk_nhan, chude, noidung, ngaygui, trangthai);
                
            }
            this.Close();

        }

        private bool KiemTra()
        {
            if (textbox_ChuDe.Texts.Trim() == String.Empty)
            {
                label_Loi.Text = "Bạn chưa nhập chủ đề";
                return false;
            }
            if (textbox_NoiDung.Texts.Trim() == String.Empty)
            {
                label_Loi.Text = "Bạn chưa nhập nội dung";
                return false;
            }
            if (textbox_NguoiNhan.Texts.Trim() == String.Empty)
            {
                label_Loi.Text = "Chưa có người nhập";
                return false;
            }
            return true;
        }

        private void button_Gui_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                string tk_gui = this.tk;
                string tk_nhan = textbox_NguoiNhan.Texts;
                string query = "select top 1 ma_thu from hop_thu where tk_gui = '" + tk_gui + "' and tk_nhan = '" + tk_nhan + "' order by ngay_gui desc";
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                string mathu = this.tk + "_" + textbox_NguoiNhan.Texts + "_";
                if (dt.Rows.Count == 0)
                {
                    mathu += "0";
                }
                else
                {
                    string ma = dt.Rows[0][0].ToString();
                    string[] arr = ma.Split('_');
                    int a = Convert.ToInt32(arr[2]) + 1;
                    mathu += a.ToString();
                }
                string chude = textbox_ChuDe.Texts;
                string noidung = textbox_NoiDung.Texts;
                DateTime ngaygui = DateTime.Now;
                int trangthai = 0;
                
                if (checkBox_Gmail.Checked == true)
                {
                    if (!HopThuDAO.Instance.getMail(tk_nhan))
                    {
                        if (!check_ngonngu)
                        {
                            label_Loi.Text = "Người dùng chưa có email";
                        }
                        else
                        {
                            label_Loi.Text = "User don't have an email";
                        }
                    }
                    else
                    {
                        HopThuDAO.Instance.GuiThu(mathu, tk_gui, tk_nhan, chude, noidung, ngaygui, trangthai);
                        int data = HopThuDAO.Instance.guiEmail(textbox_ChuDe.Texts, textbox_NoiDung.Texts, textbox_NguoiNhan.Texts);
                        if (data > 0)
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
                        else
                        {
                            foreach (Form item in Application.OpenForms)
                            {
                                if (item.GetType() == typeof(form_XemTinNhan))
                                {
                                    item.Close();
                                }
                            }
                            this.Close();
                        }
                    }


                }
                else
                {
                    HopThuDAO.Instance.GuiThu(mathu, tk_gui, tk_nhan, chude, noidung, ngaygui, trangthai);
                    foreach (Form item in Application.OpenForms)
                    {
                        if (item.GetType() == typeof(form_XemTinNhan))
                        {
                            item.Close();
                        }
                    }
                    this.Close();
                }
               
            }
            
        }
        private void GuiTinNhan()
        {
            
        }
        private void form_PhanHoiTinNhan_Load(object sender, EventArgs e)
        {

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
            button_Gui.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            //Textbox
            textbox_NguoiNhan.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_NguoiNhan.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_NguoiNhan.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_ChuDe.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_ChuDe.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_ChuDe.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NoiDung.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_NoiDung.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_NoiDung.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            checkBox_Gmail.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            checkBox_SoDienThoai.BackColor = CaiDatDAO.Instance.color_BG_White_01;

        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon_Black;
            //Button
            button_Gui.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            //Textbox
            textbox_NguoiNhan.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_NguoiNhan.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_NguoiNhan.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_ChuDe.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_ChuDe.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_ChuDe.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NoiDung.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_NoiDung.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_NoiDung.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            checkBox_Gmail.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            checkBox_SoDienThoai.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
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
            label_Title.Text = "Phản hồi tin nhắn";
            //Textbox
            textbox_NguoiNhan.PlaceholderText = "Người nhận";
            textbox_ChuDe.PlaceholderText = "Chủ đề";
            textbox_NoiDung.PlaceholderText = "Nội dung";

            checkBox_Gmail.Text = "Gmail";
            checkBox_SoDienThoai.Text = "Số điện thoại";
            button_Gui.Text = "Gửi";
        }
        public void Change_Language_EN()
        {
            //Label
            label_Title.Text = "Reply message";
            //Textbox
            textbox_NguoiNhan.PlaceholderText = "Recipient";
            textbox_ChuDe.PlaceholderText = "Subject";
            textbox_NoiDung.PlaceholderText = "Messages";

            checkBox_Gmail.Text = "Gmail";
            checkBox_SoDienThoai.Text = "Phone number";
            button_Gui.Text = "Submit";
        }
        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            textbox_NguoiNhan.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_NguoiNhan.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_ChuDe.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_ChuDe.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_NoiDung.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_NoiDung.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_Gui.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            checkBox_Gmail.CheckedColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            checkBox_SoDienThoai.CheckedColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

        }
    }
}