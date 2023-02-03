using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupid.DAO
{
    internal class NguoiDungDAO
    {
        private static NguoiDungDAO instance;

        internal static NguoiDungDAO Instance 
        {
            get { if (instance == null) 
                    instance = new NguoiDungDAO(); 
                return NguoiDungDAO.instance; }
            private set { NguoiDungDAO.instance = value; }
        }

       
        public bool Login(string userName, string passWord, DataTable result)
        {
            string query = "SELECT * FROM dbo.NGUOI_DUNG WHERE TAI_KHOAN = N'" + userName + "' AND MAT_KHAU = N'" + passWord + "' ";

            result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public DataTable getNguoiDung(int id)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = "+id+" ");

            return dt;
        }

        public DataTable getNguoiDung2(string id)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM NGUOI_DUNG WHERE TAI_KHOAN = '" + id + "' ");

            return dt;
        }


        public DataTable getHinhAnh(string id)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT HINH_ANH FROM HINH_ANH WHERE TAI_KHOAN = '" + id + "' ");

            return dt;
        }

        public bool NapTien(string tk,int soTien)
        {
            int data = 0;
            string query = "UPDATE NGUOI_DUNG SET TIEN = TIEN + "+soTien+" WHERE TAI_KHOAN = '"+tk+"'";
            data = DataProvider.Instance.ExecuteNonQuery(query);    

            return data > 0;
        }
        public bool ThemNguoiDung(byte[] ha,string tk, string mk, int loaitk,string hoten, string gt, System.DateTime ngaysinh,string quequan,string noio, string ddhenho,string nghenghiep, float chieucao,float cannang,float vong1,float vong2,float vong3,string sothich , string cunghoangdao,bool trangthai, string fb, string it, string tt, string tw, string zalo, string gmail, string sdt,int giatien,string tieusu,string bietdanh,DateTime ngaythamgia)
        {
            int data = 0;
            string query = @"INSERT INTO NGUOI_DUNG VALUES('" + tk + "','" + mk + "'," + loaitk + " , @ha , N'" + hoten + "','" + ngaysinh + "',N'" + gt + "',N'" + quequan + "',N'" + noio + "',N'" + ddhenho + "',N'" + nghenghiep + "'," + chieucao + "," + cannang + "," + vong1 + "," + vong2 + "," + vong3 + ",N'" + cunghoangdao + "',N'" + sothich + "','" + trangthai + "','" + fb + "','" + it + "', '" + tt + "', '" + tw + "','" + zalo + "','" + gmail + "','" + sdt + "','',0,"+giatien+",N'"+tieusu+"',N'"+bietdanh+"','"+ngaythamgia+"') ";

            data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ha });

            return data > 0;
        }

      

        public bool ThemNguoiDungKoAvatar(string tk, string mk, int loaitk, string hoten, string gt, System.DateTime ngaysinh, string quequan, string noio, string ddhenho, string nghenghiep, float chieucao, float cannang, float vong1, float vong2, float vong3, string sothich, string cunghoangdao, bool trangthai, string fb, string it, string tt, string tw, string zalo, string gmail, string sdt)
        {
            int data = 0;
            string query = @"INSERT INTO NGUOI_DUNG VALUES('" + tk + "','" + mk + "'," + loaitk + " , @ha , N'" + hoten + "','" + ngaysinh + "',N'" + gt + "',N'" + quequan + "',N'" + noio + "',N'" + ddhenho + "',N'" + nghenghiep + "'," + chieucao + "," + cannang + "," + vong1 + "," + vong2 + "," + vong3 + ",N'" + cunghoangdao + "',N'" + sothich + "','" + trangthai + "','"+fb+"','"+it+"', '"+tt+"', '"+tw+"','"+zalo+"','"+gmail+"','"+sdt+"','',0) ";

            data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { System.Data.SqlTypes.SqlBinary.Null });

            return data > 0;
        }

        public bool ThemAnh(string tk,List<Image> images)
        {
            int data = 0;
            string query = "INSERT INTO HINH_ANH VALUES( '" + tk + "' , @MA , @HA2 )";

            for (int i = 0; i < images.Count; i++)
            {
                data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { i.ToString(), DataProvider.Instance.ImageToBase64(images[i], images[i].RawFormat) });
            }
            return data > 0;
        }

       

        public bool SuaNguoiDung(byte[] ha, string tk, string mk, int loaitk, string hoten, string gt, System.DateTime ngaysinh, string quequan, string noio, string ddhenho, string nghenghiep, float chieucao, float cannang, float vong1, float vong2, float vong3, string sothich, string cunghoangdao, bool trangthai, string fb, string it, string tt, string tw, string zalo, string gmail, string sdt, int giatien, string tieusu, string bietdanh)
        {
            int data = 0;
            string query = @"UPDATE NGUOI_DUNG SET MAT_KHAU = '" + mk + "', LOAI_NGUOI_DUNG = " + loaitk + " , ANH_DAI_DIEN = @ha , HO_TEN = N'" + hoten + "',NGAY_SINH ='" + ngaysinh + "',GIOI_TINH = N'" + gt + "',QUE_QUAN = N'" + quequan + "',NOI_O = N'" + noio + "',DD_HENHO = N'" + ddhenho + "',NGHE_NGHIEP = N'" + nghenghiep + "',CHIEU_CAO = " + chieucao + ",CAN_NANG = " + cannang + ",VONG_1 = " + vong1 + ",VONG_2 = " + vong2 + ",VONG_3 = " + vong3 + ",CUNG_HOANG_DAO = N'" + cunghoangdao + "',SO_THICH = N'" + sothich + "',TRANG_THAI_TK ='" + trangthai + "' ,LINK_FB = '" + fb + "',LINK_IT = '" + it + "',LINK_TT = '" + tt + "',LINK_TW = '" + tw + "',ZALO = '" + zalo + "',GMAIL = '"+gmail+"',SDT = '" + sdt + "' , GIA_TIEN = "+giatien+", BIET_DANH = N'"+bietdanh+"',TIEU_SU = N'"+tieusu+"' WHERE TAI_KHOAN = '" + tk + "' ";

            data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ha });

            return data > 0;
        }

        public bool SuaNguoiDungKoAvatar(string tk, string mk, int loaitk, string hoten, string gt, System.DateTime ngaysinh, string quequan, string noio, string ddhenho, string nghenghiep, float chieucao, float cannang, float vong1, float vong2, float vong3, string sothich, string cunghoangdao, bool trangthai,string fb,string it,string tt,string tw,string zalo,string gmail,string sdt)
        {
            int data = 0;
            string query = @"UPDATE NGUOI_DUNG SET MAT_KHAU = '" + mk + "',LOAI_NGUOI_DUNG = " + loaitk + " , ANH_DAI_DIEN = @ha , HO_TEN = N'" + hoten + "',NGAY_SINH ='" + ngaysinh + "',GIOI_TINH = N'" + gt + "',QUE_QUAN = N'" + quequan + "',NOI_O = N'" + noio + "',DD_HENHO = N'" + ddhenho + "',NGHE_NGHIEP = N'" + nghenghiep + "',CHIEU_CAO = " + chieucao + ",CAN_NANG = " + cannang + ",VONG_1 = " + vong1 + ",VONG_2 = " + vong2 + ",VONG_3 = " + vong3 + ",CUNG_HOANG_DAO = N'" + cunghoangdao + "',SO_THICH = N'" + sothich + "',TRANG_THAI_TK ='" + trangthai + "' ,LINK_FB = '"+fb+"',LINK_IT = '"+it+"',LINK_TT = '"+tt+"',LINK_TW = '"+tw+"',ZALO = '"+zalo+"',GMAIL = '"+gmail+"',SDT = '"+sdt+"' WHERE TAI_KHOAN = '" + tk + "' ";

            data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { System.Data.SqlTypes.SqlBinary.Null });

            return data > 0;
        }

        public bool SuaNguoiDungKoMxh(byte[] ha, string tk, string mk, int loaitk, string hoten, string gt, System.DateTime ngaysinh, string quequan, string noio, string ddhenho, string nghenghiep, float chieucao, float cannang, float vong1, float vong2, float vong3, string sothich, string cunghoangdao, bool trangthai)
        {
            int data = 0;
            string query = @"UPDATE NGUOI_DUNG SET MAT_KHAU = '" + mk + "',LOAI_NGUOI_DUNG = " + loaitk + " , ANH_DAI_DIEN = @ha , HO_TEN = N'" + hoten + "',NGAY_SINH ='" + ngaysinh + "',GIOI_TINH = N'" + gt + "',QUE_QUAN = N'" + quequan + "',NOI_O = N'" + noio + "',DD_HENHO = N'" + ddhenho + "',NGHE_NGHIEP = N'" + nghenghiep + "',CHIEU_CAO = " + chieucao + ",CAN_NANG = " + cannang + ",VONG_1 = " + vong1 + ",VONG_2 = " + vong2 + ",VONG_3 = " + vong3 + ",CUNG_HOANG_DAO = N'" + cunghoangdao + "',SO_THICH = N'" + sothich + "',TRANG_THAI_TK ='" + trangthai + "'  WHERE TAI_KHOAN = '" + tk + "' ";

            data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { ha });

            return data > 0;
        }

        public bool SuaNguoiDungKoAvatarMxh(string tk, string mk, int loaitk, string hoten, string gt, System.DateTime ngaysinh, string quequan, string noio, string ddhenho, string nghenghiep, float chieucao, float cannang, float vong1, float vong2, float vong3, string sothich, string cunghoangdao, bool trangthai)
        {
            int data = 0;
            string query = @"UPDATE NGUOI_DUNG SET MAT_KHAU = '" + mk + "',LOAI_NGUOI_DUNG = " + loaitk + " , ANH_DAI_DIEN = @ha , HO_TEN = N'" + hoten + "',NGAY_SINH ='" + ngaysinh + "',GIOI_TINH = N'" + gt + "',QUE_QUAN = N'" + quequan + "',NOI_O = N'" + noio + "',DD_HENHO = N'" + ddhenho + "',NGHE_NGHIEP = N'" + nghenghiep + "',CHIEU_CAO = " + chieucao + ",CAN_NANG = " + cannang + ",VONG_1 = " + vong1 + ",VONG_2 = " + vong2 + ",VONG_3 = " + vong3 + ",CUNG_HOANG_DAO = N'" + cunghoangdao + "',SO_THICH = N'" + sothich + "',TRANG_THAI_TK ='" + trangthai + "'  WHERE TAI_KHOAN = '" + tk + "' ";

            data = DataProvider.Instance.ExecuteNonQuery(query, new object[] { System.Data.SqlTypes.SqlBinary.Null });

            return data > 0;
        }

        public DataTable getSoDt(string tk)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("select SDT from NGUOI_DUNG where TAI_KHOAN = '"+tk+"'");

            return dt;
        }

        public bool XoaNguoiDung(string TK)
        {
            int data = 0;
            string query = "DELETE FROM NGUOI_DUNG WHERE TAI_KHOAN = '" + TK + "'";

            data = DataProvider.Instance.ExecuteNonQuery(query);

            return data > 0;
        }
        public bool XoaHinhAnh(string tk)
        {
            int data = 0;
            string query = "DELETE FROM HINH_ANH WHERE TAI_KHOAN = '" + tk + "'";

            data = DataProvider.Instance.ExecuteNonQuery(query);

            return data >= 0;
        }

        public bool KhoaNguoiDung(string tk,int daylock,string lydo)
        {
            int data = 0;

            string query = "UPDATE NGUOI_DUNG SET TRANG_THAI_TK = 'FALSE' WHERE TAI_KHOAN = '" + tk + "'";
            data = DataProvider.Instance.ExecuteNonQuery(query);

            query = "insert into LICH_SU_VI_PHAM(TAI_KHOAN,NGAY_KHOA,NGAY_MO_KHOA,LY_DO) values('"+tk+"','"+DateTime.UtcNow+"',dateadd(day,"+daylock+ ",'"+DateTime.UtcNow+"'),N'"+lydo+"')";
            data = DataProvider.Instance.ExecuteNonQuery(query);

            return data > 0;
        }

        public bool MoKhoaNguoiDung(string tk)
        {
            int data = 0;
            string query = "UPDATE NGUOI_DUNG SET TRANG_THAI_TK = 'TRUE' WHERE TAI_KHOAN = '" + tk + "'";
            data = DataProvider.Instance.ExecuteNonQuery(query);

            return data > 0;
        }

        public DataTable SoNgayKhoaConLai(string tk)
        {
            DataTable dt = new DataTable();
            string query = "select datediff(day,'"+DateTime.UtcNow+"',lsvp.NGAY_MO_KHOA) from LICH_SU_VI_PHAM lsvp where TAI_KHOAN = '"+tk+"'" +
                "and NGAY_KHOA = (select top 1 NGAY_KHOA from LICH_SU_VI_PHAM where TAI_KHOAN = '"+tk+"' order by NGAY_KHOA desc )";

            dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
        public int ThemNote(string note,string tk)
        {
            int data = 0;
            data = DataProvider.Instance.ExecuteNonQuery("UPDATE NGUOI_DUNG SET Note = '"+note+"' WHERE TAI_KHOAN = '" + tk + "'");
            return data;
        }

        public DataTable getNote(string tk)
        {
            string query = "select note from nguoi_dung where tai_khoan = '"+tk+"'";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            return dataTable;
        }
        public DataTable TimNguoiDungTheoTaiKhoan(string keyword,int loaitk)
        {
            string query = "select * from nguoi_dung where tai_khoan like N'%" + keyword + "%' and loai_nguoi_dung = " +loaitk +"";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            return dataTable;
        }

        public DataTable TimNguoiDungTheoTen(string keyword, int loaitk)
        {
            string query = "select * from nguoi_dung where ho_ten like N'%" + keyword + "%' and loai_nguoi_dung = " + loaitk + "";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            return dataTable;
        }

        public DataTable TimNguoiDungTheoCHD(string keyword, int loaitk)
        {
            string query = "select * from nguoi_dung where cung_hoang_dao like N'%" + keyword + "%' and loai_nguoi_dung = " + loaitk + "";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            return dataTable;
        }

        public DataTable TimNguoiDungTheoNN(string keyword, int loaitk)
        {
            string query = "select * from nguoi_dung where nghe_nghiep like N'%" + keyword + "%' and loai_nguoi_dung = " + loaitk + "";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            return dataTable;
        }

        public DataTable TimNguoiDungTheoDDHenHo(string keyword, int loaitk)
        {
            string query = "select * from nguoi_dung where dd_henho like N'%" + keyword + "%' and loai_nguoi_dung = " + loaitk + "";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            return dataTable;
        }

        public bool DoiMatKhau(string tk,string mk)
        {
            int data = DataProvider.Instance.ExecuteNonQuery("UPDATE NGUOI_DUNG SET MAT_KHAU = '" + mk + "' WHERE TAI_KHOAN = '"+tk+"'");

            return data > 0;
        }
       
    }
}
