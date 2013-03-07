///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: woensdag 14 maart 2012 14:59:09
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.WCF.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass((6 + 3));
			InitCategoriesEntityMappings();
			InitCustomersEntityMappings();
			InitEmployeesEntityMappings();
			InitOrderDetailsEntityMappings();
			InitOrdersEntityMappings();
			InitProductsEntityMappings();
			InitInvoicesTypedViewMappings();
			InitProductsByCategoryTypedViewMappings();
			InitSalesByCategoryTypedViewMappings();
		}


		/// <summary>Inits CategoriesEntity's mappings</summary>
		private void InitCategoriesEntityMappings()
		{
			this.AddElementMapping( "CategoriesEntity", @"Northwind", @"dbo", "Categories", 4 );
			this.AddElementFieldMapping( "CategoriesEntity", "CategoryId", "CategoryID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "CategoriesEntity", "CategoryName", "CategoryName", false, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "CategoriesEntity", "Description", "Description", true, "NText", 1073741823, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "CategoriesEntity", "Picture", "Picture", true, "Image", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 3 );
		}
		/// <summary>Inits CustomersEntity's mappings</summary>
		private void InitCustomersEntityMappings()
		{
			this.AddElementMapping( "CustomersEntity", @"Northwind", @"dbo", "Customers", 11 );
			this.AddElementFieldMapping( "CustomersEntity", "Address", "Address", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "CustomersEntity", "City", "City", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "CustomersEntity", "CompanyName", "CompanyName", false, "NVarChar", 40, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "CustomersEntity", "ContactName", "ContactName", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "CustomersEntity", "ContactTitle", "ContactTitle", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "CustomersEntity", "Country", "Country", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "CustomersEntity", "CustomerId", "CustomerID", false, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "CustomersEntity", "Fax", "Fax", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "CustomersEntity", "Phone", "Phone", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "CustomersEntity", "PostalCode", "PostalCode", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "CustomersEntity", "Region", "Region", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 10 );
		}
		/// <summary>Inits EmployeesEntity's mappings</summary>
		private void InitEmployeesEntityMappings()
		{
			this.AddElementMapping( "EmployeesEntity", @"Northwind", @"dbo", "Employees", 18 );
			this.AddElementFieldMapping( "EmployeesEntity", "Address", "Address", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "EmployeesEntity", "BirthDate", "BirthDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "EmployeesEntity", "City", "City", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "EmployeesEntity", "Country", "Country", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "EmployeesEntity", "EmployeeId", "EmployeeID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "EmployeesEntity", "Extension", "Extension", true, "NVarChar", 4, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "EmployeesEntity", "FirstName", "FirstName", false, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "EmployeesEntity", "HireDate", "HireDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 7 );
			this.AddElementFieldMapping( "EmployeesEntity", "HomePhone", "HomePhone", true, "NVarChar", 24, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "EmployeesEntity", "LastName", "LastName", false, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "EmployeesEntity", "Notes", "Notes", true, "NText", 1073741823, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "EmployeesEntity", "Photo", "Photo", true, "Image", 2147483647, 0, 0, false, "", null, typeof(System.Byte[]), 11 );
			this.AddElementFieldMapping( "EmployeesEntity", "PhotoPath", "PhotoPath", true, "NVarChar", 255, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "EmployeesEntity", "PostalCode", "PostalCode", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "EmployeesEntity", "Region", "Region", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "EmployeesEntity", "ReportsTo", "ReportsTo", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 15 );
			this.AddElementFieldMapping( "EmployeesEntity", "Title", "Title", true, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 16 );
			this.AddElementFieldMapping( "EmployeesEntity", "TitleOfCourtesy", "TitleOfCourtesy", true, "NVarChar", 25, 0, 0, false, "", null, typeof(System.String), 17 );
		}
		/// <summary>Inits OrderDetailsEntity's mappings</summary>
		private void InitOrderDetailsEntityMappings()
		{
			this.AddElementMapping( "OrderDetailsEntity", @"Northwind", @"dbo", "Order Details", 5 );
			this.AddElementFieldMapping( "OrderDetailsEntity", "Discount", "Discount", false, "Real", 0, 0, 24, false, "", null, typeof(System.Single), 0 );
			this.AddElementFieldMapping( "OrderDetailsEntity", "OrderId", "OrderID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "OrderDetailsEntity", "ProductId", "ProductID", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "OrderDetailsEntity", "Quantity", "Quantity", false, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "OrderDetailsEntity", "UnitPrice", "UnitPrice", false, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 4 );
		}
		/// <summary>Inits OrdersEntity's mappings</summary>
		private void InitOrdersEntityMappings()
		{
			this.AddElementMapping( "OrdersEntity", @"Northwind", @"dbo", "Orders", 14 );
			this.AddElementFieldMapping( "OrdersEntity", "CustomerId", "CustomerID", true, "NChar", 5, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "OrdersEntity", "EmployeeId", "EmployeeID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 1 );
			this.AddElementFieldMapping( "OrdersEntity", "Freight", "Freight", true, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 2 );
			this.AddElementFieldMapping( "OrdersEntity", "OrderDate", "OrderDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "OrdersEntity", "OrderId", "OrderID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 4 );
			this.AddElementFieldMapping( "OrdersEntity", "RequiredDate", "RequiredDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 5 );
			this.AddElementFieldMapping( "OrdersEntity", "ShipAddress", "ShipAddress", true, "NVarChar", 60, 0, 0, false, "", null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "OrdersEntity", "ShipCity", "ShipCity", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "OrdersEntity", "ShipCountry", "ShipCountry", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "OrdersEntity", "ShipName", "ShipName", true, "NVarChar", 40, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "OrdersEntity", "ShippedDate", "ShippedDate", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 10 );
			this.AddElementFieldMapping( "OrdersEntity", "ShipPostalCode", "ShipPostalCode", true, "NVarChar", 10, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "OrdersEntity", "ShipRegion", "ShipRegion", true, "NVarChar", 15, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "OrdersEntity", "ShipVia", "ShipVia", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 13 );
		}
		/// <summary>Inits ProductsEntity's mappings</summary>
		private void InitProductsEntityMappings()
		{
			this.AddElementMapping( "ProductsEntity", @"Northwind", @"dbo", "Products", 10 );
			this.AddElementFieldMapping( "ProductsEntity", "CategoryId", "CategoryID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "ProductsEntity", "Discontinued", "Discontinued", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1 );
			this.AddElementFieldMapping( "ProductsEntity", "ProductId", "ProductID", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2 );
			this.AddElementFieldMapping( "ProductsEntity", "ProductName", "ProductName", false, "NVarChar", 40, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "ProductsEntity", "QuantityPerUnit", "QuantityPerUnit", true, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "ProductsEntity", "ReorderLevel", "ReorderLevel", true, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 5 );
			this.AddElementFieldMapping( "ProductsEntity", "SupplierId", "SupplierID", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "ProductsEntity", "UnitPrice", "UnitPrice", true, "Money", 0, 4, 19, false, "", null, typeof(System.Decimal), 7 );
			this.AddElementFieldMapping( "ProductsEntity", "UnitsInStock", "UnitsInStock", true, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 8 );
			this.AddElementFieldMapping( "ProductsEntity", "UnitsOnOrder", "UnitsOnOrder", true, "SmallInt", 0, 0, 5, false, "", null, typeof(System.Int16), 9 );
		}

		/// <summary>Inits View's mappings</summary>
		private void InitInvoicesTypedViewMappings()
		{
			this.AddElementMapping( "InvoicesTypedView", @"Northwind", @"dbo", "Invoices", 26 );
			this.AddElementFieldMapping( "InvoicesTypedView", "ShipName", "ShipName", false, "NVarChar", 40, 0, 0,false, string.Empty, null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "InvoicesTypedView", "ShipAddress", "ShipAddress", false, "NVarChar", 60, 0, 0,false, string.Empty, null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "InvoicesTypedView", "ShipCity", "ShipCity", false, "NVarChar", 15, 0, 0,false, string.Empty, null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "InvoicesTypedView", "ShipRegion", "ShipRegion", false, "NVarChar", 15, 0, 0,false, string.Empty, null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "InvoicesTypedView", "ShipPostalCode", "ShipPostalCode", false, "NVarChar", 10, 0, 0,false, string.Empty, null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "InvoicesTypedView", "ShipCountry", "ShipCountry", false, "NVarChar", 15, 0, 0,false, string.Empty, null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "InvoicesTypedView", "CustomerId", "CustomerID", false, "NChar", 5, 0, 0,false, string.Empty, null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "InvoicesTypedView", "CustomerName", "CustomerName", false, "NVarChar", 40, 0, 0,false, string.Empty, null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "InvoicesTypedView", "Address", "Address", false, "NVarChar", 60, 0, 0,false, string.Empty, null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "InvoicesTypedView", "City", "City", false, "NVarChar", 15, 0, 0,false, string.Empty, null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "InvoicesTypedView", "Region", "Region", false, "NVarChar", 15, 0, 0,false, string.Empty, null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "InvoicesTypedView", "PostalCode", "PostalCode", false, "NVarChar", 10, 0, 0,false, string.Empty, null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "InvoicesTypedView", "Country", "Country", false, "NVarChar", 15, 0, 0,false, string.Empty, null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "InvoicesTypedView", "Salesperson", "Salesperson", false, "NVarChar", 31, 0, 0,false, string.Empty, null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "InvoicesTypedView", "OrderId", "OrderID", false, "Int", 0, 0, 10,false, string.Empty, null, typeof(System.Int32), 14 );
			this.AddElementFieldMapping( "InvoicesTypedView", "OrderDate", "OrderDate", false, "DateTime", 0, 0, 0,false, string.Empty, null, typeof(System.DateTime), 15 );
			this.AddElementFieldMapping( "InvoicesTypedView", "RequiredDate", "RequiredDate", false, "DateTime", 0, 0, 0,false, string.Empty, null, typeof(System.DateTime), 16 );
			this.AddElementFieldMapping( "InvoicesTypedView", "ShippedDate", "ShippedDate", false, "DateTime", 0, 0, 0,false, string.Empty, null, typeof(System.DateTime), 17 );
			this.AddElementFieldMapping( "InvoicesTypedView", "ShipperName", "ShipperName", false, "NVarChar", 40, 0, 0,false, string.Empty, null, typeof(System.String), 18 );
			this.AddElementFieldMapping( "InvoicesTypedView", "ProductId", "ProductID", false, "Int", 0, 0, 10,false, string.Empty, null, typeof(System.Int32), 19 );
			this.AddElementFieldMapping( "InvoicesTypedView", "ProductName", "ProductName", false, "NVarChar", 40, 0, 0,false, string.Empty, null, typeof(System.String), 20 );
			this.AddElementFieldMapping( "InvoicesTypedView", "UnitPrice", "UnitPrice", false, "Money", 0, 4, 19,false, string.Empty, null, typeof(System.Decimal), 21 );
			this.AddElementFieldMapping( "InvoicesTypedView", "Quantity", "Quantity", false, "SmallInt", 0, 0, 5,false, string.Empty, null, typeof(System.Int16), 22 );
			this.AddElementFieldMapping( "InvoicesTypedView", "Discount", "Discount", false, "Real", 0, 0, 24,false, string.Empty, null, typeof(System.Single), 23 );
			this.AddElementFieldMapping( "InvoicesTypedView", "ExtendedPrice", "ExtendedPrice", false, "Money", 0, 4, 19,false, string.Empty, null, typeof(System.Decimal), 24 );
			this.AddElementFieldMapping( "InvoicesTypedView", "Freight", "Freight", false, "Money", 0, 4, 19,false, string.Empty, null, typeof(System.Decimal), 25 );
		}
		/// <summary>Inits View's mappings</summary>
		private void InitProductsByCategoryTypedViewMappings()
		{
			this.AddElementMapping( "ProductsByCategoryTypedView", @"Northwind", @"dbo", "Products by Category", 5 );
			this.AddElementFieldMapping( "ProductsByCategoryTypedView", "CategoryName", "CategoryName", false, "NVarChar", 15, 0, 0,false, string.Empty, null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "ProductsByCategoryTypedView", "ProductName", "ProductName", false, "NVarChar", 40, 0, 0,false, string.Empty, null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "ProductsByCategoryTypedView", "QuantityPerUnit", "QuantityPerUnit", false, "NVarChar", 20, 0, 0,false, string.Empty, null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "ProductsByCategoryTypedView", "UnitsInStock", "UnitsInStock", false, "SmallInt", 0, 0, 5,false, string.Empty, null, typeof(System.Int16), 3 );
			this.AddElementFieldMapping( "ProductsByCategoryTypedView", "Discontinued", "Discontinued", false, "Bit", 0, 0, 0,false, string.Empty, null, typeof(System.Boolean), 4 );
		}
		/// <summary>Inits View's mappings</summary>
		private void InitSalesByCategoryTypedViewMappings()
		{
			this.AddElementMapping( "SalesByCategoryTypedView", @"Northwind", @"dbo", "Sales by Category", 4 );
			this.AddElementFieldMapping( "SalesByCategoryTypedView", "CategoryId", "CategoryID", false, "Int", 0, 0, 10,false, string.Empty, null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "SalesByCategoryTypedView", "CategoryName", "CategoryName", false, "NVarChar", 15, 0, 0,false, string.Empty, null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "SalesByCategoryTypedView", "ProductName", "ProductName", false, "NVarChar", 40, 0, 0,false, string.Empty, null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "SalesByCategoryTypedView", "ProductSales", "ProductSales", false, "Money", 0, 4, 19,false, string.Empty, null, typeof(System.Decimal), 3 );
		}
	}
}