using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Account
    {
        public Account(string username, string displayname,  string password = null)
        {
            this.UserName = username;
            this.DisplayName = displayname;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["DisplayName"].ToString(); ;
            this.Password = row["Password"].ToString(); ;
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private int type;

       private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
