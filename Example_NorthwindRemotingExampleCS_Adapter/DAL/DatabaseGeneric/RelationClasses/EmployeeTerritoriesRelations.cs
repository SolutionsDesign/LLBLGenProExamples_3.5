///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: woensdag 14 maart 2012 14:42:32
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using Northwind.DAL;
using Northwind.DAL.FactoryClasses;
using Northwind.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: EmployeeTerritories. </summary>
	public partial class EmployeeTerritoriesRelations
	{
		/// <summary>CTor</summary>
		public EmployeeTerritoriesRelations()
		{
		}

		/// <summary>Gets all relations of the EmployeeTerritoriesEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.EmployeeEntityUsingEmployeeId);
			toReturn.Add(this.TerritoryEntityUsingTerritoryId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between EmployeeTerritoriesEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// EmployeeTerritories.EmployeeId - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employees", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, EmployeeTerritoriesFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeTerritoriesEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between EmployeeTerritoriesEntity and TerritoryEntity over the m:1 relation they have, using the relation between the fields:
		/// EmployeeTerritories.TerritoryId - Territory.TerritoryId
		/// </summary>
		public virtual IEntityRelation TerritoryEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Territories", false);
				relation.AddEntityFieldPair(TerritoryFields.TerritoryId, EmployeeTerritoriesFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TerritoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeTerritoriesEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticEmployeeTerritoriesRelations
	{
		internal static readonly IEntityRelation EmployeeEntityUsingEmployeeIdStatic = new EmployeeTerritoriesRelations().EmployeeEntityUsingEmployeeId;
		internal static readonly IEntityRelation TerritoryEntityUsingTerritoryIdStatic = new EmployeeTerritoriesRelations().TerritoryEntityUsingTerritoryId;

		/// <summary>CTor</summary>
		static StaticEmployeeTerritoriesRelations()
		{
		}
	}
}
