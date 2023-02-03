using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Cupid.DAO;
using Cupid.DTO;
using Cupid.Toolbox_Custom;

namespace Cupid
{
    public partial class form_BangXepHang : Form
    {

        private Button_Custom currentBtn;
        private Panel leftBorderBtn;
        List<ComponentXepHang> lscpn = new List<ComponentXepHang>();
        List<XepHang> lsxh = new List<XepHang>();
        string tk;
        bool check_giaodien, check_ngonngu;
        public form_BangXepHang(string tk)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(120, 3);
            panel_Top.Controls.Add(leftBorderBtn);
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
        }
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Button_Custom)senderBtn;
                currentBtn.ForeColor = Color.Black;
                //Left border button
                if (!check_giaodien)
                {
                    currentBtn.BackColor = CaiDatDAO.Instance.color_BG_White_02;
                    currentBtn.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
                }
                else
                {
                    currentBtn.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
                    currentBtn.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
                }
                leftBorderBtn.BackColor = CaiDatDAO.Instance.color_BG_Blue_02;
                leftBorderBtn.Location = new Point(currentBtn.Location.X, 47);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                if (!check_giaodien)
                {
                    currentBtn.BackColor = CaiDatDAO.Instance.color_BG_White_02;
                }
                else
                {
                    currentBtn.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
                }
                currentBtn.ForeColor = CaiDatDAO.Instance.color_Text_DarkGray;
            }
        }

        
        private void form_BangXepHang_Load(object sender, EventArgs e)
        {
            AddListComponent();
            DataTable dt = BangXepHangDAO.Instance.getBXHHomNay(1);
            AddListXH(dt);
            ShowBXH();
            combobox_HinhThuc.SelectedIndex = 1;
        }

        void AddListXH(DataTable dt)
        {
            lsxh.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lsxh.Add(new XepHang(dt.Rows[i]));
            }
        }

        void ShowBXH()
        {
            if (lscpn.Count > lsxh.Count)
            {
                for (int i = 0; i < 1; i++)
                {
                    lscpn.RemoveAt(lscpn.Count - i - 1);
                }
            }

            for (int j = 0; j < lsxh.Count; j++)
            {
                lscpn[j].pc.Image = DataProvider.Instance.Base64ToImage(lsxh[j].Hinh_Anh);
                lscpn[j].lbten.Text = lsxh[j].Tai_Khoan;
                lscpn[j].lbtien.Text = ShowMoney(lsxh[j].So_Tien.ToString()) + " VND";
            }



        }
        void AddListComponent()
        {
            lscpn.Clear();
            lscpn.Add(new ComponentXepHang(pictureBox_Top1, label_TenTop1, label_TienTop1));
            lscpn.Add(new ComponentXepHang(pictureBox_Top2, label_TenTop2, label_TienTop2));
            lscpn.Add(new ComponentXepHang(pictureBox_Top3, label_TenTop3, label_TienTop3));
            lscpn.Add(new ComponentXepHang(pictureBox_Top4, label_TenTop4, label_TienTop4));
            lscpn.Add(new ComponentXepHang(pictureBox_Top5, label_TenTop5, label_TienTop5));
            lscpn.Add(new ComponentXepHang(pictureBox_Top6, label_TenTop6, label_TienTop6));
            lscpn.Add(new ComponentXepHang(pictureBox_Top7, label_TenTop7, label_TienTop7));
            lscpn.Add(new ComponentXepHang(pictureBox_Top8, label_TenTop8, label_TienTop8));
            lscpn.Add(new ComponentXepHang(pictureBox_Top9, label_TenTop9, label_TienTop9));
            lscpn.Add(new ComponentXepHang(pictureBox_Top10, label_TenTop10, label_TienTop10));
            foreach (ComponentXepHang item in lscpn)
            {
                item.lbtien.Text = "";
                item.pc.Image = Properties.Resources.Default_Avt;
                item.lbten.Text = "";
            }

        }


        string ShowMoney(string money)
        {
            string m = "";
            string[] arr = money.Split('$');
            string[] brr = arr[1].Split('.');
            for (int i = 0; i < brr.Length - 1; i++)
            {
                m += brr[i];
            }
            return m;
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
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_White_02;
            //Button
            dateTimePicker_NgayBatDau.SkinColor = CaiDatDAO.Instance.color_BG_White_01;
            dateTimePicker_NgayKetThuc.SkinColor = CaiDatDAO.Instance.color_BG_White_01;
            combobox_HinhThuc.BackColor = CaiDatDAO.Instance.color_BG_White_01;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_Black_02;
            //Button
            dateTimePicker_NgayBatDau.SkinColor = CaiDatDAO.Instance.color_BG_Black_01;
            dateTimePicker_NgayKetThuc.SkinColor = CaiDatDAO.Instance.color_BG_Black_01;
            combobox_HinhThuc.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
        }
        public bool KiemTraNgonNgu(string userName)
        {
            string query = "SELECT * FROM dbo.CAI_DAT WHERE TAI_KHOAN = N'" + userName + "' AND NGON_NGU = 1";

            System.Data.DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public void Change_Language_VI()
        {
            label_Top1.Text = "Hạng 1";
            label_Top2.Text = "Hạng 2";
            label_Top3.Text = "Hạng 3";
            label_Top4.Text = "Hạng 4";
            label_Top5.Text = "Hạng 5";
            label_Top6.Text = "Hạng 6";
            label_Top7.Text = "Hạng 7";
            label_Top8.Text = "Hạng 8";
            label_Top9.Text = "Hạng 9";
            label_Top10.Text = "Hạng 10";

            label_TenTop1.Text = "Tên người dùng";
            label_TenTop2.Text = "Tên người dùng";
            label_TenTop3.Text = "Tên người dùng";
            label_TenTop4.Text = "Tên người dùng";
            label_TenTop5.Text = "Tên người dùng";
            label_TenTop6.Text = "Tên người dùng";
            label_TenTop7.Text = "Tên người dùng";
            label_TenTop8.Text = "Tên người dùng";
            label_TenTop9.Text = "Tên người dùng";
            label_TenTop10.Text = "Tên người dùng";
        }
        public void UpdateColorApp()
        {
            dateTimePicker_NgayBatDau.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            dateTimePicker_NgayKetThuc.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            combobox_HinhThuc.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            combobox_HinhThuc.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            pictureBox_Top1.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top2.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top3.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top4.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top5.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top6.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top7.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top8.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top9.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top10.BorderColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            pictureBox_Top1.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top2.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top3.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top4.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top5.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top6.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top7.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top8.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top9.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;
            pictureBox_Top10.BorderColor2 = CaiDatDAO.Instance.color_BG_ColorApp_01;

            label_Top1.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            label_Top2.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            label_Top3.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            label_TenTop1.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            label_TenTop2.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            label_TenTop3.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            label_TienTop1.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            label_TienTop2.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
            label_TienTop3.ForeColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
        private void dateTimePicker_NgayBatDau_Leave(object sender, EventArgs e)
        {
            label_Loi.ResetText();
            int comPare = DateTime.Compare(dateTimePicker_NgayKetThuc.Value, dateTimePicker_NgayBatDau.Value);

            if (dateTimePicker_NgayBatDau.Text != dateTimePicker_NgayKetThuc.Text)
            {
                if (comPare < 0)
                {
                    label_Loi.Text = "Ngày không hợp lệ";
                    return;
                }
                else
                {
                    AddListComponent();
                    DataTable dt = BangXepHangDAO.Instance.getBXHTheoNgay(combobox_HinhThuc.SelectedIndex,dateTimePicker_NgayBatDau.Value,dateTimePicker_NgayKetThuc.Value);
                    AddListXH(dt);
                    ShowBXH();
                }
            }
            else
            {
                AddListComponent();
                DataTable dt = BangXepHangDAO.Instance.getBXHHomNay(combobox_HinhThuc.SelectedIndex);
                AddListXH(dt);
                ShowBXH();
            }
        }

        private void dateTimePicker_NgayKetThuc_Leave(object sender, EventArgs e)
        {
            label_Loi.ResetText();

            int comPare = DateTime.Compare(dateTimePicker_NgayKetThuc.Value, dateTimePicker_NgayBatDau.Value);

            if (dateTimePicker_NgayBatDau.Text != dateTimePicker_NgayKetThuc.Text)
            {
                if (comPare < 0)
                {
                    label_Loi.Text = "Ngày không hợp lệ";
                    return;
                }
                else
                {
                    AddListComponent();
                    DataTable dt = BangXepHangDAO.Instance.getBXHTheoNgay(combobox_HinhThuc.SelectedIndex, dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                    AddListXH(dt);
                    ShowBXH();
                }
            }
            else
            {
                AddListComponent();
                DataTable dt = BangXepHangDAO.Instance.getBXHHomNay(combobox_HinhThuc.SelectedIndex);
                AddListXH(dt);
                ShowBXH();
            }
        }

        private void combobox_HinhThuc_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            label_Loi.ResetText();

            int comPare = DateTime.Compare(dateTimePicker_NgayKetThuc.Value, dateTimePicker_NgayBatDau.Value);

            if (dateTimePicker_NgayBatDau.Text != dateTimePicker_NgayKetThuc.Text)
            {
                if (comPare < 0)
                {
                    label_Loi.Text = "Ngày không hợp lệ";
                    return;

                }
                else
                {
                    AddListComponent();
                    DataTable dt = BangXepHangDAO.Instance.getBXHTheoNgay(combobox_HinhThuc.SelectedIndex, dateTimePicker_NgayBatDau.Value, dateTimePicker_NgayKetThuc.Value);
                    AddListXH(dt);
                    ShowBXH();
                }
            }
            else
            {
                AddListComponent();
                DataTable dt = BangXepHangDAO.Instance.getBXHHomNay(combobox_HinhThuc.SelectedIndex);
                AddListXH(dt);
                ShowBXH();
            }
        }

        public void Change_Language_EN()
        {
            label_Top1.Text = "Top 1";
            label_Top2.Text = "Top 2";
            label_Top3.Text = "Top 3";
            label_Top4.Text = "Top 4";
            label_Top5.Text = "Top 5";
            label_Top6.Text = "Top 6";
            label_Top7.Text = "Top 7";
            label_Top8.Text = "Top 8";
            label_Top9.Text = "Top 9";
            label_Top10.Text = "Top 10";

            label_TenTop1.Text = "Username";
            label_TenTop2.Text = "Username";
            label_TenTop3.Text = "Username";
            label_TenTop4.Text = "Username";
            label_TenTop5.Text = "Username";
            label_TenTop6.Text = "Username";
            label_TenTop7.Text = "Username";
            label_TenTop8.Text = "Username";
            label_TenTop9.Text = "Username";
            label_TenTop10.Text = "Username";

        }
    }
}
