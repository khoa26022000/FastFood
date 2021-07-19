using DAL.QLFOODTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class FoodDB
    {
        FoodTableAdapter data = new FoodTableAdapter();
        public DataTable GetFoodId(int id)
        {
            return data.GetDataBy(id);
        }
    }
}
