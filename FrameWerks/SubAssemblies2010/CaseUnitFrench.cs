
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

namespace FrameWorks.Makes.System2010
{

    public class CaseUnitFrench : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal frameReduce2X = 0.9375m * 2.0m;
        const decimal screenReduce2X = 1.51202m * 2.0m;
        const decimal astragalGap = 0.25m;
        const decimal astagalGapHalf = 0.25m / 2.0m;
        const decimal gaskFrmReduce = 1.250m;
        const decimal gstopReduce2X = 1.88285m * 2.0m;
        const decimal glassReduce2X = 2.21875m * 2.0m;
        const decimal glassRedMid2X = 2.8125m;
        const decimal gaskSashReduce = 2.1875m;
        const decimal edgeSealAdd = 0.375m;

        //static int createID;

        #endregion

        #region Constructor

        public CaseUnitFrench()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-CaseUnitFrench";
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
                             "2)Machine Right PN:1741" + "\r\n" +
                             "3)Machine Left PN:1741";

            m_parts.Add(part);

            // SillAlum ||

            part = new Part(4347, "SillAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)Machine Right PN:1741" + "\r\n" +
                             "3)Machine Left PN:1741";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Screen

            // ScrnFrmVert ^^
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4430, "ScrnFrmVert", this, 1, m_subAssemblyHieght - screenReduce2X);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "1)MiterEnds";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ScrnFrmHorz ^^
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4430, "ScrnFrmHorz", this, 1, m_subAssemblyWidth - screenReduce2X);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "1)MiterEnds";

                m_parts.Add(part);

            }

            #endregion

            #region AssyHrdwrFrame


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            for (int i = 0; i < 8; i++)
            {
                part = new Part(3206, "AglBrktAlum", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrFrame";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // PointSetScrew
            for (int i = 0; i < 32; i++)
            {
                part = new Part(1545, "PointSetScrew", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrFrame";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion
          
            #region Hardware-Parts

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // OperatorEncoreLH
            part = new Part(5094, "OperatorEncoreLH", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // LH_Encore®CoverHandle
            part = new Part(4912, "LH_Encore®CoverHandle", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // OperatorBacker
            part = new Part(5253, "OperatorBacker", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

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

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // StileAlumL <<--
            
            part = new Part(4350, "StileAlumL", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";

            m_parts.Add(part);

            // StileAlumR -->>
            part = new Part(4350, "StileAlumR", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL = "MiterEnds";

            m_parts.Add(part);

            // RailAlumT ^^
            part = new Part(4350, "RailAlumT", this, 1,( m_subAssemblyWidth - frameReduce2X - astragalGap) /2.0m);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine1741Right";

            m_parts.Add(part);

            // RailAlumB ||
            part = new Part(4350, "RailAlumB", this, 1, (m_subAssemblyWidth - frameReduce2X - astragalGap) /2.0m);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine1741Right";

            m_parts.Add(part);


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Astragal
            part = new Part(4356, "Astragal", this, 1, m_subAssemblyHieght - gaskFrmReduce * 2.0m );
            part.PartGroupType = "Sash";
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // StileAlumL <<--

            part = new Part(4350, "StileAlumL", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";

            m_parts.Add(part);

            // StileAlumR -->>
            part = new Part(4350, "StileAlumR", this, 1, m_subAssemblyHieght - frameReduce2X);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL = "MiterEnds";

            m_parts.Add(part);

            // RailAlumT ^^
            part = new Part(4350, "RailAlumT", this, 1, (m_subAssemblyWidth - frameReduce2X - astragalGap) / 2.0m);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine1741Left";

            m_parts.Add(part);

            // RailAlumB ||
            part = new Part(4350, "RailAlumB", this, 1, (m_subAssemblyWidth - frameReduce2X - astragalGap) / 2.0m);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine1741Left";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpVt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4341, "AlumGlsStpVt", this, 1, m_subAssemblyHieght - gstopReduce2X);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpHz
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4341, "AlumGlsStpHz", this, 1, (m_subAssemblyWidth - gstopReduce2X - astagalGapHalf) / 2.0m);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrSash


            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            for (int i = 0; i < 8; i++)
            {
                part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrSash";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // FlatHead_8-32x3/16_UndercutHead
            for (int i = 0; i < 32; i++)
            {
                part = new Part(502, "FlatHead_8-32x3/16_UndercutHead", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrSash";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrkt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(3206, "AlumCnrBrkt", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrSash";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // PointSet1/4x20Screw
            for (int i = 0; i < 16; i++)
            {
                part = new Part(1545, "PointSet1/4x20Screw", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrFrame";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Hardware

            // HingeCaseUL
            part = new Part(1741, "HingeCaseUL", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";

            m_parts.Add(part);

            // HingeCaseLL
            part = new Part(1741, "HingeCaseLL", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";

            m_parts.Add(part);

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

            // HingeShoe
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5279, "HingeShoe", this, 1, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            // HingeFiller
            for (int i = 0; i < 4; i++)
            {
                part = new Part(5280, "HingeFiller", this, 1, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            /////////////////////////////////////////////////////////////////////////////////////////////
            // Glass Panel
            for (int i = 0; i < 2; i++)
            {

                // Glass Panel
                part = new Part(3300);

                part.FunctionalName = "Glass";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = ((m_subAssemblyWidth - glassReduce2X - glassRedMid2X) / 2.0m);
                part.PartLength = (m_subAssemblyHieght - glassReduce2X);
                part.PartThick = 1.25m;

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            for (int i = 0; i < 2; i++)
            {
                //SashEdgeSeal
                part = new Part(2274, "SashEdgeSeal", this, 1, m_subAssemblyHieght - gstopReduce2X );
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 2; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - edgeSealAdd, (m_subAssemblyWidth / 2.0m) - edgeSealAdd);

                //SashEdgeSeal
                part = new Part(2274, "SashEdgeSeal", this, 1, periSash);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 2; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, (m_subAssemblyWidth / 2.0m) - gaskSashReduce);

                //GlazPreSetEPDM
                part = new Part(4314, "GlazPreSetEPDM", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 2; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, (m_subAssemblyWidth / 2.0m) - gaskSashReduce);

                //GlazWedgEPDM
                part = new Part(4399, "GlazWedgEPDM", this, 1, peri);
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