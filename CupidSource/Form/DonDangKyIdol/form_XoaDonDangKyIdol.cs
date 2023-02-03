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
    public partial class form_XoaDonDangKyIdol : Form
    {
        string tk;
        bool check_giaodien, check_ngonngu;
        public form_XoaDonDangKyIdol(string tk)
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

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            var f = (form_DonDangKyIdol)this.Owner;
            f.vt = -1;
            f.dataGridView.ClearSelection();
            f.OnOffBtn(false);
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
            var f = (form_DonDangKyIdol)this.Owner;
            f.vt = -1;
            f.dataGridView.ClearSelection();
            f.OnOffBtn(false);
        }

        private void button_DongY_Click(object sender, EventArgs e)
        {
            var f = (form_DonDangKyIdol)this.Owner;
            DonDangKyIdolDAO.Instance.XoaDonDangKy(f.row.Cells[0].Value.ToString());
            if (f.btn == f.button_ChuaXem)
            {
                f.button_ChuaXem_Click(f.btn, f.ea);
                f.ActivateButton(f.button_ChuaXem);
                
            }
            else
            {
                f.button_DaXem_Click(f.btn, f.ea);
                f.ActivateButton(f.button_DaXem);
                
            }
            this.Close();
        }
        private void form_XoaTinNhan_Load(object sender, EventArgs e)
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
            button_DongY.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
            button_Huy.ForeColor = CaiDatDAO.Instance.color_Text_Black_01;
        }
        public void Change_Color_Black()
        {
            //Background
            this.BackColor = CaiDatDAO.Instance.color_BG_Black_01;
            button_Close.IconColor = CaiDatDAO.Instance.color_Text_White_01;
            label_Title.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            pictureBox_Icon.Image = Cupid.Properties.Resources.Icon_Black;

            //Button
            button_DongY.ForeColor = CaiDatDAO.Instance.color_Text_White_01;
            button_Huy.ForeColor = CaiDatDAO.Instance.color_Text_White_01;

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
            label_Title.Text = "Thông báo";
            //Textbox
            label_NoiDung.Text = "Bạn có chắc chắn muốn xóa đơn đăng ký Idol của người dùng này?";
            //Button
            button_DongY.Text = "Đồng ý";
            button_Huy.Text = "Hủy";

        }
        public void Change_Language_EN()
        {
            //Label
            label_Title.Text = "Notification";
            //Textbox
            label_NoiDung.Text = "Are you sure you want to delete this user's Idol registration form? ";
            //Button
            button_DongY.Text = "Ok";
            button_Huy.Text = "Cancel";
        }
        public void UpdateColorApp()
        {
            panel_Top.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;
            button_Close.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_02;

            button_DongY.BackColor = CaiDatDAO.Instance.color_BG_ColorApp_01;

            pictureBox_IconThongBao.IconColor = CaiDatDAO.Instance.color_BG_ColorApp_01;
        }
    }
}