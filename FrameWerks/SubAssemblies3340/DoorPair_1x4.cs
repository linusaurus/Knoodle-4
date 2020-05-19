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

namespace FrameWorks.Makes.System3340
{

    public class DoorPair_1x4 : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal windGrdRed = 0.50m;
        const decimal bronzeCrnBrk = 0.625m;
        const decimal ss304CrnBrk = 0.75m;
        const decimal threshRedct = 0.6250m;
        const decimal stopRedMidX2 = 0.65625m * 2.0m;
        const decimal stopReduce = 1.40625m;
        const decimal stopReduceX2 = 1.40625m * 2.0m;
        const decimal glassReduceX2 = 1.75m * 2.0m;
        const decimal glassReduce = 1.75m;
        const decimal glassLevRed = 4.0625m;
        const decimal gasketReduce = 1.6582m;
        const decimal K_FOLD_Q_Lon = 1.1533m;
        const decimal sashReduceX2 = 0.875m * 2.0m;
        const decimal doorGapMid = 0.25m;
        const decimal muntinReduce = 2.09375m;
        const decimal muntRedMidx2 = 1.34375m * 2.0m;
        const decimal muntinNibX3 = 1.50m * 3.0m;




        #endregion

        #region Constructor

        public DoorPair_1x4()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3340-DoorPair_1x4";
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



            #region FrameBrz

            //////////////////////////////////////////////////////////////////////////////

            // Frame_4415_Vert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4415, "Frame_4415_Vert", this, 1, m_subAssemblyHieght - threshRedct);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "90°BotCut_LH_Swing";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Frame_4415_Head
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4415, "Frame_4415_Head", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "LH_Swing";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // Frame_4415_Threshold
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4415, "Frame_4415_Threshold", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "REMOVE_STOP_90°_Cut";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardwareFrame

            // StrikePassiveRamp
            part = new Part(4434, "StrikePassiveRamp", this, 1, 0.0m);
            part.PartGroupType = "HardwareFrame-Parts";
            part.PartLabel = "Pair";

            m_parts.Add(part);

            // ShootStrikePair 
            part = new Part(1986, "ShootStrikePair", this, 2, 0.0m);
            part.PartGroupType = "HardwareFrame-Parts";
            part.PartLabel = "LH";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //CornerBrackets
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4265, "CornerBrackets", this, 1, bronzeCrnBrk);
                part.PartGroupType = "HardwareFrame-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "HEAD_ONLY";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region FrameSeal

            for (int i = 0; i < 1; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - K_FOLD_Q_Lon, m_subAssemblyWidth - K_FOLD_Q_Lon);

                //FrameSeal
                part = new Part(2274, "K_FOLD_Q_Lon", this, 1, peri - (m_subAssemblyWidth + 2.0m * threshRedct));
                part.PartGroupType = "FrameSeal-Parts";
                part.PartLabel = "FrameSeal";

                m_parts.Add(part);

            }

            #endregion

            #region Door

            ////////////////////////////////////////////////////////////////////////////////

            // Door_4416_Horz
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4416, "Door_4416_Horz", this, 1, (m_subAssemblyWidth - sashReduceX2 - doorGapMid) / 2.0m);
                part.PartGroupType = "Door-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "LH";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Door_4416_Vert
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4416, "Door_4416_Vert", this, 1, m_subAssemblyHieght - sashReduceX2);
                part.PartGroupType = "Door-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "LH";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Door_4416_LeverVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4416, "Door_4416_LeverVert", this, 1, 23.6094m);
                part.PartGroupType = "Door-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "LH";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // LeverCoverInterior
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4444, "LeverCoverInterior", this, 1, 22.2344m);
                part.PartGroupType = "Door-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "LH";

                m_parts.Add(part);

            }

            // LeverCoverExterior
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4445, "LeverCoverExterior", this, 1, 22.2344m);
                part.PartGroupType = "Door-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "LH";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region MuntinBars

            //////////////////////////////////////////////////////////////////////////////

            //Muntin_Int  
            for (int i = 0; i < 6; i++)
            {
                part = new Part(4423, "Muntin_4423_Int", this, 1, (m_subAssemblyWidth - stopReduce - stopRedMidX2) / 2.0m);
                part.PartGroupType = "MuntinBars-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //Muntin_Ext 
            for (int i = 0; i < 6; i++)
            {
                part = new Part(4418, "Muntin_4418_Ext", this, 1, (m_subAssemblyWidth - muntinReduce - muntRedMidx2) / 2.0m);
                part.PartGroupType = "MuntinBars-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //SS_GLASS_DIVIDER
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4446, "SS_GLASS_DIVIDER", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "MuntinBars-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopBrz1x4

            //////////////////////////////////////////////////////////////////////////////

            //GlsStpVt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4413, "GlsStp_4413_Vt", this, 1, (m_subAssemblyHieght - (stopReduceX2 + muntinNibX3)) / 4.0m - 0.7031m);
                part.PartGroupType = "StopBrz1x4-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "TopLite";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //GlsStpVt
            for (int i = 0; i < 12; i++)
            {
                part = new Part(4413, "GlsStp_4413_Vt", this, 1, (m_subAssemblyHieght - (stopReduceX2 + muntinNibX3)) / 4.0m + 0.2344m);
                part.PartGroupType = "StopBrz1x4-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "3LowLite";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //GlsStpHz  
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4413, "GlsStp_4413_Hz", this, 1, (m_subAssemblyWidth - stopRedMidX2) / 2.0m);
                part.PartGroupType = "StopBrz1x4-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            //Glass Panel
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4212);

                part.FunctionalName = "Glass_0.53125Lami";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - doorGapMid - glassReduceX2) / 2.0m;
                part.PartLength = 45.71875m;
                part.PartThick = 0.53125m;
                part.PartLabel = "DoorUpper";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //Glass Panel
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4212);

                part.FunctionalName = "Glass_0.53125Lami";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - doorGapMid - glassLevRed - glassReduce) / 2.0m;
                part.PartLength = 22.921875m;
                part.PartThick = 0.53125m;
                part.PartLabel = "DoorMiddle";

                m_parts.Add(part);

            }


            //////////////////////////////////////////////////////////////////////////////

            //Glass Panel
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4212);

                part.FunctionalName = "Glass_0.53125Lami";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - doorGapMid - glassReduceX2) / 2.0m;
                part.PartLength = 22.921875m;
                part.PartThick = 0.53125m;
                part.PartLabel = "DoorLower";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region GlazingSeal

            //////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 2; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                part = new Part(4436, "GlazPreSetEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 2; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                part = new Part(3904, "GlazWedgEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // GlazWedgEPDM
            for (int i = 0; i < 24; i++)
            {
                part = new Part(3904, "GlazWedgEPDM", this, 1, m_subAssemblyWidth / 2.0m - stopReduceX2);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // WindGuard
            for (int i = 0; i < 1; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - windGrdRed, m_subAssemblyWidth - windGrdRed);

                //FrameSeal
                part = new Part(2274, "K_FOLD_Q_Lon", this, 1, peri - (m_subAssemblyWidth + sashReduceX2));
                part.PartGroupType = "FrameSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare Logic

            //////////////////////////////////////////////////////////////////////////////

            // SashBrackets
            for (int i = 0; i < 8; i++)
            {
                part = new Part(4441, "CornerBrackets", this, 1, ss304CrnBrk);
                part.PartGroupType = "Hardware-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "SS_Angle";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Hinges
            part = new Part(3685, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = ".25_RAD_Corner";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //AmesburyMultipointActive

            FrameWorks.Makes.Hardware.Amesbury.Premiere2000.MultipointActive GearAssy =
                new FrameWorks.Makes.Hardware.Amesbury.Premiere2000.MultipointActive(m_subAssemblyHieght, this);
            foreach (Part innerpart in GearAssy.Parts)
            {
                //inner
                this.Parts.Add(innerpart);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region HardwarePassive


            // Hinges
            part = new Part(3685, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "HardwarePassive-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //AmesburyMultipointPassive

            //FrameWorks.Makes.Hardware.Amesbury.Premiere2000.MultipointPassive GearAssy =
                new FrameWorks.Makes.Hardware.Amesbury.Premiere2000.MultipointPassive(m_subAssemblyHieght, this);
            foreach (Part innerpart in GearAssy.Parts)
            {
                //inner
                this.Parts.Add(innerpart);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion


        }


        private int HingeCount(decimal HingeAxisLength)
        {
            int result = 0;

            if (HingeAxisLength < 84.0m)
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 108.0m))
            {
                result = 5;
            }
            else if ((HingeAxisLength >= 108.0m) && (HingeAxisLength < 134.0m))
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