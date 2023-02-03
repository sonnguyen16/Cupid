using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupid.DAO
{
    internal class LichSuGiaoDichDAO
    {
        private static LichSuGiaoDichDAO instance;

        internal static LichSuGiaoDichDAO Instance { get { if (instance == null) instance = new LichSuGiaoDichDAO(); return LichSuGiaoDichDAO.instance; } set => LichSuGiaoDichDAO.instance = value; }

        public DataTable getLichSuGiaoDich(DateTime ngayBatDau,DateTime ngayKetThuc, int loaiGiaoDich, bool trangThai)
        {
            string query = "SELECT LSGD1.TAI_KHOAN AS NGUOI_THUE, LSGD2.TAI_KHOAN AS IDOL, LSGD1.NGAY_GIAO_DICH, FORMAT(LSGD1.SO_TIEN,'#,##') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD1, LICH_SU_GIAO_DICH LSGD2 WHERE LSGD1.MA_GIAO_DICH = LSGD2.MA_GIAO_DICH AND LSGD1.LOAI_GD <> LSGD2.LOAI_GD AND LSGD1.LOAI_GD = " + loaiGiaoDich+ " AND CONVERT(DATE,LSGD1.NGAY_GIAO_DICH) BETWEEN '" + ngayBatDau+"' AND '"+ngayKetThuc+"' AND LSGD1.TRANG_THAI = '"+trangThai+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public bool insertGiaoDich(string magd, string tk,float sotien,int loaigd)
        {
            int data = 0;
            string query = "INSERT INTO LICH_SU_GIAO_DICH VALUES('"+magd+"','"+tk+"',"+sotien+","+loaigd+",'"+DateTime.Now+"','true')";
            data = DataProvider.Instance.ExecuteNonQuery(query);
            return data > 0;
        }
        public DataTable getLichSuGiaoDich2(DateTime ngayBatDau, DateTime ngayKetThuc, int loaiGiaoDich, bool trangThai)
        {
            string query = "SELECT LSGD1.TAI_KHOAN AS IDOL, LSGD2.TAI_KHOAN AS NGUOI_THUE, LSGD1.NGAY_GIAO_DICH, FORMAT(LSGD1.SO_TIEN,'#,##') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD1, LICH_SU_GIAO_DICH LSGD2 WHERE LSGD1.MA_GIAO_DICH = LSGD2.MA_GIAO_DICH AND LSGD1.LOAI_GD <> LSGD2.LOAI_GD AND LSGD1.LOAI_GD = " + loaiGiaoDich + " AND CONVERT(DATE,LSGD1.NGAY_GIAO_DICH) BETWEEN '" + ngayBatDau + "' AND '" + ngayKetThuc + "' AND LSGD1.TRANG_THAI = '" + trangThai + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable getLichSuNap(DateTime ngayBatDau, DateTime ngayKetThuc,bool trang_thai)
        {
            string query = "SELECT LSGD1.TAI_KHOAN AS NGUOI_NAP, LSGD1.NGAY_GIAO_DICH, FORMAT(LSGD1.SO_TIEN,'#,##') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD1 WHERE LSGD1.LOAI_GD = 2 AND CONVERT(DATE, LSGD1.NGAY_GIAO_DICH) BETWEEN '" + ngayBatDau+"' AND '"+ngayKetThuc+"' AND LSGD1.TRANG_THAI = '"+trang_thai+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable getLichSuThueById(DateTime ngayBatDau, DateTime ngayKetThuc,  bool trangThai,string tk)
        {
            string query = "SELECT LSGD1.TAI_KHOAN AS NGUOI_THUE, LSGD2.TAI_KHOAN AS IDOL, LSGD1.NGAY_GIAO_DICH, FORMAT(LSGD1.SO_TIEN,'#,##') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD1, LICH_SU_GIAO_DICH LSGD2 WHERE LSGD1.MA_GIAO_DICH = LSGD2.MA_GIAO_DICH AND LSGD1.LOAI_GD <> LSGD2.LOAI_GD AND LSGD1.LOAI_GD = 0 AND CONVERT(DATE,LSGD1.NGAY_GIAO_DICH) BETWEEN '" + ngayBatDau + "' AND '" + ngayKetThuc + "' AND LSGD1.TRANG_THAI = '" + trangThai + "' AND LSGD1.TAI_KHOAN like '%"+tk+"%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable getLichSuIdolById(DateTime ngayBatDau, DateTime ngayKetThuc, bool trangThai, string tk)
        {
            string query = "SELECT LSGD1.TAI_KHOAN AS IDOL, LSGD2.TAI_KHOAN AS NGUOI_THUE, LSGD1.NGAY_GIAO_DICH, FORMAT(LSGD1.SO_TIEN,'#,##') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD1, LICH_SU_GIAO_DICH LSGD2 WHERE LSGD1.MA_GIAO_DICH = LSGD2.MA_GIAO_DICH AND LSGD1.LOAI_GD <> LSGD2.LOAI_GD AND LSGD1.LOAI_GD = 1 AND CONVERT(DATE,LSGD1.NGAY_GIAO_DICH) BETWEEN '" + ngayBatDau + "' AND '" + ngayKetThuc + "' AND LSGD1.TRANG_THAI = '" + trangThai + "' AND LSGD1.TAI_KHOAN like '%" + tk + "%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
        public DataTable getLichSuNapById(DateTime ngayBatDau, DateTime ngayKetThuc, bool trang_thai, string tk)
        {
            string query = "SELECT LSGD1.TAI_KHOAN AS NGUOI_NAP, LSGD1.NGAY_GIAO_DICH, FORMAT(LSGD1.SO_TIEN,'#,##') AS SO_TIEN FROM LICH_SU_GIAO_DICH LSGD1 WHERE LSGD1.LOAI_GD = 2 AND CONVERT(DATE, LSGD1.NGAY_GIAO_DICH) BETWEEN '" + ngayBatDau + "' AND '" + ngayKetThuc + "' AND LSGD1.TRANG_THAI = '" + trang_thai + "' AND LSGD1.TAI_KHOAN like '%" + tk + "%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable getComboBox()
        {
            string query = "SELECT DISTINCT MONTH(NGAY_GIAO_DICH), YEAR(NGAY_GIAO_DICH) FROM LICH_SU_GIAO_DICH LSGD ORDER BY  YEAR(NGAY_GIAO_DICH) DESC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable getComboBox2()
        {
            string query = "SELECT DISTINCT YEAR(NGAY_GIAO_DICH) FROM LICH_SU_GIAO_DICH LSGD ORDER BY  YEAR(NGAY_GIAO_DICH) DESC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
        public DataTable ThongKe(string thang, string nam, int loaigd)
        {
            string query = "SELECT DAY(NGAY_GIAO_DICH) DAY, FORMAT(SUM(SO_TIEN),'#,##') TOTAL FROM LICH_SU_GIAO_DICH LSGD WHERE MONTH(NGAY_GIAO_DICH) = '"+thang+"' AND YEAR(NGAY_GIAO_DICH) = '"+nam+"' AND LOAI_GD = "+loaigd+" GROUP BY DAY(NGAY_GIAO_DICH)";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable ThongKe2(string nam, int loaigd)
        {
            string query = "SELECT MONTH(NGAY_GIAO_DICH) MONTH, FORMAT(SUM(SO_TIEN),'#,##') TOTAL FROM LICH_SU_GIAO_DICH LSGD WHERE  YEAR(NGAY_GIAO_DICH) = '"+nam+"' AND LOAI_GD = "+loaigd+" GROUP BY MONTH(NGAY_GIAO_DICH)";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable ThongKe3(int loaigd)
        {
            string query = "SELECT YEAR(NGAY_GIAO_DICH) YEAR, FORMAT(SUM(SO_TIEN),'#,##') TOTAL FROM LICH_SU_GIAO_DICH LSGD WHERE LOAI_GD = " + loaigd + " GROUP BY YEAR(NGAY_GIAO_DICH)";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable ThongKeUser(string tk)
        {
            string query = "SELECT TAI_KHOAN, SUM(SO_TIEN) AS TOTAL FROM LICH_SU_GIAO_DICH WHERE TAI_KHOAN = '" + tk + "' AND LOAI_GD = 0 GROUP BY TAI_KHOAN ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable ThongKeUser1(string tk)
        {
            string query = "SELECT TAI_KHOAN, SUM(SO_TIEN) AS TOTAL FROM LICH_SU_GIAO_DICH WHERE TAI_KHOAN = '" + tk + "' AND LOAI_GD = 2 GROUP BY TAI_KHOAN ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
        public DataTable ThongKeUser2(string tk)
        {
            string query = "SELECT TAI_KHOAN, SUM(SO_TIEN) AS TOTAL FROM LICH_SU_GIAO_DICH WHERE TAI_KHOAN = '" + tk + "' AND LOAI_GD = 1 GROUP BY TAI_KHOAN ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
    }
}
