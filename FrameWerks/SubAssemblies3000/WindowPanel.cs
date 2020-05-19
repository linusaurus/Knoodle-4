#region Copyright (c) 2007 WeaselWare Software
/************************************************************************************
'
' Copyright  2007 WeaselWare Software 
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
' Portions Copyright 2007 WeaselWare Software
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
using FrameWorks;

namespace FrameWorks.Makes.System3000
{
  
   public class WindowPanel : SubAssemblyBase
   {

      #region Fields

      static int createID;
     

      #endregion

      #region Constructor

      public WindowPanel()
      {
         m_subAssemblyID = Guid.NewGuid();
         this.ModelID = "Sys3000-WindowPanel";
      }

      #endregion

      #region Methods

      //Bill of Material
      public override void Build()
      {

         Part part;
         string partleader =  this.Parent.UnitID + "." + this.CreateID.ToString();

    

         #region Sash

         // StileL
         part = new Part(1167);
         part.Qnty = 1;
         part.PartGroupType = "Sash-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyHieght - (0.875m + 0.875m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StileL";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

  

         // StileR
         part = new Part(1167);
         part.Qnty = 1;
         part.PartGroupType = "Sash-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyHieght - (0.875m + 0.875m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StileR";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // RailT
         part = new Part(1167);
         part.Qnty = 1;
         part.PartGroupType = "Sash-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth -(2.875m + 2.875m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "RailT";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // RailB
         part = new Part(1167);
         part.Qnty = 1;
         part.PartGroupType = "Sash-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth -(2.875m + 2.875m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "RailB";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);
         
         #endregion

         #region Filler

         part = new Part(1813, "Filler-Top", this, 2, m_subAssemblyWidth + 0.25m);
         part.PartGroupType = "Filler-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         part = new Part(1813, "Filler-Bottom", this, 2, m_subAssemblyWidth + 0.25m);
         part.PartGroupType = "Filler-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         part = new Part(1813, "Filler-Left", this, 2, m_subAssemblyHieght  + 0.25m);
         part.PartGroupType = "Filler-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         part = new Part(1813, "Filler-Right", this, 2, m_subAssemblyHieght  + 0.25m);
         part.PartGroupType = "Filler-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         #endregion

         #region Glass
         
         //Glass Panel
         part = new Part(-1);
         part.FunctionalName = "Glass";
         part.PartGroupType = "Glass-Parts";
         part.Qnty = 1;
         part.Source.MaterialDescription = "1.25 Insulated Glass";
         part.PartName = "PartName";
         part.PartLabel = "Phantom Part";
         part.Source.MaterialName = "1.25 IGU";
         part.ContainerAssembly = this;

         part.PartWidth =  m_subAssemblyHieght-(2.4753m + 2.4753m);
         part.PartLength = m_subAssemblyWidth -(2.4753m + 2.4753m);
         //part.Source.UOM = (int)FrameWorks.UnitOfMeasure.Foot;

         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         #endregion

         #region Stops
         // StopT-Front
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth -(2.1875m + 2.1875m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopT-Front";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // StopT-Rear
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth -(2.1875m + 2.1875m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopT-Rear";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // StopB-Rear
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth -(2.1875m + 2.1875m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopB-Rear";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // StopB-Front
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth -(2.1875m + 2.1875m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopB-Front";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // StopL-Rear
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyHieght  -(2.1875m + 2.1875m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopL-Rear";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // StopL-Front
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyHieght  -(2.1875m + 2.1875m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopL-Front";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // StopR-Rear
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyHieght  -(2.1875m + 2.1875m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopR-Rear";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // StopR-Front
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyHieght  -(2.1875m + 2.1875m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopR-Front";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         #endregion

         #region Hardware

         // Hinges
         decimal hingesize = SubAssemblyHieght - (2.0m * 0.8750m);
         part = new Part(HingeSelection(hingesize));
         part.Qnty = 1;
         part.FunctionalName = "Hinges";
         part.PartGroupType = "Hardware-Parts";

         part.ContainerAssembly = this;
         part.PartThick = decimal.Zero;
         part.PartWidth =  decimal.Zero;
         part.PartLength = decimal.Zero;

         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         #endregion

            #region Labor



         part = new LPart("Design", this, 4.0m, 80.0m);
         m_parts.Add(part);
         //Collect Information on Sizes: Measure: Provide Information for Approval: Order: Supervision

         part = new LPart("Draft", this, 3.0m, 80.0m);
         m_parts.Add(part);
         //Typical Drawings

         part = new LPart("MetalHours", this, 12.0m, 80.0m);
         m_parts.Add(part);
         //1 Recieve: 1 Handle: 1 CutSash: 1 CutGlassStop: 1.5 Machine: 1.5 Hardware Prep: 1 Mount Hardware: 4 Weld:

         part = new LPart("Finish", this, 4.0m, 80.0m);
         m_parts.Add(part);
         //2 Sand Linegrain: 2 Finish:

         part = new LPart("Glazing", this, (this.Area * .10m) + 4.5m, 80.0m);
         m_parts.Add(part);
         //0.5 Order: 0.5 Recieve: 1.0 Inspect/Reject: 0.5 Store/Handle: 0.5 SetGlass/Shim&Calk: 0.5 Set GlassStop: 0.5 GlazingSeals

         part = new LPart("Prehang", this, (this.Area * .10m) + 3.0m, 80.0m);
         m_parts.Add(part);
         //2 FitSash into Frame: 1 Mount Weather Strips/Seals

         part = new LPart("Stage", this, 1.0m, 80.0m);
         m_parts.Add(part);
         //1 Stage

         part = new LPart("Load", this, 1.0m, 80.0m);
         m_parts.Add(part);
          //1 Load

         #endregion

      }

      private int HingeSelection(decimal HingeAxisLength)
      {
         int result = 0;

         if (HingeAxisLength < 20.0m)
         {
            result = 1741;
         }
         else if ((HingeAxisLength >= 20.0m) && (HingeAxisLength < 25.0m))
         {
            result = 1742;
         }
         else if ((HingeAxisLength >= 25.0m) && (HingeAxisLength < 34.0m))
         {
            result = 1743;
         }
         else if ((HingeAxisLength >= 34.0m) && (HingeAxisLength < 50.0m))
         {
            result = 1744;
         }
         else if (HingeAxisLength > 50.0m)
         {
            result = 1746;

         }

         return result;
      }

      #endregion


   }
}