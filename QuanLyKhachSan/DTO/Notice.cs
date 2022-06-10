using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    public class Notice
    {
        private int id;
        private string username;
        private string subject;
        private string content;
        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Content { get => content; set => content = value; }


        public Notice(string username, string subject, string content)
        {
            this.Username = username;
            this.Subject = subject;
            this.Content = content;
        }

        public Notice(DataRow row)
        {
            this.Id = (int)row["MaThongBao"];
            this.Username = (string)row["TenDangNhap"].ToString();
            this.Subject = (string)row["TieuDe"].ToString();
            this.Content = (string)row["NoiDung"].ToString();
        }
    }
}
