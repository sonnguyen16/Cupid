using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupid.DAO
{
    internal class LichSuHoatDongDAO
    {
        private static LichSuHoatDongDAO instance;

        internal static LichSuHoatDongDAO Instance { get { if (instance == null) instance = new LichSuHoatDongDAO(); return LichSuHoatDongDAO.instance; } set => LichSuHoatDongDAO.instance = value; }


        public DataTable getLSHD(int index,string keyword)
        {
            string query = "SELECT TAI_KHOAN,CHI_TIET, NGAY_THAO_TAC, CASE THAO_TAC WHEN 0 THEN N'Tạo tài khoản' " +
                "WHEN 1 THEN N'Sửa tài khoản' " +
                "WHEN 2 THEN N'Xóa tài khoản' " +
                "WHEN 3 THEN N'Nạp tiền' " +
                "WHEN 4 THEN N'Duyệt đơn idol' " +
                "ELSE N'Khóa tài khoản' END AS THAO_TAC "  +
                "FROM LICH_SU_HOAT_DONG " +
                "WHERE CONVERT(DATE,NGAY_THAO_TAC) = CONVERT(DATE,GETDATE()) ";
            if (index > 0)
            {
                if (keyword != "")
                {
                    query += "AND THAO_TAC = "+index+" AND TAI_KHOAN like '%"+keyword+"%' ORDER BY NGAY_THAO_TAC DESC";
                }
                else
                {
                    query += "AND THAO_TAC = " + index + " ORDER BY NGAY_THAO_TAC DESC";

                }
            }
            else
            {
                query += "ORDER BY NGAY_THAO_TAC DESC";

            }
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable getLSHD2(int index, string keyword,DateTime dts, DateTime dte)
        {
            string query = "SELECT TAI_KHOAN,CHI_TIET, NGAY_THAO_TAC, CASE THAO_TAC WHEN 0 THEN N'Tạo tài khoản' " +
                "WHEN 1 THEN N'Sửa tài khoản' " +
                "When 2 THEN N'Xóa tài khoản' " +
                "WHEN 3 THEN N'Nạp tiền' " +
                "WHEN 4 THEN N'Duyệt đơn idol' " +
                "ELSE N'Khóa tài khoản' END AS THAO_TAC " +
                "FROM LICH_SU_HOAT_DONG " +
                "WHERE NGAY_THAO_TAC BETWEEN '" + dts + "' AND '" + dte + "' ";
            if (index > 0)
            {
                if (keyword != "")
                {
                    query += "AND THAO_TAC = " + index + " AND TAI_KHOAN like '%" + keyword + "%' ORDER BY NGAY_THAO_TAC DESC";
                }
                else
                {
                    query += "AND THAO_TAC = " + index + " ORDER BY NGAY_THAO_TAC DESC";

                }
            }
            else
            {
                if (keyword != "")
                {
                    query += "AND TAI_KHOAN like '%" + keyword + "%' ORDER BY NGAY_THAO_TAC DESC";
                }
                else
                {
                    query += "ORDER BY NGAY_THAO_TAC DESC";

                }
            }
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
        public bool insertLSHD(string tk, int index, string chitiet)
        {
            int data = 0;
            string query = "INSERT INTO LICH_SU_HOAT_DONG VALUES('" + tk + "'," + index + ",N'" + chitiet + "','" + DateTime.Now + "')";
            data = DataProvider.Instance.ExecuteNonQuery(query);

            return data > 0;
        }

    }
}
