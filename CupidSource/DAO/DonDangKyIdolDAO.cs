using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupid.DAO
{
    internal class DonDangKyIdolDAO
    {
        private static DonDangKyIdolDAO instance;

        internal static DonDangKyIdolDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonDangKyIdolDAO();
                return DonDangKyIdolDAO.instance;
            }
            private set { DonDangKyIdolDAO.instance = value; }
        }

        public DataTable getDon(bool tt)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM DON_DANG_KY WHERE TRANG_THAI = '" + tt + "' order by NGAY_GUI DESC");

            return dt;
        }

        public DataTable getDonById(string id,bool tt)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM DON_DANG_KY WHERE TRANG_THAI = '" + tt + "' AND TAI_KHOAN LIKE '%"+id+ "%' order by NGAY_GUI DESC");

            return dt;
        }

        public bool getSoDon()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM DON_DANG_KY WHERE TRANG_THAI = 'true' ");

            return data.Rows.Count > 0;
        }

        public int DaXem(string madon)
        {
            int data = 0;
            data = DataProvider.Instance.ExecuteNonQuery("UPDATE DON_DANG_KY SET TRANG_THAI = 'FALSE' WHERE MA_DON = '"+madon+"'");

            return data;
        }

        public int XoaDonDangKy(string madon)
        {
            int data = 0;

            data = DataProvider.Instance.ExecuteNonQuery("DELETE FROM DON_DANG_KY WHERE MA_DON = '"+madon+"'");
            return data;
        }

        public int XoaAllDonDangKy(string tk)
        {
            int data = 0;

            data = DataProvider.Instance.ExecuteNonQuery("DELETE FROM DON_DANG_KY WHERE MA_DON = '" + tk + "'");
            return data ;
        }

        public int PhanHoi(string tk)
        {
            int data = 0;
            data = DataProvider.Instance.ExecuteNonQuery("UPDATE NGUOI_DUNG SET LOAI_NGUOI_DUNG = 2 WHERE TAI_KHOAN = '"+tk+"'");
            return data ;
        }
    }
}
