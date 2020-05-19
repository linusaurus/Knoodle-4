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

namespace FrameWorks.System3250
{
    
    public class DoorBiFoldJambPanelStd : SubAssemblyBase
    {

        #region Fields

        static int createID;
        Part part;
        string partleader;

        #endregion

        #region Constructor

        public DoorBiFoldJambPanelStd()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3250-DoorBiFoldJambPanelStd";


        }

        #endregion

        #region Error Handling

        System.Exception HardwareApplicationError(string description)
        {

            return new SystemException(description);
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region Panel-Frame



            // StileRight -->>
            part = new Part(2951, "StileR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // StileLeft <<--
            part = new Part(2951, "StileL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // RailTop ^^
            part = new Part(2951, "RailT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // RailBottom ||  
            part = new Part(2951, "RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);



            #endregion

            #region Stop



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
            part = new Part(809, "StopFrontTop", this, 1, m_subAssemblyWidth - (1.3125m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);


            // StopRearTop
            part = new Part(809, "StopRearTop", this, 1, m_subAssemblyWidth - (1.3125m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);


            // StopFrontBot
            string crap;
            crap = Functions.StopWeepMachining(m_subAssemblyWidth - 2.0m * 1.3125m);
            part = new Part(809, "StopFrontBot", this, 1, m_subAssemblyWidth - (1.3125m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "1) Miter Ends" + "\r\n" +
                             "2)" + crap;
            
            m_parts.Add(part);


            // StopRearBot
            part = new Part(809, "StopRearBot", this, 1, m_subAssemblyWidth - (1.3125m * 2.0m));
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);


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


            #endregion

            #region Hardware


            // Pivot ||
            part = new Part(2998, "Pivot", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // WallPivot <<--
            part = new Part(2999, "WallPivot", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);



            #endregion

            #region WeatherSeals

            //WeatherSeal
            part = new Part(2274, "WeatherSeal", this, 1, (m_subAssemblyHieght * 4.0m));
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            //VinylSpline
            part = new Part(2786, "VinylSpline", this, 1, (-1.3125m * 4.0m + m_subAssemblyHieght * 4.0m) + (-1.3125m * 4.0m + m_subAssemblyWidth * 4.0m));
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region Glass


            //Glass Panel

            part = new Part(2828);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (1.625m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (1.625m * 2.0m);
            
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

            part = new LPart("PatinaMat", this, this.m_perimeter, 1.62m);
            m_parts.Add(part);
            //$1.62 per inch

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



        #endregion

    }
}