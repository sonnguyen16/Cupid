using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Cupid.DAO;

namespace Cupid
{
    public partial class form_ThongTinLienLac : Form
    {
        List<string> mxh2 = new List<string>();
        string tk;
        bool check_giaodien, check_ngonngu;
        public form_ThongTinLienLac(List<string> mxh, string tk)
        {
            InitializeComponent();
            mxh = new List<string>();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            textbox_Sdt.Padding = new Padding(60, 7, 10, 6);
            label_Loi.ResetText();
            foreach (Form item in Application.OpenForms)
            {
               
                if (item.GetType() == typeof(form_ChinhSuaTaiKhoanNguoiDung))
                {
                    textbox_Facebook.Texts = ((form_ChinhSuaTaiKhoanNguoiDung)item).mxh[0];
                    textbox_Insta.Texts = ((form_ChinhSuaTaiKhoanNguoiDung)item).mxh[1];
                    textbox_Tiktok.Texts = ((form_ChinhSuaTaiKhoanNguoiDung)item).mxh[2];
                    textbox_Twitter.Texts = ((form_ChinhSuaTaiKhoanNguoiDung)item).mxh[3];
                    textbox_Gmail.Texts = ((form_ChinhSuaTaiKhoanNguoiDung)item).mxh[5];
                    textbox_Zalo.Texts = ((form_ChinhSuaTaiKhoanNguoiDung)item).mxh[4];
                    textbox_Sdt.Texts = ((form_ChinhSuaTaiKhoanNguoiDung)item).mxh[6];
                    break;
                }
                if (item.GetType() == typeof(form_TaoTaiKhoanNguoiDung))
                {
                    if (((form_TaoTaiKhoanNguoiDung)item).mxh != null)
                    {
                        textbox_Facebook.Texts = ((form_TaoTaiKhoanNguoiDung)item).mxh[0];
                        textbox_Insta.Texts = ((form_TaoTaiKhoanNguoiDung)item).mxh[1];
                        textbox_Tiktok.Texts = ((form_TaoTaiKhoanNguoiDung)item).mxh[2];
                        textbox_Twitter.Texts = ((form_TaoTaiKhoanNguoiDung)item).mxh[3];
                        textbox_Gmail.Texts = ((form_TaoTaiKhoanNguoiDung)item).mxh[5];
                        textbox_Zalo.Texts = ((form_TaoTaiKhoanNguoiDung)item).mxh[4];
                        textbox_Sdt.Texts = ((form_TaoTaiKhoanNguoiDung)item).mxh[6];
                    }
                    
                    break;
                }
            }
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
        }
        private void form_ThongTinLienLac_Load(object sender, EventArgs e)
        {
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        #region Events
        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void button_Luu_Click(object sender, EventArgs e)
        {
          
            if (!textbox_Gmail.Texts.Contains("@gmail.com") && textbox_Gmail.Texts.Trim().Length > 0)
            {
                if (!check_ngonngu)
                {
                    label_Loi.Text = "Gmail không hợp lệ";
                }
                else
                {
                    label_Loi.Text = "Invalid Gmail";
                }
            }
            else if (textbox_Zalo.Texts.Trim().Length > 0 && textbox_Zalo.Texts.Trim().Length < 10 )
            {
                if (!check_ngonngu)
                {
                    label_Loi.Text = "Zalo không hợp lệ";
                }
                else
                {
                    label_Loi.Text = "Invalid Zalo";
                }
            }
            else if (textbox_Sdt.Texts.Trim().Length > 0 && textbox_Sdt.Texts.Trim().Length < 10)
            {
                if (!check_ngonngu)
                {
                    label_Loi.Text = "Số điện thoại không hợp lệ";
                }
                else
                {
                    label_Loi.Text = "Invalid phone number";
                }
            }
            else
            {
                ThemMxh();
                foreach (Form item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(form_TaoTaiKhoanNguoiDung))
                    {
                        ((form_TaoTaiKhoanNguoiDung)item).mxh = new List<string>(mxh2);
                        break;
                    }
                    if (item.GetType() == typeof(form_ChinhSuaTaiKhoanNguoiDung))
                    {
                        ((form_ChinhSuaTaiKhoanNguoiDung)item).mxh = new List<string>(mxh2);
                        break;
                    }
                }
                this.Close();
            }
            
        }
        private void ThemMxh()
        {
            mxh2.Add(textbox_Facebook.Texts);
            mxh2.Add(textbox_Insta.Texts);
            mxh2.Add(textbox_Tiktok.Texts);
            mxh2.Add(textbox_Twitter.Texts);
            mxh2.Add(textbox_Zalo.Texts);
            mxh2.Add(textbox_Gmail.Texts);
            mxh2.Add(textbox_Sdt.Texts);
        }
        private void textbox_Zalo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back )
            {
                e.Handled = true;
            }
        }
        private void textbox_Sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
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

            //Button
            button_Luu.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            //Textbox
            textbox_Facebook.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Facebook.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Facebook.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Insta.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Insta.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Insta.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Tiktok.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Tiktok.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Tiktok.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Twitter.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Twitter.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Twitter.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Gmail.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Gmail.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Gmail.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Zalo.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Zalo.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Zalo.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Sdt.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Sdt.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Sdt.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon_Black;

            //Button
            button_Luu.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            //Textbox
            textbox_Facebook.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Facebook.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Facebook.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Insta.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Insta.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Insta.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Tiktok.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Tiktok.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Tiktok.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Twitter.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Twitter.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Twitter.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Gmail.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Gmail.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Gmail.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Zalo.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Zalo.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Zalo.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Sdt.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Sdt.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Sdt.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;


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
            label_Title.Text = "Thông tin liên lạc";
            label_Facebook.Text = "Facebook";
            label_Instagram.Text = "Instagram:";
            label_TikTok.Text = "TikTok:";
            label_Twitter.Text = "Twitter:";
            label_Gmail.Text = "Gmail:";
            label_Zalo.Text = "Zalo:";
            label_SDT.Text = "Số điện thoại:";
            //Button
            button_Luu.Text = "Lưu";

        }
        public void Change_Language_EN()
        {
            //Label
            label_Title.Text = "Communications";
            label_Facebook.Text = "Facebook";
            label_Instagram.Text = "Instagram:";
            label_TikTok.Text = "TikTok:";
            label_Twitter.Text = "Twitter:";
            label_Gmail.Text = "Gmail:";
            label_Zalo.Text = "Zalo:";
            label_SDT.Text = "Phone number:";
            //Button
            button_Luu.Text = "Save";
        }
        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            textbox_Facebook.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Facebook.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_Gmail.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Gmail.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_Insta.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Insta.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_Sdt.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Sdt.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_Tiktok.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Tiktok.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_Twitter.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Twitter.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_Zalo.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Zalo.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_Luu.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}