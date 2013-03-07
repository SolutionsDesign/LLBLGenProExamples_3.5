///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: woensdag 14 maart 2012 14:59:08
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.WCF.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (6 + 3));
			InitCategoriesEntityInfos();
			InitCustomersEntityInfos();
			InitEmployeesEntityInfos();
			InitOrderDetailsEntityInfos();
			InitOrdersEntityInfos();
			InitProductsEntityInfos();
			InitInvoicesTypedViewInfos();
			InitProductsByCategoryTypedViewInfos();
			InitSalesByCategoryTypedViewInfos();
			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits CategoriesEntity's FieldInfo objects</summary>
		private void InitCategoriesEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CategoriesFieldIndex), "CategoriesEntity");
			this.AddElementFieldInfo("CategoriesEntity", "CategoryId", typeof(System.Int32), true, false, true, false,  (int)CategoriesFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("CategoriesEntity", "CategoryName", typeof(System.String), false, false, false, false,  (int)CategoriesFieldIndex.CategoryName, 15, 0, 0);
			this.AddElementFieldInfo("CategoriesEntity", "Description", typeof(System.String), false, false, false, true,  (int)CategoriesFieldIndex.Description, 1073741823, 0, 0);
			this.AddElementFieldInfo("CategoriesEntity", "Picture", typeof(System.Byte[]), false, false, false, true,  (int)CategoriesFieldIndex.Picture, 2147483647, 0, 0);
		}
		/// <summary>Inits CustomersEntity's FieldInfo objects</summary>
		private void InitCustomersEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomersFieldIndex), "CustomersEntity");
			this.AddElementFieldInfo("CustomersEntity", "Address", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "City", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "CompanyName", typeof(System.String), false, false, false, false,  (int)CustomersFieldIndex.CompanyName, 40, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "ContactName", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.ContactName, 30, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "ContactTitle", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.ContactTitle, 30, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "Country", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "CustomerId", typeof(System.String), true, false, false, false,  (int)CustomersFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "Fax", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.Fax, 24, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "Phone", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.Phone, 24, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "PostalCode", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("CustomersEntity", "Region", typeof(System.String), false, false, false, true,  (int)CustomersFieldIndex.Region, 15, 0, 0);
		}
		/// <summary>Inits EmployeesEntity's FieldInfo objects</summary>
		private void InitEmployeesEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeesFieldIndex), "EmployeesEntity");
			this.AddElementFieldInfo("EmployeesEntity", "Address", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "BirthDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeesFieldIndex.BirthDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "City", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "Country", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "EmployeeId", typeof(System.Int32), true, false, true, false,  (int)EmployeesFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("EmployeesEntity", "Extension", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.Extension, 4, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)EmployeesFieldIndex.FirstName, 10, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "HireDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeesFieldIndex.HireDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "HomePhone", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.HomePhone, 24, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "LastName", typeof(System.String), false, false, false, false,  (int)EmployeesFieldIndex.LastName, 20, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "Notes", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.Notes, 1073741823, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "Photo", typeof(System.Byte[]), false, false, false, true,  (int)EmployeesFieldIndex.Photo, 2147483647, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "PhotoPath", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.PhotoPath, 255, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "PostalCode", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "Region", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.Region, 15, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "ReportsTo", typeof(Nullable<System.Int32>), false, true, false, true,  (int)EmployeesFieldIndex.ReportsTo, 0, 0, 10);
			this.AddElementFieldInfo("EmployeesEntity", "Title", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.Title, 30, 0, 0);
			this.AddElementFieldInfo("EmployeesEntity", "TitleOfCourtesy", typeof(System.String), false, false, false, true,  (int)EmployeesFieldIndex.TitleOfCourtesy, 25, 0, 0);
		}
		/// <summary>Inits OrderDetailsEntity's FieldInfo objects</summary>
		private void InitOrderDetailsEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrderDetailsFieldIndex), "OrderDetailsEntity");
			this.AddElementFieldInfo("OrderDetailsEntity", "Discount", typeof(System.Single), false, false, false, false,  (int)OrderDetailsFieldIndex.Discount, 0, 0, 24);
			this.AddElementFieldInfo("OrderDetailsEntity", "OrderId", typeof(System.Int32), true, true, false, false,  (int)OrderDetailsFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("OrderDetailsEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)OrderDetailsFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("OrderDetailsEntity", "Quantity", typeof(System.Int16), false, false, false, false,  (int)OrderDetailsFieldIndex.Quantity, 0, 0, 5);
			this.AddElementFieldInfo("OrderDetailsEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)OrderDetailsFieldIndex.UnitPrice, 0, 4, 19);
		}
		/// <summary>Inits OrdersEntity's FieldInfo objects</summary>
		private void InitOrdersEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(OrdersFieldIndex), "OrdersEntity");
			this.AddElementFieldInfo("OrdersEntity", "CustomerId", typeof(System.String), false, true, false, true,  (int)OrdersFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "EmployeeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)OrdersFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("OrdersEntity", "Freight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)OrdersFieldIndex.Freight, 0, 4, 19);
			this.AddElementFieldInfo("OrdersEntity", "OrderDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrdersFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "OrderId", typeof(System.Int32), true, false, true, false,  (int)OrdersFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("OrdersEntity", "RequiredDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrdersFieldIndex.RequiredDate, 0, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipAddress", typeof(System.String), false, false, false, true,  (int)OrdersFieldIndex.ShipAddress, 60, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipCity", typeof(System.String), false, false, false, true,  (int)OrdersFieldIndex.ShipCity, 15, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipCountry", typeof(System.String), false, false, false, true,  (int)OrdersFieldIndex.ShipCountry, 15, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipName", typeof(System.String), false, false, false, true,  (int)OrdersFieldIndex.ShipName, 40, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShippedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)OrdersFieldIndex.ShippedDate, 0, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipPostalCode", typeof(System.String), false, false, false, true,  (int)OrdersFieldIndex.ShipPostalCode, 10, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipRegion", typeof(System.String), false, false, false, true,  (int)OrdersFieldIndex.ShipRegion, 15, 0, 0);
			this.AddElementFieldInfo("OrdersEntity", "ShipVia", typeof(Nullable<System.Int32>), false, false, false, true,  (int)OrdersFieldIndex.ShipVia, 0, 0, 10);
		}
		/// <summary>Inits ProductsEntity's FieldInfo objects</summary>
		private void InitProductsEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductsFieldIndex), "ProductsEntity");
			this.AddElementFieldInfo("ProductsEntity", "CategoryId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductsFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("ProductsEntity", "Discontinued", typeof(System.Boolean), false, false, false, false,  (int)ProductsFieldIndex.Discontinued, 0, 0, 0);
			this.AddElementFieldInfo("ProductsEntity", "ProductId", typeof(System.Int32), true, false, true, false,  (int)ProductsFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductsEntity", "ProductName", typeof(System.String), false, false, false, false,  (int)ProductsFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("ProductsEntity", "QuantityPerUnit", typeof(System.String), false, false, false, true,  (int)ProductsFieldIndex.QuantityPerUnit, 20, 0, 0);
			this.AddElementFieldInfo("ProductsEntity", "ReorderLevel", typeof(Nullable<System.Int16>), false, false, false, true,  (int)ProductsFieldIndex.ReorderLevel, 0, 0, 5);
			this.AddElementFieldInfo("ProductsEntity", "SupplierId", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ProductsFieldIndex.SupplierId, 0, 0, 10);
			this.AddElementFieldInfo("ProductsEntity", "UnitPrice", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductsFieldIndex.UnitPrice, 0, 4, 19);
			this.AddElementFieldInfo("ProductsEntity", "UnitsInStock", typeof(Nullable<System.Int16>), false, false, false, true,  (int)ProductsFieldIndex.UnitsInStock, 0, 0, 5);
			this.AddElementFieldInfo("ProductsEntity", "UnitsOnOrder", typeof(Nullable<System.Int16>), false, false, false, true,  (int)ProductsFieldIndex.UnitsOnOrder, 0, 0, 5);
		}

		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitInvoicesTypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(InvoicesFieldIndex), "InvoicesTypedView");
			this.AddElementFieldInfo("InvoicesTypedView", "ShipName", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipName, 40, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShipAddress", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipAddress, 60, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShipCity", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipCity, 15, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShipRegion", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipRegion, 15, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShipPostalCode", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipPostalCode, 10, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShipCountry", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipCountry, 15, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "CustomerId", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.CustomerId, 5, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "CustomerName", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.CustomerName, 40, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "Address", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.Address, 60, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "City", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.City, 15, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "Region", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.Region, 15, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "PostalCode", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.PostalCode, 10, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "Country", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.Country, 15, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "Salesperson", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.Salesperson, 31, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "OrderId", typeof(System.Int32), false, false, true, false, (int)InvoicesFieldIndex.OrderId, 0, 0, 10);
			this.AddElementFieldInfo("InvoicesTypedView", "OrderDate", typeof(System.DateTime), false, false, true, false, (int)InvoicesFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "RequiredDate", typeof(System.DateTime), false, false, true, false, (int)InvoicesFieldIndex.RequiredDate, 0, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShippedDate", typeof(System.DateTime), false, false, true, false, (int)InvoicesFieldIndex.ShippedDate, 0, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ShipperName", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ShipperName, 40, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "ProductId", typeof(System.Int32), false, false, true, false, (int)InvoicesFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("InvoicesTypedView", "ProductName", typeof(System.String), false, false, true, false, (int)InvoicesFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("InvoicesTypedView", "UnitPrice", typeof(System.Decimal), false, false, true, false, (int)InvoicesFieldIndex.UnitPrice, 0, 4, 19);
			this.AddElementFieldInfo("InvoicesTypedView", "Quantity", typeof(System.Int16), false, false, true, false, (int)InvoicesFieldIndex.Quantity, 0, 0, 5);
			this.AddElementFieldInfo("InvoicesTypedView", "Discount", typeof(System.Single), false, false, true, false, (int)InvoicesFieldIndex.Discount, 0, 0, 24);
			this.AddElementFieldInfo("InvoicesTypedView", "ExtendedPrice", typeof(System.Decimal), false, false, true, false, (int)InvoicesFieldIndex.ExtendedPrice, 0, 4, 19);
			this.AddElementFieldInfo("InvoicesTypedView", "Freight", typeof(System.Decimal), false, false, true, false, (int)InvoicesFieldIndex.Freight, 0, 4, 19);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitProductsByCategoryTypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductsByCategoryFieldIndex), "ProductsByCategoryTypedView");
			this.AddElementFieldInfo("ProductsByCategoryTypedView", "CategoryName", typeof(System.String), false, false, true, false, (int)ProductsByCategoryFieldIndex.CategoryName, 15, 0, 0);
			this.AddElementFieldInfo("ProductsByCategoryTypedView", "ProductName", typeof(System.String), false, false, true, false, (int)ProductsByCategoryFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("ProductsByCategoryTypedView", "QuantityPerUnit", typeof(System.String), false, false, true, false, (int)ProductsByCategoryFieldIndex.QuantityPerUnit, 20, 0, 0);
			this.AddElementFieldInfo("ProductsByCategoryTypedView", "UnitsInStock", typeof(System.Int16), false, false, true, false, (int)ProductsByCategoryFieldIndex.UnitsInStock, 0, 0, 5);
			this.AddElementFieldInfo("ProductsByCategoryTypedView", "Discontinued", typeof(System.Boolean), false, false, true, false, (int)ProductsByCategoryFieldIndex.Discontinued, 0, 0, 0);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitSalesByCategoryTypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesByCategoryFieldIndex), "SalesByCategoryTypedView");
			this.AddElementFieldInfo("SalesByCategoryTypedView", "CategoryId", typeof(System.Int32), false, false, true, false, (int)SalesByCategoryFieldIndex.CategoryId, 0, 0, 10);
			this.AddElementFieldInfo("SalesByCategoryTypedView", "CategoryName", typeof(System.String), false, false, true, false, (int)SalesByCategoryFieldIndex.CategoryName, 15, 0, 0);
			this.AddElementFieldInfo("SalesByCategoryTypedView", "ProductName", typeof(System.String), false, false, true, false, (int)SalesByCategoryFieldIndex.ProductName, 40, 0, 0);
			this.AddElementFieldInfo("SalesByCategoryTypedView", "ProductSales", typeof(System.Decimal), false, false, true, false, (int)SalesByCategoryFieldIndex.ProductSales, 0, 4, 19);
		}		
	}
}




