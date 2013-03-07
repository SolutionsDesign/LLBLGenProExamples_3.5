///////////////////////////////////////////////////////////////
// LLBLGen Pro v2.6 - Validation Example
//////////////////////////////////////////////////////////////
// This code uses LLBLGen Pro version: 2.6
// (c) Solutions Design
//////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SD.LLBLGenPro.Examples.GUI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers customers = new frmCustomers();
            customers.ShowDialog(this);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts products = new frmProducts();
            products.ShowDialog(this);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrders orders = new frmOrders();
            orders.ShowDialog(this);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}