#region Copyright (c) 2008 WeaselWare Software
/************************************************************************************
'
' Copyright  2008 WeaselWare Software 
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
' Portions Copyright 2008 WeaselWare Software
'
' 2. Altered source versions must be plainly marked as such, and must not be 
' misrepresented as being the original software.
'
' 3. This notice may not be removed or altered from any source distribution.
'
'***********************************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using FrameWorks.Makes;

namespace FrameWorks 
{
   [Serializable]
    public abstract class SubAssemblyBase 
   {
      
      #region Fields
      
      
      protected Guid m_subAssemblyID = new Guid();
      protected int m_ID;
      protected AssemblyBase m_parent;
      protected List<Part> m_parts = new List<Part>();
      protected string m_modelID;
      protected string m_name;
      protected decimal m_subAssemblyWidth;
      protected decimal m_subAssemblyHieght;
      protected decimal m_subAssemblyDepth;
      protected decimal m_calculatedCost;
      protected static int counter;
      protected decimal m_area;
      protected decimal m_perimeter;
      protected decimal m_wieght;
      protected decimal m_radius;
      protected decimal m_laborTotal;
      protected FrameWorks.Workorder m_workorder;

    
      
      #endregion

       public static SubAssemblyBase  FactoryNew(object criteria)
       {
           SubAssemblyBase newAssembly;
           newAssembly = null;
           Type t = Type.GetType(criteria.ToString());
           try
           {
                if (t != null)
               {
                 newAssembly = (SubAssemblyBase)Activator.CreateInstance(t, true);
                 newAssembly.subassemblyID = Guid.NewGuid();
               }

           }
           catch (Exception e)
           {
               string msg = criteria.ToString() + " is not a valid class, or not included in project";
               throw e;
           }
           
           
           return newAssembly;
            
       }

       public override string ToString()
       {
           return m_subAssemblyID.ToString();
       }


      #region Constructor

      public SubAssemblyBase()
      {
        // m_subAssemblyID = Guid.NewGuid();
         counter++ ;
        
      }
      
      #endregion

      public FrameWorks.Workorder WrkOrder
      { get { return m_workorder; } set { m_workorder = value ; } }

      public int ID
      {
          get { return m_ID; }
          set { m_ID = value; }
      }

     
      
      public int CreateID
      {
             get{return counter;}
      }

      public decimal SquareFootPrice
      {
          get
          {
              return Decimal.Divide(CalculatedCost, this.m_area);
          }
      }


      
      public decimal CalculatedCost
      {
          get
          {
              decimal _cost = decimal.Zero;
              foreach (Part part in this.m_parts)
              {
                  decimal per = part.UnitPrice;
                  _cost += part.CalculatedCost;

              }
              m_calculatedCost = _cost;
              return m_calculatedCost;
          }
      }

      public decimal LaborTotal
      {
          get {

              m_laborTotal = decimal.Zero;
              foreach (var lpart in m_parts)
              {
                  if (lpart.GetType().Name == "LPart")
                  {
                        m_laborTotal += lpart.LaborAmount * lpart.Rate;
                  }
                  
              }

              return Math.Round(m_laborTotal, 2);
          }

      }
      public decimal Wieght
      {
         get 
         {
            decimal w = decimal.Zero;
             foreach (FrameWorks.Part p in this.Parts)
             {
                 w += p.Weight;
             }
             return Math.Round(w,2);
         }
         set { m_wieght = value; }
      }

      public decimal Area
      {
         get {
                decimal result = decimal.Zero;
                result = Math.Round(((m_subAssemblyWidth * m_subAssemblyHieght)/144),2);
                m_area = result;
                return m_area;
          
          
          }
         
      }

      public decimal Perimeter
      {
         get
         {
            m_perimeter = decimal.Zero;
            m_perimeter = (m_subAssemblyWidth * 2.0m) + (m_subAssemblyHieght * 2.0m) + (m_subAssemblyDepth * 2.0m);
            return Math.Round(m_perimeter,2);

         }

      }

      
      #region SubAssemblyBase Members
      
      public Guid subassemblyID
      {
         get{return m_subAssemblyID;}
         set{m_subAssemblyID = value;}
      }

      public AssemblyBase Parent
      {
         get{return m_parent ;}
         set{ m_parent = value;}
      }

      public List<Part> Parts
      {
         get { return m_parts ; }
      } 

      public string ModelID
      {
          get {return this.GetType().ToString() ;}
          //get {return m_modelID; }
         set{m_modelID = value;}
      }
      public string Name
      {
         get { return m_name ; }
         set { m_name = value;}
      }
      public decimal SubAssemblyWidth
      {
         get { return m_subAssemblyWidth; }
         set { m_subAssemblyWidth = value; }
      }
      public decimal SubAssemblyHieght
      {
         get { return m_subAssemblyHieght; }
         set { m_subAssemblyHieght = value; }
      }
      public decimal SubAssemblyDepth
      {
         get { return m_subAssemblyDepth; }
         set { m_subAssemblyDepth = value; }
      }

      public decimal Radius
      {
          get { return m_radius; }
          set { m_radius = value; }
      }

      #endregion
      
      #region Methods
      
      // This is overidden with each Makefile Instance Class
      public virtual void Build(){}
         
      #endregion

   }
}
