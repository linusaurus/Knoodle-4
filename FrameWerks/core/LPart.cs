using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrameWorks
{
    [Serializable]
    public class LComponent : Component   
    {
      #region Contructors

      public LComponent()
      {
          this.m_ComponentType = "Labor";
          this.ComponentGroupType = "Labor";
          this.m_UOM = 11;//hrs
      }

      public LComponent(string TaskName, SubAssemblyBase parent,decimal laborAmount,decimal laborRate)
      {
          this.ComponentType = "Labor";
          this.m_UOM = 11;
          this.FunctionalName = TaskName ;
          
          this.m_parentAssembly = parent;
          this.m_rate = laborRate;
          this.m_laborAmount = laborAmount;
          this.Qnty = 1;
          this.m_ComponentLength = 0.0m;
          this.m_ComponentWidth = 0.0m;
          this.m_ComponentGroupType = "Labor";

          this.m_ComponentThick =  0.0m;
          
          this.m_waste = 0.0m;
          this.m_weight = 0.0m;
          this.m_source = new SourceMaterial();
          this.m_source.MaterialDescription = TaskName;
          this.m_source.MaterialName = TaskName;
          this.m_source.Cost = laborRate;
          this.ComponentGroupType = "Labor";
          this.m_UOM = 11; //hrs
          
          
          
      }
      public LComponent(int routingID,string TaskName, SubAssemblyBase parent, decimal laborAmount, decimal laborRate)
      {
          this.ComponentType = "Labor";
          this.m_UOM = 11;
          this.FunctionalName = TaskName;

          this.m_parentAssembly = parent;
          this.m_rate = laborRate;
          this.m_laborAmount = laborAmount;
          this.Qnty = 1;
          this.m_ComponentLength = 0.0m;
          this.m_ComponentWidth = 0.0m;
          this.m_ComponentGroupType = "Labor";

          this.m_ComponentThick = 0.0m;

          this.m_waste = 0.0m;
          this.m_weight = 0.0m;
          this.m_source = new SourceMaterial();
          this.m_source.MaterialDescription = TaskName;
          this.m_source.MaterialName = TaskName;
          this.m_source.Cost = laborRate;
          this.ComponentGroupType = "Labor";
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
