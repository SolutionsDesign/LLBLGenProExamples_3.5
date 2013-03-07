using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.DatabaseSpecific;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.GUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			EntityCollection<CustomerEntity> customers = new EntityCollection<CustomerEntity>(new CustomerEntityFactory());
			using(DataAccessAdapter adapter = new DataAccessAdapter())
			{
				// fill the employeecollection with all the employee entities
				adapter.FetchEntityCollection(_availableEmployeeCollection, null);

				// fill the shippers collection with all the shipper entities
				adapter.FetchEntityCollection(_availableShippersCollection, null);

				// load all customers and bind them to the combobox
				adapter.FetchEntityCollection(customers, null, 0, new SortExpression(CustomerFields.CompanyName | SortOperator.Ascending));
				_customersComboBox.DataSource = customers;
				_customersComboBox.DisplayMember = "CompanyName";
				_customersComboBox.ValueMember = "CustomerId";
			}
		}

		private void _closeButton_Click(object sender, EventArgs e)
		{
			// done
			this.Close();
		}

		private void _loadOrdersButton_Click(object sender, EventArgs e)
		{
			CustomerEntity selectedCustomer = (CustomerEntity)_customersComboBox.SelectedItem;
			if(selectedCustomer.Orders.Count > 0)
			{
				selectedCustomer.Orders.Clear();
			}
			// fetch the orders of the customer from the db.
			using(DataAccessAdapter adapter = new DataAccessAdapter())
			{
				adapter.FetchEntityCollection(selectedCustomer.Orders, selectedCustomer.GetRelationInfoOrders());
			}
			// bind the orders collection. 
			_ordersGridView.DataSource = selectedCustomer.Orders;
		}
	}
}