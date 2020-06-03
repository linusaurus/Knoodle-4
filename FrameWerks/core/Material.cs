using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWorks
{
   
    public class  SourceMaterial
    {
      private int partID;
      private string materialName;
      private decimal width;
      private decimal height;
      private string materialDescription;
      private decimal cost = decimal.Zero;
      private int uom = 0;
      private decimal weight = 0.0m;
      private decimal waste = 0.0m;
      private decimal markup = 0.0m;
      private int supplierID;

      public int SupplierID
      {
          get { return supplierID; }
          set { supplierID = value; }
      }

      public override string ToString()
      {
          return this.materialName;
      }

      public decimal MarkUp
      {
          get { return markup ; }
          set { markup  = value; }
      }

      public decimal Waste
      {
          get { return waste ; }
          set { waste  = value; }
      }

      public decimal Weight
      {
          get { return weight; }
          set { weight = value; }
      }

      public decimal Cost
      {
         get{return cost ;}
         set{cost = value;}
       }
      
      public int UOM
      {
         get{return uom;}
         set{uom = value;}
      }
      public string MaterialDescription
      {
         get { return materialDescription; }
         set { materialDescription = value; }
      }


      public decimal Height
      {
         get { return height; }
         set { height = value; }
      }
	

      public decimal Width
      {
         get { return width; }
         set { width = value; }
      }
	
      
      public string MaterialName
      {
         get { return materialName; }
         set { materialName = value; }
      }
	

      public int ItemID
      {
         get { return partID;}
         set { partID = value;}
      }
	
   }
}
