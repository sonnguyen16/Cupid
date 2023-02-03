using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupid.DAO
{
    internal class KhuyenMaiDAO
    {
        private static KhuyenMaiDAO instance;

        internal static KhuyenMaiDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhuyenMaiDAO();
                }
                return KhuyenMaiDAO.instance;
            } set => KhuyenMaiDAO.instance = value;
        }

        public DataTable getKhuyenMai()
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM KHUYEN_MAI");

            return table;
        }

        public DataTable getKhuyenMaiById(string id)
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM KHUYEN_MAI WHERE MA_KM like N'%"+id+"%'");

            return table;
        }
        public bool ThemKhuyenMai(string MaKm, string NoiDung,DateTime NgayBd,DateTime NgayKt)
        {
            int data = 0;

            data = DataProvider.Instance.ExecuteNonQuery("Insert into KHUYEN_MAI values( N'"+MaKm+"' , N'"+NoiDung+"' , @Mnbd , @Mnkt ) ", new object[] { NgayBd, NgayKt });

            return data > 0;
        }

        public bool SuaKhuyenMai(string MaKm, string NoiDung, DateTime NgayBd, DateTime NgayKt)
        {
            int data = 0;

            data = DataProvider.Instance.ExecuteNonQuery("UPDATE KHUYEN_MAI SET ND_KHUYEN_MAI = N'" + NoiDung + "' , NGAY_BD = @MNBD , NGAY_KT = @MNKT WHERE MA_KM = @MAKM ", new object[] { NgayBd, NgayKt , MaKm});

            return data > 0;
        }

        public bool XoaKhuyenMai(string MaKm)
        {
            int data = 0;

            data = DataProvider.Instance.ExecuteNonQuery("DELETE FROM KHUYEN_MAI WHERE MA_KM = @MAKM ", new object[] { MaKm });

            return data > 0;
        }

        public bool KiemTraMaKM(string MaKM)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM KHUYEN_MAI WHERE MA_KM = @MAKM ", new object[] { MaKM });

            return data.Rows.Count == 0;
        }
    }
}
