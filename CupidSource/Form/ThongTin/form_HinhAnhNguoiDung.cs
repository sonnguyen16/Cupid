using Cupid.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupid
{
    public partial class form_HinhAnhNguoiDung : Form
    {

        public List<Image> ls; 
        int current = 0;
        string tk;
        bool check_giaodien, check_ngonngu;
        public form_HinhAnhNguoiDung(string tk)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            button_TienLen.BackColor = Color.DarkGray;
            ls = new List<Image>();
            var f = (form_ChinhSuaTaiKhoanNguoiDung)this.Owner;
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
        }

        public form_HinhAnhNguoiDung(List<Image> images, string tk)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            button_TienLen.BackColor = Color.DarkGray;
            ls = new List<Image>(images);
            pictureBox_HinhAnh.Image = ls[0];
            label_TongSoTrang.Text = "/ "+ls.Count.ToString();
            label_TrangHienTai.Text = "1";
            button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            this.tk = tk;
        }
        private void form_HinhAnhNguoiDung_Load(object sender, EventArgs e)
        {
            Change_Color_Button();
        }
        private void label_TrangHienTai_TextChanged(object sender, EventArgs e)
        {
            Change_Color_Button();
        }
        public void Change_Color_Button()
        {
            if (ls.Count == 0)
            {
                button_Xoa.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
            }
            else
            {
                button_Xoa.BackColor = CaiDatDAO.Instance.color_BG_Blue_01;
            }
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
        //Remove transparent border in maximized state

        private void HinhAnh_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        public void XoaHinhAnh()
        {
            if (ls.Count == 0)
            {
                button_Xoa.BackColor = CaiDatDAO.Instance.color_Text_DarkGray;
                button_Xoa.BackColor = CaiDatDAO.Instance.color_BG_Blue_01;
            }
            else
            {
                ls.Remove(ls[current]);
                if (current == 0)
                {
                    button_QuayLai.BackColor = Color.DarkGray;

                }
                if (current + 1 == ls.Count)
                {
                    button_TienLen.BackColor = Color.DarkGray;

                }


                if (ls.Count > 0)
                {
                    if (current == ls.Count)
                    {
                        pictureBox_HinhAnh.Image = ls[--current];
                    }
                    if (current >= 0)
                    {
                        pictureBox_HinhAnh.Image = ls[current];
                    }

                    label_TongSoTrang.Text = "/ " + ls.Count.ToString();
                    label_TrangHienTai.Text = (current + 1).ToString();

                }
                else
                {
                    pictureBox_HinhAnh.Image = null;
                    label_TongSoTrang.Text = "/ 0";
                    label_TrangHienTai.Text = "0 ";
                }
            }
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(form_ChinhSuaTaiKhoanNguoiDung))
                {
                    form_XoaHinhAnhNguoiDung nf = new form_XoaHinhAnhNguoiDung(tk);
                    nf.Owner = this;
                    nf.ShowDialog();
                    break;
                }
                if (f.GetType() == typeof(form_TaoTaiKhoanNguoiDung))
                {
                    XoaHinhAnh();
                    break;
                }
            }
            
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Chọn hình ảnh";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox_HinhAnh.Image = Image.FromFile(openFile.FileName);
                ls.Add(pictureBox_HinhAnh.Image);
                label_TongSoTrang.Text = "/ " + ls.Count.ToString();
                current = ls.Count - 1;
                label_TrangHienTai.Text = (current + 1).ToString();
                if (ls.Count >= 2)
                {
                    button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                }
            }
        }

        private void button_TienLen_Click(object sender, EventArgs e)
        {
            if (ls.Count >= 2)
            {
                button_QuayLai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                if (current + 1 < ls.Count)
                {
                    current++;
                    pictureBox_HinhAnh.Image = ls[current];
                    //button_TienLen.BackColor = Color.FromArgb(157, 217, 243);
                }
                if (current + 1 == ls.Count)
                {
                    button_TienLen.BackColor = Color.DarkGray;
                }
                label_TrangHienTai.Text = (current + 1).ToString();
            }
        }

        private void button_QuayLai_Click(object sender, EventArgs e)
        {
            if (ls.Count >= 2)
            {
                button_TienLen.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                if (current - 1 >= 0)
                {
                    current--;
                    pictureBox_HinhAnh.Image = ls[current];
                    //button_QuayLai.BackColor = Color.FromArgb(157, 217, 243);
                }
                if (current == 0)
                {
                    button_QuayLai.BackColor = Color.DarkGray;
                }
                label_TrangHienTai.Text = (current + 1).ToString();
            }
          


        }

        private void button_Luu_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(form_ChinhSuaTaiKhoanNguoiDung))
                {
                    ((form_ChinhSuaTaiKhoanNguoiDung)f).images = new List<Image>(ls);
                    this.Close();
                }
                if (f.GetType() == typeof(form_TaoTaiKhoanNguoiDung))
                {
                    ((form_TaoTaiKhoanNguoiDung)f).images = new List<Image>(ls);
                    this.Close();
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
            panel_Bottom.BackColor = CaiDatDAO.Instance.color_BG_White_02;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon;

            //Button
            button_Them.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Xoa.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Luu.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
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
            button_Them.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Xoa.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Luu.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
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
            label_Title.Text = "Hình ảnh người dùng";
            //Button
            button_Them.Text = "Thêm";
            button_Xoa.Text = "Xóa";
            button_Luu.Text = "Lưu";

        }
        public void Change_Language_EN()
        {
            //Label
            label_Title.Text = "User Image";
            //Button
            button_Them.Text = "Add";
            button_Xoa.Text = "Delete";
            button_Luu.Text = "Save";
        }
        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Maximize.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Minimize.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            button_Them.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Luu.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Xoa.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}
