#region Copyright (c) 2016 WeaselWare Software
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
using FrameWorks.Makes.System2010AH;


namespace FrameWorks.Makes.System2010AH
{

    public class DrSwgPr1X4ActRH : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal doorReduceX2 = 0.875m * 2.0m;
        const decimal doorReduce = 0.875m;
        const decimal doorGapBot = 0.75m;
        const decimal doorGapMid = 0.375m;
        const decimal sidMuntGPExt2 = 3.7835m * 2.0m;
        const decimal sidMuntGPInt2 = 3.9582m * 2.0m;
        const decimal centMuntGPExt = 6.1920m;
        const decimal centMuntGPInt = 6.5414m;
        const decimal glsDrGap = 3.46875m;
        const decimal glsDrGapMID = 5.5625m;
        const decimal glsDrGapBot = 3.34375m;
        const decimal glsDrGapX2 = 3.46875m * 2.0m;
        const decimal epdmReduce = 2.73129921m;
        const decimal epdmADD = 2.375m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.21875m;
        const decimal hdpExtX2 = 0.21875m * 2.0m;
        const decimal stopRedBot = 3.000m;
        const decimal stopReduce = 3.125m;
        const decimal stopRed2x = 3.125m * 2.0m;
        const decimal stopRedMid = 4.875m;
        const decimal calkJoint = 0.125m;
        const decimal headReduct = 0.875m;
        const decimal botumRedut = .75m;
        const decimal kFoldRedut = .8125m;


        //



        #endregion

        #region Constructor

        public DrSwgPr1X4ActRH()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-DrSwgPr1X4ActRH";
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

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region Frame-Parts


            // JambsAlum -->> 

            for (int i = 0; i < 2; i++)
            {
                decimal doorPanel = decimal.Zero;

                doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;

                part = new Part(4352, "JambsAlum<>", this, 1, m_subAssemblyHieght - calkJoint);
                part.PartGroupType = "Frame-Parts";
                decimal step = (doorPanel - 15.0m);
                step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(doorPanel) - 1));
                step = Math.Round(step, 4);
                //string msg = "";
                part.PartLabel = "1) MiterTop\r\n" +
                                 "2) [911.m]Cope Jamb Bottom->\r\n" +
                                 "3) Position 0rigin TOU @ ->" + (7.5m + 0.875m).ToString() + "\r\n" +
                                 "4) Hinge Backer Prep->[1982.m] "
                       + FrameWorks.Functions.HingeCount(doorPanel).ToString() + "@<" + step.ToString() + ">O.C.";

                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // HeadAlum ^^
            part = new Part(4352, "HeadAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds\r\n" +
                             "2)[1987.m]Position 0rigin Shoot Strike";

            m_parts.Add(part);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrFrame


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            for (int i = 0; i < 4; i++)
            {
                part = new Part(3206, "AglBrktAlum", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrFrame";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // PointSetScrew
            for (int i = 0; i < 16; i++)
            {
                part = new Part(1545, "PointSetScrew", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrFrame";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region HardWare


            // PVC ASTRAGAL
            part = new Part(1901, "PVC ASTRAGAL", this, 1, m_subAssemblyHieght - headReduct - botumRedut);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // ASTRAGAL_COVER
            part = new Part(4589, "ASTRAGAL_COVER", this, 1, m_subAssemblyHieght - headReduct - botumRedut);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // PairShootStrike 
            part = new Part(5309, "PairShootStrike", this, 2, 0.0m);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - kFoldRedut - calkJoint, m_subAssemblyWidth - 2 * kFoldRedut);

                //FrameSealKfolD
                part = new Part(2274, "FrameSealKfolD", this, 1, peri - m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region AlumTB3inch

            ////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4355, "StileLeft", this, 1, m_subAssemblyHieght - doorReduce - doorGapBot);
                part.PartGroupType = "AlumTB3inch";
                part.PartLabel = "1) Miter_Ends";
                m_parts.Add(part);

            }

            // StileRight
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4355, "StileRight", this, 1, m_subAssemblyHieght - doorReduce - doorGapBot);
                part.PartGroupType = "AlumTB3inch";
                part.PartLabel = "1) Miter_Ends";

                m_parts.Add(part);

            }

            // RailTop
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4355, "RailTop", this, 1, (m_subAssemblyWidth - doorReduceX2 - doorGapMid) / 2.0m);
                part.PartGroupType = "AlumTB3inch";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }

            // RailBot
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4355, "RailBot", this, 1, (m_subAssemblyWidth - doorReduceX2 - doorGapMid) / 2.0m);
                part.PartGroupType = "AlumTB3inch";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE

            // HDPELockEdge
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4269, "HDPELockEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);

            }

            // HDPEHingEdge
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4268, "HDPEHingEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);

            }

            // HDPETop
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4269, "HDPETop", this, 1, (m_subAssemblyWidth - doorReduceX2 - doorGapMid + hdpExtX2) / 2.0m);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "";

                m_parts.Add(part);

            }

            // HDPEBot
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4270, "HDPEBot", this, 1, (m_subAssemblyWidth - doorReduceX2 - doorGapMid + hdpExtX2) / 2.0m);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "";

                m_parts.Add(part);

            }

            #endregion

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // ExtMuntHorz
            for (int i = 0; i < 6; i++)
            {

                part = new Part(4588, "ExtMuntHorz", this, 1, (m_subAssemblyWidth - sidMuntGPExt2 - centMuntGPExt) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "WELD_Ends";

                m_parts.Add(part);

            }

            // IntMuntHorz
            for (int i = 0; i < 6; i++)
            {

                part = new Part(4587, "IntMuntHorz", this, 1, (m_subAssemblyWidth - sidMuntGPInt2 - centMuntGPInt) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "BEVEL_Ends";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            // AlumGlsStpVert
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4341, "AlumGlsStpVert", this, 1, m_subAssemblyHieght - stopReduce - stopRedBot);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpTopBot
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4341, "AlumGlsStpTopBot", this, 1, (m_subAssemblyWidth - stopRed2x - stopRedMid) / 2.0m);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            // GlassPanel
            for (int i = 0; i < 2; i++)
            {

                //GlassPanel
                part = new Part(3472);
                part.FunctionalName = "GlassPanel";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - glsDrGapX2 - glsDrGapMID) / 2.0m;
                part.PartLength = (m_subAssemblyHieght - glsDrGap - glsDrGapBot);
                part.PartThick = 1.25m;
                part.PartLabel = "SDL_1x4";

                m_parts.Add(part);

            }

            #endregion

            #region AssyHrdwrDoor


            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            for (int i = 0; i < 8; i++)
            {
                part = new Part(4784, "SS_0.4625_InsetCrnBrace", this, 1, 0.0m);
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

            // AlumCnrBrace
            for (int i = 0; i < 8; i++)
            {
                part = new Part(4830, "AlumCnrBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            for (int i = 0; i < 32; i++)
            {
                part = new Part(4833, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrace
            for (int i = 0; i < 8; i++)
            {
                part = new Part(4831, "AlumCnrBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            for (int i = 0; i < 32; i++)
            {
                part = new Part(4833, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            // SS_0.7049_OutsetCrnBrace 
            for (int i = 0; i < 16; i++)
            {
                part = new Part(4829, "SS_0.7049_OutsetCrnBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrDoor";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // FlatHead_8-32x3/16_UndercutHead
            for (int i = 0; i < 64; i++)
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

            #region HardWare Logic

            // Hinges

            for (int i = 0; i < 2; i++)
            {
                part = new Part(3685, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = ".25_RAD_Corner";

                m_parts.Add(part);

            }

            // BackerHinge

            for (int i = 0; i < 2; i++)
            {
                part = new Part(4101, "BackerHinge", this, HingeCount(m_subAssemblyHieght), 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //AmesburyMultipointActive

            FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointActive GearAssy =
                new FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointActive(m_subAssemblyHieght - doorReduce - doorGapBot, this);
            foreach (Part innerpart in GearAssy.Parts)
            {
                //inner
                this.Parts.Add(innerpart);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            //AmesburyMultipointPassive

            FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointPassive GearBox =
            new FrameWorks.Makes.Hardware.Amesbury40.Premiere2000.MultipointPassive(m_subAssemblyHieght - doorReduce - doorGapBot, this);
            foreach (Part innerpart in GearBox.Parts)
            {
                //inner
                this.Parts.Add(innerpart);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            // StrikePlateRH_LHR
            part = new Part(5338, "StrikePlateRH_LHR", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

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

            for (int i = 0; i < 2; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, (periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd) / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 2; i++)
            {
                //DoorBotPVC

                part = new Part(1518, "DoorBotPVC", this, 1, (m_subAssemblyWidth - doorReduceX2 - doorGapMid + hdpExtX2) / 2.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 2; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDM_PreSet
                part = new Part(4314, "EPDM_PreSet", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 2; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDM_Wedge
                part = new Part(4284, "EPDM_Wedge", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
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
                result = 3;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 108.0m))
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 108.0m) && (HingeAxisLength < 134.0m))
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