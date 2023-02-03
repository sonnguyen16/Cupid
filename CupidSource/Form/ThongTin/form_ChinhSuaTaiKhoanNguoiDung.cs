using Cupid.DAO;
using Cupid.DTO;
using Cupid.Toolbox_Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupid
{
    public partial class form_ChinhSuaTaiKhoanNguoiDung : Form
    {
        List<Textbox_Custom> textbox_Customs = new List<Textbox_Custom>();
        List<EditCompo> listEdit = new List<EditCompo>();
        List<string> prop;
        string gioitinh, cunghoangdao, tieusu, giathue,ngaysinh;
        bool idol;
        public List<Image> images = new List<Image>();
        Image avt = null;
        public DataGridViewRow row;
        public List<string> mxh;
        public List<string> mxh2;
        public List<Image> images2 = new List<Image>();
        string tk;
        bool check_giaodien, check_ngonngu;

        public form_ChinhSuaTaiKhoanNguoiDung(DataGridViewRow row, string tk)
        {
            InitializeComponent();
            this.row = row;
            this.tk = tk;
            mxh = new List<string>();
            ThemMxh();
            mxh2 = new List<string>(mxh);
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            textbox_TaiKhoan.Enabled = false;
            label_Loi.ResetText();
            label_ThoiGianKhoaConLai.ResetText();
            pictureBox_AnhDaiDien.Image = null;
            images = new List<Image>();
            textbox_TaiKhoan.Texts = row.Cells[0].Value.ToString();
            
            textbox_MatKhau.Texts = row.Cells[1].Value.ToString();
            if (row.Cells[4].Value != DBNull.Value)
            {
                byte[] img = (byte[])row.Cells[3].Value;
                pictureBox_AnhDaiDien.Image = DataProvider.Instance.Base64ToImage(img);
            }

            if ((int)row.Cells[2].Value == 2)
            {
                this.pictureBox_Idol.IconFont = FontAwesome.Sharp.IconFont.Solid;
            }
            else
            {
                this.pictureBox_Idol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            }

            textbox_HoVaTen.Texts = row.Cells[4].Value.ToString();
            dateTimePicker_NgaySinh.Value = (DateTime)row.Cells[5].Value;
            if (row.Cells[6].Value.ToString().Equals("Nam"))
            {
                radioButton_Nam.Checked = true;
            }
            else if (row.Cells[6].Value.ToString().Equals("Nữ"))
            {
                radioButton_Nu.Checked = true;
            }
            else
            {
                radioButton_Khac.Checked = true;
            }

            textbox_QueQuan.Texts = row.Cells[7].Value.ToString();
            textbox_NoiOHienTai.Texts = row.Cells[8].Value.ToString();
            textbox_DiaDiemhenHo.Texts = row.Cells[9].Value.ToString();
            textbox_NgheNghiep.Texts = row.Cells[10].Value.ToString();
            textbox_ChieuCao.Texts = row.Cells[11].Value.ToString();
            textbox_CanNang.Texts = row.Cells[12].Value.ToString();
            textbox_Vong1.Texts = row.Cells[13].Value.ToString();
            textbox_Vong2.Texts = row.Cells[14].Value.ToString();
            textbox_Vong3.Texts = row.Cells[15].Value.ToString();
            if (!check_ngonngu)
            {
                if (row.Cells[16].Value.ToString() == "Bạch dương")
                {
                    combobox_CungHoangDao.Texts = "Bạch dương";
                }
                else if (row.Cells[16].Value.ToString() == "Kim ngưu")
                {
                    combobox_CungHoangDao.Texts = "Kim ngưu";
                }
                else if (row.Cells[16].Value.ToString() == "Song tử")
                {
                    combobox_CungHoangDao.Texts = "Song tử";
                }
                else if (row.Cells[16].Value.ToString() == "Cự giải")
                {
                    combobox_CungHoangDao.Texts = "Cự giải";
                }
                else if (row.Cells[16].Value.ToString() == "Sư tử")
                {
                    combobox_CungHoangDao.Texts = "Sư tử";
                }
                else if (row.Cells[16].Value.ToString() == "Xử nữ")
                {
                    combobox_CungHoangDao.Texts = "Xử nữ";
                }
                else if (row.Cells[16].Value.ToString() == "Thiên bình")
                {
                    combobox_CungHoangDao.Texts = "Thiên bình";
                }
                else if (row.Cells[16].Value.ToString() == "Bọ cạp")
                {
                    combobox_CungHoangDao.Texts = "Bọ cạp";
                }
                else if (row.Cells[16].Value.ToString() == "Nhân mã")
                {
                    combobox_CungHoangDao.Texts = "Nhân mã";
                }
                else if (row.Cells[16].Value.ToString() == "Ma kết")
                {
                    combobox_CungHoangDao.Texts = "Ma kết";
                }
                else if (row.Cells[16].Value.ToString() == "Bảo bình")
                {
                    combobox_CungHoangDao.Texts = "Bảo bình";
                }
                else if (row.Cells[16].Value.ToString() == "Song ngư")
                {
                    combobox_CungHoangDao.Texts = "Song ngư";
                }
            }
            else
            {
                if (row.Cells[16].Value.ToString() == "Bạch dương")
                {
                    combobox_CungHoangDao.Texts = "Aries";
                }
                else if (row.Cells[16].Value.ToString() == "Kim ngưu")
                {
                    combobox_CungHoangDao.Texts = "Taurus";
                }
                else if (row.Cells[16].Value.ToString() == "Song tử")
                {
                    combobox_CungHoangDao.Texts = "Gemini";
                }
                else if (row.Cells[16].Value.ToString() == "Cự giải")
                {
                    combobox_CungHoangDao.Texts = "Cancer";
                }
                else if (row.Cells[16].Value.ToString() == "Sư tử")
                {
                    combobox_CungHoangDao.Texts = "Leo";
                }
                else if (row.Cells[16].Value.ToString() == "Xử nữ")
                {
                    combobox_CungHoangDao.Texts = "Virgo";
                }
                else if (row.Cells[16].Value.ToString() == "Thiên bình")
                {
                    combobox_CungHoangDao.Texts = "Libra";
                }
                else if (row.Cells[16].Value.ToString() == "Bọ cạp")
                {
                    combobox_CungHoangDao.Texts = "Scorpion";
                }
                else if (row.Cells[16].Value.ToString() == "Nhân mã")
                {
                    combobox_CungHoangDao.Texts = "Sagittarius";
                }
                else if (row.Cells[16].Value.ToString() == "Ma kết")
                {
                    combobox_CungHoangDao.Texts = "Capricorn";
                }
                else if (row.Cells[16].Value.ToString() == "Bảo bình")
                {
                    combobox_CungHoangDao.Texts = "Aquarius";
                }
                else if (row.Cells[16].Value.ToString() == "Song ngư")
                {
                    combobox_CungHoangDao.Texts = "Pisces";
                }
            }
            textbox_SoThich.Texts = row.Cells[17].Value.ToString();
            if ((bool)row.Cells[18].Value == true)
            {
                this.pictureBox_Lock.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            }
            else
            {
                this.pictureBox_Lock.IconChar = FontAwesome.Sharp.IconChar.Lock;
                SoNgayKhoaConLai();
            }
            textbox_SoTienThue.Texts = row.Cells[28].Value.ToString();
            textbox_TieuSu.Texts = row.Cells[29].Value.ToString();
            textbox_BietDanh.Texts = row.Cells[30].Value.ToString();
        }

        private void ThemMxh()
        {
            mxh.Add(row.Cells[19].Value.ToString());
            mxh.Add(row.Cells[20].Value.ToString());
            mxh.Add(row.Cells[21].Value.ToString());
            mxh.Add(row.Cells[22].Value.ToString());
            mxh.Add(row.Cells[23].Value.ToString());
            mxh.Add(row.Cells[24].Value.ToString());
            mxh.Add(row.Cells[25].Value.ToString());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #region Methods


        void AddListTextBox()
        {
            textbox_Customs.Add(textbox_TaiKhoan);
            textbox_Customs.Add(textbox_MatKhau);
            textbox_Customs.Add(textbox_HoVaTen);
            textbox_Customs.Add(textbox_QueQuan);
            textbox_Customs.Add(textbox_NoiOHienTai);
            textbox_Customs.Add(textbox_DiaDiemhenHo);
            textbox_Customs.Add(textbox_NgheNghiep);
            textbox_Customs.Add(textbox_ChieuCao);
            textbox_Customs.Add(textbox_CanNang);
            textbox_Customs.Add(textbox_Vong1);
            textbox_Customs.Add(textbox_Vong2);
            textbox_Customs.Add(textbox_Vong3);
            textbox_Customs.Add(textbox_SoThich);
        }


        private bool KiemTra(List<Textbox_Custom> ls)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].Texts.Trim().Equals(""))
                {
                    ls[i].BorderFocusColor = Color.Red;
                    ls[i].BorderColor = Color.Red;
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

            if (radioButton_Nam.Checked == false && radioButton_Nu.Checked == false && radioButton_Khac.Checked == false)
            {
                label_Loi.Text = "Bạn chưa chọn giới tính";
                return false;
            }


            if (combobox_CungHoangDao.Texts.Equals(""))
            {
                label_Loi.Text = "Bạn chưa chọn cung hoàng đạo";
                return false;
            }

            return true;


        }

        private void Reset()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Textbox_Custom)
                {
                    //((Textbox_Custom)x).Text = String.Empty;
                    ((Textbox_Custom)x).BorderColor = Color.FromArgb(157, 217, 243);
                    ((Textbox_Custom)x).BorderFocusColor = Color.FromArgb(119, 195, 236);
                }
            }
            label_Loi.ResetText();

        }

        private bool SuaNguoiDung()
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
            byte[] ha = null;
            if (pictureBox_AnhDaiDien.Image != null)
            {
                ha = DataProvider.Instance.ImageToByte2(pictureBox_AnhDaiDien.Image);
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
            float chieucao = float.Parse(textbox_ChieuCao.Texts);
            float can_nang = float.Parse(textbox_CanNang.Texts);
            float vong1 = float.Parse(textbox_Vong1.Texts);
            float vong2 = float.Parse(textbox_Vong2.Texts);
            float vong3 = float.Parse(textbox_Vong3.Texts);
            string cunghoangdao = "";
            if (combobox_CungHoangDao.Texts == "Bạch dương" || combobox_CungHoangDao.Texts == "Aries")
            {
                cunghoangdao = "Bạch dương";
            }
            else if (combobox_CungHoangDao.Texts == "Kim ngưu" || combobox_CungHoangDao.Texts == "Taurus")
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
            string fb = mxh[0];
            string it = mxh[1];
            string tt = mxh[2];
            string tw = mxh[3];
            string gmail = mxh[5];
            string zalo = mxh[4];
            string sdt = mxh[6];
            
           
            if (this.pictureBox_Lock.IconChar == FontAwesome.Sharp.IconChar.Lock)
            {
                trangthai = false;
            }

            int giatien = 0;
            if (textbox_SoTienThue.Texts != String.Empty)
            {
                giatien = Convert.ToInt32(textbox_SoTienThue.Texts);
            }
            string tieusu = textbox_TieuSu.Texts;
            string bietdanh = textbox_BietDanh.Texts;

            bool data = false;

            if (pictureBox_AnhDaiDien.Image != null)
            {
                    data = NguoiDungDAO.Instance.SuaNguoiDung(ha, tk, mk, loaitk, hoten, gt, ngaysinh, quequan, noio, ddhenho, nghenghiep, chieucao, can_nang, vong1, vong2, vong3, sothich, cunghoangdao, trangthai, fb, it, tt, tw, zalo, gmail, sdt,giatien,tieusu,bietdanh);
               
                if (images.Count > 0)
                {

                    data = NguoiDungDAO.Instance.XoaHinhAnh(tk);
                    data = NguoiDungDAO.Instance.ThemAnh(tk, images);
                }
                else
                {
                    data = NguoiDungDAO.Instance.XoaHinhAnh(tk);
                }
            }
            else
            {
                    data = NguoiDungDAO.Instance.SuaNguoiDungKoAvatar(tk, mk, loaitk, hoten, gt, ngaysinh, quequan, noio, ddhenho, nghenghiep, chieucao, can_nang, vong1, vong2, vong3, sothich, cunghoangdao, trangthai, fb, it, tt, tw, zalo, gmail, sdt);
             
                if (images.Count > 0)
                {
                    data = NguoiDungDAO.Instance.XoaHinhAnh(tk);
                    data = NguoiDungDAO.Instance.ThemAnh(tk, images);
                }
                else
                {
                    data = NguoiDungDAO.Instance.XoaHinhAnh(tk);

                }
            }

            return data;
        }

        public void SoNgayKhoaConLai()
        {
            DataTable dt = NguoiDungDAO.Instance.SoNgayKhoaConLai(textbox_TaiKhoan.Texts);

            if (dt.Rows.Count > 0)
            {
                label_ThoiGianKhoaConLai.Text = dt.Rows[0][0].ToString() + " ngày";
            }
        }
        #endregion

        #region Events
        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void button_Close_Click(object sender, EventArgs e)
        {
            var f1 = (form_ThongTin)this.Owner;
            if (this.pictureBox_Idol.IconFont == FontAwesome.Sharp.IconFont.Auto)
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
            f1.OnOffBtn(false);
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
            string newtk = tk;
            form_ThongTinLienLac ttll = new form_ThongTinLienLac(this.mxh, newtk);
            ttll.Owner = this;
            ttll.ShowDialog();
        }
        private void pictureBox_Lock_Click(object sender, EventArgs e)
        {
            if (this.pictureBox_Lock.IconChar == FontAwesome.Sharp.IconChar.Lock)
            {
                this.pictureBox_Lock.IconChar = FontAwesome.Sharp.IconChar.Unlock;
                form_MoKhoaTaiKhoanNguoiDung ktknd = new form_MoKhoaTaiKhoanNguoiDung(tk);
                ktknd.Owner = this;
                ktknd.ShowDialog();
            }
            else
            {
                this.pictureBox_Lock.IconChar = FontAwesome.Sharp.IconChar.Lock;
                form_KhoaTaiKhoanNguoiDung mktknd = new form_KhoaTaiKhoanNguoiDung(tk);
                mktknd.Owner = this;
                mktknd.ShowDialog();
            }
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

        void KiemTraChinhSua()
        {
            for (int i = 0; i < textbox_Customs.Count; i++)
            {
                if (prop[i] != textbox_Customs[i].Texts)
                {
                    listEdit.Add(new EditCompo(textbox_Customs[i].PlaceholderText,prop[i],textbox_Customs[i].Texts));
                }
            }
            if (combobox_CungHoangDao.Texts != cunghoangdao)
            {
                listEdit.Add(new EditCompo("Cung hoàng đạo", cunghoangdao, combobox_CungHoangDao.Texts));
            }
            if (textbox_TieuSu.Texts != tieusu)
            {
                listEdit.Add(new EditCompo("Tiểu sử", tieusu, textbox_TieuSu.Texts));
            }
            if (textbox_SoTienThue.Texts != giathue)
            {
                listEdit.Add(new EditCompo("Giá thuê", giathue, textbox_SoTienThue.Texts));

            }
            if (ngaysinh != dateTimePicker_NgaySinh.Text)
            {
                listEdit.Add(new EditCompo("Ngày sinh", ngaysinh, dateTimePicker_NgaySinh.Text));

            }
            foreach (Control item in this.Controls)
            {
                if (item is RadioButton_Custom)
                {
                    if (((RadioButton_Custom)item).Checked)
                    {
                        if (((RadioButton_Custom)item).Text != gioitinh )
                        {
                            listEdit.Add(new EditCompo("Giới tính", gioitinh, item.Text));
                            break;
                        }
                    }
                }
            }
            if (images.Count > images2.Count)
            {
                listEdit.Add(new EditCompo("Thêm hình ảnh", "", ""));

            }
            else if (images.Count < images2.Count)
            {
                listEdit.Add(new EditCompo("Xóa hình ảnh", "", ""));
            }
            else
            {
                for (int i = 0; i < images.Count; i++)
                {
                    if (images[i] != images2[i])
                    {
                        listEdit.Add(new EditCompo("Chỉnh sửa hình ảnh", "", ""));
                        break;
                    }
                }
            }
            
            if (mxh[0] != mxh2[0])
            {
                listEdit.Add(new EditCompo("Facebook ", mxh2[0], mxh[0]));
            }
            if (mxh[1] != mxh2[1])
            {
                listEdit.Add(new EditCompo("Instagram ", mxh2[1], mxh[1]));
            }
            if (mxh[2] != mxh2[2])
            {
                listEdit.Add(new EditCompo("Tiktok ", mxh2[2], mxh[2]));
            }
            if (mxh[3] != mxh2[3])
            {
                listEdit.Add(new EditCompo("Twitter ", mxh2[3], mxh[3]));
            }
            if (mxh[4] != mxh2[4])
            {
                listEdit.Add(new EditCompo("Zalo ", mxh2[4], mxh[4]));
            }
            if (mxh[5] != mxh2[5])
            {
                listEdit.Add(new EditCompo("Gmail ", mxh2[5], mxh[5]));
            }
            if (mxh[6] != mxh2[6])
            {
                listEdit.Add(new EditCompo("Số điện thoại ", mxh2[6], mxh[6]));
            }
           

            if (pictureBox_AnhDaiDien.Image != avt)
            {
                listEdit.Add(new EditCompo("Chỉnh sửa ảnh đại diện ", "", ""));

            }
            if (idol == false)
            {
                if (this.pictureBox_Idol.IconFont == FontAwesome.Sharp.IconFont.Solid)
                {
                    listEdit.Add(new EditCompo("Cấp quyền idol cho người dùng ", "", ""));

                }
            }
            else
            {
                if (this.pictureBox_Idol.IconFont == FontAwesome.Sharp.IconFont.Auto)
                {
                    listEdit.Add(new EditCompo("Hủy quyền idol của người dùng ", "", ""));

                }
            }

        }

        private void button_ChinhSua_Click(object sender, EventArgs e)
        {
            Reset();
            if (KiemTra(textbox_Customs))
            {
                if (SuaNguoiDung())
                {
                    KiemTraChinhSua();
                    images.Clear();
                    if (listEdit.Count > 0)
                    {
                        string noidung = "Chỉnh sửa tài khoản " + textbox_TaiKhoan.Texts + " : ";
                        for (int i = 0; i < listEdit.Count; i++)
                        {
                            noidung += " " + Environment.NewLine + listEdit[i].Control + " : " + listEdit[i].OldValue + " ► " + listEdit[i].NewValue;
                        }
                        LichSuHoatDongDAO.Instance.insertLSHD(this.tk, 1, noidung);
                    }
                    var f1 = (form_ThongTin)this.Owner;
                    if (this.pictureBox_Idol.IconFont == FontAwesome.Sharp.IconFont.Auto)
                    {
                        f1.button_BinhThuong_Click(f1.btn, f1.ea);
                        f1.ActivateButton(f1.button_BinhThuong);
                        f1.btn = f1.button_BinhThuong;
                        f1.loaitk = 1;
                    }
                    else
                    {
                        f1.button_Idol_Click(f1.btn1, f1.ea1);
                        f1.ActivateButton(f1.button_Idol);
                        f1.btn = f1.button_Idol;
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

        private void pictureBox_AnhDaiDien_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)|*.png;*.jpg";
            openFile.Title = "Chọn hình ảnh";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //pictureBox_AnhDaiDien.Image = Image.FromFile(openFile.FileName);
                //pictureBox_AnhDaiDien.SizeMode = PictureBoxSizeMode.Zoom;
                form_CapNhatAnhDaiDien f = new form_CapNhatAnhDaiDien(tk, Image.FromFile(openFile.FileName));
                f.Owner = this;
                f.Show();
            }
        }

        private void form_ChinhSuaTaiKhoanNguoiDung_Load(object sender, EventArgs e)
        {
            AddListTextBox();
            this.prop = new List<string>();
            foreach (Textbox_Custom item in textbox_Customs)
            {
                prop.Add(item.Texts);
            }
            if (radioButton_Nam.Checked == true)
            {
                gioitinh = "Nam";
            }
            else if (radioButton_Nu.Checked == true)
            {
                gioitinh = "Nữ";
            }
            else
            {
                gioitinh = "Khác";
            }

            if (this.pictureBox_Idol.IconFont == FontAwesome.Sharp.IconFont.Solid)
            {
                idol = true;
            }
            else
            {
                idol= false;
            }
            tieusu = textbox_TieuSu.Texts;
            giathue = textbox_SoTienThue.Texts;
            cunghoangdao = combobox_CungHoangDao.Texts;
            ngaysinh = dateTimePicker_NgaySinh.Text;
            DataTable dt = NguoiDungDAO.Instance.getHinhAnh(textbox_TaiKhoan.Texts);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    images.Add(DataProvider.Instance.Base64ToImage((byte[])dt.Rows[i][0]));
                }
            }
            images2 = new List<Image>(images);
            if (pictureBox_AnhDaiDien.Image != null)
            {
                pictureBox_AnhDaiDien.BackgroundImage = null;
                avt = pictureBox_AnhDaiDien.Image;
            }
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
            button_ChinhSua.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            // PictureBox
            pictureBox_AnhDaiDien.BackgroundImage = Cupid.Properties.Resources.BG_Upload;

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
            button_ChinhSua.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            // PictureBox
            pictureBox_AnhDaiDien.BackgroundImage = Cupid.Properties.Resources.BG_Upload_Black;

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
            label_Title.Text = "Chỉnh sửa tài khoản người dùng";
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
            button_ChinhSua.Text = "Chỉnh sửa";

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
            label_Title.Text = "Edit a user account";
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
            button_ChinhSua.Text = "Edit";

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

            button_ChinhSua.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

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
            pictureBox_Lock.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_HinhAnh.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            label_ThoiGianKhoaConLai.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            panel_Line.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}
