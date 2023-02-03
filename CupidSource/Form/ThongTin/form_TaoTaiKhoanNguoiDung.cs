using Cupid.DAO;
using Cupid.Toolbox_Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupid
{
    public partial class form_TaoTaiKhoanNguoiDung : Form
    {
        List<Textbox_Custom> textbox_Customs = new List<Textbox_Custom>();
        public List<Image> images;
        public List<string> mxh = null;
        string tk;
        bool check_giaodien, check_ngonngu;
        public Image avatar;
        public form_TaoTaiKhoanNguoiDung(string tk)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            label_Loi.ResetText();
            AddListTextBox();
            images = new List<Image>();
            Reset();
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
        }
        private void form_TaoTaiKhoanNguoiDung_Load(object sender, EventArgs e)
        {
            pictureBox_AnhDaiDien.Image = null;
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
            var f = (form_ThongTin)this.Owner;
            f.OnOffBtn(false);
            f.vt = -1;
            f.dataGridView.ClearSelection();
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

        private void pictureBox_DienThoai_Click(object sender, EventArgs e)
        {
            form_ThongTinLienLac ttll = new form_ThongTinLienLac(mxh, tk);
            ttll.Owner = this;
            ttll.ShowDialog();
        }
        private void pictureBox_HinhAnh_Click(object sender, EventArgs e)
        {
            if (images.Count > 0)
            {
                form_HinhAnhNguoiDung hand = new form_HinhAnhNguoiDung(images, tk);
                hand.Owner = this;
                hand.ShowDialog();
            }
            else
            {
                form_HinhAnhNguoiDung hand = new form_HinhAnhNguoiDung(tk);
                hand.Owner = this;
                hand.ShowDialog();
            }

        }

        private void pictureBox_AnhDaiDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Chọn hình ảnh";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //pictureBox_AnhDaiDien.Image = Image.FromFile(openFile.FileName);
                //pictureBox_AnhDaiDien.SizeMode = PictureBoxSizeMode.Zoom;
                form_CapNhatAnhDaiDien f = new form_CapNhatAnhDaiDien(tk,Image.FromFile(openFile.FileName));
                f.Owner = this;
                f.Show();
            }
        }

        private void textbox_ChieuCao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textbox_CanNang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textbox_Vong1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textbox_Vong2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textbox_Vong3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void textbox_HoVaTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space || e.KeyChar == (char)Keys.ShiftKey);
        }

        private void button_Tao_Click(object sender, EventArgs e)
        {
            Reset();
            if (KiemTra(textbox_Customs))
            {
                if (ThemNguoiDung())
                {
                    
                    images.Clear();
                    LichSuHoatDongDAO.Instance.insertLSHD(this.tk,0,"Tạo tài khoản : "+ textbox_TaiKhoan.Texts);
                    var f1 = (form_ThongTin)this.Owner;
                    if (this.pictureBox_Idol.IconFont == FontAwesome.Sharp.IconFont.Auto)
                    {
                        f1.button_BinhThuong_Click(f1.btn, f1.ea);
                        f1.ActivateButton(f1.button_BinhThuong);
                        f1.currentBtn = f1.button_BinhThuong;
                        f1.loaitk = 1;
                    }
                    else
                    {
                        f1.button_Idol_Click(f1.btn1, f1.ea1);
                        f1.ActivateButton(f1.button_Idol);
                        f1.currentBtn = f1.button_Idol;
                        f1.loaitk = 2;
                    }
                    this.Close();
                    f1.OnOffBtn(false);

                }
                else
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
            }

        }

        private void textbox_TaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void textbox_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void textbox_TaiKhoan_Leave(object sender, EventArgs e)
        {
            DataTable dt = NguoiDungDAO.Instance.getNguoiDung2(textbox_TaiKhoan.Texts);

            if (dt.Rows.Count > 0)
            {
                label_Loi.Text = "Tài khoản đã tồn tại, vui lòng đặt lại";
                textbox_TaiKhoan.BorderColor = Color.Red;
                textbox_TaiKhoan.BorderFocusColor = Color.Red;
            }
            else
            {
                textbox_TaiKhoan.BorderColor = CaiDatDAO.Instance.color_BG_Blue_01;
                textbox_TaiKhoan.BorderFocusColor = CaiDatDAO.Instance.color_BG_Blue_02;
                label_Loi.ResetText();
            }
        }

        #endregion

        #region Methods

        private bool ThemNguoiDung()
        {
            string tk = textbox_TaiKhoan.Texts;
            string mk = textbox_MatKhau.Texts;
            int loaitk = 0;
            if (this.pictureBox_Idol.IconFont == FontAwesome.Sharp.IconFont.Auto)
            {
                loaitk = 1;
            }
            else
            {
                loaitk = 2;
            }
            byte[] ha = DataProvider.Instance.ImageToBase64(Properties.Resources.Default_Avt, Properties.Resources.Default_Avt.RawFormat);
            if (((PictureBox_Custom)pictureBox_AnhDaiDien).Image != null)
            {
                ha = DataProvider.Instance.ImageToByte2(((PictureBox_Custom)pictureBox_AnhDaiDien).Image);
            }

            string hoten = textbox_HoVaTen.Texts;
            System.DateTime ngaysinh = dateTimePicker_NgaySinh.Value;
            string gt = "";
            if (radioButton_Nam.Checked == true)
            {
                gt = "Nam";
            }
            else if (radioButton_Nu.Checked == true)
            {
                gt = "Nữ";
            }
            else if (radioButton_Khac.Checked == true)
            {
                gt = "Khác";
            }

            string quequan = textbox_QueQuan.Texts;
            string noio = textbox_NoiOHienTai.Texts;
            string ddhenho = textbox_DiaDiemhenHo.Texts;
            string nghenghiep = textbox_NgheNghiep.Texts;
            float chieucao = 0;
            if (textbox_ChieuCao.Texts != String.Empty)
            {
                chieucao = float.Parse(textbox_ChieuCao.Texts);
            }
            float can_nang = 0;
            if (textbox_CanNang.Texts != String.Empty)
            {
                can_nang = float.Parse(textbox_CanNang.Texts);
            }
            float vong1 = 0;
            if (textbox_Vong1.Texts != String.Empty)
            {
                vong1 = float.Parse(textbox_Vong1.Texts);
            }
            float vong2 = 0;
            if (textbox_Vong2.Texts != String.Empty)
            {
                vong2 = float.Parse(textbox_Vong2.Texts);
            }
            float vong3 = 0;
            if (textbox_Vong3.Texts != String.Empty)
            {
                vong3 = float.Parse(textbox_Vong3.Texts);
            }
           
            string cunghoangdao = "";
            if (combobox_CungHoangDao.Texts == "Bạch dương" || combobox_CungHoangDao.Texts == "Aries")
            {
                cunghoangdao = "Bạch dương";
            }
            else if(combobox_CungHoangDao.Texts == "Kim ngưu" || combobox_CungHoangDao.Texts == "Taurus")
            {
                cunghoangdao = "Kim ngưu";
            }
            else if (combobox_CungHoangDao.Texts == "Song tử" || combobox_CungHoangDao.Texts == "Gemini")
            {
                cunghoangdao = "Song tử";
            }
            else if (combobox_CungHoangDao.Texts == "Cự giải" || combobox_CungHoangDao.Texts == "Cancer")
            {
                cunghoangdao = "Cự giải";
            }
            else if (combobox_CungHoangDao.Texts == "Sư tử" || combobox_CungHoangDao.Texts == "Leo")
            {
                cunghoangdao = "Sư tử";
            }
            else if (combobox_CungHoangDao.Texts == "Xử nữ" || combobox_CungHoangDao.Texts == "Virgo")
            {
                cunghoangdao = "Xử nữ";
            }
            else if (combobox_CungHoangDao.Texts == "Thiên bình" || combobox_CungHoangDao.Texts == "Libra")
            {
                cunghoangdao = "Thiên bình";
            }
            else if (combobox_CungHoangDao.Texts == "Bọ cạp" || combobox_CungHoangDao.Texts == "Scorpion")
            {
                cunghoangdao = "Bọ cạp";
            }
            else if (combobox_CungHoangDao.Texts == "Nhân mã" || combobox_CungHoangDao.Texts == "Sagittarius")
            {
                cunghoangdao = "Nhân mã";
            }
            else if (combobox_CungHoangDao.Texts == "Ma kết" || combobox_CungHoangDao.Texts == "Capricorn")
            {
                cunghoangdao = "Ma kết";
            }
            else if (combobox_CungHoangDao.Texts == "Bảo bình" || combobox_CungHoangDao.Texts == "Aquarius")
            {
                cunghoangdao = "Bảo bình";
            }
            else if (combobox_CungHoangDao.Texts == "Song ngư" || combobox_CungHoangDao.Texts == "Pisces")
            {
                cunghoangdao = "Song ngư";
            }
            string sothich = textbox_SoThich.Texts;
            bool trangthai = true;
            string fb = null;
            string it = null;
            string tt = null;
            string tw = null;
            string zalo = null;
            string gmail = null;
            string sdt = null;
            if (mxh != null)
            {
                fb = mxh[0];
                it = mxh[1];
                tt = mxh[2];
                tw = mxh[3];
                zalo = mxh[4];
                gmail = mxh[5];
                sdt = mxh[6];
            }

            int giatien = 0;
            if (textbox_SoTienThue.Texts != String.Empty)
            {
                giatien = Convert.ToInt32(textbox_SoTienThue.Texts);
            }
            string tieusu = textbox_TieuSu.Texts;
            string bietdanh = textbox_BietDanh.Texts;

            bool data = false;
           

                 data = NguoiDungDAO.Instance.ThemNguoiDung(ha, tk, mk, loaitk, hoten, gt, ngaysinh, quequan, noio, ddhenho, nghenghiep, chieucao, can_nang, vong1, vong2, vong3, sothich, cunghoangdao, trangthai, fb, it, tt, tw, zalo, gmail, sdt,giatien,tieusu,bietdanh,DateTime.Now);

                if (images.Count > 0)
                {
                    data = NguoiDungDAO.Instance.ThemAnh(tk, images);
                }
            

            return data;
        }

        void AddListTextBox()
        {
            textbox_Customs.Add(textbox_TaiKhoan);
            textbox_Customs.Add(textbox_MatKhau);
            //textbox_Customs.Add(textbox_HoVaTen);
            //textbox_Customs.Add(textbox_QueQuan);
            //textbox_Customs.Add(textbox_NoiOHienTai);
            //textbox_Customs.Add(textbox_DiaDiemhenHo);
            //textbox_Customs.Add(textbox_NgheNghiep);
            //textbox_Customs.Add(textbox_ChieuCao);
            //textbox_Customs.Add(textbox_CanNang);
            //textbox_Customs.Add(textbox_Vong1);
            //textbox_Customs.Add(textbox_Vong2);
            //textbox_Customs.Add(textbox_Vong3);
            //textbox_Customs.Add(textbox_SoThich);
        }


        private bool KiemTra(List<Textbox_Custom> ls)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].Texts.Trim().Equals(""))
                {
                    ls[i].BorderFocusColor = CaiDatDAO.Instance.color_Text_Red;
                    ls[i].BorderColor = CaiDatDAO.Instance.color_Text_Red;
                    ls[i].Focus();
                    if (!check_ngonngu)
                    {
                        label_Loi.Text = "Bạn chưa nhập " + ls[i].PlaceholderText;
                    }
                    else
                    {
                        label_Loi.Text = "You have not entered " + ls[i].PlaceholderText;
                    }
                    return false;
                    break;
                }


            }

            DataTable dt = NguoiDungDAO.Instance.getNguoiDung2(textbox_TaiKhoan.Texts);

            if (dt.Rows.Count > 0)
            {
                if (!check_ngonngu)
                {
                    label_Loi.Text = "Tài khoản đã tồn tại, vui lòng đặt lại";
                }
                else
                {
                    label_Loi.Text = "Account already exists, please reset";
                }
                return false;
            }

            //if (radioButton_Nam.Checked == false && radioButton_Nu.Checked == false && radioButton_Khac.Checked == false)
            //{
            //    if (!check_ngonngu)
            //    {
            //        label_Loi.Text = "Bạn chưa chọn giới tính";
            //    }
            //    else
            //    {
            //        label_Loi.Text = "You haven't chosen a gender yet";
            //    }
            //    return false;
            //}


            //if (combobox_CungHoangDao.SelectedItem == null)
            //{
            //    if (!check_ngonngu)
            //    {
            //        label_Loi.Text = "Bạn chưa chọn cung hoàng đạo";
            //    }
            //    else
            //    {
            //        label_Loi.Text = "You haven't chosen your zodiac sign yet";
            //    }
            //    return false;
            //}

            return true;


        }
        private void Reset()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Textbox_Custom)
                {
                    //((Textbox_Custom)x).Text = String.Empty;
                    ((Textbox_Custom)x).BorderColor = CaiDatDAO.Instance.color_BG_Blue_01;
                    ((Textbox_Custom)x).BorderFocusColor = CaiDatDAO.Instance.color_BG_Blue_02;
                }
            }
            label_Loi.ResetText();

        }
        #endregion

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
            button_Tao.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            // PictureBox
            pictureBox_AnhDaiDien.Image = Cupid.Properties.Resources.BG_Upload;

            //Textbox
            textbox_TaiKhoan.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TaiKhoan.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TaiKhoan.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_MatKhau.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_MatKhau.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_MatKhau.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_HoVaTen.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_HoVaTen.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_HoVaTen.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_BietDanh.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_BietDanh.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_BietDanh.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_QueQuan.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_QueQuan.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_QueQuan.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NoiOHienTai.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_NoiOHienTai.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_NoiOHienTai.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_DiaDiemhenHo.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_DiaDiemhenHo.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_DiaDiemhenHo.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NgheNghiep.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_NgheNghiep.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_NgheNghiep.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_ChieuCao.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_ChieuCao.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_ChieuCao.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_CanNang.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_CanNang.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_CanNang.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Vong1.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Vong1.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Vong1.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Vong2.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Vong2.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Vong2.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Vong3.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_Vong3.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_Vong3.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_SoThich.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_SoThich.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_SoThich.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_TieuSu.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_TieuSu.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_TieuSu.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_SoTienThue.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_SoTienThue.ForeColor = CaiDatDAO.Instance.color_Text_White_02;
            textbox_SoTienThue.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            // DateTimePicker
            dateTimePicker_NgaySinh.SkinColor = CaiDatDAO.Instance.color_BG_White_01;

            //Combobox
            combobox_CungHoangDao.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_CungHoangDao.ListBackColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_CungHoangDao.ListTextColor = CaiDatDAO.Instance.color_Text_White_01;

        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon_Black;

            //Button
            button_Tao.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            // PictureBox
            pictureBox_AnhDaiDien.Image = Cupid.Properties.Resources.BG_Upload_Black;

            //Textbox
            textbox_TaiKhoan.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TaiKhoan.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TaiKhoan.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_MatKhau.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_MatKhau.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_MatKhau.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_HoVaTen.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_HoVaTen.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_HoVaTen.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_BietDanh.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_BietDanh.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_BietDanh.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_QueQuan.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_QueQuan.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_QueQuan.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NoiOHienTai.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_NoiOHienTai.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_NoiOHienTai.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_DiaDiemhenHo.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_DiaDiemhenHo.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_DiaDiemhenHo.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_NgheNghiep.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_NgheNghiep.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_NgheNghiep.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_ChieuCao.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_ChieuCao.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_ChieuCao.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_CanNang.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_CanNang.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_CanNang.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Vong1.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Vong1.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Vong1.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Vong2.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Vong2.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Vong2.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_Vong3.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_Vong3.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_Vong3.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_SoThich.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_SoThich.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_SoThich.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_TieuSu.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_TieuSu.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_TieuSu.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            textbox_SoTienThue.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_SoTienThue.ForeColor = CaiDatDAO.Instance.color_Text_Black_02;
            textbox_SoTienThue.PlaceholderColor = CaiDatDAO.Instance.color_Text_DarkGray;

            // DateTimePicker
            dateTimePicker_NgaySinh.SkinColor = CaiDatDAO.Instance.color_BG_Black_01;

            //Combobox
            combobox_CungHoangDao.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_CungHoangDao.ListBackColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_CungHoangDao.ListTextColor = CaiDatDAO.Instance.color_Text_Black_01;

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
            label_GioiTinh.Text = "Hình ảnh:";
            label_GioiTinh.Text = "Giới tính:";
            label_NgaySinh.Text = "Ngày sinh:";
            label_Title.Text = "Tạo tài khoản người dùng";
            //Textbox
            textbox_TaiKhoan.PlaceholderText = "Tài khoản";
            textbox_MatKhau.PlaceholderText = "Mật khẩu";
            textbox_HoVaTen.PlaceholderText = "Họ và tên";
            textbox_BietDanh.PlaceholderText = "Biệt danh";
            textbox_QueQuan.PlaceholderText = "Quê quán";
            textbox_NoiOHienTai.PlaceholderText = "Nơi ơ hiện tại";
            textbox_DiaDiemhenHo.PlaceholderText = "Địa điểm hẹn hò";
            textbox_NgheNghiep.PlaceholderText = "Nghề nghiệp";
            textbox_ChieuCao.PlaceholderText = "Chiều cao/cm";
            textbox_CanNang.PlaceholderText = "Cân nặng/kg";
            textbox_Vong1.PlaceholderText = "Vòng 1/cm";
            textbox_Vong2.PlaceholderText = "Vòng 2/cm";
            textbox_Vong3.PlaceholderText = "Vòng 3/cm";
            textbox_SoThich.PlaceholderText = "Sở thích";
            textbox_TieuSu.PlaceholderText = "Tiểu sử";
            textbox_SoTienThue.PlaceholderText = "Số tiền thuê/1h";
            //RadioButton
            radioButton_Nam.Text = "Nam";
            radioButton_Nu.Text = "Nữ";
            radioButton_Khac.Text = "Khác";
            //Combobox
            combobox_CungHoangDao.Texts = "Cung hoàng đạo";
            //Button
            button_Tao.Text = "Tạo";

            combobox_CungHoangDao.Items.Add("Bạch dương");
            combobox_CungHoangDao.Items.Add("Kim ngưu");
            combobox_CungHoangDao.Items.Add("Song tử");
            combobox_CungHoangDao.Items.Add("Cự giải");
            combobox_CungHoangDao.Items.Add("Sư tử");
            combobox_CungHoangDao.Items.Add("Xử nữ");
            combobox_CungHoangDao.Items.Add("Thiên bình");
            combobox_CungHoangDao.Items.Add("Bọ cạp");
            combobox_CungHoangDao.Items.Add("Nhân mã");
            combobox_CungHoangDao.Items.Add("Ma kết");
            combobox_CungHoangDao.Items.Add("Bảo bình");
            combobox_CungHoangDao.Items.Add("Song ngư");

        }

        private void textbox_SoTienThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        public void Change_Language_EN()
        {
            //Label
            label_HinhAnh.Text = "Image:";
            label_GioiTinh.Text = "Gender:";
            label_NgaySinh.Text = "Date of birth:";
            label_Title.Text = "Create a user account";
            //Textbox
            textbox_TaiKhoan.PlaceholderText = "Username";
            textbox_MatKhau.PlaceholderText = "Password";
            textbox_HoVaTen.PlaceholderText = "Full name";
            textbox_BietDanh.PlaceholderText = "Nick name";
            textbox_QueQuan.PlaceholderText = "Place of origin";
            textbox_NoiOHienTai.PlaceholderText = "Place of residence";
            textbox_DiaDiemhenHo.PlaceholderText = "Dating place";
            textbox_NgheNghiep.PlaceholderText = "Career";
            textbox_ChieuCao.PlaceholderText = "Height/cm";
            textbox_CanNang.PlaceholderText = "Weight/kg";
            textbox_Vong1.PlaceholderText = "Bust/cm";
            textbox_Vong2.PlaceholderText = "Waist/cm";
            textbox_Vong3.PlaceholderText = "Hip/cm";
            textbox_SoThich.PlaceholderText = "Hobbies";
            textbox_TieuSu.PlaceholderText = "Biography";
            textbox_SoTienThue.PlaceholderText = "Hired pricing/1h";

            //RadioButton
            radioButton_Nam.Text = "Male";
            radioButton_Nu.Text = "Female";
            radioButton_Khac.Text = "Other";
            //Combo box
            combobox_CungHoangDao.Texts = "Zodiac";
            //Button
            button_Tao.Text = "Create";

            combobox_CungHoangDao.Items.Add("Aries");
            combobox_CungHoangDao.Items.Add("Taurus");
            combobox_CungHoangDao.Items.Add("Gemini");
            combobox_CungHoangDao.Items.Add("Cancer");
            combobox_CungHoangDao.Items.Add("Leo");
            combobox_CungHoangDao.Items.Add("Virgo");
            combobox_CungHoangDao.Items.Add("Libra");
            combobox_CungHoangDao.Items.Add("Scorpion");
            combobox_CungHoangDao.Items.Add("Sagittarius");
            combobox_CungHoangDao.Items.Add("Capricorn");
            combobox_CungHoangDao.Items.Add("Aquarius");
            combobox_CungHoangDao.Items.Add("Pisces");
        }
        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            button_Tao.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_TaiKhoan.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TaiKhoan.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_MatKhau.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_MatKhau.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_HoVaTen.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_HoVaTen.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_BietDanh.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_BietDanh.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_QueQuan.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_QueQuan.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_NoiOHienTai.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_NoiOHienTai.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_DiaDiemhenHo.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_DiaDiemhenHo.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_NgheNghiep.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_NgheNghiep.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_ChieuCao.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_ChieuCao.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_CanNang.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_CanNang.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_Vong1.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Vong1.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_Vong2.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Vong2.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_Vong3.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_Vong3.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_SoThich.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_SoThich.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_TieuSu.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_TieuSu.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            textbox_SoTienThue.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_SoTienThue.BorderFocusColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            radioButton_Nam.CheckedColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            radioButton_Nu.CheckedColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            radioButton_Khac.CheckedColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            dateTimePicker_NgaySinh.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            combobox_CungHoangDao.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_CungHoangDao.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            pictureBox_AnhDaiDien.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_AnhDaiDien.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;

            pictureBox_Idol.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_DienThoai.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_HinhAnh.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            panel_line.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}
