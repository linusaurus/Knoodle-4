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

namespace FrameWorks.Makes.System2010
{

    public class FrameScreen : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal screenFrmRed2X = 1.50m * 2.0m;
        const decimal aluminumCrnBrk = 0.625m;
        const decimal splineReduceX2 = 2.0m * 2.0m;

        #endregion

        #region Constructor

        public FrameScreen()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrameScreen";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region FrameScreen


            //////////////////////////////////////////////////////////////////////////////

            // ScreenFrameVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4430, "ScreenFrameVert", this, 1, m_subAssemblyHieght - screenFrmRed2X);
                part.PartGroupType = "FrameScreen-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            // ScreenFrameHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4430, "ScreenFrameHorz", this, 1, m_subAssemblyWidth - screenFrmRed2X);
                part.PartGroupType = "FrameScreen-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Mesh


            //Mesh

            part = new Part(911);

            part.FunctionalName = "Mesh";
            part.PartGroupType = "Mesh-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - screenFrmRed2X;
            part.PartLength = m_subAssemblyHieght - screenFrmRed2X;
            part.PartThick = 0.3125m;

            m_parts.Add(part);



            #endregion

            #region Spline

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - splineReduceX2, m_subAssemblyWidth - splineReduceX2);

                //Glazing Seals
                part = new Part(911, "Spline", this, 1, peri);
                part.PartGroupType = "Spline-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            #endregion

            #region Hardware


            for (int i = 0; i < 4; i++)
            {
                part = new Part(911, "ScnFrmCrnBrackets", this, 1, aluminumCrnBrk);
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