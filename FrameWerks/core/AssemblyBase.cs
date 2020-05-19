#region Copyright (c) 2011 WeaselWare Software
/************************************************************************************
'
' Copyright  2011 WeaselWare Software 
'
' This software is provided 'as-is', without any express or implied warranty. In no 
' event will the authors be held liable for any damages arising from the use of this 
' software.
' 
' Permission is granted to anyone to use this software for any purpose, including 
' commercial applications, and to alter it and redistribute it freely, subject to the 
' following restrictions:
'
' 1. The origin of this software must not be misrepresented; you must not claim that 
' you wrote the original software. If you use this software in a product, an 
' acknowledgment (see the following) in the product documentation is required.
'
' Portions Copyright 2010 WeaselWare Software
'
' 2. Altered source versions must be plainly marked as such, and must not be 
' misrepresented as being the original software.
'
' 3. This notice may not be removed or altered from any source distribution.
'
'***********************************************************************************/
#endregion

using System;
using System.Reflection ;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;
using System.ComponentModel;


namespace FrameWorks
{
   [Serializable]
   public abstract class AssemblyBase 
   {
      #region Fields

      protected string m_projectID;
      protected string m_projectGroup;
      protected string m_productID;

      protected int m_UnitID;
      protected decimal m_varDecimalOne;
      protected object[] options;
      protected string m_unitName = string.Empty;
      protected string m_projectInstanceName = string.Empty;
      protected decimal m_unitWidth;
      protected decimal m_unitHeight;
      protected decimal m_unitDepth;
      protected decimal m_unitArea;
      protected decimal m_calculatedCost = decimal.Zero;
      protected decimal m_area;
      protected string m_MakeFileName = string.Empty;
      protected List<SubAssemblyBase> m_subAssemblies = new List<SubAssemblyBase>();
      
      #endregion 
      
      #region ICutlistableUnit Members

      public object[] Options
      { get { return options; } set { options = value; } }

      public decimal VarDecimalOne
       {
           get { return m_varDecimalOne ;}
           set { m_varDecimalOne = value;}

       }
      [Category("Pricing")]
      [Description("Price per square foot of the aggregate Unit")]
      public decimal SquareFootPrice
      {
          get
          {
              return Math.Round(Decimal.Divide(CalculatedCost, this.m_area),2);
          }
      }

      public override string ToString()
      {
            return this.UnitName;
      }
      public int UnitID
      {
         get { return m_UnitID; }
         set { m_UnitID = value; }

      }
      [Category("Pricing")]
      [Description("Square foot area of the Unit")]
      public decimal Area
      {
         get
         {
             if (m_unitHeight != decimal.Zero && m_unitWidth != decimal.Zero)
             {
                 m_area = (m_unitHeight * m_unitWidth) / 144;
             }
             return Math.Round(m_area,2);
         }
         set { m_area = value; }

      }
     
      public List<SubAssemblyBase> SubAssemblies
      {
         get { return m_subAssemblies ; }
      }

      public void AddSubAssembly(FrameWorks.SubAssemblyBase subAssembly)
      {
          subAssembly.Parent = this;
          this.SubAssemblies.Add(subAssembly);
      }
   
      #endregion
      
      #region Static Methods
      
      public static  FrameWorks.Unit  FactoryNew(object criteria)
      {
         FrameWorks.Unit newUnit;
         newUnit = null;
         Type t = Type.GetType(criteria.ToString());
         if(t != null)
         {
            newUnit= (FrameWorks.Unit)Activator.CreateInstance(t, true);
         }
      
         return newUnit;
      
      }
      
       #endregion
      [Category("Pricing")]
      [Description("Name of this item in the contract or bid ")]
      public string ProjectInstanceName
      {
         get{ return m_projectInstanceName ;}
         set{ m_projectInstanceName = value;}
 
      }
      public string UnitName
      {
         get{return m_unitName;}
         set{m_unitName = value;}
     
      }

      public string MakeFileName
      {
          get { return m_MakeFileName; }
          set { m_MakeFileName = value; }
      }
      [Category("Pricing")]
      [Description("Total dollar price for the material and labor for the Assembly")]
      public decimal CalculatedCost
      {                 
           get
           {
               m_calculatedCost = decimal.Zero;
               foreach(SubAssemblyBase sub in m_subAssemblies)
               {
                     m_calculatedCost += sub.CalculatedCost;
               }
               return  Math.Round( m_calculatedCost, 2);
           }   
          
      }
         
      #region ICutlistableUnit Members

      [Category("Dimensional")]
      [Description("Width of the Unit")]
      public decimal UnitWidth
      {
         get { return m_unitWidth; }
         set { m_unitWidth = value; }
      }
      [Category("Dimensional")]
      [Description("Height of the Unit")]
      public decimal UnitHeight
      {
         get { return m_unitHeight; }
         set { m_unitHeight = value; }
      }
      [Category("Dimensional")]
      [Description("Depth of the Unit")]
      public decimal UnitDepth
      {
         get { return m_unitDepth; }
         set { m_unitDepth = value; }
      }

      public abstract void Build();
       // Total Rewrite Required
      public virtual void Write()
      {
         
        
      }

      #endregion

      public event EventHandler PartProccessed;


      }
  

}
