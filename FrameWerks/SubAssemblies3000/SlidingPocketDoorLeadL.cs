#region CopyRight
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
   
   public class SlidingPocketDoorLeadL : SubAssemblyBase
   {

      #region Fields

      static int createID;
         Part part;
      #endregion

      #region Constructor

         public SlidingPocketDoorLeadL()
      {
         m_subAssemblyID = Guid.NewGuid();
         this.ModelID = "SlidingPocketDoorLeadL";
      }

      #endregion

      #region Methods

      //Bill of Material
      public override void Build()
      {

         
         string partleader =  this.Parent.UnitID + "." + this.CreateID.ToString();



         #region Panel


         // StileL <<--

         part = new Part(1167, "StileL", this, 1, m_subAssemblyHieght);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         // StileR -->>

         part = new Part(1167, "StileR", this, 1, m_subAssemblyHieght);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         // RailT ^^

         part = new Part(1167, "RailT", this, 1, m_subAssemblyWidth );
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         // RailB ||

         part = new Part(1167, "RailB", this, 1, m_subAssemblyWidth );
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         // Hooking Cap L <<--

         part = new Part(2157, "Hooking Cap L", this, 1, m_subAssemblyHieght);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "Machine Notch 0.50m";
         
         m_parts.Add(part);


         // Stile Cap R -->>

         part = new Part(2158, "Cap R", this, 1, m_subAssemblyHieght);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         // Plastic Hook Strip

         part = new Part(924, "Hook Strip", this, 1, m_subAssemblyHieght);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         // Filler Edge

         part = new Part(2011, "Filler Edge", this, 2, m_subAssemblyHieght);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         

         // Glazing Vinyl

         part = new Part(1819, "Glazing Vinyl", this, 1, FrameWorks.Functions.Perimeter(m_subAssemblyWidth,m_subAssemblyHieght,1.625m)*2.0m );
         part.PartGroupType = "Seal-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         // Assemble Braces

         part = new Part(1115, "Braces", this, 8, 0.0m  );
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);
         

         // Brush Holder
 
         part = new Part(1404, "Brush Holder", this, 1, m_subAssemblyWidth );
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         // Guide Fin 

         part = new Part(2071, "Guide Fin", this, 1, m_subAssemblyWidth );
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         // Weather Strip 

         part = new Part(1029, "Weather Strip", this, 2, m_subAssemblyWidth );
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         // Suspention Track

         part = new Part(2148, "Suspention Track ", this, 2, 0.0m );
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         // Aluminum Block Shim
         part = new Part(2454, "Block Shim", this, 2, 0.0m);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);
         
        

         #endregion

         #region Stop


         // StopFrontLeft
         part = new Part(809, "StopFrontLeft", this, 1, m_subAssemblyHieght - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "Miter Ends";
         
         m_parts.Add(part);



         // StopRearLeft
         part = new Part(809, "StopRearLeft", this, 1, m_subAssemblyHieght - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "Miter Ends";
         
         m_parts.Add(part);



         // StopFrontRight
         part = new Part(809, "StopFrontRight", this, 1, m_subAssemblyHieght - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "Miter Ends";
         
         m_parts.Add(part);



         // StopRearRight
         part = new Part(809, "StopRearRight", this, 1, m_subAssemblyHieght - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "Miter Ends";
         
         m_parts.Add(part);



         // StopFrontTop
         part = new Part(809, "StopFrontTop", this, 1, m_subAssemblyWidth - (1.3125m * 3.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "Miter Ends";
         
         m_parts.Add(part);



         // StopRearTop
         part = new Part(809, "StopRearTop", this, 1, m_subAssemblyWidth - (1.3125m * 3.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "Miter Ends";
         
         m_parts.Add(part);



         // StopFrontBot
         string crap;
         crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 3.0m * 1.3125m);
         part = new Part(809, "StopFrontBot", this, 1, m_subAssemblyWidth - (1.3125m * 3.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "1) Miter Ends" + "\r\n" +
                          "2)" + crap;
         
         m_parts.Add(part);



         // StopRearBot
         part = new Part(809, "StopRearBot", this, 1, m_subAssemblyWidth - (1.3125m * 3.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "Miter Ends";
         
         m_parts.Add(part);



         #endregion

         #region Glass


         //Glass Panel
         part = new Part(2828);
         part.FunctionalName = "Glass";
         part.PartGroupType = "Glass-Parts";
         part.Qnty = 1;
         part.PartName = "";
         part.PartLabel = "";
         part.ContainerAssembly = this;
         part.PartWidth = m_subAssemblyWidth - (1.625m * 2.0m);
         part.PartLength = m_subAssemblyHieght - (1.625m * 2.0m);
         
         m_parts.Add(part);



         #endregion

         #region Hardware


         //DS Sliding Door Lock
         part = new Part(2430, "Sliding Door Lock", this, 1, decimal.Zero);
         part.PartGroupType = "Hardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

          
      #endregion

         #region TrollyHardware


         //3 Blue Turcite Wheels
         part = new Part(1586, "Wheels", this, 2, decimal.Zero);
         part.PartGroupType = "TrollyHardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         //Pendant Bolt 
         part = new Part(2347, "PenBolt", this, 2, decimal.Zero);
         part.PartGroupType = "TrollyHardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         //Socket Set Screw 
         part = new Part(480, "SetScrew", this, 2, decimal.Zero);
         part.PartGroupType = "TrollyHardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         //Suspension Plate 
         part = new Part(2124, "Suspension Plate", this, 2, decimal.Zero);
         part.PartGroupType = "TrollyHardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         //Screw Hex Head Cap
         part = new Part(1567, "Hex Cap", this, 2, decimal.Zero);
         part.PartGroupType = "TrollyHardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         // Suspention Track
         part = new Part(2148, "Suspention Track", this, 2, 0.0m);
         part.PartGroupType = "TrollyHardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         // Aluminum Block Shim
         part = new Part(2454, "Block Shim", this, 2, 0.0m);
         part.PartGroupType = "TrollyHardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         // Track Stop
         part = new Part(2311, "Track Stop", this, 2, 0.0m);
         part.PartGroupType = "TrollyHardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);





         #endregion

         #region Seals


         // Weather Strip

         part = new Part(1029, "Weather Strip", this, 2, m_subAssemblyWidth);
         part.PartGroupType = "Seal-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

                                               
               
         
         #endregion

             #region Labor


         part = new LPart("Design", this, 4.0m, 80.0m);
         m_parts.Add(part);
         // Measure: Collect Information on Sizes from Contractor:
         // Provide Information for Approval:
         // Samples Correspondence: Ordering: Supervision

         part = new LPart("Draft", this, 3.0m, 80.0m);
         m_parts.Add(part);
         //Typical Drawings: Supervision

         part = new LPart("MetalHours", this, 8.0m, 80.0m);
         m_parts.Add(part);
         //1 Receive: 1 Handle: 1 Cut: 1 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

         part = new LPart("MuntinHours", this, 6.0m, 80.0m);
         m_parts.Add(part);
         //.5 Per Bar this 12 Bars:

         part = new LPart("GlazingHours", this, (this.Area * 0.1m) + 4.5m, 80.0m);
         m_parts.Add(part);
         //.5 Recieve: 1.0 InspectReject: .5 StoreHandle: 1.0 GlazeShimCalk: .5 SetGlassStop: 05 InsertGasket 

         part = new LPart("FinishHours", this, 4.0m, 80.0m);
         m_parts.Add(part);
         //2 SandLineGrain: 2 Finish

         part = new LPart("Stage", this, 0.5m, 80.0m);
         m_parts.Add(part);
         //.5 Stage

         part = new LPart("Load", this, 1.0m, 80.0m);
         m_parts.Add(part);
          //1 Load


         #endregion


      }


      #endregion


   }
}