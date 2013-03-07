using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Northwind.DAL.CollectionClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.EntityClasses;

namespace Northwind.GUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			// fill the employeecollection with all the employee entities
			_availableEmployeesCollection.GetMulti(null);

			// fill the shippers collection with all the shipper entities
			_availableShippersCollection.GetMulti(null);

			// load all customers and bind them to the combobox
			CustomerCollection customers = new CustomerCollection();
			customers.GetMulti(null, 0, new SortExpression(CustomerFields.CompanyName | SortOperator.Ascending));
			_customersComboBox.DataSource = customers;
			_customersComboBox.DisplayMember = "CompanyName";
			_customersComboBox.ValueMember = "CustomerId";
		}

		private void _closeButton_Click(object sender, EventArgs e)
		{
			// done
			this.Close();
		}

		private void _loadOrdersButton_Click(object sender, EventArgs e)
		{
			CustomerEntity selectedCustomer = (CustomerEntity)_customersComboBox.SelectedItem;
			// bind the orders collection. It will lazy load the data from the database before binding.
			_ordersGridView.DataSource = selectedCustomer.Orders;
		}
	}
}