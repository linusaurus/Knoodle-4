﻿#region Copyright (c) 2016 WeaselWare Software
/************************************************************************************
'
' Copyright  2016 WeaselWare Software 
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
' Portions Copyright 2016 WeaselWare Software
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
using FrameWorks.Makes.System5010HVY;


namespace FrameWorks.Makes.System5010HVY
{

    public class DrBzAluWdLSLeadX : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;
        const decimal stopReduceX2 = 2.0m * 2.25m;
        const decimal glassReduceX2 = 2.0m * 2.59375m;
        const decimal glassVinylX2 = 2.0m * 2.71875m;
        const decimal topGuideHDPE = 0.854m;




        #endregion

        #region Constructor

        public DrBzAluWdLSLeadX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010HVY-DrBzAluWdLSLeadX";
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


            ///////////////////////////////////////////////////////////////////////////////////////////////


            #region DoorBzAlTB



            // StileBTBLeft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4554, "StileBTBLeft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorBzAlTB-Parts";
                part.PartLabel = "1) Miter Ends";
                m_parts.Add(part);

            }




            // StileBTBRight
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4554, "StileBTBRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorBzAlTB-Parts";
                part.PartLabel = "1) Miter Ends";

                m_parts.Add(part);

            }




            // RailBTBtop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4554, "RailBTBtop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorBzAlTB-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }




            // RailBTBbot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4554, "RailBTBbot", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorBzAlTB-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }




            #endregion

            #region StopAlum


            // BrzGlsStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4327, "AlumGlsStpVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            // BrzGlsStpTopBot
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4327, "AlumGlsStpTopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////




            #endregion

            #region DrCldWood



            // StileWdLft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4337, "StileWdLft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DrCldWood-Parts";
                part.PartLabel = "1) Miter Ends";
                m_parts.Add(part);

            }




            // StileWdRt
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4337, "StileWdRt", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DrCldWood-Parts";
                part.PartLabel = "1) Miter Ends";

                m_parts.Add(part);

            }




            // RailWdTop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4337, "RailWdTop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DrCldWood-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }




            // RailWdBot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4337, "RailWdBot", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorBzAlTB-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }




            #endregion

            #region StopWood


            // WdGlsStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4331, "WdGlsStpVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            // WdGlsStpTopBot
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4331, "WdGlsStpTopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////




            #endregion

            #region HDPE



            // HDPE_LS_LockEdge1
            for (int i = 0; i < 1; i++)
            {

                part = new Part(911, "HDPE_LS_LockEdge1", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);
            }



            // HDPE_LS_LockEdge2
            for (int i = 0; i < 1; i++)
            {

                part = new Part(911, "HDPE_LS_LockEdge2", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);
            }



            // HDPE_LS_TopGuide
            for (int i = 0; i < 2; i++)
            {

                part = new Part(911, "HDPE_LS_TopGuide", this, 1, topGuideHDPE);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);
            }



            #endregion

            #region AssyBraces


            //Alum_PVC_Corner_Bracket

            for (int i = 0; i < 4; i++)
            {
                part = new Part(911, "Alum_PVC_Corner_Bracket", this, 1, 0.0m);
                part.PartGroupType = "AssyBraces-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //SS_0.4662_Offset_In

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4855, "SS_0.4662_Offset_In", this, 1, 0.0m);
                part.PartGroupType = "AssyBraces-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            //SS_0.6737 _Offset_Out

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4854, "SS_0.6737 _Offset_Out", this, 1, 0.0m);
                part.PartGroupType = "AssyBraces-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            //SS_0.4662_Offset_Out

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4866, "SS_0.4662_Offset_Out", this, 1, 0.0m);
                part.PartGroupType = "AssyBraces-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion

            #region HookCap

            // EndCapWood

            part = new Part(4338, "EndCapWood", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // HookStrip

            part = new Part(3710, "HookStrip", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            #endregion

            #region TopGuides

            //TopGuides

            for (int i = 0; i < 2; i++)
            {

                part = new Part(5217, "RootBlock", this, 1, 0.0m);
                part.PartGroupType = "TopGuides";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            #endregion

            #region Glass


            //Glass Panel
            part = new Part(4550);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduceX2;
            part.PartLength = m_subAssemblyHieght - glassReduceX2;
            part.PartThick = 1.50m;

            m_parts.Add(part);

            #endregion

            #region HardWare Logic


            // LiftSlideGear

            part = new Part(3421, "LiftSlideGear", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////

            // CoverExtension

            if (m_subAssemblyHieght >= 104.0m)
            {
                int c;
                decimal result = decimal.Zero;
                result = (m_subAssemblyHieght - 104.0m);
                result = decimal.Divide(result, 24.0m);
                if (result > 0.0m && result < 24.0m)
                {
                    c = 1;
                }

                else
                {
                    c = Convert.ToInt32(Math.Round(result, 0)) + 1;
                }

                part = new Part(3430, "CoverExtension", this, c, 24.0m);

                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ///////////////////////

            // LockBoltKits

            part = new Part(3431, "LockBoltKits", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // ShimsLockBolt

            part = new Part(3383, "ShimsLockBolt", this, 2, m_subAssemblyHieght);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // CarrageKit

            part = new Part(3422, "CarrageKit", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////


            // LinkRod


            if (m_subAssemblyWidth >= 25.5m && m_subAssemblyWidth < 130.0m)
            {
                if (m_subAssemblyWidth >= 25.5m && m_subAssemblyWidth <= 50.0m)
                {
                    part = new Part(3423, "LinkRod", this, 1, m_subAssemblyWidth);
                }
                if (m_subAssemblyWidth > 50.0m && m_subAssemblyWidth <= 78.0m)
                {
                    part = new Part(2100, "LinkRod", this, 1, m_subAssemblyWidth);
                }
                if (m_subAssemblyWidth > 78.0m && m_subAssemblyWidth <= 130.0m)
                {
                    part = new Part(3424, "LinkRod", this, 1, m_subAssemblyWidth);
                }

            }
            else
            {
                part = new Part(911, "LinkRod", this, 1, m_subAssemblyWidth);
            }


            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////



            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - glassVinylX2, m_subAssemblyWidth - glassVinylX2);

            //PreSetEPDM

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - glassVinylX2, m_subAssemblyWidth - glassVinylX2);
                part = new Part(4314, "PreSetEPDM", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            //WedeEPDM

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - glassVinylX2, m_subAssemblyWidth - glassVinylX2);
                part = new Part(4399, "WedeEPDM", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            //////////////////////////

            // Edge & Bottom Seal

            for (int i = 0; i < 2; i++)
            {

                part = new Part(1005, "Edge & Bottom Seal", this, 1, m_subAssemblyHieght + m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            ///////////////////////////

            // Top Seal

            for (int i = 0; i < 2; i++)
            {


                part = new Part(3783, "Top Seal", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////

            // HookPileT+Fin

            for (int i = 0; i < 2; i++)
            {

                part = new Part(3959, "HookPileT+Fin", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////



            #endregion


            ///////////////////////////////////////////////////////////////////////////////////////////////

        }
        #endregion

    }

}