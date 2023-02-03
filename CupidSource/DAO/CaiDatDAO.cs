using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupid.DAO
{
    internal class CaiDatDAO
    {
        private static CaiDatDAO instance;

        internal static CaiDatDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CaiDatDAO();
                return CaiDatDAO.instance;
            }
            private set { CaiDatDAO.instance = value; }
        }

        public Color color_BG_ColorApp_01;
        public Color color_BG_ColorApp_02;

        public Color color_BG_Blue_01 = Color.FromArgb(150, 200, 250); // nhạt
        public Color color_BG_Blue_02 = Color.FromArgb(130, 180, 230); // đậm

        public Color color_BG_Red_01 = Color.FromArgb(250, 80, 100); // nhạt
        public Color color_BG_Red_02 = Color.FromArgb(200, 80, 100); // đậm

        public Color color_BG_Green_01 = Color.FromArgb(100, 200, 80); // nhạt
        public Color color_BG_Green_02 = Color.FromArgb(100, 150, 80); // đậm

        public Color color_BG_Orange_01 = Color.FromArgb(250, 100, 80); // nhạt
        public Color color_BG_Orange_02 = Color.FromArgb(200, 100, 80); // đậm

        public Color color_BG_Yellow_01 = Color.FromArgb(200, 200, 0); // nhạt
        public Color color_BG_Yellow_02 = Color.FromArgb(150, 150, 0); // đậm

        public Color color_BG_BlueDark_01 = Color.FromArgb(80, 150, 250); // nhạt
        public Color color_BG_BlueDark_02 = Color.FromArgb(80, 100, 250); // đậm

        public Color color_BG_Violet_01 = Color.FromArgb(200, 80, 250); // nhạt
        public Color color_BG_Violet_02 = Color.FromArgb(150, 80, 250); // đậm

        public Color color_BG_Pink_01 = Color.FromArgb(250, 150, 200); // nhạt
        public Color color_BG_Pink_02 = Color.FromArgb(250, 100, 150); // đậm

        public Color color_BG_Brown_01 = Color.FromArgb(100, 50, 50); // nhạt
        public Color color_BG_Brown_02 = Color.FromArgb(100, 0, 0); // đậm

        public Color color_BG_Grey_01 = Color.FromArgb(150, 150, 150); // nhạt
        public Color color_BG_Grey_02 = Color.FromArgb(70, 70, 70); // đậm

        public Color color_BG_White_01 = Color.FromArgb(255, 255, 255);
        public Color color_BG_White_02 = Color.FromArgb(240, 242, 245);
        public Color color_BG_Black_01 = Color.FromArgb(36, 37, 38);
        public Color color_BG_Black_02 = Color.FromArgb(24, 25, 26);

        public Color color_Text_White_01 = Color.FromArgb(0, 0, 0); // màu đen
        public Color color_Text_White_02 = Color.FromArgb(5, 5, 5);
        public Color color_Text_Black_01 = Color.FromArgb(255, 255, 255); // màu trắng
        public Color color_Text_Black_02 = Color.FromArgb(228, 230, 235);

        public Color color_Text_Red = Color.FromArgb(250, 80, 100);
        public Color color_Text_Green = Color.FromArgb(100, 250, 80);

        public Color color_Grid = Color.FromArgb(206, 208, 212);
        public Color color_Gridview_Hover_White = Color.FromArgb(228, 230, 233);
        public Color color_Gridview_Hover_Black = Color.FromArgb(58, 59, 60);

        public Color color_Text_DarkGray = Color.DarkGray;

        public void CapNhatGiaoDien(string tk, int giaodien)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE CAI_DAT SET GIAO_DIEN = '" + giaodien + "' WHERE TAI_KHOAN = '" + tk + "'");
        }
        public void CapNhatNgonNgu(string tk, int ngonngu)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE CAI_DAT SET NGON_NGU = '" + ngonngu + "' WHERE TAI_KHOAN = '" + tk + "'");
        }
        public void CapNhatTabMenu(string tk, int tabmenu)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE CAI_DAT SET MENU_TAB = '" + tabmenu + "' WHERE TAI_KHOAN = '" + tk + "'");
        }
        public void CapNhatColorApp(string tk, int colorapp)
        {
            DataProvider.Instance.ExecuteNonQuery("UPDATE CAI_DAT SET COLOR_APP = '" + colorapp + "' WHERE TAI_KHOAN = '" + tk + "'");
        }
    }
}
