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
   
   public class FixedMonolithic : SubAssemblyBase
   {

      #region Fields

      static int createID;

      #endregion

      #region Constructor

      public FixedMonolithic()
      {
         m_subAssemblyID = Guid.NewGuid();
         this.ModelID = "Sys3000-FixedMonolithic";
      }

      #endregion

      #region Methods

      //Bill of Material
      public override void Build()
      {

         Part part;
         string partleader =  this.Parent.UnitID + "." + this.CreateID.ToString();

         #region Frame


         // JambRight -->>
         part = new Part(804);
         part.Qnty = 1;
         part.PartGroupType = "Frame-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyHieght;
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "JambR";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // JambLeft <<--
         part = new Part(804);
         part.Qnty = 1;
         part.PartGroupType = "Frame-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyHieght;
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "JambL";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Head ^^
         part = new Part(804);
         part.Qnty = 1;
         part.PartGroupType = "Frame-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth;
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "Head";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Sill ||
         part = new Part(804);
         part.Qnty = 1;
         part.PartGroupType = "Frame-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth;
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "Sill";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Braces
         part = new Part(1117);
         part.Qnty = 8;
         part.PartGroupType = "Frame-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth;
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "Braces";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         #endregion
         
         #region Stops

         // StopR
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyHieght  - (0.625m * 2.0m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopR";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // StopL
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyHieght  - (0.625m * 2.0m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopL";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // StopT
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth   - (0.625m * 2.0m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopT";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // StopB
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth   - (0.625m * 2.0m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopB";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);
         
         #endregion
         
         #region Spacers

         // SpacerHori
         part = new Part(272, "SpacerHor", this, 2, m_subAssemblyWidth  - (1.375m * 2.0m));
         part.PartGroupType = "Spacers-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // SpacerVert
         part = new Part(272, "SpacerVert", this, 2, m_subAssemblyWidth  - (0.788m * 2.0m));
         part.PartGroupType = "Spacers-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);
         
         
         #endregion
         
         #region Glass


         //Glass Panel
         part = new Part(-1);
         part.FunctionalName = "Glass";
         part.PartGroupType = "Glass-Parts";
         part.Qnty = 1;
         part.Source.MaterialDescription = "1/2 Glass";
         part.PartName = "PartName";
         part.PartLabel = "Phantom Part";
         part.Source.MaterialName = "0.5 Glass";
         part.ContainerAssembly = this;

         part.PartWidth =  m_subAssemblyHieght-(0.9375m * 2.0m);
         part.PartLength = m_subAssemblyWidth -(0.9375m * 2.0m);
         part.Source.UOM = 9;

         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);



         #endregion

            #region Labor

         part = new LPart("Design", this, 4.0m, 80.0m);
         m_parts.Add(part);
         //Measure: Collect Information on Sizes from Contractor: Provide Information for Approval: Samples Correspondence: Ordering: Supervision

         part = new LPart("Draft", this, 3.0m, 80.0m);
         m_parts.Add(part);
         //Typical Drawings: Supervision

         part = new LPart("MetalHours", this, 10.0m, 80.0m);
         m_parts.Add(part);
         //1 Recieve: 1 Handle: 1 CutFrame: 1 CutStop: 1.5 Machine: 1.5 HardwarePrep: 1 MountHardware: 2 Weld: 

         part = new LPart("FinishHours", this, 4.0m, 80.0m);
         m_parts.Add(part);
         //2 LinegrainSand: 2 Finish

         part = new LPart("GlazingHours", this, (this.Area * 0.1m) + 4.5m, 80.0m);
         m_parts.Add(part);
         //.5 Recieve: 1.0 InspectReject: .5 StoreHandle: 1.0 GlazeShimCalk: .5 SetGlassStop: 05 InsertGasket 

         part = new LPart("Prehang", this, (this.Area * 0.1m) + 3.0m, 80.0m);
         m_parts.Add(part);
         //2 Fit Sash into Frame: 1 Mount Weather StripSeals

         part = new LPart("Stage", this, 0.5m, 80.0m);
         m_parts.Add(part);
         //.5 Stage

         part = new LPart("Load", this, 0.5m, 80.0m);
         m_parts.Add(part);
          //.5 Load


         #endregion


      }

     
      #endregion


   }
}