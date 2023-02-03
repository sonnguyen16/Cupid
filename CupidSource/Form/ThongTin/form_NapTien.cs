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
    public partial class form_NapTien : Form
    {
        string tk;
        string tkus;
        bool check_giaodien, check_ngonngu;
        public form_NapTien(string tkad,string tkus)
        {
            InitializeComponent();
            this.tk = tkad;
            this.tkus = tkus;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            textbox_TaiKhoan.Texts = this.tkus;
        }
        private void form_NapTien_Load(object sender, EventArgs e)
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
        }

        private void switch_Check_StyleChanged(object sender, EventArgs e)
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
            button_Nap.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            //Textbox
            textbox_TaiKhoan.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TaiKhoan.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TaiKhoan.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_SoTienNap.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_SoTienNap.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_SoTienNap.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            switch_Check.BackColor = CaiDatDAO.Instance.color_BG_White_01;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon_Black;

            //Button
            button_Nap.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            //Textbox
            textbox_TaiKhoan.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TaiKhoan.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TaiKhoan.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_SoTienNap.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_SoTienNap.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_SoTienNap.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            switch_Check.BackColor = CaiDatDAO.Instance.color_BG_Black_01;

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
            label_Title.Text = "Nạp tiền";
            //Textbox
            textbox_TaiKhoan.PlaceholderText = "Tài khoản";
            textbox_SoTienNap.PlaceholderText = "Số tiền nạp";
            //Button
            button_Nap.Text = "Nạp";
        }

        private void switch_Check_Click(object sender, EventArgs e)
        {
            if (switch_Check.IsOn)
            {
                button_Nap.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            }
            else
            {
                button_Nap.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
            }
        }

        private void switch_Check_DoubleClick(object sender, EventArgs e)
        {
            if (switch_Check.IsOn)
            {
                button_Nap.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            }
            else
            {
                button_Nap.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
            }
        }

        private void button_Nap_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                string query = "SELECT TOP 1 MA_GIAO_DICH FROM LICH_SU_GIAO_DICH ORDER BY MA_GIAO_DICH DESC";
                DataTable dt = DataProvider.Instance.ExecuteQuery(query);
                string[] arr = dt.Rows[0][0].ToString().Split('_');
                string ma = "GD_" + (Convert.ToInt32(arr[1]) + 1).ToString();
                int soTien = Convert.ToInt32(textbox_SoTienNap.Texts);
                if (NguoiDungDAO.Instance.NapTien(tkus, soTien) && LichSuGiaoDichDAO.Instance.insertGiaoDich(ma,tkus,soTien,2))
                {
                    LichSuHoatDongDAO.Instance.insertLSHD(this.tk, 3, "Nạp tiền cho tài khoản " + textbox_TaiKhoan.Texts + Environment.NewLine + " Số tiền : " + textbox_SoTienNap.Texts);
                    var f1 = (form_ThongTin)this.Owner;
                    if (f1.dataGridView.Rows[0].Cells[2].Value.ToString() == "1")
                    {
                        f1.button_BinhThuong_Click(f1.btn, f1.ea);
                        f1.ActivateButton(f1.button_BinhThuong);
                        f1.btn = f1.button_BinhThuong;
                    }
                    else
                    {
                        f1.button_Idol_Click(f1.btn1, f1.ea1);
                        f1.ActivateButton(f1.button_Idol);
                        f1.btn = f1.button_Idol;
                    }
                    this.Close();
                }
                else
                {
                    if (!check_ngonngu)
                    {
                        label_Loi.Text = "Nạp tiền thất bại";
                    }
                    else
                    {
                        label_Loi.Text = "Deposit failed";
                    }
                    
                }
            }
        }

        private bool KiemTra()
        {
            if (!check_ngonngu)
            {
                if (textbox_SoTienNap.Texts.Trim().Equals(""))
                {
                    label_Loi.Text = "Bạn chưa nhập số tiền";
                    return false;
                }
                if (switch_Check.IsOn == false)
                {
                    label_Loi.Text = "Bạn chưa xác nhận nạp tiền";
                    return false;
                }
            }
            else
            {
                if (textbox_SoTienNap.Texts.Trim().Equals(""))
                {
                    label_Loi.Text = "You haven't entered the amount yet";
                    return false;
                }
                if (switch_Check.IsOn == false)
                {
                    label_Loi.Text = "You haven't confirmed the deposit";
                    return false;
                }
            }
           return true;
        }

        public void Change_Language_EN()
        {

            //Label
            label_Title.Text = "Top up";
            //Textbox
            textbox_TaiKhoan.PlaceholderText = "Username";
            textbox_SoTienNap.PlaceholderText = "External funds used";
            //Button
            button_Nap.Text = "Top up";
        }
        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            button_Nap.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            switch_Check.OnColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_TaiKhoan.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TaiKhoan.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_SoTienNap.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_SoTienNap.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}
