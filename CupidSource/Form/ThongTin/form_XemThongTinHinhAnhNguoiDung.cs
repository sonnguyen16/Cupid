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
    public partial class form_XemThongTinHinhAnhNguoiDung : Form
    {
        string tk;
        bool check_giaodien, check_ngonngu;
        List<Image> images;
        public form_XemThongTinHinhAnhNguoiDung(string tk, List<Image> images,Image image,int index)
        {
            InitializeComponent();
            this.images = images;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            button_TienLen.BackColor = Color.DarkGray;
            this.tk = tk;
            pictureBox_HinhAnh.Image = image;
            current = index;
            label_TrangHienTai.Text = (current + 1).ToString();
            label_TongSoTrang.Text = " / "+images.Count.ToString();
            button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            if (index == 0)
            {
                button_QuayLai.BackColor = Color.DarkGray;
            }
            if (index == images.Count - 1)
            {
                button_TienLen.BackColor = Color.DarkGray; 
            }
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
        }
        private void form_XemThongTinHinhAnhNguoiDung_Load(object sender, EventArgs e)
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
        private void From_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
        private void button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        int current = 0;
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
            panel_Bottom.BackColor = CaiDatDAO.Instance.color_BG_White_02;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon;

            //Button
            button_QuayLai.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_TienLen.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            button_Close.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Maximize.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Minimize.IconColor = CaiDatDAO.Instance.color_Text_Black_01;

            button_TienLen.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_QuayLai.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            panel_Bottom.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon_Black;

            //Button
            button_QuayLai.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_TienLen.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Maximize.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Minimize.IconColor = CaiDatDAO.Instance.color_Text_White_01;

            button_TienLen.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_QuayLai.IconColor = CaiDatDAO.Instance.color_Text_White_01;
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
            label_Title.Text = "Xem thông tin hình ảnh người dùng";

        }

        public void Change_Language_EN()
        {
            //Label
            label_Title.Text = "View the user image information";
        }
        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Maximize.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Minimize.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}
