#region Copyright (c) 2020 WeaselWare Software
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
' Portions Copyright 2020 WeaselWare Software
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
using System.ComponentModel;


namespace FrameWorks
{
    public class ComponentNotFoundException : System.Exception
    {
        public ComponentNotFoundException()
        {
            // Add implementation.
        }
        public ComponentNotFoundException(string message) 
            : base(message)
        {
            // Add implementation.
        }
        public ComponentNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
 
    public class Component
   {

      #region Fields

      //protected FrameWorks.Material m_source;

      protected string m_ComponentType = "Materials";
      protected decimal m_rate;
      protected decimal m_laborAmount;
      protected decimal m_unitPrice;
      protected string m_ComponentName;
      protected int m_ComponentSourceNumber;
      protected decimal unitSpecificAmount;
      // this requires the lookup and a Component number
      protected SourceMaterial m_source;
      protected decimal m_ComponentWidth = 0.0m;
      protected decimal m_ComponentThick = 0.0m;
      protected decimal m_ComponentLength = 0.0m;
      protected string m_functionalName;
      protected string m_ComponentGroupType;
      protected decimal m_sourceWaste = 0.0m;
      protected decimal m_sourceMarkup = 0.0m;
      
      protected SubAssemblyBase m_parentAssembly;
      protected decimal m_area;
      protected string m_ComponentLabel = string.Empty;
      protected string m_ComponentIdentifier = string.Empty;
      protected int m_UOM = 0;
      protected decimal m_weight;
      protected decimal m_waste = 0.0m;
      protected decimal m_markup = 0.0m;
      protected int m_supplierID;
      

      

      #endregion

      #region Contructors

 

      public Component()
      {

      }

      public Component(int sourceID)
      {
         if(sourceID == -1)
         {
            m_source = new SourceMaterial();
            m_ComponentSourceNumber  = -1;
         } 
         else
         {
                this.m_source = FrameWorks.PartDictionary.PartSource[sourceID];
                m_UOM = m_source.UOM ;
         }
      }

      public Component(int sourceID, string functionalName, SubAssemblyBase parent,int Quantity, decimal calculatedLength)
      {
         if (sourceID == -1)
         {
            m_source = new SourceMaterial();
            m_ComponentSourceNumber  = -1;

         }
         else
         {
             try
             {
                this.m_source = FrameWorks.PartDictionary.PartSource[sourceID];
             }
             catch 
             {
                 ComponentNotFoundException ex = new ComponentNotFoundException(String.Format("Source Part {0} does not exist",sourceID.ToString()));
                 throw ex;
             }
             
         }

         
         this.FunctionalName = functionalName;
         this.m_parentAssembly = parent;
         this.m_ComponentLength = calculatedLength;
         this.Qnty = Quantity ;

      }

      public Component(int sourceID, string functionalName, SubAssemblyBase parent, int Quantity, decimal calculatedLength,decimal width)
      {
          if (sourceID == -1)
          {
              m_source = new SourceMaterial();
              m_ComponentSourceNumber = -1;

          }
          else
          {
              try
              {
                  this.m_source = FrameWorks.PartDictionary.PartSource[sourceID];
              }
              catch
              {
                  ComponentNotFoundException ex = new ComponentNotFoundException("Component ID = does not exist");
                  throw ex;
              }

          }


          this.FunctionalName = functionalName;
          this.m_parentAssembly = parent;
          this.m_ComponentLength = calculatedLength;
          this.Qnty = Quantity;
          this.ComponentWidth = width;

      }
      
      #endregion
      [Category("Component Specification")]
      public string ComponentType
      { get { return m_ComponentType; } set { m_ComponentType = value; } }
      [Category("Labor")]
      public decimal Rate
      { get { return m_rate; } set { m_rate = value; } }
      [Category("Labor")]
      public decimal LaborAmount
      { get { return m_laborAmount; } set { m_laborAmount = value; } }
      [Category("Material")]
      public decimal UnitPrice
      { 
          get 
          {
              if (this.GetType().ToString() == "FrameWorks.LComponent")
              { m_unitPrice = ((FrameWorks.LComponent)this).Rate; }
              else { m_unitPrice = m_source.Cost; }
              
              return m_unitPrice; 
          } 
          set 
          { 
              m_unitPrice = value; 
          } 
      }
      
      #region Properties

      [Category("Material")]
      public int SupplierID
      {
          get { return m_supplierID; }
          set { m_supplierID = value; }
      }
      [Category("Material")]
      public decimal Waste
      {
          get 
          {
              if (m_source.Waste != decimal.Zero)
              {
                  decimal qty = decimal.Parse(m_Qnty.ToString());
                  switch (m_source.UOM)
                  {

                      //--- Each-------------------------------------------------------------------
                      case 1:
                          {
                              this.m_waste = qty * m_source.Waste;
                              break;
                          }
                      //--- Foot
                      case 2:
                          {
                              this.m_waste = Math.Round((decimal)((this.m_ComponentLength / 12) * Qnty) * m_source.Waste,2);
                              break;
                          }
                      //--- lbs
                      case 3:
                          {
                              this.m_waste = (decimal)((this.m_ComponentLength / 12) * Qnty) * m_source.Waste;
                              break;
                          }
                      //--- Qts
                      case 4:
                          {
                              this.m_waste = (decimal)((this.m_ComponentLength / 12) * Qnty) * m_source.Waste;
                              break;
                          }
                      //--- Inch
                      case 6:
                          {
                              this.m_waste = (this.m_ComponentLength * Qnty) * m_source.Waste;
                              break;
                          }
                      //--- Pair
                      case 7:
                          {
                              this.m_waste = (this.m_ComponentLength * Qnty) * m_source.Waste;
                              break;
                          }
                      // Sqft
                      case 8:
                          {
                              this.m_waste = Math.Round((((this.m_ComponentLength * this.ComponentWidth) / 144) * qty) * m_source.Waste,2);
                              break;
                          }

                      //--- Sq Inch
                      case 9:
                          {

                              this.m_waste = (this.Area * qty) * m_source.Waste;
                              break;
                          }
                      //--- Bdft
                      case 10:
                          {

                              this.m_waste = (this.Area * qty) * m_source.Waste;
                              break;
                          }

                  }
                 
              }
              else
              {
                  m_waste = decimal.Zero;
              }
              return Math.Round(m_waste ,2);
          }
          set 
          {
              m_waste = value ;
          }
      }
      [Category("Material")]
      public decimal MarkUp
      {
          get 
          {
              if (this.GetType().ToString() == "FrameWorks.LComponent")
              {
                 return 0.0m;
              }
              return m_source.MarkUp; 
          }
          set { m_markup = value; }
      }
      [Category("Component Specification")]
      public decimal Area
      {
         get
         {
             decimal m_area = decimal.Zero;
             switch (this.UOM)
                 {
                 case 8:
                     {
                      if (m_ComponentWidth > 0.0m && m_ComponentLength > 0.0m)
                        {
                            m_area = (m_ComponentLength * m_ComponentWidth);
                            m_area = m_area / 144;
                            m_area = Math.Round(m_area, 4);
                        }
                        break;
                     }
                 case 9:
                     {
                         if (m_ComponentWidth > 0.0m)
                         {
                             m_area = (m_ComponentLength * m_ComponentWidth);
                             m_area = Math.Round(m_area, 4);
                         }
                        break;
                     }
                 }

             return m_area;
         } 
        
       }
      [Category("Component Specification")]
      public decimal Weight
      {
          get 
          {
              switch(m_source.UOM ) 
             {
            
                //--- Each
                case 1 :
                {
                this.m_weight   = (this.m_Qnty  * m_source.Weight);
                break;
                }
                //--- Foot
                case 2:
                {
                    this.m_weight =((this.m_ComponentLength / 12)* Qnty) * m_source.Weight;
                    break;
                }
                //--- Inch
                case 6:
                {
                    this.m_weight =((this.m_ComponentLength)* Qnty) * m_source.Weight;
                    break;
                }
                //--- Pair
                case 7:
                {
                    
                    this.m_weight = Math.Round(Qnty * m_source.Weight, 4);
                    break;
                }
                //--- Sqft
                case 8:
                {
                    decimal area = (decimal)this.Area;
                    if (this.Area  > 0.0m)
                    {
                        this.m_weight = Math.Round(((area) * Qnty) * m_source.Weight,4);
                        
                    }

                    break;
                }
                //--- Sq Inch
                case 9:
                {

                    this.m_weight = (this.Area * Qnty) * m_source.Weight;
                    break;
            }
       
                }
            return this.m_weight ; 
         }
          
          set {m_weight = value ;}
      }
      [Category("Material")]
      public int UOM 
      { 
        get 
        {
            if ( this.Source !=null )
            {
              m_UOM = this.Source.UOM ;
            }
            return m_UOM; 
        }
      
        set 
        {
            m_UOM = value;
        } 
       }
      [Category("Material")]
      public decimal UnitSpecificAmount
      { get 
          {
              return ConvertToUomAmount(this.UOM,this); 
          }     
      }
      [Category("Component Specification")]
       public string ComponentLabel
       {
         get
         {
             //m_ComponentLabel =  this.m_parentAssembly.Parent.UnitID.ToString() + this. ;
             return m_ComponentLabel;
         }
         set{m_ComponentLabel = value;}
       
       }
      [Category("Component Specification")]
      public string ComponentIdentifier
      {
         get { return m_ComponentIdentifier; }
         set { m_ComponentIdentifier = value; }
      }

      [Category("Material")]
      public int ComponentSourceNumber
      {
         get
         {
             return m_source.ItemID ; 
         }
         set
         {
            this.ComponentSourceNumber = value ;
            
         }
      }
      [Category("Component Specification")]
      private int m_Qnty;
      [Category("Component Specification")]
      private decimal m_calculatedCost = decimal.Zero ;
      [Category("Component Specification")]
      public virtual decimal CalculatedCost
      {
        get {
        
        switch(m_source.UOM ) 
        {
            
            //--- Each
            case 1:
                {
                    this.m_calculatedCost = Math.Round((decimal)(m_Qnty * m_source.Cost),2);
                    break;
                }
            //--- Foot
            case 2:
            {
                    decimal cs = (decimal)(this.m_ComponentLength / 12) *  Convert.ToDecimal(Qnty) * m_source.Cost;
                    this.m_calculatedCost = Math.Round(cs, 2);
                    break;
            }
            //--- Inch
            case 6:
            {
                    this.m_calculatedCost =(decimal) (this.m_ComponentLength  *  Convert.ToDecimal(Qnty)  *  m_source.Cost);
                    break;
            }
            //--- Pair
            case 7:
            {
                    this.m_calculatedCost = Math.Round((decimal)(m_Qnty * m_source.Cost),2);
                    break;
            }
            //--- Square Foot
            case 8:
            {
                decimal cs = (decimal)((this.Area  * m_source.Cost));
                this.m_calculatedCost = Math.Round(cs,2);
                break;
            }
            //--- Sq Inch
            case 9:
            {
             
                this.m_calculatedCost = (decimal)((this.Area  * Qnty) * m_source.Cost) ;
                break;
            }
            //--- Bdft
            case 10:
            {

                this.m_calculatedCost = (decimal)((this.Area * Qnty) * m_source.Cost);
                break;
            }
       
        }
            return Math.Round(m_calculatedCost,2); 
         }
         
      }
      [Category("Component Specification")]
      public int Qnty
      {
         get { return m_Qnty; }
         set { m_Qnty = value; }
      }
      [Category("Material")]
      public string ComponentName
      {
         get { return m_ComponentName; }
         set { m_ComponentName = value; }
      }

      public void LoadComponent()
      {

      }

      [Category("Component Specification")]
      public SubAssemblyBase ContainerAssembly
      {
         get { return m_parentAssembly; }
         set { m_parentAssembly = value; }
      }

      [Category("Material")]
      public virtual SourceMaterial Source
      {
         get { return m_source; }
         set { m_source = value; }

      }
      [Category("Component Specification")]
      public virtual string FunctionalName
      {
         get { return m_functionalName; }
         set { m_functionalName =value; }
      }
      [Category("Component Specification")]
      public string ComponentGroupType
      {
         get { return m_ComponentGroupType; }
         set { m_ComponentGroupType = value; }

      }
      [Category("Dimension")]
      public decimal ComponentWidth
      {
         get { return m_ComponentWidth; }
         set { m_ComponentWidth = value; }
      }
      [Category("Dimension")]
      public decimal ComponentLength
      {
         get { return m_ComponentLength; }
         set { m_ComponentLength  = value; }

      }
      [Category("Dimension")]
      public decimal ComponentThick
      {
         get { return m_ComponentThick; }
         set { m_ComponentThick = value; }
      }

      #endregion

      #region Methods

      public virtual object Clone()
      {
         Component newComponent =(Component)this.MemberwiseClone();
         return newComponent;
      }

      private decimal ConvertToUomAmount(int UoM, FrameWorks.Component Component)
      {
          decimal result = decimal.Zero;
          switch (this.UOM)
          {
              case 1:
                  {
                      result = Convert.ToDecimal(this.Qnty);
                      break;
                  }
              case 2:
                  {
                      result = Convert.ToDecimal(this.ComponentLength / 12);
                      break;
                  }
              case 3:
                  {
                      result = Convert.ToDecimal(this.Weight);
                      break;
                  }
              case 4:
                  {
                      result = Convert.ToDecimal(this.Qnty);
                      break;
                  }
              case 5:
                  {
                      result = Convert.ToDecimal(this.Qnty);
                      break;
                  }
              case 6:
                  {
                      result = Convert.ToDecimal(this.Qnty);
                      break;
                  }
              case 7:
                  {
                      result = Convert.ToDecimal(this.Qnty / 2);
                      break;
                  }
              case 8:
                  {
                      result = Convert.ToDecimal(this.Qnty * this.Area);
                      break;
                  }
              case 9:
                  {
                      result = Convert.ToDecimal(this.Qnty * this.Area);
                      break;
                  }
              case 10:
                  {
                      if (this.ComponentThick != decimal.Zero)
                      {
                        result = Convert.ToDecimal(this.Qnty * this.Area * this.ComponentThick);
                      }
                      else
                      {
                          result = Convert.ToDecimal(this.Qnty * this.Area);
                      }
                      
                      break;
                  }
              case 11:
                  {
                      result = Convert.ToDecimal(this.Qnty);
                      break;
                  }
              default:
                  break;
          }

          return result;
      }

      #endregion

     
   }
}
