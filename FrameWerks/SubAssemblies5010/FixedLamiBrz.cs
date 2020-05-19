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

namespace FrameWorks.Makes.System5010
{

    public class FixedLamiBrz : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal stopReduceX2 = .625m * 2.0m;
        const decimal glassReduce = .96875m;
        const decimal gasketReduce = 1.09375m;



        #endregion

        #region Constructor

        public FixedLamiBrz()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FixedLamiBrz";
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


            //////////////////////////////////////////////////////////////////////////////

            // BrzFixHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4300, "BrzFixHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


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

            //////////////////////////////////////////////////////////////////////////////

            // WoodFixWndHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4283, "WoodFixWndHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

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

            //////////////////////////////////////////////////////////////////////////////

            // BrzGlassStopHorz  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlassStopHorz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopWood


            //////////////////////////////////////////////////////////////////////////////

            // WoodGlassStopVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4331, "WoodGlassStopVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////

            // WoodGlassStopHorz  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4331, "WoodGlassStopHorz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region BrzStpFill


            //////////////////////////////////////////////////////////////////////////////

            // BrzStpFillVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4317, "BrzStpFillVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "BrzFill-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "CUT_.4375";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////

            // BrzStpFillHorz  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4317, "BrzStpFillHorz", this, 1, m_subAssemblyWidth - stopReduceX2);
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
            part.PartWidth = m_subAssemblyWidth - (glassReduce * 2.0m);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 0.8125m;

            m_parts.Add(part);



            #endregion

            #region AssyBrackets


            //////////////////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            for (int i = 0; i < 8; i++)
            {
                part = new Part(4265, "BrzCnrBrkt", this, 1, 0.0m);
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

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //GlazDartEPDM
                part = new Part(4314, "GlazDartEPDM", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

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