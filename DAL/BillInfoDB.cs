using DAL.QLFOODTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class BillInfoDB
    {
        BillInfoTableAdapter daBillInfo = new BillInfoTableAdapter();
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = daBillInfo.GetDataBy(id);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);

            }
            return listBillInfo;
        }
    }
}
