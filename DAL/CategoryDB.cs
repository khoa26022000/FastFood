using System;
using DAL.QLFOODTableAdapters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class CategoryDB
    {
        FoodCategoryTableAdapter data = new FoodCategoryTableAdapter();
        public DataTable GetCategoryFood()
        {
            return data.GetData();
        }
    }
}
