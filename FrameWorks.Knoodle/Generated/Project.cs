/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.1.0209.0
EntitySpaces Driver  : Access
Date Generated       : 6/9/2011 3:24:42 PM
===============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.ComponentModel;
using System.Xml.Serialization;


using EntitySpaces.Interfaces;
using EntitySpaces.Core;



namespace BusinessObjects
{

	[Serializable]
	abstract public class esProjectCollection : esEntityCollection
	{
		public esProjectCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "ProjectCollection";
		}

		#region Query Logic
		protected void InitQuery(esProjectQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			query.es.Connection = ((IEntityCollection)this).Connection;
		}

		protected bool OnQueryLoaded(DataTable table)
		{
			this.PopulateCollection(table);
			return (this.RowCount > 0) ? true : false;
		}
		
		protected override void HookupQuery(esDynamicQuery query)
		{
			this.InitQuery(query as esProjectQuery);
		}
		#endregion
		
		virtual public Project DetachEntity(Project entity)
		{
			return base.DetachEntity(entity) as Project;
		}
		
		virtual public Project AttachEntity(Project entity)
		{
			return base.AttachEntity(entity) as Project;
		}
		
		virtual public void Combine(ProjectCollection collection)
		{
			base.Combine(collection);
		}
		
		new public Project this[int index]
		{
			get
			{
				return base[index] as Project;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(Project);
		}
	}



	[Serializable]
	abstract public class esProject : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esProjectQuery GetDynamicQuery()
		{
			return null;
		}

		public esProject()
		{

		}

		public esProject(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 id)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 id)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(id);
			else
				return LoadByPrimaryKeyStoredProcedure(id);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 id)
		{
			esProjectQuery query = this.GetDynamicQuery();
			query.Where(query.Id == id);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 id)
		{
			esParameters parms = new esParameters();
			parms.Add("ID",id);
			return this.Load(esQueryType.StoredProcedure, this.es.spLoadByPrimaryKey, parms);
		}
		#endregion
		
		
		#region INotifyPropertyChanged Members

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		#endregion
		
		#region Properties
		
		
		public override void SetProperties(IDictionary values)
		{
			foreach (string propertyName in values.Keys)
			{
				this.SetProperty(propertyName, values[propertyName]);
			}
		}

		public override void SetProperty(string name, object value)
		{
			if(this.Row == null) this.AddNew();
			
			esColumnMetadata col = this.Meta.Columns.FindByPropertyName(name);
			if (col != null)
			{
				if(value == null || value.GetType().ToString() == "System.String")
				{				
					// Use the strongly typed property
					switch (name)
					{							
						case "Id": this.str.Id = (string)value; break;							
						case "JobName": this.str.JobName = (string)value; break;							
						case "JobNumber": this.str.JobNumber = (string)value; break;							
						case "DataPath": this.str.DataPath = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "Id":
						
							if (value == null || value.GetType().ToString() == "System.Int32")
								this.Id = (System.Int32?)value;
							break;
						
						case "JobNumber":
						
							if (value == null || value.GetType().ToString() == "System.Int32")
								this.JobNumber = (System.Int32?)value;
							break;
					

						default:
							break;
					}
				}
			}
			else if(this.Row.Table.Columns.Contains(name))
			{
				this.Row[name] = value;
			}
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}
		
		
		/// <summary>
		/// Maps to Project.ID
		/// </summary>
		virtual public System.Int32? Id
		{
			get
			{
				return base.GetSystemInt32(ProjectMetadata.ColumnNames.Id);
			}
			
			set
			{
				if(base.SetSystemInt32(ProjectMetadata.ColumnNames.Id, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProjectMetadata.PropertyNames.Id));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Project.JobName
		/// </summary>
		virtual public System.String JobName
		{
			get
			{
				return base.GetSystemString(ProjectMetadata.ColumnNames.JobName);
			}
			
			set
			{
				if(base.SetSystemString(ProjectMetadata.ColumnNames.JobName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProjectMetadata.PropertyNames.JobName));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Project.JobNumber
		/// </summary>
		virtual public System.Int32? JobNumber
		{
			get
			{
				return base.GetSystemInt32(ProjectMetadata.ColumnNames.JobNumber);
			}
			
			set
			{
				if(base.SetSystemInt32(ProjectMetadata.ColumnNames.JobNumber, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProjectMetadata.PropertyNames.JobNumber));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Project.DataPath
		/// </summary>
		virtual public System.String DataPath
		{
			get
			{
				return base.GetSystemString(ProjectMetadata.ColumnNames.DataPath);
			}
			
			set
			{
				if(base.SetSystemString(ProjectMetadata.ColumnNames.DataPath, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ProjectMetadata.PropertyNames.DataPath));
					}
				}
			}
		}
		
		#endregion	

		#region String Properties


		[BrowsableAttribute( false )]
		public esStrings str
		{
			get
			{
				if (esstrings == null)
				{
					esstrings = new esStrings(this);
				}
				return esstrings;
			}
		}


		[Serializable]
		sealed public class esStrings
		{
			public esStrings(esProject entity)
			{
				this.entity = entity;
			}
			
	
			public System.String Id
			{
				get
				{
					System.Int32? data = entity.Id;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Id = null;
					else entity.Id = Convert.ToInt32(value);
				}
			}
				
			public System.String JobName
			{
				get
				{
					System.String data = entity.JobName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobName = null;
					else entity.JobName = Convert.ToString(value);
				}
			}
				
			public System.String JobNumber
			{
				get
				{
					System.Int32? data = entity.JobNumber;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobNumber = null;
					else entity.JobNumber = Convert.ToInt32(value);
				}
			}
				
			public System.String DataPath
			{
				get
				{
					System.String data = entity.DataPath;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.DataPath = null;
					else entity.DataPath = Convert.ToString(value);
				}
			}
			

			private esProject entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esProjectQuery query)
		{
			query.OnLoadDelegate = this.OnQueryLoaded;
			query.es.Connection = ((IEntity)this).Connection;
		}

		[System.Diagnostics.DebuggerNonUserCode]
		protected bool OnQueryLoaded(DataTable table)
		{
			bool dataFound = this.PopulateEntity(table);

			if (this.RowCount > 1)
			{
				throw new Exception("esProject can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}


	
	public partial class Project : esProject
	{

		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
		
			return props;
		}	
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PreSave.
		/// </summary>
		protected override void ApplyPreSaveKeys()
		{
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostSave.
		/// </summary>
		protected override void ApplyPostSaveKeys()
		{
		}
		
		/// <summary>
		/// Used internally for retrieving AutoIncrementing keys
		/// during hierarchical PostOneToOneSave.
		/// </summary>
		protected override void ApplyPostOneSaveKeys()
		{
		}
		
	}



	[Serializable]
	abstract public class esProjectQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ProjectMetadata.Meta();
			}
		}	
		

		public esQueryItem Id
		{
			get
			{
				return new esQueryItem(this, ProjectMetadata.ColumnNames.Id, esSystemType.Int32);
			}
		} 
		
		public esQueryItem JobName
		{
			get
			{
				return new esQueryItem(this, ProjectMetadata.ColumnNames.JobName, esSystemType.String);
			}
		} 
		
		public esQueryItem JobNumber
		{
			get
			{
				return new esQueryItem(this, ProjectMetadata.ColumnNames.JobNumber, esSystemType.Int32);
			}
		} 
		
		public esQueryItem DataPath
		{
			get
			{
				return new esQueryItem(this, ProjectMetadata.ColumnNames.DataPath, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("ProjectCollection")]
	public partial class ProjectCollection : esProjectCollection, IEnumerable<Project>
	{
		public ProjectCollection()
		{

		}
		
		public static implicit operator List<Project>(ProjectCollection coll)
		{
			List<Project> list = new List<Project>();
			
			foreach (Project emp in coll)
			{
				list.Add(emp);
			}
			
			return list;
		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return  ProjectMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProjectQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new Project(row);
		}

		override protected esEntity CreateEntity()
		{
			return new Project();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public ProjectQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProjectQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(ProjectQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public Project AddNew()
		{
			Project entity = base.AddNewEntity() as Project;
			
			return entity;
		}

		public Project FindByPrimaryKey(System.Int32 id)
		{
			return base.FindByPrimaryKey(id) as Project;
		}


		#region IEnumerable<Project> Members

		IEnumerator<Project> IEnumerable<Project>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as Project;
			}
		}

		#endregion
		
		private ProjectQuery query;
	}


	/// <summary>
	/// Encapsulates the 'Project' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("Project ({Id})")]
	[Serializable]
	public partial class Project : esProject
	{
		public Project()
		{

		}
	
		public Project(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ProjectMetadata.Meta();
			}
		}
		
		
		
		override protected esProjectQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ProjectQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public ProjectQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ProjectQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(ProjectQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private ProjectQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
	public partial class ProjectQuery : esProjectQuery
	{
		public ProjectQuery()
		{

		}		
		
		public ProjectQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	
		
			
	}



	[Serializable]
	public partial class ProjectMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ProjectMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ProjectMetadata.ColumnNames.Id, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProjectMetadata.PropertyNames.Id;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;	
			c.NumericPrecision = 10;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(ProjectMetadata.ColumnNames.JobName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ProjectMetadata.PropertyNames.JobName;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(ProjectMetadata.ColumnNames.JobNumber, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ProjectMetadata.PropertyNames.JobNumber;	
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(ProjectMetadata.ColumnNames.DataPath, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ProjectMetadata.PropertyNames.DataPath;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
		}
		#endregion
	
		static public ProjectMetadata Meta()
		{
			return meta;
		}	
		
		public Guid DataID
		{
			get { return base._dataID; }
		}	
		
		public bool MultiProviderMode
		{
			get { return false; }
		}		

		public esColumnMetadataCollection Columns
		{
			get	{ return base._columns; }
		}
		
		#region ColumnNames
		public class ColumnNames
		{ 
			 public const string Id = "ID";
			 public const string JobName = "JobName";
			 public const string JobNumber = "JobNumber";
			 public const string DataPath = "DataPath";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string Id = "Id";
			 public const string JobName = "JobName";
			 public const string JobNumber = "JobNumber";
			 public const string DataPath = "DataPath";
		}
		#endregion	

		public esProviderSpecificMetadata GetProviderMetadata(string mapName)
		{
			MapToMeta mapMethod = mapDelegates[mapName];

			if (mapMethod != null)
				return mapMethod(mapName);
			else
				return null;
		}
		
		#region MAP esDefault
		
		static private int RegisterDelegateesDefault()
		{
			// This is only executed once per the life of the application
			lock (typeof(ProjectMetadata))
			{
				if(ProjectMetadata.mapDelegates == null)
				{
					ProjectMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ProjectMetadata.meta == null)
				{
					ProjectMetadata.meta = new ProjectMetadata();
				}
				
				MapToMeta mapMethod = new MapToMeta(meta.esDefault);
				mapDelegates.Add("esDefault", mapMethod);
				mapMethod("esDefault");
			}
			return 0;
		}			

		private esProviderSpecificMetadata esDefault(string mapName)
		{
			if(!_providerMetadataMaps.ContainsKey(mapName))
			{
				esProviderSpecificMetadata meta = new esProviderSpecificMetadata();
				

				meta.AddTypeMap("ID", new esTypeMap("Long", "System.Int32"));
				meta.AddTypeMap("JobName", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("JobNumber", new esTypeMap("Long", "System.Int32"));
				meta.AddTypeMap("DataPath", new esTypeMap("Text", "System.String"));			
				
				
				
				meta.Source = "Project";
				meta.Destination = "Project";
				
				meta.spInsert = "proc_ProjectInsert";				
				meta.spUpdate = "proc_ProjectUpdate";		
				meta.spDelete = "proc_ProjectDelete";
				meta.spLoadAll = "proc_ProjectLoadAll";
				meta.spLoadByPrimaryKey = "proc_ProjectLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ProjectMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
