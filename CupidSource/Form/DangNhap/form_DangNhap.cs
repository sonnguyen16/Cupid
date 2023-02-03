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
using Cupid.Toolbox_Custom;
using NETWORKLIST;
using Check_Internet;

namespace Cupid
{
    public partial class form_DangNhap : Form
    {
        CheckerInternetHelper helper;
        string Name;
        private bool boolHienMatKhau;
        DataTable result = null;
        public int current = 0;
        public static Random random = new Random();
        public int num = random.Next(1, 5);
        bool check_internet = false;
        public form_DangNhap()
        {
            InitializeComponent();
            helper = new CheckerInternetHelper(this);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            label_Loi.Text = string.Empty;
            Change_Image();
        }
        private void form_DangNhap_Load(object sender, EventArgs e)
        {
            timer.Start();
            Check_Internet();
            pictureBox_Error.Visible = false;
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
        private void pictureBox_HienMatKhau_Click(object sender, EventArgs e)
        {
            boolHienMatKhau = !boolHienMatKhau;
            if (boolHienMatKhau)
            {
                pictureBox_HienMatKhau.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textbox_MatKhau.PasswordChar = false;
            }
            else
            {
                pictureBox_HienMatKhau.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                textbox_MatKhau.PasswordChar = true;
            }
        }
        private void pictureBox_HienMatKhau_DoubleClick(object sender, EventArgs e)
        {
            boolHienMatKhau = !boolHienMatKhau;
            if (boolHienMatKhau)
            {
                pictureBox_HienMatKhau.IconChar = FontAwesome.Sharp.IconChar.Eye;
                textbox_MatKhau.PasswordChar = false;
            }
            else
            {
                pictureBox_HienMatKhau.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                textbox_MatKhau.PasswordChar = true;
            }
        }
        private void button_Login_Click(object sender, EventArgs e)
        {
            Reset();
            if (check_internet)
            {
                if (textbox_TaiKhoan.Texts.Trim().Equals(""))
                {
                    label_Loi.Text = "Bạn chưa nhập tài khoản";
                    textbox_TaiKhoan.Focus();
                    textbox_TaiKhoan.BorderColor = Color.FromArgb(250, 80, 100);
                    textbox_TaiKhoan.BorderFocusColor = Color.FromArgb(250, 80, 100);
                }
                else if (textbox_MatKhau.Texts.Trim().Equals(""))
                {
                    label_Loi.Text = "Bạn chưa nhập mật khẩu";
                    textbox_MatKhau.Focus();
                    textbox_MatKhau.BorderColor = Color.FromArgb(250, 80, 100);
                    textbox_MatKhau.BorderFocusColor = Color.FromArgb(250, 80, 100);
                }
                else
                {
                    string userName = textbox_TaiKhoan.Texts.Trim();
                    string passWord = textbox_MatKhau.Texts.Trim();
                    if (Login(userName, passWord))
                    {
                        TachTen(result);
                        this.Hide();
                        form_Chinh chinh = new form_Chinh(Name, userName);
                        textbox_MatKhau.Enabled = false;
                        textbox_TaiKhoan.Enabled = false;
                        chinh.Owner = this;
                        chinh.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        label_Loi.Text = "Tài khoản hoặc mật khẩu không chính xác";
                    }
                }
            }
        }
        private void Reset()
        {
            textbox_TaiKhoan.BorderColor = Color.FromArgb(157, 217, 243);
            textbox_TaiKhoan.BorderFocusColor = Color.FromArgb(119, 195, 236);
            textbox_MatKhau.BorderColor = Color.FromArgb(157, 217, 243);
            textbox_MatKhau.BorderFocusColor = Color.FromArgb(119, 195, 236);
        }
        public bool Login(string userName, string passWord)
        {
            try
            {
                string query = "SELECT * FROM dbo.NGUOI_DUNG WHERE TAI_KHOAN = N'" + userName + "' AND MAT_KHAU = N'" + passWord + "' AND LOAI_NGUOI_DUNG = 0";

                result = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                
            }

            return result.Rows.Count > 0;
        }
        string TachTen(DataTable result)
        {
            string FullName = result.Rows[0]["HO_TEN"].ToString();

            string[] arrName = FullName.Split(' ');

            Name = arrName[arrName.Length - 1];

            return Name;
        }
        public void Change_Image()
        {
            if (num == 1)
            {
                pictureBox_Image.Image = Cupid.Properties.Resources.BG_Login_Image_01;
            }
            else if (num == 2)
            {
                pictureBox_Image.Image = Cupid.Properties.Resources.BG_Login_Image_02;
            }
            else if (num == 3)
            {
                pictureBox_Image.Image = Cupid.Properties.Resources.BG_Login_Image_03;
            }
            else
            {
                pictureBox_Image.Image = Cupid.Properties.Resources.BG_Login_Image_04;
            }
        }
        public void Check_Internet()
        {
            check_internet = false;
            IEnumNetworks Networks = helper.NLM.GetNetworks(NLM_ENUM_NETWORK.NLM_ENUM_NETWORK_CONNECTED);
            foreach (INetwork item in Networks)
            {
                check_internet = true;
            }
            if(check_internet)
            {
                pictureBox_Error.Visible = false;
            }
            else
            {
                pictureBox_Error.Visible = true;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Check_Internet();
        }
    }
}
