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
   
   public class FixedMonolithicCorner : SubAssemblyBase
   {

      #region Fields

      static int createID;

      #endregion

      #region Constructor

      public FixedMonolithicCorner()
      {
         m_subAssemblyID = Guid.NewGuid();
         this.ModelID = "Sys3000-FixedMonolithicCorner";
      }

      #endregion

      #region Methods

      //Bill of Material
      public override void Build()
      {

         Part part;
         string partleader =  this.Parent.UnitID + "." + this.CreateID.ToString();

         #region Frame


         // JambRight
         part = new Part(804,"JambR",this,1,m_subAssemblyHieght);
         part.Qnty = 1;
         part.PartGroupType = "Frame-Parts"; 
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // JambLeft
         part = new Part(804, "JambL", this, 1, m_subAssemblyHieght);
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Head Left
         part = new Part(804,"HeadL",this,1,m_subAssemblyWidth );
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "Rotated Mitre";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Head Right
         part = new Part(804, "HeadR", this, 1, m_subAssemblyDepth );
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "Rotated Mitre";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Sill Left
         part = new Part(804,"SillL",this,1,m_subAssemblyWidth );
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "Rotated Mitre";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Sill Right
         part = new Part(804, "SillR", this, 1, m_subAssemblyDepth );
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "Rotated Mitre";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Braces
         part = new Part(1114,"Braces",this,16,0.0m);
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         #endregion

         #region Stops

         // StopR
         part = new Part(1114,"StopR",this, 1, m_subAssemblyHieght - (0.625m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // StopL
         part = new Part(1114, "StopL", this, 1, m_subAssemblyHieght - (0.625m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Stop Top Left
         part = new Part(1114, "Stop-TopL", this, 1, m_subAssemblyHieght - (0.625m ));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Stop Bottom Left
         part = new Part(1114, "Stop-BotL", this, 1, m_subAssemblyHieght - (0.625m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Stop Top Right
         part = new Part(1114, "Stop-TopR", this, 1, m_subAssemblyDepth  - (0.625m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Stop Bottom Right
         part = new Part(1114, "Stop-BotR", this, 1, m_subAssemblyDepth - (0.625m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);
 

         #endregion

         #region Spacers

         // Spacer Left
         //part = new Part(-1,"SpacerL",this,1,);
         part.Qnty = 2;
         part.FunctionalName = "Horizontal Spacer";
         part.PartGroupType = "Spacers-Parts";
         part.Source.MaterialDescription = "Bronze U-Channel";
         part.PartLabel = "";
         part.Source.MaterialName = "Aluminum";
         part.ContainerAssembly = this;
         part.PartWidth =  0.0m;
         part.PartLength = m_subAssemblyWidth  - (1.375m * 2.0m);
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // SpacerVert
         part = new Part(-1);
         part.Qnty = 2;
         part.FunctionalName = "Vertical Spacer";
         part.PartGroupType = "Spacers-Parts";
         part.Source.MaterialDescription = "Alum U-Channel";
         part.PartLabel = "";
         part.Source.MaterialName = "Aluminum";
         part.ContainerAssembly = this;
         part.PartWidth =  0.0m;
         part.PartLength = m_subAssemblyWidth  - (0.788m * 2.0m);
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         #endregion

         #region Glass


         //Glass Panel
         part = new Part(-1);
         part.FunctionalName = "Glass Left";
         part.PartGroupType = "Glass-Parts";
         part.Qnty = 1;
         part.Source.MaterialDescription = "0.5 Insulated Glass";
         part.PartName = "PartName";
         part.PartLabel = "Phantom Part";
         part.Source.MaterialName = "0.5 IGU";
         part.ContainerAssembly = this;

         part.PartLength =  m_subAssemblyHieght-(0.943m * 2.0m);
         part.PartWidth  = m_subAssemblyWidth -(0.943m + 0.425m);
        // part.Source.UOM = (int)FrameWorks.UnitOfMeasure.Foot;

         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         //Glass Panel
         part = new Part(-1);
         part.FunctionalName = "Glass Right";
         part.PartGroupType = "Glass-Parts";
         part.Qnty = 1;
         part.Source.MaterialDescription = "0.5 Insulated Glass";
         part.PartName = "PartName";
         part.PartLabel = "Phantom Part";
         part.Source.MaterialName = "0.5 IGU";
         part.ContainerAssembly = this;

         part.PartLength =  m_subAssemblyHieght-(0.943m * 2.0m);
         part.PartWidth  = m_subAssemblyDepth  -(0.943m + 0.425m);
         //part.Source.UOM = (int)FrameWorks.UnitOfMeasure.Foot;

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