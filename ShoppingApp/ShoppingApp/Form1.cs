using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoppingAppDataSet.Cart' table. You can move, or remove it, as needed.
            this.cartTableAdapter.Fill(this.shoppingAppDataSet.Cart);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUserName.Text;
            string Password = txtpassword.Text;

        }
    }
}
