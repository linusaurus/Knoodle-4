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

namespace FrameWorks.Makes.System5010
{

    public class FixedLamBrzMiter : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal stopReduce = .625m;
        const decimal stopReduceX2 = .625m * 2.0m;
        const decimal fillerReduce = 1.27m;
        const decimal fillReduceX2 = 1.27m * 2.0m;
        const decimal fillCornerRed = 0.5347m;
        const decimal stopRedCorner = 0.1796m;
        const decimal glassReduce = .96875m;
        const decimal glassRedWide = 1.1875m;
        const decimal glassRedDepth = 2.250m;



        #endregion

        #region Constructor

        public FixedLamBrzMiter()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FixedLamBrzMiter";
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

            // BrzFixVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4300, "BrzFixVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            // BrzFixHorzW
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4300, "BrzFixHorzW", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "H_MiterFram1width";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // BrzFixHorzD
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4300, "BrzFixHorzD", this, 1, m_subAssemblyDepth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "H_MiterFrm1depth";

                m_parts.Add(part);

            }


            //////////////////////////////////////////////////////////////////////////////


            #endregion

            #region WoodFrameInt


            //////////////////////////////////////////////////////////////////////////////

            // WoodFixWndVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4283, "WoodFixWndVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // WoodFixWndHorzW
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4283, "WoodFixWndHorzW", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "BackMiter1Width";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////           

            // WoodFixWndHorzD
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4283, "WoodFixWndHorzD", this, 1, m_subAssemblyDepth);
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "BackMiter1Depth";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////     



            #endregion

            #region StopBrz


            //////////////////////////////////////////////////////////////////////////////

            // BrzGlassStopVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlassStopVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // BrzGlassStopHorzW  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlassStopHorzW", this, 1, m_subAssemblyWidth - stopReduce - stopRedCorner);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "H_Miter1Stpwidth";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // BrzGlassStopHorzD  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlassStopHorzD", this, 1, m_subAssemblyDepth - stopRedCorner - stopReduce);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "H_Miter1Stpdepth";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region BrzStpFill


            //////////////////////////////////////////////////////////////////////////////

            // BrzStpFillVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4317, "BrzStpFillVert", this, 1, m_subAssemblyHieght - fillReduceX2);
                part.PartGroupType = "BrzFill-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "CUT_.4375";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // BrzStpFillHorzW  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4317, "BrzStpFillHorzW", this, 1, m_subAssemblyWidth - fillerReduce - fillCornerRed);
                part.PartGroupType = "BrzFill-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "CUT_.4375";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // BrzStpFillHorzD  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4317, "BrzStpFillHorzD", this, 1, m_subAssemblyDepth - fillCornerRed - fillerReduce);
                part.PartGroupType = "BrzFill-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "CUT_.4375";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Glass


            //Glass Panel

            part = new Part(3041);

            part.FunctionalName = "GlassLami";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce + glassRedWide);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 0.8125m;
            part.PartLabel = "POLISH_1_VERTICAL";

            m_parts.Add(part);



            //Glass Panel

            part = new Part(3041);

            part.FunctionalName = "GlassLami";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyDepth - (glassReduce + glassRedDepth);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 0.8125m;
            part.PartLabel = "POLISH_1_VERTICAL";

            m_parts.Add(part);



            #endregion

            #region AssyBrackets


            //////////////////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4265, "BrzCnrBrkt", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////

            // AluCnrBrkt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(3206, "AluCnrBrkt", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////

            // SocSetScrw.25_20
            for (int i = 0; i < 16; i++)
            {
                part = new Part(1545, "SocSetScrw.25_20", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Seal/Weatherstripping


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth + m_subAssemblyDepth);

                //GlazDartEPDM
                part = new Part(4314, "GlazDartEPDM", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth + m_subAssemblyDepth);

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