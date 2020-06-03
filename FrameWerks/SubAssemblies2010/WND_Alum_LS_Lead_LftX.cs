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
using FrameWorks.Makes.System2010;


namespace FrameWorks.Makes.System2010
{

    public class WND_Alum_LS_Lead_LftX : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;

        const decimal stopReduceX2 = 2.0m * 2.25m;
        const decimal glassReduceX2 = 2.0m * 2.59375m;


        #endregion

        #region Constructor

        public WND_Alum_LS_Lead_LftX()
        {
            subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-WND_Alum_LS_Lead_LftX";
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

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region DoorAlumTB

            // StileLeft
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4355, "StileLeft", this, 1, m_subAssemblyHieght);
                Component.ComponentGroupType = "DoorAlumTB-Components";
                Component.ComponentLabel = "1) Miter Ends";
                m_Components.Add(Component);

            }

            // StileRight

            ///////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                Component = new Component(4355, "StileRight", this, 1, m_subAssemblyHieght);
                Component.ComponentGroupType = "DoorAlumTB-Components";
                Component.ComponentLabel = "1) Miter Ends";

                m_Components.Add(Component);

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailTop
            for (int i = 0; i < 1; i++)
            {

                Component = new Component(4355, "RailTop", this, 1, m_subAssemblyWidth);
                Component.ComponentGroupType = "DoorAlumTB-Components";
                Component.ComponentLabel = "1) Miter Ends ";

                m_Components.Add(Component);

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailBot
            for (int i = 0; i < 1; i++)
            {

                Component = new Component(4355, "RailBot", this, 1, m_subAssemblyWidth);
                Component.ComponentGroupType = "DoorAlumTB-Components";
                Component.ComponentLabel = "1) Miter Ends ";

                m_Components.Add(Component);

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region StopAlum


            // AlumGlsStpVert
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4341, "AlumGlsStpVert", this, 1, m_subAssemblyHieght - stopReduceX2);
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
                Component = new Component(4341, "AlumGlsStpTopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
                Component.ComponentGroupType = "StopAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HDPE

            // HDPE_LS_LockEdge
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4266, "HDPE_LS_LockEdge", this, 1, m_subAssemblyHieght);
                Component.ComponentGroupType = "HDPE-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = labelStileL = "";

                m_Components.Add(Component);
            }

            // HDPETop
            //for (int i = 0; i < 1; i++)
            //{


            //Component = new Component(3762, "HDPETop", this, 1, m_subAssemblyWidth);
            //Component.ComponentGroupType = "HDPE-Components";
            //Component.ComponentWidth = Component.Source.Width;
            //Component.ComponentThick = Component.Source.Height;
            //Component.ComponentLabel = labelStileR = "";

            //m_Components.Add(Component);

            //}

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

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

            // AlumCnrBrace
            for (int i = 0; i < 4; i++)
            {
                Component = new Component(4831, "AlumCnrBrace", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrDoor";
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

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region GuidesTop

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // TopGuide4440

            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4440, "TopGuide4440", this, 1, 0.0m);
                Component.ComponentGroupType = "GuidesTop-Components";
                Component.ComponentLabel = "4440_LockStile";

                m_Components.Add(Component);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // TopGuide5212

            for (int i = 0; i < 1; i++)
            {
                Component = new Component(5212, "TopGuide5212", this, 1, 0.0m);
                Component.ComponentGroupType = "GuidesTop-Components";
                Component.ComponentLabel = "5212_Overlap";

                m_Components.Add(Component);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HookCap

            // EndCap

            Component = new Component(4397, "EndCap", this, 1, m_subAssemblyHieght );
            Component.ComponentGroupType = "HookCap-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            // HookStrip

            Component = new Component(3710, "HookStrip", this, 1, m_subAssemblyHieght + 0.0625m);
            Component.ComponentGroupType = "HookCap-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Glass

            //Glass Panel
            Component = new Component(3300);
            Component.FunctionalName = "Glass";
            Component.ComponentGroupType = "Glass-Components";
            Component.Qnty = 1;
            Component.ContainerAssembly = this;
            Component.ComponentWidth = m_subAssemblyWidth - glassReduceX2;
            Component.ComponentLength = m_subAssemblyHieght - glassReduceX2;
            Component.ComponentThick = 1.25m;

            m_Components.Add(Component);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HardWare Logic


            // LiftSlideGear

            Component = new Component(3958, "LiftSlideGear", this, 1, m_subAssemblyHieght);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            /////////////////////

            // CoverExtension

            if (m_subAssemblyHieght >= 104.0m)
            {
                int c;
                decimal result = decimal.Zero;
                result = (m_subAssemblyHieght - 104.0m);
                result = decimal.Divide(result, 24.0m);
                if (result > 0.0m && result < 24.0m)
                {
                    c = 1;
                }

                else
                {
                    c = Convert.ToInt32(Math.Round(result, 0)) + 1;
                }

                Component = new Component(3430, "CoverExtension", this, c, 24.0m);

                Component.ComponentGroupType = "Hardware-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);
            }
            ///////////////////////

            // LockBoltKits

            Component = new Component(3431, "LockBoltKits", this, 2, m_subAssemblyHieght);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            // ShimsLockBolt

            Component = new Component(3383, "ShimsLockBolt", this, 2, m_subAssemblyHieght);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            // CarrageKit

            Component = new Component(3422, "CarrageKit", this, 1, m_subAssemblyWidth);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);


            /////////////////////


            // LinkRod


            if (m_subAssemblyWidth >= 25.5m && m_subAssemblyWidth < 130.0m)
            {
                if (m_subAssemblyWidth >= 25.5m && m_subAssemblyWidth <= 50.0m)
                {
                    Component = new Component(3423, "LinkRod", this, 1, m_subAssemblyWidth);
                }
                if (m_subAssemblyWidth > 50.0m && m_subAssemblyWidth <= 78.0m)
                {
                    Component = new Component(2100, "LinkRod", this, 1, m_subAssemblyWidth);
                }
                if (m_subAssemblyWidth > 78.0m && m_subAssemblyWidth <= 130.0m)
                {
                    Component = new Component(3424, "LinkRod", this, 1, m_subAssemblyWidth);
                }

            }
            else
            {
                Component = new Component(911, "LinkRod", this, 1, m_subAssemblyWidth);
            }


            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);



            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Seal/Weatherstripping

            //GlazPreSetEPDM

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.7313m, m_subAssemblyWidth - 2.7313m);

                Component = new Component(4314, "GlazPreSetEPDM", this, 1, peri);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            //GlazWedgEPDM

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.6286m, m_subAssemblyWidth - 2.6286m);

                Component = new Component(4399, "GlazWedgEPDM", this, 1, peri);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Edge & Bottom Seal

            for (int i = 0; i < 2; i++)
            {

                Component = new Component(1005, "Edge & Bottom Seal", this, 1, m_subAssemblyHieght + m_subAssemblyWidth);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Top Seal

            for (int i = 0; i < 2; i++)
            {


                Component = new Component(3783, "Top Seal", this, 1, m_subAssemblyWidth);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            // HookPileT+Fin

            for (int i = 0; i < 2; i++)
            {

                Component = new Component(3959, "HookPileT+Fin", this, 1, m_subAssemblyHieght + 0.0625m);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////


        }
        #endregion

    }

}