namespace Northwind.GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._closeButton = new System.Windows.Forms.Button();
			this._loadOrdersButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this._customersComboBox = new System.Windows.Forms.ComboBox();
			this._ordersGridView = new System.Windows.Forms.DataGridView();
			this._employeesBinder = new System.Windows.Forms.BindingSource(this.components);
			this._availableEmployeeCollection = new Northwind.DAL.HelperClasses.EntityCollection();
			this._shippersBinder = new System.Windows.Forms.BindingSource(this.components);
			this._availableShippersCollection = new Northwind.DAL.HelperClasses.EntityCollection();
			this._ordersBinder = new System.Windows.Forms.BindingSource(this.components);
			this._ordersDesignerCollection = new Northwind.DAL.HelperClasses.EntityCollection();
			this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.requiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shippedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipViaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this._ordersGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._employeesBinder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._shippersBinder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._ordersBinder)).BeginInit();
			this.SuspendLayout();
			// 
			// _closeButton
			// 
			this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._closeButton.Location = new System.Drawing.Point(559, 416);
			this._closeButton.Name = "_closeButton";
			this._closeButton.Size = new System.Drawing.Size(75, 23);
			this._closeButton.TabIndex = 7;
			this._closeButton.Text = "Close";
			this._closeButton.UseVisualStyleBackColor = true;
			this._closeButton.Click += new System.EventHandler(this._closeButton_Click);
			// 
			// _loadOrdersButton
			// 
			this._loadOrdersButton.Location = new System.Drawing.Point(468, 3);
			this._loadOrdersButton.Name = "_loadOrdersButton";
			this._loadOrdersButton.Size = new System.Drawing.Size(75, 23);
			this._loadOrdersButton.TabIndex = 8;
			this._loadOrdersButton.Text = "Load orders";
			this._loadOrdersButton.UseVisualStyleBackColor = true;
			this._loadOrdersButton.Click += new System.EventHandler(this._loadOrdersButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Customer";
			// 
			// _customersComboBox
			// 
			this._customersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._customersComboBox.FormattingEnabled = true;
			this._customersComboBox.Location = new System.Drawing.Point(66, 5);
			this._customersComboBox.Name = "_customersComboBox";
			this._customersComboBox.Size = new System.Drawing.Size(396, 21);
			this._customersComboBox.TabIndex = 5;
			// 
			// _ordersGridView
			// 
			this._ordersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this._ordersGridView.AutoGenerateColumns = false;
			this._ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.employeeIdDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.requiredDateDataGridViewTextBoxColumn,
            this.shippedDateDataGridViewTextBoxColumn,
            this.shipViaDataGridViewTextBoxColumn,
            this.freightDataGridViewTextBoxColumn,
            this.shipNameDataGridViewTextBoxColumn,
            this.shipAddressDataGridViewTextBoxColumn,
            this.shipCityDataGridViewTextBoxColumn,
            this.shipRegionDataGridViewTextBoxColumn,
            this.shipPostalCodeDataGridViewTextBoxColumn,
            this.shipCountryDataGridViewTextBoxColumn});
			this._ordersGridView.DataSource = this._ordersBinder;
			this._ordersGridView.Location = new System.Drawing.Point(12, 32);
			this._ordersGridView.Name = "_ordersGridView";
			this._ordersGridView.Size = new System.Drawing.Size(622, 378);
			this._ordersGridView.TabIndex = 4;
			// 
			// _employeesBinder
			// 
			this._employeesBinder.DataSource = this._availableEmployeeCollection;
			// 
			// _availableEmployeeCollection
			// 
			this._availableEmployeeCollection.ActiveContext = null;
			this._availableEmployeeCollection.AllowEdit = true;
			this._availableEmployeeCollection.AllowNew = true;
			this._availableEmployeeCollection.AllowRemove = true;
			this._availableEmployeeCollection.Capacity = 256;
			this._availableEmployeeCollection.ConcurrencyPredicateFactoryToUse = null;
			this._availableEmployeeCollection.DoNotPerformAddIfPresent = false;
			this._availableEmployeeCollection.EntityFactoryToUse = new Northwind.DAL.FactoryClasses.EmployeeEntityFactory();
			this._availableEmployeeCollection.IsReadOnly = false;
			// 
			// _shippersBinder
			// 
			this._shippersBinder.DataSource = this._availableShippersCollection;
			// 
			// _availableShippersCollection
			// 
			this._availableShippersCollection.ActiveContext = null;
			this._availableShippersCollection.AllowEdit = true;
			this._availableShippersCollection.AllowNew = true;
			this._availableShippersCollection.AllowRemove = true;
			this._availableShippersCollection.Capacity = 256;
			this._availableShippersCollection.ConcurrencyPredicateFactoryToUse = null;
			this._availableShippersCollection.DoNotPerformAddIfPresent = false;
			this._availableShippersCollection.EntityFactoryToUse = new Northwind.DAL.FactoryClasses.ShipperEntityFactory();
			this._availableShippersCollection.IsReadOnly = false;
			// 
			// _ordersBinder
			// 
			this._ordersBinder.DataSource = this._ordersDesignerCollection;
			// 
			// _ordersDesignerCollection
			// 
			this._ordersDesignerCollection.ActiveContext = null;
			this._ordersDesignerCollection.AllowEdit = true;
			this._ordersDesignerCollection.AllowNew = true;
			this._ordersDesignerCollection.AllowRemove = true;
			this._ordersDesignerCollection.Capacity = 256;
			this._ordersDesignerCollection.ConcurrencyPredicateFactoryToUse = null;
			this._ordersDesignerCollection.DoNotPerformAddIfPresent = false;
			this._ordersDesignerCollection.EntityFactoryToUse = new Northwind.DAL.FactoryClasses.OrderEntityFactory();
			this._ordersDesignerCollection.IsReadOnly = false;
			// 
			// orderIdDataGridViewTextBoxColumn
			// 
			this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
			this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
			this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
			// 
			// customerIdDataGridViewTextBoxColumn
			// 
			this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
			this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
			this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
			// 
			// employeeIdDataGridViewTextBoxColumn
			// 
			this.employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
			this.employeeIdDataGridViewTextBoxColumn.DataSource = this._employeesBinder;
			this.employeeIdDataGridViewTextBoxColumn.DisplayMember = "FullName";
			this.employeeIdDataGridViewTextBoxColumn.HeaderText = "Employee";
			this.employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
			this.employeeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.employeeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.employeeIdDataGridViewTextBoxColumn.ValueMember = "EmployeeId";
			// 
			// orderDateDataGridViewTextBoxColumn
			// 
			this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
			this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
			this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
			// 
			// requiredDateDataGridViewTextBoxColumn
			// 
			this.requiredDateDataGridViewTextBoxColumn.DataPropertyName = "RequiredDate";
			this.requiredDateDataGridViewTextBoxColumn.HeaderText = "RequiredDate";
			this.requiredDateDataGridViewTextBoxColumn.Name = "requiredDateDataGridViewTextBoxColumn";
			// 
			// shippedDateDataGridViewTextBoxColumn
			// 
			this.shippedDateDataGridViewTextBoxColumn.DataPropertyName = "ShippedDate";
			this.shippedDateDataGridViewTextBoxColumn.HeaderText = "ShippedDate";
			this.shippedDateDataGridViewTextBoxColumn.Name = "shippedDateDataGridViewTextBoxColumn";
			// 
			// shipViaDataGridViewTextBoxColumn
			// 
			this.shipViaDataGridViewTextBoxColumn.DataPropertyName = "ShipVia";
			this.shipViaDataGridViewTextBoxColumn.DataSource = this._shippersBinder;
			this.shipViaDataGridViewTextBoxColumn.DisplayMember = "CompanyName";
			this.shipViaDataGridViewTextBoxColumn.HeaderText = "ShipVia";
			this.shipViaDataGridViewTextBoxColumn.Name = "shipViaDataGridViewTextBoxColumn";
			this.shipViaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.shipViaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.shipViaDataGridViewTextBoxColumn.ValueMember = "ShipperId";
			// 
			// freightDataGridViewTextBoxColumn
			// 
			this.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
			this.freightDataGridViewTextBoxColumn.HeaderText = "Freight";
			this.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
			// 
			// shipNameDataGridViewTextBoxColumn
			// 
			this.shipNameDataGridViewTextBoxColumn.DataPropertyName = "ShipName";
			this.shipNameDataGridViewTextBoxColumn.HeaderText = "ShipName";
			this.shipNameDataGridViewTextBoxColumn.Name = "shipNameDataGridViewTextBoxColumn";
			// 
			// shipAddressDataGridViewTextBoxColumn
			// 
			this.shipAddressDataGridViewTextBoxColumn.DataPropertyName = "ShipAddress";
			this.shipAddressDataGridViewTextBoxColumn.HeaderText = "ShipAddress";
			this.shipAddressDataGridViewTextBoxColumn.Name = "shipAddressDataGridViewTextBoxColumn";
			// 
			// shipCityDataGridViewTextBoxColumn
			// 
			this.shipCityDataGridViewTextBoxColumn.DataPropertyName = "ShipCity";
			this.shipCityDataGridViewTextBoxColumn.HeaderText = "ShipCity";
			this.shipCityDataGridViewTextBoxColumn.Name = "shipCityDataGridViewTextBoxColumn";
			// 
			// shipRegionDataGridViewTextBoxColumn
			// 
			this.shipRegionDataGridViewTextBoxColumn.DataPropertyName = "ShipRegion";
			this.shipRegionDataGridViewTextBoxColumn.HeaderText = "ShipRegion";
			this.shipRegionDataGridViewTextBoxColumn.Name = "shipRegionDataGridViewTextBoxColumn";
			// 
			// shipPostalCodeDataGridViewTextBoxColumn
			// 
			this.shipPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "ShipPostalCode";
			this.shipPostalCodeDataGridViewTextBoxColumn.HeaderText = "ShipPostalCode";
			this.shipPostalCodeDataGridViewTextBoxColumn.Name = "shipPostalCodeDataGridViewTextBoxColumn";
			// 
			// shipCountryDataGridViewTextBoxColumn
			// 
			this.shipCountryDataGridViewTextBoxColumn.DataPropertyName = "ShipCountry";
			this.shipCountryDataGridViewTextBoxColumn.HeaderText = "ShipCountry";
			this.shipCountryDataGridViewTextBoxColumn.Name = "shipCountryDataGridViewTextBoxColumn";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 445);
			this.Controls.Add(this._closeButton);
			this.Controls.Add(this._loadOrdersButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this._customersComboBox);
			this.Controls.Add(this._ordersGridView);
			this.Name = "MainForm";
			this.Text = "Complex binding example";
			((System.ComponentModel.ISupportInitialize)(this._ordersGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._employeesBinder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._shippersBinder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._ordersBinder)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button _closeButton;
		private System.Windows.Forms.Button _loadOrdersButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox _customersComboBox;
		private System.Windows.Forms.DataGridView _ordersGridView;
		private System.Windows.Forms.BindingSource _employeesBinder;
		private Northwind.DAL.HelperClasses.EntityCollection _availableEmployeeCollection;
		private System.Windows.Forms.BindingSource _shippersBinder;
		private Northwind.DAL.HelperClasses.EntityCollection _availableShippersCollection;
		private System.Windows.Forms.BindingSource _ordersBinder;
		private Northwind.DAL.HelperClasses.EntityCollection _ordersDesignerCollection;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn employeeIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn requiredDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shippedDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewComboBoxColumn shipViaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipCityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipRegionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipPostalCodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipCountryDataGridViewTextBoxColumn;
	}
}

