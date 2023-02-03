using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupid.DAO
{
    internal class HopThuDAO
    {
        private static HopThuDAO instance; // Ctrl + R + E

        public static HopThuDAO Instance
        {
            get { if (instance == null) instance = new HopThuDAO(); return HopThuDAO.instance; }
            private set { HopThuDAO.instance = value; }
        }

        public bool GuiThu(string mathu,string ng_gui,string ng_nhan,string chude,string noidung,DateTime ngaygui,int trangthai)
        {
            int data = 0;
            int data2 = 0;
            data = DataProvider.Instance.ExecuteNonQuery("INSERT INTO HOP_THU VALUES('" + mathu + "_G','" + ng_gui + "','" + ng_nhan + "',N'" + chude + "',N'" + noidung + "','" + ngaygui + "'," + 1 + ")");
            data2 = DataProvider.Instance.ExecuteNonQuery("INSERT INTO HOP_THU VALUES('" + mathu + "_N','" + ng_gui + "','" + ng_nhan + "',N'" + chude + "',N'" + noidung + "','" + ngaygui + "'," + trangthai + ")");

            return data > 0 && data2 > 0;
        }

        public int LuuThuNhap(string mathu, string ng_gui, string ng_nhan, string chude, string noidung, DateTime ngaygui, int trangthai)
        {
            int data = 0;
            data = DataProvider.Instance.ExecuteNonQuery("INSERT INTO HOP_THU VALUES('" + mathu + "_G','" + ng_gui + "','" + ng_nhan + "',N'" + chude + "',N'" + noidung + "','" + ngaygui + "'," + trangthai + ")");

            return data;
        }

        public bool getSoThu(string tk,int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from hop_thu where tk_nhan = '"+tk+"' and trang_thai = "+id+"");

            return data.Rows.Count > 0;
        }
        
        public DataTable getThuChuaXemTheoTk(string tkg,string tkn)
        {
            string query = "SELECT * FROM HOP_THU WHERE TK_GUI like '%"+tkg+ "%' AND TRANG_THAI = 0 and TK_NHAN = '" + tkn + "' order by NGAY_GUI DESC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable getThuDaXemTheoTk(string tkg,string tkn)
        {
            string query = "SELECT * FROM HOP_THU WHERE TK_GUI like '%" + tkg + "%' AND TRANG_THAI = 1 and TK_NHAN = '" + tkn + "' order by NGAY_GUI DESC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable getThuDaGuiTheoTk(string tkg,string tkn )
        {
            string query = "SELECT * FROM HOP_THU WHERE TK_NHAN like '%" + tkn + "%' and TK_GUI =  '" + tkg + "' and TRANG_THAI != 2 order by NGAY_GUI DESC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable getThuNhap2(string tkg,string tkn) // Tìm kiếm thư nháp
        {
            string query = "SELECT * FROM HOP_THU WHERE TK_GUI = '" + tkg + "' and TRANG_THAI = 2 and TK_NHAN like '%"+tkn+ "%' order by NGAY_GUI DESC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable getThuDaNhan(string tk,int id)
        {
            string query = "SELECT * FROM HOP_THU WHERE TRANG_THAI = " + id + " and TK_NHAN = '"+tk+ "'  AND MA_THU like '%_N' order by NGAY_GUI DESC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
        public DataTable getThuDaGui(string tk)
        {
            string query = "SELECT * FROM HOP_THU WHERE  TK_GUI = '" + tk + "' AND  TRANG_THAI != 2 AND TRANG_THAI != 3 AND MA_THU like '%_G' order by NGAY_GUI DESC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable getThuNhap(string tk)
        {
            string query = "SELECT * FROM HOP_THU WHERE  TK_GUI = '" + tk + "' and TRANG_THAI = 2 and MA_THU like '%_G' order by NGAY_GUI DESC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public int DaXem(string ma)
        {
            int data = 0;

            data = DataProvider.Instance.ExecuteNonQuery("UPDATE HOP_THU SET TRANG_THAI = 1  WHERE MA_THU = '" + ma + "'");

            return data;
        }

        public int XoaThu(string id)
        {
            int data = 0;

            data = DataProvider.Instance.ExecuteNonQuery("UPDATE HOP_THU SET TRANG_THAI = 3 WHERE MA_THU = '"+id+"'");

            return data;
        }

        public int guiEmail(string chude,string noidung,string taikhoan )
        {
            int data = 0;
            string query = "select gmail from nguoi_dung where tai_khoan = '"+taikhoan+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string email = dt.Rows[0][0].ToString();

            query = " EXEC msdb.dbo.sp_send_dbmail @profile_name = 'CupidTeamVN',  @recipients = '"+email+"', @body = N'"+noidung+"', @body_format = 'HTML',  @subject = N'"+chude+"';"; 
            data = DataProvider.Instance.ExecuteNonQuery(query);

            return data;
        }

        public bool getMail(string tk)
        {
            string query = "select gmail from nguoi_dung where tai_khoan = '" + tk + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string email = dt.Rows[0][0].ToString();

            return email != "";
        }
    }
}
