
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
using System.Linq;
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.SubAssembliesFASTrcPerft
{
    class FTPXXXX : SubAssemblyBase
    {

        #region Fields



        // The values we can change for different layouts
        const int panelCount = 4;
        const decimal stileWidth = 2.5625m;
        const decimal doorGap = 0.25m;


        #endregion

        #region Math Functions



        #endregion

        #region Constructor

        public FTPXXXX()
        {
            subAssemblyID = Guid.NewGuid();
            this.ModelID = "LiftSlide-FTPXXXX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth, 0);

            BridgeGenie bridgeGenie = new BridgeGenie(2.50m);

            Component Component;
            string Componentleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region BladeSS




            //BladePX

            Component = new Component(3444, "BladePX", this, 1, trackHelper.DoorPanelWidth * 2.0m);
            Component.ComponentGroupType = "BladeSS-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);


            // BladePXX

            Component = new Component(3444, "BladePXX", this, 1, (trackHelper.DoorPanelWidth * 3.0m) - stileWidth);
            Component.ComponentGroupType = "BladeSS-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);


            // BladePXXX

            Component = new Component(3444, "BladePXXX", this, 1, (trackHelper.DoorPanelWidth * 4.0m) - 2.0m * stileWidth);
            Component.ComponentGroupType = "BladeSS-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);


            // BladePXXXX

            Component = new Component(3444, "BladePXXXX", this, 1, (trackHelper.DoorPanelWidth * 5.0m) - 3.0m * stileWidth + doorGap);
            Component.ComponentGroupType = "BladeSS-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);




            #endregion

            #region PerfecTack

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_PX
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4424, "PerfecT_PX", this, 1, trackHelper.DoorPanelWidth * 2.0m);
                Component.ComponentGroupType = "PerfecTack-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_PXX
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4424, "PerfecT_PXX", this, 1, (trackHelper.DoorPanelWidth * 3.0m) - stileWidth);
                Component.ComponentGroupType = "PerfecTack-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_PXXX
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4424, "PerfecT_PXXX", this, 1, (trackHelper.DoorPanelWidth * 4.0m) - 2.0m * stileWidth);
                Component.ComponentGroupType = "PerfecTack-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_PXXXX
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4424, "PerfecT_PXXXX", this, 1, (trackHelper.DoorPanelWidth * 5.0m) - 3.0m * stileWidth + doorGap);
                Component.ComponentGroupType = "PerfecTack-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Drains

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //Drains

            for (int i = 0; i < trackHelper.DrainCount; i++)
            {
                Component = new Component(4465, "Drains", this, 1, 0.0m);
                Component.ComponentGroupType = "Drains-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }


            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region BridgeAssemble

            //BridgeAssemble

            for (int i = 1; i < panelCount + 1; i++)
            {
                //Bridge

                if (i > 1)
                {
                    decimal waste = decimal.Zero;
                    for (int j = 1; j < trackHelper.BridgeCount + 1; j++)
                    {
                        Component = new Component(3445, "Bridge", this, 1, bridgeGenie.result[i - 1]);
                        Component.ComponentGroupType = "BridgeAssemble-Components";
                        Component.ComponentLabel = "";
                        m_Components.Add(Component);
                        waste += 0.125m;
                    }
                    Component = new Component(3445, "Cutting Waste", this, 1, waste);
                    m_Components.Add(Component);
                }

                else
                {
                    decimal waste = decimal.Zero;
                    for (int j = 1; j < trackHelper.BridgeCount + 1; j++)
                    {
                        Component = new Component(3445, "Bridge", this, 1, bridgeGenie.result[i - 1]);
                        Component.ComponentGroupType = "BridgeAssemble-Components";
                        Component.ComponentLabel = "";

                        m_Components.Add(Component);
                        waste += 0.125m;
                    }
                    Component = new Component(3445, "Cutting Waste", this, 1, waste);
                    m_Components.Add(Component);
                }
                //BridgeClips

                if (i > 1)
                {

                    Component = new Component(5432, "BridgeClips", this, trackHelper.BridgeCount * 2, 0.0m);
                    Component.ComponentGroupType = "BridgeAssemble-Components";
                    Component.ComponentLabel = "";

                    m_Components.Add(Component);

                }

                else
                {

                    Component = new Component(5432, "BridgeClips", this, trackHelper.BridgeCount * 2, 0.0m);
                    Component.ComponentGroupType = "BridgeAssemble-Components";
                    Component.ComponentLabel = "";

                    m_Components.Add(Component);

                }


                //TrackBolts

                if (i > 1)
                {
                    Component = new Component(3451, "TrackBolts", this, trackHelper.BridgeCount * 2, 0.0m);
                    Component.ComponentGroupType = "BridgeAssemble-Components";
                    Component.ComponentLabel = "";

                    m_Components.Add(Component);
                }
                else
                {
                    Component = new Component(3451, "TrackBolts", this, trackHelper.BridgeCount * 2, 0.0m);
                    Component.ComponentGroupType = "BridgeAssemble-Components";
                    Component.ComponentLabel = "";

                    m_Components.Add(Component);
                }



                //TrackClips

                Component = new Component(3447, "TrackClips", this, trackHelper.BridgeCount * i * 2, 0.0m);
                Component.ComponentGroupType = "BridgeAssemble-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);



                Component = new Component(3449, "CapScrews", this, trackHelper.BridgeCount * i * 2, 0.0m);
                Component.ComponentGroupType = "BridgeAssemble-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);



                //FlangeNuts

                if (i > 1)
                {
                    Component = new Component(3450, "FlangeNuts", this, trackHelper.BridgeCount * 4, 0.0m);
                    Component.ComponentGroupType = "BridgeAssemble-Components";
                    Component.ComponentLabel = "";

                    m_Components.Add(Component);

                }
                else
                {
                    Component = new Component(3450, "FlangeNuts", this, trackHelper.BridgeCount * 4, 0.0m);
                    Component.ComponentGroupType = "BridgeAssemble-Components";
                    Component.ComponentLabel = "";

                    m_Components.Add(Component);
                }


                //NutPlateConnector

                if (i > 1 && i != panelCount)
                {
                    // your the second door but NOT second to last
                    if (i >= 3 && i < (panelCount - 1))
                    {
                        Component = new Component(5433, "NutPlateConnector", this, trackHelper.BridgeCount * (panelCount - 2), 0.0m);
                        Component.ComponentGroupType = "BridgeAssemble-Components";
                        Component.ComponentLabel = "";

                        m_Components.Add(Component);
                    }
                    // your the second door but ARE second to last
                    else
                    {
                        Component = new Component(5433, "NutPlateConnector", this, trackHelper.BridgeCount * (panelCount - 2), 0.0m);
                        Component.ComponentGroupType = "BridgeAssemble-Components";
                        Component.ComponentLabel = "";

                        m_Components.Add(Component);

                    }




                }
            }

            #endregion

            #region PocBrdgAssY

            //PocBrdgAssY

            //Bridge

            decimal CutWaste = decimal.Zero;
            for (int j = 1; j < trackHelper.BridgeCount + 1; j++)
            {
                Component = new Component(3445, "BridgePoc", this, 1, bridgeGenie.result[panelCount - 1]);
                Component.ComponentGroupType = "PocBrdgAssY-Components";
                Component.ComponentLabel = "";
                m_Components.Add(Component);
                CutWaste += 0.125m;
            }
            Component = new Component(3445, "CutPocWaste", this, 1, CutWaste);
            m_Components.Add(Component);

            //BridgeClips

            Component = new Component(5432, "BridgeClipsPoc", this, trackHelper.BridgeCount * 2, 0.0m);
            Component.ComponentGroupType = "PocBrdgAssY-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            //TrackClips
            Component = new Component(3447, "TrackClipsPoc", this, trackHelper.BridgeCount * panelCount * 2, 0.0m);
            Component.ComponentGroupType = "PocBrdgAssY-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            //NutPlateConnector

            // your the second door but NOT second to last

            Component = new Component(5433, "NutPlateConPoc", this, (trackHelper.BridgeCount) * (panelCount - 2), 0.0m);
            Component.ComponentGroupType = "PocBrdgAssY-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            //CapScrews

            Component = new Component(3449, "CapScrewsPoc", this, trackHelper.BridgeCount * panelCount * 2, 0.0m);
            Component.ComponentGroupType = "PocBrdgAssY-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            //FlangeNuts
            Component = new Component(3450, "FlangeNutsPoc", this, trackHelper.BridgeCount * 4, 0.0m);
            Component.ComponentGroupType = "PocBrdgAssY-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            //TrackBolts
            Component = new Component(3451, "TrackBoltsPoc", this, trackHelper.BridgeCount * 2, 0.0m);
            Component.ComponentGroupType = "PocBrdgAssY-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);



            #endregion

        }

        #endregion


    }
}
