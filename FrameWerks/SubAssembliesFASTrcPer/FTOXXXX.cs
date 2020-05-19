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
    class FTOXXXX : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const int panelCount = 5;
        const decimal stileWidth = 2.5625m;
        const decimal bladeAdd = 1.0m;


        #endregion

        #region Math Functions



        #endregion

        #region Constructor

        public FTOXXXX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "LiftSlide-FTOXXXX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth, 0);

            BridgeGenie bridgeGenie = new BridgeGenie(2.50m);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region BladeSS


            //BladeO

            part = new Part(3444, "BladeO", this, 1, trackHelper.DoorPanelWidth + bladeAdd);
            part.PartGroupType = "BladeSS-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // BladeOX

            part = new Part(3444, "BladeOX", this, 1, (trackHelper.DoorPanelWidth * 2) - stileWidth + bladeAdd);
            part.PartGroupType = "BladeSS-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // BladeOXX

            part = new Part(3444, "BladeOXX", this, 1, (trackHelper.DoorPanelWidth * 3) - stileWidth * 2 + bladeAdd);
            part.PartGroupType = "BladeSS-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // BladeOXXX

            part = new Part(3444, "BladeOXXX", this, 1, (trackHelper.DoorPanelWidth * 4) - stileWidth * 3 + bladeAdd);
            part.PartGroupType = "BladeSS-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // BladeOXXXX

            part = new Part(3444, "BladeOXXX", this, 1, (trackHelper.DoorPanelWidth * 5) - stileWidth * 4 + bladeAdd * 2.0m);
            part.PartGroupType = "BladeSS-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion

            #region PerfecTack

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_O
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4424, "PerfecT_O", this, 1, trackHelper.DoorPanelWidth + bladeAdd);
                part.PartGroupType = "PerfecTack-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_OX
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4424, "PerfecT_OX", this, 1, (trackHelper.DoorPanelWidth * 2) - stileWidth + bladeAdd);
                part.PartGroupType = "PerfecTack-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_OXX
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4424, "PerfecT_OXX", this, 1, (trackHelper.DoorPanelWidth * 3) - stileWidth * 2 + bladeAdd);
                part.PartGroupType = "PerfecTack-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_OXXX
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4424, "PerfecT_OXXX", this, 1, (trackHelper.DoorPanelWidth * 4) - stileWidth * 3 + bladeAdd);
                part.PartGroupType = "PerfecTack-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //PerfecT_OXXXX
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4424, "PerfecT_OXXXX", this, 1, (trackHelper.DoorPanelWidth * 5) - stileWidth * 4 + bladeAdd * 2.0m);
                part.PartGroupType = "PerfecTack-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Drains

            //////////////////////////////////////////////////////////////////////////////////////////////////

            //Drains

            for (int i = 0; i < trackHelper.DrainCount; i++)
            {
                part = new Part(4465, "Drains", this, 1, 0.0m);
                part.PartGroupType = "Drains-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

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
                        part = new Part(3445, "Bridge", this, 1, bridgeGenie.result[i - 1]);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";
                        m_parts.Add(part);
                        waste += 0.125m;
                    }
                    part = new Part(3445, "Cutting Waste", this, 1, waste);
                    m_parts.Add(part);
                }

                else
                {
                    decimal waste = decimal.Zero;
                    for (int j = 1; j < trackHelper.BridgeCount + 1; j++)
                    {
                        part = new Part(3445, "Bridge", this, 1, bridgeGenie.result[i - 1]);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";

                        m_parts.Add(part);
                        waste += 0.125m;
                    }
                    part = new Part(3445, "Cutting Waste", this, 1, waste);
                    m_parts.Add(part);
                }

                //BridgeClips

                if (i > 1)
                {

                    part = new Part(5432, "BridgeClips", this, trackHelper.BridgeCount * 2, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                else
                {

                    part = new Part(5432, "BridgeClips", this, trackHelper.BridgeCount * 2, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }


                //TrackBolts

                if (i > 1)
                {
                    part = new Part(3451, "TrackBolts", this, trackHelper.BridgeCount * 2, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);
                }
                else
                {
                    part = new Part(3451, "TrackBolts", this, trackHelper.BridgeCount * 2, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);
                }



                //TrackClips

                part = new Part(3447, "TrackClips", this, trackHelper.BridgeCount * i * 2, 0.0m);
                part.PartGroupType = "BridgeAssemble-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                part = new Part(3449, "CapScrews", this, trackHelper.BridgeCount * i * 2, 0.0m);
                part.PartGroupType = "BridgeAssemble-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                //FlangeNuts

                if (i > 1)
                {
                    part = new Part(3450, "FlangeNuts", this, trackHelper.BridgeCount * 4, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }
                else
                {
                    part = new Part(3450, "FlangeNuts", this, trackHelper.BridgeCount * 4, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);
                }


                //NutPlateConnector

                if (i > 1 && i != panelCount)
                {
                    // your the second door but NOT second to last
                    if (i >= 2 && i < (panelCount - 1))
                    {
                        part = new Part(5433, "NutPlateConnector", this, trackHelper.BridgeCount * (panelCount - 2), 0.0m);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";

                        m_parts.Add(part);
                    }
                    // your the second door but ARE second to last
                    else
                    {
                        part = new Part(5433, "NutPlateConnector", this, trackHelper.BridgeCount * (panelCount - 2), 0.0m);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";

                        m_parts.Add(part);

                    }




                }
            }

            #endregion


        }

    }

        #endregion


}


