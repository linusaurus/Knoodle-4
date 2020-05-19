#region Copyright (c) 2011 WeaselWare Software
/************************************************************************************
'
' Copyright  2011 WeaselWare Software 
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
' Portions Copyright 2011 WeaselWare Software
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


namespace FrameWorks.Makes.Tiburon
{
    [Serializable()]
    public class SashSSCasementLHR : SubAssemblyBase
    {

        #region Fields

        static int createID;


        #endregion

        #region Constructor

        public SashSSCasementLHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3250-SashSSCasementLHR";
        }
        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {
            Part part;

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;


            #region SashCoreAlum


            // SubStileL <<--
            part = new Part(3077, "SubStileL", this, 1, m_subAssemblyHieght - 2 * .375m);
            part.PartGroupType = "SashCoreAlum-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL;

            m_parts.Add(part);


            // SubStileR -->>
            part = new Part(3077, "SubStileR", this, 1, m_subAssemblyHieght - 2 * .375m);
            part.PartGroupType = "SashCoreAlum-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR;

            m_parts.Add(part);


            // SubRailT ^^
            part = new Part(3077, "SubRailT", this, 1, m_subAssemblyWidth - 2 * .375m);
            part.PartGroupType = "SashCoreAlum-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail;

            m_parts.Add(part);


            // SubRailB ||
            part = new Part(3077, "SubRailB", this, 1, m_subAssemblyWidth - 2 * .375m);
            part.PartGroupType = "SashCoreAlum-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail;

            m_parts.Add(part);


            #endregion

            #region ExtCladSS

            // StileExtL <<--
            part = new Part(3094, "StileExtL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "ExtCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL;

            m_parts.Add(part);


            // StileExtR -->>
            part = new Part(3094, "StileExtR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "ExtCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR;

            m_parts.Add(part);


            // RailExtT ^^
            part = new Part(3094, "RailExtT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "ExtCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail;

            m_parts.Add(part);


            // RailExtB ||
            part = new Part(3094, "RailExtB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "ExtCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail;

            m_parts.Add(part);


            #endregion

            #region IntCladSS


            // StileIntL <<--
            part = new Part(3095, "StileIntL", this, 1, m_subAssemblyHieght - 2 * .75m);
            part.PartGroupType = "IntCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL;

            m_parts.Add(part);


            // StileIntR -->>
            part = new Part(3095, "StileIntR", this, 1, m_subAssemblyHieght - 2 * .75m);
            part.PartGroupType = "IntCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR;

            m_parts.Add(part);


            // RailIntT ^^
            part = new Part(3095, "RailIntT", this, 1, m_subAssemblyWidth - 2 * .75m);
            part.PartGroupType = "IntCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail;

            m_parts.Add(part);


            // RailIntB ||
            part = new Part(3095, "RailIntB", this, 1, m_subAssemblyWidth - 2 * .75m);
            part.PartGroupType = "IntCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail;

            m_parts.Add(part);


            #endregion

            #region HDPEdge


            part = new Part(3389, "HDPEdgeLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HDPEdge-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            part = new Part(3389, "HDPEdgeRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HDPEdge-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            part = new Part(3389, "HDPEdgeTop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HDPEdge-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            part = new Part(3389, "HDPEdgeBottom", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HDPEdge-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion

            #region Glass

            //Glass Panel
            part = new Part(3122);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (1.46875m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (1.46875m * 2.0m);

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

            part = new LPart("MetalHours", this, 10.0m, 80.0m);
            m_parts.Add(part);
            //1 Recieve: 1 Handle: 1 CutFrame: 1 CutStop: 1.5 Machine: 1.5 HardwarePrep: 1 MountHardware: 2 Weld: 

            part = new LPart("FinishHours", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 LinegrainSand: 2 Finish

            part = new LPart("PatinaMat", this, this.m_perimeter, 1.62m);
            m_parts.Add(part);
            //$1.62 per inch

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