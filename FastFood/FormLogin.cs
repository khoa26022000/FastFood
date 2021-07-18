using DAL;
using FastFood.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FastFood
{
    public partial class FormLogin : Form
    {
        int numRows = 0;
        ConnectDAL getData = new ConnectDAL();
        DataTable users = new DataTable();
        public string UserID { get; set; }
        public string DisName { get; set; }
        public string Type { get; set; }
        public FormLogin()
        {
            InitializeComponent();
            textBox3.PasswordChar = '*';
        }
        public void getTypeUser(string user, string pass)
        {
            if (string.IsNullOrEmpty(user.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + label1.Text);
                this.textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Không được bỏ trống " + label2.Text);
                this.textBox2.Focus();
                return;
            }
            users = getData.GetLogin(user, pass);
            numRows = users.Rows.Count;
            for (int index = 0; index < numRows; index++)
            {
                if (textBox2.Text == users.Rows[index]["UserName"].ToString() && textBox3.Text == users.Rows[index]["Password"].ToString())
                {
                    MessageBox.Show("thanh cong");
                    UserID = users.Rows[index]["UserName"].ToString();
                    DisName = users.Rows[index]["DisplayName"].ToString();
                    Type = users.Rows[index]["Type"].ToString();
                    if (Program.mainForm == null || Program.mainForm.IsDisposed)
                    {
                        Program.mainForm = new Form1();
                    }
                    this.Visible = false;
                    Program.mainForm.MADN = UserID;
                    Program.mainForm.DisName = DisName;
                    Program.mainForm.Type = Type;
                    Program.mainForm.Show();

                }
                else
                    MessageBox.Show("Sai User hoac Password");
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát ?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            getTypeUser(textBox2.Text, textBox3.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.resForm == null || Program.resForm.IsDisposed)
            {
                Program.resForm = new Register();
            }
            this.Visible = false;
            Program.resForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
