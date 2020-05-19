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
using FrameWorks.Makes.System2060;


namespace FrameWorks.Makes.System2060
{

    public class DrAl_LS_Mid_2x4_RtX : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;

        const decimal stopReduceX2 = 2.0m * 2.25m;
        const decimal glassReduceX2 = 2.0m * 2.59375m;
        const decimal sidMuntGap2 = 2.0m * 2.25m;

        #endregion

        #region Constructor

        public DrAl_LS_Mid_2x4_RtX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2060-DrAl_LS_Mid_2x4_RtX";
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

            #region DoorAlumTB

            // StileLeft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(5131, "StileLeft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorAlumTB-Parts";
                part.PartLabel = "1) Miter Ends";
                m_parts.Add(part);

            }

            // StileRight

            ///////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5131, "StileRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorAlumTB-Parts";
                part.PartLabel = "1) Miter Ends";

                m_parts.Add(part);

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5131, "RailTop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorAlumTB-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(5131, "RailBot", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorAlumTB-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region StopAlum

            // AlumGlsStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5123, "AlumGlsStpVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            // AlumGlsStpTopBot
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5123, "AlumGlsStpTopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // MuntHorz
            for (int i = 0; i < 12; i++)
            {

                part = new Part(5306, "MuntHorz", this, 1, (m_subAssemblyWidth - sidMuntGap2) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "?Ends";

                m_parts.Add(part);

            }

            // MuntVert
            for (int i = 0; i < 8; i++)
            {

                part = new Part(5306, "MuntVert", this, 1, (m_subAssemblyHieght - sidMuntGap2) / 4.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "?Ends";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HDPE

            // HDPE_LS_LockEdge
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4266, "HDPE_LS_LockEdge", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);
            }

            // HDPETop
            //for (int i = 0; i < 1; i++)
            //{


            //part = new Part(3762, "HDPETop", this, 1, m_subAssemblyWidth);
            //part.PartGroupType = "HDPE-Parts";
            //part.PartWidth = part.Source.Width;
            //part.PartThick = part.Source.Height;
            //part.PartLabel = labelStileR = "";

            //m_parts.Add(part);

            //}

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region AssyHrdwrDoor


            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // FlatHead_8-32x3/16_UndercutHead
            for (int i = 0; i < 16; i++)
            {
                part = new Part(502, "FlatHead_8-32x3/16_UndercutHead", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrace
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4830, "AlumCnrBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            for (int i = 0; i < 16; i++)
            {
                part = new Part(4833, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // AlumCnrBrace
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4831, "AlumCnrBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            for (int i = 0; i < 16; i++)
            {
                part = new Part(4833, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            // SS_0.7049_OutsetCrnBrace 
            for (int i = 0; i < 8; i++)
            {
                part = new Part(4829, "SS_0.7049_OutsetCrnBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // FlatHead_8-32x3/16_UndercutHead
            for (int i = 0; i < 32; i++)
            {
                part = new Part(502, "FlatHead_8-32x3/16_UndercutHead", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region GuidesTop

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // TopGuide4438

            for (int i = 0; i < 1; i++)
            {
                part = new Part(5217, "TopGuide4438", this, 1, 0.0m);
                part.PartGroupType = "GuidesTop-Parts";
                part.PartLabel = "4438_OverLapLead";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // TopGuide4438

            for (int i = 0; i < 1; i++)
            {
                part = new Part(4438, "TopGuide4438", this, 1, 0.0m);
                part.PartGroupType = "GuidesTop-Parts";
                part.PartLabel = "4438_HalfGear";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HookCap

            // EndCap
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4397, "EndCap", this, 1, m_subAssemblyHieght + 0.0625m);
                part.PartGroupType = "HookCap-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////

            // HookStrip
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3710, "HookStrip", this, 1, m_subAssemblyHieght + 0.0625m);
                part.PartGroupType = "HookCap-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Glass

            //Glass Panel
            part = new Part(3300);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduceX2;
            part.PartLength = m_subAssemblyHieght - glassReduceX2;
            part.PartThick = 1.25m;
            part.PartLabel = "SDL_2x4";

            m_parts.Add(part);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HardWare Logic

            // LS_HalfGear

            part = new Part(4096, "LS_HalfGear", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // CarrageKit

            part = new Part(3422, "CarrageKit", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////

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



            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Seal/Weatherstripping

            //EPDM_PreSet

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.7313m, m_subAssemblyWidth - 2.7313m);

                part = new Part(4314, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            //EPDM_Wedge

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.6286m, m_subAssemblyWidth - 2.6286m);

                part = new Part(4399, "EPDM_Wedge", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Edge & Bottom Seal

            for (int i = 0; i < 2; i++)
            {

                part = new Part(1005, "Edge & Bottom Seal", this, 1, m_subAssemblyHieght + m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Top Seal

            for (int i = 0; i < 2; i++)
            {


                part = new Part(3783, "Top Seal", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // HookPileT+Fin

            for (int i = 0; i < 4; i++)
            {

                part = new Part(3959, "HookPileT+Fin", this, 1, m_subAssemblyHieght + 0.0625m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////


        }
        #endregion

    }

}