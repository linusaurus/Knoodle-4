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
using System.Diagnostics;


namespace FrameWorks.Makes.System3000
{
   
   public class AwningNT : SubAssemblyBase
   {

      #region Fields

      static int createID;


      #endregion

      #region Constructor

      public AwningNT()
      {
         m_subAssemblyID = Guid.NewGuid();
         this.ModelID = "Sys3000-AwningNT";
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
         part.PartLength = m_subAssemblyHieght;
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
         part.PartLength = m_subAssemblyHieght;
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
         part.PartLength = m_subAssemblyWidth;
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
         part.PartLength = m_subAssemblyWidth;
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "RailB";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         
         part = new Part(1117, "Braces", this, 8, 0.0m);
         part.PartGroupType = "Sash-Parts";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         #region Stops
         // StopT-Front
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth -(1.3125m * 2.0m);
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
         part.PartLength = m_subAssemblyWidth -(1.3125m * 2.0m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopT-Rear";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // StopB-Rear
         part = new Part(809);
         part.Qnty = 1;
         part.FunctionalName = "StopB-Rear";
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth -(1.3125m + 1.3125m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;

         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // StopB-Front
         part = new Part(809);
         part.Qnty = 1;
         part.PartGroupType = "Stop-Parts";
         part.ContainerAssembly = this;
         part.PartLength = m_subAssemblyWidth -(1.3125m + 1.3125m);
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
         part.PartLength = m_subAssemblyHieght  -(1.3125m + 1.3125m);
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
         part.PartLength = m_subAssemblyHieght  -(1.3125m + 1.3125m);
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
         part.PartLength = m_subAssemblyHieght  -(1.3125m + 1.3125m);
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
         part.PartLength = m_subAssemblyHieght  -(1.3125m + 1.3125m);
         part.PartWidth = part.Source.Width;
         part.PartThick = part.Source.Height;
         part.FunctionalName = "StopR-Front";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         #endregion

         #region Hardware

         // Hinges
         decimal _wieght = FrameWorks.Functions.PanelWieghtS3000(SubAssemblyWidth, SubAssemblyHieght);
         decimal hingesize = SubAssemblyHieght - (2.0m * 0.8750m);
         string id = this.Parent.UnitID.ToString();
         if (_wieght < 234)
         {

            part = new Part(FrameWorks.Functions.S3000AwningHinge(hingesize), "Awning Hinge", this, 2, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else
         {

            string message = "The Component is too heavy-" + id.ToString();

            Debug.WriteLine(message);

         }



         #endregion

         #region Seals

         //Sash Weatherstip
         part = new Part(1769);
         part.Qnty = 1;
         part.FunctionalName = "Sash Weatherstip";
         part.PartGroupType = "Seals-Parts";
         part.PartLabel = "";
         part.ContainerAssembly = this;
         part.PartLength = (m_subAssemblyHieght + m_subAssemblyWidth)* 2.0m;
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         #endregion

         #endregion


            #region Labor

         part = new LPart("Design", this,4.0m, 80.0m);
         m_parts.Add(part);
         //Measure: Collect Information on Sizes from Contractor: Provide Information for Approval: Samples Correspondence: Ordering: Supervision

         part = new LPart("Draft",this, 3.0m, 80.0m);
         m_parts.Add(part);
         //Typical Drawings: Supervision

         part = new LPart("MetalHours",this, 10.0m, 80.0m);
         m_parts.Add(part);
         //1 Recieve: 1 Handle: 1 CutFrame: 1 CutStop: 1.5 Machine: 1.5 HardwarePrep: 1 MountHardware: 2 Weld: 

         part = new LPart("FinishHours",this, 4.0m, 80.0m);
         m_parts.Add(part);
         //2 LinegrainSand: 2 Finish

         part = new LPart("GlazingHours",this, (this.Area * 0.1m) + 4.5m, 80.0m);
         m_parts.Add(part);
         //.5 Recieve: 1.0 InspectReject: .5 StoreHandle: 1.0 GlazeShimCalk: .5 SetGlassStop: 05 InsertGasket 

         part = new LPart("Prehang",this, (this.Area * 0.1m) + 3.0m, 80.0m);
         m_parts.Add(part);
         //2 Fit Sash into Frame: 1 Mount Weather StripSeals

         part = new LPart("Stage",this,0.5m, 80.0m);
         m_parts.Add(part);
          //.5 Stage

         part = new LPart("Load",this, 0.5m, 80.0m);
         m_parts.Add(part);
          //.5 Load

         #endregion



      }


      #endregion

   }
}