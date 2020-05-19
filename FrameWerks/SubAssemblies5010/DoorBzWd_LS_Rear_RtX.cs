#region Copyright (c) 2017 WeaselWare Software
/************************************************************************************
'
' Copyright  2017 WeaselWare Software 
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
' Portions Copyright 2017 WeaselWare Software
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
using FrameWorks.Makes.System5010;


namespace FrameWorks.Makes.System5010
{

    public class DoorBzWd_LS_Rear_RtX : SubAssemblyBase
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

        public DoorBzWd_LS_Rear_RtX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-DoorBzWd_LS_Rear_RtX";
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


            #region DoorBZtbAL



            // StileBZtbALLeft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4325, "StileBZtbALLeft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorBzAlTB-Parts";
                part.PartLabel = "1) Miter Ends";
                m_parts.Add(part);

            }




            // StileBZtbALRight
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4325, "StileBZtbALRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorBzAlTB-Parts";
                part.PartLabel = "1) Miter Ends";

                m_parts.Add(part);

            }




            // RailBZtbALtop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4325, "RailBZtbALtop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorBzAlTB-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }




            // RailBZtbALbot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4325, "RailBZtbALbot", this, 1, m_subAssemblyWidth);
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
                part = new Part(4857, "Alum_PVC_Corner_Bracket", this, 1, 0.0m);
                part.PartGroupType = "AssyBraces-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //MS_FlatHead_8-32x3/4_SS

            for (int i = 0; i < 32; i++)
            {
                part = new Part(4858, "MS_FlatHead_8-32x3/4_SS", this, 1, 0.0m);
                part.PartGroupType = "AssyBraces-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////

            // Black_CrnBrSS14ga_0.6377

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4854, "Black_CrnBrSS14ga_0.6377", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Blue_CrnBrSS14ga_0.4662

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4855, "Blue_CrnBrSS14ga_0.4662", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Orange_CrnBrSS14ga_0.4662

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4866, "Orange_CrnBrSS14ga_0.4662", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // MS_FlatHead_8-32x3/16_SS

            for (int i = 0; i < 48; i++)
            {
                part = new Part(1545, "MS_FlatHead_8-32x3/16_SS", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region GuidesTop

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // TopGuide5135

            for (int i = 0; i < 1; i++)
            {
                part = new Part(5135, "TopGuide5135", this, 1, 0.0m);
                part.PartGroupType = "GuidesTop-Parts";
                part.PartLabel = "5135_HalfGearStile";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // TopGuide5213

            for (int i = 0; i < 1; i++)
            {
                part = new Part(5213, "TopGuide5213", this, 1, 0.0m);
                part.PartGroupType = "GuidesTop-Parts";
                part.PartLabel = "5213_Overlap";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HookCap

            // EndCapMetal

            part = new Part(4498, "EndCapMetal", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // HookStrip

            part = new Part(3710, "HookStrip", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

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
            part.PartThick = 1.230m;

            m_parts.Add(part);

            #endregion

            #region HardWare Logic

            // LS_HalfGear

            part = new Part(4096, "LS_HalfGear", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////

            // LS_HandleKit

            part = new Part(4549, "LS_HandleKit", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////

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
                part = new Part(4284, "WedeEPDM", this, 1, peri);
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