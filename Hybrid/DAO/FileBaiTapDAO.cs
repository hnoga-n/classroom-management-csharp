using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Hybrid.BUS;
using Hybrid.DTO;
using ServiceStack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Hybrid.DAO
{
    public class FileBaiTapDAO
    {
        //private DriveService service;
        public FileBaiTapDAO()
        {
            //UserCredential credential;
            //using (var stream = new FileStream(@"..\..\bin\Debug\ggdrivelink.json", FileMode.Open, FileAccess.Read))
            //{
            //    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
            //        GoogleClientSecrets.Load(stream).Secrets,
            //        new[] { DriveService.Scope.Drive },
            //        "user",
            //        CancellationToken.None,
            //        new FileDataStore("token.json", true)).Result;
            //}

            //// Tạo dịch vụ Google Drive
            //service = new DriveService(new BaseClientService.Initializer()
            //{
            //    HttpClientInitializer = credential,
            //    ApplicationName = "hybrid"
            //});
        }

        public ArrayList loadList()
        {
            ArrayList listTmp = new ArrayList();
            try
            {

                string sql_get_all = "SELECT * FROM filebaitap";
                SqlCommand cmd = new SqlCommand(sql_get_all, Ketnoisqlserver.GetConnection());

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    FileBaiTap tmp = new FileBaiTap();
                    tmp.Mabaitap = dr["mabaitap"].ToString();
                    tmp.Path = dr["tenfile"].ToString();
                    tmp.Id_file = dr["id_file"].ToString();
                    tmp.Lafiledapan = Convert.ToInt32(dr["lafiledapan"].ToString());
                    listTmp.Add(tmp);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file FilebtDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return listTmp;
        }

        public bool createFile(ArrayList listFilebt)
        {
            try
            {
                string sql_getall = "INSERT INTO filebaitap(mabaitap,lafiledapan,tenfile,id_file) VALUES (@mabaitap,@lafiledapan,@tenfile,@id_file)";
                SqlCommand command = new SqlCommand(sql_getall, Ketnoisqlserver.GetConnection());
                int index;
                foreach (FileBaiTap fileBt in listFilebt)
                {
                    //  upload to drive
                    string tenfile = Path.GetFileName(fileBt.Path);
                    //// Tạo yêu cầu tải lên tệp lên Google Drive và chỉ định thư mục đích bằng ID.
                    var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                    {
                        Name = tenfile,
                        Parents = new List<string> { "1wuHPlPBbdi_vVY7q5KkthgMbe1m0K0Ku" }
                    };

                    FilesResource.CreateMediaUpload request;
                    using (var stream = new FileStream(fileBt.Path, FileMode.Open))
                    {
                        request = Chucnang.service.Files.Create(fileMetadata, stream, "application/octet-stream");
                        request.Upload();
                    }

                    var file = request.ResponseBody;
                    if (file != null) // upload thành công
                    {
                        // insert into database
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@mabaitap", Guid.Parse(fileBt.Mabaitap));
                        command.Parameters.AddWithValue("@lafiledapan", Convert.ToInt16(fileBt.Lafiledapan));
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
                MessageBox.Show("Lỗi xảy ra ở file FilebtDAO:" + ex.Message);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return true;
        }
        public bool EditFile(ArrayList listFilebt)
        {
            try
            {
                string sql_getall = "INSERT INTO filebaitap(mabaitap,lafiledapan,tenfile,id_file) VALUES (@mabaitap,@lafiledapan,@tenfile,@id_file)";
                SqlCommand command = new SqlCommand(sql_getall, Ketnoisqlserver.GetConnection());
                int index;
                foreach (FileBaiTap fileBt in listFilebt)
                {
                    if (fileBt.Id_file == string.Empty)
                    {
                        //  upload to drive
                        string tenfile = Path.GetFileName(fileBt.Path);
                        //// Tạo yêu cầu tải lên tệp lên Google Drive và chỉ định thư mục đích bằng ID.
                        var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                        {
                            Name = tenfile,
                            Parents = new List<string> { "1wuHPlPBbdi_vVY7q5KkthgMbe1m0K0Ku" }
                        };

                        FilesResource.CreateMediaUpload request;
                        using (var stream = new FileStream(fileBt.Path, FileMode.Open))
                        {
                            request = Chucnang.service.Files.Create(fileMetadata, stream, "application/octet-stream");
                            request.Upload();
                        }

                        var file = request.ResponseBody;
                        if (file != null) // upload thành công
                        {
                            // insert into database
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@mabaitap", Guid.Parse(fileBt.Mabaitap));
                            command.Parameters.AddWithValue("@lafiledapan", Convert.ToInt16(fileBt.Lafiledapan));
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
                    else
                    {
                        // insert into database
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@mabaitap", Guid.Parse(fileBt.Mabaitap));
                        command.Parameters.AddWithValue("@lafiledapan", Convert.ToInt16(fileBt.Lafiledapan));
                        command.Parameters.AddWithValue("@tenfile", Path.GetFileName(fileBt.Path));
                        command.Parameters.AddWithValue("@id_file", fileBt.Id_file);
                        index = command.ExecuteNonQuery();
                        if (index <= 0) return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file FilebtDAO:" + ex.Message);
                Console.WriteLine(ex);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return true;
        }
        public bool DeleteFileBaiTapByMaBaiTap(string mabaitap)
        {
            try
            {
                string sql_delete = "DELETE FROM filebaitap WHERE mabaitap=@mabaitap";
                SqlCommand command = new SqlCommand(sql_delete, Ketnoisqlserver.GetConnection());
                command.Parameters.Add("@mabaitap", SqlDbType.UniqueIdentifier).Value = Guid.Parse(mabaitap);
                int index = command.ExecuteNonQuery();
                if (index > 0) return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra ở file FilebtDAO:" + ex.Message);
                Console.WriteLine(ex);
            }
            finally
            {
                Ketnoisqlserver.CloseConnection();
            }
            return false;
        }
    }

}
