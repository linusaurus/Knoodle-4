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
using FrameWorks.Makes.System2010AH;


namespace FrameWorks.Makes.System2010AH
{

    public class DrSwg1x3FIXED : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal doorReduceX2 = 0.875m * 2.0m;
        const decimal doorReduce = 0.875m;
        const decimal doorGapBot = 0.5625m;
        const decimal doorGapMid = 0.375m;
        const decimal sidMuntGPExt2 = 3.7835m * 2.0m;
        const decimal sidMuntGPInt2 = 3.9582m * 2.0m;
        const decimal glsDrGap = 3.46875m;
        const decimal glsDrGapBot = 3.15625m;
        const decimal glsDrGapX2 = 3.46875m * 2.0m;
        const decimal epdmReduce = 2.73129921m;
        const decimal epdmADD = 2.375m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.21875m;
        const decimal hdpExtX2 = 0.21875m * 2.0m;
        const decimal stopRedBot = 2.8125m;
        const decimal stopReduce = 3.125m;
        const decimal stopRed2x = 3.125m * 2.0m;
        const decimal calkJoint = 0.125m;



        //



        #endregion

        #region Constructor

        public DrSwg1x3FIXED()
        {
            subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-DrSwg1x3FIXED";
        }

        #endregion

        #region Methods


        //Bill of Material
        public override void Build()
        {

            Component Component;

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region Frame-Components

            // JamAlumL <<-- 

            Component = new Component(4352, "JamAlumL|<", this, 1, m_subAssemblyHieght - calkJoint);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "1) MiterTop";

            m_Components.Add(Component);

            // JamAlumR -->>

            decimal doorPanel = decimal.Zero;

            doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;

            Component = new Component(4352, "JamAlumR>|", this, 1, m_subAssemblyHieght - calkJoint);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "1) MiterTop";

            m_Components.Add(Component);

            // HeadAlum ^^
            Component = new Component(4352, "HeadAlum", this, 1, m_subAssemblyWidth);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "1) MiterEnds";

            m_Components.Add(Component);

            #endregion

            #region AssyHrdwrFrame


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            for (int i = 0; i < 4; i++)
            {
                Component = new Component(3206, "AglBrktAlum", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrFrame";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            // PointSetScrew
            for (int i = 0; i < 16; i++)
            {
                Component = new Component(1545, "PointSetScrew", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrFrame";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - calkJoint, m_subAssemblyWidth);

                //FrameSealKfolD
                Component = new Component(2274, "FrameSealKfolD", this, 1, peri - m_subAssemblyWidth - 4.0m);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #region AlumTB3inch


            ////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4355, "StileLeft|<", this, 1, m_subAssemblyHieght - doorReduce - doorGapBot);
                Component.ComponentGroupType = "AlumTB3inch";
                Component.ComponentLabel = "1) Miter_Ends";
                m_Components.Add(Component);

            }


            // StileRight
            for (int i = 0; i < 1; i++)
            {

                Component = new Component(4355, "StileRight>|", this, 1, m_subAssemblyHieght - doorReduce - doorGapBot);
                Component.ComponentGroupType = "AlumTB3inch";
                Component.ComponentLabel = "1) Miter_Ends";

                m_Components.Add(Component);

            }


            // RailTop
            for (int i = 0; i < 1; i++)
            {

                Component = new Component(4355, "RailTop^", this, 1, m_subAssemblyWidth - doorReduceX2);
                Component.ComponentGroupType = "AlumTB3inch";
                Component.ComponentLabel = "1) Miter_Ends ";

                m_Components.Add(Component);

            }


            // RailBot
            for (int i = 0; i < 1; i++)
            {

                Component = new Component(4355, "RailBot_", this, 1, m_subAssemblyWidth - doorReduceX2);
                Component.ComponentGroupType = "AlumTB3inch";
                Component.ComponentLabel = "1) Miter_Ends ";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region HDPE

            // HDPELockEdge
            for (int i = 0; i < 0; i++)
            {

                Component = new Component(4269, "HDPELockEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
                Component.ComponentGroupType = "HDPE-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = labelStileL = "";

                m_Components.Add(Component);

            }

            // HDPEHingEdge
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4268, "HDPEHingEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
                Component.ComponentGroupType = "HDPE-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = labelStileL = "";

                m_Components.Add(Component);

            }

            // HDPETop
            for (int i = 0; i < 1; i++)
            {

                Component = new Component(4269, "HDPETop", this, 1, (m_subAssemblyWidth - doorReduceX2  + hdpExtX2) );
                Component.ComponentGroupType = "HDPE-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = labelStileR = "";

                m_Components.Add(Component);

            }

            // HDPEBot
            for (int i = 0; i < 1; i++)
            {

                Component = new Component(4270, "HDPEBot", this, 1, (m_subAssemblyWidth - doorReduceX2 - doorGapMid + hdpExtX2) );
                Component.ComponentGroupType = "HDPE-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = labelStileR = "";

                m_Components.Add(Component);

            }

            #endregion

            #region Muntins

            ////////////////////////////////////////////////////////////////////////////////////

            // ExtMuntHorz
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4588, "ExtMuntHorz", this, 1, (m_subAssemblyWidth - sidMuntGPExt2));
                Component.ComponentGroupType = "Muntins";
                Component.ComponentLabel = "WELD_Ends";

                m_Components.Add(Component);

            }

            // IntMuntHorz
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4587, "IntMuntHorz", this, 1, (m_subAssemblyWidth - sidMuntGPInt2));
                Component.ComponentGroupType = "Muntins";
                Component.ComponentLabel = "BEVEL_Ends";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopAlum

            // AlumGlsStpVert
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4341, "AlumGlsStpVert", this, 1, m_subAssemblyHieght - stopReduce - stopRedBot);
                Component.ComponentGroupType = "StopAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpTopBot
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4341, "AlumGlsStpTopBot", this, 1, (m_subAssemblyWidth - stopRed2x));
                Component.ComponentGroupType = "StopAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            // GlassPanel
            for (int i = 0; i < 1; i++)
            {

                //GlassPanel
                Component = new Component(3472);
                Component.FunctionalName = "GlassPanel";
                Component.ComponentGroupType = "Glass-Components";
                Component.Qnty = 1;
                Component.ContainerAssembly = this;
                Component.ComponentWidth = (m_subAssemblyWidth - glsDrGapX2);
                Component.ComponentLength = (m_subAssemblyHieght - glsDrGap - glsDrGapBot);
                Component.ComponentThick = 1.25m;
                Component.ComponentLabel = "SDL_1x3";

                m_Components.Add(Component);

            }

            #endregion

            #region AssyHrdwrDoor


            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
            for (int i = 0; i < 4; i++)
            {
                Component = new Component(4784, "SS_0.4625_InsetCrnBrace", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrDoor";
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

            // AlumCnrBrace
            for (int i = 0; i < 4; i++)
            {
                Component = new Component(4830, "AlumCnrBrace", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrDoor";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            for (int i = 0; i < 16; i++)
            {
                Component = new Component(4833, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrDoor";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrace
            for (int i = 0; i < 4; i++)
            {
                Component = new Component(4831, "AlumCnrBrace", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrDoor";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            // FlatHead_#10x5/8_SheetMetal_18_8_SS
            for (int i = 0; i < 16; i++)
            {
                Component = new Component(4833, "FlatHead_#10x5/8_SheetMetal_18_8_SS", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrDoor";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////


            // SS_0.7049_OutsetCrnBrace 
            for (int i = 0; i < 8; i++)
            {
                Component = new Component(4829, "SS_0.7049_OutsetCrnBrace", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrDoor";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            // FlatHead_8-32x3/16_UndercutHead
            for (int i = 0; i < 32; i++)
            {
                Component = new Component(502, "FlatHead_8-32x3/16_UndercutHead", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrDoor";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Seal/Weatherstripping


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //KfolDrEdge
                Component = new Component(2274, "KfolDrEdge", this, 1, periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //DoorBotPVC

            Component = new Component(1518, "DoorBotPVC", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
            Component.ComponentGroupType = "Seal-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDM_PreSet
                Component = new Component(4314, "EPDM_PreSet", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDM_Wedge
                Component = new Component(4284, "EPDM_Wedge", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
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