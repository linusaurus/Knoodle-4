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

    public class FixedLamAlumBrz : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal stopReduceX2 = .625m * 2.0m;
        const decimal fillReduceX2 = 1.27m * 2.0m;
        const decimal glassReduce = .96875m;
        const decimal gasketReduce = 1.09375m;


        #endregion

        #region Constructor

        public FixedLamAlumBrz()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FixedLamAlumBrz";
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
                part = new Part(4321, "BrzAluFixVert", this, 1, m_subAssemblyHieght);
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
                part = new Part(4321, "BrzAlumFixHorz", this, 1, m_subAssemblyWidth);
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
                part = new Part(4330, "WoodFixWndVert", this, 1, m_subAssemblyHieght);
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
                part = new Part(4330, "WoodFixWndHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////           




            #endregion

            #region StopAlu




            //////////////////////////////////////////////////////////////////////////////

            // AluGlassStopVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4327, "AluGlassStopVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopAlu-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////

            // AluGlassStopHorz 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4327, "AluGlassStopHorz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopAlu-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region WoodStop

            //////////////////////////////////////////////////////////////////////////////

            // WoodGlsStpVt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4331, "WoodGlsStpVt", this, 1, m_subAssemblyHieght - 2 * stopReduceX2);
                part.PartGroupType = "WoodStop-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////

            // WoodGlsStpHz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4331, "WoodGlsStpHz", this, 1, m_subAssemblyWidth - 2 * stopReduceX2);
                part.PartGroupType = "WoodStop-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region HDPEStpFill


            //////////////////////////////////////////////////////////////////////////////

            // HDPEStpFillVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(911, "HDPEStpFillVert", this, 1, m_subAssemblyHieght );
                part.PartGroupType = "HDPEStpFill-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // HDPEStpFillHorzW  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(911, "HDPEStpFillHorzW", this, 1, m_subAssemblyWidth );
                part.PartGroupType = "HDPEStpFill-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }




            #endregion

            #region LamCapWood

            //////////////////////////////////////////////////////////////////////////////

            // WoodLamCapVt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(911, "WoodLamCapVt", this, 1, m_subAssemblyHieght - 2 * stopReduceX2);
                part.PartGroupType = "LamCapWood-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////

            // WoodLamCapHz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(911, "WoodLamCapHz", this, 1, m_subAssemblyWidth - 2 * stopReduceX2);
                part.PartGroupType = "LamCapWood-Parts";
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
                part = new Part(4317, "BrzStpFillHorzW", this, 1, m_subAssemblyWidth - fillReduceX2);
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

            part.FunctionalName = "Glass";
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
                part = new Part(4284, "GlazWedgEPDM", this, 1, peri);
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