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
	
	/// <summary>Typed datatable for the view 'QuarterlyOrder'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class QuarterlyOrderTypedView : TypedViewBase<QuarterlyOrderRow>, ITypedView
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private DataColumn _columnCustomerId;
		private DataColumn _columnCompanyName;
		private DataColumn _columnCity;
		private DataColumn _columnCountry;
		
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		/// <summary>
		/// The amount of fields in the resultset.
		/// </summary>
		private const int AmountOfFields = 4;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static QuarterlyOrderTypedView()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public QuarterlyOrderTypedView():base("QuarterlyOrder")
		{
			InitClass();
		}
		
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected QuarterlyOrderTypedView(SerializationInfo info, StreamingContext context):base(info, context)
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
			return EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.QuarterlyOrderTypedView);
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
			IEntityFields fieldsInResultset = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.QuarterlyOrderTypedView);
			return DAOFactory.CreateTypedListDAO().GetDbCount(fieldsInResultset, null, filter, null, groupByClause, allowDuplicates);
		}

		/// <summary>Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.</summary>
		/// <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		/// <returns>the new typed datarow</returns>
		protected override DataRow NewRowFromBuilder(DataRowBuilder rowBuilder) 
		{
			return new QuarterlyOrderRow(rowBuilder);
		}

		/// <summary>Initializes the hashtables for the typed view type and typed view field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();
			Hashtable fieldHashtable;
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("CustomerId", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("CompanyName", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Country", fieldHashtable);
		}

		/// <summary>Initialize the datastructures.</summary>
		protected override void InitClass()
		{
			TableName = "QuarterlyOrder";		
			_columnCustomerId = GeneralUtils.CreateTypedDataTableColumn("CustomerId", @"CustomerId", typeof(System.String), this.Columns);
			_columnCompanyName = GeneralUtils.CreateTypedDataTableColumn("CompanyName", @"CompanyName", typeof(System.String), this.Columns);
			_columnCity = GeneralUtils.CreateTypedDataTableColumn("City", @"City", typeof(System.String), this.Columns);
			_columnCountry = GeneralUtils.CreateTypedDataTableColumn("Country", @"Country", typeof(System.String), this.Columns);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClass
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnCustomerId = this.Columns["CustomerId"];
			_columnCompanyName = this.Columns["CompanyName"];
			_columnCity = this.Columns["City"];
			_columnCountry = this.Columns["Country"];
			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			QuarterlyOrderTypedView cloneToReturn = ((QuarterlyOrderTypedView)(base.Clone()));
			cloneToReturn.InitMembers();
			return cloneToReturn;
		}
#if !CF
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new QuarterlyOrderTypedView();
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
			get { return QuarterlyOrderTypedView.CustomProperties;}
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
			get { return QuarterlyOrderTypedView.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedView field CustomerId</summary>
		internal DataColumn CustomerIdColumn 
		{
			get { return _columnCustomerId; }
		}

		/// <summary>Returns the column object belonging to the TypedView field CompanyName</summary>
		internal DataColumn CompanyNameColumn 
		{
			get { return _columnCompanyName; }
		}

		/// <summary>Returns the column object belonging to the TypedView field City</summary>
		internal DataColumn CityColumn 
		{
			get { return _columnCity; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Country</summary>
		internal DataColumn CountryColumn 
		{
			get { return _columnCountry; }
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


	/// <summary>Typed datarow for the typed datatable QuarterlyOrder</summary>
	public partial class QuarterlyOrderRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private QuarterlyOrderTypedView	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal QuarterlyOrderRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((QuarterlyOrderTypedView)(this.Table));
		}

		#region Class Property Declarations

		/// <summary>Gets / sets the value of the TypedView field CustomerId<br/><br/></summary>
		/// <remarks>Mapped on view field: "Quarterly Orders"."CustomerID"<br/>
		/// View field characteristics (type, precision, scale, length): NChar, 0, 0, 5</remarks>
		public System.String CustomerId 
		{
			get { return IsCustomerIdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CustomerIdColumn]; }
			set { this[_parent.CustomerIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field CustomerId is NULL, false otherwise.</summary>
		public bool IsCustomerIdNull() 
		{
			return IsNull(_parent.CustomerIdColumn);
		}

		/// <summary>Sets the TypedView field CustomerId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCustomerIdNull() 
		{
			this[_parent.CustomerIdColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field CompanyName<br/><br/></summary>
		/// <remarks>Mapped on view field: "Quarterly Orders"."CompanyName"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 40</remarks>
		public System.String CompanyName 
		{
			get { return IsCompanyNameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CompanyNameColumn]; }
			set { this[_parent.CompanyNameColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field CompanyName is NULL, false otherwise.</summary>
		public bool IsCompanyNameNull() 
		{
			return IsNull(_parent.CompanyNameColumn);
		}

		/// <summary>Sets the TypedView field CompanyName to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCompanyNameNull() 
		{
			this[_parent.CompanyNameColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field City<br/><br/></summary>
		/// <remarks>Mapped on view field: "Quarterly Orders"."City"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 15</remarks>
		public System.String City 
		{
			get { return IsCityNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CityColumn]; }
			set { this[_parent.CityColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field City is NULL, false otherwise.</summary>
		public bool IsCityNull() 
		{
			return IsNull(_parent.CityColumn);
		}

		/// <summary>Sets the TypedView field City to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCityNull() 
		{
			this[_parent.CityColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Country<br/><br/></summary>
		/// <remarks>Mapped on view field: "Quarterly Orders"."Country"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 15</remarks>
		public System.String Country 
		{
			get { return IsCountryNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CountryColumn]; }
			set { this[_parent.CountryColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Country is NULL, false otherwise.</summary>
		public bool IsCountryNull() 
		{
			return IsNull(_parent.CountryColumn);
		}

		/// <summary>Sets the TypedView field Country to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCountryNull() 
		{
			this[_parent.CountryColumn] = System.Convert.DBNull;
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
