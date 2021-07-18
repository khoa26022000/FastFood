using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FastFood.Forms
{
    public partial class Register : Form
    {
        ConnectDAL getData = new ConnectDAL();
        DataTable users = new DataTable();
        int numRows = 0;
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsetUser(textBox2.Text, textBox4.Text, textBox3.Text);
        }
        public void InsetUser(string user,string dis, string pass)
        {
            if (string.IsNullOrEmpty(user.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + label2.Text);
                this.textBox2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Không được bỏ trống " + label4.Text);
                this.textBox3.Focus();
                return;
            }
            if (string.IsNullOrEmpty(dis))
            {
                MessageBox.Show("Không được bỏ trống " + label5.Text);
                this.textBox4.Focus();
                return;
            }
            users = getData.GetUser(user);
            numRows = users.Rows.Count;
           
                if (numRows>=1)
                {
                    MessageBox.Show("Tài Khoản Tồn Tại");
                    return;
                }
                else
                {
                    getData.InsertDisplayName(user, dis, "", 0, pass);
                    MessageBox.Show("Tạo thành công");
                    if (Program.loginForm == null || Program.loginForm.IsDisposed)
                    {
                        Program.loginForm = new FormLogin();
                    }
                    this.Visible = false;
                    this.Close();
                    Program.loginForm.Show();
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Program.loginForm == null || Program.loginForm.IsDisposed)
            {
                Program.loginForm = new FormLogin();
            }
            this.Visible = false;
            this.Close();
            Program.loginForm.Show();
        }
    }
}
