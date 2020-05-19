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

namespace FrameWorks.Makes.System5010
{

    public class FixMAS_BrzAluMel_1x2 : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal stopReduceX2 = .625m * 2.0m;
        const decimal stopReduce = .625m;
        const decimal glassReduce = .96875m;
        const decimal glasReduce2X = .96875m * 2.0m;
        const decimal glasADDhead = .21875m;
        const decimal centerGapGlass = 0.25m;
        const decimal gasketReduce = 1.09375m;
        const decimal coveReduce = 1.5m;


        #endregion

        #region Constructor

        public FixMAS_BrzAluMel_1x2()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FixMAS_BrzAluMel_1x2";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region FrameBrzAlu

            //////////////////////////////////////////////////////////////////////////////

            // BrzAluFixVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4480, "BrzAluFixVert", this, 1, m_subAssemblyHieght );
                part.PartGroupType = "FrameBrzAlu-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // BrzAlumFixHorz
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4480, "BrzAlumFixHorz", this, 1, m_subAssemblyWidth );
                part.PartGroupType = "FrameBrzAlu-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region MetalCovers

            //MuntinCover
            for (int i = 0; i < 2; i++)
            {
                part = new Part(1859, "MuntinCover", this, 1, m_subAssemblyHieght - coveReduce);
                part.PartGroupType = "MetalCovers-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "1-1/2_BarCover";

                m_parts.Add(part);

            }

            #endregion

            #region HeadMelcore

            //////////////////////////////////////////////////////////////////////////////

            // Melcore
            for (int i = 0; i < 2; i++)
            {
                part = new Part(911, "Melcore", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "HeadMelcore-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // MarinePly
            for (int i = 0; i < 1; i++)
            {
                part = new Part(911, "MarinePly", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "HeadMelcore-Parts";
                part.PartWidth = 4.75m;
                part.PartThick = 0.75m;
                part.PartLabel = "Head";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region WoodFrameInt

            //////////////////////////////////////////////////////////////////////////////

            // WoodFixWndVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5383, "WoodFixWndVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            // WoodFixWndHorz
            for (int i = 0; i < 1; i++)
            {
                part = new Part(5383, "WoodFixWndHorz", this, 1, m_subAssemblyWidth);
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

            // BrzGlsStpVt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlsStpVt", this, 1, m_subAssemblyHieght - stopReduce);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //BrzGlsStpHz  
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4298, "BrzGlsStpHz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //Glass Panel
            for (int i = 0; i < 2; i++)

            {

                part = new Part(4550);
                part.FunctionalName = "Glass";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - glasReduce2X - centerGapGlass) / 2.0m;
                part.PartLength = m_subAssemblyHieght - glassReduce + (glasADDhead);
                part.PartThick = 1.25m;

                m_parts.Add(part);

            }

            #endregion

            #region AssyBrackets


            //////////////////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4265, "BrzCnrBrkt", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////


            // AluCnrBrkt
            for (int i = 0; i < 2; i++)
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

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //EPDM_PreSet
                part = new Part(4314, "EPDM_PreSet", this, 1, peri - m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //EPDM_Wedge
                part = new Part(4284, "EPDM_Wedge", this, 1, peri - m_subAssemblyWidth);
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