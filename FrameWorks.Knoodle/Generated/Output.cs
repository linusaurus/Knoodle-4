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
	abstract public class esOutputCollection : esEntityCollection
	{
		public esOutputCollection()
		{

		}

		protected override string GetCollectionName()
		{
			return "OutputCollection";
		}

		#region Query Logic
		protected void InitQuery(esOutputQuery query)
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
			this.InitQuery(query as esOutputQuery);
		}
		#endregion
		
		virtual public Output DetachEntity(Output entity)
		{
			return base.DetachEntity(entity) as Output;
		}
		
		virtual public Output AttachEntity(Output entity)
		{
			return base.AttachEntity(entity) as Output;
		}
		
		virtual public void Combine(OutputCollection collection)
		{
			base.Combine(collection);
		}
		
		new public Output this[int index]
		{
			get
			{
				return base[index] as Output;
			}
		}

		public override Type GetEntityType()
		{
			return typeof(Output);
		}
	}



	[Serializable]
	abstract public class esOutput : esEntity, INotifyPropertyChanged
	{
		/// <summary>
		/// Used internally by the entity's DynamicQuery mechanism.
		/// </summary>
		virtual protected esOutputQuery GetDynamicQuery()
		{
			return null;
		}

		public esOutput()
		{

		}

		public esOutput(DataRow row)
			: base(row)
		{

		}
		
		#region LoadByPrimaryKey
		public virtual bool LoadByPrimaryKey(System.Int32 cutlistID)
		{
			if(this.es.Connection.SqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(cutlistID);
			else
				return LoadByPrimaryKeyStoredProcedure(cutlistID);
		}

		public virtual bool LoadByPrimaryKey(esSqlAccessType sqlAccessType, System.Int32 cutlistID)
		{
			if (sqlAccessType == esSqlAccessType.DynamicSQL)
				return LoadByPrimaryKeyDynamic(cutlistID);
			else
				return LoadByPrimaryKeyStoredProcedure(cutlistID);
		}

		private bool LoadByPrimaryKeyDynamic(System.Int32 cutlistID)
		{
			esOutputQuery query = this.GetDynamicQuery();
			query.Where(query.CutlistID == cutlistID);
			return query.Load();
		}

		private bool LoadByPrimaryKeyStoredProcedure(System.Int32 cutlistID)
		{
			esParameters parms = new esParameters();
			parms.Add("CutlistID",cutlistID);
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
						case "CutlistID": this.str.CutlistID = (string)value; break;							
						case "PartID": this.str.PartID = (string)value; break;							
						case "SubAssemblyGUID": this.str.SubAssemblyGUID = (string)value; break;							
						case "FunctionalName": this.str.FunctionalName = (string)value; break;							
						case "SourceName": this.str.SourceName = (string)value; break;							
						case "SourceDescription": this.str.SourceDescription = (string)value; break;							
						case "Qnty": this.str.Qnty = (string)value; break;							
						case "Width": this.str.Width = (string)value; break;							
						case "Thick": this.str.Thick = (string)value; break;							
						case "Length": this.str.Length = (string)value; break;							
						case "PartClass": this.str.PartClass = (string)value; break;							
						case "Note": this.str.Note = (string)value; break;							
						case "PartIdentifier": this.str.PartIdentifier = (string)value; break;							
						case "Price": this.str.Price = (string)value; break;							
						case "Area": this.str.Area = (string)value; break;							
						case "Weight": this.str.Weight = (string)value; break;							
						case "PartLabel": this.str.PartLabel = (string)value; break;							
						case "Waste": this.str.Waste = (string)value; break;							
						case "Markup": this.str.Markup = (string)value; break;							
						case "PartType": this.str.PartType = (string)value; break;							
						case "Rate": this.str.Rate = (string)value; break;							
						case "LaborAmount": this.str.LaborAmount = (string)value; break;							
						case "UnitPrice": this.str.UnitPrice = (string)value; break;							
						case "AssemblyName": this.str.AssemblyName = (string)value; break;							
						case "AssemblyID": this.str.AssemblyID = (string)value; break;							
						case "Tax": this.str.Tax = (string)value; break;							
						case "AssemblyWidth": this.str.AssemblyWidth = (string)value; break;							
						case "AssemblyHieght": this.str.AssemblyHieght = (string)value; break;							
						case "AssemblyDepth": this.str.AssemblyDepth = (string)value; break;							
						case "AssemblyArea": this.str.AssemblyArea = (string)value; break;							
						case "SubAssemblyWidth": this.str.SubAssemblyWidth = (string)value; break;							
						case "SubAssemblyHieght": this.str.SubAssemblyHieght = (string)value; break;							
						case "SubAssemblyDepth": this.str.SubAssemblyDepth = (string)value; break;							
						case "SubAssemblyArea": this.str.SubAssemblyArea = (string)value; break;							
						case "Uom": this.str.Uom = (string)value; break;							
						case "JobID": this.str.JobID = (string)value; break;							
						case "ArticleID": this.str.ArticleID = (string)value; break;							
						case "JobName": this.str.JobName = (string)value; break;
					}
				}
				else
				{
					switch (name)
					{	
						case "CutlistID":
						
							if (value == null || value.GetType().ToString() == "System.Int32")
								this.CutlistID = (System.Int32?)value;
							break;
						
						case "PartID":
						
							if (value == null || value.GetType().ToString() == "System.Int32")
								this.PartID = (System.Int32?)value;
							break;
						
						case "Qnty":
						
							if (value == null || value.GetType().ToString() == "System.Int32")
								this.Qnty = (System.Int32?)value;
							break;
						
						case "Width":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Width = (System.Decimal?)value;
							break;
						
						case "Thick":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Thick = (System.Decimal?)value;
							break;
						
						case "Length":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Length = (System.Decimal?)value;
							break;
						
						case "Price":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Price = (System.Decimal?)value;
							break;
						
						case "Area":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Area = (System.Decimal?)value;
							break;
						
						case "Weight":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Weight = (System.Decimal?)value;
							break;
						
						case "Waste":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Waste = (System.Decimal?)value;
							break;
						
						case "Markup":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Markup = (System.Decimal?)value;
							break;
						
						case "Rate":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Rate = (System.Decimal?)value;
							break;
						
						case "LaborAmount":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.LaborAmount = (System.Decimal?)value;
							break;
						
						case "UnitPrice":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.UnitPrice = (System.Decimal?)value;
							break;
						
						case "AssemblyID":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.AssemblyID = (System.Decimal?)value;
							break;
						
						case "Tax":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.Tax = (System.Decimal?)value;
							break;
						
						case "AssemblyWidth":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.AssemblyWidth = (System.Decimal?)value;
							break;
						
						case "AssemblyHieght":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.AssemblyHieght = (System.Decimal?)value;
							break;
						
						case "AssemblyDepth":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.AssemblyDepth = (System.Decimal?)value;
							break;
						
						case "AssemblyArea":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.AssemblyArea = (System.Decimal?)value;
							break;
						
						case "SubAssemblyWidth":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.SubAssemblyWidth = (System.Decimal?)value;
							break;
						
						case "SubAssemblyHieght":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.SubAssemblyHieght = (System.Decimal?)value;
							break;
						
						case "SubAssemblyDepth":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.SubAssemblyDepth = (System.Decimal?)value;
							break;
						
						case "SubAssemblyArea":
						
							if (value == null || value.GetType().ToString() == "System.Decimal")
								this.SubAssemblyArea = (System.Decimal?)value;
							break;
						
						case "Uom":
						
							if (value == null || value.GetType().ToString() == "System.Int16")
								this.Uom = (System.Int16?)value;
							break;
						
						case "JobID":
						
							if (value == null || value.GetType().ToString() == "System.Int32")
								this.JobID = (System.Int32?)value;
							break;
						
						case "ArticleID":
						
							if (value == null || value.GetType().ToString() == "System.Int32")
								this.ArticleID = (System.Int32?)value;
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
		/// Maps to Output.CutlistID
		/// </summary>
		virtual public System.Int32? CutlistID
		{
			get
			{
				return base.GetSystemInt32(OutputMetadata.ColumnNames.CutlistID);
			}
			
			set
			{
				if(base.SetSystemInt32(OutputMetadata.ColumnNames.CutlistID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.CutlistID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.PartID
		/// </summary>
		virtual public System.Int32? PartID
		{
			get
			{
				return base.GetSystemInt32(OutputMetadata.ColumnNames.PartID);
			}
			
			set
			{
				if(base.SetSystemInt32(OutputMetadata.ColumnNames.PartID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.PartID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.SubAssemblyGUID
		/// </summary>
		virtual public System.String SubAssemblyGUID
		{
			get
			{
				return base.GetSystemString(OutputMetadata.ColumnNames.SubAssemblyGUID);
			}
			
			set
			{
				if(base.SetSystemString(OutputMetadata.ColumnNames.SubAssemblyGUID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.SubAssemblyGUID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.FunctionalName
		/// </summary>
		virtual public System.String FunctionalName
		{
			get
			{
				return base.GetSystemString(OutputMetadata.ColumnNames.FunctionalName);
			}
			
			set
			{
				if(base.SetSystemString(OutputMetadata.ColumnNames.FunctionalName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.FunctionalName));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.SourceName
		/// </summary>
		virtual public System.String SourceName
		{
			get
			{
				return base.GetSystemString(OutputMetadata.ColumnNames.SourceName);
			}
			
			set
			{
				if(base.SetSystemString(OutputMetadata.ColumnNames.SourceName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.SourceName));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.SourceDescription
		/// </summary>
		virtual public System.String SourceDescription
		{
			get
			{
				return base.GetSystemString(OutputMetadata.ColumnNames.SourceDescription);
			}
			
			set
			{
				if(base.SetSystemString(OutputMetadata.ColumnNames.SourceDescription, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.SourceDescription));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.Qnty
		/// </summary>
		virtual public System.Int32? Qnty
		{
			get
			{
				return base.GetSystemInt32(OutputMetadata.ColumnNames.Qnty);
			}
			
			set
			{
				if(base.SetSystemInt32(OutputMetadata.ColumnNames.Qnty, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.Qnty));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.Width
		/// </summary>
		virtual public System.Decimal? Width
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.Width);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.Width, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.Width));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.Thick
		/// </summary>
		virtual public System.Decimal? Thick
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.Thick);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.Thick, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.Thick));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.Length
		/// </summary>
		virtual public System.Decimal? Length
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.Length);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.Length, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.Length));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.PartClass
		/// </summary>
		virtual public System.String PartClass
		{
			get
			{
				return base.GetSystemString(OutputMetadata.ColumnNames.PartClass);
			}
			
			set
			{
				if(base.SetSystemString(OutputMetadata.ColumnNames.PartClass, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.PartClass));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.Note
		/// </summary>
		virtual public System.String Note
		{
			get
			{
				return base.GetSystemString(OutputMetadata.ColumnNames.Note);
			}
			
			set
			{
				if(base.SetSystemString(OutputMetadata.ColumnNames.Note, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.Note));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.PartIdentifier
		/// </summary>
		virtual public System.String PartIdentifier
		{
			get
			{
				return base.GetSystemString(OutputMetadata.ColumnNames.PartIdentifier);
			}
			
			set
			{
				if(base.SetSystemString(OutputMetadata.ColumnNames.PartIdentifier, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.PartIdentifier));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.Price
		/// </summary>
		virtual public System.Decimal? Price
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.Price);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.Price, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.Price));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.Area
		/// </summary>
		virtual public System.Decimal? Area
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.Area);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.Area, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.Area));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.Weight
		/// </summary>
		virtual public System.Decimal? Weight
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.Weight);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.Weight, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.Weight));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.PartLabel
		/// </summary>
		virtual public System.String PartLabel
		{
			get
			{
				return base.GetSystemString(OutputMetadata.ColumnNames.PartLabel);
			}
			
			set
			{
				if(base.SetSystemString(OutputMetadata.ColumnNames.PartLabel, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.PartLabel));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.Waste
		/// </summary>
		virtual public System.Decimal? Waste
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.Waste);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.Waste, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.Waste));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.Markup
		/// </summary>
		virtual public System.Decimal? Markup
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.Markup);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.Markup, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.Markup));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.PartType
		/// </summary>
		virtual public System.String PartType
		{
			get
			{
				return base.GetSystemString(OutputMetadata.ColumnNames.PartType);
			}
			
			set
			{
				if(base.SetSystemString(OutputMetadata.ColumnNames.PartType, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.PartType));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.Rate
		/// </summary>
		virtual public System.Decimal? Rate
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.Rate);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.Rate, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.Rate));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.LaborAmount
		/// </summary>
		virtual public System.Decimal? LaborAmount
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.LaborAmount);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.LaborAmount, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.LaborAmount));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.UnitPrice
		/// </summary>
		virtual public System.Decimal? UnitPrice
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.UnitPrice);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.UnitPrice, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.UnitPrice));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.AssemblyName
		/// </summary>
		virtual public System.String AssemblyName
		{
			get
			{
				return base.GetSystemString(OutputMetadata.ColumnNames.AssemblyName);
			}
			
			set
			{
				if(base.SetSystemString(OutputMetadata.ColumnNames.AssemblyName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.AssemblyName));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.AssemblyID
		/// </summary>
		virtual public System.Decimal? AssemblyID
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.AssemblyID);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.AssemblyID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.AssemblyID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.Tax
		/// </summary>
		virtual public System.Decimal? Tax
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.Tax);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.Tax, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.Tax));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.AssemblyWidth
		/// </summary>
		virtual public System.Decimal? AssemblyWidth
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.AssemblyWidth);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.AssemblyWidth, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.AssemblyWidth));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.AssemblyHieght
		/// </summary>
		virtual public System.Decimal? AssemblyHieght
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.AssemblyHieght);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.AssemblyHieght, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.AssemblyHieght));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.AssemblyDepth
		/// </summary>
		virtual public System.Decimal? AssemblyDepth
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.AssemblyDepth);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.AssemblyDepth, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.AssemblyDepth));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.AssemblyArea
		/// </summary>
		virtual public System.Decimal? AssemblyArea
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.AssemblyArea);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.AssemblyArea, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.AssemblyArea));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.SubAssemblyWidth
		/// </summary>
		virtual public System.Decimal? SubAssemblyWidth
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.SubAssemblyWidth);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.SubAssemblyWidth, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.SubAssemblyWidth));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.SubAssemblyHieght
		/// </summary>
		virtual public System.Decimal? SubAssemblyHieght
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.SubAssemblyHieght);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.SubAssemblyHieght, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.SubAssemblyHieght));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.SubAssemblyDepth
		/// </summary>
		virtual public System.Decimal? SubAssemblyDepth
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.SubAssemblyDepth);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.SubAssemblyDepth, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.SubAssemblyDepth));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.SubAssemblyArea
		/// </summary>
		virtual public System.Decimal? SubAssemblyArea
		{
			get
			{
				return base.GetSystemDecimal(OutputMetadata.ColumnNames.SubAssemblyArea);
			}
			
			set
			{
				if(base.SetSystemDecimal(OutputMetadata.ColumnNames.SubAssemblyArea, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.SubAssemblyArea));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.UOM
		/// </summary>
		virtual public System.Int16? Uom
		{
			get
			{
				return base.GetSystemInt16(OutputMetadata.ColumnNames.Uom);
			}
			
			set
			{
				if(base.SetSystemInt16(OutputMetadata.ColumnNames.Uom, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.Uom));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.JobID
		/// </summary>
		virtual public System.Int32? JobID
		{
			get
			{
				return base.GetSystemInt32(OutputMetadata.ColumnNames.JobID);
			}
			
			set
			{
				if(base.SetSystemInt32(OutputMetadata.ColumnNames.JobID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.JobID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.ArticleID
		/// </summary>
		virtual public System.Int32? ArticleID
		{
			get
			{
				return base.GetSystemInt32(OutputMetadata.ColumnNames.ArticleID);
			}
			
			set
			{
				if(base.SetSystemInt32(OutputMetadata.ColumnNames.ArticleID, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.ArticleID));
					}
				}
			}
		}
		
		/// <summary>
		/// Maps to Output.JobName
		/// </summary>
		virtual public System.String JobName
		{
			get
			{
				return base.GetSystemString(OutputMetadata.ColumnNames.JobName);
			}
			
			set
			{
				if(base.SetSystemString(OutputMetadata.ColumnNames.JobName, value))
				{
					if (PropertyChanged != null)
					{
						PropertyChanged(this, new PropertyChangedEventArgs(OutputMetadata.PropertyNames.JobName));
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
			public esStrings(esOutput entity)
			{
				this.entity = entity;
			}
			
	
			public System.String CutlistID
			{
				get
				{
					System.Int32? data = entity.CutlistID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.CutlistID = null;
					else entity.CutlistID = Convert.ToInt32(value);
				}
			}
				
			public System.String PartID
			{
				get
				{
					System.Int32? data = entity.PartID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PartID = null;
					else entity.PartID = Convert.ToInt32(value);
				}
			}
				
			public System.String SubAssemblyGUID
			{
				get
				{
					System.String data = entity.SubAssemblyGUID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SubAssemblyGUID = null;
					else entity.SubAssemblyGUID = Convert.ToString(value);
				}
			}
				
			public System.String FunctionalName
			{
				get
				{
					System.String data = entity.FunctionalName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.FunctionalName = null;
					else entity.FunctionalName = Convert.ToString(value);
				}
			}
				
			public System.String SourceName
			{
				get
				{
					System.String data = entity.SourceName;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SourceName = null;
					else entity.SourceName = Convert.ToString(value);
				}
			}
				
			public System.String SourceDescription
			{
				get
				{
					System.String data = entity.SourceDescription;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SourceDescription = null;
					else entity.SourceDescription = Convert.ToString(value);
				}
			}
				
			public System.String Qnty
			{
				get
				{
					System.Int32? data = entity.Qnty;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Qnty = null;
					else entity.Qnty = Convert.ToInt32(value);
				}
			}
				
			public System.String Width
			{
				get
				{
					System.Decimal? data = entity.Width;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Width = null;
					else entity.Width = Convert.ToDecimal(value);
				}
			}
				
			public System.String Thick
			{
				get
				{
					System.Decimal? data = entity.Thick;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Thick = null;
					else entity.Thick = Convert.ToDecimal(value);
				}
			}
				
			public System.String Length
			{
				get
				{
					System.Decimal? data = entity.Length;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Length = null;
					else entity.Length = Convert.ToDecimal(value);
				}
			}
				
			public System.String PartClass
			{
				get
				{
					System.String data = entity.PartClass;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PartClass = null;
					else entity.PartClass = Convert.ToString(value);
				}
			}
				
			public System.String Note
			{
				get
				{
					System.String data = entity.Note;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Note = null;
					else entity.Note = Convert.ToString(value);
				}
			}
				
			public System.String PartIdentifier
			{
				get
				{
					System.String data = entity.PartIdentifier;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PartIdentifier = null;
					else entity.PartIdentifier = Convert.ToString(value);
				}
			}
				
			public System.String Price
			{
				get
				{
					System.Decimal? data = entity.Price;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Price = null;
					else entity.Price = Convert.ToDecimal(value);
				}
			}
				
			public System.String Area
			{
				get
				{
					System.Decimal? data = entity.Area;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Area = null;
					else entity.Area = Convert.ToDecimal(value);
				}
			}
				
			public System.String Weight
			{
				get
				{
					System.Decimal? data = entity.Weight;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Weight = null;
					else entity.Weight = Convert.ToDecimal(value);
				}
			}
				
			public System.String PartLabel
			{
				get
				{
					System.String data = entity.PartLabel;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PartLabel = null;
					else entity.PartLabel = Convert.ToString(value);
				}
			}
				
			public System.String Waste
			{
				get
				{
					System.Decimal? data = entity.Waste;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Waste = null;
					else entity.Waste = Convert.ToDecimal(value);
				}
			}
				
			public System.String Markup
			{
				get
				{
					System.Decimal? data = entity.Markup;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Markup = null;
					else entity.Markup = Convert.ToDecimal(value);
				}
			}
				
			public System.String PartType
			{
				get
				{
					System.String data = entity.PartType;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.PartType = null;
					else entity.PartType = Convert.ToString(value);
				}
			}
				
			public System.String Rate
			{
				get
				{
					System.Decimal? data = entity.Rate;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Rate = null;
					else entity.Rate = Convert.ToDecimal(value);
				}
			}
				
			public System.String LaborAmount
			{
				get
				{
					System.Decimal? data = entity.LaborAmount;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.LaborAmount = null;
					else entity.LaborAmount = Convert.ToDecimal(value);
				}
			}
				
			public System.String UnitPrice
			{
				get
				{
					System.Decimal? data = entity.UnitPrice;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.UnitPrice = null;
					else entity.UnitPrice = Convert.ToDecimal(value);
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
				
			public System.String AssemblyID
			{
				get
				{
					System.Decimal? data = entity.AssemblyID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AssemblyID = null;
					else entity.AssemblyID = Convert.ToDecimal(value);
				}
			}
				
			public System.String Tax
			{
				get
				{
					System.Decimal? data = entity.Tax;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Tax = null;
					else entity.Tax = Convert.ToDecimal(value);
				}
			}
				
			public System.String AssemblyWidth
			{
				get
				{
					System.Decimal? data = entity.AssemblyWidth;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AssemblyWidth = null;
					else entity.AssemblyWidth = Convert.ToDecimal(value);
				}
			}
				
			public System.String AssemblyHieght
			{
				get
				{
					System.Decimal? data = entity.AssemblyHieght;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AssemblyHieght = null;
					else entity.AssemblyHieght = Convert.ToDecimal(value);
				}
			}
				
			public System.String AssemblyDepth
			{
				get
				{
					System.Decimal? data = entity.AssemblyDepth;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AssemblyDepth = null;
					else entity.AssemblyDepth = Convert.ToDecimal(value);
				}
			}
				
			public System.String AssemblyArea
			{
				get
				{
					System.Decimal? data = entity.AssemblyArea;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.AssemblyArea = null;
					else entity.AssemblyArea = Convert.ToDecimal(value);
				}
			}
				
			public System.String SubAssemblyWidth
			{
				get
				{
					System.Decimal? data = entity.SubAssemblyWidth;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SubAssemblyWidth = null;
					else entity.SubAssemblyWidth = Convert.ToDecimal(value);
				}
			}
				
			public System.String SubAssemblyHieght
			{
				get
				{
					System.Decimal? data = entity.SubAssemblyHieght;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SubAssemblyHieght = null;
					else entity.SubAssemblyHieght = Convert.ToDecimal(value);
				}
			}
				
			public System.String SubAssemblyDepth
			{
				get
				{
					System.Decimal? data = entity.SubAssemblyDepth;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SubAssemblyDepth = null;
					else entity.SubAssemblyDepth = Convert.ToDecimal(value);
				}
			}
				
			public System.String SubAssemblyArea
			{
				get
				{
					System.Decimal? data = entity.SubAssemblyArea;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.SubAssemblyArea = null;
					else entity.SubAssemblyArea = Convert.ToDecimal(value);
				}
			}
				
			public System.String Uom
			{
				get
				{
					System.Int16? data = entity.Uom;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.Uom = null;
					else entity.Uom = Convert.ToInt16(value);
				}
			}
				
			public System.String JobID
			{
				get
				{
					System.Int32? data = entity.JobID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.JobID = null;
					else entity.JobID = Convert.ToInt32(value);
				}
			}
				
			public System.String ArticleID
			{
				get
				{
					System.Int32? data = entity.ArticleID;
					return (data == null) ? String.Empty : Convert.ToString(data);
				}

				set
				{
					if (value == null || value.Length == 0) entity.ArticleID = null;
					else entity.ArticleID = Convert.ToInt32(value);
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
			

			private esOutput entity;
		}
		#endregion

		#region Query Logic
		protected void InitQuery(esOutputQuery query)
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
				throw new Exception("esOutput can only hold one record of data");
			}

			return dataFound;
		}
		#endregion
		
		[NonSerialized]
		private esStrings esstrings;
	}


	
	public partial class Output : esOutput
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
	abstract public class esOutputQuery : esDynamicQuery
	{
		override protected IMetadata Meta
		{
			get
			{
				return OutputMetadata.Meta();
			}
		}	
		

		public esQueryItem CutlistID
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.CutlistID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem PartID
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.PartID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem SubAssemblyGUID
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.SubAssemblyGUID, esSystemType.String);
			}
		} 
		
		public esQueryItem FunctionalName
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.FunctionalName, esSystemType.String);
			}
		} 
		
		public esQueryItem SourceName
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.SourceName, esSystemType.String);
			}
		} 
		
		public esQueryItem SourceDescription
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.SourceDescription, esSystemType.String);
			}
		} 
		
		public esQueryItem Qnty
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.Qnty, esSystemType.Int32);
			}
		} 
		
		public esQueryItem Width
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.Width, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Thick
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.Thick, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Length
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.Length, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem PartClass
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.PartClass, esSystemType.String);
			}
		} 
		
		public esQueryItem Note
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.Note, esSystemType.String);
			}
		} 
		
		public esQueryItem PartIdentifier
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.PartIdentifier, esSystemType.String);
			}
		} 
		
		public esQueryItem Price
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.Price, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Area
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.Area, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Weight
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.Weight, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem PartLabel
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.PartLabel, esSystemType.String);
			}
		} 
		
		public esQueryItem Waste
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.Waste, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Markup
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.Markup, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem PartType
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.PartType, esSystemType.String);
			}
		} 
		
		public esQueryItem Rate
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.Rate, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem LaborAmount
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.LaborAmount, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem UnitPrice
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.UnitPrice, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem AssemblyName
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.AssemblyName, esSystemType.String);
			}
		} 
		
		public esQueryItem AssemblyID
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.AssemblyID, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Tax
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.Tax, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem AssemblyWidth
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.AssemblyWidth, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem AssemblyHieght
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.AssemblyHieght, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem AssemblyDepth
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.AssemblyDepth, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem AssemblyArea
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.AssemblyArea, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem SubAssemblyWidth
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.SubAssemblyWidth, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem SubAssemblyHieght
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.SubAssemblyHieght, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem SubAssemblyDepth
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.SubAssemblyDepth, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem SubAssemblyArea
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.SubAssemblyArea, esSystemType.Decimal);
			}
		} 
		
		public esQueryItem Uom
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.Uom, esSystemType.Int16);
			}
		} 
		
		public esQueryItem JobID
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.JobID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem ArticleID
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.ArticleID, esSystemType.Int32);
			}
		} 
		
		public esQueryItem JobName
		{
			get
			{
				return new esQueryItem(this, OutputMetadata.ColumnNames.JobName, esSystemType.String);
			}
		} 
		
	}



    [System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[Serializable]
	[XmlType("OutputCollection")]
	public partial class OutputCollection : esOutputCollection, IEnumerable<Output>
	{
		public OutputCollection()
		{

		}
		
		public static implicit operator List<Output>(OutputCollection coll)
		{
			List<Output> list = new List<Output>();
			
			foreach (Output emp in coll)
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
				return  OutputMetadata.Meta();
			}
		}
		
		
		
		override protected esDynamicQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new OutputQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		
		override protected esEntity CreateEntityForCollection(DataRow row)
		{
			return new Output(row);
		}

		override protected esEntity CreateEntity()
		{
			return new Output();
		}
		
		
		#endregion


		[BrowsableAttribute( false )]
		public OutputQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OutputQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}

		public bool Load(OutputQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		public Output AddNew()
		{
			Output entity = base.AddNewEntity() as Output;
			
			return entity;
		}

		public Output FindByPrimaryKey(System.Int32 cutlistID)
		{
			return base.FindByPrimaryKey(cutlistID) as Output;
		}


		#region IEnumerable<Output> Members

		IEnumerator<Output> IEnumerable<Output>.GetEnumerator()
		{
			System.Collections.IEnumerable enumer = this as System.Collections.IEnumerable;
			System.Collections.IEnumerator iterator = enumer.GetEnumerator();

			while(iterator.MoveNext())
			{
				yield return iterator.Current as Output;
			}
		}

		#endregion
		
		private OutputQuery query;
	}


	/// <summary>
	/// Encapsulates the 'Output' table
	/// </summary>

    [System.Diagnostics.DebuggerDisplay("Output ({CutlistID})")]
	[Serializable]
	public partial class Output : esOutput
	{
		public Output()
		{

		}
	
		public Output(DataRow row)
			: base(row)
		{

		}
		
		#region Housekeeping methods
		override protected IMetadata Meta
		{
			get
			{
				return OutputMetadata.Meta();
			}
		}
		
		
		
		override protected esOutputQuery GetDynamicQuery()
		{
			if (this.query == null)
			{
				this.query = new OutputQuery();
				this.InitQuery(query);
			}
			return this.query;
		}
		#endregion
		



		[BrowsableAttribute( false )]
		public OutputQuery Query
		{
			get
			{
				if (this.query == null)
				{
					this.query = new OutputQuery();
					base.InitQuery(this.query);
				}

				return this.query;
			}
		}

		public void QueryReset()
		{
			this.query = null;
		}
		

		public bool Load(OutputQuery query)
		{
			this.query = query;
			base.InitQuery(this.query);
			return this.Query.Load();
		}
		
		private OutputQuery query;
	}



    [System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")]
	[Serializable]
	public partial class OutputQuery : esOutputQuery
	{
		public OutputQuery()
		{

		}		
		
		public OutputQuery(string joinAlias)
		{
			this.es.JoinAlias = joinAlias;
		}	
		
			
	}



	[Serializable]
	public partial class OutputMetadata : esMetadata, IMetadata
	{
		#region Protected Constructor
		protected OutputMetadata()
		{
			_columns = new esColumnMetadataCollection();
			esColumnMetadata c;

			c = new esColumnMetadata(OutputMetadata.ColumnNames.CutlistID, 0, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OutputMetadata.PropertyNames.CutlistID;
			c.IsInPrimaryKey = true;
			c.IsAutoIncrement = true;	
			c.NumericPrecision = 10;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.PartID, 1, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OutputMetadata.PropertyNames.PartID;	
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.SubAssemblyGUID, 2, typeof(System.String), esSystemType.String);
			c.PropertyName = OutputMetadata.PropertyNames.SubAssemblyGUID;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.FunctionalName, 3, typeof(System.String), esSystemType.String);
			c.PropertyName = OutputMetadata.PropertyNames.FunctionalName;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.SourceName, 4, typeof(System.String), esSystemType.String);
			c.PropertyName = OutputMetadata.PropertyNames.SourceName;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.SourceDescription, 5, typeof(System.String), esSystemType.String);
			c.PropertyName = OutputMetadata.PropertyNames.SourceDescription;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.Qnty, 6, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OutputMetadata.PropertyNames.Qnty;	
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.Width, 7, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.Width;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.Thick, 8, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.Thick;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.Length, 9, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.Length;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.PartClass, 10, typeof(System.String), esSystemType.String);
			c.PropertyName = OutputMetadata.PropertyNames.PartClass;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.Note, 11, typeof(System.String), esSystemType.String);
			c.PropertyName = OutputMetadata.PropertyNames.Note;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.PartIdentifier, 12, typeof(System.String), esSystemType.String);
			c.PropertyName = OutputMetadata.PropertyNames.PartIdentifier;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.Price, 13, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.Price;	
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.Area, 14, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.Area;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.Weight, 15, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.Weight;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.PartLabel, 16, typeof(System.String), esSystemType.String);
			c.PropertyName = OutputMetadata.PropertyNames.PartLabel;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.Waste, 17, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.Waste;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.Markup, 18, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.Markup;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.PartType, 19, typeof(System.String), esSystemType.String);
			c.PropertyName = OutputMetadata.PropertyNames.PartType;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.Rate, 20, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.Rate;	
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.LaborAmount, 21, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.LaborAmount;	
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.UnitPrice, 22, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.UnitPrice;	
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.AssemblyName, 23, typeof(System.String), esSystemType.String);
			c.PropertyName = OutputMetadata.PropertyNames.AssemblyName;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.AssemblyID, 24, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.AssemblyID;	
			c.NumericPrecision = 18;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.Tax, 25, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.Tax;	
			c.NumericPrecision = 18;
			c.NumericScale = 2;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.AssemblyWidth, 26, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.AssemblyWidth;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.AssemblyHieght, 27, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.AssemblyHieght;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.AssemblyDepth, 28, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.AssemblyDepth;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.AssemblyArea, 29, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.AssemblyArea;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.SubAssemblyWidth, 30, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.SubAssemblyWidth;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.SubAssemblyHieght, 31, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.SubAssemblyHieght;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.SubAssemblyDepth, 32, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.SubAssemblyDepth;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.SubAssemblyArea, 33, typeof(System.Decimal), esSystemType.Decimal);
			c.PropertyName = OutputMetadata.PropertyNames.SubAssemblyArea;	
			c.NumericPrecision = 18;
			c.NumericScale = 4;
			c.HasDefault = true;
			c.Default = @"0";
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.Uom, 34, typeof(System.Int16), esSystemType.Int16);
			c.PropertyName = OutputMetadata.PropertyNames.Uom;	
			c.NumericPrecision = 5;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.JobID, 35, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OutputMetadata.PropertyNames.JobID;	
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.ArticleID, 36, typeof(System.Int32), esSystemType.Int32);
			c.PropertyName = OutputMetadata.PropertyNames.ArticleID;	
			c.NumericPrecision = 10;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
			c = new esColumnMetadata(OutputMetadata.ColumnNames.JobName, 37, typeof(System.String), esSystemType.String);
			c.PropertyName = OutputMetadata.PropertyNames.JobName;
			c.CharacterMaxLength = 255;
			c.NumericPrecision = 0;
			c.IsNullable = true;
			_columns.Add(c); 
			
				
		}
		#endregion
	
		static public OutputMetadata Meta()
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
			 public const string CutlistID = "CutlistID";
			 public const string PartID = "PartID";
			 public const string SubAssemblyGUID = "SubAssemblyGUID";
			 public const string FunctionalName = "FunctionalName";
			 public const string SourceName = "SourceName";
			 public const string SourceDescription = "SourceDescription";
			 public const string Qnty = "Qnty";
			 public const string Width = "Width";
			 public const string Thick = "Thick";
			 public const string Length = "Length";
			 public const string PartClass = "PartClass";
			 public const string Note = "Note";
			 public const string PartIdentifier = "PartIdentifier";
			 public const string Price = "Price";
			 public const string Area = "Area";
			 public const string Weight = "Weight";
			 public const string PartLabel = "PartLabel";
			 public const string Waste = "Waste";
			 public const string Markup = "Markup";
			 public const string PartType = "PartType";
			 public const string Rate = "Rate";
			 public const string LaborAmount = "LaborAmount";
			 public const string UnitPrice = "UnitPrice";
			 public const string AssemblyName = "AssemblyName";
			 public const string AssemblyID = "AssemblyID";
			 public const string Tax = "Tax";
			 public const string AssemblyWidth = "AssemblyWidth";
			 public const string AssemblyHieght = "AssemblyHieght";
			 public const string AssemblyDepth = "AssemblyDepth";
			 public const string AssemblyArea = "AssemblyArea";
			 public const string SubAssemblyWidth = "SubAssemblyWidth";
			 public const string SubAssemblyHieght = "SubAssemblyHieght";
			 public const string SubAssemblyDepth = "SubAssemblyDepth";
			 public const string SubAssemblyArea = "SubAssemblyArea";
			 public const string Uom = "UOM";
			 public const string JobID = "JobID";
			 public const string ArticleID = "ArticleID";
			 public const string JobName = "JobName";
		}
		#endregion	
		
		#region PropertyNames
		public class PropertyNames
		{ 
			 public const string CutlistID = "CutlistID";
			 public const string PartID = "PartID";
			 public const string SubAssemblyGUID = "SubAssemblyGUID";
			 public const string FunctionalName = "FunctionalName";
			 public const string SourceName = "SourceName";
			 public const string SourceDescription = "SourceDescription";
			 public const string Qnty = "Qnty";
			 public const string Width = "Width";
			 public const string Thick = "Thick";
			 public const string Length = "Length";
			 public const string PartClass = "PartClass";
			 public const string Note = "Note";
			 public const string PartIdentifier = "PartIdentifier";
			 public const string Price = "Price";
			 public const string Area = "Area";
			 public const string Weight = "Weight";
			 public const string PartLabel = "PartLabel";
			 public const string Waste = "Waste";
			 public const string Markup = "Markup";
			 public const string PartType = "PartType";
			 public const string Rate = "Rate";
			 public const string LaborAmount = "LaborAmount";
			 public const string UnitPrice = "UnitPrice";
			 public const string AssemblyName = "AssemblyName";
			 public const string AssemblyID = "AssemblyID";
			 public const string Tax = "Tax";
			 public const string AssemblyWidth = "AssemblyWidth";
			 public const string AssemblyHieght = "AssemblyHieght";
			 public const string AssemblyDepth = "AssemblyDepth";
			 public const string AssemblyArea = "AssemblyArea";
			 public const string SubAssemblyWidth = "SubAssemblyWidth";
			 public const string SubAssemblyHieght = "SubAssemblyHieght";
			 public const string SubAssemblyDepth = "SubAssemblyDepth";
			 public const string SubAssemblyArea = "SubAssemblyArea";
			 public const string Uom = "Uom";
			 public const string JobID = "JobID";
			 public const string ArticleID = "ArticleID";
			 public const string JobName = "JobName";
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
			lock (typeof(OutputMetadata))
			{
				if(OutputMetadata.mapDelegates == null)
				{
					OutputMetadata.mapDelegates = new Dictionary<string,MapToMeta>();
				}
				
				if (OutputMetadata.meta == null)
				{
					OutputMetadata.meta = new OutputMetadata();
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
				

				meta.AddTypeMap("CutlistID", new esTypeMap("Long", "System.Int32"));
				meta.AddTypeMap("PartID", new esTypeMap("Long", "System.Int32"));
				meta.AddTypeMap("SubAssemblyGUID", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("FunctionalName", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("SourceName", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("SourceDescription", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("Qnty", new esTypeMap("Long", "System.Int32"));
				meta.AddTypeMap("Width", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("Thick", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("Length", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("PartClass", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("Note", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("PartIdentifier", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("Price", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("Area", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("Weight", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("PartLabel", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("Waste", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("Markup", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("PartType", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("Rate", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("LaborAmount", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("UnitPrice", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("AssemblyName", new esTypeMap("Text", "System.String"));
				meta.AddTypeMap("AssemblyID", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("Tax", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("AssemblyWidth", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("AssemblyHieght", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("AssemblyDepth", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("AssemblyArea", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("SubAssemblyWidth", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("SubAssemblyHieght", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("SubAssemblyDepth", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("SubAssemblyArea", new esTypeMap("Decimal", "System.Decimal"));
				meta.AddTypeMap("UOM", new esTypeMap("Integer", "System.Int16"));
				meta.AddTypeMap("JobID", new esTypeMap("Long", "System.Int32"));
				meta.AddTypeMap("ArticleID", new esTypeMap("Long", "System.Int32"));
				meta.AddTypeMap("JobName", new esTypeMap("Text", "System.String"));			
				
				
				
				meta.Source = "Output";
				meta.Destination = "Output";
				
				meta.spInsert = "proc_OutputInsert";				
				meta.spUpdate = "proc_OutputUpdate";		
				meta.spDelete = "proc_OutputDelete";
				meta.spLoadAll = "proc_OutputLoadAll";
				meta.spLoadByPrimaryKey = "proc_OutputLoadByPrimaryKey";
				
				this._providerMetadataMaps["esDefault"] = meta;
			}
			
			return this._providerMetadataMaps["esDefault"];
		}

		#endregion

		static private OutputMetadata meta;
		static protected Dictionary<string, MapToMeta> mapDelegates;
		static private int _esDefault = RegisterDelegateesDefault();
	}
}
