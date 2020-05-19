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

    public class PivotDoorRH_1x5 : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal windGrdRed = 0.50m;
        const decimal bronzeCrnBrk = 0.625m;
        const decimal calkGap = 0.125m;
        const decimal ss304CrnBrk = 0.75m;
        const decimal stopReduceX2 = 1.40625m * 2.0m;
        const decimal glassReduceX2 = 1.75m * 2.0m;
        const decimal gasketReduce = 1.6582m;
        const decimal K_FOLD_Q_Lon = 1.1533m;
        const decimal sashReduceX2 = 0.875m * 2.0m;
        const decimal muntinReduceX2 = 2.09375m * 2.0m;
        const decimal muntinNibX4 = 1.50m * 4.0m;


        #endregion

        #region Constructor

        public PivotDoorRH_1x5()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3340-PivotDoorRH_1x5";
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

            ////////////////////////////////////////////////////////////////////////////////

            // Frame_4415_JambVt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4415, "Frame_4415_JambVt", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "RH_Swing";

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
                part.PartLabel = "RH_Swing";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region FrameSeal

            for (int i = 0; i < 1; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - K_FOLD_Q_Lon, m_subAssemblyWidth - K_FOLD_Q_Lon);

                //FrameSeal
                part = new Part(2274, "K_FOLD_Q_Lon", this, 1, peri - (2.0m * m_subAssemblyWidth ));
                part.PartGroupType = "FrameSeal-Parts";
                part.PartLabel = "FrameSeal";

                m_parts.Add(part);

            }

            #endregion

            #region HardwareFrame

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

            #region Door

            ////////////////////////////////////////////////////////////////////////////////

            // Door_4416_Horz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4416, "Door_4416_Horz", this, 1, m_subAssemblyWidth - sashReduceX2);
                part.PartGroupType = "Door-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "RH";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Door_4416_Vert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4416, "Door_4416_Vert", this, 1, m_subAssemblyHieght - sashReduceX2);
                part.PartGroupType = "Door-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "RH";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region MuntinBars

            //////////////////////////////////////////////////////////////////////////////

            //Muntin_4423_Int  
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4423, "Muntin_4423_Int", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "MuntinBars-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //Muntin_4418_Ext 
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4418, "Muntin_4418_Ext", this, 1, m_subAssemblyWidth - muntinReduceX2);
                part.PartGroupType = "MuntinBars-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopBrz1x5

            //////////////////////////////////////////////////////////////////////////////

            //GlsStp_4413_Vt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4413, "GlsStp_4413_Vt", this, 1, (m_subAssemblyHieght - (stopReduceX2 + muntinNibX4)) / 5.0m - 0.75m);
                part.PartGroupType = "StopBrz1x5-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "TopLite";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //GlsStp_4413_Vt
            for (int i = 0; i < 8; i++)
            {
                part = new Part(4413, "GlsStp_4413_Vt", this, 1, (m_subAssemblyHieght - (stopReduceX2 + muntinNibX4)) / 5.0m + 0.1875m);
                part.PartGroupType = "StopBrz1x5-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "4LowLite";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //GlsStp_4413_Hz  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4413, "GlsStp_4413_Hz", this, 1, m_subAssemblyWidth - stopReduceX2);
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
            part = new Part(4212);

            part.FunctionalName = "Glass_0.53125Lami";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduceX2);
            part.PartLength = m_subAssemblyHieght - (glassReduceX2);
            part.PartThick = 0.53125m;
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region GlazingSeal

            //////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                part = new Part(4436, "GlazPreSetEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
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
            for (int i = 0; i < 16; i++)
            {
                part = new Part(3904, "GlazWedgEPDM", this, 1, m_subAssemblyWidth - stopReduceX2);
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
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4441, "CornerBrackets", this, 1, ss304CrnBrk);
                part.PartGroupType = "Hardware-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "SS_Angle";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // BTS_80
            part = new Part(300, "BTS_80", this, 1, 0.0m);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "RH";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Bottom_Arm
            part = new Part(25, "Bottom_Arm", this, 1, 0.0m);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "RH";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // Spindle_No.80020_1-1/8"_3°_Pre_load
            part = new Part(2130, "Spindle_80020_3°_Pre_load", this, 1, 0.0m);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "RH_1.125_Spindle_80020_3°_Pre_load";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // WalkingBeamPivot
            part = new Part(28, "WalkingBeamPivot", this, 1, 0.0m);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "RH";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // ElectricBolt
            part = new Part(4406, "ElectricBolt", this, 1, 0.0m);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "RH";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }




        #endregion

    }
}