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

    public class FxBt2IG_MAS_BrzAlum : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal coveReduceX2 = 1.5m * 2.0m;
        const decimal gasketReduce = 1.0m;
        const decimal stopReduceX2 = 2.0m * 0.625m;
        const decimal glassReduX2 = 2.0m * 0.96875m;
        const decimal glassAtMunt = 0.25m;


        #endregion

        #region Constructor

        public FxBt2IG_MAS_BrzAlum()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FxBt2IG_MAS_BrzAlum";
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
                part = new Part(4480, "BrzAluFixVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "FrameBrzAlu-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // BrzAlumFixHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4480, "BrzAlumFixHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrzAlu-Parts";
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
                part = new Part(5383, "WoodFixWndVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // WoodFixWndHorz
            for (int i = 0; i < 2; i++)
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

            #region MuntinV

            //MuntinV
            for (int i = 0; i < 2; i++)
            {
                part = new Part(1859, "MuntinV", this, 1, m_subAssemblyHieght - coveReduceX2);
                part.PartGroupType = "MuntinV-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "1-1/2_MuntinV";

                m_parts.Add(part);

            }

            #endregion

            #region StopBrz

            //////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpVt
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

            //BrzGlsStpHz  
            for (int i = 0; i < 2; i++)
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
                part.PartWidth = (m_subAssemblyWidth - (glassReduX2 + glassAtMunt)) / 2.0m;
                part.PartLength = m_subAssemblyHieght - glassReduX2 ;
                part.PartThick = 1.230m;

                m_parts.Add(part);

            }


            #endregion

            #region AssyBrackets


            //////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktBronz
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4853, "AglBrktBronz", this, 1, 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////


            // AglBrktAlum
            for (int i = 0; i < 4; i++)
            {
                part = new Part(3206, "AglBrktAlum", this, 1, 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////

            // SocSetScrw.25_20
            for (int i = 0; i < 32; i++)
            {
                part = new Part(1545, "SocSetScrw.25_20", this, 1, 0.0m);
                part.PartGroupType = "AssemblyHdw-Parts";
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

                //preSetEPDM
                part = new Part(4314, "preSetEPDM", this, 1, peri - m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //WedgEPDM
                part = new Part(4284, "WedgEPDM", this, 1, peri - m_subAssemblyWidth);
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