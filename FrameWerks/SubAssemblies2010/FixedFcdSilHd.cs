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

    public class FixedFcdSilHd : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal aluminumCrnBrk = 0.625m;
        const decimal stopReduceX2 = .96875m * 2.0m;
        const decimal glassReduce = .96875m;



        #endregion

        #region Constructor

        public FixedFcdSilHd()
        {
            subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FixedFcdSilHd";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Component Component;
            string Componentleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            var Components = ComponentsHelper.TrackMaker(new FrameLS_OX(){SubAssemblyWidth=100.0m,SubAssemblyHieght=90.0m,
                                                                Parent=this.Parent},3,3,TrackConfiguration.Telescoping);

            foreach (Component p in Components)
	        {
                p.ComponentGroupType = "Track-Components";
                m_Components.Add(p);
	        }
           
            #region FrameAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumFxdFcdSilHd
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4344, "AlumFxdFcdSilHd", this, 1, m_subAssemblyWidth);
                Component.ComponentGroupType = "FrameAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpHz  
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4341, "AlumGlsStpHz", this, 1, m_subAssemblyWidth - stopReduceX2);
                Component.ComponentGroupType = "StopAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////

            //GlsSpcrBrz 
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4317, "GlsSpcrBrz", this, 1, m_subAssemblyWidth - stopReduceX2);
                Component.ComponentGroupType = "StopAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass


            //Glass Panel

            Component = new Component(3300);

            Component.FunctionalName = "Glass";
            Component.ComponentGroupType = "Glass-Components";
            Component.Qnty = 1;
            Component.ContainerAssembly = this;
            Component.ComponentWidth = m_subAssemblyWidth - (glassReduce * 2.0m);
            Component.ComponentLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            Component.ComponentThick = 0.5625m;

            m_Components.Add(Component);



            #endregion

            #region GlazingSeal


            for (int i = 0; i < 1; i++)
            {


                //decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                Component = new Component(4314, "GlazDartEPDM", this, 1, m_subAssemblyWidth * 2.0m);
                Component.ComponentGroupType = "GlazingSeal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }


            for (int i = 0; i < 1; i++)
            {


                //decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                Component = new Component(4399, "GlazWedgEPDM", this, 1, m_subAssemblyWidth * 2.0m);
                Component.ComponentGroupType = "GlazingSeal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }



            #endregion

            #region AssyBrackets

            /////////////////////////////////////////////////////////////////////////

            //AglBrktAlum

            for (int i = 0; i < 8; i++)
            {
                Component = new Component(3206, "AglBrktAlum", this, 1, aluminumCrnBrk);
                Component.ComponentGroupType = "AssyBrackets";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "Angle_1.5";

                m_Components.Add(Component);

            }

            //PointSetScrew_1/4_20

            for (int i = 0; i < 32; i++)
            {
                Component = new Component(1545, "PointSetScrew_1/4_20", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyBrackets";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "1/4_20x.25";

                m_Components.Add(Component);

            }

            /////////////////////////////////////////////////////////////////////////

            #endregion



        }



        #endregion


    }
}