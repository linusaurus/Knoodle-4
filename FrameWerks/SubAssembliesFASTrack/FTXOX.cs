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
using System.Linq;
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.SubAssembliesFASTrack
{
    class FTXOX : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const int panelCount = 3;
        const decimal stileWidth = 2.5625m;
        const decimal bladeAdd = 0.75m;
        const decimal gapNCvr = 0.3125m;

        #endregion

        #region Math Functions


        #endregion

        #region Constructor

        public FTXOX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "LiftSlide-FTXOX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth, 0);

            BridgeGenie bridgeGenie = new BridgeGenie(2.25m);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region BladeSS

            // BladeX0

            part = new Part(3444, "BladeX0", this, 1, trackHelper.DoorPanelWidth * 2.0m - stileWidth + bladeAdd + gapNCvr);
            part.PartGroupType = "BladeSS-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //BladeO

            part = new Part(3444, "BladeO", this, 1, (trackHelper.DoorPanelWidth));
            part.PartGroupType = "BladeSS-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // BladeOX

            part = new Part(3444, "BladeOX", this, 1, trackHelper.DoorPanelWidth * 2.0m - stileWidth + bladeAdd + gapNCvr);
            part.PartGroupType = "BladeSS-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion


            #region BridgeAssemble

            //BridgeAssemble

            //////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////////////////////////


            for (int i = 1; i < panelCount + 1; i++)
            {
                //Bridge

                if (i > 1)
                {
                    decimal waste = decimal.Zero;
                    for (int j = 1; j < trackHelper.BridgeCount + 2; j++)
                    {
                        part = new Part(3445, "Bridge", this, 1, bridgeGenie.result[i - 1]);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";
                        m_parts.Add(part);
                        waste += 0.125m;
                    }
                    part = new Part(3445, "Cutting Waste", this, 2, waste);
                    m_parts.Add(part);
                }

                else
                {
                    decimal waste = decimal.Zero;
                    for (int j = 1; j < trackHelper.BridgeCount + 2; j++)
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

                //////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////

                //BridgeClips

                if (i > 1)
                {

                    part = new Part(3446, "BridgeClips", this, trackHelper.BridgeCount * 2, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                else
                {

                    part = new Part(3446, "BridgeClips", this, trackHelper.BridgeCount * 2, 0.0m);
                    part.PartGroupType = "BridgeAssemble-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                ///////////////////////////////////////////////////////////////////////////////////
                //TrackBolts

                //if (i > 1)
                //{
                //part = new Part(3451, "TrackBolts", this, trackHelper.BridgeCount * 2, 0.0m);
                //part.PartGroupType = "BridgeAssemble-Parts";
                //part.PartLabel = "";

                //m_parts.Add(part);
                //}
                //else
                //{
                //part = new Part(3451, "TrackBolts", this, trackHelper.BridgeCount * 2, 0.0m);
                //part.PartGroupType = "BridgeAssemble-Parts";
                //part.PartLabel = "";

                //m_parts.Add(part);
                //}
                ///////////////////////////////////////////////////////////////////////////////////


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
                        part = new Part(3448, "NutPlateConnector", this, trackHelper.BridgeCount * (panelCount - 2), 0.0m);
                        part.PartGroupType = "BridgeAssemble-Parts";
                        part.PartLabel = "";

                        m_parts.Add(part);
                    }
                    // your the second door but ARE second to last
                    else
                    {
                        part = new Part(3448, "NutPlateConnector", this, trackHelper.BridgeCount * (panelCount - 2), 0.0m);
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
