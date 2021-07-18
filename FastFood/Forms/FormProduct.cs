using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using System.Globalization;

namespace FastFood.Forms
{
    public partial class FormProduct : Form
    {
        GetDataTableFood getData = new GetDataTableFood();
        GetUnCheckBillByIdTable getBil = new GetUnCheckBillByIdTable();
        BillInfoDB getBillInfo = new BillInfoDB();
        MenuDAL getMenu = new MenuDAL();
        public FormProduct()
        {
            InitializeComponent();
            loadTable();
        }
        void loadTable()
        {
            List<Table> tableList= getData.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button();
                btn.Width = 90;
                btn.Height = 90;
                btn.Text = item.Name+  Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status) { 
                    case "Trống":
                        btn.BackColor = Color.White;
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(192, 255, 255);
                        break;

                }
                flpTable.Controls.Add(btn);
            }
        }
        void showBill(int id)
        {
            lsvBill.Items.Clear();
            //List<BillInfo> listBillInfo = getBillInfo.GetListBillInfo(getBil.GetDataBill(id));
            //foreach (BillInfo item in listBillInfo)
            //{
            //    ListViewItem lsvItem = new ListViewItem(item.FoodID.ToString());
            //    lsvItem.SubItems.Add(item.Count.ToString());
            //    lsvBill.Items.Add(lsvItem);
            //}

            List<DAL.Menu> listBillInfo = getMenu.GetListMenuByID(id);
            float totalPrice = 0;
            CultureInfo culute = new CultureInfo("vi-VN");
            foreach (DAL.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("#,##"));
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString("#,##"));
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            txtTotalPrice.Text = totalPrice.ToString("c", culute);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            showBill(tableID);
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
