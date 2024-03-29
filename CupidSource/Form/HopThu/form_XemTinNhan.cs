﻿using Cupid.DAO;
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
    public partial class form_XemTinNhan : Form
    {
        DataGridViewRow row;
        string tk;
        bool check_giaodien, check_ngonngu;
        public form_XemTinNhan(DataGridViewRow row2,string tk)
        {
            InitializeComponent();
            this.tk = tk;
            UpdateColorApp();
            Update_GiaoDien_NgonNgu();
            this.row = row2;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            textbox_NguoiGui.Texts = row2.Cells[1].Value.ToString();
            textbox_ChuDe.Texts = row2.Cells[3].Value.ToString(); 
            textbox_NoiDung.Texts = row2.Cells[4].Value.ToString();
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
            var f = (form_HopThu)this.Owner;
            if (f.currentBtn == f.button_ChuaXem)
            {
                f.button_ChuaXem_Click(f.button_ChuaXem, e);
                f.ActivateButton(f.button_ChuaXem);
            }
            this.Close();
        }

        private void button_PhanHoi_Click(object sender, EventArgs e)
        {
            if (tk != row.Cells[1].Value.ToString())
            {
                form_PhanHoiTinNhan f = new form_PhanHoiTinNhan(row, tk);
                f.ShowDialog();
            }
        }

        private void form_XemTinNhan_Load(object sender, EventArgs e)
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
            button_PhanHoi.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;

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
            label_Title.Text = "Xem tin nhắn";
            //Textbox
            textbox_NguoiGui.PlaceholderText = "Người gửi";
            textbox_ChuDe.PlaceholderText = "Chủ đề";
            textbox_NoiDung.PlaceholderText = "Nội dung";
            button_PhanHoi.Text = "Phản hồi";
        }
        public void Change_Language_EN()
        {
            //Label
            label_Title.Text = "View the message";
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
        }
    }
}