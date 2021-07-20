
using DAL.QLFOODTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class MenuDB
    {
        BillInfoTableAdapter daBillInfo = new BillInfoTableAdapter();
        DataTable2TableAdapter daMenu = new DataTable2TableAdapter();

        //NewSelectCommandTableAdapter daMenu = new NewSelectCommandTableAdapter();
        public List<Menu> GetListMenuByID(int id)
        {
            List<Menu> listMenu = new List<Menu>();
            //DataTable data = daBillInfo.GetDataByMenu(id); 
            DataTable data = daMenu.GetData(id);


            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
        public void insertBillInfo(int idBill, int idFood, int count)
        {
            daBillInfo.Insert(idBill, idFood, count);
        }
    }
}