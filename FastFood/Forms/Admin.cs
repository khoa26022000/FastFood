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
    public partial class Admin : Form
    {
        ConnectDAL data = new ConnectDAL();
        int IdType=0;
        int IdFood = 0;
        int idTable = 0;
        string[] ports = new string[2] { "Admin", "Nhan Vien" };
        public Admin()
        {
            InitializeComponent();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            loadCombobox();
            loadComboboxTypeAccount();
            dataGVdoanhThu.DataSource = data.GetDataDoanhThu("1000-1-1", "3000-1-1"); 
        }
        public void loadLv()
        {
            lvFood.DataSource = data.GetDataFood();
        }
        public void loadgvTypeFood()
        {
            gvTypeFood.DataSource = data.GetDataFoodType();
        }
        public void loadgvTableFood()
        {
            dataGVTableFood.DataSource = data.GetDataTableFood();
        }
        public void loadingSearchFood()
        {
            lvFood.DataSource = data.GetDataSearchFood(textBox1.Text+"%");
        }
            
        public void lodGvAccount()
        {
            viewAccount.DataSource = data.GetDataAccount();        
        }
        public void loadDoanhThu()
        {
            dataGVdoanhThu.DataSource = data.GetDataDoanhThu(dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
        }
        private void button5_Click(object sender, EventArgs e)
        {
            loadLv();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loadgvTypeFood();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            data.InsertType(textBox2.Text);
            loadgvTypeFood();
            resetControls();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            data.DeleteType(IdType,textBox2.Text);
            loadgvTypeFood();
            resetControls();
        }

        private void gvTypeFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvTypeFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdType = Convert.ToInt32(gvTypeFood.SelectedRows[0].Cells[0].Value);
            textBox4.Text = IdType.ToString();
            textBox2.Text = gvTypeFood.SelectedRows[0].Cells[1].Value.ToString();
        }
        public void resetControls()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            data.UpdateType(IdType, textBox2.Text);
            loadgvTypeFood();
            resetControls();
        }
        public void loadCombobox()
        {
            comboBox1.DataSource = data.GetDataFoodType();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
        }
        public void loadComboboxTypeAccount()
        {
            for (int i = 0; i < ports.Length; i++)
            {
                if (ports[i] == "Admin")
                {
                    comboBox3.DataSource = ports.Select(p => new { Key = -1, Value = p }).ToList();
                    comboBox3.DisplayMember = "Value";
                    comboBox3.ValueMember = "Key";
                }
                else
                {
                   
                        comboBox3.DataSource = ports.Select(p => new { Key = 0, Value = p }).ToList();
                        comboBox3.DisplayMember = "Value";
                        comboBox3.ValueMember = "Key";
                }
            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            data.InsertFood(textBox3.Text, (int)comboBox1.SelectedValue, (double)numericUpDown1.Value);
            loadLv();
            resetControls();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            data.UpdateFood(IdFood, textBox3.Text, (int)comboBox1.SelectedValue, (double)numericUpDown1.Value);
            loadLv();
            resetControls();
        }

        private void lvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdFood = Convert.ToInt32(lvFood.SelectedRows[0].Cells[0].Value);
            textBox5.Text = IdFood.ToString();
            textBox3.Text = lvFood.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.SelectedValue = lvFood.SelectedRows[0].Cells[2].Value;
            numericUpDown1.Value =(decimal) Convert.ToInt64( lvFood.SelectedRows[0].Cells[3].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data.DeleteFood(IdFood, textBox3.Text, (int)comboBox1.SelectedValue, (double)numericUpDown1.Value);
            loadLv();
            resetControls();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            loadgvTableFood();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            data.InsertTable(textBox6.Text,textBox10.Text);
            loadgvTableFood();
            resetControls();
        }

        private void dataGVTableFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idTable = Convert.ToInt32(dataGVTableFood.SelectedRows[0].Cells[0].Value);

            textBox7.Text = idTable.ToString();

            textBox6.Text = dataGVTableFood.SelectedRows[0].Cells[1].Value.ToString();

            textBox10.Text = dataGVTableFood.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            data.DeleteTable(idTable,textBox6.Text, textBox10.Text);
            loadgvTableFood();
            resetControls();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            data.UpdateTable(idTable, textBox6.Text, textBox10.Text);
            loadgvTableFood();
            resetControls();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lodGvAccount();
        }

        private void viewAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox9.Text = viewAccount.SelectedRows[0].Cells[0].Value.ToString(); ;
            textBox8.Text = viewAccount.SelectedRows[0].Cells[1].Value.ToString();
            comboBox3.SelectedValue = viewAccount.SelectedRows[0].Cells[2].Value;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            data.UpdateDisplayName(textBox9.Text, textBox8.Text,"",(int)comboBox3.SelectedValue);
            lodGvAccount();
            resetControls();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            data.InsertDisplayName(textBox9.Text, textBox8.Text, "", (int)comboBox3.SelectedValue, "123456");
            lodGvAccount();
            resetControls();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            data.DeletedisplayName(textBox9.Text);
            lodGvAccount();
            resetControls();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            data.updatePass(textBox9.Text,"123");
            MessageBox.Show("Đổi thành công");
            lodGvAccount();
            resetControls();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                loadingSearchFood();
            }
            else
            {
                loadLv();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDoanhThu();
        }
    }

}
