﻿#region Copyright (c) 2015 WeaselWare Software
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

    public class FrameSpndrlComponents : SubAssemblyBase
    {

        #region Fields

        //Constant Values



        #endregion

        #region Constructor

        public FrameSpndrlComponents()
        {
            subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrameSpndrlComponents";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Component Component;
            string Componentleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region FrameAlum

            //////////////////////////////////////////////////////////////////////////////

            // BaseFrameVert
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4360, "BaseFrameVert", this, 1, m_subAssemblyHieght );
                Component.ComponentGroupType = "FrameAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "BaseV";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            // BaseFrameHorz
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4360, "BaseFrameHorz", this, 1, m_subAssemblyWidth );
                Component.ComponentGroupType = "FrameAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "BaseH";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // ClampVert
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4359, "ClampVert", this, 1, m_subAssemblyHieght );
                Component.ComponentGroupType = "FrameAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "BaseV";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            // ClampHorz
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4359, "ClampHorz", this, 1, m_subAssemblyWidth);
                Component.ComponentGroupType = "FrameAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "BaseH";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region CapAlum

            //////////////////////////////////////////////////////////////////////////////

            //CapVt
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4358, "CapVt", this, 1, m_subAssemblyHieght);
                Component.ComponentGroupType = "CapAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            //CapHz  
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4358, "CapHz", this, 1, m_subAssemblyWidth);
                Component.ComponentGroupType = "CapAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region GlazingSeal

            for (int i = 0; i < 4; i++)
            {

                //decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght + gasketAdd, m_subAssemblyWidth + gasketAdd);

                //Glazing Seals
                Component = new Component(4314, "GlazDartEPDM_Vt", this, 1, m_subAssemblyHieght);
                Component.ComponentGroupType = "GlazingSeal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }


            for (int i = 0; i < 4; i++)
            {

                //decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                Component = new Component(4314, "GlazDartEPDM_Hz", this, 1, m_subAssemblyWidth);
                Component.ComponentGroupType = "GlazingSeal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }



            #endregion

        }

        #endregion

    }
}