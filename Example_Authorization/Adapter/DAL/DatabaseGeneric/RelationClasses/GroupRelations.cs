﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: woensdag 14 maart 2012 14:18:11
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using SD.LLBLGen.Pro.Examples.Authorization;
using SD.LLBLGen.Pro.Examples.Authorization.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Authorization.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Authorization.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Group. </summary>
	public partial class GroupRelations
	{
		/// <summary>CTor</summary>
		public GroupRelations()
		{
		}

		/// <summary>Gets all relations of the GroupEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.UserGroupEntityUsingGroupId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between GroupEntity and UserGroupEntity over the 1:n relation they have, using the relation between the fields:
		/// Group.Id - UserGroup.GroupId
		/// </summary>
		public virtual IEntityRelation UserGroupEntityUsingGroupId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "UserGroup" , true);
				relation.AddEntityFieldPair(GroupFields.Id, UserGroupFields.GroupId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("GroupEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UserGroupEntity", false);
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
	internal static class StaticGroupRelations
	{
		internal static readonly IEntityRelation UserGroupEntityUsingGroupIdStatic = new GroupRelations().UserGroupEntityUsingGroupId;

		/// <summary>CTor</summary>
		static StaticGroupRelations()
		{
		}
	}
}
