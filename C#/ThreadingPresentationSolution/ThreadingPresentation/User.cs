using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ThreadingPresentation
{
    class User
    {

        
        #region Props
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        #endregion

        public User(string f, string l, string e)
        {
            FirstName = f;
            LastName = l;
            Email = e;
        }

        public void Register()
        {
            Thread.Sleep(2000);
            using(SqlConnection conn = new SqlConnection("Data Source=DESKTOP-F75OMCE\\SQLEXPRESS;Initial Catalog=MyUsers;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand query = new SqlCommand($"INSERT INTO userDetails(fname, lname, email) VALUES ('{FirstName}', '{LastName}', '{Email}')", conn);
                query.ExecuteNonQuery();
                conn.Close();
            }
            MessageBox.Show($"{FirstName} Registration Sucess!");
        }

        public void ValidateName()
        {
            if (FirstName.Equals("")) throw new Exception("No Empty Name");
            if (FirstName.Length > 50) throw new Exception("Max symbols 50!");
        }

        public void ValidateLName()
        {
            if (LastName.Equals("")) throw new Exception("No Empty Last Name!");
            if (LastName.Length > 50) throw new Exception("Max symbols 50!");
        }

        public void ValidateEmail()
        {
            Regex reg = new Regex("^[A-Za-z0-9]{3,20}@[A-Za-z]{3,10}.(com|co.in|co.au)$");
            if (!reg.IsMatch(Email)) throw new Exception("Wrong Email Format (something@gmail.com)");
        }

        public void DownloadContent()
        {
            Thread.Sleep(5000);
        }
    }
}
