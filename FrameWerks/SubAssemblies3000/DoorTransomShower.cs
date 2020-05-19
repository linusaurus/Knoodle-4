#region Copyright (c) 2010 WeaselWare Software
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
using System.Runtime;

namespace FrameWorks.Makes.System3000
{
    
    public class DoorTransomShower : SubAssemblyBase
    {

        #region Fields


        Part part;
        string partleader;

        #endregion

        #region Constructor

        public DoorTransomShower()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys3000-DoorTransomShower";


        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region Panel-Frame


            // StileRight -->>
            part = new Part(1167, "StileR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // StileLeft <<--
            part = new Part(1167, "StileL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // RailTop ^^
            part = new Part(1167, "RailT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // RailBottom ||
            part = new Part(1167, "RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region CapBronze


            part = new Part(2972, "CapBronze-Top", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CapBronze-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region Filler

            part = new Part(1817, "Filler-Top", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Filler-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            part = new Part(1817, "Filler-Bottom", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Filler-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            part = new Part(1813, "Filler-Left", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Filler-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            part = new Part(1816, "Filler-Right", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Filler-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region Stop


            // StopFrontLeft
            part = new Part(2986, "StopFrontLeft", this, 1, m_subAssemblyHieght - (1.0m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);


            // StopRearLeft
            part = new Part(2986, "StopRearLeft", this, 1, m_subAssemblyHieght - (1.0m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);


            // StopFrontRight
            part = new Part(2986, "StopFrontRight", this, 1, m_subAssemblyHieght - (1.0m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);


            // StopRearRight
            part = new Part(2986, "StopRearRight", this, 1, m_subAssemblyHieght - (1.0m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);


            // StopFrontTop
            part = new Part(2986, "StopFrontTop", this, 1, m_subAssemblyWidth - (1.0m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);


            // StopRearTop
            part = new Part(2986, "StopRearTop", this, 1, m_subAssemblyWidth - (1.0m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);


            // StopFrontBot
            part = new Part(2986, "StopFrontBot", this, 1, m_subAssemblyWidth - (1.0m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);


            // StopRearBot
            part = new Part(2986, "StopRearBot", this, 1, m_subAssemblyWidth - (1.0m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);


            #endregion

            #region Muntin


            // MuntinBarExtV1 ||
            part = new Part(2987, "MuntinBarExtV1", this, 1, m_subAssemblyWidth - 1.3125m * 2.0m);
            part.PartGroupType = "Muntin-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // MuntinBarExtV2 ||
            part = new Part(2987, "MuntinBarExtV2", this, 1, m_subAssemblyWidth - 1.3125m * 2.0m);
            part.PartGroupType = "Muntin-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // MuntinBarIntV1 ||
            part = new Part(2987, "MuntinBarIntV1", this, 1, m_subAssemblyWidth - 1.3125m * 2.0m);
            part.PartGroupType = "Muntin-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // MuntinBarIntV2 ||
            part = new Part(2987, "MuntinBarIntV2", this, 1, m_subAssemblyWidth - 1.3125m * 2.0m);
            part.PartGroupType = "Muntin-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region FoamTape


            // Foam Tape Vertical ||  #2808
            part = new Part(2808, "FoamTapeV", this, 4, m_subAssemblyHieght - 2.0m * 1.0m);
            part.PartGroupType = "FoamTape-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // Foam Tape Horizontal <-->  #2808
            part = new Part(2808, "FoamTapeH", this, 8, m_subAssemblyWidth - (2.0m + 1.0m));
            part.PartGroupType = "FoamTape-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);



            #endregion

            #region WeatherSeals

            //Door Bulb Seals
            part = new Part(1769, "Bulb Seal Door", this, 1, ((m_subAssemblyHieght * 2.0m) + (m_subAssemblyWidth * 2.0m)));
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // Glazing Seal
            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyWidth - (1.3125m * 2.0m),
             m_subAssemblyHieght - (1.3125m * 2.0m));
            part = new Part(1819, "Glazing Seal", this, 1, peri *= 2.0m);
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // Door Bottom
            part = new Part(1518, "Door Bottom", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);





            #endregion

            #region Glass


            //Glass Panel
            part = new Part(2989);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (1.6875m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (1.6875m * 2.0m);
            
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


        private int HingeCount(decimal HingeAxisLength)
        {
            int result = 0;

            if (HingeAxisLength < 84.0m)
            {
                result = 3;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 114.0m))
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 114.0m) && (HingeAxisLength < 134.0m))
            {
                result = 5;
            }
            else if ((HingeAxisLength >= 134.0m) && (HingeAxisLength < 164.0m))
            {
                result = 6;
            }


            return result;
        }


        #endregion

    }
}