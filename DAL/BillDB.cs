using DAL.QLFOODTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class BillDB
    {
        BillTableAdapter daBill = new BillTableAdapter();

        public int GetDataBill(int id)
        {
            DataTable data = daBill.GetDataBy1(id);

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void insertBill(int idTable)
        {
            daBill.InsertQueryByIDTable(idTable);
        }
        public int getMaxIDBill()
        {
            DataTable data = daBill.GetMaxID();
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void updateThanhToan(float totalPrice, int id)
        {
            daBill.UpdateThanhToan(totalPrice, id);
        }

    }
}