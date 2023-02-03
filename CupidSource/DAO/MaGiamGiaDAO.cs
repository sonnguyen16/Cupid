using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupid.DAO
{
    internal class MaGiamGiaDAO
    {
        private static MaGiamGiaDAO instance;

        internal static MaGiamGiaDAO Instance { 
            get { if (instance == null) 
                    instance = new MaGiamGiaDAO();
                return MaGiamGiaDAO.instance; } 
            set => MaGiamGiaDAO.instance = value; 
        }

        public DataTable getMaGiamGia()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM MA_GIAM_GIA");

            return table;
        }

        public DataTable getMaGiamGiaById(string id)
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM MA_GIAM_GIA WHERE MA_GG like N'%" + id + "%'");

            return table;
        }

        public bool ThemMaGiamGia(string MaGG, float Giam, DateTime NgayBd, DateTime NgayKt)
        {
            int data = 0;

            data = DataProvider.Instance.ExecuteNonQuery("Insert into MA_GIAM_GIA values( N'" + MaGG + "' , " + Giam + " , @Mnbd , @Mnkt ) ", new object[] { NgayBd, NgayKt });

            return data > 0;
        }

        public bool SuaMaGiamGia(string MaGG, float Giam, DateTime NgayBd, DateTime NgayKt)
        {
            int data = 0;

            data = DataProvider.Instance.ExecuteNonQuery("UPDATE MA_GIAM_GIA SET GIAM = " + Giam + " , NGAY_BDGG = @MNBD , NGAY_KTGG = @MNKT WHERE MA_GG = @MAGG ", new object[] { NgayBd, NgayKt, MaGG });

            return data > 0;
        }

        public bool XoaMaGiamGia(string MaGG)
        {
            int data = 0;

            data = DataProvider.Instance.ExecuteNonQuery("DELETE FROM MA_GIAM_GIA WHERE MA_GG = @MAGG ", new object[] { MaGG });

            return data > 0;
        }

        public bool KiemTraMaKM(string MaGG)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM MA_GIAM_GIA WHERE MA_GG = @MAGG ", new object[] { MaGG });

            return data.Rows.Count == 0;
        }

    }
}
