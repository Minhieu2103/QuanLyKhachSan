using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nhom12_.ClassLogin
{
    public class ClDangKy
    {
        private Modify modify = new Modify();

        public bool CheckAccount(string account)
        {
            return Regex.IsMatch(account, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool CheckEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        public bool IsEmailRegistered(string email)
        {
            return modify.TaiKhoans("Select * from TaiKhoan where Email= '" + email + "'").Count != 0;
        }

        public bool RegisterAccount(string username, string password, string email)
        {
            try
            {
                string query = "Insert into TaiKhoan values ('" + username + "','" + password + "','" + email + "')";
                modify.Command(query);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
