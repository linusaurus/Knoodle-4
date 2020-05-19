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
	abstract public class esUnitCollection : esEntityCollection
	{
		public esUnitCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "UnitCollection";
		}

		#region Query Logic
		protected void InitQuery(esUnitQuery query)
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
			this.InitQuery(query as esUnitQuery);
		}
		#endregion
		
		virtual public Unit DetachEntity(Unit entity)
		{
			return base.DetachEntity(entity) as Unit;
		}
		
		virtual public Unit AttachEntity(Unit entity)
		{
			return base.AttachEntity(entity) as Unit;
		}
		
		virtual public void Combine(UnitCollection collection)
		{
			base.Combine(collection);
		}
		
		new public Unit this[int index]
		{
			get
			{
				return base[index] as Unit;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(Unit);
		}
	}



	[Serializable]
	abstract public class esUnit : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esUnitQuery GetDynamicQuery()
		{
			return null;
		}

		public esUnit()
		{

		}

		public esUnit(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 unitID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(unitID);
			else
				return LoadByPrimaryKeyStoredProcedure(unitID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 unitID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(unitID);
			else
				return LoadByPrimaryKeyStoredProcedure(unitID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 unitID)
		{
			esUnitQuery query = this.GetDynamicQuery();
			query.Where(query.UnitID == unitID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 unitID)
		{
			esParameters parms = new esParameters();
			parms.Add("UnitID",unitID);
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
						case "UnitID": this.str.UnitID = (string)value; break;							
						case "UnitName": this.str.UnitName = (string)value; break;							
						case "ArchDescription": this.str.ArchDescription = (string)value; break;							
						case "Make": this.str.Make = (string)value; break;							
						case "Fow": this.str.Fow = (string)value; break;							
						case "Foh": this.str.Foh = (string)value; break;							
						case "Fod": this.str.Fod = (string)value; break;							
						case "Row": this.str.Row = (string)value; break;							
						case "Roh": this.str.Roh = (string)value; break;							
						case "MakeFile": this.str.MakeFile = (string)value; break;							
						case "Level": this.str.Level = (string)value; break;							
						case "Room": this.str.Room = (string)value; break;							
						case "ProjectID": this.str.ProjectID = (string)value; break;							
						case "ProductionID": this.str.ProductionID = (string)value; break;							
						case "ProjectGroupID": this.str.ProjectGroupID = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "UnitID":
						
							if (value == null || value.GetType().ToString() == "System.Int32")
								this.UnitID = (System.Int32?)value;
							break;
						
						case "Make":
						
							if (value == null || value.GetType().ToString() == "System.Boolean")
								this.Make = (System.Boolean?)value;
							break;
						
						case "Fow":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Fow = (System.Decimal?)value;
							break;
						
						case "Foh":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Foh = (System.Decimal?)value;
							break;
						
						case "Fod":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Fod = (System.Decimal?)value;
							break;
						
						case "Row":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Row = (System.Decimal?)value;
							break;
						
						case "Roh":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Roh = (System.Decimal?)value;
							break;
						
						case "Level":
						
							if (value == null || value.GetType().ToString() == "System.Int32")
								this.Level = (System.Int32?)value;
							break;
						
						case "ProjectID":
						
							if (value == null || value.GetType().ToString() == "System.Int32")
								this.ProjectID = (System.Int32?)value;
							break;
						
						case "ProductionID":
						
							if (value == null || value.GetType().ToString() == "System.Int32")
								this.ProductionID = (System.Int32?)value;
							break;
					

						default:
							break;
					}
				}
			}
            //else if(this.Row.Table.Columns.Contains(name))
            //{
            //    this.Row[name] = value;
            //}
			else
			{
				throw new Exception("SetProperty Error: '" + name + "' not found");
			}
		}
		
		
		/// <summary>
		/// Maps to Unit.UnitID
		/// </summary>
		virtual public System.Int32? UnitID
		{
			get
			{
				return base.GetSystemInt32(UnitMetadata.ColumnNames.UnitID);
			}
			
			set
			{
				if(base.SetSystemInt32(UnitMetadata.ColumnNames.UnitID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.UnitID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.UnitName
		/// </summary>
		virtual public System.String UnitName
		{
			get
			{
				return base.GetSystemString(UnitMetadata.ColumnNames.UnitName);
			}
			
			set
			{
				if(base.SetSystemString(UnitMetadata.ColumnNames.UnitName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.UnitName));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.ArchDescription
		/// </summary>
		virtual public System.String ArchDescription
		{
			get
			{
				return base.GetSystemString(UnitMetadata.ColumnNames.ArchDescription);
			}
			
			set
			{
				if(base.SetSystemString(UnitMetadata.ColumnNames.ArchDescription, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.ArchDescription));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.Make
		/// </summary>
		virtual public System.Boolean? Make
		{
			get
			{
				return base.GetSystemBoolean(UnitMetadata.ColumnNames.Make);
			}
			
			set
			{
				if(base.SetSystemBoolean(UnitMetadata.ColumnNames.Make, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.Make));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.FOW
		/// </summary>
		virtual public System.Decimal? Fow
		{
			get
			{
				return base.GetSystemDecimal(UnitMetadata.ColumnNames.Fow);
			}
			
			set
			{
				if(base.SetSystemDecimal(UnitMetadata.ColumnNames.Fow, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.Fow));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.FOH
		/// </summary>
		virtual public System.Decimal? Foh
		{
			get
			{
				return base.GetSystemDecimal(UnitMetadata.ColumnNames.Foh);
			}
			
			set
			{
				if(base.SetSystemDecimal(UnitMetadata.ColumnNames.Foh, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.Foh));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.FOD
		/// </summary>
		virtual public System.Decimal? Fod
		{
			get
			{
				return base.GetSystemDecimal(UnitMetadata.ColumnNames.Fod);
			}
			
			set
			{
				if(base.SetSystemDecimal(UnitMetadata.ColumnNames.Fod, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.Fod));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.ROW
		/// </summary>
		virtual public System.Decimal? Row
		{
			get
			{
				return base.GetSystemDecimal(UnitMetadata.ColumnNames.Row);
			}
			
			set
			{
				if(base.SetSystemDecimal(UnitMetadata.ColumnNames.Row, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.Row));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.ROH
		/// </summary>
		virtual public System.Decimal? Roh
		{
			get
			{
				return base.GetSystemDecimal(UnitMetadata.ColumnNames.Roh);
			}
			
			set
			{
				if(base.SetSystemDecimal(UnitMetadata.ColumnNames.Roh, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.Roh));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.MakeFile
		/// </summary>
		virtual public System.String MakeFile
		{
			get
			{
				return base.GetSystemString(UnitMetadata.ColumnNames.MakeFile);
			}
			
			set
			{
				if(base.SetSystemString(UnitMetadata.ColumnNames.MakeFile, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.MakeFile));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.Level
		/// </summary>
		virtual public System.Int32? Level
		{
			get
			{
				return base.GetSystemInt32(UnitMetadata.ColumnNames.Level);
			}
			
			set
			{
				if(base.SetSystemInt32(UnitMetadata.ColumnNames.Level, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.Level));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.Room
		/// </summary>
		virtual public System.String Room
		{
			get
			{
				return base.GetSystemString(UnitMetadata.ColumnNames.Room);
			}
			
			set
			{
				if(base.SetSystemString(UnitMetadata.ColumnNames.Room, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.Room));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.ProjectID
		/// </summary>
		virtual public System.Int32? ProjectID
		{
			get
			{
				return base.GetSystemInt32(UnitMetadata.ColumnNames.ProjectID);
			}
			
			set
			{
				if(base.SetSystemInt32(UnitMetadata.ColumnNames.ProjectID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.ProjectID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.ProductionID
		/// </summary>
		virtual public System.Int32? ProductionID
		{
			get
			{
				return base.GetSystemInt32(UnitMetadata.ColumnNames.ProductionID);
			}
			
			set
			{
				if(base.SetSystemInt32(UnitMetadata.ColumnNames.ProductionID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.ProductionID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Unit.ProjectGroupID
		/// </summary>
		virtual public System.String ProjectGroupID
		{
			get
			{
				return base.GetSystemString(UnitMetadata.ColumnNames.ProjectGroupID);
			}
			
			set
			{
				if(base.SetSystemString(UnitMetadata.ColumnNames.ProjectGroupID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(UnitMetadata.PropertyNames.ProjectGroupID));
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
			public esStrings(esUnit entity)
			{
				this.entity = entity;
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
				
			public System.String UnitName
			{
				get
				{
					System.String data = entity.UnitName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UnitName = null;
					else entity.UnitName = Convert.ToString(value);
				}
			}
				
			public System.String ArchDescription
			{
				get
				{
					System.String data = entity.ArchDescription;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ArchDescription = null;
					else entity.ArchDescription = Convert.ToString(value);
				}
			}
				
			public System.String Make
			{
				get
				{
					System.Boolean? data = entity.Make;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Make = null;
					else entity.Make = Convert.ToBoolean(value);
				}
			}
				
			public System.String Fow
			{
				get
				{
					System.Decimal? data = entity.Fow;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Fow = null;
					else entity.Fow = Convert.ToDecimal(value);
				}
			}
				
			public System.String Foh
			{
				get
				{
					System.Decimal? data = entity.Foh;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Foh = null;
					else entity.Foh = Convert.ToDecimal(value);
				}
			}
				
			public System.String Fod
			{
				get
				{
					System.Decimal? data = entity.Fod;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Fod = null;
					else entity.Fod = Convert.ToDecimal(value);
				}
			}
				
			public System.String Row
			{
				get
				{
					System.Decimal? data = entity.Row;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Row = null;
					else entity.Row = Convert.ToDecimal(value);
				}
			}
				
			public System.String Roh
			{
				get
				{
					System.Decimal? data = entity.Roh;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Roh = null;
					else entity.Roh = Convert.ToDecimal(value);
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
				
			public System.String Level
			{
				get
				{
					System.Int32? data = entity.Level;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Level = null;
					else entity.Level = Convert.ToInt32(value);
				}
			}
				
			public System.String Room
			{
				get
				{
					System.String data = entity.Room;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Room = null;
					else entity.Room = Convert.ToString(value);
				}
			}
				
			public System.String ProjectID
			{
				get
				{
					System.Int32? data = entity.ProjectID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProjectID = null;
					else entity.ProjectID = Convert.ToInt32(value);
				}
			}
				
			public System.String ProductionID
			{
				get
				{
					System.Int32? data = entity.ProductionID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProductionID = null;
					else entity.ProductionID = Convert.ToInt32(value);
				}
			}
				
			public System.String ProjectGroupID
			{
				get
				{
					System.String data = entity.ProjectGroupID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ProjectGroupID = null;
					else entity.ProjectGroupID = Convert.ToString(value);
				}
			}
			

			private esUnit entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esUnitQuery query)
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
				throw new Exception("esUnit can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}


	
	public partial class Unit : esUnit
	{

				
		#region ComponentCollectionByUnitID - Zero To Many
		/// <summary>
		/// Zero to Many
		/// Foreign Key Name - UnitComponent
		/// </summary>

		[XmlIgnore]
		public ComponentCollection ComponentCollectionByUnitID
		{
			get
			{
				if(this._ComponentCollectionByUnitID == null)
				{
					this._ComponentCollectionByUnitID = new ComponentCollection();
					this._ComponentCollectionByUnitID.es.Connection.Name = this.es.Connection.Name;
					this.SetPostSave("ComponentCollectionByUnitID", this._ComponentCollectionByUnitID);
				
					if(this.UnitID != null)
					{
                     
                        this._ComponentCollectionByUnitID.Query.Where(this._ComponentCollectionByUnitID.Query.UnitID == this.UnitID);
                        this._ComponentCollectionByUnitID.Query.Load();
                        // Auto-hookup Foreign Keys
                        this._ComponentCollectionByUnitID.fks.Add(ComponentMetadata.ColumnNames.UnitID, this.UnitID);

					}
				}

				return this._ComponentCollectionByUnitID;
			}
			
			set 
			{ 
				if (value != null) throw new Exception("'value' Must be null"); 
			 
				if (this._ComponentCollectionByUnitID != null) 
				{ 
					this.RemovePostSave("ComponentCollectionByUnitID"); 
					this._ComponentCollectionByUnitID = null;
					this.OnPropertyChanged("ComponentCollectionByUnitID");
				} 
			} 			
		}

		private ComponentCollection _ComponentCollectionByUnitID;
		#endregion

		
		/// <summary>
		/// Used internally by the entity's hierarchical properties.
		/// </summary>
		protected override List<esPropertyDescriptor> GetHierarchicalProperties()
		{
			List<esPropertyDescriptor> props = new List<esPropertyDescriptor>();
			
			props.Add(new esPropertyDescriptor(this, "ComponentCollectionByUnitID", typeof(ComponentCollection), new Component()));
		
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
			if(this._ComponentCollectionByUnitID != null)
			{
				foreach(Component obj in this._ComponentCollectionByUnitID)
				{
					if(obj.es.IsAdded)
					{
						obj.UnitID = this.UnitID;
					}
				}
			}
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
	abstract public class esUnitQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return UnitMetadata.Meta();
			}
		}	
		

		public esQueryItem UnitID
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.UnitID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem UnitName
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.UnitName, esSystemType.String);
			}
		} 
		
		public esQueryItem ArchDescription
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.ArchDescription, esSystemType.String);
			}
		} 
		
		public esQueryItem Make
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.Make, esSystemType.Boolean);
			}
		} 
		
		public esQueryItem Fow
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.Fow, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Foh
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.Foh, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Fod
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.Fod, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Row
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.Row, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Roh
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.Roh, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem MakeFile
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.MakeFile, esSystemType.String);
			}
		} 
		
		public esQueryItem Level
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.Level, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Room
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.Room, esSystemType.String);
			}
		} 
		
		public esQueryItem ProjectID
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.ProjectID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem ProductionID
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.ProductionID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem ProjectGroupID
		{
			get
			{
				return new esQueryItem(this, UnitMetadata.ColumnNames.ProjectGroupID, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("UnitCollection")]
	public partial class UnitCollection : esUnitCollection, IEnumerable<Unit>
	{
		public UnitCollection()
		{

		}
		
		public static implicit operator List<Unit>(UnitCollection coll)
		{
			List<Unit> list = new List<Unit>();
			
			foreach (Unit emp in coll)
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
				return  UnitMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new UnitQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new Unit(row);
		}

		override protected esEntity CreateEntity()
		{
			return new Unit();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public UnitQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new UnitQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(UnitQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public Unit AddNew()
		{
			Unit entity = base.AddNewEntity() as Unit;
			
			return entity;
		}

		public Unit FindByPrimaryKey(System.Int32 unitID)
		{
			return base.FindByPrimaryKey(unitID) as Unit;
		}


		#region IEnumerable<Unit> Members

		IEnumerator<Unit> IEnumerable<Unit>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as Unit;
			}
		}

		#endregion
		
		private UnitQuery query;
	}


	/// <summary>
	/// Encapsulates the 'Unit' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("Unit ({UnitID})")]
	[Serializable]
	public partial class Unit : esUnit
	{
		public Unit()
		{

		}
	
		public Unit(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return UnitMetadata.Meta();
			}
		}
		
		
		
		override protected esUnitQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new UnitQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public UnitQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new UnitQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(UnitQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private UnitQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
	public partial class UnitQuery : esUnitQuery
	{
		public UnitQuery()
		{

		}		
		
		public UnitQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	
		
			
	}



	[Serializable]
	public partial class UnitMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected UnitMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(UnitMetadata.ColumnNames.UnitID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UnitMetadata.PropertyNames.UnitID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;	
			c.NumericPrecision = 10;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.UnitName, 1, typeof(System.String), esSystemType.String);
			c.PropertyName = UnitMetadata.PropertyNames.UnitName;
			c.CharacterMaxLength = 50;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.ArchDescription, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = UnitMetadata.PropertyNames.ArchDescription;
			c.CharacterMaxLength = 200;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.Make, 3, typeof(System.Boolean), esSystemType.Boolean);
			c.PropertyName = UnitMetadata.PropertyNames.Make;
			c.CharacterMaxLength = 2;
			c.NumericPrecision = 0;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.Fow, 4, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = UnitMetadata.PropertyNames.Fow;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.Foh, 5, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = UnitMetadata.PropertyNames.Foh;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.Fod, 6, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = UnitMetadata.PropertyNames.Fod;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.Row, 7, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = UnitMetadata.PropertyNames.Row;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.Roh, 8, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = UnitMetadata.PropertyNames.Roh;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.MakeFile, 9, typeof(System.String), esSystemType.String);
			c.PropertyName = UnitMetadata.PropertyNames.MakeFile;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.Level, 10, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UnitMetadata.PropertyNames.Level;	
			c.NumericPrecision = 10;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.Room, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = UnitMetadata.PropertyNames.Room;
			c.CharacterMaxLength = 50;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.ProjectID, 12, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UnitMetadata.PropertyNames.ProjectID;	
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.ProductionID, 13, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = UnitMetadata.PropertyNames.ProductionID;	
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(UnitMetadata.ColumnNames.ProjectGroupID, 14, typeof(System.String), esSystemType.String);
			c.PropertyName = UnitMetadata.PropertyNames.ProjectGroupID;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
		}
		#endregion
	
		static public UnitMetadata Meta()
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
			 public const string UnitID = "UnitID";
			 public const string UnitName = "UnitName";
			 public const string ArchDescription = "ArchDescription";
			 public const string Make = "Make";
			 public const string Fow = "FOW";
			 public const string Foh = "FOH";
			 public const string Fod = "FOD";
			 public const string Row = "ROW";
			 public const string Roh = "ROH";
			 public const string MakeFile = "MakeFile";
			 public const string Level = "Level";
			 public const string Room = "Room";
			 public const string ProjectID = "ProjectID";
			 public const string ProductionID = "ProductionID";
			 public const string ProjectGroupID = "ProjectGroupID";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string UnitID = "UnitID";
			 public const string UnitName = "UnitName";
			 public const string ArchDescription = "ArchDescription";
			 public const string Make = "Make";
			 public const string Fow = "Fow";
			 public const string Foh = "Foh";
			 public const string Fod = "Fod";
			 public const string Row = "Row";
			 public const string Roh = "Roh";
			 public const string MakeFile = "MakeFile";
			 public const string Level = "Level";
			 public const string Room = "Room";
			 public const string ProjectID = "ProjectID";
			 public const string ProductionID = "ProductionID";
			 public const string ProjectGroupID = "ProjectGroupID";
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
			lock (typeof(UnitMetadata))
			{
				if(UnitMetadata.mapDelegates == null)
				{
					UnitMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (UnitMetadata.meta == null)
				{
					UnitMetadata.meta = new UnitMetadata();
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
				

				meta.AddTypeMap("UnitID", new esTypeMap("Long", "System.Int32"));
				meta.AddTypeMap("UnitName", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("ArchDescription", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("Make", new esTypeMap("Yes/No", "System.Boolean"));
				meta.AddTypeMap("FOW", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("FOH", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("FOD", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("ROW", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("ROH", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("MakeFile", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("Level", new esTypeMap("Long", "System.Int32"));
				meta.AddTypeMap("Room", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("ProjectID", new esTypeMap("Long", "System.Int32"));
				meta.AddTypeMap("ProductionID", new esTypeMap("Long", "System.Int32"));
				meta.AddTypeMap("ProjectGroupID", new esTypeMap("Text", "System.String"));			
				
				
				
				meta.Source = "Unit";
				meta.Destination = "Unit";
				
				meta.spInsert = "proc_UnitInsert";				
				meta.spUpdate = "proc_UnitUpdate";		
				meta.spDelete = "proc_UnitDelete";
				meta.spLoadAll = "proc_UnitLoadAll";
				meta.spLoadByPrimaryKey = "proc_UnitLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private UnitMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
