///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: woensdag 14 maart 2012 14:24:39
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;
using Northwind.DAL;
using Northwind.DAL.HelperClasses;
using Northwind.DAL.DaoClasses;
using Northwind.DAL.EntityClasses;
using Northwind.DAL.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;


namespace Northwind.DAL.TypedViewClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Typed datatable for the view 'AlphabeticalListOfProduct'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class AlphabeticalListOfProductTypedView : TypedViewBase<AlphabeticalListOfProductRow>, ITypedView
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnProductId;
		private DataColumn _columnProductName;
		private DataColumn _columnSupplierId;
		private DataColumn _columnCategoryId;
		private DataColumn _columnQuantityPerUnit;
		private DataColumn _columnUnitPrice;
		private DataColumn _columnUnitsInStock;
		private DataColumn _columnUnitsOnOrder;
		private DataColumn _columnReorderLevel;
		private DataColumn _columnDiscontinued;
		private DataColumn _columnCategoryName;
		
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		/// <summary>
		/// The amount of fields in the resultset.
		/// </summary>
		private const int AmountOfFields = 11;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static AlphabeticalListOfProductTypedView()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AlphabeticalListOfProductTypedView():base("AlphabeticalListOfProduct")
		{
			InitClass();
		}
		
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AlphabeticalListOfProductTypedView(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}

		/// <summary> Fills itself with data. it builds a dynamic query and loads itself with that query. 
		/// Will use no sort filter, no select filter, will allow duplicate rows and will not limit the amount of rows returned</summary>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill()
		{
			return Fill(0, null, true, null, null, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query. Will not use a filter, will allow duplicate rows.</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, true, null, null, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query. Will not use a filter.</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, null, null, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, null, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		/// used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter, ITransaction transactionToUse)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, transactionToUse, null, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		/// used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <param name="groupByClause">GroupByCollection with fields to group by on.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter, ITransaction transactionToUse, 	IGroupByCollection groupByClause)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, transactionToUse, groupByClause, 0, 0);
		}

		/// <summary>Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter</summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate expression to filter on the rows inserted in this TypedView object.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <param name="groupByClause">GroupByCollection with fields to group by on.</param>
		/// <param name="pageNumber">The page number to retrieve.</param>
		/// <param name="pageSize">The page size of the page to retrieve.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public virtual bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter, ITransaction transactionToUse, 
								 IGroupByCollection groupByClause, int pageNumber, int pageSize)
		{
			IEntityFields fieldsInResultset = GetFields();
			// __LLBLGENPRO_USER_CODE_REGION_START AdditionalFields
			// be sure to call fieldsInResultset.Expand(number of new fields) first. 
			// __LLBLGENPRO_USER_CODE_REGION_END
			return DAOFactory.CreateTypedListDAO().GetMultiAsDataTable(fieldsInResultset, this, maxNumberOfItemsToReturn, sortClauses, selectFilter, null, allowDuplicates, groupByClause, transactionToUse, pageNumber, pageSize);
		}

		/// <summary>Gets the fields of this typed view</summary>
		/// <returns>IEntityFields object</returns>
		public virtual IEntityFields GetFields()
		{
			return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.AlphabeticalListOfProductTypedView);
		}
		
		/// <summary>Gets the amount of rows in the database for this typed view, not skipping duplicates</summary>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public int GetDbCount()
		{
			return GetDbCount(true, null);
		}
		
		/// <summary>Gets the amount of rows in the database for this typed view.</summary>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public int GetDbCount(bool allowDuplicates)
		{
			return GetDbCount(allowDuplicates, null);
		}
		
		/// <summary>Gets the amount of rows in the database for this typed list.</summary>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="filter">The filter to apply for the count retrieval</param>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public int GetDbCount(bool allowDuplicates, IPredicateExpression filter)
		{
			return GetDbCount(allowDuplicates, filter, null);
		}

		/// <summary>Gets the amount of rows in the database for this typed list.</summary>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="filter">The filter to apply for the count retrieval</param>
		/// <param name="groupByClause">group by clause to embed in the query</param>
		/// <returns>the number of rows in the set defined by the passed in query elements</returns>
		public virtual int GetDbCount(bool allowDuplicates, IPredicateExpression filter, GroupByCollection groupByClause)
		{
			IEntityFields fieldsInResultset = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.AlphabeticalListOfProductTypedView);
			return DAOFactory.CreateTypedListDAO().GetDbCount(fieldsInResultset, null, filter, null, groupByClause, allowDuplicates);
		}

		/// <summary>Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.</summary>
		/// <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		/// <returns>the new typed datarow</returns>
		protected override DataRow NewRowFromBuilder(DataRowBuilder rowBuilder) 
		{
			return new AlphabeticalListOfProductRow(rowBuilder);
		}

		/// <summary>Initializes the hashtables for the typed view type and typed view field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();
			Hashtable fieldHashtable;
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ProductName", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("SupplierId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("CategoryId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("QuantityPerUnit", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("UnitPrice", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("UnitsInStock", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("UnitsOnOrder", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ReorderLevel", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Discontinued", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("CategoryName", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		protected override void InitClass()
		{
			TableName = "AlphabeticalListOfProduct";		
			_columnProductId = GeneralUtils.CreateTypedDataTableColumn("ProductId", @"ProductId", typeof(System.Int32), this.Columns);
			_columnProductName = GeneralUtils.CreateTypedDataTableColumn("ProductName", @"ProductName", typeof(System.String), this.Columns);
			_columnSupplierId = GeneralUtils.CreateTypedDataTableColumn("SupplierId", @"SupplierId", typeof(System.Int32), this.Columns);
			_columnCategoryId = GeneralUtils.CreateTypedDataTableColumn("CategoryId", @"CategoryId", typeof(System.Int32), this.Columns);
			_columnQuantityPerUnit = GeneralUtils.CreateTypedDataTableColumn("QuantityPerUnit", @"QuantityPerUnit", typeof(System.String), this.Columns);
			_columnUnitPrice = GeneralUtils.CreateTypedDataTableColumn("UnitPrice", @"UnitPrice", typeof(System.Decimal), this.Columns);
			_columnUnitsInStock = GeneralUtils.CreateTypedDataTableColumn("UnitsInStock", @"UnitsInStock", typeof(System.Int16), this.Columns);
			_columnUnitsOnOrder = GeneralUtils.CreateTypedDataTableColumn("UnitsOnOrder", @"UnitsOnOrder", typeof(System.Int16), this.Columns);
			_columnReorderLevel = GeneralUtils.CreateTypedDataTableColumn("ReorderLevel", @"ReorderLevel", typeof(System.Int16), this.Columns);
			_columnDiscontinued = GeneralUtils.CreateTypedDataTableColumn("Discontinued", @"Discontinued", typeof(System.Boolean), this.Columns);
			_columnCategoryName = GeneralUtils.CreateTypedDataTableColumn("CategoryName", @"CategoryName", typeof(System.String), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnProductId = this.Columns["ProductId"];
			_columnProductName = this.Columns["ProductName"];
			_columnSupplierId = this.Columns["SupplierId"];
			_columnCategoryId = this.Columns["CategoryId"];
			_columnQuantityPerUnit = this.Columns["QuantityPerUnit"];
			_columnUnitPrice = this.Columns["UnitPrice"];
			_columnUnitsInStock = this.Columns["UnitsInStock"];
			_columnUnitsOnOrder = this.Columns["UnitsOnOrder"];
			_columnReorderLevel = this.Columns["ReorderLevel"];
			_columnDiscontinued = this.Columns["Discontinued"];
			_columnCategoryName = this.Columns["CategoryName"];
			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			AlphabeticalListOfProductTypedView cloneToReturn = ((AlphabeticalListOfProductTypedView)(base.Clone()));
			cloneToReturn.InitMembers();
			return cloneToReturn;
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new AlphabeticalListOfProductTypedView();
		}
#endif

		#region Class Property Declarations
		/// <summary>The custom properties for this TypedView type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary>The custom properties for the type of this TypedView instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[System.ComponentModel.Browsable(false)]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return AlphabeticalListOfProductTypedView.CustomProperties;}
		}

		/// <summary>The custom properties for the fields of this TypedView type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary>The custom properties for the fields of the type of this TypedView instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[System.ComponentModel.Browsable(false)]
		public virtual Hashtable FieldsCustomPropertiesOfType
		{
			get { return AlphabeticalListOfProductTypedView.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedView field ProductId</summary>
		internal DataColumn ProductIdColumn 
		{
			get { return _columnProductId; }
		}

		/// <summary>Returns the column object belonging to the TypedView field ProductName</summary>
		internal DataColumn ProductNameColumn 
		{
			get { return _columnProductName; }
		}

		/// <summary>Returns the column object belonging to the TypedView field SupplierId</summary>
		internal DataColumn SupplierIdColumn 
		{
			get { return _columnSupplierId; }
		}

		/// <summary>Returns the column object belonging to the TypedView field CategoryId</summary>
		internal DataColumn CategoryIdColumn 
		{
			get { return _columnCategoryId; }
		}

		/// <summary>Returns the column object belonging to the TypedView field QuantityPerUnit</summary>
		internal DataColumn QuantityPerUnitColumn 
		{
			get { return _columnQuantityPerUnit; }
		}

		/// <summary>Returns the column object belonging to the TypedView field UnitPrice</summary>
		internal DataColumn UnitPriceColumn 
		{
			get { return _columnUnitPrice; }
		}

		/// <summary>Returns the column object belonging to the TypedView field UnitsInStock</summary>
		internal DataColumn UnitsInStockColumn 
		{
			get { return _columnUnitsInStock; }
		}

		/// <summary>Returns the column object belonging to the TypedView field UnitsOnOrder</summary>
		internal DataColumn UnitsOnOrderColumn 
		{
			get { return _columnUnitsOnOrder; }
		}

		/// <summary>Returns the column object belonging to the TypedView field ReorderLevel</summary>
		internal DataColumn ReorderLevelColumn 
		{
			get { return _columnReorderLevel; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Discontinued</summary>
		internal DataColumn DiscontinuedColumn 
		{
			get { return _columnDiscontinued; }
		}

		/// <summary>Returns the column object belonging to the TypedView field CategoryName</summary>
		internal DataColumn CategoryNameColumn 
		{
			get { return _columnCategoryName; }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalColumnProperties
		// __LLBLGENPRO_USER_CODE_REGION_END
 		#endregion
		
		#region Custom Typed View code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included Code

		#endregion
	}


	/// <summary>Typed datarow for the typed datatable AlphabeticalListOfProduct</summary>
	public partial class AlphabeticalListOfProductRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AlphabeticalListOfProductTypedView	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal AlphabeticalListOfProductRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((AlphabeticalListOfProductTypedView)(this.Table));
		}

		#region Class Property Declarations

		/// <summary>Gets / sets the value of the TypedView field ProductId<br/><br/></summary>
		/// <remarks>Mapped on view field: "Alphabetical list of products"."ProductID"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 ProductId 
		{
			get { return IsProductIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.ProductIdColumn]; }
			set { this[_parent.ProductIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ProductId is NULL, false otherwise.</summary>
		public bool IsProductIdNull() 
		{
			return IsNull(_parent.ProductIdColumn);
		}

		/// <summary>Sets the TypedView field ProductId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetProductIdNull() 
		{
			this[_parent.ProductIdColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field ProductName<br/><br/></summary>
		/// <remarks>Mapped on view field: "Alphabetical list of products"."ProductName"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 40</remarks>
		public System.String ProductName 
		{
			get { return IsProductNameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.ProductNameColumn]; }
			set { this[_parent.ProductNameColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ProductName is NULL, false otherwise.</summary>
		public bool IsProductNameNull() 
		{
			return IsNull(_parent.ProductNameColumn);
		}

		/// <summary>Sets the TypedView field ProductName to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetProductNameNull() 
		{
			this[_parent.ProductNameColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field SupplierId<br/><br/></summary>
		/// <remarks>Mapped on view field: "Alphabetical list of products"."SupplierID"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 SupplierId 
		{
			get { return IsSupplierIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.SupplierIdColumn]; }
			set { this[_parent.SupplierIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field SupplierId is NULL, false otherwise.</summary>
		public bool IsSupplierIdNull() 
		{
			return IsNull(_parent.SupplierIdColumn);
		}

		/// <summary>Sets the TypedView field SupplierId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetSupplierIdNull() 
		{
			this[_parent.SupplierIdColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field CategoryId<br/><br/></summary>
		/// <remarks>Mapped on view field: "Alphabetical list of products"."CategoryID"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 CategoryId 
		{
			get { return IsCategoryIdNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.CategoryIdColumn]; }
			set { this[_parent.CategoryIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field CategoryId is NULL, false otherwise.</summary>
		public bool IsCategoryIdNull() 
		{
			return IsNull(_parent.CategoryIdColumn);
		}

		/// <summary>Sets the TypedView field CategoryId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCategoryIdNull() 
		{
			this[_parent.CategoryIdColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field QuantityPerUnit<br/><br/></summary>
		/// <remarks>Mapped on view field: "Alphabetical list of products"."QuantityPerUnit"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 20</remarks>
		public System.String QuantityPerUnit 
		{
			get { return IsQuantityPerUnitNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.QuantityPerUnitColumn]; }
			set { this[_parent.QuantityPerUnitColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field QuantityPerUnit is NULL, false otherwise.</summary>
		public bool IsQuantityPerUnitNull() 
		{
			return IsNull(_parent.QuantityPerUnitColumn);
		}

		/// <summary>Sets the TypedView field QuantityPerUnit to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetQuantityPerUnitNull() 
		{
			this[_parent.QuantityPerUnitColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field UnitPrice<br/><br/></summary>
		/// <remarks>Mapped on view field: "Alphabetical list of products"."UnitPrice"<br/>
		/// View field characteristics (type, precision, scale, length): Money, 19, 4, 0</remarks>
		public System.Decimal UnitPrice 
		{
			get { return IsUnitPriceNull() ? (System.Decimal)TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)) : (System.Decimal)this[_parent.UnitPriceColumn]; }
			set { this[_parent.UnitPriceColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field UnitPrice is NULL, false otherwise.</summary>
		public bool IsUnitPriceNull() 
		{
			return IsNull(_parent.UnitPriceColumn);
		}

		/// <summary>Sets the TypedView field UnitPrice to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetUnitPriceNull() 
		{
			this[_parent.UnitPriceColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field UnitsInStock<br/><br/></summary>
		/// <remarks>Mapped on view field: "Alphabetical list of products"."UnitsInStock"<br/>
		/// View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0</remarks>
		public System.Int16 UnitsInStock 
		{
			get { return IsUnitsInStockNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.UnitsInStockColumn]; }
			set { this[_parent.UnitsInStockColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field UnitsInStock is NULL, false otherwise.</summary>
		public bool IsUnitsInStockNull() 
		{
			return IsNull(_parent.UnitsInStockColumn);
		}

		/// <summary>Sets the TypedView field UnitsInStock to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetUnitsInStockNull() 
		{
			this[_parent.UnitsInStockColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field UnitsOnOrder<br/><br/></summary>
		/// <remarks>Mapped on view field: "Alphabetical list of products"."UnitsOnOrder"<br/>
		/// View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0</remarks>
		public System.Int16 UnitsOnOrder 
		{
			get { return IsUnitsOnOrderNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.UnitsOnOrderColumn]; }
			set { this[_parent.UnitsOnOrderColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field UnitsOnOrder is NULL, false otherwise.</summary>
		public bool IsUnitsOnOrderNull() 
		{
			return IsNull(_parent.UnitsOnOrderColumn);
		}

		/// <summary>Sets the TypedView field UnitsOnOrder to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetUnitsOnOrderNull() 
		{
			this[_parent.UnitsOnOrderColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field ReorderLevel<br/><br/></summary>
		/// <remarks>Mapped on view field: "Alphabetical list of products"."ReorderLevel"<br/>
		/// View field characteristics (type, precision, scale, length): SmallInt, 5, 0, 0</remarks>
		public System.Int16 ReorderLevel 
		{
			get { return IsReorderLevelNull() ? (System.Int16)TypeDefaultValue.GetDefaultValue(typeof(System.Int16)) : (System.Int16)this[_parent.ReorderLevelColumn]; }
			set { this[_parent.ReorderLevelColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ReorderLevel is NULL, false otherwise.</summary>
		public bool IsReorderLevelNull() 
		{
			return IsNull(_parent.ReorderLevelColumn);
		}

		/// <summary>Sets the TypedView field ReorderLevel to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetReorderLevelNull() 
		{
			this[_parent.ReorderLevelColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Discontinued<br/><br/></summary>
		/// <remarks>Mapped on view field: "Alphabetical list of products"."Discontinued"<br/>
		/// View field characteristics (type, precision, scale, length): Bit, 0, 0, 0</remarks>
		public System.Boolean Discontinued 
		{
			get { return IsDiscontinuedNull() ? (System.Boolean)TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)) : (System.Boolean)this[_parent.DiscontinuedColumn]; }
			set { this[_parent.DiscontinuedColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Discontinued is NULL, false otherwise.</summary>
		public bool IsDiscontinuedNull() 
		{
			return IsNull(_parent.DiscontinuedColumn);
		}

		/// <summary>Sets the TypedView field Discontinued to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetDiscontinuedNull() 
		{
			this[_parent.DiscontinuedColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field CategoryName<br/><br/></summary>
		/// <remarks>Mapped on view field: "Alphabetical list of products"."CategoryName"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 15</remarks>
		public System.String CategoryName 
		{
			get { return IsCategoryNameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CategoryNameColumn]; }
			set { this[_parent.CategoryNameColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field CategoryName is NULL, false otherwise.</summary>
		public bool IsCategoryNameNull() 
		{
			return IsNull(_parent.CategoryNameColumn);
		}

		/// <summary>Sets the TypedView field CategoryName to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCategoryNameNull() 
		{
			this[_parent.CategoryNameColumn] = System.Convert.DBNull;
		}
		#endregion
		
		#region Custom Typed View Row Code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion
		
		#region Included Row Code

		#endregion		
	}
}
