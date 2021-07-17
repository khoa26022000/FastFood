using DAL.QLFOODTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class GetDataTableFood
    {
        TableFoodTableAdapter daTableFood = new TableFoodTableAdapter();
        public DataTable GetTableFood()
        {
            return daTableFood.GetData(); ;
        }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = daTableFood.GetData();

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }
    }
}

