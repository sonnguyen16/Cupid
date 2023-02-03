using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Cupid.DAO;
using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using System.Diagnostics;

namespace Cupid
{
    public partial class form_XemThongTin : Form
    {
        string tk;
        bool check_giaodien, check_ngonngu;
        List<Image> images;
        DataGridViewRow row;
        List<PictureBox> pictureBoxes = new List<PictureBox> ();
        public form_XemThongTin(DataGridViewRow row,string tk)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
            label_ThoiGianKhoaConLai.ResetText();
            this.row = row;
            LoadImage();
            AddPictureBox();
            foreach  (PictureBox p in pictureBoxes)
            {
                p.Visible = false;
            }
            ShowImage();
            label_Value_TaiKhoan.Text = row.Cells[0].Value.ToString();
            label_Value_MatKhau.Text = row.Cells[1].Value.ToString();
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

            label_TenNguoiDung.Text = row.Cells[4].Value.ToString();
            label_Value_NgaySinh.Text = System.Convert.ToDateTime(row.Cells[5].Value).ToString("dd-MM-yyyy");
            if (!check_ngonngu)
            {
                label_Value_GioiTinh.Text = row.Cells[6].Value.ToString();
            }
            else
            {
                if(row.Cells[6].Value.ToString() == "Nam")
                {
                    label_Value_GioiTinh.Text = "Male";
                }
                else if(row.Cells[6].Value.ToString() == "Nữ")
                {
                    label_Value_GioiTinh.Text = "Female";
                }
                else
                {
                    label_Value_GioiTinh.Text = "Other";
                }
            }
            label_Value_QueQuan.Text = row.Cells[7].Value.ToString();
            label_Value_NoiOHienTai.Text = row.Cells[8].Value.ToString();
            label_Value_DiaDiemHenHo.Text = row.Cells[9].Value.ToString();
            label_Value_NgheNghiep.Text = row.Cells[10].Value.ToString();
            label_Value_ChieuCao.Text = row.Cells[11].Value.ToString() + "cm";
            if (!check_ngonngu)
            {
                if (row.Cells[16].Value.ToString() == "Bạch dương")
                {
                    label_Value_CungHoangDao.Text = "Bạch dương";
                }
                else if (row.Cells[16].Value.ToString() == "Kim ngưu")
                {
                    label_Value_CungHoangDao.Text = "Kim ngưu";
                }
                else if (row.Cells[16].Value.ToString() == "Song tử")
                {
                    label_Value_CungHoangDao.Text = "Song tử";
                }
                else if (row.Cells[16].Value.ToString() == "Cự giải")
                {
                    label_Value_CungHoangDao.Text = "Cự giải";
                }
                else if (row.Cells[16].Value.ToString() == "Sư tử")
                {
                    label_Value_CungHoangDao.Text = "Sư tử";
                }
                else if (row.Cells[16].Value.ToString() == "Xử nữ")
                {
                    label_Value_CungHoangDao.Text = "Xử nữ";
                }
                else if (row.Cells[16].Value.ToString() == "Thiên bình")
                {
                    label_Value_CungHoangDao.Text = "Thiên bình";
                }
                else if (row.Cells[16].Value.ToString() == "Bọ cạp")
                {
                    label_Value_CungHoangDao.Text = "Bọ cạp";
                }
                else if (row.Cells[16].Value.ToString() == "Nhân mã")
                {
                    label_Value_CungHoangDao.Text = "Nhân mã";
                }
                else if (row.Cells[16].Value.ToString() == "Ma kết")
                {
                    label_Value_CungHoangDao.Text = "Ma kết";
                }
                else if (row.Cells[16].Value.ToString() == "Bảo bình")
                {
                    label_Value_CungHoangDao.Text = "Bảo bình";
                }
                else if (row.Cells[16].Value.ToString() == "Song ngư")
                {
                    label_Value_CungHoangDao.Text = "Song ngư";
                }
            }
            else
            {
                if (row.Cells[16].Value.ToString() == "Bạch dương")
                {
                    label_Value_CungHoangDao.Text = "Aries";
                }
                else if (row.Cells[16].Value.ToString() == "Kim ngưu")
                {
                    label_Value_CungHoangDao.Text = "Taurus";
                }
                else if (row.Cells[16].Value.ToString() == "Song tử")
                {
                    label_Value_CungHoangDao.Text = "Gemini";
                }
                else if (row.Cells[16].Value.ToString() == "Cự giải")
                {
                    label_Value_CungHoangDao.Text = "Cancer";
                }
                else if (row.Cells[16].Value.ToString() == "Sư tử")
                {
                    label_Value_CungHoangDao.Text = "Leo";
                }
                else if (row.Cells[16].Value.ToString() == "Xử nữ")
                {
                    label_Value_CungHoangDao.Text = "Virgo";
                }
                else if (row.Cells[16].Value.ToString() == "Thiên bình")
                {
                    label_Value_CungHoangDao.Text = "Libra";
                }
                else if (row.Cells[16].Value.ToString() == "Bọ cạp")
                {
                    label_Value_CungHoangDao.Text = "Scorpion";
                }
                else if (row.Cells[16].Value.ToString() == "Nhân mã")
                {
                    label_Value_CungHoangDao.Text = "Sagittarius";
                }
                else if (row.Cells[16].Value.ToString() == "Ma kết")
                {
                    label_Value_CungHoangDao.Text = "Capricorn";
                }
                else if (row.Cells[16].Value.ToString() == "Bảo bình")
                {
                    label_Value_CungHoangDao.Text = "Aquarius";
                }
                else if (row.Cells[16].Value.ToString() == "Song ngư")
                {
                    label_Value_CungHoangDao.Text = "Pisces";
                }
            }
            label_Value_CanNang.Text = row.Cells[12].Value.ToString() + "kg";
            label_Value_Vong1.Text = row.Cells[13].Value.ToString() + "cm";
            label_Value_Vong2.Text = row.Cells[14].Value.ToString() + "cm";
            label_Value_Vong3.Text = row.Cells[15].Value.ToString() + "cm";
            label_Value_SoThich.Text = row.Cells[17].Value.ToString();
            label_Value_SoDienThoai.Text = "+84" + row.Cells[25].Value.ToString();
            if ((bool)row.Cells[18].Value == true)
            {
                this.pictureBox_Lock.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            }
            else
            {
                this.pictureBox_Lock.IconChar = FontAwesome.Sharp.IconChar.Lock;
                SoNgayKhoaConLai();
            }
            if (row.Cells[27].Value.ToString() != "0")
            {
                label_Value_SoDu.Text = Convert.ToDouble(row.Cells[27].Value).ToString("###,###,###,###");
            }
            if (row.Cells[28].Value.ToString() != "0")
            {
                label_Value_SoTienThueTren1Gio.Text = Convert.ToDouble(row.Cells[28].Value).ToString("###,###,###,###");

            }
            label_Value_TieuSu.Text = row.Cells[29].Value.ToString();
            label_BietDanh.Text = row.Cells[30].Value.ToString();
            Change_Position_Coin();

        }
        public void Change_Position_Coin()
        {
            int x = 801;
            pictureBox_Coin.Location = new Point(x + 3 * label_Value_SoDu.Text.Length, 75);
        }
        void ShowImage()
        {
            if (images.Count> 0)
            {
                if (images.Count < 5)
                {
                    for (int i = pictureBoxes.Count - 1; i >= images.Count; i--)
                    {
                        pictureBoxes[i].Visible = false;
                        pictureBoxes.RemoveAt(i);
                    }
                }
                for (int i = 0; i < pictureBoxes.Count; i++)
                {
                    pictureBoxes[i].Visible=true;
                    pictureBoxes[i].Image = images[i];
                }
                if (images.Count > 5)
                {
                        pictureBox_Image_05.Image = CombineAndResizeTwoImages(images[4], Cupid.Properties.Resources.Image_Blur, 100, 100);
                }
                if (images.Count == 5)
                {
                    pictureBox_Image_05.Image = images[4];
                }
            }
        }
        private void AddPictureBox()
        {
            pictureBoxes.Add(pictureBox_Image_01);
            pictureBoxes.Add(pictureBox_Image_02);
            pictureBoxes.Add(pictureBox_Image_03);
            pictureBoxes.Add(pictureBox_Image_04);
            pictureBoxes.Add(pictureBox_Image_05);

        }

        public void SoNgayKhoaConLai()
        {
            DataTable dt = NguoiDungDAO.Instance.SoNgayKhoaConLai(row.Cells[0].Value.ToString());

            if (dt.Rows.Count > 0)
            {
                label_ThoiGianKhoaConLai.Text = dt.Rows[0][0].ToString() + " ngày";
            }
        }
        void LoadImage()
        {
            DataTable dt = NguoiDungDAO.Instance.getHinhAnh(row.Cells[0].Value.ToString());
            images = new List<Image>();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    images.Add(DataProvider.Instance.Base64ToImage((byte[])dt.Rows[i][0]));
                }
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

        private void button_Facebook_Click(object sender, EventArgs e)
        {
           
                if (row.Cells[19].Value.ToString() != "")
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo
                    {
                        FileName = row.Cells[19].Value.ToString(),
                        UseShellExecute = true
                    };
                    Process.Start(psInfo);
                }

        }

        private void button_Youtube_Click(object sender, EventArgs e)
        {
              
        }

        private void button_Tiktok_Click(object sender, EventArgs e)
        {
                if (row.Cells[21].Value.ToString() != "")
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo
                    {
                        FileName = row.Cells[21].Value.ToString(),
                        UseShellExecute = true
                    };
                    Process.Start(psInfo);
                }
            
        }

        private void button_Twitter_Click(object sender, EventArgs e)
        {
            if (row.Cells[22].Value.ToString() != "")
            {
                ProcessStartInfo psInfo = new ProcessStartInfo
                {
                    FileName = row.Cells[22].Value.ToString(),
                    UseShellExecute = true
                };
                Process.Start(psInfo);
            }
        }

        private void button_Instagram_Click(object sender, EventArgs e)
        {
           
                if (row.Cells[20].Value.ToString() != "")
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo
                    {
                        FileName = row.Cells[20].Value.ToString(),
                        UseShellExecute = true
                    };
                    Process.Start(psInfo);
                }
           
        }
        public static Bitmap CombineAndResizeTwoImages(Image image1, Image image2, int width, int height)
        {
            //a holder for the result
            Bitmap result = new Bitmap(width, height);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the images into the target bitmap
                graphics.DrawImage(image1, 0, 0, result.Width, result.Height);
                graphics.DrawImage(image2, 0, 0, result.Width, result.Height);
            }

            //return the resulting bitmap
            return result;
        }
        private void form_XemThongTin_Load(object sender, EventArgs e)
        {
            Load_Image_Opacity();            
        }
        public void Load_Image_Opacity()
        {
            Label label_SoAnh = new Label();
            pictureBox_Image_05.Controls.Add(label_SoAnh);
            label_SoAnh.Text = "+" + (images.Count - 5).ToString();
            label_SoAnh.Location = new Point(0, 35);
            label_SoAnh.Font = new Font("Arial", 24, FontStyle.Bold);
            label_SoAnh.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            label_SoAnh.BackColor = Color.Transparent;
            label_SoAnh.AutoSize = false;
            label_SoAnh.Size = new Size(105, 35);
            label_SoAnh.TextAlign = ContentAlignment.MiddleCenter;
            label_SoAnh.BringToFront();
            label_SoAnh.MouseClick += label_SoAnh_MouseClick;
            if (images.Count == 5)
            {
                label_SoAnh.Visible = false;
            }
        }
        private void pictureBox_Image_01_Click(object sender, EventArgs e)
        {
            form_XemThongTinHinhAnhNguoiDung hxtthand = new form_XemThongTinHinhAnhNguoiDung(tk,images,pictureBox_Image_01.Image,0);
            hxtthand.ShowDialog();
        }
        private void pictureBox_Image_02_Click(object sender, EventArgs e)
        {
            form_XemThongTinHinhAnhNguoiDung hxtthand = new form_XemThongTinHinhAnhNguoiDung(tk,images, pictureBox_Image_02.Image,1);
            hxtthand.ShowDialog();
        }
        private void pictureBox_Image_03_Click(object sender, EventArgs e)
        {
            form_XemThongTinHinhAnhNguoiDung hxtthand = new form_XemThongTinHinhAnhNguoiDung(tk, images, pictureBox_Image_03.Image,2);
            hxtthand.ShowDialog();
        }
        private void pictureBox_Image_04_Click(object sender, EventArgs e)
        {
            form_XemThongTinHinhAnhNguoiDung hxtthand = new form_XemThongTinHinhAnhNguoiDung(tk, images, pictureBox_Image_04.Image,3);
            hxtthand.ShowDialog();
        }
        private void pictureBox_Image_05_Click(object sender, EventArgs e)
        {
            form_XemThongTinHinhAnhNguoiDung hxtthand = new form_XemThongTinHinhAnhNguoiDung(tk,images, images[4],4);
            hxtthand.ShowDialog();
        }
        public void label_SoAnh_MouseClick(object sender, EventArgs e)
        {
            form_XemThongTinHinhAnhNguoiDung hxtthand = new form_XemThongTinHinhAnhNguoiDung(tk, images, images[4], 4);
            hxtthand.ShowDialog();
        }
        private void button_Gmail_Click(object sender, EventArgs e)
        {
            form_SoanTinNhan f = new form_SoanTinNhan(row.Cells[0].Value.ToString(), 0, tk);
            f.Owner = this;
            f.ShowDialog();
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
                Change_Position_EN();
                check_ngonngu = true;
            }
            else
            {
                Change_Language_VI();
                Change_Position_VI();
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
            button_Facebook.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            button_Twitter.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            button_Instagram.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            button_Tiktok.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            button_Gmail.BackColor = CaiDatDAO.Instance.color_BG_White_01;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon_Black;

            //Button
            button_Facebook.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Twitter.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Instagram.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Tiktok.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Gmail.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
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
            label_Title.Text = "Xem thông tin";

            label_TenNguoiDung.Text = "Tên người dùng";
            label_BietDanh.Text = "(Biệt danh)";
            label_TieuSu.Text = "Tiểu sử";
            label_TaiKhoan.Text = "Tài khoản:";
            label_MatKhau.Text = "Mật khẩu:";
            label_GioiTinh.Text = "Giới tính:";
            label_NgaySinh.Text = "Ngày sinh:";
            label_QueQuan.Text = "Quê quán:";
            label_NoiOHienTai.Text = "Nơi ở hiện tại:";
            label_DiaDiemHenHo.Text = "Địa điểm hẹn hò:";
            label_NgheNghiep.Text = "Nghề nghiệp:";
            label_SoDienThoai.Text = "Số điện thoại:";
            label_ChieuCao.Text = "Chiều cao:";
            label_CanNang.Text = "Cân nặng:";
            label_Vong1.Text = "Vòng 1:";
            label_Vong2.Text = "Vòng 2:";
            label_Vong3.Text = "Vòng 3:";
            label_CungHoangDao.Text = "Cung hoàng đạo:";
            label_SoThich.Text = "Sở thích:";
            label_NgayThamGia.Text = "Ngày tham gia:";
            label_SoNguoiTheoDoi.Text = "Số người theo dõi";
            label_SoLanDuocThue.Text = "Số lần được thuê";
            label_TyLeHoanThanh.Text = "Tỷ lệ hoàn thành";
            label_SoDu.Text = "Số dư";

        }
        public void Change_Language_EN()
        {
            //Label
            label_Title.Text = "Watch information";

            label_TenNguoiDung.Text = "Full name";
            label_BietDanh.Text = "(Nickname)";
            label_TieuSu.Text = "Biography";
            label_TaiKhoan.Text = "Username:";
            label_MatKhau.Text = "Password:";
            label_GioiTinh.Text = "Sex:";
            label_NgaySinh.Text = "Date of birth:";
            label_QueQuan.Text = "Place of origin:";
            label_NoiOHienTai.Text = "Place of residence:";
            label_DiaDiemHenHo.Text = "Dating places:";
            label_NgheNghiep.Text = "Career:";
            label_SoDienThoai.Text = "Phone number:";
            label_ChieuCao.Text = "Height:";
            label_CanNang.Text = "Weight:";
            label_Vong1.Text = "Bust:";
            label_Vong2.Text = "Waist:";
            label_Vong3.Text = "Hip:";
            label_CungHoangDao.Text = "Zodiac:";
            label_SoThich.Text = "Hobbies:";
            label_NgayThamGia.Text = "Date joined:";
            label_SoNguoiTheoDoi.Text = "Followers";
            label_SoLanDuocThue.Text = "Hired times";
            label_TyLeHoanThanh.Text = "Percentage of completion";
            label_SoDu.Text = "Balance";
        }
        public void Change_Position_VI()
        {
            //Text
            label_TaiKhoan.Size = new Size(80, 19);
            label_TaiKhoan.Location = new Point(283, 230);

            label_MatKhau.Size = new Size(80, 19);
            label_MatKhau.Location = new Point(283, 260);

            label_GioiTinh.Size = new Size(75, 19);
            label_GioiTinh.Location = new Point(283, 290);

            label_NgaySinh.Size = new Size(80, 19);
            label_NgaySinh.Location = new Point(283, 320);

            label_QueQuan.Size = new Size(80, 19);
            label_QueQuan.Location = new Point(283, 350);

            label_NoiOHienTai.Size = new Size(110, 19);
            label_NoiOHienTai.Location = new Point(283, 380);

            label_DiaDiemHenHo.Size = new Size(125, 19);
            label_DiaDiemHenHo.Location = new Point(283, 410);

            label_NgheNghiep.Size = new Size(105, 19);
            label_NgheNghiep.Location = new Point(283, 440);

            label_SoDienThoai.Size = new Size(105, 19);
            label_SoDienThoai.Location = new Point(283, 470);

            label_ChieuCao.Size = new Size(85, 19);
            label_ChieuCao.Location = new Point(585, 230);

            label_CanNang.Size = new Size(80, 19);
            label_CanNang.Location = new Point(585, 260);

            label_Vong1.Size = new Size(60, 19);
            label_Vong1.Location = new Point(585, 290);

            label_Vong2.Size = new Size(60, 19);
            label_Vong2.Location = new Point(585, 320);

            label_Vong3.Size = new Size(60, 19);
            label_Vong3.Location = new Point(585, 350);

            label_CungHoangDao.Size = new Size(130, 19);
            label_CungHoangDao.Location = new Point(585, 380);

            label_SoThich.Size = new Size(70, 19);
            label_SoThich.Location = new Point(585, 410);

            label_NgayThamGia.Size = new Size(110, 19);
            label_NgayThamGia.Location = new Point(585, 440);

            //Value

            label_Value_TaiKhoan.Size = new Size(218, 19);
            label_Value_TaiKhoan.Location = new Point(361, 230);

            label_Value_MatKhau.Size = new Size(222, 19);
            label_Value_MatKhau.Location = new Point(357, 260);

            label_Value_GioiTinh.Size = new Size(226, 19);
            label_Value_GioiTinh.Location = new Point(353, 290);

            label_Value_NgaySinh.Size = new Size(219, 19);
            label_Value_NgaySinh.Location = new Point(360, 320);

            label_Value_QueQuan.Size = new Size(219, 19);
            label_Value_QueQuan.Location = new Point(360, 350);

            label_Value_NoiOHienTai.Size = new Size(193, 19);
            label_Value_NoiOHienTai.Location = new Point(386, 380);

            label_Value_DiaDiemHenHo.Size = new Size(173, 19);
            label_Value_DiaDiemHenHo.Location = new Point(406, 410);

            label_Value_NgheNghiep.Size = new Size(196, 19);
            label_Value_NgheNghiep.Location = new Point(383, 440);

            label_Value_SoDienThoai.Size = new Size(194, 19);
            label_Value_SoDienThoai.Location = new Point(385, 470);

            label_Value_ChieuCao.Size = new Size(203, 19);
            label_Value_ChieuCao.Location = new Point(665, 230);

            label_Value_CanNang.Size = new Size(208, 19);
            label_Value_CanNang.Location = new Point(660, 260);

            label_Value_Vong1.Size = new Size(225, 19);
            label_Value_Vong1.Location = new Point(643, 290);

            label_Value_Vong2.Size = new Size(225, 19);
            label_Value_Vong2.Location = new Point(643, 320);

            label_Value_Vong3.Size = new Size(225, 19);
            label_Value_Vong3.Location = new Point(643, 350);

            label_Value_CungHoangDao.Size = new Size(158, 19);
            label_Value_CungHoangDao.Location = new Point(710, 380);

            label_Value_SoThich.Size = new Size(215, 19);
            label_Value_SoThich.Location = new Point(651, 410);

            label_Value_NgayThamGia.Size = new Size(176, 19);
            label_Value_NgayThamGia.Location = new Point(692, 440);

        }

        public void Change_Position_EN()
        {
            //Text
            label_TaiKhoan.Size = new Size(85, 19);
            label_TaiKhoan.Location = new Point(283, 230);

            label_MatKhau.Size = new Size(80, 19);
            label_MatKhau.Location = new Point(283, 260);

            label_GioiTinh.Size = new Size(40, 19);
            label_GioiTinh.Location = new Point(283, 290);

            label_NgaySinh.Size = new Size(100, 19);
            label_NgaySinh.Location = new Point(283, 320);

            label_QueQuan.Size = new Size(115, 19);
            label_QueQuan.Location = new Point(283, 350);

            label_NoiOHienTai.Size = new Size(145, 19);
            label_NoiOHienTai.Location = new Point(283, 380);

            label_DiaDiemHenHo.Size = new Size(110, 19);
            label_DiaDiemHenHo.Location = new Point(283, 410);

            label_NgheNghiep.Size = new Size(60, 19);
            label_NgheNghiep.Location = new Point(283, 440);

            label_SoDienThoai.Size = new Size(115, 19);
            label_SoDienThoai.Location = new Point(283, 470);

            label_ChieuCao.Size = new Size(60, 19);
            label_ChieuCao.Location = new Point(585, 230);

            label_CanNang.Size = new Size(80, 19);
            label_CanNang.Location = new Point(585, 260);

            label_Vong1.Size = new Size(45, 19);
            label_Vong1.Location = new Point(585, 290);

            label_Vong2.Size = new Size(50, 19);
            label_Vong2.Location = new Point(585, 320);

            label_Vong3.Size = new Size(35, 19);
            label_Vong3.Location = new Point(585, 350);

            label_CungHoangDao.Size = new Size(60, 19);
            label_CungHoangDao.Location = new Point(585, 380);

            label_SoThich.Size = new Size(70, 19);
            label_SoThich.Location = new Point(585, 410);

            label_NgayThamGia.Size = new Size(95, 19);
            label_NgayThamGia.Location = new Point(585, 440);

            //Value

            label_Value_TaiKhoan.Size = new Size(215, 19);
            label_Value_TaiKhoan.Location = new Point(363, 230);

            label_Value_MatKhau.Size = new Size(220, 19);
            label_Value_MatKhau.Location = new Point(358, 260);

            label_Value_GioiTinh.Size = new Size(263, 19);
            label_Value_GioiTinh.Location = new Point(316, 290);

            label_Value_NgaySinh.Size = new Size(200, 19);
            label_Value_NgaySinh.Location = new Point(378, 320);

            label_Value_QueQuan.Size = new Size(187, 19);
            label_Value_QueQuan.Location = new Point(391, 350);

            label_Value_NoiOHienTai.Size = new Size(158, 19);
            label_Value_NoiOHienTai.Location = new Point(421, 380);

            label_Value_DiaDiemHenHo.Size = new Size(194, 19);
            label_Value_DiaDiemHenHo.Location = new Point(385, 410);

            label_Value_NgheNghiep.Size = new Size(240, 19);
            label_Value_NgheNghiep.Location = new Point(339, 440);

            label_Value_SoDienThoai.Size = new Size(185, 19);
            label_Value_SoDienThoai.Location = new Point(394, 470);

            label_Value_ChieuCao.Size = new Size(229, 19);
            label_Value_ChieuCao.Location = new Point(639, 230);

            label_Value_CanNang.Size = new Size(226, 19);
            label_Value_CanNang.Location = new Point(642, 260);

            label_Value_Vong1.Size = new Size(243, 19);
            label_Value_Vong1.Location = new Point(625, 290);

            label_Value_Vong2.Size = new Size(238, 19);
            label_Value_Vong2.Location = new Point(630, 320);

            label_Value_Vong3.Size = new Size(252, 19);
            label_Value_Vong3.Location = new Point(616, 350);

            label_Value_CungHoangDao.Size = new Size(227, 19);
            label_Value_CungHoangDao.Location = new Point(641, 380);

            label_Value_SoThich.Size = new Size(217, 19);
            label_Value_SoThich.Location = new Point(651, 410);

            label_Value_NgayThamGia.Size = new Size(196, 19);
            label_Value_NgayThamGia.Location = new Point(672, 440);
        }
        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            button_Facebook.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Facebook.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_Instagram.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Instagram.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_Twitter.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Twitter.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_Tiktok.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Tiktok.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_Gmail.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Gmail.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            pictureBox_Idol.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Lock.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            label_ThoiGianKhoaConLai.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            label_BietDanh.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            label_TenNguoiDung.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            pictureBox_AnhDaiDien.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_AnhDaiDien.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }

}
