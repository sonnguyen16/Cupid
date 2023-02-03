using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cupid.DTO
{
    internal class XepHang
    {
        public byte[] Hinh_Anh;
        public string Tai_Khoan;
        public string So_Tien;

        public XepHang(DataRow row)
        {
            this.Hinh_Anh = (byte[])row["ANH_DAI_DIEN"];
            this.Tai_Khoan = row["TAI_KHOAN"].ToString();
            this.So_Tien = row["SO_TIEN"].ToString();
        }

        public XepHang(byte[] Hinh_Anh,string Tai_Khoan,string So_Tien)
        {
            this.Hinh_Anh = Hinh_Anh;
            this.Tai_Khoan = Tai_Khoan;
            this.So_Tien = So_Tien;
        }

    }
}
