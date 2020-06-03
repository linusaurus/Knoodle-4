
#region Copyright (c) 2017 WeaselWare Software
/************************************************************************************
'
' Copyright  2017 WeaselWare Software 
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
' Portions Copyright 2017 WeaselWare Software
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

    public class CaseUnit1x2LHR : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal frameReduce2X = 0.9375m * 2.0m;
        const decimal AlumCrnBrk = 0.625m;
        const decimal gaskFrmReduce = 1.250m;
        const decimal gstopReduce2X = 1.88285m * 2.0m;
        const decimal glassReduce2X = 2.21875m * 2.0m;
        const decimal gaskSashReduce = 2.1875m;
        const decimal edgeSealAdd = 0.375m;
        const decimal sidMuntGPExt2 = 2.5335m * 2.0m;
        const decimal sidMuntGPInt2 = 2.7080m * 2.0m;
        const decimal screenReduce2X = 2.0m * 1.51202m;

        //static int createID;

        #endregion

        #region Constructor

        public CaseUnit1x2LHR()
        {
            subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010AH-CaseUnit1x2LHR";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Component Component;
            string Componentleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;



            #region Frame

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // JmbAlumR -->>

            Component = new Component(4347, "JmbAlumR", this, 1, m_subAssemblyHieght);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + FrameWorks.Functions.TieBarLockCenter(this.SubAssemblyHieght);

            m_Components.Add(Component);

            // JmbAlumL <<-- 

            Component = new Component(4347, "JmbAlumL", this, 1, m_subAssemblyHieght);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "1)MiterEnds";

            m_Components.Add(Component);


            // HeadAlum ^^

            Component = new Component(4347, "HeadAlum", this, 1, m_subAssemblyWidth);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "1)MiterEnds" + "\r\n" +
                             "2)Machine Left PN:1741";

            m_Components.Add(Component);

            // SillAlum ||

            Component = new Component(4347, "SillAlum", this, 1, m_subAssemblyWidth);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "1)MiterEnds" + "\r\n" +
                             "2)Machine Left PN:1741";

            m_Components.Add(Component);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Screen

            // ScrnFrmVert ^^
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4430, "ScrnFrmVert", this, 1, m_subAssemblyHieght - screenReduce2X);
                Component.ComponentGroupType = "Frame-Components";
                Component.ComponentLabel = "1)MiterEnds";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // ScrnFrmHorz ^^
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4430, "ScrnFrmHorz", this, 1, m_subAssemblyWidth - screenReduce2X);
                Component.ComponentGroupType = "Frame-Components";
                Component.ComponentLabel = "1)MiterEnds";

                m_Components.Add(Component);

            }

            #endregion

            #region AssyHrdwrFrame


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            for (int i = 0; i < 8; i++)
            {
                Component = new Component(3206, "AglBrktAlum", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrFrame";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            // PointSetScrew
            for (int i = 0; i < 32; i++)
            {
                Component = new Component(1545, "PointSetScrew", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrFrame";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Hardware-Components

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // OperatorEncoreLH

            Component = new Component(5094, "OperatorEncoreLH", this, 1, 0.0m);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            // LH_Encore®CoverHandle
            Component = new Component(4912, "LH_Encore®CoverHandle", this, 1, 0.0m);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            // OperatorBacker
            Component = new Component(5253, "OperatorBacker", this, 1, 0.0m);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            int hardwarecount = 1;
            if (m_subAssemblyHieght < 51.9999m)
            {
                hardwarecount = 1;
            }
            else
            {
                hardwarecount = 2;

            }


            // TruthMaxim24Lock
            Component = new Component(4911, "TruthMaxim24Lock", this, hardwarecount, 0m);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            // Keeper
            Component = new Component(3516, "Keeper", this, hardwarecount, 0m);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Get the size of the tiebar ComponentNo--
            decimal tieBarLength = FrameWorks.Functions.S2000TieBar(m_subAssemblyHieght);

            //check is sash even requires a tiebar
            if (tieBarLength != 0)
            {
                // Tie Bars
                Component = new Component(3625, "Tie Bars", this, 1, tieBarLength);
                Component.ComponentGroupType = "Hardware-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            decimal periFrame = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                periFrame = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);

                //FrameSeal
                Component = new Component(2274, "FrameSeal", this, 1, periFrame);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region Sash

            // StileAlumL <<--

            Component = new Component(4350, "StileAlumL", this, 1, m_subAssemblyHieght - frameReduce2X);
            Component.ComponentGroupType = "Sash-Components";
            Component.ComponentWidth = Component.Source.Width;
            Component.ComponentThick = Component.Source.Height;
            Component.ComponentLabel = labelStileL = "MiterEnds";

            m_Components.Add(Component);

            // StileAlumR -->>

            Component = new Component(4350, "StileAlumR", this, 1, m_subAssemblyHieght - frameReduce2X);
            Component.ComponentGroupType = "Sash-Components";
            Component.ComponentWidth = Component.Source.Width;
            Component.ComponentThick = Component.Source.Height;
            Component.ComponentLabel = labelStileR = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";

            m_Components.Add(Component);

            // RailAlumT ^^
            Component = new Component(4350, "RailAlumT", this, 1, m_subAssemblyWidth - frameReduce2X);
            Component.ComponentGroupType = "Sash-Components";
            Component.ComponentWidth = Component.Source.Width;
            Component.ComponentThick = Component.Source.Height;
            Component.ComponentLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine1741Left";

            m_Components.Add(Component);

            // RailAlumB ||
            Component = new Component(4350, "RailAlumB", this, 1, m_subAssemblyWidth - frameReduce2X);
            Component.ComponentGroupType = "Sash-Components";
            Component.ComponentWidth = Component.Source.Width;
            Component.ComponentThick = Component.Source.Height;
            Component.ComponentLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine1741Left";

            m_Components.Add(Component);

            #endregion

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // ExtMuntHorz
            for (int i = 0; i < 1; i++)
            {

                Component = new Component(4588, "ExtMuntHorz", this, 1, m_subAssemblyWidth - sidMuntGPExt2);
                Component.ComponentGroupType = "Muntins";
                Component.ComponentLabel = "WELD_Ends";

                m_Components.Add(Component);

            }

            // IntMuntHorz
            for (int i = 0; i < 1; i++)
            {

                Component = new Component(4587, "IntMuntHorz", this, 1, m_subAssemblyWidth - sidMuntGPInt2);
                Component.ComponentGroupType = "Muntins";
                Component.ComponentLabel = "BEVEL_Ends";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpVert
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4341, "AlumGlsStpVert", this, 1, m_subAssemblyHieght - gstopReduce2X);
                Component.ComponentGroupType = "StopAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpTopBot
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4341, "AlumGlsStpTopBot", this, 1, m_subAssemblyWidth - gstopReduce2X);
                Component.ComponentGroupType = "StopAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AsemblHrdwr

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace
            for (int i = 0; i < 4; i++)
            {
                Component = new Component(4784, "SS_0.4625_InsetCrnBrace", this, 1, 0.0m);
                Component.ComponentGroupType = "AsemblHrdwr-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            // FlatHead_8-32x3/16_UndercutHead
            for (int i = 0; i < 16; i++)
            {
                Component = new Component(502, "FlatHead_8-32x3/16_UndercutHead", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrDoor";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            for (int i = 0; i < 4; i++)
            {
                Component = new Component(3206, "AglBrktAlum", this, 1, AlumCrnBrk);
                Component.ComponentGroupType = "AsemblHrdwr-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "SashWnd";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Hardware

            // HingeCaseUL
            Component = new Component(1741, "HingeCaseUL", this, 1, 0.0m);
            Component.ComponentGroupType = "Hardware";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            // HingeCaseLL
            Component = new Component(1741, "HingeCaseLL", this, 1, 0.0m);
            Component.ComponentGroupType = "Hardware";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            // HingeShoeLL
            Component = new Component(5279, "HingeShoeLL", this, 1, 0.0m);
            Component.ComponentGroupType = "Hardware";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            // HingeFiller
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(5280, "HingeFiller", this, 1, 0.0m);
                Component.ComponentGroupType = "Hardware";
                Component.ComponentLabel = "";

                m_Components.Add(Component);
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            /////////////////////////////////////////////////////////////////////////////////////////////
            // GlassPanel
            for (int i = 0; i < 1; i++)
            {

                // GlassPanel
                Component = new Component(3472);

                Component.FunctionalName = "GlassPanel";
                Component.ComponentGroupType = "Glass-Components";
                Component.Qnty = 1;
                Component.ContainerAssembly = this;
                Component.ComponentWidth = (m_subAssemblyWidth - glassReduce2X);
                Component.ComponentLength = (m_subAssemblyHieght - glassReduce2X);
                Component.ComponentThick = 1.25m;
                Component.ComponentLabel = "SDL_1x2";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - edgeSealAdd, m_subAssemblyWidth - edgeSealAdd);

                //SashEdgeSeal
                Component = new Component(2274, "SashEdgeSeal", this, 1, periSash);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);

                //EPDM_PreSet
                Component = new Component(4314, "EPDM_PreSet", this, 1, peri);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);

                //EPDM_Wedge
                Component = new Component(4284, "EPDM_Wedge", this, 1, peri);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_PreSet
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4314, "EPDM_PreSet", this, 1, m_subAssemblyWidth - sidMuntGPExt2);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // EPDM_Wedge
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4284, "EPDM_Wedge", this, 1, m_subAssemblyWidth - sidMuntGPInt2);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

        }


        #endregion


    }
}