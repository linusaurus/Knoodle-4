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
            subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrameScreen";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Component Component;
            string Componentleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region FrameScreen


            //////////////////////////////////////////////////////////////////////////////

            // ScreenFrameVert
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4430, "ScreenFrameVert", this, 1, m_subAssemblyHieght - screenFrmRed2X);
                Component.ComponentGroupType = "FrameScreen-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            // ScreenFrameHorz
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4430, "ScreenFrameHorz", this, 1, m_subAssemblyWidth - screenFrmRed2X);
                Component.ComponentGroupType = "FrameScreen-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Mesh


            //Mesh

            Component = new Component(911);

            Component.FunctionalName = "Mesh";
            Component.ComponentGroupType = "Mesh-Components";
            Component.Qnty = 1;
            Component.ContainerAssembly = this;
            Component.ComponentWidth = m_subAssemblyWidth - screenFrmRed2X;
            Component.ComponentLength = m_subAssemblyHieght - screenFrmRed2X;
            Component.ComponentThick = 0.3125m;

            m_Components.Add(Component);



            #endregion

            #region Spline

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - splineReduceX2, m_subAssemblyWidth - splineReduceX2);

                //Glazing Seals
                Component = new Component(911, "Spline", this, 1, peri);
                Component.ComponentGroupType = "Spline-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            #endregion

            #region Hardware


            for (int i = 0; i < 4; i++)
            {
                Component = new Component(911, "ScnFrmCrnBrackets", this, 1, aluminumCrnBrk);
                Component.ComponentGroupType = "Hardware-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }


            #endregion

        }

        #endregion


    }
}