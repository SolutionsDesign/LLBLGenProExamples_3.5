﻿using System;

using System.Configuration;
using System.Collections;
using System.Web;
using System.Text;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.Examples.Auditing.EntityClasses;
using SD.LLBLGen.Pro.Examples.Auditing;

public partial class Controls_ListSupplierInstances : System.Web.UI.UserControl, IListControl
{
	protected void Page_Load(object sender, EventArgs e)
	{
	}


	/// <summary>
	/// Handles the Click event of the btnHome control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnHome_Click(object sender, EventArgs e)
	{
		Response.Redirect("~/default.aspx");
	}
	
	
	/// <summary>
	/// Handles the Click event of the btnAddNew control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
	protected void btnAddNew_Click(object sender, EventArgs e)
	{
		object additionalFilters = ViewState["additionalFilters"];
		string additionalFiltersAsString = string.Empty;
		if(additionalFilters != null)
		{
			additionalFiltersAsString = (string)additionalFilters;
		}
		Response.Redirect("~/AddNew.aspx?EntityType=" + (int)EntityType.SupplierEntity + additionalFiltersAsString);
	}
	
	
	/// <summary>
	/// Handles the RowCommand event of the theGrid control.
	/// </summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">The <see cref="System.Web.UI.WebControls.GridViewCommandEventArgs"/> instance containing the event data.</param>
	protected void theGrid_RowCommand(object sender, GridViewCommandEventArgs e)
	{
		switch(e.CommandName)
		{
			case "EditExisting":
			case "ViewExisting":
				break;
			default:
				// apparently another command, return
				return;
		}
		int index = Convert.ToInt32(e.CommandArgument);
		SupplierEntity selectedEntity = (SupplierEntity)_SupplierDS.EntityCollection[index];

		StringBuilder pkFieldsAndValues = new StringBuilder();
		pkFieldsAndValues.AppendFormat("&SupplierId={0}", selectedEntity.SupplierId);
		switch(e.CommandName)
		{
			case "EditExisting":
				Response.Redirect("~/EditExisting.aspx?EntityType=" + (int)EntityType.SupplierEntity + pkFieldsAndValues.ToString());
				break;
			case "ViewExisting":
				Response.Redirect("~/ViewExisting.aspx?EntityType=" + (int)EntityType.SupplierEntity + pkFieldsAndValues.ToString());
				break;
		}
	}


	/// <summary>
	/// Sets the containing entity for the entities enlisted in this control. When a particular containing entity is set (e.g. 'Customer' for orders), the
	/// set entity is used to obtain the filter for the entities to show, and FilterToUse is then overruled. The entity is also used to produce FK field values
	/// for AddNew, so for example when a list of orders is shown, which are related to customer, the AddNew button should make the order's AddNew form preselect
	/// the Customer.
	/// </summary>
	/// <param name="containingEntity">The containing entity instance</param>
	/// <param name="name">the field name mapped on the relation from the containing entity with this entity</param>
	public void SetContainingEntity(IEntity2 containingEntity, string name)
	{
		switch(containingEntity.LLBLGenProEntityName)
		{
			case "ProductEntity":
				switch(name)
				{
					default:
						break;
				}
				break;
			case "CategoryEntity":
				switch(name)
				{
					case "SuppliersCollectionViaProducts":
						_SupplierDS.FilterToUse = ((CategoryEntity)containingEntity).GetRelationInfoSuppliersCollectionViaProducts();
						break;
					default:
						break;
				}
				break;

			default:
				break;
		}
	}


	/// <summary>
	/// Sets the filter to use for the ListControl's datasource control.
	/// </summary>
	public IRelationPredicateBucket FilterToUse 
	{
		set { _SupplierDS.FilterToUse = value; }
	}


	/// <summary>
	/// Sets the flag to show the Home button or not. The home button is hidden when the control is shown inside a form with other information.
	/// </summary>
	public bool ShowHomeButton 
	{
		set { phHomeButton.Visible = value; }
	}	


	/// <summary>
	/// Sets the flag to show the AddNew button or not. The AddNew button is hidden when the data in the control is the data of an m:n relation.
	/// </summary>
	public bool ShowAddNewButton 
	{
		set { phAddNewButton.Visible = value; }
	}	
}