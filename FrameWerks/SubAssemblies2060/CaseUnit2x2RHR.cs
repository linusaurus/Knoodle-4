
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

namespace FrameWorks.Makes.System2060
{

    public class CaseUnit2x2RHR : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal frameReduce2X = 0.9375m * 2.0m;
        const decimal screenReduce2X = 1.51202m * 2.0m;
        const decimal AlumCrnBrk = 0.625m;
        const decimal PointSetScrew = 0.25m;
        const decimal gaskFrmReduce = 1.250m;
        const decimal gstopReduce2X = 1.88285m * 2.0m;
        const decimal glassReduce2X = 2.21875m * 2.0m;
        const decimal gaskSashReduce = 2.1875m;
        const decimal edgeSealAdd = 0.375m;
        const decimal MuntGapX2 = 2.03125m * 2.0m;

        //static int createID;

        #endregion

        #region Constructor

        public CaseUnit2x2RHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2060-CaseUnit2x2RHR";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;



            #region Frame

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // JmbAlumR -->>

            part = new Part(4347, "JmbAlumR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);

            // JmbAlumL <<-- 

            part = new Part(4347, "JmbAlumL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + FrameWorks.Functions.TieBarLockCenter(this.SubAssemblyHieght);

            m_parts.Add(part);

            // HeadAlum ^^

            part = new Part(4347, "HeadAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)Machine Right PN:1741";

            m_parts.Add(part);

            // SillAlum ||

            part = new Part(4347, "SillAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)Machine Right PN:1741";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Screen

            ////////////////////////////////////////////////////////////////////////////////

            // ScreenAlumR -->>

            part = new Part(5304, "ScreenAlumR", this, 1, m_subAssemblyHieght - screenReduce2X);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);

            // ScreenAlumL <<-- 

            part = new Part(5304, "ScreenAlumL", this, 1, m_subAssemblyHieght - screenReduce2X);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);

            // ScreenAlum ^^

            part = new Part(5304, "ScreenAlumHd", this, 1, m_subAssemblyWidth - screenReduce2X);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);

            // ScreenAlum ||

            part = new Part(5304, "ScreenAlumSl", this, 1, m_subAssemblyWidth - screenReduce2X);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Hardware-Parts

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            for (int i = 0; i < 8; i++)
            {
                part = new Part(3206, "AglBrktAlum", this, 1, AlumCrnBrk);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "WndFrame";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // OperatorEncoreRH
            part = new Part(5095, "OperatorEncoreRH", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // RH_Encore®CoverHandle
            part = new Part(4938, "RH_Encore®CoverHandle", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // OperatorBacker
            part = new Part(5253, "OperatorBacker", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int hardwarecount = 1;
            if (m_subAssemblyHieght < 51.9999m)
            {
                hardwarecount = 1;
            }
            else
            {
                hardwarecount = 2;

            }


            // TruthMaxim24Lock
            part = new Part(4911, "TruthMaxim24Lock", this, hardwarecount, 0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // Keeper
            part = new Part(3516, "Keeper", this, hardwarecount, 0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Get the size of the tiebar partNo--
            decimal tieBarLength = FrameWorks.Functions.S2000TieBar(m_subAssemblyHieght);

            //check is sash even requires a tiebar
            if (tieBarLength != 0)
            {
                // Tie Bars
                part = new Part(3625, "Tie Bars", this, 1, tieBarLength);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            decimal periFrame = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                periFrame = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);

                //FrameSeal
                part = new Part(2274, "FrameSeal", this, 1, periFrame);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region Sash

            // StileAlumL <<--

            part = new Part(5129, "StileAlumL", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";

            m_parts.Add(part);

            // StileAlumR -->>

            part = new Part(5129, "StileAlumR", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL = "MiterEnds";

            m_parts.Add(part);

            // RailAlumT ^^
            part = new Part(5129, "RailAlumT", this, 1, m_subAssemblyWidth - frameReduce2X);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine1741Right";

            m_parts.Add(part);

            // RailAlumB ||
            part = new Part(5129, "RailAlumB", this, 1, m_subAssemblyWidth - frameReduce2X);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine1741Right";

            m_parts.Add(part);

            #endregion

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // MuntHorz
            for (int i = 0; i < 4; i++)
            {

                part = new Part(5306, "MuntHorz", this, 1, (m_subAssemblyWidth - MuntGapX2) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "?_Ends";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            // MuntVert
            for (int i = 0; i < 4; i++)
            {

                part = new Part(5306, "MuntVert", this, 1, (m_subAssemblyHieght - MuntGapX2) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "?_Ends";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5123, "AlumGlsStpVert", this, 1, m_subAssemblyHieght - gstopReduce2X);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpTopBot
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5123, "AlumGlsStpTopBot", this, 1, m_subAssemblyWidth - gstopReduce2X);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AsemblHrdwr

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
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

            // AglBrktAlum
            for (int i = 0; i < 4; i++)
            {
                part = new Part(3206, "AglBrktAlum", this, 1, AlumCrnBrk);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "SashWnd";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            //Cross_Bracket

            for (int i = 0; i < 2; i++)
            {
                part = new Part(5267, "Cross_Bracket", this, 1, AlumCrnBrk);
                part.PartGroupType = "AssyBrackets";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Cross_3.025";

                m_parts.Add(part);

            }

            //SetScrew_10_32

            for (int i = 0; i < 16; i++)
            {
                part = new Part(3518, "SetScrew_10_32", this, 1, PointSetScrew);
                part.PartGroupType = "AssyBrackets";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "1/4_20x.25";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////

            #endregion

            #region Hardware

            // HingeCaseUR
            part = new Part(1741, "HingeCaseUR", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";

            m_parts.Add(part);

            // HingeCaseLR
            part = new Part(1741, "HingeCaseLR", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";

            m_parts.Add(part);

            // HingeShoeLR
            part = new Part(5279, "HingeShoeLR", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";

            m_parts.Add(part);

            // HingeFiller
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5280, "HingeFiller", this, 1, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            /////////////////////////////////////////////////////////////////////////////////////////////
            // GlassPanel
            for (int i = 0; i < 1; i++)
            {

                // GlassPanel
                part = new Part(3472);

                part.FunctionalName = "GlassPanel";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - glassReduce2X);
                part.PartLength = (m_subAssemblyHieght - glassReduce2X);
                part.PartThick = 1.25m;
                part.PartLabel = "SDL_2x2";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - edgeSealAdd, m_subAssemblyWidth - edgeSealAdd);

                //SashEdgeSeal
                part = new Part(2274, "SashEdgeSeal", this, 1, periSash);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);

                //EPDM_PreSet
                part = new Part(4314, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);

                //EPDM_Wedge
                part = new Part(4284, "EPDM_Wedge", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge
            for (int i = 0; i < 8; i++)
            {

                part = new Part(911, "EPDM_Wedge", this, 1, (m_subAssemblyWidth - MuntGapX2) / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge
            for (int i = 0; i < 8; i++)
            {

                part = new Part(911, "EPDM_Wedge", this, 1, (m_subAssemblyHieght - MuntGapX2) / 2.0m);
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