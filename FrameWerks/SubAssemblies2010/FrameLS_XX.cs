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

    public class FrameLS_XX : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 2;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.875m;
        const decimal jambDimW = 1.5m;
        const decimal jambInset = 0.375m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEadd = 1.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;

        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_XX()
        {
            subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrameLS_XX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambReduce2X - doorGap2X, 0);

            Component Component;
            string Componentleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region TopTrackY

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackX
            Component = new Component(3406, "TopTrackX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - stileOverLap + doorGap);
            Component.ComponentGroupType = "TopTrackY-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //ShapedYtrackRubber -->> 
            for (int i = 0; i < 2; i++)
            {


                Component = new Component(3766, "ShapedYtrackRubber", this, 1, 0.0m);
                Component.ComponentGroupType = "TopTrackY-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //AlumJambXXDoor -->> 
            for (int i = 0; i < 4; i++)
            {

                Component = new Component(4357, "AlumJambXXDoor", this, 1, m_subAssemblyHieght - calkGap);
                Component.ComponentGroupType = "Frame-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            // FaciaHeadXX ^^
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4362, "FaciaHeadXX", this, 1, m_subAssemblyWidth - jambDimW - jambInset);
                Component.ComponentGroupType = "Frame-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_LS_Seals

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            for (int i = 0; i < 4; i++)
            {

                Component = new Component(4384, "Pile_LS_Seals", this, 1, m_subAssemblyHieght - calkGap);
                Component.ComponentGroupType = "Pile_LS_Seals-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4384, "Pile_LS_Seals", this, 1, m_subAssemblyWidth - jambDimW - jambInset);
                Component.ComponentGroupType = "Pile_LS_Seals-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE_Head

            //////////////////////////////////////////////////////////////////////////////

            string notchHDPE = string.Empty;
            decimal[] temp = new decimal[panelCount + 1];

            for (int i = 1; i < panelCount; i++)
            {

                switch (i)
                {
                    case 1:
                        {
                            temp[1] = trackHelper.DoorPanelWidth + headHDPEadd + notchHDPEadd;
                            notchHDPE = temp[1].ToString() + ",";
                            break;
                        }
                    case 2:
                        {
                            temp[2] = (trackHelper.DoorPanelWidth * 2.0m) - stileOverLap + headHDPEadd + notchHDPEadd;
                            notchHDPE += temp[2].ToString() + ",";
                            break;
                        }
                    case 3:
                        {
                            temp[3] = (trackHelper.DoorPanelWidth * 3.0m) - stileOvrLpX2 + headHDPEadd + notchHDPEadd;
                            notchHDPE += temp[3].ToString() + ",";
                            break;
                        }

                    case 4:
                        {
                            temp[3] = (trackHelper.DoorPanelWidth * 4.0m) - stileOvrLpX3 + headHDPEadd + notchHDPEadd;
                            notchHDPE += temp[3].ToString() + ",";
                            break;
                        }


                    default:
                        break;
                }

            }

            // notchHDPE 
            decimal HDPEnotch = trackHelper.DoorPanelWidth + headHDPEadd + notchHDPEadd;


            // HDPE_Head ^^
            Component = new Component(3442, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * panelCount)  );
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = notchHDPE;
            Component.ComponentThick = 0.75m;
            Component.ComponentWidth = 5.75m;

            m_Components.Add(Component);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
                Component.ComponentGroupType = "HDPE_Head-Components";
                Component.ComponentLabel = "";
                Component.ComponentThick = 0.75m;
                Component.ComponentWidth = 2.875m;

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion


        }


        #endregion

    }


}