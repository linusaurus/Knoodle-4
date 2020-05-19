using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWorks
{
    [Serializable]
    public class LPart : Part   
    {
      #region Contructors

      public LPart()
      {
          this.m_partType = "Labor";
          this.PartGroupType = "Labor";
          this.m_UOM = 11;//hrs
      }

      public LPart(string TaskName, SubAssemblyBase parent,decimal laborAmount,decimal laborRate)
      {
          this.PartType = "Labor";
          this.m_UOM = 11;
          this.FunctionalName = TaskName ;
          
          this.m_parentAssembly = parent;
          this.m_rate = laborRate;
          this.m_laborAmount = laborAmount;
          this.Qnty = 1;
          this.m_partLength = 0.0m;
          this.m_partWidth = 0.0m;
          this.m_partGroupType = "Labor";

          this.m_partThick =  0.0m;
          
          this.m_waste = 0.0m;
          this.m_weight = 0.0m;
          this.m_source = new Material();
          this.m_source.MaterialDescription = TaskName;
          this.m_source.MaterialName = TaskName;
          this.m_source.Cost = laborRate;
          this.PartGroupType = "Labor";
          this.m_UOM = 11; //hrs
          
          
          
      }
      public LPart(int routingID,string TaskName, SubAssemblyBase parent, decimal laborAmount, decimal laborRate)
      {
          this.PartType = "Labor";
          this.m_UOM = 11;
          this.FunctionalName = TaskName;

          this.m_parentAssembly = parent;
          this.m_rate = laborRate;
          this.m_laborAmount = laborAmount;
          this.Qnty = 1;
          this.m_partLength = 0.0m;
          this.m_partWidth = 0.0m;
          this.m_partGroupType = "Labor";

          this.m_partThick = 0.0m;

          this.m_waste = 0.0m;
          this.m_weight = 0.0m;
          this.m_source = new Material();
          this.m_source.MaterialDescription = TaskName;
          this.m_source.MaterialName = TaskName;
          this.m_source.Cost = laborRate;
          this.PartGroupType = "Labor";
          this.m_UOM = 11; //hrs



      }

      public override decimal CalculatedCost
      {
         
          get
          {
             return this.m_laborAmount * this.Rate;
     
          }
      }
      
      #endregion
    }
}
