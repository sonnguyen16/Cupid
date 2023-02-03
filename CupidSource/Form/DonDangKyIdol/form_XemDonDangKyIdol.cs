using Cupid.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupid
{
    public partial class form_XemDonDangKyIdol : Form
    {
        List<Image> images = new List<Image>();
        int current = 0;
        DataGridViewRow row = null;
        public string tk_idol, tk;
        DataTable dt2;
        bool check_giaodien, check_ngonngu;

        public form_XemDonDangKyIdol(string tk)
        {
            InitializeComponent();
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
        #region Methods



        #endregion

        #region Events
        private void button_Close_Click(object sender, EventArgs e)
        {
            var f = (form_DonDangKyIdol)this.Owner;
            if (f.currentBtn == f.button_ChuaXem || f.currentBtn == null)
            {
                f.button_ChuaXem_Click(f.button_ChuaXem, e);
                f.ActivateButton(f.button_ChuaXem);
            }
            else
            {
                f.vt = -1;
                f.dataGridView.ClearSelection();
            }
            f.OnOffBtn(false);
            this.Close();
        }

        private void button_PhanHoi_Click(object sender, EventArgs e)
        {
            var f = (form_DonDangKyIdol)this.Owner;
            //this.row = f.row;
            //form_PhanHoiDonDangKyIdol phddki = new form_PhanHoiDonDangKyIdol(this.row,this.tk);
            //phddki.Owner = this;
            //phddki.ShowDialog();
            f.button_PhanHoi_Click(sender, e);

        }

        private void pictureBox_HinhAnh_Click(object sender, EventArgs e)
        {
            if (pictureBox_HinhAnh.Image != null)
            {
                form_ZoomHinhAnh zha = new form_ZoomHinhAnh(pictureBox_HinhAnh.Image, tk);
                zha.Show();
            }
            else
            {

            }
           
        }

        private void form_XemDonDangKyIdol_Load(object sender, EventArgs e)
        {
            var f = (form_DonDangKyIdol)this.Owner;
            this.tk_idol = f.tk;

            textbox_NguoiGui.Texts = f.row.Cells[1].Value.ToString();
            textbox_ChuDe.Texts = f.row.Cells[2].Value.ToString();
            textbox_NoiDung.Texts = f.row.Cells[3].Value.ToString();
            DataTable dt = NguoiDungDAO.Instance.getHinhAnh(textbox_NguoiGui.Texts);
            dt2 = NguoiDungDAO.Instance.getNguoiDung2(textbox_NguoiGui.Texts);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    images.Add(DataProvider.Instance.Base64ToImage((byte[])dt.Rows[i][0]));
                }
                label_TongSoTrang.Text = "/ " + images.Count;
                pictureBox_HinhAnh.Image = images[0];
            }
            DonDangKyIdolDAO.Instance.DaXem(f.row.Cells[0].Value.ToString());
           
        }
        #endregion
        private void button_TienLen_Click(object sender, EventArgs e)
        {
            if (images.Count >= 2)
            {
                button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                if (current + 1 < images.Count)
                {
                    current++;
                    pictureBox_HinhAnh.Image = images[current];
                    //button_TienLen.BackColor = Color.FromArgb(157, 217, 243);
                }
                if (current + 1 == images.Count)
                {
                    button_TienLen.BackColor = Color.DarkGray;
                }
                label_TrangHienTai.Text = (current + 1).ToString();
            }
        }

        private void button_QuayLai_Click(object sender, EventArgs e)
        {
            if (images.Count >= 2)
            {
                button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                if (current - 1 >= 0)
                {
                    current--;
                    pictureBox_HinhAnh.Image = images[current];
                    //button_QuayLai.BackColor = Color.FromArgb(157, 217, 243);
                }
                if (current == 0)
                {
                    button_QuayLai.BackColor = Color.DarkGray;
                }
                label_TrangHienTai.Text = (current + 1).ToString();
            }
        }

        private void button_Facebook_Click(object sender, EventArgs e)
        {
            if (dt2.Rows.Count > 0)
            {
                if (dt2.Rows[0][19].ToString() != null)
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo
                    {
                        FileName = dt2.Rows[0][19].ToString(),
                        UseShellExecute = true
                    };
                    Process.Start(psInfo);
                }
            }
           
        }

        private void button_Youtube_Click(object sender, EventArgs e)
        {
            if (dt2.Rows.Count > 0)
            {
                if (dt2.Rows[0][22].ToString() != null)
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo
                    {
                        FileName = dt2.Rows[0][22].ToString(),
                        UseShellExecute = true
                    };
                    Process.Start(psInfo);
                }
            }
        }

        private void button_Tiktok_Click(object sender, EventArgs e)
        {
            if (dt2.Rows.Count > 0)
            {
                if (dt2.Rows[0][21].ToString() != null)
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo
                    {
                        FileName = dt2.Rows[0][21].ToString(),
                        UseShellExecute = true
                    };
                    Process.Start(psInfo);
                }
            }
        }

        private void button_Instagram_Click(object sender, EventArgs e)
        {
            if (dt2.Rows.Count > 0)
            {
                if (dt2.Rows[0][20].ToString() != null)
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo
                    {
                        FileName = dt2.Rows[0][20].ToString(),
                        UseShellExecute = true
                    };
                    Process.Start(psInfo);
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
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon;
            //Button
            button_PhanHoi.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Facebook.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            button_Instagram.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            button_Twitter.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            button_Tiktok.BackColor = CaiDatDAO.Instance.color_BG_White_01;

            button_TienLen.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_QuayLai.IconColor = CaiDatDAO.Instance.color_Text_Black_01;

            //Textbox
            textbox_NguoiGui.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_NguoiGui.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_NguoiGui.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_ChuDe.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_ChuDe.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_ChuDe.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NoiDung.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_NoiDung.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_NoiDung.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            //Picture
            pictureBox_HinhAnh.BackColor = CaiDatDAO.Instance.color_BG_White_01;


        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon_Black;
            //Button
            button_PhanHoi.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Facebook.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Instagram.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Twitter.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Tiktok.BackColor = CaiDatDAO.Instance.color_BG_Black_01;

            button_TienLen.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_QuayLai.IconColor = CaiDatDAO.Instance.color_Text_White_01;

            //Textbox
            textbox_NguoiGui.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_NguoiGui.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_NguoiGui.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_ChuDe.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_ChuDe.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_ChuDe.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NoiDung.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_NoiDung.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_NoiDung.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            //Picture
            pictureBox_HinhAnh.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
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
            label_Title.Text = "Xem form đăng ký Idol";
            //Textbox
            textbox_NguoiGui.PlaceholderText = "Người gửi";
            textbox_ChuDe.PlaceholderText = "Chủ đề";
            textbox_NoiDung.PlaceholderText = "Nội dung";
            button_PhanHoi.Text = "Phản hồi";
        }
        public void Change_Language_EN()
        {
            //Label
            label_Title.Text = "View Idol registration form";
            //Textbox
            textbox_NguoiGui.PlaceholderText = "Sender";
            textbox_ChuDe.PlaceholderText = "Subject";
            textbox_NoiDung.PlaceholderText = "Messages";
            button_PhanHoi.Text = "Reply";
        }
        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            textbox_NguoiGui.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_NguoiGui.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_ChuDe.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_ChuDe.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_NoiDung.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_NoiDung.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_PhanHoi.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            panel_HinhAnh.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_Facebook.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Facebook.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_Instagram.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Instagram.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_Twitter.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Twitter.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_Tiktok.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Tiktok.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_TienLen2.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}