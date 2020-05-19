#region CopyRight
/************************************************************************************
'
' Copyright  2010 WeaselWare Software 
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
' Portions Copyright 2010 WeaselWare Software
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

namespace FrameWorks.Makes.System2000
{
    
    public class SlidingDoorRearXR : SubAssemblyBase
    {

        #region Fields

        static int createID;
        Part part;
        #endregion

        #region Constructor

        public SlidingDoorRearXR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "SlidingDoorRearXR";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {


            


            #region Panel


            // StileL <<--
            part = new Part(2688, "StileL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // StileR -->>
            part = new Part(2688, "StileR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // RailT ^^
            part = new Part(2688, "RailT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // RailB ||
            part = new Part(2688, "RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // Hooking Cap R -->>
            part = new Part(3019, "Hooking Cap R", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "Machine Notch 0.50m";
           
            m_parts.Add(part);

            // Plastic Hook Strip
            part = new Part(924, "Hook Strip", this, 1, m_subAssemblyHieght - 0.5m);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // Filler Edge
            part = new Part(1818, "Filler Edge", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // Brush Holder 
            part = new Part(1404, "Brush Holder", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // Guide Fin 
            part = new Part(2071, "Guide Fin", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);





            #endregion

            #region Stop


            // StopLeft
            part = new Part(800, "StopLeft", this, 1, m_subAssemblyHieght - (1.3125m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
           
            m_parts.Add(part);



            // StopRight
            part = new Part(800, "StopRight", this, 1, m_subAssemblyHieght - (1.3125m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
           
            m_parts.Add(part);


            // StopTop
            part = new Part(800, "StopTop", this, 1, m_subAssemblyWidth - (1.3125m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
           
            m_parts.Add(part);


            // StopBot
            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 2.0m * 1.3125m);
            part = new Part(800, "StopBot", this, 1, m_subAssemblyWidth - (1.3125m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "1) Miter Ends" + "\r\n" +
                             "2)" + crap;
           
            m_parts.Add(part);



            #endregion

            #region Glass



            //Glass Panel

            part = new Part(1022);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;

            part.PartWidth = m_subAssemblyWidth - (1.625m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (1.625m * 2.0m);
           
            m_parts.Add(part);




            #endregion

            #region Hardware


            //CORNER L-BRACE
            part = new Part(2674, "Corner L-Brace", this, 8, 0.0m);
            part.PartGroupType = "Assembly_Hardware-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // Screws 
            part = new Part(1300, "Screws", this, Convert.ToInt32(((m_subAssemblyHieght / 4.0m) + 2.0m)), decimal.Zero);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "Screws for 924";
           
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
           
            m_parts.Add(part);


            // Glazing Vinyl
            part = new Part(2772, "Glazing Vinyl", this, 1, FrameWorks.Functions.Perimeter(m_subAssemblyWidth, m_subAssemblyHieght, 1.625m) * 2.0m);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);



            #endregion

            #region Labor


            part = new LPart("Design", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //Collect Information on Sizes: Measure: Provide Information for Approval: Order: Supervision

            part = new LPart("Draft", this, 3.0m, 80.0m);
            m_parts.Add(part);
            //Typical Drawings

            part = new LPart("MetalHours", this, 8.0m, 80.0m);
            m_parts.Add(part);
            //1 Recieve: 1 Handle: 1 CutSash: 1 CutGlassStop: 1.5 Machine: 1.5 Hardware Prep: 1 Mount Hardware: 


            part = new LPart("Finish", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 Sand Linegrain: 2 Finish:

            part = new LPart("GlazingHours", this, (this.Area * 0.17m) + 1.5m, 80.0m);
            m_parts.Add(part);
            //.5 Recieve: .5 InspectReject: .5 StoreHandle: * .17 Hrs Per Square Ft: 

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


        #endregion



    }
}