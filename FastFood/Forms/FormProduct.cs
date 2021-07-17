using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace FastFood.Forms
{
    public partial class FormProduct : Form
    {
        GetDataTableFood getData = new GetDataTableFood();
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
                btn.Width = 110;
                btn.Height = 110;
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
 
        }
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = (sender as Table).ID;
            showBill(tableID);
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
        }
    }
}
