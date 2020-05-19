#region Copyright (c) 2014 WeaselWare Software
/************************************************************************************
'
' Copyright  2014 WeaselWare Software 
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
' Portions Copyright 2014 WeaselWare Software
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

namespace FrameWorks.Makes.System3010
{

    public class FixedMitr : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal bronzeCrnBrk = 0.625m;
        const decimal stopReduce = 0.625m;
        const decimal stopReduceX2 = 0.625m * 2.0m;
        const decimal stopRedMiter = 2.26999977m;
        const decimal spaceStopRed = 0.76853695m;
        const decimal spcStpRedX2 = 0.76853695m * 2.0m;
        const decimal spaceStpMitRed = 1.71530761m;
        const decimal glassReduce = 0.96875m;
        const decimal glsRedWideWidth = 0.96875m;
        const decimal glsRedWideDepth = 1.71875m;
        const decimal gasketReduce = 1.09375m;


        #endregion

        #region Constructor

        public FixedMitr()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-FixedMitr";
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

            // BrzFixedIGVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4300, "BrzFixedIGVert", this, 1, m_subAssemblyHieght);
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
                part = new Part(4300, "BrzFixedIGHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "SEE_DWG";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            // BrzFixedIGHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4300, "BrzFixedIGHorz", this, 1, m_subAssemblyDepth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "SEE_DWG";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////



            #endregion

            #region StopBrz




            //////////////////////////////////////////////////////////////////////////////

            // BrzGlsStopVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlsStpVt", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            // BrzGlsStopHorz 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlsStpHzWIDE", this, 1, m_subAssemblyWidth - stopReduce - stopRedMiter);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "SEE_DWG";

                m_parts.Add(part);

            }


            ////////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            //BrzGlsStopHorz  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlsStpHzDEEP", this, 1, m_subAssemblyDepth - stopReduce - stopRedMiter);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "SEE_DWG";

                m_parts.Add(part);

            }


            ////////////////////////////////////////////////////////////////////////////////



            #endregion

            #region STPfillBrz


            //////////////////////////////////////////////////////////////////////////////

            // BrzStpFilVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4317, "BrzStpFilVert", this, 1, m_subAssemblyHieght - spcStpRedX2 );
                part.PartGroupType = "STPfillBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            // BrzStpFilHorz 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4317, "BrzStpFilHorz", this, 1, m_subAssemblyWidth - spaceStopRed - spaceStpMitRed);
                part.PartGroupType = "STPfillBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "SEE_DWG";

                m_parts.Add(part);

            }


            ////////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            // BrzStpFilHorz 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4317, "BrzStpFilHorz", this, 1, m_subAssemblyDepth - spaceStopRed - spaceStpMitRed);
                part.PartGroupType = "STPfillBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "SEE_DWG";

                m_parts.Add(part);

            }


            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Glass


            //Glass Panel

            part = new Part(4212);

            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce + glsRedWideWidth);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = .5625m;
            part.PartLabel = "SEE_DWG";

            m_parts.Add(part);


            //Glass Panel

            part = new Part(4212);

            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyDepth - (glassReduce + glsRedWideDepth);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = .5625m;
            part.PartLabel = "SEE_DWG";

            m_parts.Add(part);



            #endregion

            #region GlazingSeal


            for (int i = 0; i < 1; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth + m_subAssemblyDepth - gasketReduce );

                // GlazePreSet
                part = new Part(4314, "GlazePreSet", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            for (int i = 0; i < 1; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth + m_subAssemblyDepth - gasketReduce );

                // GlazeWedgeSeals
                part = new Part(4399, "GlazeWedgeSeals", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }



            #endregion

            #region AsemblHrdwr

            //////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4265, "BrzCnrBrkt", this, 1, bronzeCrnBrk);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // SetSocScrew_1/4-20x1/4
            for (int i = 0; i < 32; i++)
            {
                part = new Part(1545, "SetSocScrew_1/4-20x1/4", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion


        }



        #endregion


    }
}
