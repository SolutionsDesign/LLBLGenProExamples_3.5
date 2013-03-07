///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: woensdag 14 maart 2012 14:42:33
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.DatabaseSpecific
{
	/// <summary>Class which contains the static logic to execute action stored procedures in the database.</summary>
	public static partial class ActionProcedures
	{

		/// <summary>Delegate definition for stored procedure 'pr_CustomersAndOrdersOnCountry' to be used in combination of a UnitOfWork2 object.</summary>
		public delegate int CustomersAndOrdersOnCountryCallBack(System.String country, IDataAccessCore dataAccessProvider);


		/// <summary>Calls stored procedure 'pr_CustomersAndOrdersOnCountry'.<br/><br/></summary>
		/// <param name="country">Input parameter. </param>
		/// <returns>Number of rows affected, if the database / routine doesn't suppress rowcounting.</returns>
		public static int CustomersAndOrdersOnCountry(System.String country)
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return CustomersAndOrdersOnCountry(country, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'pr_CustomersAndOrdersOnCountry'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="country">Input parameter. </param>
		/// <returns>Number of rows affected, if the database / routine doesn't suppress rowcounting.</returns>
		public static int CustomersAndOrdersOnCountry(System.String country, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateCustomersAndOrdersOnCountryCall(dataAccessProvider, country))
			{
				int toReturn = call.Call();
				return toReturn;
			}
		}
		
		/// <summary>Creates the call object for the call 'CustomersAndOrdersOnCountry' to stored procedure 'pr_CustomersAndOrdersOnCountry'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="country">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateCustomersAndOrdersOnCountryCall(IDataAccessCore dataAccessProvider, System.String country)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[Northwind].[dbo].[pr_CustomersAndOrdersOnCountry]", "CustomersAndOrdersOnCountry")
							.AddParameter("@country", "VarChar", 50, ParameterDirection.Input, true, 0, 0, country);
		}


		#region Included Code

		#endregion
	}
}
