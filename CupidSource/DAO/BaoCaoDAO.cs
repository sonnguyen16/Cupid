using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupid.DAO
{
    internal class BaoCaoDAO
    {
        private static BaoCaoDAO instance;

        internal static BaoCaoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoDAO();
                return BaoCaoDAO.instance;
            }
            private set { BaoCaoDAO.instance = value; }
        }

        public DataTable getDon(bool tt)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM BAO_CAO WHERE TRANG_THAI = '" + tt + "' order by NGAY_GUI DESC");

            return dt;
        }

        public DataTable getDonById(string id, bool tt)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SELECT * FROM BAO_CAO WHERE TRANG_THAI = '" + tt + "' AND TK_BAO_CAO LIKE '%" + id + "%' OR TK_BI_BAO_CAO LIKE '%" + id + "%' order by NGAY_GUI DESC");

            return dt;
        }

        public bool getSoDon()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BAO_CAO WHERE TRANG_THAI = 'true' ");

            return data.Rows.Count > 0;
        }

        public int DaXem(string madon)
        {
            int data = 0;
            data = DataProvider.Instance.ExecuteNonQuery("UPDATE BAO_CAO SET TRANG_THAI = 'FALSE' WHERE MA_BAO_CAO = '" + madon + "'");

            return data;
        }

        public int XoaBaoCao(string madon)
        {
            int data = 0;

            data = DataProvider.Instance.ExecuteNonQuery("DELETE FROM BAO_CAO WHERE MA_BAO_CAO = '" + madon + "'");
            return data;
        }
    }
}
