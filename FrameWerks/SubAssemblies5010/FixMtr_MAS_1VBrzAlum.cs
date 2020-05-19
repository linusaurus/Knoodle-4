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

    public class FixMtr_MAS_1VBrzAlum : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal stopReduce = .625m;
        const decimal stopReduceX2 = .625m * 2.0m;
        const decimal stopRedMiter = 0.1796m;
        const decimal glassRedX2 = .96875m * 2.0m;
        const decimal glassReduce = .96875m;
        const decimal glassAtMunt = 0.125m;
        const decimal glasRedMitWd = 0.78125m;
        const decimal glasRedMitDp = 2.28125m;
        const decimal gasketReduce = 1.0m;
        const decimal coveReduceX2 = 1.5m * 2.0m;


        #endregion

        #region Constructor

        public FixMtr_MAS_1VBrzAlum()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FixMtr_MAS_1VBrzAlum";
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
            for (int i = 0; i < 1; i++)
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
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4480, "BrzAlumFixHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrzAlu-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Miter_90°";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // BrzAlumFixHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4480, "BrzAlumFixHorz", this, 1, m_subAssemblyDepth);
                part.PartGroupType = "FrameBrzAlu-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Miter_90";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region C385_AngleCover

            //C385_AngleCover
            for (int i = 0; i < 1; i++)
            {
                part = new Part(2799, "C385_AngleCover", this, 1, m_subAssemblyHieght - coveReduceX2);
                part.PartGroupType = "C385_AngleCover-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "2-1/2_Cover";

                m_parts.Add(part);

            }

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

            #region WoodFrameInt

            //////////////////////////////////////////////////////////////////////////////

            // WoodFixWndVert
            for (int i = 0; i < 1; i++)
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
                part.PartLabel = "Miter_90";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////// 

            // WoodFixWndHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5383, "WoodFixWndHorz", this, 1, m_subAssemblyDepth);
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Miter_90";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////  

            //WoodCornerCover
            for (int i = 0; i < 1; i++)
            {
                part = new Part(911, "WoodCornerCover", this, 1, m_subAssemblyHieght - coveReduceX2);
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "13/16_Cover";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////// 

            #endregion

            #region StopBrz

            //////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpVt
            for (int i = 0; i < 1; i++)
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
                part = new Part(4298, "BrzGlsStpHz", this, 1, m_subAssemblyWidth - stopReduce - stopRedMiter);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Miter_90";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            //BrzGlsStpHz  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlsStpHz", this, 1, m_subAssemblyDepth - stopReduce - stopRedMiter);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Miter_90";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //Glass Panel

            part = new Part(4550);

            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassAtMunt + glasRedMitWd);
            part.PartLength = m_subAssemblyHieght - (glassRedX2);
            part.PartThick = 1.230m;

            m_parts.Add(part);


            //Glass Panel

            part = new Part(4550);

            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyDepth - (glassReduce + glasRedMitDp);
            part.PartLength = m_subAssemblyHieght - (glassRedX2);
            part.PartThick = 1.230m;

            m_parts.Add(part);

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
                part = new Part(4314, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //EDPM_Wedge
                part = new Part(4284, "EDPM_Wedge", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyDepth - gasketReduce);

                //EPDM_PreSet
                part = new Part(4314, "EPDM_PreSet", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyDepth - gasketReduce);

                //EDPM_Wedge
                part = new Part(4284, "EDPM_Wedge", this, 1, peri);
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