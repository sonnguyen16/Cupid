using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;
using System.Configuration;


namespace Cupid.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance; // Ctrl + R + E

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string connectionSTR = Properties.Settings.Default.CupidOnline;

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
               
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);

                    connection.Close();
            }

            return data;
        }

        public DataTable GetCurrentRecords(int page, int loaitk)
        {
            SqlConnection con = new SqlConnection(connectionSTR);
            DataTable dt = new DataTable();
            SqlCommand cmd;
            if (page == 1)
            {
                 cmd = new SqlCommand("Select TOP " + 20 +
                " * from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = "+loaitk+" ORDER BY TAI_KHOAN", con);
            }
            else
            {
                int PreviousPageOffSet = (page - 1) * 20;

                 cmd = new SqlCommand("Select TOP "+ 20 + " * from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND TAI_KHOAN NOT IN (Select TOP " + PreviousPageOffSet + " TAI_KHOAN from NGUOI_DUNG  WHERE LOAI_NGUOI_DUNG = " + loaitk + " ORDER BY TAI_KHOAN) ", con);
            }
            try
            {
                
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable GetCurrentRecords2(int page, int loaitk,int index,string keyword)
        {
            SqlConnection con = new SqlConnection(connectionSTR);
            DataTable dt = new DataTable();
            SqlCommand cmd = null;
            if (page < 0)
            {
                if (index == 0)
                {
                    cmd = new SqlCommand("Select * " +
               "  from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND TAI_KHOAN like '%" + keyword + "%' ORDER BY TAI_KHOAN", con);
                }
                else if (index == 1)
                {
                    cmd = new SqlCommand("Select * " +
               "  from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND HO_TEN like '%" + keyword + "%' ORDER BY TAI_KHOAN", con);
                }
                else if (index == 2)
                {
                    cmd = new SqlCommand("Select * " +
          " from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND DD_HENHO like '%" + keyword + "%' ORDER BY TAI_KHOAN", con);
                }
                else if (index == 3)
                {
                    cmd = new SqlCommand("Select * " +
          " from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND NGHE_NGHIEP like '%" + keyword + "%' ORDER BY TAI_KHOAN", con);
                }
                else
                {
                    cmd = new SqlCommand("Select * " +
          " from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND CUNG_HOANG_DAO like '%" + keyword + "%' ORDER BY TAI_KHOAN", con);
                }
            }
            else
            {
                if (page == 1)
                {
                    if (index == 0)
                    {
                        cmd = new SqlCommand("Select TOP " + 20 +
                   " * from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND TAI_KHOAN like '%" + keyword + "%' ORDER BY TAI_KHOAN", con);
                    }
                    else if (index == 1)
                    {
                        cmd = new SqlCommand("Select TOP " + 20 +
                   " * from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND HO_TEN like '%" + keyword + "%' ORDER BY TAI_KHOAN", con);
                    }
                    else if (index == 2)
                    {
                        cmd = new SqlCommand("Select TOP " + 20 +
              " * from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND DD_HENHO like '%" + keyword + "%' ORDER BY TAI_KHOAN", con);
                    }
                    else if (index == 3)
                    {
                        cmd = new SqlCommand("Select TOP " + 20 +
              " * from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND NGHE_NGHIEP like '%" + keyword + "%' ORDER BY TAI_KHOAN", con);
                    }
                    else
                    {
                        cmd = new SqlCommand("Select TOP " + 20 +
              " * from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND CUNG_HOANG_DAO like '%" + keyword + "%' ORDER BY TAI_KHOAN", con);
                    }

                }
                else
                {
                    int PreviousPageOffSet = (page - 1) * 20;
                    if (index == 0)
                    {
                        cmd = new SqlCommand("Select TOP " + 20 + " * from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND TAI_KHOAN like '%" + keyword + "%' AND TAI_KHOAN NOT IN (Select TOP " + PreviousPageOffSet + " TAI_KHOAN from NGUOI_DUNG  WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND TAI_KHOAN like '%" + keyword + "%' ORDER BY TAI_KHOAN) ", con);

                    }
                    else if (index == 1)
                    {
                        cmd = new SqlCommand("Select TOP " + 20 + " * from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND HO_TEN like '%" + keyword + "%' AND TAI_KHOAN NOT IN (Select TOP " + PreviousPageOffSet + " TAI_KHOAN from NGUOI_DUNG  WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND HO_TEN like '%" + keyword + "%' ORDER BY TAI_KHOAN) ", con);

                    }
                    else if (index == 2)
                    {
                        cmd = new SqlCommand("Select TOP " + 20 + " * from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND DD_HENHO like '%" + keyword + "%' AND TAI_KHOAN NOT IN (Select TOP " + PreviousPageOffSet + " TAI_KHOAN from NGUOI_DUNG  WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND DD_HENHO like '%" + keyword + "%' ORDER BY TAI_KHOAN) ", con);

                    }
                    else if (index == 3)
                    {
                        cmd = new SqlCommand("Select TOP " + 20 + " * from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND NGHE_NGHEP like '%" + keyword + "%' AND TAI_KHOAN NOT IN (Select TOP " + PreviousPageOffSet + " TAI_KHOAN from NGUOI_DUNG  WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND NGHE_NGHIEP like '%" + keyword + "%' ORDER BY TAI_KHOAN) ", con);

                    }
                    else
                    {
                        cmd = new SqlCommand("Select TOP " + 20 + " * from NGUOI_DUNG WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND CUNG_HOANG_DAO like '%" + keyword + "%' AND TAI_KHOAN NOT IN (Select TOP " + PreviousPageOffSet + " TAI_KHOAN from NGUOI_DUNG  WHERE LOAI_NGUOI_DUNG = " + loaitk + " AND CUNG_HOANG_DAO like '%" + keyword + "%' ORDER BY TAI_KHOAN) ", con);

                    }

                }
            }
           
            try
            {

                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public int CountResult(int index,int loaitk,string keyword)
        {
            object data = 0;
            SqlConnection con = new SqlConnection(connectionSTR);
            SqlCommand cmd = null;
            if (index == 0)
            {
                cmd = new SqlCommand("SELECT COUNT (*) FROM NGUOI_DUNG WHERE TAI_KHOAN LIKE '%"+keyword+"%' AND LOAI_NGUOI_DUNG = "+loaitk+"",con);
            }
            else if (index == 1)
            {
                cmd = new SqlCommand("SELECT COUNT (*) FROM NGUOI_DUNG WHERE HO_TEN LIKE '%" + keyword + "%' AND LOAI_NGUOI_DUNG = " + loaitk + "", con);

            }
            else if (index == 2)
            {
                cmd = new SqlCommand("SELECT COUNT (*) FROM NGUOI_DUNG WHERE DD_HENHO LIKE '%" + keyword + "%' AND LOAI_NGUOI_DUNG = " + loaitk + "", con);

            }
            else if (index == 3)
            {
                cmd = new SqlCommand("SELECT COUNT (*) FROM NGUOI_DUNG WHERE NGHE_NGHIEP LIKE '%" + keyword + "%' AND LOAI_NGUOI_DUNG = " + loaitk + "", con);

            }
            else
            {
                cmd = new SqlCommand("SELECT COUNT (*) FROM NGUOI_DUNG WHERE CUNG_HOANG_DAO LIKE '%" + keyword + "%' AND LOAI_NGUOI_DUNG = " + loaitk + "", con);

            }

            try
            {

                con.Open();
                data = cmd.ExecuteScalar();
            }
            finally
            {
                con.Close();
            }

            return (int)data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@H") || item.Contains("@h") || item.Contains("@M"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }

        public byte[] ImageToByte2(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

    }
}
