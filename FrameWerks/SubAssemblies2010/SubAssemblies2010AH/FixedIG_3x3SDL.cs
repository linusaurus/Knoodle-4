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

namespace FrameWorks.Makes.System2010AH
{

    public class FixedIG_3x3SDL : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal aluminumCrnBrk = 0.625m;
        const decimal PointSetScrew = 0.25m;
        const decimal stopReduceX2 = .6250m * 2.0m;
        const decimal glassReduce = .96875m;
        const decimal gasketReduce = 1.09375m;
        const decimal sidMuntGPExt2 = 1.35465335m * 2.0m;
        const decimal sidMuntGPInt2 = 1.47049216m * 2.0m;
        const decimal vrtMuntGPExt2 = 1.29909927m * 2.0m;
        const decimal vrtMuntGPInt2 = 1.38031624m * 2.0m;


        #endregion

        #region Constructor

        public FixedIG_3x3SDL()
        {
            subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010AH-FixedIG_3x3SDL";
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

            // AlumFixedIGVert
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4344, "AlumFixedIGVert", this, 1, m_subAssemblyHieght);
                Component.ComponentGroupType = "FrameAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            // AlumFixedIGHorz
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4344, "AlumFixedIGHorz", this, 1, m_subAssemblyWidth);
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

            //AlumGlsStpVt
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4341, "AlumGlsStpVt", this, 1, m_subAssemblyHieght - stopReduceX2);
                Component.ComponentGroupType = "StopAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////


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


            #endregion

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // ExtMuntHorz
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4588, "ExtMuntHorz", this, 1, m_subAssemblyWidth - sidMuntGPExt2);
                Component.ComponentGroupType = "Muntins";
                Component.ComponentLabel = "BEVEL_BISHOP_Ends";

                m_Components.Add(Component);

            }

            // IntMuntHorz
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4587, "IntMuntHorz", this, 1, m_subAssemblyWidth - sidMuntGPInt2);
                Component.ComponentGroupType = "Muntins";
                Component.ComponentLabel = "BEVEL_BISHOP_Ends";

                m_Components.Add(Component);

            }


            ////////////////////////////////////////////////////////////////////////////////////

            // ExtMuntVert
            for (int i = 0; i < 6; i++)
            {

                Component = new Component(4588, "ExtMuntVert", this, 1, (m_subAssemblyHieght - sidMuntGPExt2 - vrtMuntGPExt2) / 3.0m);
                Component.ComponentGroupType = "Muntins";
                Component.ComponentLabel = "BEVEL_BISHOP_Ends";

                m_Components.Add(Component);

            }

            // IntMuntVert
            for (int i = 0; i < 6; i++)
            {

                Component = new Component(4587, "IntMuntVert", this, 1, (m_subAssemblyHieght - sidMuntGPInt2 - vrtMuntGPInt2) / 3.0m);
                Component.ComponentGroupType = "Muntins";
                Component.ComponentLabel = "BEVEL_BISHOP_Ends";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass


            //GlassPanel

            Component = new Component(3472);

            Component.FunctionalName = "GlassPanel";
            Component.ComponentGroupType = "Glass-Components";
            Component.Qnty = 1;
            Component.ContainerAssembly = this;
            Component.ComponentWidth = m_subAssemblyWidth - (glassReduce * 2.0m);
            Component.ComponentLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            Component.ComponentThick = 1.25m;
            Component.ComponentLabel = "SDL_3x3";

            m_Components.Add(Component);



            #endregion

            #region GlazingSeal


            for (int i = 0; i < 1; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //EPDM_PreSet
                Component = new Component(4314, "EPDM_PreSet", this, 1, peri);
                Component.ComponentGroupType = "GlazingSeal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }


            for (int i = 0; i < 1; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //EPDM_Wedge
                Component = new Component(4284, "EPDM_Wedge", this, 1, peri);
                Component.ComponentGroupType = "GlazingSeal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_PreSet
            for (int i = 0; i < 4; i++)
            {

                Component = new Component(4314, "EPDM_PreSet", this, 1, m_subAssemblyWidth - sidMuntGPExt2);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge
            for (int i = 0; i < 4; i++)
            {

                Component = new Component(4284, "EPDM_Wedge", this, 1, m_subAssemblyWidth - sidMuntGPInt2);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_PreSet
            for (int i = 0; i < 4; i++)
            {

                Component = new Component(4314, "EPDM_PreSet", this, 1, m_subAssemblyHieght - sidMuntGPExt2);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge
            for (int i = 0; i < 4; i++)
            {

                Component = new Component(4284, "EPDM_Wedge", this, 1, m_subAssemblyHieght - sidMuntGPInt2);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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
                Component = new Component(1545, "PointSetScrew_1/4_20", this, 1, PointSetScrew);
                Component.ComponentGroupType = "AssyBrackets";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "1/4_20x.25";

                m_Components.Add(Component);

            }

            /////////////////////////////////////////////////////////////////////////



            //Cross_Bracket

            for (int i = 0; i < 8; i++)
            {
                Component = new Component(5267, "Cross_Bracket", this, 1, aluminumCrnBrk);
                Component.ComponentGroupType = "AssyBrackets";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "Cross_3.025";

                m_Components.Add(Component);

            }

            //SetScrew_10_32

            for (int i = 0; i < 64; i++)
            {
                Component = new Component(3518, "SetScrew_10_32", this, 1, PointSetScrew);
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