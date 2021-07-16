using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;

namespace FastFood.Forms
{
    public partial class Admin : Form
    {
        GetDataBLL getDataBLL = new GetDataBLL();
        public Admin()
        {
            InitializeComponent();
        }


        private void Admin_Load(object sender, EventArgs e)
        {
            viewAccount.DataSource = getDataBLL.GetAccount();
        }
    }
}
