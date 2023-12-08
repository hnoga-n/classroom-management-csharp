using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Hybrid.BUS;
using Hybrid.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hybrid.DAO
{
    public class FileBaiLamBaiTapDAO
    {
        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM filebailambaitap";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    FileBaiLamBaiTap tmp = new FileBaiLamBaiTap();
                    tmp.Mabailam = dr["mabailam"].ToString();
                    tmp.Path = dr["tenfile"].ToString();
                    tmp.Id_file = dr["id_file"].ToString();
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file fileblbtDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }
        public bool createFile(ArrayList listFileblbt)
        {
            try
            {
                string sql_getall = "INSERT INTO filebailambaitap(mabailam,tenfile,id_file) VALUES (@mabailam,@tenfile,@id_file)";
                SqlCommand command = new SqlCommand(sql_getall, Ketnoisqlserver.GetConnection());
                int index;
                foreach (FileBaiLamBaiTap fileblbt in listFileblbt)
                {
                    //  upload to drive
                    string tenfile = Path.GetFileName(fileblbt.Path);
                    //// Tạo yêu cầu tải lên tệp lên Google Drive và chỉ định thư mục đích bằng ID.
                    var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                    {
                        Name = tenfile,
                        Parents = new List<string> { "14ZVRdaPjYKQ9wJZn_EWrEsu0IpgIW00I" }
                    };

                    FilesResource.CreateMediaUpload request;
                    using (var stream = new FileStream(fileblbt.Path, FileMode.Open))
                    {
                        request = Chucnang.service.Files.Create(fileMetadata, stream, "application/octet-stream");
                        request.Upload();
                    }

                    var file = request.ResponseBody;
                    if (file != null) // upload thành công
                    {
                        // insert into database
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@mabailam", Guid.Parse(fileblbt.Mabailam));
                        command.Parameters.AddWithValue("@tenfile", tenfile);
                        command.Parameters.AddWithValue("@id_file", file.Id);
                        index = command.ExecuteNonQuery();
                        if (index <= 0) return false;
                    }
                    else
                    {
                        MessageBox.Show("Không thể tải lên tệp lên Google Drive.");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return true;
        }

        public bool DeleteFileBaiLamBaiTapByMaBaiLam(string mabailam)
        {
            try
            {
                string sql_delete = "DELETE FROM filebailambaitap WHERE mabailam=@mabailam";
                SqlCommand command = new SqlCommand(sql_delete, Ketnoisqlserver.GetConnection());
                command.Parameters.Add("@mabailam", SqlDbType.UniqueIdentifier).Value = Guid.Parse(mabailam);
                int index = command.ExecuteNonQuery();
                if (index > 0) return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file FileblbtDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return false;
        }

    }

}
