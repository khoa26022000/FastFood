using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAL.QLFOODTableAdapters;


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
        //public int GetDataBill(int id)
        //{
        //    DataTable data = daBill.GetDataByIdTable(id);
        //    if (data.Rows.Count > 0)
        //    {
        //        Bill bill = new Bill(data.Rows[0]);
        //        return bill.ID;
        //    }
        //    return -1;
        //}
    }

}
