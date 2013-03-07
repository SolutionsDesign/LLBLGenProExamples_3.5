using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using SD.LLBLGen.Pro.Examples.WCF;
using SD.LLBLGen.Pro.Examples.WCF.EntityClasses;
using SD.LLBLGen.Pro.Examples.WCF.HelperClasses;
using SD.LLBLGen.Pro.Examples.WCF.FactoryClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Collections.Generic;

namespace SD.LLBLGen.Pro.Examples.WCF.Client
{
	/// <summary>
	/// The customer manager. It allows you to manage a customer's data and its orders and that orders' orderdetails.
	/// It illustrates complex databinding (master-detail), events, sorting, fields mapped on relations (Customer.Orders ..), 
	/// transactions and validation.
	/// The code can seem somewhat complex at first, that's because a lot of maintainance is done to keep all the eventhandlers correct,
	/// log which collections are dirty, which have been visited (for the eventhandlers) etc. 
	/// </summary>
	public class CustomerManager : System.Windows.Forms.Form
	{
		#region Components
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox customerIDTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox companyNameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox contactNameTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox contactTitleTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button selectCustomerButton;
		private System.Windows.Forms.Button saveCustomerButton;
		private System.Windows.Forms.TextBox postalCodeTextBox;
		private System.Windows.Forms.TextBox regionTextBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGrid ordersDataGrid;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button removeOrderButton;
		private System.Windows.Forms.Button saveOrdersButton;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGrid orderDetailsDataGrid;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.TextBox faxTextBox;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.TextBox countryTextBox;
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.Label label32;
		#endregion

		#region Class Member Declarations
		private CustomersEntity		_currentCustomer;
		private bool				_customerObjectIsBinded;
		private CurrencyManager		_ordersCManager;
		private List<EntityCollection<OrderDetailsEntity>>			_visitedOrderDetails;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public CustomerManager()
		{
			InitializeComponent();
			_currentCustomer=null;
			_customerObjectIsBinded=false;

			// block resizing beyond a minimum;
			this.MinimumSize = this.Size;
			_ordersCManager=null;
			_visitedOrderDetails = new List<EntityCollection<OrderDetailsEntity>>();
		}

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="customer">the customer to manage</param>
		public CustomerManager(CustomersEntity customer):this()
		{
			// load customer and set as active.
			SetCustomerAsCurrent(customer.CustomerId);
		}

		/// <summary>
		/// Binds the current set customer (in _currentCustomer) to the gui's controls so data entered is validated directly.
		/// </summary>
		private void  BindCustomerToGui()
		{
			if(_currentCustomer==null)
			{
				// no active customer
				return;
			}

			// bind it. First remove old bindings.
			if(_customerObjectIsBinded)
			{
				customerIDTextBox.DataBindings.RemoveAt(0);
				companyNameTextBox.DataBindings.RemoveAt(0);
				contactNameTextBox.DataBindings.RemoveAt(0);
				contactTitleTextBox.DataBindings.RemoveAt(0);
				postalCodeTextBox.DataBindings.RemoveAt(0);
				regionTextBox.DataBindings.RemoveAt(0);
				addressTextBox.DataBindings.RemoveAt(0);
				faxTextBox.DataBindings.RemoveAt(0);
				phoneTextBox.DataBindings.RemoveAt(0);
				countryTextBox.DataBindings.RemoveAt(0);
				cityTextBox.DataBindings.RemoveAt(0);
			}

			// add new bindings.
			customerIDTextBox.DataBindings.Add("Text", _currentCustomer, "CustomerId");
			companyNameTextBox.DataBindings.Add("Text", _currentCustomer, "CompanyName");
			contactNameTextBox.DataBindings.Add("Text", _currentCustomer, "ContactName");
			contactTitleTextBox.DataBindings.Add("Text", _currentCustomer, "ContactTitle");
			postalCodeTextBox.DataBindings.Add("Text", _currentCustomer, "PostalCode");
			regionTextBox.DataBindings.Add("Text", _currentCustomer, "Region");
			addressTextBox.DataBindings.Add("Text", _currentCustomer, "Address");
			faxTextBox.DataBindings.Add("Text", _currentCustomer, "Fax");
			phoneTextBox.DataBindings.Add("Text", _currentCustomer, "Phone");
			countryTextBox.DataBindings.Add("Text", _currentCustomer, "Country");
			cityTextBox.DataBindings.Add("Text", _currentCustomer, "City");

			// set new event handler
			_currentCustomer.PropertyChanged += new PropertyChangedEventHandler(_currentCustomer_PropertyChanged);
			_customerObjectIsBinded=true;

			// bind its orders to the grids.
			BindOrders();
		}


		/// <summary>
		/// Binds the orders and the orderdetails grids to the data of the current customer. It's a separate routine because this
		/// functionality is re-used more than once.
		/// Use this routine together with UnbindOrders or as initialization.
		/// </summary>
		private void BindOrders()
		{
			if(_currentCustomer==null)
			{
				return;
			}

			// clean up house keeping collections. Remove eventhandlers so we don't get memleaks.
			for (int i = 0; i < _visitedOrderDetails.Count; i++)
			{
				_visitedOrderDetails[i].ListChanged-=new ListChangedEventHandler(CurrentOrderDetails_ListChanged);
			}
			_visitedOrderDetails.Clear();

			// bind orders
			ordersDataGrid.DataSource=_currentCustomer.Orders;
			ordersDataGrid.CurrentRowIndex=0;

			// set event handler
			_currentCustomer.Orders.ListChanged+=new ListChangedEventHandler(Orders_ListChanged);

			// bind orderdetails
			orderDetailsDataGrid.DataSource=_currentCustomer.Orders;
			orderDetailsDataGrid.DataMember="OrderDetails";

			if(_ordersCManager==null)
			{
				// create currency manager to keep track of which order is displayed.
				_ordersCManager=(CurrencyManager)this.BindingContext[_currentCustomer.Orders];
				_ordersCManager.PositionChanged+=new EventHandler(_ordersCManager_PositionChanged);
			}

			if(_currentCustomer.Orders.Count>0)
			{
				// there are orders. The binding is the initial one. The grid will select the first row in the orders grid
				// and will bind the orderdetails of that order in the orderdetails grid.
				// We have to set up the initial event handler for this one. All other orderdetails are binded automatically by the
				// binding context and we set their event handlers in the _ordersCManager_PositionChanged event handler routine.
				if(!_visitedOrderDetails.Contains( _currentCustomer.Orders[ordersDataGrid.CurrentRowIndex].OrderDetails))
				{
					// add it
					_visitedOrderDetails.Add(_currentCustomer.Orders[ordersDataGrid.CurrentRowIndex].OrderDetails);
					
					// add eventhandler
					OrdersEntity currentSelectedOrder = _currentCustomer.Orders[ordersDataGrid.CurrentRowIndex];
					currentSelectedOrder.OrderDetails.ListChanged+=new ListChangedEventHandler(CurrentOrderDetails_ListChanged);
					currentSelectedOrder.OrderDetails.AllowRemove=true;
				}

				removeOrderButton.Enabled=true;
			}
			else
			{
				removeOrderButton.Enabled=false;
			}
		}


		/// <summary>
		/// Removes binding of orders from the gui. This is necessary to prevent all kinds of events starting actions behind our back
		/// and the datagrids will not interfere with processes we want to control ourselves.
		/// It also unbinds all event handlers from the visited collections, so the gui is not updated and interfering with our actions
		/// </summary>
		/// <remarks>
		/// This is a routine necessary to keep the gui away from what we're doing. Normally routines like this are not necessary since
		/// gui's would simply collect information and would stop processing current objects and hand over the new information to a BL tier.
		/// For the simplicity of the example, there is no BL tier.
		/// 
		/// After calling this routine, do the actions and call refresh or BindOrders() again to update the gui with the results of the
		/// actions.
		/// </remarks>
		private void UnbindOrders()
		{
			if(ordersDataGrid.DataSource!=null)
			{
				ordersDataGrid.CurrentRowIndex=0;
			}

			if(orderDetailsDataGrid.DataSource!=null)
			{
				orderDetailsDataGrid.CurrentRowIndex=0;
			}

			// remove event handlers 
			_currentCustomer.Orders.ListChanged-=new ListChangedEventHandler(Orders_ListChanged);
			for (int i = 0; i < _visitedOrderDetails.Count; i++)
			{
				_visitedOrderDetails[i].ListChanged-=new ListChangedEventHandler(CurrentOrderDetails_ListChanged);
			}

			if(_ordersCManager!=null)
			{
				_ordersCManager.PositionChanged-=new EventHandler(_ordersCManager_PositionChanged);
				_ordersCManager = null;
			}

			ordersDataGrid.DataSource=null;
			orderDetailsDataGrid.DataSource=null;
		}


		/// <summary>
		/// removes the order passed in from the persistent storage. Also the order detail rows belonging with this order will be
		/// removed. It is wise to refresh the gui after this action, since collections and other data elements have to refreshed to illustrate the
		/// change.
		/// </summary>
		/// <param name="orderToRemove">Order entity to remove from the persistent storage</param>
		/// <returns>true if the removal was succesful, false otherwise</returns>
		private bool RemoveOrder(OrdersEntity orderToRemove)
		{
			return MainForm.DalService.RemoveOrder(orderToRemove);
		}


		/// <summary>
		/// Fetches the customer + orders + order details from the service for the customer passed in, 
		/// adding values of the customer to the controls on the form and setting
		/// up eventhandlers so the gui is aware of changes of the customer or its contents.
		/// </summary>
		/// <param name="customer"></param>
		private void SetCustomerAsCurrent(string customerId)
		{
			if(_currentCustomer!=null)
			{
				// first remove the eventhandlers from the current object
				_currentCustomer.PropertyChanged -= new PropertyChangedEventHandler(_currentCustomer_PropertyChanged);
				_currentCustomer.Orders.ListChanged-=new ListChangedEventHandler(Orders_ListChanged);
			}

			if(_ordersCManager!=null)
			{
				// remove the currency manager.
				_ordersCManager.PositionChanged-=new EventHandler(_ordersCManager_PositionChanged);
				_ordersCManager = null;
			}

			// get new graph from server
			_currentCustomer = (CustomersEntity)MainForm.DalService.GetCustomerWithFullOrders(customerId);

			// bind the customer to the gui elements.
			BindCustomerToGui();
		}


		#region Windows Form Designer generated code
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.saveCustomerButton = new System.Windows.Forms.Button();
			this.selectCustomerButton = new System.Windows.Forms.Button();
			this.faxTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.countryTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.postalCodeTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.regionTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.addressTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.contactTitleTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.contactNameTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.companyNameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.customerIDTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ordersDataGrid = new System.Windows.Forms.DataGrid();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.orderDetailsDataGrid = new System.Windows.Forms.DataGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.saveOrdersButton = new System.Windows.Forms.Button();
			this.removeOrderButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGrid)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.cityTextBox);
			this.groupBox1.Controls.Add(this.label32);
			this.groupBox1.Controls.Add(this.saveCustomerButton);
			this.groupBox1.Controls.Add(this.selectCustomerButton);
			this.groupBox1.Controls.Add(this.faxTextBox);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.phoneTextBox);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.countryTextBox);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.postalCodeTextBox);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.regionTextBox);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.addressTextBox);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.contactTitleTextBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.contactNameTextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.companyNameTextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.customerIDTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(669, 213);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customer information";
			// 
			// cityTextBox
			// 
			this.cityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cityTextBox.Location = new System.Drawing.Point(108, 129);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(351, 20);
			this.cityTextBox.TabIndex = 6;
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(12, 132);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(93, 18);
			this.label32.TabIndex = 22;
			this.label32.Text = "City";
			// 
			// saveCustomerButton
			// 
			this.saveCustomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveCustomerButton.Enabled = false;
			this.saveCustomerButton.Location = new System.Drawing.Point(561, 180);
			this.saveCustomerButton.Name = "saveCustomerButton";
			this.saveCustomerButton.Size = new System.Drawing.Size(99, 24);
			this.saveCustomerButton.TabIndex = 12;
			this.saveCustomerButton.Text = "Save changes";
			this.saveCustomerButton.Click += new System.EventHandler(this.saveCustomerButton_Click);
			// 
			// selectCustomerButton
			// 
			this.selectCustomerButton.Location = new System.Drawing.Point(225, 21);
			this.selectCustomerButton.Name = "selectCustomerButton";
			this.selectCustomerButton.Size = new System.Drawing.Size(66, 21);
			this.selectCustomerButton.TabIndex = 1;
			this.selectCustomerButton.Text = "Select...";
			this.selectCustomerButton.Click += new System.EventHandler(this.selectCustomerButton_Click);
			// 
			// faxTextBox
			// 
			this.faxTextBox.Location = new System.Drawing.Point(330, 177);
			this.faxTextBox.Name = "faxTextBox";
			this.faxTextBox.Size = new System.Drawing.Size(111, 20);
			this.faxTextBox.TabIndex = 11;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(240, 180);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(78, 18);
			this.label10.TabIndex = 20;
			this.label10.Text = "Fax";
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.Location = new System.Drawing.Point(108, 177);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(120, 20);
			this.phoneTextBox.TabIndex = 10;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(12, 180);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(93, 18);
			this.label9.TabIndex = 18;
			this.label9.Text = "Phone";
			// 
			// countryTextBox
			// 
			this.countryTextBox.Location = new System.Drawing.Point(330, 153);
			this.countryTextBox.Name = "countryTextBox";
			this.countryTextBox.Size = new System.Drawing.Size(249, 20);
			this.countryTextBox.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(240, 156);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(87, 18);
			this.label8.TabIndex = 16;
			this.label8.Text = "Country";
			// 
			// postalCodeTextBox
			// 
			this.postalCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.postalCodeTextBox.Location = new System.Drawing.Point(570, 129);
			this.postalCodeTextBox.Name = "postalCodeTextBox";
			this.postalCodeTextBox.Size = new System.Drawing.Size(87, 20);
			this.postalCodeTextBox.TabIndex = 7;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Location = new System.Drawing.Point(474, 132);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 18);
			this.label7.TabIndex = 14;
			this.label7.Text = "Postalcode";
			// 
			// regionTextBox
			// 
			this.regionTextBox.Location = new System.Drawing.Point(108, 153);
			this.regionTextBox.Name = "regionTextBox";
			this.regionTextBox.Size = new System.Drawing.Size(120, 20);
			this.regionTextBox.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 156);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 18);
			this.label6.TabIndex = 12;
			this.label6.Text = "Region";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.addressTextBox.Location = new System.Drawing.Point(108, 105);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(549, 20);
			this.addressTextBox.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 108);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 18);
			this.label5.TabIndex = 10;
			this.label5.Text = "Address";
			// 
			// contactTitleTextBox
			// 
			this.contactTitleTextBox.Location = new System.Drawing.Point(108, 75);
			this.contactTitleTextBox.Name = "contactTitleTextBox";
			this.contactTitleTextBox.Size = new System.Drawing.Size(111, 20);
			this.contactTitleTextBox.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 18);
			this.label4.TabIndex = 8;
			this.label4.Text = "ContactTitle";
			// 
			// contactNameTextBox
			// 
			this.contactNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.contactNameTextBox.Location = new System.Drawing.Point(330, 75);
			this.contactNameTextBox.Name = "contactNameTextBox";
			this.contactNameTextBox.Size = new System.Drawing.Size(327, 20);
			this.contactNameTextBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(240, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 18);
			this.label3.TabIndex = 6;
			this.label3.Text = "Contact Name";
			// 
			// companyNameTextBox
			// 
			this.companyNameTextBox.Location = new System.Drawing.Point(108, 51);
			this.companyNameTextBox.Name = "companyNameTextBox";
			this.companyNameTextBox.Size = new System.Drawing.Size(243, 20);
			this.companyNameTextBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 18);
			this.label2.TabIndex = 4;
			this.label2.Text = "Company Name";
			// 
			// customerIDTextBox
			// 
			this.customerIDTextBox.Location = new System.Drawing.Point(108, 21);
			this.customerIDTextBox.Name = "customerIDTextBox";
			this.customerIDTextBox.ReadOnly = true;
			this.customerIDTextBox.Size = new System.Drawing.Size(111, 20);
			this.customerIDTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Customer ID";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.ordersDataGrid);
			this.groupBox2.Controls.Add(this.splitter1);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(9, 225);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(666, 423);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Customer\'s orders";
			// 
			// ordersDataGrid
			// 
			this.ordersDataGrid.AllowNavigation = false;
			this.ordersDataGrid.CaptionText = "Orders";
			this.ordersDataGrid.DataMember = "";
			this.ordersDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ordersDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.ordersDataGrid.Location = new System.Drawing.Point(3, 16);
			this.ordersDataGrid.Name = "ordersDataGrid";
			this.ordersDataGrid.Size = new System.Drawing.Size(660, 149);
			this.ordersDataGrid.TabIndex = 0;
			// 
			// splitter1
			// 
			this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(3, 165);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(660, 6);
			this.splitter1.TabIndex = 11;
			this.splitter1.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.orderDetailsDataGrid);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox3.Location = new System.Drawing.Point(3, 171);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(660, 207);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Current order\'s order details";
			// 
			// orderDetailsDataGrid
			// 
			this.orderDetailsDataGrid.CaptionText = "Order Details";
			this.orderDetailsDataGrid.DataMember = "";
			this.orderDetailsDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.orderDetailsDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.orderDetailsDataGrid.Location = new System.Drawing.Point(3, 16);
			this.orderDetailsDataGrid.Name = "orderDetailsDataGrid";
			this.orderDetailsDataGrid.Size = new System.Drawing.Size(654, 188);
			this.orderDetailsDataGrid.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.saveOrdersButton);
			this.panel1.Controls.Add(this.removeOrderButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(3, 378);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(660, 42);
			this.panel1.TabIndex = 9;
			// 
			// saveOrdersButton
			// 
			this.saveOrdersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveOrdersButton.Enabled = false;
			this.saveOrdersButton.Location = new System.Drawing.Point(546, 9);
			this.saveOrdersButton.Name = "saveOrdersButton";
			this.saveOrdersButton.Size = new System.Drawing.Size(105, 23);
			this.saveOrdersButton.TabIndex = 3;
			this.saveOrdersButton.Text = "Save Changes";
			this.saveOrdersButton.Click += new System.EventHandler(this.saveOrdersButton_Click);
			// 
			// removeOrderButton
			// 
			this.removeOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.removeOrderButton.Enabled = false;
			this.removeOrderButton.Location = new System.Drawing.Point(9, 9);
			this.removeOrderButton.Name = "removeOrderButton";
			this.removeOrderButton.Size = new System.Drawing.Size(105, 23);
			this.removeOrderButton.TabIndex = 1;
			this.removeOrderButton.Text = "Remove Order...";
			this.removeOrderButton.Click += new System.EventHandler(this.removeOrderButton_Click);
			// 
			// CustomerManager
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(679, 656);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "CustomerManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Northwind Customer manager form";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ordersDataGrid)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.orderDetailsDataGrid)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		
		#region Event Handlers

		private void selectCustomerButton_Click(object sender, System.EventArgs e)
		{
			CustomerSelector selector = new CustomerSelector();
			selector.ShowDialog(this);

			if(selector.CancelClicked)
			{
				return;
			}

			SetCustomerAsCurrent(selector.SelectedCustomer.CustomerId);
		}


		private void _currentCustomer_PropertyChanged(object sender, EventArgs e)
		{
			// enable the customer save button only if the customer's data is dirty so a save is necessary.
			saveCustomerButton.Enabled=_currentCustomer.Fields.IsDirty;
		}


		private void saveCustomerButton_Click(object sender, System.EventArgs e)
		{
			// save the customer, not recursively, as we just want to save the customer.
			bool succeeded = MainForm.DalService.SaveCustomer(_currentCustomer, false);

			if(succeeded)
			{
				MessageBox.Show("Save was succesful!", "Save result", MessageBoxButtons.OK, MessageBoxIcon.Information);
				saveCustomerButton.Enabled = false;
			}
			else
			{
				MessageBox.Show(this, "Save was NOT succesful!", "Save result", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

            CustomersEntity newData = (CustomersEntity)MainForm.DalService.GetCustomer(_currentCustomer.CustomerId);
			// as remoting copies objects, we want to keep the old customer object but with the data refetched from the service
			_currentCustomer.Fields = newData.Fields;
		}


		private void Orders_ListChanged(object sender, ListChangedEventArgs e)
		{
			// the orders list has changed, enabled save changes button
			saveOrdersButton.Enabled=true;
		}


		private void saveOrdersButton_Click(object sender, System.EventArgs e)
		{
			// simply recursively save the orders.
			IEntityCollection2 orders = new EntityCollection(new OrdersEntityFactory());
            foreach(OrdersEntity order in _currentCustomer.Orders)
            {
                orders.Add(order);
            }
            MainForm.DalService.SaveOrders(orders);

			// reset UI, so all data is refetched
			SetCustomerAsCurrent(_currentCustomer.CustomerId);
			saveOrdersButton.Enabled = false;
		}


		private void _ordersCManager_PositionChanged(object sender, EventArgs e)
		{
			// a new orders details collection has been bound. 
			OrdersEntity currentOrder = (OrdersEntity)_currentCustomer.Orders[_ordersCManager.Position];

			if(!_visitedOrderDetails.Contains(currentOrder.OrderDetails))
			{
				// add handler
				currentOrder.OrderDetails.ListChanged += new ListChangedEventHandler(CurrentOrderDetails_ListChanged);
				_visitedOrderDetails.Add(currentOrder.OrderDetails);
				currentOrder.OrderDetails.AllowRemove = true;
			}

			removeOrderButton.Enabled = !_currentCustomer.Orders[_ordersCManager.Position].IsNew;
		}


		private void CurrentOrderDetails_ListChanged(object sender, ListChangedEventArgs e)
		{
			// the order detials list has changed, enabled save changes button
			saveOrdersButton.Enabled=true;
		}


		private void removeOrderButton_Click(object sender, System.EventArgs e)
		{
			// check if there are orders and if so, check if the current selected row in the grid is in the order collection (i.o.w.: if the row index is 
			// in the order collection)
			if(_currentCustomer==null)
			{
				return;
			}

			if(_currentCustomer.Orders.Count<=0)
			{
				// no orders.
				return;
			}

			if(_currentCustomer.Orders.Count<=ordersDataGrid.CurrentRowIndex)
			{
				// index is not on a row in our collection
				return;
			}

			OrdersEntity currentOrder = (OrdersEntity)_currentCustomer.Orders[ordersDataGrid.CurrentRowIndex];

			if(currentOrder.IsNew)
			{
				// it's a new order, can't be removed from the database. simply return for now
				return;
			}

			// seems ok. Present a message box
			DialogResult proceed = MessageBox.Show(this, "Are you sure you want to remove the order '" + currentOrder.OrderId +
									"'? The grids will be refreshed after the removal.", "Confirmation request.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			if(proceed==DialogResult.No)
			{
				return;
			}

			// remove the order. Pass Order
			UnbindOrders();
			bool result = RemoveOrder(currentOrder);
			if(result)
			{
				MessageBox.Show(this, "The removal was succesful.", "Remove result.");
			}
			else
			{
				MessageBox.Show(this, "The removal was NOT succesful.", "Remove result.");
			}
			// update locally, to save roundtrips
			_currentCustomer.Orders.Remove(currentOrder);
			BindOrders();
		}
		#endregion

	}
}
