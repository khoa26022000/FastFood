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
    public partial class FormAccountProfile : Form
    {
        ConnectDAL data = new ConnectDAL();
        FormLogin login = new FormLogin();
        private Account loginAccount;
        public FormAccountProfile(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            load(acc);

        }
        public void load(Account acc)
        {
            txtTenDN.Text = acc.UserName;
            txtTenHienThi.Text = acc.DisplayName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }
        public void Update()
        {
            if (String.IsNullOrEmpty(txtNewMK.Text))
            {
                MessageBox.Show("Không được bỏ trống ");
                this.txtNewMK.Focus();
                return;
            }
            if (txtMK.Text.ToString() == loginAccount.Password)
            {
                string newMK = txtNewMK.Text.ToString();
                string ten = txtTenHienThi.Text.ToString();
                data.updateProfile(ten, newMK, txtTenDN.Text.ToString());
                MessageBox.Show("Cập nhật thành công");
            }
            else
                MessageBox.Show("Vui lòng nhập đúng mật khẩu");
        }
    }
}
