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
    public partial class form_PhanHoiDonDangKyIdol : Form
    {
        DataGridViewRow row;
        string tk;
        bool check_giaodien, check_ngonngu;
        public form_PhanHoiDonDangKyIdol(DataGridViewRow row,string tk)
        {
            InitializeComponent();
            this.row = row;
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType() == typeof(form_DonDangKyIdol))
                {
                    ((form_DonDangKyIdol)item).vt = -1;
                    ((form_DonDangKyIdol)item).dataGridView.ClearSelection();
                    ((form_DonDangKyIdol)item).OnOffBtn(false);
                }
            }
        }

        private void form_PhanHoiDonDangKyIdol_Load(object sender, EventArgs e)
        {
            textbox_NguoiNhan.Texts = this.row.Cells[1].Value.ToString();
            textbox_ChuDe.Texts = "Phản hồi về yêu cầu đăng ký làm Idol của Cupid";
        }

        private void pictureBox_Idol_Click(object sender, EventArgs e)
        {
            if (this.pictureBox_Idol.IconFont == FontAwesome.Sharp.IconFont.Solid)
            {
                this.pictureBox_Idol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            }
            else
            {
                this.pictureBox_Idol.IconFont = FontAwesome.Sharp.IconFont.Solid;
            }
        }

        private void button_Gui_Click(object sender, EventArgs e)
        {
            try
            {
               
                string tk_gui = this.tk;
                string tk_nhan = this.row.Cells[1].Value.ToString();
                string mathu = this.row.Cells[0].Value.ToString() + "_" + this.tk ;
                string chude = textbox_ChuDe.Texts;
                string noidung = textbox_NoiDung.Texts;
                DateTime ngaygui = DateTime.Now;
                int trangthai = 0;
              
                if (this.pictureBox_Idol.IconFont == FontAwesome.Sharp.IconFont.Solid)
                {
                    DonDangKyIdolDAO.Instance.PhanHoi(tk_nhan);
                }
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
                            if (this.pictureBox_Idol.IconFont == FontAwesome.Sharp.IconFont.Solid)
                            {
                                LichSuHoatDongDAO.Instance.insertLSHD(this.tk, 4, "Chấp nhận đơn đăng ký idol của tài khoản : " + textbox_NguoiNhan.Texts);
                            }
                            else
                            {
                                LichSuHoatDongDAO.Instance.insertLSHD(this.tk, 4, "Từ chối đơn đăng ký idol của tài khoản : " + textbox_NguoiNhan.Texts);

                            }

                            var f = (form_DonDangKyIdol)this.Owner;
                            if (f.currentBtn == f.button_ChuaXem)
                            {
                                f.button_ChuaXem_Click(f.button_ChuaXem, e);
                                f.ActivateButton(f.button_ChuaXem);
                            }
                            else
                            {
                                f.button_DaXem_Click(f.button_DaXem, e);
                                f.ActivateButton(f.button_DaXem);
                            }
                            f.OnOffBtn(false);
                            foreach (Form item in Application.OpenForms)
                            {
                                if (item.GetType() == typeof(form_XemDonDangKyIdol))
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
                    
                    bool data = HopThuDAO.Instance.GuiThu(mathu, tk_gui, tk_nhan, chude, noidung, ngaygui, trangthai);
                    if (data == false)
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
                        if (this.pictureBox_Idol.IconFont == FontAwesome.Sharp.IconFont.Solid)
                        {
                            LichSuHoatDongDAO.Instance.insertLSHD(this.tk, 4, "Chấp nhận đơn đăng ký idol của tài khoản : " + textbox_NguoiNhan.Texts);
                        }
                        else
                        {
                            LichSuHoatDongDAO.Instance.insertLSHD(this.tk, 4, "Từ chối đơn đăng ký idol của tài khoản : " + textbox_NguoiNhan.Texts);

                        }

                        var f = (form_DonDangKyIdol)this.Owner;
                        if (f.currentBtn == f.button_ChuaXem)
                        {
                            f.button_ChuaXem_Click(f.button_ChuaXem, e);
                            f.ActivateButton(f.button_ChuaXem);
                        }
                        else
                        {
                            f.button_DaXem_Click(f.button_DaXem, e);
                            f.ActivateButton(f.button_DaXem);
                        }
                        f.OnOffBtn(false);
                        foreach (Form item in Application.OpenForms)
                        {
                            if (item.GetType() == typeof(form_XemDonDangKyIdol))
                            {
                                item.Close();
                            }
                        }
                        this.Close();
                    }
                }

                if (checkBox_SoDienThoai.Checked == true)
                {
                    try
                    {
                        GuiTinNhan();
                    }
                    catch (Exception)
                    {
                        if (!check_ngonngu)
                        {
                            label_Loi.Text = "Không gửi được tin nhắn đến số điện thoại";
                        }
                        else
                        {
                            label_Loi.Text = "Can't send text message to phone number";
                        }
                    }

                }
                
            }
            catch (Exception)
            {
                if (!check_ngonngu)
                {
                    label_Loi.Text = "Bạn đã phản hồi yêu cầu này rồi";
                }
                else
                {
                    label_Loi.Text = "You have already responded to this request";
                }
            }
           
        }

        private void GuiTinNhan()
        {
            DataTable dt = NguoiDungDAO.Instance.getSoDt(textbox_NguoiNhan.Texts);
            string accountSid = "AC3f0c246be3dd2c51ffa424a9ee0ec4e6";
            string authToken = "1ae2c9e800facb9c23e85710d6e886b9";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: textbox_ChuDe.Texts + Environment.NewLine + textbox_NoiDung.Texts,
                from: new Twilio.Types.PhoneNumber("+13202894958"),
                to: new Twilio.Types.PhoneNumber("+84" + dt.Rows[0][0].ToString())
            );
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
            label_Title.Text = "Phản hồi đơn đăng kí Idol";
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
            label_Title.Text = "Reply Idol registration form";
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

            pictureBox_Idol.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}