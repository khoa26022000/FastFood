using DAL.QLFOODTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class MenuDAL
    {
        BillInfoTableAdapter daBillInfo = new BillInfoTableAdapter();
        NewSelectCommandTableAdapter daMenu = new NewSelectCommandTableAdapter();
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
    }
}
