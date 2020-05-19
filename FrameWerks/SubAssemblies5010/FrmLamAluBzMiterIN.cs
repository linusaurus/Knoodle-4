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

    public class FrmLamAluBzMiterIN : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal woodIntReduce = 0.25m;
        const decimal stopReduce = .625m;
        const decimal stopReduceX2 = .625m * 2.0m;
        const decimal stopRedCorner = 0.5466m;
        const decimal glassReduce = .96875m;
        const decimal glassRedWide = 1.437575m;
        const decimal glassRedDepth = 2.50m;


        #endregion

        #region Constructor

        public FrmLamAluBzMiterIN()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FrmLamAluBzMiterIN";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region FrameAluBrz


            //////////////////////////////////////////////////////////////////////////////

            // BrzAluFixVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4321, "BrzAluFixVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "FrameAluBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            // BrzAluFixHorzW
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4321, "BrzAluFixHorzW", this, 1, m_subAssemblyWidth - woodIntReduce);
                part.PartGroupType = "FrameAluBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "H_MiterFram1width";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // BrzAluFixHorzD
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4321, "BrzAluFixHorzD", this, 1, m_subAssemblyDepth - woodIntReduce);
                part.PartGroupType = "FrameAluBrz-Parts";
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
                part = new Part(4330, "WoodFixWndVert", this, 1, m_subAssemblyHieght);
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
                part = new Part(4330, "WoodFixWndHorzW", this, 1, m_subAssemblyWidth );
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
                part = new Part(4330, "WoodFixWndHorzD", this, 1, m_subAssemblyDepth );
                part.PartGroupType = "WoodFrameInt-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "BackMiter1Depth";

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

            // AluGlassStopHorzW  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4327, "AluGlassStopHorzW", this, 1, m_subAssemblyWidth - stopReduce - stopRedCorner);
                part.PartGroupType = "StopAlu-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "H_Miter1Stpwidth";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // AluGlassStopHorzD  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4327, "AluGlassStopHorzD", this, 1, m_subAssemblyDepth - stopRedCorner - stopReduce);
                part.PartGroupType = "StopAlu-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "H_Miter1Stpdepth";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region WoodStop


            //////////////////////////////////////////////////////////////////////////////

            // WoodStopVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4331, "WoodStopVert", this, 1, m_subAssemblyHieght - stopReduceX2 );
                part.PartGroupType = "WoodStop-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // WoodStopHorzW  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4331, "WoodStopHorzW", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "WoodStop-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // WoodStopHorzD  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4331, "WoodStopHorzD", this, 1, m_subAssemblyDepth);
                part.PartGroupType = "WoodStop-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Glass

            //GlassPanel

            ////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                part = new Part(3041, "GlassLami", this, 1, 0);
                part.PartWidth = m_subAssemblyWidth - glassReduce - glassRedWide;
                part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
                part.PartThick = 0.8125m;
                part.PartLabel = "POLISH_1_VERTICAL";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////////////

            //Glass Panel

            part = new Part(3041);

            part.FunctionalName = "GlassLami";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyDepth - glassReduce - glassRedDepth;
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
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////


            // AluCnrBrkt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(3206, "AluCnrBrkt", this, 1, 0.0m);
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