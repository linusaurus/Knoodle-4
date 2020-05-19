using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace FrameWorks
{
   [Serializable]
   public class Unit : AssemblyBase , ISerializable
   {
 
      public Unit()
      {
        
      }

      public Unit(SerializationInfo info, StreamingContext context)
      {
          this.m_subAssemblies = (List<FrameWorks.SubAssemblyBase>)info.GetValue("SubAssemblies",typeof(List<FrameWorks.SubAssemblyBase>));
          this.m_UnitID = (Int32)info.GetValue("UnitID",typeof(Int32));
          this.m_unitName = (string)info.GetValue("UnitName",typeof(string));
          this.m_unitWidth = (decimal)info.GetValue("UnitWidth",typeof(decimal));
          this.m_unitHeight = (decimal)info.GetValue("UnitHeight",typeof(decimal));
          this.m_unitDepth = (decimal)info.GetValue("UnitDepth",typeof(decimal));
          // Need renaming and revision
          this.m_projectInstanceName = (string)info.GetValue("ProjectInstanceName",typeof(string));
          this.m_varDecimalOne = (decimal)info.GetValue("VarDecimalOne",typeof(decimal));

          this.m_MakeFileName = (string)info.GetValue("MakeFileName",typeof(string));
          this.m_calculatedCost = (decimal)info.GetValue("CalculatedCost",typeof(decimal));
          this.m_area = (decimal)info.GetValue("Area", typeof(decimal));
           
      }
   
      public override void Build()
      {
         foreach(SubAssemblyBase  sub in this.m_subAssemblies)
          {
             sub.Parent = this; 
             sub.Build();
          }
      }



      #region ISerializable Members

      public void GetObjectData(SerializationInfo info, StreamingContext context)
      {
          info.AddValue("SubAssemblies", this.m_subAssemblies);
          info.AddValue("UnitID",this.m_UnitID);
          info.AddValue("UnitName", this.m_unitName);
          info.AddValue("UnitWidth", this.m_unitWidth);
          info.AddValue("UnitHeight", this.m_unitHeight);
          info.AddValue("UnitDepth", this.m_unitDepth);
          // Need renaming and revision
          info.AddValue("ProjectInstanceName", this.m_projectInstanceName);
          info.AddValue("VarDecimalOne", this.m_varDecimalOne);

          info.AddValue("MakeFileName", this.m_MakeFileName);
          info.AddValue("CalculatedCost", this.m_calculatedCost);
          info.AddValue("Area", this.m_area);


      }

      #endregion
   }
}
