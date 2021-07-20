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
        DataTable1TableAdapter dataBilladap = new DataTable1TableAdapter();
        //food
        public DataTable GetDataFood()
        {
            return daFood.GetData();
        }
        public DataTable GetDataSearchFood(string name)
        {
            return daFood.GetDataBy3(name);
        }
        public void InsertFood(string name, int idType, double price)
        {
            daFood.InsertFoodQuery(name, idType, price);
        }
        public void DeleteFood(int id, string name, int idType, double price)
        {
            daFood.DeleteFoodQuery(id, null, name,idType,null,price);
        }
        public void UpdateFood(int id, string name, int idType, double price)
        {
            daFood.UpdateQuery( name, idType, price,id,id);
        }
        //type
        public DataTable GetDataFoodType()
        {
            return daFoodCategory.GetData();
        }
        public void InsertType(string name)
        {
            daFoodCategory.FoodTypeInsert(name);
        }
        public void UpdateType(int id,string name)
        {
            daFoodCategory.UpdateQuery(name,id,id);
        }
        public void DeleteType(int id,string name)
        {
            daFoodCategory.DeleteQuery(id,null,name);
        }
      
        //table
        public DataTable GetDataTableFood()
        {
            return daTableFood.GetData();
        }
        public void InsertTable(string name, string status)
        {
            daTableFood.InsertQuery(name, status);
        }
        public void DeleteTable(int id ,string name, string status)
        {
            daTableFood.DeleteTableQuery(id,null,name,null, status);
        }
        public void UpdateTable(int id, string name, string status)
        {
            daTableFood.UpdateTableQuery(name,status, id, id);
        }
        //Acount
        public DataTable GetDataAccount()
        {
            return daAccount.GetDataBy1();
        }
        public void UpdateDisplayName(string id,string DisplayName,string name, int type)
        {
            daAccount.UpdateAccountDisNameQuery(DisplayName,name,type,id, id);
        }
        public void InsertDisplayName(string id, string DisplayName, string name, int type,string pass)
        {
            daAccount.InsertAccountQuery(id,DisplayName, name,pass, type );
        }
        public void DeletedisplayName(string id)
        {
            daAccount.DeleteQuery(id);
        }
        public void updatePass(string id,string pass)
        {
            daAccount.UpdatePassQuery(pass,id,id);
        }
        public DataTable GetLogin(string userName, string passWord)
        {
            return daAccount.GetDataDangNhap(userName, passWord);
        }
        public DataTable GetUser(string userName)
        {
            return daAccount.GetDataBy5(userName);
        }
        public Account GetUser1(string userName)
        {
            DataTable data = daAccount.GetDataBy6(userName);
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public void updateProfile(string displayname,string password,string username)
        {
            daAccount.UpdateQuery(displayname, password, username);
        }
        //Bill
          public DataTable GetDataDoanhThu(string inc,string outc)
        {
            return dataBilladap.GetData(inc,outc);
        }
        public int GetDataBill(int id)
        {
            DataTable data= daBill.GetDataByIdTable(id);
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public DataTable getCategory()
        {
            return daFoodCategory.GetData();
        }
        public DataTable getFoodByIdCate(int id)
        {
            return daFood.GetDataByIdCategory(id);
        }
    }

}
