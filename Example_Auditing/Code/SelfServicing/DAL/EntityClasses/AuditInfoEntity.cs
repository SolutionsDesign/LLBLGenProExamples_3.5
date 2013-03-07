﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: woensdag 14 maart 2012 14:03:34
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Data;
using System.Xml.Serialization;
using SD.LLBLGen.Pro.Examples.Auditing;
using SD.LLBLGen.Pro.Examples.Auditing.FactoryClasses;
using SD.LLBLGen.Pro.Examples.Auditing.DaoClasses;
using SD.LLBLGen.Pro.Examples.Auditing.RelationClasses;
using SD.LLBLGen.Pro.Examples.Auditing.HelperClasses;
using SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace SD.LLBLGen.Pro.Examples.Auditing.EntityClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'AuditInfo'. <br/><br/>
	/// 
	/// </summary>
	[Serializable]
	public partial class AuditInfoEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AuditActionTypeEntity _auditActionType;
		private bool	_alwaysFetchAuditActionType, _alreadyFetchedAuditActionType, _auditActionTypeReturnsNewIfNotFound;
		private UserEntity _user;
		private bool	_alwaysFetchUser, _alreadyFetchedUser, _userReturnsNewIfNotFound;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name AuditActionType</summary>
			public static readonly string AuditActionType = "AuditActionType";
			/// <summary>Member name User</summary>
			public static readonly string User = "User";
		}
		#endregion
		
		/// <summary>Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static AuditInfoEntity()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public AuditInfoEntity() : base()
		{
			InitClassEmpty(null);
		}
		
		/// <summary>CTor</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		public AuditInfoEntity(System.Int32 auditInfoId)
		{
			InitClassFetch(auditInfoId, null, null);
		}

		/// <summary>CTor</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		public AuditInfoEntity(System.Int32 auditInfoId, IPrefetchPath prefetchPathToUse)
		{
			InitClassFetch(auditInfoId, null, prefetchPathToUse);
		}

		/// <summary>CTor</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="validator">The custom validator object for this AuditInfoEntity</param>
		public AuditInfoEntity(System.Int32 auditInfoId, IValidator validator)
		{
			InitClassFetch(auditInfoId, validator, null);
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AuditInfoEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			_auditActionType = (AuditActionTypeEntity)info.GetValue("_auditActionType", typeof(AuditActionTypeEntity));
			if(_auditActionType!=null)
			{
				_auditActionType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_auditActionTypeReturnsNewIfNotFound = info.GetBoolean("_auditActionTypeReturnsNewIfNotFound");
			_alwaysFetchAuditActionType = info.GetBoolean("_alwaysFetchAuditActionType");
			_alreadyFetchedAuditActionType = info.GetBoolean("_alreadyFetchedAuditActionType");

			_user = (UserEntity)info.GetValue("_user", typeof(UserEntity));
			if(_user!=null)
			{
				_user.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_userReturnsNewIfNotFound = info.GetBoolean("_userReturnsNewIfNotFound");
			_alwaysFetchUser = info.GetBoolean("_alwaysFetchUser");
			_alreadyFetchedUser = info.GetBoolean("_alreadyFetchedUser");
			this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance(), PersistenceInfoProviderSingleton.GetInstance());
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((AuditInfoFieldIndex)fieldIndex)
			{
				case AuditInfoFieldIndex.AuditActionTypeId:
					DesetupSyncAuditActionType(true, false);
					_alreadyFetchedAuditActionType = false;
					break;
				case AuditInfoFieldIndex.UserId:
					DesetupSyncUser(true, false);
					_alreadyFetchedUser = false;
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Will perform post-ReadXml actions</summary>
		protected override void PerformPostReadXmlFixups()
		{
			_alreadyFetchedAuditActionType = (_auditActionType != null);
			_alreadyFetchedUser = (_user != null);
		}
				
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "AuditActionType":
					toReturn.Add(Relations.AuditActionTypeEntityUsingAuditActionTypeId);
					break;
				case "User":
					toReturn.Add(Relations.UserEntityUsingUserId);
					break;
				default:
					break;				
			}
			return toReturn;
		}

		/// <summary>Gets a predicateexpression which filters on this entity</summary>
		/// <returns>ready to use predicateexpression</returns>
		/// <remarks>Only useful in entity fetches.</remarks>
		public  static IPredicateExpression GetEntityTypeFilter()
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter("AuditInfoEntity", false);
		}
		
		/// <summary>Gets a predicateexpression which filters on this entity</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <returns>ready to use predicateexpression</returns>
		/// <remarks>Only useful in entity fetches.</remarks>
		public  static IPredicateExpression GetEntityTypeFilter(bool negate)
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter("AuditInfoEntity", negate);
		}

		/// <summary> ISerializable member. Does custom serialization so event handlers do not get serialized.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_auditActionType", (!this.MarkedForDeletion?_auditActionType:null));
			info.AddValue("_auditActionTypeReturnsNewIfNotFound", _auditActionTypeReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchAuditActionType", _alwaysFetchAuditActionType);
			info.AddValue("_alreadyFetchedAuditActionType", _alreadyFetchedAuditActionType);
			info.AddValue("_user", (!this.MarkedForDeletion?_user:null));
			info.AddValue("_userReturnsNewIfNotFound", _userReturnsNewIfNotFound);
			info.AddValue("_alwaysFetchUser", _alwaysFetchUser);
			info.AddValue("_alreadyFetchedUser", _alreadyFetchedUser);

			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}
		
		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "AuditActionType":
					_alreadyFetchedAuditActionType = true;
					this.AuditActionType = (AuditActionTypeEntity)entity;
					break;
				case "User":
					_alreadyFetchedUser = true;
					this.User = (UserEntity)entity;
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "AuditActionType":
					SetupSyncAuditActionType(relatedEntity);
					break;
				case "User":
					SetupSyncUser(relatedEntity);
					break;
				default:
					break;
			}
		}
		
		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "AuditActionType":
					DesetupSyncAuditActionType(false, true);
					break;
				case "User":
					DesetupSyncUser(false, true);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependingRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		protected override List<IEntity> GetDependentRelatedEntities()
		{
			List<IEntity> toReturn = new List<IEntity>();
			if(_auditActionType!=null)
			{
				toReturn.Add(_auditActionType);
			}
			if(_user!=null)
			{
				toReturn.Add(_user);
			}
			return toReturn;
		}
		
		/// <summary> Gets a List of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		protected override List<IEntityCollection> GetMemberEntityCollections()
		{
			List<IEntityCollection> toReturn = new List<IEntityCollection>();


			return toReturn;
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static  AuditInfoEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 auditInfoId, Context contextToUse)
		{
			return FetchPolymorphic(transactionToUse, auditInfoId, contextToUse, null);
		}
				
		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key specified in a polymorphic way, so the entity returned  could be of a subtype of the current entity or the current entity.</summary>
		/// <param name="transactionToUse">transaction to use during fetch</param>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="contextToUse">Context to use for fetch</param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>Fetched entity of the type of this entity or a subtype, or an empty entity of that type if not found.</returns>
		/// <remarks>Creates a new instance, doesn't fill <i>this</i> entity instance</remarks>
		public static  AuditInfoEntity FetchPolymorphic(ITransaction transactionToUse, System.Int32 auditInfoId, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			IEntityFields fields = EntityFieldsFactory.CreateEntityFieldsObject(SD.LLBLGen.Pro.Examples.Auditing.EntityType.AuditInfoEntity);
			fields[(int)AuditInfoFieldIndex.AuditInfoId].ForcedCurrentValueWrite(auditInfoId);
			return (AuditInfoEntity)new AuditInfoDAO().FetchExistingPolymorphic(transactionToUse, fields, contextToUse, excludedIncludedFields);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditInfoId)
		{
			return FetchUsingPK(auditInfoId, null, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditInfoId, IPrefetchPath prefetchPathToUse)
		{
			return FetchUsingPK(auditInfoId, prefetchPathToUse, null, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditInfoId, IPrefetchPath prefetchPathToUse, Context contextToUse)
		{
			return FetchUsingPK(auditInfoId, prefetchPathToUse, contextToUse, null);
		}

		/// <summary> Fetches the contents of this entity from the persistent storage using the primary key.</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 auditInfoId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			return Fetch(auditInfoId, prefetchPathToUse, contextToUse, excludedIncludedFields);
		}

		/// <summary> Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. Refetching an empty Entity has no effect. </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		public override bool Refetch()
		{
			return Fetch(this.AuditInfoId, null, null, null);
		}

		/// <summary>Determines whether this entity is a subType of the entity represented by the passed in enum value, which represents a value in the SD.LLBLGen.Pro.Examples.Auditing.EntityType enum</summary>
		/// <param name="typeOfEntity">Type of entity.</param>
		/// <returns>true if the passed in type is a supertype of this entity, otherwise false</returns>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override bool CheckIfIsSubTypeOf(int typeOfEntity)
		{
			return InheritanceInfoProviderSingleton.GetInstance().CheckIfIsSubTypeOf("AuditInfoEntity", ((SD.LLBLGen.Pro.Examples.Auditing.EntityType)typeOfEntity).ToString());
		}
				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new AuditInfoRelations().GetAllRelations();
		}

		/// <summary> Retrieves the related entity of type 'AuditActionTypeEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'AuditActionTypeEntity' which is related to this entity.</returns>
		public AuditActionTypeEntity GetSingleAuditActionType()
		{
			return GetSingleAuditActionType(false);
		}

		/// <summary> Retrieves the related entity of type 'AuditActionTypeEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'AuditActionTypeEntity' which is related to this entity.</returns>
		public virtual AuditActionTypeEntity GetSingleAuditActionType(bool forceFetch)
		{
			if( ( !_alreadyFetchedAuditActionType || forceFetch || _alwaysFetchAuditActionType) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.AuditActionTypeEntityUsingAuditActionTypeId);
				AuditActionTypeEntity newEntity = new AuditActionTypeEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.AuditActionTypeId);
				}
				if(fetchResult)
				{
					newEntity = (AuditActionTypeEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_auditActionTypeReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.AuditActionType = newEntity;
				_alreadyFetchedAuditActionType = fetchResult;
			}
			return _auditActionType;
		}


		/// <summary> Retrieves the related entity of type 'UserEntity', using a relation of type 'n:1'</summary>
		/// <returns>A fetched entity of type 'UserEntity' which is related to this entity.</returns>
		public UserEntity GetSingleUser()
		{
			return GetSingleUser(false);
		}

		/// <summary> Retrieves the related entity of type 'UserEntity', using a relation of type 'n:1'</summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from the persistent storage</param>
		/// <returns>A fetched entity of type 'UserEntity' which is related to this entity.</returns>
		public virtual UserEntity GetSingleUser(bool forceFetch)
		{
			if( ( !_alreadyFetchedUser || forceFetch || _alwaysFetchUser) && !this.IsSerializing && !this.IsDeserializing  && !this.InDesignMode)			
			{
				bool performLazyLoading = this.CheckIfLazyLoadingShouldOccur(Relations.UserEntityUsingUserId);
				UserEntity newEntity = new UserEntity();
				bool fetchResult = false;
				if(performLazyLoading)
				{
					AddToTransactionIfNecessary(newEntity);
					fetchResult = newEntity.FetchUsingPK(this.UserId);
				}
				if(fetchResult)
				{
					newEntity = (UserEntity)GetFromActiveContext(newEntity);
				}
				else
				{
					if(!_userReturnsNewIfNotFound)
					{
						RemoveFromTransactionIfNecessary(newEntity);
						newEntity = null;
					}
				}
				this.User = newEntity;
				_alreadyFetchedUser = fetchResult;
			}
			return _user;
		}


		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("AuditActionType", _auditActionType);
			toReturn.Add("User", _user);
			return toReturn;
		}
	
		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validatorToUse">Validator to use.</param>
		private void InitClassEmpty(IValidator validatorToUse)
		{
			OnInitializing();
			this.Fields = CreateFields();
			this.Validator = validatorToUse;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}		

		/// <summary> Initializes the the entity and fetches the data related to the entity in this entity.</summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="validator">The validator object for this AuditInfoEntity</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		private void InitClassFetch(System.Int32 auditInfoId, IValidator validator, IPrefetchPath prefetchPathToUse)
		{
			OnInitializing();
			this.Validator = validator;
			this.Fields = CreateFields();
			InitClassMembers();	
			Fetch(auditInfoId, prefetchPathToUse, null, null);

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassFetch
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			_auditActionTypeReturnsNewIfNotFound = true;
			_userReturnsNewIfNotFound = true;
			PerformDependencyInjection();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ActionData", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ActionDateTime", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AffectedEntityName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AuditActionTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AuditInfoId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UserId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _auditActionType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAuditActionType(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _auditActionType, new PropertyChangedEventHandler( OnAuditActionTypePropertyChanged ), "AuditActionType", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticAuditInfoRelations.AuditActionTypeEntityUsingAuditActionTypeIdStatic, true, signalRelatedEntity, "AuditInfo", resetFKFields, new int[] { (int)AuditInfoFieldIndex.AuditActionTypeId } );		
			_auditActionType = null;
		}
		
		/// <summary> setups the sync logic for member _auditActionType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAuditActionType(IEntityCore relatedEntity)
		{
			if(_auditActionType!=relatedEntity)
			{		
				DesetupSyncAuditActionType(true, true);
				_auditActionType = (AuditActionTypeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _auditActionType, new PropertyChangedEventHandler( OnAuditActionTypePropertyChanged ), "AuditActionType", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticAuditInfoRelations.AuditActionTypeEntityUsingAuditActionTypeIdStatic, true, ref _alreadyFetchedAuditActionType, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAuditActionTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _user</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUser(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticAuditInfoRelations.UserEntityUsingUserIdStatic, true, signalRelatedEntity, "AuditInfo", resetFKFields, new int[] { (int)AuditInfoFieldIndex.UserId } );		
			_user = null;
		}
		
		/// <summary> setups the sync logic for member _user</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUser(IEntityCore relatedEntity)
		{
			if(_user!=relatedEntity)
			{		
				DesetupSyncUser(true, true);
				_user = (UserEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _user, new PropertyChangedEventHandler( OnUserPropertyChanged ), "User", SD.LLBLGen.Pro.Examples.Auditing.RelationClasses.StaticAuditInfoRelations.UserEntityUsingUserIdStatic, true, ref _alreadyFetchedUser, new string[] {  } );
			}
		}

		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUserPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. </summary>
		/// <param name="auditInfoId">PK value for AuditInfo which data should be fetched into this AuditInfo object</param>
		/// <param name="prefetchPathToUse">the PrefetchPath which defines the graph of objects to fetch as well</param>
		/// <param name="contextToUse">The context to add the entity to if the fetch was succesful. </param>
		/// <param name="excludedIncludedFields">The list of IEntityField objects which have to be excluded or included for the fetch. 
		/// If null or empty, all fields are fetched (default). If an instance of ExcludeIncludeFieldsList is passed in and its ExcludeContainedFields property
		/// is set to false, the fields contained in excludedIncludedFields are kept in the query, the rest of the fields in the query are excluded.</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 auditInfoId, IPrefetchPath prefetchPathToUse, Context contextToUse, ExcludeIncludeFieldsList excludedIncludedFields)
		{
			try
			{
				OnFetch();
				this.Fields[(int)AuditInfoFieldIndex.AuditInfoId].ForcedCurrentValueWrite(auditInfoId);
				CreateDAOInstance().FetchExisting(this, this.Transaction, prefetchPathToUse, contextToUse, excludedIncludedFields);
				return (this.Fields.State == EntityState.Fetched);
			}
			finally
			{
				OnFetchComplete();
			}
		}

		/// <summary> Creates the DAO instance for this type</summary>
		/// <returns></returns>
		protected override IDao CreateDAOInstance()
		{
			return DAOFactory.CreateAuditInfoDAO();
		}
		
		/// <summary> Creates the entity factory for this type.</summary>
		/// <returns></returns>
		protected override IEntityFactory CreateEntityFactory()
		{
			return new AuditInfoEntityFactory();
		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static AuditInfoRelations Relations
		{
			get	{ return new AuditInfoRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'AuditActionType'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathAuditActionType
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.AuditActionTypeCollection(), (IEntityRelation)GetRelationsForField("AuditActionType")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.AuditInfoEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.AuditActionTypeEntity, 0, null, null, null, "AuditActionType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement object which contains all the information to prefetch the related entities of type 'User'  for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement implementation.</returns>
		public static IPrefetchPathElement PrefetchPathUser
		{
			get	{ return new PrefetchPathElement(new SD.LLBLGen.Pro.Examples.Auditing.CollectionClasses.UserCollection(), (IEntityRelation)GetRelationsForField("User")[0], (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.AuditInfoEntity, (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.UserEntity, 0, null, null, null, "User", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The ActionData property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."ActionData"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 250<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ActionData
		{
			get { return (System.String)GetValue((int)AuditInfoFieldIndex.ActionData, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.ActionData, value, true); }
		}

		/// <summary> The ActionDateTime property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."ActionDateTime"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ActionDateTime
		{
			get { return (System.DateTime)GetValue((int)AuditInfoFieldIndex.ActionDateTime, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.ActionDateTime, value, true); }
		}

		/// <summary> The AffectedEntityName property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."AffectedEntityName"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 100<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AffectedEntityName
		{
			get { return (System.String)GetValue((int)AuditInfoFieldIndex.AffectedEntityName, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.AffectedEntityName, value, true); }
		}

		/// <summary> The AuditActionTypeId property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."AuditActionTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AuditActionTypeId
		{
			get { return (System.Int32)GetValue((int)AuditInfoFieldIndex.AuditActionTypeId, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.AuditActionTypeId, value, true); }
		}

		/// <summary> The AuditInfoId property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."AuditInfoID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AuditInfoId
		{
			get { return (System.Int32)GetValue((int)AuditInfoFieldIndex.AuditInfoId, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.AuditInfoId, value, true); }
		}

		/// <summary> The UserId property of the Entity AuditInfo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AuditInfo"."UserID"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String UserId
		{
			get { return (System.String)GetValue((int)AuditInfoFieldIndex.UserId, true); }
			set	{ SetValue((int)AuditInfoFieldIndex.UserId, value, true); }
		}


		/// <summary> Gets / sets related entity of type 'AuditActionTypeEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAuditActionType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual AuditActionTypeEntity AuditActionType
		{
			get	{ return GetSingleAuditActionType(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncAuditActionType(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "AuditInfo", "AuditActionType", _auditActionType, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for AuditActionType. When set to true, AuditActionType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AuditActionType is accessed. You can always execute a forced fetch by calling GetSingleAuditActionType(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchAuditActionType
		{
			get	{ return _alwaysFetchAuditActionType; }
			set	{ _alwaysFetchAuditActionType = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property AuditActionType already has been fetched. Setting this property to false when AuditActionType has been fetched
		/// will set AuditActionType to null as well. Setting this property to true while AuditActionType hasn't been fetched disables lazy loading for AuditActionType</summary>
		[Browsable(false)]
		public bool AlreadyFetchedAuditActionType
		{
			get { return _alreadyFetchedAuditActionType;}
			set 
			{
				if(_alreadyFetchedAuditActionType && !value)
				{
					this.AuditActionType = null;
				}
				_alreadyFetchedAuditActionType = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property AuditActionType is not found
		/// in the database. When set to true, AuditActionType will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool AuditActionTypeReturnsNewIfNotFound
		{
			get	{ return _auditActionTypeReturnsNewIfNotFound; }
			set { _auditActionTypeReturnsNewIfNotFound = value; }	
		}

		/// <summary> Gets / sets related entity of type 'UserEntity'. This property is not visible in databound grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.<br/><br/>
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUser()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in bound controls, f.e. datagrids.</remarks>
		[Browsable(true)]
		public virtual UserEntity User
		{
			get	{ return GetSingleUser(false); }
			set 
			{ 
				if(this.IsDeserializing)
				{
					SetupSyncUser(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "AuditInfo", "User", _user, true); 
				}
			}
		}

		/// <summary> Gets / sets the lazy loading flag for User. When set to true, User is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time User is accessed. You can always execute a forced fetch by calling GetSingleUser(true).</summary>
		[Browsable(false)]
		public bool AlwaysFetchUser
		{
			get	{ return _alwaysFetchUser; }
			set	{ _alwaysFetchUser = value; }	
		}
				
		/// <summary>Gets / Sets the lazy loading flag if the property User already has been fetched. Setting this property to false when User has been fetched
		/// will set User to null as well. Setting this property to true while User hasn't been fetched disables lazy loading for User</summary>
		[Browsable(false)]
		public bool AlreadyFetchedUser
		{
			get { return _alreadyFetchedUser;}
			set 
			{
				if(_alreadyFetchedUser && !value)
				{
					this.User = null;
				}
				_alreadyFetchedUser = value;
			}
		}

		/// <summary> Gets / sets the flag for what to do if the related entity available through the property User is not found
		/// in the database. When set to true, User will return a new entity instance if the related entity is not found, otherwise 
		/// null be returned if the related entity is not found. Default: true.</summary>
		[Browsable(false)]
		public bool UserReturnsNewIfNotFound
		{
			get	{ return _userReturnsNewIfNotFound; }
			set { _userReturnsNewIfNotFound = value; }	
		}


		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}

		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		[System.ComponentModel.Browsable(false), XmlIgnore]
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.TargetPerEntity;}
		}
		
		/// <summary>Returns the SD.LLBLGen.Pro.Examples.Auditing.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)SD.LLBLGen.Pro.Examples.Auditing.EntityType.AuditInfoEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
