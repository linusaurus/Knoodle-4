/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.1.0209.0
EntitySpaces Driver  : Access
Date Generated       : 6/9/2011 3:24:41 PM
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
	abstract public class esComponentCollection : esEntityCollection
	{
		public esComponentCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "ComponentCollection";
		}

		#region Query Logic
		protected void InitQuery(esComponentQuery query)
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
			this.InitQuery(query as esComponentQuery);
		}
		#endregion
		
		virtual public Component DetachEntity(Component entity)
		{
			return base.DetachEntity(entity) as Component;
		}
		
		virtual public Component AttachEntity(Component entity)
		{
			return base.AttachEntity(entity) as Component;
		}
		
		virtual public void Combine(ComponentCollection collection)
		{
			base.Combine(collection);
		}
		
		new public Component this[int index]
		{
			get
			{
				return base[index] as Component;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(Component);
		}
	}



	[Serializable]
	abstract public class esComponent : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esComponentQuery GetDynamicQuery()
		{
			return null;
		}

		public esComponent()
		{

		}

		public esComponent(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 assemblyID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(assemblyID);
			else
				return LoadByPrimaryKeyStoredProcedure(assemblyID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 assemblyID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(assemblyID);
			else
				return LoadByPrimaryKeyStoredProcedure(assemblyID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 assemblyID)
		{
			esComponentQuery query = this.GetDynamicQuery();
			query.Where(query.AssemblyID == assemblyID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 assemblyID)
		{
			esParameters parms = new esParameters();
			parms.Add("AssemblyID",assemblyID);
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
						case "AssemblyID": this.str.AssemblyID = (string)value; break;							
						case "AssemblyName": this.str.AssemblyName = (string)value; break;							
						case "UnitID": this.str.UnitID = (string)value; break;							
						case "MakeFile": this.str.MakeFile = (string)value; break;							
						case "W": this.str.W = (string)value; break;							
						case "H": this.str.H = (string)value; break;							
						case "D": this.str.D = (string)value; break;							
						case "Radius": this.str.Radius = (string)value; break;							
						case "Chord": this.str.Chord = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "AssemblyID":
						
							if (value == null || value.GetType().ToString() == "System.Int32")
								this.AssemblyID = (System.Int32?)value;
							break;
						
						case "UnitID":
						
							if (value == null || value.GetType().ToString() == "System.Int32")
								this.UnitID = (System.Int32?)value;
							break;
						
						case "W":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.W = (System.Decimal?)value;
							break;
						
						case "H":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.H = (System.Decimal?)value;
							break;
						
						case "D":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.D = (System.Decimal?)value;
							break;
						
						case "Radius":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Radius = (System.Decimal?)value;
							break;
						
						case "Chord":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Chord = (System.Decimal?)value;
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
		/// Maps to Component.AssemblyID
		/// </summary>
		virtual public System.Int32? AssemblyID
		{
			get
			{
				return base.GetSystemInt32(ComponentMetadata.ColumnNames.AssemblyID);
			}
			
			set
			{
				if(base.SetSystemInt32(ComponentMetadata.ColumnNames.AssemblyID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ComponentMetadata.PropertyNames.AssemblyID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Component.AssemblyName
		/// </summary>
		virtual public System.String AssemblyName
		{
			get
			{
				return base.GetSystemString(ComponentMetadata.ColumnNames.AssemblyName);
			}
			
			set
			{
				if(base.SetSystemString(ComponentMetadata.ColumnNames.AssemblyName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ComponentMetadata.PropertyNames.AssemblyName));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Component.UnitID
		/// </summary>
		virtual public System.Int32? UnitID
		{
			get
			{
				return base.GetSystemInt32(ComponentMetadata.ColumnNames.UnitID);
			}
			
			set
			{
				if(base.SetSystemInt32(ComponentMetadata.ColumnNames.UnitID, value))
				{
					this._UpToUnitByUnitID = null;
					this.OnPropertyChanged("UpToUnitByUnitID");
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ComponentMetadata.PropertyNames.UnitID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Component.MakeFile
		/// </summary>
		virtual public System.String MakeFile
		{
			get
			{
				return base.GetSystemString(ComponentMetadata.ColumnNames.MakeFile);
			}
			
			set
			{
				if(base.SetSystemString(ComponentMetadata.ColumnNames.MakeFile, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ComponentMetadata.PropertyNames.MakeFile));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Component.W
		/// </summary>
		virtual public System.Decimal? W
		{
			get
			{
				return base.GetSystemDecimal(ComponentMetadata.ColumnNames.W);
			}
			
			set
			{
				if(base.SetSystemDecimal(ComponentMetadata.ColumnNames.W, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ComponentMetadata.PropertyNames.W));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Component.H
		/// </summary>
		virtual public System.Decimal? H
		{
			get
			{
				return base.GetSystemDecimal(ComponentMetadata.ColumnNames.H);
			}
			
			set
			{
				if(base.SetSystemDecimal(ComponentMetadata.ColumnNames.H, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ComponentMetadata.PropertyNames.H));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Component.D
		/// </summary>
		virtual public System.Decimal? D
		{
			get
			{
				return base.GetSystemDecimal(ComponentMetadata.ColumnNames.D);
			}
			
			set
			{
				if(base.SetSystemDecimal(ComponentMetadata.ColumnNames.D, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ComponentMetadata.PropertyNames.D));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Component.Radius
		/// </summary>
		virtual public System.Decimal? Radius
		{
			get
			{
				return base.GetSystemDecimal(ComponentMetadata.ColumnNames.Radius);
			}
			
			set
			{
				if(base.SetSystemDecimal(ComponentMetadata.ColumnNames.Radius, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ComponentMetadata.PropertyNames.Radius));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Component.Chord
		/// </summary>
		virtual public System.Decimal? Chord
		{
			get
			{
				return base.GetSystemDecimal(ComponentMetadata.ColumnNames.Chord);
			}
			
			set
			{
				if(base.SetSystemDecimal(ComponentMetadata.ColumnNames.Chord, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(ComponentMetadata.PropertyNames.Chord));
					}
				}
			}
		}
	
		internal protected Unit _UpToUnitByUnitID;
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
			public esStrings(esComponent entity)
			{
				this.entity = entity;
			}
			
	
			public System.String AssemblyID
			{
				get
				{
					System.Int32? data = entity.AssemblyID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AssemblyID = null;
					else entity.AssemblyID = Convert.ToInt32(value);
				}
			}
				
			public System.String AssemblyName
			{
				get
				{
					System.String data = entity.AssemblyName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AssemblyName = null;
					else entity.AssemblyName = Convert.ToString(value);
				}
			}
				
			public System.String UnitID
			{
				get
				{
					System.Int32? data = entity.UnitID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UnitID = null;
					else entity.UnitID = Convert.ToInt32(value);
				}
			}
				
			public System.String MakeFile
			{
				get
				{
					System.String data = entity.MakeFile;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.MakeFile = null;
					else entity.MakeFile = Convert.ToString(value);
				}
			}
				
			public System.String W
			{
				get
				{
					System.Decimal? data = entity.W;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.W = null;
					else entity.W = Convert.ToDecimal(value);
				}
			}
				
			public System.String H
			{
				get
				{
					System.Decimal? data = entity.H;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.H = null;
					else entity.H = Convert.ToDecimal(value);
				}
			}
				
			public System.String D
			{
				get
				{
					System.Decimal? data = entity.D;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.D = null;
					else entity.D = Convert.ToDecimal(value);
				}
			}
				
			public System.String Radius
			{
				get
				{
					System.Decimal? data = entity.Radius;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Radius = null;
					else entity.Radius = Convert.ToDecimal(value);
				}
			}
				
			public System.String Chord
			{
				get
				{
					System.Decimal? data = entity.Chord;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Chord = null;
					else entity.Chord = Convert.ToDecimal(value);
				}
			}
			

			private esComponent entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esComponentQuery query)
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
				throw new Exception("esComponent can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}


	
	public partial class Component : esComponent
	{

				
		#region UpToUnitByUnitID - Many To One
		/// <summary>
		/// Many to One
		/// Foreign Key Name - UnitComponent
		/// </summary>

		[XmlIgnore]
		public Unit UpToUnitByUnitID
		{
			get
			{
				if(this._UpToUnitByUnitID == null
					&& UnitID != null					)
				{
					this._UpToUnitByUnitID = new Unit();
					this._UpToUnitByUnitID.es.Connection.Name = this.es.Connection.Name;
					this.SetPreSave("UpToUnitByUnitID", this._UpToUnitByUnitID);
					this._UpToUnitByUnitID.Query.Where(this._UpToUnitByUnitID.Query.UnitID == this.UnitID);
					this._UpToUnitByUnitID.Query.Load();
				}

				return this._UpToUnitByUnitID;
			}
			
			set
			{
				this.RemovePreSave("UpToUnitByUnitID");
				
				bool changed = this._UpToUnitByUnitID != value;

				if(value == null)
				{
					this.UnitID = null;
					this._UpToUnitByUnitID = null;
				}
				else
				{
					this.UnitID = value.UnitID;
					this._UpToUnitByUnitID = value;
					this.SetPreSave("UpToUnitByUnitID", this._UpToUnitByUnitID);
				}
				
				if( changed )
				{
					this.OnPropertyChanged("UpToUnitByUnitID");
				}
			}
		}
		#endregion
		

		
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
			if(!this.es.IsDeleted && this._UpToUnitByUnitID != null)
			{
				this.UnitID = this._UpToUnitByUnitID.UnitID;
			}
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
	abstract public class esComponentQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return ComponentMetadata.Meta();
			}
		}	
		

		public esQueryItem AssemblyID
		{
			get
			{
				return new esQueryItem(this, ComponentMetadata.ColumnNames.AssemblyID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem AssemblyName
		{
			get
			{
				return new esQueryItem(this, ComponentMetadata.ColumnNames.AssemblyName, esSystemType.String);
			}
		} 
		
		public esQueryItem UnitID
		{
			get
			{
				return new esQueryItem(this, ComponentMetadata.ColumnNames.UnitID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem MakeFile
		{
			get
			{
				return new esQueryItem(this, ComponentMetadata.ColumnNames.MakeFile, esSystemType.String);
			}
		} 
		
		public esQueryItem W
		{
			get
			{
				return new esQueryItem(this, ComponentMetadata.ColumnNames.W, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem H
		{
			get
			{
				return new esQueryItem(this, ComponentMetadata.ColumnNames.H, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem D
		{
			get
			{
				return new esQueryItem(this, ComponentMetadata.ColumnNames.D, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Radius
		{
			get
			{
				return new esQueryItem(this, ComponentMetadata.ColumnNames.Radius, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Chord
		{
			get
			{
				return new esQueryItem(this, ComponentMetadata.ColumnNames.Chord, esSystemType.Decimal);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("ComponentCollection")]
	public partial class ComponentCollection : esComponentCollection, IEnumerable<Component>
	{
		public ComponentCollection()
		{

		}
		
		public static implicit operator List<Component>(ComponentCollection coll)
		{
			List<Component> list = new List<Component>();
			
			foreach (Component emp in coll)
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
				return  ComponentMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ComponentQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new Component(row);
		}

		override protected esEntity CreateEntity()
		{
			return new Component();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public ComponentQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ComponentQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(ComponentQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public Component AddNew()
		{
			Component entity = base.AddNewEntity() as Component;
			
			return entity;
		}

		public Component FindByPrimaryKey(System.Int32 assemblyID)
		{
			return base.FindByPrimaryKey(assemblyID) as Component;
		}


		#region IEnumerable<Component> Members

		IEnumerator<Component> IEnumerable<Component>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as Component;
			}
		}

		#endregion
		
		private ComponentQuery query;
	}


	/// <summary>
	/// Encapsulates the 'Component' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("Component ({AssemblyID})")]
	[Serializable]
	public partial class Component : esComponent
	{
		public Component()
		{

		}
	
		public Component(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return ComponentMetadata.Meta();
			}
		}
		
		
		
		override protected esComponentQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new ComponentQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public ComponentQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new ComponentQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(ComponentQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private ComponentQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
	public partial class ComponentQuery : esComponentQuery
	{
		public ComponentQuery()
		{

		}		
		
		public ComponentQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	
		
			
	}



	[Serializable]
	public partial class ComponentMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected ComponentMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(ComponentMetadata.ColumnNames.AssemblyID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ComponentMetadata.PropertyNames.AssemblyID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;	
			c.NumericPrecision = 10;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(ComponentMetadata.ColumnNames.AssemblyName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = ComponentMetadata.PropertyNames.AssemblyName;
			c.CharacterMaxLength = 50;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(ComponentMetadata.ColumnNames.UnitID, 2, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = ComponentMetadata.PropertyNames.UnitID;	
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(ComponentMetadata.ColumnNames.MakeFile, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = ComponentMetadata.PropertyNames.MakeFile;
			c.CharacterMaxLength = 50;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(ComponentMetadata.ColumnNames.W, 4, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ComponentMetadata.PropertyNames.W;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(ComponentMetadata.ColumnNames.H, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ComponentMetadata.PropertyNames.H;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(ComponentMetadata.ColumnNames.D, 6, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ComponentMetadata.PropertyNames.D;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(ComponentMetadata.ColumnNames.Radius, 7, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ComponentMetadata.PropertyNames.Radius;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(ComponentMetadata.ColumnNames.Chord, 8, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = ComponentMetadata.PropertyNames.Chord;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
		}
		#endregion
	
		static public ComponentMetadata Meta()
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
			 public const string AssemblyID = "AssemblyID";
			 public const string AssemblyName = "AssemblyName";
			 public const string UnitID = "UnitID";
			 public const string MakeFile = "MakeFile";
			 public const string W = "W";
			 public const string H = "H";
			 public const string D = "D";
			 public const string Radius = "Radius";
			 public const string Chord = "Chord";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string AssemblyID = "AssemblyID";
			 public const string AssemblyName = "AssemblyName";
			 public const string UnitID = "UnitID";
			 public const string MakeFile = "MakeFile";
			 public const string W = "W";
			 public const string H = "H";
			 public const string D = "D";
			 public const string Radius = "Radius";
			 public const string Chord = "Chord";
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
			lock (typeof(ComponentMetadata))
			{
				if(ComponentMetadata.mapDelegates == null)
				{
					ComponentMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (ComponentMetadata.meta == null)
				{
					ComponentMetadata.meta = new ComponentMetadata();
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
				

				meta.AddTypeMap("AssemblyID", new esTypeMap("Long", "System.Int32"));
				meta.AddTypeMap("AssemblyName", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("UnitID", new esTypeMap("Long", "System.Int32"));
				meta.AddTypeMap("MakeFile", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("W", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("H", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("D", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("Radius", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("Chord", new esTypeMap("Decimal", "System.Decimal"));			
				
				
				
				meta.Source = "Component";
				meta.Destination = "Component";
				
				meta.spInsert = "proc_ComponentInsert";				
				meta.spUpdate = "proc_ComponentUpdate";		
				meta.spDelete = "proc_ComponentDelete";
				meta.spLoadAll = "proc_ComponentLoadAll";
				meta.spLoadByPrimaryKey = "proc_ComponentLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private ComponentMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
