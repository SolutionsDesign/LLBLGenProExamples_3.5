﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: woensdag 14 maart 2012 14:02:51
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET35
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using SD.LLBLGen.Pro.Examples.Auditing;
using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;
using SD.LLBLGen.Pro.Examples.Auditing.RelationClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData: ILinqMetaData
	{
		#region Class Member Declarations
		private IDataAccessAdapter _adapterToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null)
		{
		}

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			_adapterToUse = adapterToUse;
			_customFunctionMappings = customFunctionMappings;
		}
	
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((SD.LLBLGen.Pro.Examples.Auditing.EntityType)typeOfEntity)
			{
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.AuditActionTypeEntity:
					toReturn = this.AuditActionType;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.AuditInfoEntity:
					toReturn = this.AuditInfo;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.CategoryEntity:
					toReturn = this.Category;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerEntity:
					toReturn = this.Customer;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerCustomerDemoEntity:
					toReturn = this.CustomerCustomerDemo;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.CustomerDemographyEntity:
					toReturn = this.CustomerDemography;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeEntity:
					toReturn = this.Employee;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.EmployeeTerritoryEntity:
					toReturn = this.EmployeeTerritory;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderEntity:
					toReturn = this.Order;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderAuditInfoEntity:
					toReturn = this.OrderAuditInfo;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.OrderDetailEntity:
					toReturn = this.OrderDetail;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.ProductEntity:
					toReturn = this.Product;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.RegionEntity:
					toReturn = this.Region;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.ShipperEntity:
					toReturn = this.Shipper;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.SupplierEntity:
					toReturn = this.Supplier;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.TerritoryEntity:
					toReturn = this.Territory;
					break;
				case SD.LLBLGen.Pro.Examples.Auditing.EntityType.UserEntity:
					toReturn = this.User;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query when targeting AuditActionTypeEntity instances in the database.</summary>
		public DataSource2<AuditActionTypeEntity> AuditActionType
		{
			get { return new DataSource2<AuditActionTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AuditInfoEntity instances in the database.</summary>
		public DataSource2<AuditInfoEntity> AuditInfo
		{
			get { return new DataSource2<AuditInfoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CategoryEntity instances in the database.</summary>
		public DataSource2<CategoryEntity> Category
		{
			get { return new DataSource2<CategoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerEntity instances in the database.</summary>
		public DataSource2<CustomerEntity> Customer
		{
			get { return new DataSource2<CustomerEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerCustomerDemoEntity instances in the database.</summary>
		public DataSource2<CustomerCustomerDemoEntity> CustomerCustomerDemo
		{
			get { return new DataSource2<CustomerCustomerDemoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerDemographyEntity instances in the database.</summary>
		public DataSource2<CustomerDemographyEntity> CustomerDemography
		{
			get { return new DataSource2<CustomerDemographyEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeEntity instances in the database.</summary>
		public DataSource2<EmployeeEntity> Employee
		{
			get { return new DataSource2<EmployeeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeTerritoryEntity instances in the database.</summary>
		public DataSource2<EmployeeTerritoryEntity> EmployeeTerritory
		{
			get { return new DataSource2<EmployeeTerritoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting OrderEntity instances in the database.</summary>
		public DataSource2<OrderEntity> Order
		{
			get { return new DataSource2<OrderEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting OrderAuditInfoEntity instances in the database.</summary>
		public DataSource2<OrderAuditInfoEntity> OrderAuditInfo
		{
			get { return new DataSource2<OrderAuditInfoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting OrderDetailEntity instances in the database.</summary>
		public DataSource2<OrderDetailEntity> OrderDetail
		{
			get { return new DataSource2<OrderDetailEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductEntity instances in the database.</summary>
		public DataSource2<ProductEntity> Product
		{
			get { return new DataSource2<ProductEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting RegionEntity instances in the database.</summary>
		public DataSource2<RegionEntity> Region
		{
			get { return new DataSource2<RegionEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ShipperEntity instances in the database.</summary>
		public DataSource2<ShipperEntity> Shipper
		{
			get { return new DataSource2<ShipperEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SupplierEntity instances in the database.</summary>
		public DataSource2<SupplierEntity> Supplier
		{
			get { return new DataSource2<SupplierEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting TerritoryEntity instances in the database.</summary>
		public DataSource2<TerritoryEntity> Territory
		{
			get { return new DataSource2<TerritoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting UserEntity instances in the database.</summary>
		public DataSource2<UserEntity> User
		{
			get { return new DataSource2<UserEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		
		#region Class Property Declarations
		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse
		{
			get { return _adapterToUse;}
			set { _adapterToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}