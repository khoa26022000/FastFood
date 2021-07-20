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
        ConnectDAL data = new ConnectDAL();
        GetDataTableFood getData = new GetDataTableFood();
        MenuDB getMenu = new MenuDB();
        BillDB daBill = new BillDB();
        
        public FormProduct()
        {
            InitializeComponent();
            loadTable();
            loadCategory();
            cbFood.DataSource = data.getFoodByIdCate(1);
            cbFood.DisplayMember = "name";
            cbFood.ValueMember = "id";
            
        }
        void loadCategory()
        {
            cbGategory.DataSource = data.getCategory();
            cbGategory.DisplayMember = "name";
            cbGategory.ValueMember = "id";
        }
        void loadTable()
        {
            flpTable.Controls.Clear();
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
            txtTotalPrice.Text = totalPrice.ToString("#,##")+" VNĐ";

        }
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            showBill(tableID);
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbGategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cbGategory.SelectedValue;
            cbFood.DataSource = data.getFoodByIdCate(id);
            cbFood.DisplayMember = "name";
            cbFood.ValueMember = "id";
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lsvBill.Tag as Table;
                int foodID = (int)cbFood.SelectedValue;
                int countFood = (int)countValue.Value;
                int idBill = daBill.GetDataBill(table.ID);
                if (idBill == -1)
                {
                    daBill.insertBill(table.ID);
                    getMenu.insertBillInfo(daBill.getMaxIDBill(), foodID, countFood);
                }
                else
                {
                    getMenu.insertBillInfo(idBill, foodID, countFood);
                }
                showBill(table.ID);
                loadTable();
            }
            catch {
                if (MessageBox.Show("Bạn có chắc thêm món !!!" , "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    btnAddFood_Click(sender, e);
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lsvBill.Tag as Table;
                int idBill = daBill.GetDataBill(table.ID);
                //string a = String.Format("{0:n}", txtTotalPrice.ToString());
                string[] arrListStr = txtTotalPrice.ToString().Split(' ');
                float totalPrice = float.Parse(arrListStr[2]);


                if (idBill != -1)
                {
                    if (MessageBox.Show("Bạn có chắc thanh toán !!!" + table.Name, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        daBill.updateThanhToan(totalPrice, idBill);
                        showBill(table.ID);
                        loadTable();
                    }
                }
            }
            catch { MessageBox.Show("Bàn không có người !!!"); }
        }
    }
}
