#region Copyright (c) 2013 WeaselWare Software
/************************************************************************************
'
' Copyright  2013 WeaselWare Software 
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
' Portions Copyright 2013 WeaselWare Software
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

namespace FrameWorks.Makes.System3530
{

    public class FixedIGHVM6Lite : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal stopReduceX2 = 1.25m;
        const decimal muntFrmRedX2 = 1.65533022m;
        const decimal delReduceX2 = 1.57599848m;
        const decimal delRenThick = .09375m;
        const decimal muntinJunc = .15533009m;
        const decimal glassReduce = .9375m;
        const decimal glassMuntRedX2 = .375m;
        const decimal gasketReduce = .922m;

        //static int createID;

        #endregion

        #region Constructor

        public FixedIGHVM6Lite()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3530-FixedIGHVM6Lite";
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

            // BrzFixedIGVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3947, "BrzFixedIGVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            // BrzFixedIGHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3947, "BrzFixedIGHorz", this, 1, m_subAssemblyWidth);
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

            // BrzGlsStpVt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3892, "BrzGlsStpVt", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpT
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3892, "BrzGlsStpT", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            // BrzGlsStpB
            for (int i = 0; i < 1; i++)
            {


                string crap;
                crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - stopReduceX2);
                part = new Part(3892, "BrzGlsStpB", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "GlassStop-Parts";
                part.PartLabel = "1)MiterEnds" + "\r\n" +
                                 "2)" + crap;

                m_parts.Add(part);


            }



            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Muntin

            //////////////////////////////////////////////////////////////////////////////

            // BrzMuntinVert
            for (int i = 0; i < 6; i++)
            {
                part = new Part(3893, "BrzMuntinVert", this, 1, (m_subAssemblyHieght - muntFrmRedX2 - 2 * muntinJunc) / 3.0m);
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // DelrinDivVert
            for (int i = 0; i < 3; i++)
            {
                part = new Part(911, "DelrinDivVert", this, 1, (m_subAssemblyHieght - delReduceX2 - 2 * delRenThick) / 3.0m);
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // BrzMuntinHorz
            for (int i = 0; i < 4; i++)
            {
                part = new Part(3893, "BrzMuntinHorz", this, 1, m_subAssemblyWidth - muntFrmRedX2);
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // DelrinDivHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(911, "DelrinDivHorz", this, 1, m_subAssemblyWidth - delReduceX2);
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            /////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass


            /////////////////////////////////////////////////////////////////////////////////////
            // 4 Glass Panels
            for (int i = 0; i < 6; i++)
            {

                // 4 Glass Panels
                part = new Part(4420);

                part.FunctionalName = "Glass";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = ((m_subAssemblyWidth - 2 * glassReduce - glassMuntRedX2) / 2);
                part.PartLength = ((m_subAssemblyHieght - 2 * glassReduce - 2 * glassMuntRedX2) / 3);
                part.PartThick = 1.0m;

                m_parts.Add(part);

            }
            ///////////////////////////////////////////////////////////////////////////////////////



            #endregion

            #region GlazingSeal


            for (int i = 0; i < 2; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                part = new Part(3904, "Glazing Seal", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion

            #region Hardware


            #endregion



        }



        #endregion


    }
}