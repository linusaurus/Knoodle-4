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

    public class FixedFloor_1x5 : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal sillReduce = 0.625m;
        const decimal bronzeCrnBrk = 0.625m;
        const decimal stopReduce = 0.625m;
        const decimal stopReduceX2 = .625m * 2.0m;
        const decimal stopReduceBOT = 1.25m;
        const decimal muntinNibX4 = 1.50m * 4.0m;
        const decimal muntinReduceX2 = 1.3125m * 2.0m;
        const decimal glassReduce = 0.96875m;
        const decimal glassReduceX2 = .96875m * 2.0m;
        const decimal glassReduceBOT = 1.59375m;
        const decimal gasketReduce = 0.8125m;


        #endregion

        #region Constructor

        public FixedFloor_1x5()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3340-FixedFloor_1x5";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region FrameBrz

            //////////////////////////////////////////////////////////////////////////////

            // Fixed_4414_Vt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4414, "Fixed_4414_Vt", this, 1, m_subAssemblyHieght - sillReduce);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Fixed_4414_Head
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4414, "Fixed_4414_Head", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Fixed_4431_Sill
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4431, "Fixed_4431_Sill", this, 1, m_subAssemblyWidth + stopReduceX2);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopBrz

            //////////////////////////////////////////////////////////////////////////////

            //GlsStp_4413_Vt
            for (int i = 0; i < 10; i++)
            {
                part = new Part(4413, "GlsStp_4413_Vt", this, 1, (m_subAssemblyHieght - (stopReduce + stopReduceBOT + muntinNibX4)) / 5.0m);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //GlsStp_4413_Hz  
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4413, "GlsStp_4413_Hz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //GlsStp_4413_Bot 
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4413, "GlsStp_4413_Bot", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Muntin

            //////////////////////////////////////////////////////////////////////////////

            //Muntin_4423_Int  
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4423, "Muntin_4423_Int", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "Muntin-Parts";
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
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //Glass Panel

            part = new Part(4212);

            part.FunctionalName = "Glass_0.53125Lami";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduceX2);
            part.PartLength = m_subAssemblyHieght - (glassReduce + glassReduceBOT);
            part.PartThick = 0.53125m;

            m_parts.Add(part);

            #endregion

            #region GlazingSeal

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - sillReduce - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //GlazPreSetEPDM
                part = new Part(4436, "GlazPreSetEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            for (int i = 0; i < 1; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - sillReduce - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //GlazWedgEPDM
                part = new Part(3904, "GlazWedgEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


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

            #region Hardware


            for (int i = 0; i < 8; i++)
            {
                part = new Part(4265, "CornerBrackets", this, 1, bronzeCrnBrk);
                part.PartGroupType = "Hardware-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion



        }



        #endregion


    }
}