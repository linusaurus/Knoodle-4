﻿#region Copyright (c) 2015 WeaselWare Software
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

    public class Door_Cooper_1x5 : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal windGrdRed = 0.50m;
        const decimal bronzeCrnBrk = 0.625m;
        const decimal calkGap = 0.125m;
        const decimal ss304CrnBrk = 0.75m;
        const decimal stopReduceX2 = 0.5625m * 2.0m;
        const decimal glassReduceX2 = 0.875m * 2.0m;
        const decimal gasketReduce = 1.50m;
        const decimal sashReduceX2 = 0.875m * 2.0m;
        const decimal muntinReduceX2 = 1.21875m * 2.0m;
        const decimal muntinNibX4 = 0.125m * 4.0m;


        #endregion

        #region Constructor

        public Door_Cooper_1x5()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3340-Door_Cooper_1x5";
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

            //Muntin_Int  
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4423, "Muntin_Int", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "MuntinBars-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //Muntin_Ext 
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4418, "Muntin_Ext", this, 1, m_subAssemblyWidth - muntinReduceX2);
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

            //GlsStpVt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4413, "GlsStpVt", this, 1, (m_subAssemblyHieght - (stopReduceX2 + muntinNibX4)) / 5.0m );
                part.PartGroupType = "StopBrz1x5-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "TopLite";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //GlsStpVt
            for (int i = 0; i < 8; i++)
            {
                part = new Part(4413, "GlsStpVt", this, 1, (m_subAssemblyHieght - (stopReduceX2 + muntinNibX4)) / 5.0m );
                part.PartGroupType = "StopBrz1x5-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "4LowLite";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //BrzGlsStpHz  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4413, "BrzGlsStpHz", this, 1, m_subAssemblyWidth - stopReduceX2);
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


            #endregion

        }




        #endregion

    }
}