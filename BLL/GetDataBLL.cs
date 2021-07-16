using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data;
namespace BLL
{
    public class GetDataBLL
    {
        ConnectDAL connect = new ConnectDAL();
        public DataTable GetAccount()
        {
            return connect.GetDataAccount();
        }
    }
}
