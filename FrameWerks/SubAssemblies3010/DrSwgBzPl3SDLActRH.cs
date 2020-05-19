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

    public class DrSwgBzPl3SDLActRH : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal BrzPanelSwgDr = 12.125m;
        const decimal muntStileRedX2 = 2.0m * 3.125m;
        const decimal midRailRedX2 = 2.0m * 2.25m;
        const decimal stpPanHth = 12.75m;
        const decimal glsDrGapX2 = 2.59375m * 2.0m;
        const decimal glsPanGap = 16.71875m;
        const decimal glassDrGap = 2.59375m;
        const decimal topPanRedX2 = 2.0m * 77.125m;
        const decimal botPanRedX2 = 2.0m * 14.125m;
        const decimal epdmReduce = 2.6875m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.1250m;
        const decimal stopReduceX2 = 2.25m * 2.0m;
        const decimal stopReduce = 2.25m;
        const decimal stopRedPAN = 16.375m;




        #endregion

        #region Constructor

        public DrSwgBzPl3SDLActRH()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-DrSwgBzPl3SDLActRH";
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


            // RailMid
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4386, "RailMid", this, 1, m_subAssemblyWidth - midRailRedX2);
                part.PartGroupType = "BrzTB3inch";
                part.PartLabel = "1) Cope_Ends ";

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

            #region PanelBrz


            // ExtiraPanel ^^
            part = new Part(4043);
            part.FunctionalName = "ExtiraPanel";
            part.PartGroupType = "PanelBrz";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - 2 * glassDrGap);
            part.PartLength = (BrzPanelSwgDr);

            m_parts.Add(part);


            /////////////////////////////////////////////////////////////////////////////////////////////////


            // BrassC464
            for (int i = 0; i < 2; i++)
            {

                // BrassC464
                part = new Part(4042);
                part.FunctionalName = "BrassC464";
                part.PartGroupType = "PanelBrz";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - 2 * glassDrGap);
                part.PartLength = (BrzPanelSwgDr);

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Muntin

            //////////////////////////////////////////////////////////////////////////////

            // BrzMntHrz3Lt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4313, "BrzMntHrz3Lt", this, 1, m_subAssemblyWidth - muntStileRedX2);
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
                part = new Part(4298, "BrzGlsStpVert", this, 1, m_subAssemblyHieght - stopReduce - stopRedPAN);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // BrzPNLStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzPNLStpVert", this, 1, stpPanHth);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpTopBot
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4298, "BrzGlsStpTopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////



            #endregion

            #region Glass3SDL

            /////////////////////////////////////////////////////////////////////////////////////////////
            // 3 SDL GlassPanels
            for (int i = 0; i < 1; i++)
            {

                // 3 SDL GlassPanel
                part = new Part(4419);

                part.FunctionalName = "Gls3SDLite";
                part.PartGroupType = "Glass3SDL-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - glsDrGapX2);
                part.PartLength = (m_subAssemblyHieght - glassDrGap - glsPanGap);
                part.PartThick = 1.25m;

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyBrackets

            //Alum_CornerBrace

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4831, "Alum_CornerBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // SMS_10_1/2_FH

            for (int i = 0; i < 16; i++)
            {
                part = new Part(4832, "SMS_10_1/2_FH", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Alum_CornerBrace

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4830, "Alum_CornerBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // SMS_10_5/8_FH

            for (int i = 0; i < 16; i++)
            {
                part = new Part(4833, "SMS_10_5/8_FH", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Blue_CnrBrcSS14ga_0.4662

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4855, "Blue_CnrBrcSS14ga_0.4662", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //Black_CnrBrcSS14ga_0.638

            for (int i = 0; i < 8; i++)
            {
                part = new Part(4854, "Black_CnrBrcSS14ga_0.638", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //MS_FlatHead_8-32x3/16_SS

            for (int i = 0; i < 48; i++)
            {
                part = new Part(4876, "MS_FlatHead_8-32x3/16_SS", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare Logic


            // Hinges
            part = new Part(3685, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = ".25_RAD_Corner";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //AmesburyMultipointActive

            FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointActive GearAssy =
                new FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointActive(m_subAssemblyHieght, this);
            foreach (Part innerpart in GearAssy.Parts)
            {
                //inner
                this.Parts.Add(innerpart);

            }

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

                //GlazePreSet
                part = new Part(4314, "GlazePreSet", this, 1, periSeal - botPanRedX2 - 8.0m * epdmReduce);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //GlazeWedgeSeals
                part = new Part(4399, "GlazeWedgeSeals", this, 1, periSeal - botPanRedX2 - 8.0m * epdmReduce);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //GlazePreSet
                part = new Part(4314, "GlazePreSet", this, 1, periSeal - topPanRedX2 - 8.0m * epdmReduce);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //GlazeWedgeSeals
                part = new Part(4399, "GlazeWedgeSeals", this, 1, periSeal - topPanRedX2 - 8.0m * epdmReduce);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////




            #endregion

        }

        private int HingeCount(decimal HingeAxisLength)
        {
            int result = 0;

            if (HingeAxisLength < 84.0m)
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 114.0m))
            {
                result = 5;
            }
            else if ((HingeAxisLength >= 114.0m) && (HingeAxisLength < 134.0m))
            {
                result = 6;
            }
            else if ((HingeAxisLength >= 134.0m) && (HingeAxisLength < 164.0m))
            {
                result = 7;
            }


            return result;
        }


        #endregion

    }




}