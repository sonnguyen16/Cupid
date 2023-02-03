using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupid.DAO
{
    internal class BangXepHangDAO
    {
        private static BangXepHangDAO instance;

        internal static BangXepHangDAO Instance { get { if(instance == null) instance = new BangXepHangDAO(); return BangXepHangDAO.instance; }  set => BangXepHangDAO.instance = value; }

        public DataTable getBXHHomNay(int index)
        {
            string query = "SELECT TOP 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE CONVERT(DATE,LSGD.NGAY_GIAO_DICH) = CONVERT(DATE,GETDATE()) AND LSGD.LOAI_GD = "+index+" AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        //public DataTable getBXHIdolTheoNgay()
        //{
        //    string query = "SELECT TOP 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE CONVERT(DATE,LSGD.NGAY_GIAO_DICH) = CONVERT(DATE,GETDATE()) AND LSGD.LOAI_GD = 1 AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

        //    return dt;
        //}

        //public DataTable getBXHNapTienTheoNgay()
        //{
        //    string query = "SELECT TOP 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE CONVERT(DATE,LSGD.NGAY_GIAO_DICH) = CONVERT(DATE,GETDATE()) AND LSGD.LOAI_GD = 2 AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

        //    return dt;
        //}

        public DataTable getBXHTheoNgay(int index, DateTime dt1,DateTime dt2)
        {
            string query = "SELECT top 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE  LSGD.NGAY_GIAO_DICH BETWEEN '"+dt1+"'AND '"+dt2+"' AND LSGD.LOAI_GD = "+index+" AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
        //public DataTable getBXHIdolTheoTuan()
        //{
        //    string query = "SELECT top 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE DATEDIFF(DAY, LSGD.NGAY_GIAO_DICH, GETDATE()) <= 7 AND LSGD.LOAI_GD = 1 AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

        //    return dt;
        //}

        //public DataTable getBXHNapTienTheoTuan()
        //{
        //    string query = "SELECT top 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE DATEDIFF(DAY, LSGD.NGAY_GIAO_DICH, GETDATE()) <= 7 AND LSGD.LOAI_GD = 2 AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

        //    return dt;
        //}

        //public DataTable getBXHNguoiThueTheoThang()
        //{
        //    string query = "SELECT top 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE DATEDIFF(DAY, LSGD.NGAY_GIAO_DICH, GETDATE()) <= 30 AND LSGD.LOAI_GD = 0 AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

        //    return dt;
        //}
        //public DataTable getBXHIdolTheoThang()
        //{
        //    string query = "SELECT top 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE DATEDIFF(DAY, LSGD.NGAY_GIAO_DICH, GETDATE()) <= 30 AND LSGD.LOAI_GD = 1 AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

        //    return dt;
        //}

        //public DataTable getBXHNapTienTheoThang()
        //{
        //    string query = "SELECT top 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE DATEDIFF(DAY, LSGD.NGAY_GIAO_DICH, GETDATE()) <= 30 AND LSGD.LOAI_GD = 2 AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

        //    return dt;
        //}

        //public DataTable getBXHNguoiThueTheoNam()
        //{
        //    string query = "SELECT top 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE DATEDIFF(DAY, LSGD.NGAY_GIAO_DICH, GETDATE()) <= 365 AND LSGD.LOAI_GD = 0 AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

        //    return dt;
        //}
        //public DataTable getBXHIdolTheoNam()
        //{
        //    string query = "SELECT top 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE DATEDIFF(DAY, LSGD.NGAY_GIAO_DICH, GETDATE()) <= 365 AND LSGD.LOAI_GD = 1 AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

        //    return dt;
        //}

        //public DataTable getBXHNapTienTheoNam()
        //{
        //    string query = "SELECT top 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE DATEDIFF(DAY, LSGD.NGAY_GIAO_DICH, GETDATE()) <= 365 AND LSGD.LOAI_GD = 2 AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

        //    return dt;
        //}

        //public DataTable getBXHNguoiThue()
        //{
        //    string query = "SELECT top 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE LSGD.LOAI_GD = 0 AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

        //    return dt;
        //}
        //public DataTable getBXHIdol()
        //{
        //    string query = "SELECT top 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE LSGD.LOAI_GD = 1 AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

        //    return dt;
        //}

        //public DataTable getBXHNapTien()
        //{
        //    string query = "SELECT top 10 ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN, FORMAT(SUM(SO_TIEN),'C') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD,NGUOI_DUNG ND WHERE LSGD.LOAI_GD = 2 AND LSGD.TAI_KHOAN = ND.TAI_KHOAN AND LSGD.TRANG_THAI = 1 GROUP BY ND.ANH_DAI_DIEN, LSGD.TAI_KHOAN ORDER BY SUM(SO_TIEN) DESC";

        //    DataTable dt = DataProvider.Instance.ExecuteQuery(query);

        //    return dt;
        //}
    }
}
