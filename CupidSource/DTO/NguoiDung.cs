using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Cupid.DTO
{
    internal class NguoiDung
    {
		private string TAI_KHOAN;
		private string MAT_KHAU;
		private int LOAI_NGUOI_DUNG;
		private byte[] ANH_DAI_DIEN;
		private string HO_TEN;
		private System.DateTime NGAY_SINH;
		private string GIOI_TINH;
		private string QUE_QUAN;
		private string NOI_O;
		private string DD_HENHO;
		private string NGHE_NGHIEP;
		private int CHIEU_CAO;
		private int CAN_NANG;
		private int VONG_1;
		private int VONG_2;
		private int VONG_3;
		private string CUNG_HOANG_DAO;
		private string SO_THICH;
		private bool TRANG_THAI_TK;

        public NguoiDung(string TAI_KHOAN,string MAT_KHAU, int LOAI_NGUOI_DUNG, byte[] ANH_DAI_DIEN, string HO_TEN, System.DateTime NGAY_SINH, string GIOI_TINH, string QUE_QUAN, string NOI_O,
		string DD_HENHO,string NGHE_NGHIEP, int CHIEU_CAO, int CAN_NANG, int VONG_1, int VONG_2, int VONG_3, string CUNG_HOANG_DAO, string SO_THICH, bool TRANG_THAI_TK)
        {
			this.TAI_KHOAN = TAI_KHOAN;
			this.MAT_KHAU = MAT_KHAU;
			this.LOAI_NGUOI_DUNG = LOAI_NGUOI_DUNG;
			this.HO_TEN = HO_TEN;
			this.GIOI_TINH = GIOI_TINH;
			this.ANH_DAI_DIEN = ANH_DAI_DIEN;
			this.NGAY_SINH = NGAY_SINH;
			this.NGHE_NGHIEP = NGHE_NGHIEP;
			this.NOI_O = NOI_O;
			this.QUE_QUAN = QUE_QUAN;
			this.SO_THICH = SO_THICH;
			this.DD_HENHO = DD_HENHO;
			this.CAN_NANG = CAN_NANG;
			this.CHIEU_CAO = CHIEU_CAO;
			this.VONG_1 = VONG_1;
			this.VONG_2 = VONG_2;
			this.VONG_3 = VONG_3;
			this.CUNG_HOANG_DAO	= CUNG_HOANG_DAO;
			this.TRANG_THAI_TK = TRANG_THAI_TK;
        }

		public NguoiDung(DataRow row)
        {
			this.TAI_KHOAN = row["TAI_KHOAN"].ToString();
			this.MAT_KHAU = row["MAT_KHAU"].ToString();
			this.LOAI_NGUOI_DUNG = (int)row["LOAI_NGUOI_DUNG"];
			this.HO_TEN = row["HO_TEN"].ToString();
			this.GIOI_TINH = row["GIOI_TINH"].ToString();
			this.ANH_DAI_DIEN = (byte[])row["ANH_DAI_DIEN"];
			this.NGAY_SINH = (DateTime)row["NGAY_SINH"];
			this.NGHE_NGHIEP = row["NGHE_NGHIEP"].ToString();
			this.NOI_O = row["NOI_O"].ToString();
			this.QUE_QUAN = row["QUE_QUAN"].ToString();
			this.SO_THICH = row["SO_THICH"].ToString();
			this.DD_HENHO = row["DD_HENHO"].ToString();
			this.CAN_NANG = (int)row["CAN_NANG"];
			this.CHIEU_CAO = (int)row["CHIEU_CAO"];
			this.VONG_1 = (int)row["VONG_1"];
			this.VONG_2 = (int)row["VONG_2"];
			this.VONG_3 = (int)row["VONG_3"];
			this.CUNG_HOANG_DAO = row["CUNG_HOANG_DAO"].ToString();
			this.TRANG_THAI_TK = (bool)row["TAI_KHOAN"];
		}

		

	}
}
