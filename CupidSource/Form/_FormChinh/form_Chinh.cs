using Cupid.DAO;
using Cupid.DTO;
using Cupid.Toolbox_Custom;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace Cupid
{
    public partial class form_Chinh : Form
    {
        private IconButton currentBtn;
        public Panel leftBorderBtn;
        private Form currentChildForm;
        private int counter = 0, counter1 = 0, counter2 = 0, counter3 = 0, counter4 = 0;
        public static Random random = new Random();
        public int num = random.Next(1, 4);
        public static Random hellord = new Random();
        public int numhello = hellord.Next(1, 5);
        string Name = null;
        public bool DonMoi = false;
        public bool ThuMoi = false;
        public bool BaoMoi = false;
        string tk;
        bool check_giaodien, check_ngonngu;
        public bool check_TabMenu;
        public event PropertyChangedEventHandler PropertyChanged;
        private clsNotification notification;
        public int colorApp;
        public form_Chinh(string Name, string tk)
        {
            InitializeComponent();
            //Form
            leftBorderBtn = new Panel();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            textbox_GhiChu.Padding = new Padding(0, 0, 0, 0);
            Time();
            Time4();
            Time1();
            Time2();
            Time3();
            this.Name = Name;
            this.tk = tk;
            //string command = "select [MA_THU],[TK_NHAN],[NOI_DUNG],[NGAY_GUI] from [dbo].[HOP_THU]";
            //notification = new clsNotification(setData, command);
            //// Start listening notification
            //notification.loadData();
            colorApp = KiemTraColorApp(tk);
            ChangeColorApp();
            UpdateColorApp();
            Update_TabMenu();
            Update_GiaoDien_NgonNgu();
        }

        private void setData()
        {
            if (true)
            {

            }
            ThongBao(3, 194);
        }

        private void On_Quit()
        {
            //notification.Dispose();
        }
        private void form_Chinh_Load(object sender, EventArgs e)
        {
            DataTable dt = NguoiDungDAO.Instance.getNote(tk);
            textbox_GhiChu.Texts = dt.Rows[0][0].ToString();
        }
        private void Time()
        {
            timer.Interval = 1;
            timer.Start();
        }
        private void Time1()
        {
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void Time2()
        {
            timer2.Interval = 1000;
            timer2.Start();
        }
        private void Time3()
        {
            timer3.Interval = 1000;
            timer3.Start();
        }
        private void Time4()
        {
            timer4.Interval = 1000;
            timer4.Start();
        }
        public void ThongBao(int x, int y)
        {
            PictureBox_Custom pc = new PictureBox_Custom();

            panel_Menu.Controls.Add((Control)pc);
            ((PictureBox_Custom)pc).Size = new Size(20, 20);
            ((PictureBox_Custom)pc).BackColor = CaiDatDAO.Instance.color_Text_Red;
            ((PictureBox_Custom)pc).BorderSize = 0;
            ((PictureBox_Custom)pc).BorderColor = Color.Transparent;
            ((PictureBox_Custom)pc).BorderColor2 = Color.Transparent;
            ((PictureBox_Custom)pc).Location = new Point(x, y);
            ((PictureBox_Custom)pc).BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            ((PictureBox_Custom)pc).BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            ((PictureBox_Custom)pc).BringToFront();
        }
        private void PrintDayTime()
        {
            string weekdays = "";
            string months = "";
            string days = "";
            if (!check_ngonngu)
            {
                if (DateTime.Now.ToString("dddd") == "Monday")
                {
                    weekdays = "Thứ hai";
                }
                else if (DateTime.Now.ToString("dddd") == "Tuesday")
                {
                    weekdays = "Thứ ba";
                }
                else if (DateTime.Now.ToString("dddd") == "Wednesday")
                {
                    weekdays = "Thứ tư";
                }
                else if (DateTime.Now.ToString("dddd") == "Thursday")
                {
                    weekdays = "Thứ năm";
                }
                else if (DateTime.Now.ToString("dddd") == "Friday")
                {
                    weekdays = "Thứ sáu";
                }
                else if (DateTime.Now.ToString("dddd") == "Saturday")
                {
                    weekdays = "Thứ bảy";
                }
                else
                {
                    weekdays = "Chủ nhật";
                }
                label_ThoiGian.Text = DateTime.Now.ToString("HH:mm:ss");
                label_NgayThangNam.Text = weekdays + ", ngày " + DateTime.Now.ToString("dd") + " tháng " + DateTime.Now.ToString("MM") + " năm " + DateTime.Now.ToString("yyyy");
            }
            else
            {
                //weeks
                if (DateTime.Now.ToString("dddd") == "Monday")
                {
                    weekdays = "Monday";
                }
                else if (DateTime.Now.ToString("dddd") == "Tuesday")
                {
                    weekdays = "Tuesday";
                }
                else if (DateTime.Now.ToString("dddd") == "Wednesday")
                {
                    weekdays = "Wednesday";
                }
                else if (DateTime.Now.ToString("dddd") == "Thursday")
                {
                    weekdays = "Thursday";
                }
                else if (DateTime.Now.ToString("dddd") == "Friday")
                {
                    weekdays = "Friday";
                }
                else if (DateTime.Now.ToString("dddd") == "Saturday")
                {
                    weekdays = "Saturday";
                }
                else
                {
                    weekdays = "Sunday";
                }
                // days
                if (DateTime.Now.ToString("dd") == "01" || DateTime.Now.ToString("dd") == "31")
                {
                    days = "st";
                }
                else if (DateTime.Now.ToString("dd") == "02")
                {
                    days = "nd";
                }
                else if (DateTime.Now.ToString("dd") == "03")
                {
                    days = "rd";
                }
                else
                {
                    days = "th";
                }
                // month
                if (DateTime.Now.ToString("MM") == "01")
                {
                    months = "January";
                }
                else if (DateTime.Now.ToString("MM") == "02")
                {
                    months = "February";
                }
                else if (DateTime.Now.ToString("MM") == "03")
                {
                    months = "March";
                }
                else if (DateTime.Now.ToString("MM") == "04")
                {
                    months = "April";
                }
                else if (DateTime.Now.ToString("MM") == "05")
                {
                    months = "May";
                }
                else if (DateTime.Now.ToString("MM") == "06")
                {
                    months = "June";
                }
                else if (DateTime.Now.ToString("MM") == "07")
                {
                    months = "July";
                }
                else if (DateTime.Now.ToString("MM") == "08")
                {
                    months = "August";
                }
                else if (DateTime.Now.ToString("MM") == "09")
                {
                    months = "September";
                }
                else if (DateTime.Now.ToString("MM") == "10")
                {
                    months = "October";
                }
                else if (DateTime.Now.ToString("MM") == "11")
                {
                    months = "November";
                }
                else
                {
                    months = "December";
                }
                label_ThoiGian.Text = DateTime.Now.ToString("HH:mm:ss");
                label_NgayThangNam.Text = weekdays + ", " + months + ", " + DateTime.Now.ToString("dd") + days + ", " + DateTime.Now.ToString("yyyy");
            }
        }
        private void Hello()
        {
            if (!check_ngonngu)
            {
                if (Convert.ToInt32(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt32(DateTime.Now.ToString("HH")) < 11)
                {

                    if (numhello == 1)
                    {
                        label_XinChao.Text = "Chào buổi sáng! " + Name;
                    }
                    else if (numhello == 2)
                    {
                        label_XinChao.Text = "Buổi sáng vui vẻ! " + Name;
                    }
                    else if (numhello == 3)
                    {
                        label_XinChao.Text = "Ngày mới tốt lành! " + Name;
                    }
                    else
                    {
                        label_XinChao.Text = "Nhớ ăn sáng nhé! " + Name;
                    }
                }
                else if (Convert.ToInt32(DateTime.Now.ToString("HH")) >= 11 && Convert.ToInt32(DateTime.Now.ToString("HH")) < 14)
                {
                    if (numhello == 1)
                    {
                        label_XinChao.Text = "Chào buổi trưa! " + Name;
                    }
                    else if (numhello == 2)
                    {
                        label_XinChao.Text = "Buổi trưa vui vẻ! " + Name;
                    }
                    else if (numhello == 3)
                    {
                        label_XinChao.Text = "Đừng quên ăn trưa nhé!! " + Name;
                    }
                    else
                    {
                        label_XinChao.Text = "Hãy tìm người yêu nhé! " + Name;
                    }
                }
                else if (Convert.ToInt32(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt32(DateTime.Now.ToString("HH")) < 18)
                {
                    if (numhello == 1)
                    {
                        label_XinChao.Text = "Chào buổi chiều! " + Name;
                    }
                    else if (numhello == 2)
                    {
                        label_XinChao.Text = "Buổi chiều vui vẻ! " + Name;
                    }
                    else if (numhello == 3)
                    {
                        label_XinChao.Text = "Làm tốt công việc nhé! " + Name;
                    }
                    else
                    {
                        label_XinChao.Text = "Nhớ uống nước thường xuyên nhé! " + Name;
                    }
                }
                else if (Convert.ToInt32(DateTime.Now.ToString("HH")) >= 18 && Convert.ToInt32(DateTime.Now.ToString("HH")) < 22)
                {
                    if (numhello == 1)
                    {
                        label_XinChao.Text = "Chào buổi tối! " + Name;
                    }
                    else if (numhello == 2)
                    {
                        label_XinChao.Text = "Buổi tối vui vẻ! " + Name;
                    }
                    else if (numhello == 3)
                    {
                        label_XinChao.Text = "Đừng quên ăn tối nhé! " + Name;
                    }
                    else
                    {
                        label_XinChao.Text = "Hãy làm việc thật tốt nhé! " + Name;
                    }
                }
                else
                {
                    if (numhello == 1)
                    {
                        label_XinChao.Text = "Nhớ giữ gìn sức khỏe! " + Name;
                    }
                    else if (numhello == 2)
                    {
                        label_XinChao.Text = "Đêm nay vui vẻ nhé! " + Name;
                    }
                    else if (numhello == 3)
                    {
                        label_XinChao.Text = "Làm tốt công việc nhé! " + Name;
                    }
                    else
                    {
                        label_XinChao.Text = "Nhớ ngủ đủ giấc nhé! " + Name;
                    }
                }
            }
            else
            {
                if (Convert.ToInt32(DateTime.Now.ToString("HH")) >= 6 && Convert.ToInt32(DateTime.Now.ToString("HH")) < 11)
                {

                    if (numhello == 1)
                    {
                        label_XinChao.Text = "Good morning! " + Name;
                    }
                    else if (numhello == 2)
                    {
                        label_XinChao.Text = "Have a good day! " + Name;
                    }
                    else if (numhello == 3)
                    {
                        label_XinChao.Text = "Glad to see you! " + Name;
                    }
                    else
                    {
                        label_XinChao.Text = "Remember to have breakfast! " + Name;
                    }
                }
                else if (Convert.ToInt32(DateTime.Now.ToString("HH")) >= 11 && Convert.ToInt32(DateTime.Now.ToString("HH")) < 14)
                {
                    if (numhello == 1)
                    {
                        label_XinChao.Text = "Good afternoon! " + Name;
                    }
                    else if (numhello == 2)
                    {
                        label_XinChao.Text = "Have a good afternoon! " + Name;
                    }
                    else if (numhello == 3)
                    {
                        label_XinChao.Text = "Don't forget your lunch! " + Name;
                    }
                    else
                    {
                        label_XinChao.Text = "Let's find your love! " + Name;
                    }
                }
                else if (Convert.ToInt32(DateTime.Now.ToString("HH")) >= 14 && Convert.ToInt32(DateTime.Now.ToString("HH")) < 18)
                {
                    if (numhello == 1)
                    {
                        label_XinChao.Text = "Good afternoon! " + Name;
                    }
                    else if (numhello == 2)
                    {
                        label_XinChao.Text = "Have a good afternoon! " + Name;
                    }
                    else if (numhello == 3)
                    {
                        label_XinChao.Text = "Let's get down to bussiness! " + Name;
                    }
                    else
                    {
                        label_XinChao.Text = "Remember to drink more water during the day " + Name;
                    }
                }
                else if (Convert.ToInt32(DateTime.Now.ToString("HH")) >= 18 && Convert.ToInt32(DateTime.Now.ToString("HH")) < 22)
                {
                    if (numhello == 1)
                    {
                        label_XinChao.Text = "Good evening! " + Name;
                    }
                    else if (numhello == 2)
                    {
                        label_XinChao.Text = "Have a good evening! " + Name;
                    }
                    else if (numhello == 3)
                    {
                        label_XinChao.Text = "Don't forget your dinner! " + Name;
                    }
                    else
                    {
                        label_XinChao.Text = "Keep up the good work! " + Name;
                    }
                }
                else
                {
                    if (numhello == 1)
                    {
                        label_XinChao.Text = "Alright now, take it easy! " + Name;
                    }
                    else if (numhello == 2)
                    {
                        label_XinChao.Text = "Have fun tonight! " + Name;
                    }
                    else if (numhello == 3)
                    {
                        label_XinChao.Text = "You were awesome today! " + Name;
                    }
                    else
                    {
                        label_XinChao.Text = "Stay healthy, and remember, sleep well! " + Name;
                    }
                }
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter <= 0)
            {
                PrintDayTime();
                Hello();
                counter = 1;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1--;
            if (counter1 <= 0)
            {
                LoadThongBao();
                counter1 = 1;
            }
            if (ThuMoi == false)
            {
                HuyThongBao(16, 194);
                timer3.Start();
            }


            if (DonMoi == false)
            {
                HuyThongBao(16, 244);
                timer2.Start();
            }

            if (BaoMoi == false)
            {
                HuyThongBao(16, 294);
                timer4.Start();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            counter2--;
            if (counter2 <= 0)
            {
                LoadThongBao();
                counter2 = 1;
            }
            if (DonMoi == false)
            {
                HuyThongBao(16, 244);
            }
            else
            {
                if (currentBtn == button_DonDangKyIdol)
                {
                    ThongBao(16, 244);
                }
                else
                {
                    ThongBao(3, 244);
                }
                timer2.Stop();
            }

        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            counter4--;
            if (counter4 <= 0)
            {
                LoadThongBao2();
            }
            if (BaoMoi == false)
            {
                HuyThongBao(16, 294);
            }
            else
            {
                if (currentBtn == button_BaoCao)
                {
                    ThongBao(16, 294);
                }
                else
                {
                    ThongBao(3, 294);
                }
                timer4.Stop();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            counter3--;
            if (counter3 <= 0)
            {
                LoadThongBao1();
            }
            if (ThuMoi == false)
            {
                HuyThongBao(16, 194);
            }
            else
            {
                if (currentBtn == button_HopThu)
                {
                    ThongBao(16, 194);
                }
                else
                {
                    ThongBao(3, 194);
                }
                timer3.Stop();
            }
        }
        public void LoadThongBao()
        {
            DonMoi = DonDangKyIdolDAO.Instance.getSoDon();

        }
        public void LoadThongBao1()
        {

            ThuMoi = HopThuDAO.Instance.getSoThu(tk, 0);

        }
        public void LoadThongBao2()
        {

            BaoMoi = BaoCaoDAO.Instance.getSoDon();
        }
        private void HuyThongBao(int v1, int v2)
        {
            foreach (Control pc in panel_Menu.Controls)
            {
                if (pc is PictureBox_Custom)
                {
                    if (pc.Location == new Point(v1, v2))
                    {
                        panel_Menu.Controls.Remove((Control)pc);
                    }
                }

            }
        }
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
                if (!check_TabMenu)
                {
                    currentBtn.Padding = new Padding(15, 0, 0, 0);
                    //Left border button

                    leftBorderBtn.Size = new Size(7, currentBtn.Height);
                    //Current Child Form Icon
                    pictureBox_Select.IconChar = currentBtn.IconChar;
                    pictureBox_Select.IconFont = IconFont.Solid;
                }
                else
                {
                    currentBtn.Padding = new Padding(0, 0, 0, 0);
                    //Current Child Form Icon
                    leftBorderBtn.Size = new Size(5, currentBtn.Height);
                    pictureBox_Select.IconChar = currentBtn.IconChar;
                    pictureBox_Select.IconFont = IconFont.Solid;
                }
                panel_Menu.Controls.Add(leftBorderBtn);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.Padding = new Padding(0, 0, 0, 0);
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.Owner = this;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(childForm);
            panel_Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label_Select.Text = currentBtn.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            pictureBox_Select.IconChar = IconChar.Home;
            pictureBox_Select.IconColor = Color.White;
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

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Color_White()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            panel_Main.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            //Form Chính
            button_ThongTin.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_KhuyenMai.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_BangXepHang.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_HopThu.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_DonDangKyIdol.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_BaoCao.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_ThongKe.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_LichSuHoatDong.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_LichSuGiaoDich.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_CaiDat.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_DangXuat.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            button_ThongTin.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_KhuyenMai.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_BangXepHang.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_HopThu.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_DonDangKyIdol.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_BaoCao.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_ThongKe.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_LichSuHoatDong.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_LichSuGiaoDich.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_CaiDat.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_DangXuat.IconColor = CaiDatDAO.Instance.color_Text_Black_01;

            label_Select.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            pictureBox_Select.IconColor = CaiDatDAO.Instance.color_Text_Black_01;

            button_Close.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Maximize.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Minimize.IconColor = CaiDatDAO.Instance.color_Text_Black_01;

            leftBorderBtn.BackColor = CaiDatDAO.Instance.color_BG_White_01;

            button_Facebook.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            button_Youtube.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            button_Twitter.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            button_Instagram.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            button_Tiktok.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            button_Gmail.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            button_Website.BackColor = CaiDatDAO.Instance.color_BG_White_01;

            label_ThoiGian.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            label_NgayThangNam.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

            label_GhiChu.BackColor = CaiDatDAO.Instance.color_BG_White_01;
            textbox_GhiChu.BackColor = CaiDatDAO.Instance.color_BG_White_01;

            if (check_TabMenu)
            {
                pictureBox_Logo.Image = Cupid.Properties.Resources.Icon;
            }
            else
            {
                pictureBox_Logo.Image = Cupid.Properties.Resources.Logo;
            }

            pictureBox_TabMenu.IconColor = CaiDatDAO.Instance.color_Text_Black_01;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            panel_Main.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            //Form chính
            button_ThongTin.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_KhuyenMai.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_BangXepHang.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_HopThu.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_DonDangKyIdol.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_BaoCao.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_ThongKe.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_LichSuHoatDong.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_LichSuGiaoDich.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_CaiDat.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_DangXuat.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            button_ThongTin.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_KhuyenMai.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_BangXepHang.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_HopThu.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_DonDangKyIdol.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_BaoCao.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_ThongKe.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_LichSuHoatDong.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_LichSuGiaoDich.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_CaiDat.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_DangXuat.IconColor = CaiDatDAO.Instance.color_Text_White_01;

            label_Select.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            pictureBox_Select.IconColor = CaiDatDAO.Instance.color_Text_White_01;

            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Maximize.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Minimize.IconColor = CaiDatDAO.Instance.color_Text_White_01;

            leftBorderBtn.BackColor = CaiDatDAO.Instance.color_BG_Black_01;

            button_Facebook.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Youtube.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Twitter.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Instagram.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Tiktok.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Gmail.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Website.BackColor = CaiDatDAO.Instance.color_BG_Black_01;

            label_ThoiGian.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            label_NgayThangNam.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

            label_GhiChu.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            textbox_GhiChu.BackColor = CaiDatDAO.Instance.color_BG_Black_01;

            if (check_TabMenu)
            {
                pictureBox_Logo.Image = Cupid.Properties.Resources.Icon_Black;
            }
            else
            {
                pictureBox_Logo.Image = Cupid.Properties.Resources.Logo_Black;
            }
            pictureBox_TabMenu.IconColor = CaiDatDAO.Instance.color_Text_White_01;
        }
        public bool KiemTraNgonNgu(string userName)
        {
            string query = "SELECT * FROM dbo.CAI_DAT WHERE TAI_KHOAN = N'" + userName + "' AND NGON_NGU = 1";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Language_VI()
        {
            //Form Chính
            button_ThongTin.Text = "Thông tin";
            button_KhuyenMai.Text = "Khuyến mãi";
            button_BangXepHang.Text = "Bảng xếp hạng";
            button_HopThu.Text = "Hộp thư";
            button_DonDangKyIdol.Text = "Đơn đăng ký Idol";
            button_BaoCao.Text = "Báo cáo";
            button_ThongKe.Text = "Thống kê";
            button_LichSuHoatDong.Text = "Lịch sử hoạt động";
            button_LichSuGiaoDich.Text = "Lịch sử giao dịch";
            button_CaiDat.Text = "Cài đặt";
            button_DangXuat.Text = "Đăng xuất";

            label_GhiChu.Text = "Ghi chú:";

            label_Select.Text = "Trang chủ";
        }
        public void Change_Language_EN()
        {
            //Form Chính
            button_ThongTin.Text = "Information";
            button_KhuyenMai.Text = "Promotion";
            button_BangXepHang.Text = "Leaderboard";
            button_HopThu.Text = "Mailbox";
            button_DonDangKyIdol.Text = "Idol registration";
            button_BaoCao.Text = "Report";
            button_ThongKe.Text = "Statistical";
            button_LichSuHoatDong.Text = "Operation history";
            button_LichSuGiaoDich.Text = "Transaction history";
            button_CaiDat.Text = "Settings";
            button_DangXuat.Text = "Log Out";

            label_GhiChu.Text = "Notes:";

            label_Select.Text = "Home";
        }
        private void pictureBox_TabMenu_Click(object sender, EventArgs e)
        {
            TabMenu();
        }
        private void pictureBox_TabMenu_DoubleClick(object sender, EventArgs e)
        {
            TabMenu();
        }
        public void TabMenu()
        {
            check_TabMenu = !check_TabMenu;
            if (!check_TabMenu)
            {
                panel_Menu.Size = new Size(200, 673);

                pictureBox_Logo.Size = new Size(170, 90);
                pictureBox_Logo.Location = new Point(15, 3);


                pictureBox_TabMenu.IconChar = IconChar.ChevronCircleLeft;
                if (currentBtn != null)
                {
                    currentBtn.Padding = new Padding(15, 0, 0, 0);
                    leftBorderBtn.Size = new Size(7, currentBtn.Height);
                }
                CaiDatDAO.Instance.CapNhatTabMenu(tk, 1);
            }
            else
            {
                panel_Menu.Size = new Size(47, 673);

                pictureBox_Logo.Size = new Size(42, 90);
                pictureBox_Logo.Location = new Point(3, 3);

                pictureBox_TabMenu.IconChar = IconChar.ChevronCircleRight;

                if (currentBtn != null)
                {
                    currentBtn.Padding = new Padding(0, 0, 0, 0);
                    leftBorderBtn.Size = new Size(5, currentBtn.Height);
                }
                CaiDatDAO.Instance.CapNhatTabMenu(tk, 0);
            }
            Update_GiaoDien_NgonNgu();
        }
        public bool KiemTraTabMenu(string userName)
        {
            string query = "SELECT * FROM dbo.CAI_DAT WHERE TAI_KHOAN = N'" + userName + "' AND MENU_TAB = 1";

            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Update_TabMenu()
        {
            if (KiemTraTabMenu(tk))
            {
                check_TabMenu = false;
                panel_Menu.Size = new Size(200, 673);

                pictureBox_Logo.Size = new Size(170, 90);
                pictureBox_Logo.Location = new Point(15, 3);
            }
            else
            {
                check_TabMenu = true;
                panel_Menu.Size = new Size(47, 673);

                pictureBox_Logo.Size = new Size(42, 90);
                pictureBox_Logo.Location = new Point(3, 3);

                pictureBox_TabMenu.IconChar = IconChar.ChevronCircleRight;
            }
        }
        public int KiemTraColorApp(string userName)
        {
            string query = "SELECT COLOR_APP FROM dbo.CAI_DAT WHERE TAI_KHOAN = N'" + userName + "'";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
        public void ChangeColorApp()
        {
            if (colorApp == 0)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Blue_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Blue_02;
            }
            else if (colorApp == 1)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Red_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Red_02;
            }
            if (colorApp == 2)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Green_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Green_02;
            }
            if (colorApp == 3)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Orange_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Orange_02;
            }
            if (colorApp == 4)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Yellow_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Yellow_02;
            }
            if (colorApp == 5)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_BlueDark_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_BlueDark_02;
            }
            if (colorApp == 6)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Violet_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Violet_02;
            }
            if (colorApp == 7)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Pink_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Pink_02;
            }
            if (colorApp == 8)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Brown_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Brown_02;
            }
            if (colorApp == 9)
            {
                CaiDatDAO.Instance.color_BG_ColorApp_01 = CaiDatDAO.Instance.color_BG_Grey_01;
                CaiDatDAO.Instance.color_BG_ColorApp_02 = CaiDatDAO.Instance.color_BG_Grey_02;
            }
        }
        public void UpdateColorApp()
        {
            panel_Title.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Maximize.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Minimize.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            panel_Menu.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_ThongTin.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_KhuyenMai.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_BangXepHang.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_HopThu.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_DonDangKyIdol.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_BaoCao.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_ThongKe.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_LichSuHoatDong.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_LichSuGiaoDich.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_CaiDat.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_DangXuat.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            label_XinChao.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Time.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            label_ThoiGian.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            label_NgayThangNam.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_Facebook.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Youtube.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Twitter.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Instagram.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Tiktok.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Gmail.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Website.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            button_Facebook.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Youtube.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Twitter.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Instagram.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Tiktok.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Gmail.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            button_Website.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            label_GhiChu.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_GhiChu.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            textbox_GhiChu.PlaceholderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
        public void ThongBao()
        {
            if (ThuMoi == true)
            {
                HuyThongBao(3, 194);
                HuyThongBao(16, 194);
                if (currentBtn == button_HopThu)
                {
                    ThongBao(16, 194);

                }
                else
                {
                    ThongBao(3, 194);
                }
            }
            else
            {
                HuyThongBao(16, 194);
            }

            if (DonMoi == true)
            {
                HuyThongBao(3, 244);
                HuyThongBao(16, 244);
                if (currentBtn == button_DonDangKyIdol)
                {
                    ThongBao(16, 244);

                }
                else
                {
                    ThongBao(3, 244);
                }
            }
            else
            {
                HuyThongBao(16, 244);
            }
            if (BaoMoi == true)
            {
                HuyThongBao(3, 294);
                HuyThongBao(16, 294);
                if (currentBtn == button_BaoCao)
                {
                    ThongBao(16, 294);

                }
                else
                {
                    ThongBao(3, 294);
                }
            }
            else
            {
                HuyThongBao(16, 294);
            }

        }
        private void pictureBox_Logo_Click(object sender, EventArgs e)
        {
            if (DonMoi == true)
            {
                HuyThongBao(16, 244);
                ThongBao(3, 244);
            }
            if (ThuMoi == true)
            {
                HuyThongBao(16, 194);
                ThongBao(3, 194);
            }
            if (BaoMoi == true)
            {
                HuyThongBao(16, 294);
                ThongBao(3, 294);
            }
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
            LoadThongBao();
        }
        //Menu Button_Clicks
        private void button_ThongTin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ThongBao();
            Update_GiaoDien_NgonNgu();
            OpenChildForm(new form_ThongTin(tk));
        }
        private void button_KhuyenMai_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ThongBao();
            Update_GiaoDien_NgonNgu();
            OpenChildForm(new form_KhuyenMai(tk));
        }
        private void button_BangXepHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ThongBao();
            Update_GiaoDien_NgonNgu();
            OpenChildForm(new form_BangXepHang(tk));
        }
        private void button_HopThu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            HuyThongBao(3, 194);
            ThongBao();
            Update_GiaoDien_NgonNgu();
            OpenChildForm(new form_HopThu(tk));
        }
        private void button_DonDangKyIdol_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            HuyThongBao(3, 244);
            ThongBao();
            Update_GiaoDien_NgonNgu();
            OpenChildForm(new form_DonDangKyIdol(tk));
        }
        private void button_BaoCao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            HuyThongBao(3, 294);
            ThongBao();
            Update_GiaoDien_NgonNgu();
            OpenChildForm(new form_BaoCao(tk));
        }
        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ThongBao();
            Update_GiaoDien_NgonNgu();
            OpenChildForm(new form_ThongKe(tk));
        }
        private void button_LichSuHoatDong_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ThongBao();
            Update_GiaoDien_NgonNgu();
            OpenChildForm(new form_LichSuHoatDong(this.tk));
        }
        private void button_LichSuGiaoDich_Click(object sender, EventArgs e)
        {
            
            ActivateButton(sender);
            ThongBao();
            Update_GiaoDien_NgonNgu();
            OpenChildForm(new form_LichSuGiaoDich(tk));
        }
        private void button_CaiDat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ThongBao();
            Update_GiaoDien_NgonNgu();
            OpenChildForm(new form_CaiDat(tk));
        }
        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_DangNhap login = new form_DangNhap();
            login.ShowDialog();
            this.Close();
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Close-Maximize-Minimize
        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void Chinh_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
        private void button_Facebook_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/phu.d.thinh/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
        private void button_Youtube_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/phu.d.thinh/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
        private void button_Twitter_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/phu.d.thinh/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
        private void form_Chinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            On_Quit();
        }
        private void button_Instagram_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/phu.d.thinh/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
        private void button_Tiktok_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/phu.d.thinh/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
        private void button_Gmail_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/phu.d.thinh/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
        private void button_Website_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/phu.d.thinh/",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
        private void textbox_GhiChu_Leave(object sender, EventArgs e)
        {
            NguoiDungDAO.Instance.ThemNote(textbox_GhiChu.Texts, tk);
        }
    }
}
