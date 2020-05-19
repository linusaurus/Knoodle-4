using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWorks
{
     [Serializable]
    public class Material
   {
      private int m_ItemId;
      private string m_materialName;
      private decimal m_width;
      private decimal m_Height;
      private string m_materialDiscription;
      private decimal m_cost = decimal.Zero;
      private int m_uom = 0;
      private decimal _weight = 0.0m;
      private decimal _waste = 0.0m;
      private decimal _markup = 0.0m;
      private int _supplierID;

      public int SupplierID
      {
          get { return _supplierID; }
          set { _supplierID = value; }
      }

      public override string ToString()
      {
          return this.m_materialName;
      }

      public decimal MarkUp
      {
          get { return _markup ; }
          set { _markup  = value; }
      }

      public decimal Waste
      {
          get { return _waste ; }
          set { _waste  = value; }
      }

      public decimal Weight
      {
          get { return _weight; }
          set { _weight = value; }
      }

      public decimal Cost
      {
         get{return m_cost ;}
         set{m_cost = value;}
       }
      
      public int UOM
      {
         get{return m_uom;}
         set{m_uom = value;}
      }
      public string MaterialDescription
      {
         get { return m_materialDiscription; }
         set { m_materialDiscription = value; }
      }


      public decimal Height
      {
         get { return m_Height; }
         set { m_Height = value; }
      }
	

      public decimal Width
      {
         get { return m_width; }
         set { m_width = value; }
      }
	
      
      public string MaterialName
      {
         get { return m_materialName; }
         set { m_materialName = value; }
      }
	

      public int ItemID
      {
         get { return m_ItemId;}
         set { m_ItemId = value;}
      }
	
   }
}
