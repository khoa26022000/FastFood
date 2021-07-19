using DAL.QLFOODTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class GetUnCheckBillByIdTable
    {
        BillTableAdapter daBill = new BillTableAdapter();

        public int GetDataBill(int id)
        {
            DataTable data = daBill.GetDataBy(id);

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        //public DataTable insertBill(DateTime dateCheckIn, DateTime dateCheckOut, int id, int status)
        //{
        //    return daBill.Insert(dateIn,dateOut,id,status);
        //}

    }
}
