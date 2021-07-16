using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.QLFOODTableAdapters;
using System.Linq;

namespace DAL
{
    public class ConnectDAL
    {
        TableFoodTableAdapter daTableFood = new TableFoodTableAdapter();
        BillTableAdapter daBill = new BillTableAdapter();
        BillInfoTableAdapter daBillInfo = new BillInfoTableAdapter();
        FoodTableAdapter daFood = new FoodTableAdapter();
        FoodCategoryTableAdapter daFoodCategory = new FoodCategoryTableAdapter();
        AccountTableAdapter daAccount = new AccountTableAdapter();


        public DataTable GetDataAccount() {
            return daAccount.GetData();
        }
    }

}
