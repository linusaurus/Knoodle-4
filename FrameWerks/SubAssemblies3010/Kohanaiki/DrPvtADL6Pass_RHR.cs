#region Copyright (c) 2015 WeaselWare Software
/************************************************************************************
'
' Copyright  2015 WeaselWare Software 
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
' Portions Copyright 2015 WeaselWare Software
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
using FrameWorks.Makes.System3010;


namespace FrameWorks.Makes.System3010
{

    public class DrPvtADL6Pass_RHR : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal muntStileRedX2 = 2.0m * 3.125m;
        const decimal muntHeightX2 = 2.0m * 1.0m;
        const decimal glsDrGapX2 = 2.59375m * 2.0m;
        const decimal epdmReduce = 2.6875m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.1250m;
        const decimal stopReduceX2 = 2.25m * 2.0m;

        #endregion

        #region Constructor

        public DrPvtADL6Pass_RHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-DrPvtADL6Pass_RHR";
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

            #region BrzTB3inch


            ////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4312, "StileLeft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "BrzTB3inch";
                part.PartLabel = "1) Miter_Ends";
                m_parts.Add(part);

            }


            // StileRight
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4312, "StileRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "BrzTB3inch";
                part.PartLabel = "1) Miter_Ends";

                m_parts.Add(part);

            }


            // RailTop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4312, "RailTop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "BrzTB3inch";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }


            // RailBot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4312, "RailBot", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "BrzTB3inch";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region HDPE



            // HDPELockEdge
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4269, "HDPELockEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);

            }



            // HDPEHingEdge
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4268, "HDPEHingEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);

            }



            // HDPETop
            for (int i = 0; i < 1; i++)
            {


                part = new Part(4269, "HDPETop", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "";

                m_parts.Add(part);

            }


            // HDPEBot
            for (int i = 0; i < 1; i++)
            {


                part = new Part(4270, "HDPEBot", this, 1, m_subAssemblyWidth + 2.0M * hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "";

                m_parts.Add(part);

            }



            #endregion

            #region Muntin

            //////////////////////////////////////////////////////////////////////////////

            // BrzMntHrz6Lt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4313, "BrzMntHrz6Lt", this, 1, m_subAssemblyWidth - muntStileRedX2);
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////

            // BrzMntVrt6Lt
            for (int i = 0; i < 6; i++)
            {
                part = new Part(4313, "BrzMntVrt6Lt", this, 1, (m_subAssemblyHieght - muntStileRedX2 - muntHeightX2) / 3.0m);
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////



            #endregion

            #region StopBrz

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlsStpVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpTopBot
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlsStpTopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // BrzSpacerStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4317, "BrzSpacerStpVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // BrzSpacerStpTopBot
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4317, "BrzSpacerStpTopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Glass6SDL

            /////////////////////////////////////////////////////////////////////////////////////////////
            // 6 ADL GlassPanels
            for (int i = 0; i < 1; i++)
            {

                // 6 ADL GlassPanel
                part = new Part(2137);

                part.FunctionalName = "Gls6ADL";
                part.PartGroupType = "Glass6SDL-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - glsDrGapX2);
                part.PartLength = (m_subAssemblyHieght - glsDrGapX2);
                part.PartThick = 0.5625m;

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets


            //SS_0.4525_TYPE1

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4408, "SS_0.4525_TYPE1", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            //SS_0.6637 _TYPE2

            for (int i = 0; i < 8; i++)
            {
                part = new Part(4409, "SS_0.6637 _TYPE2", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            //SS_1.0346_TYPE3

            for (int i = 0; i < 8; i++)
            {
                part = new Part(4410, "SS_1.0346_TYPE3", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion

            #region HardWare Logic

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            // TOP_PIVOT_WLKNG_BM
            for (int i = 0; i < 1; i++)
            {

                part = new Part(3933, "TOP_PIVOT_WLKNG_BM", this, 1, 0.0m);
                part.PartGroupType = "HardWare";
                part.PartLabel = "WB_PIVOT";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            // TOP_PIVOT_COVER
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4417, "TOP_PIVOT_COVER", this, 1, 0.0m);
                part.PartGroupType = "HardWare";
                part.PartLabel = "BRASS_COVER";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            // FLOOR_CLOSER_90° 
            for (int i = 0; i < 1; i++)
            {

                part = new Part(3929, "FLOOR_CLOSER_90°", this, 1, 0.0m);
                part.PartGroupType = "HardWare";
                part.PartLabel = "FLOOR_CLOSER_90°";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            // BTM_ARM_CNTR_PVT
            for (int i = 0; i < 1; i++)
            {

                part = new Part(3932, "BTM_ARM_CNTR_PVT", this, 1, 0.0m);
                part.PartGroupType = "HardWare";
                part.PartLabel = "BOTTOM_PIVOT_ARM";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            // SPINDLE_LHR
            for (int i = 0; i < 1; i++)
            {

                part = new Part(2350, "SPINDLE_RHR", this, 1, 0.0m);
                part.PartGroupType = "HardWare";
                part.PartLabel = "DETERMINE_HEIGHT";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //AmesburyMultipointPassive

            FrameWorks.Makes.Hardware.Amesbury.Premiere2000.MultipointPassive GearAssy =
                new FrameWorks.Makes.Hardware.Amesbury.Premiere2000.MultipointPassive(m_subAssemblyHieght, this);
            foreach (Part innerpart in GearAssy.Parts)
            {
                //inner
                this.Parts.Add(innerpart);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            //SwivSpin
            part = new Part(5329, "SwivSpin", this, 1, 0.0m);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //DoorBotPVC

            part = new Part(1518, "DoorBotPVC", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDMpreSet
                part = new Part(4314, "EPDMpreSet", this, 1, periSeal - epdmReduce);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //WedgEPDM
                part = new Part(4284, "WedgEPDM", this, 1, periSeal - epdmReduce);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////




            #endregion

        }




        #endregion

    }




}