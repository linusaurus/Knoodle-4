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

namespace FrameWorks.Makes.System3340
{

    public class FrameSlideXOX : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        // The values we can change for different layouts
        const int panelCount = 3;
        const decimal faceCapX = 3.625m;
        const decimal facEndCap = 4.0m;
        const decimal facEndAcc = 4.0625m;
        const decimal stileOverLap = 1.125m;
        const decimal stileOvrLpX2 = 2.0m * 1.125m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * .875m;
        const decimal jambInset = 0.375m;
        const decimal jambCvrBrz = 0.0625m;
        const decimal spltHdRed = 5.1276m;
        const decimal faceXdoor = 4.1275m;
        const decimal endCap = 0.1276m;
        const decimal pockYtrackAdd = 4.0m;
        const decimal yTrAccess = 2.0m;
        const decimal notchHDPEadd = 4.0025m;
        const decimal headHDPEadd = 1.0m;
        const decimal reducHDPE = 0.875m;
        const decimal calkGap = 0.125m;



        #endregion

        #region Constructor

        public FrameSlideXOX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3340-FrameSlideXOX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambReduce2X - doorGap2X, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region TopTrackY

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //TopTrackYXO
            part = new Part(4447, "TopTrackYXO", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - reducHDPE - endCap + doorGap + yTrAccess);
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            //TopTrackO
            part = new Part(4447, "TopTrackO", this, 1, (trackHelper.DoorPanelWidth * 1.0m) + endCap * 2.0m + yTrAccess);
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // TopTrackYOX
            part = new Part(4447, "TopTrackYOX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - reducHDPE - endCap + doorGap + yTrAccess);
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //ShapedYtrackRubber -->> 
            for (int i = 0; i < 4; i++)
            {


                part = new Part(3766, "ShapedYtrackRubber", this, 1, 0.0m);
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //Jamb_4363_XDoor -->> 
            for (int i = 0; i < 4; i++)
            {


                part = new Part(4363, "Jamb_4363_XDoor", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // FaciaHd_4364_ExtXO_OX ^^

            for (int i = 0; i < 2; i++)
            {
                part = new Part(4364, "FaciaHd_4364_ExtXO_OX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - stileOverLap - jambInset + faceXdoor);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaHd_4364_ExtX_O_X ^^

            for (int i = 0; i < 2; i++)
            {

                part = new Part(4364, "FaciaHd_4364_ExtX_O_X", this, 1, (trackHelper.DoorPanelWidth) - jambInset - spltHdRed);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // Facia_4364_CapX ^^
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4364, "Facia_4364_CapX", this, 1, faceCapX);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // Facia_4364_Access ^^
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4364, "Facia_4364_Access", this, 1, facEndAcc);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // Face_4364_EndCap ^^
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4364, "Face_4364_EndCap", this, 1, facEndCap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

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
                            temp[1] = trackHelper.DoorPanelWidth * 2.0m + pockYtrackAdd - jambInset + endCap + notchHDPEadd;
                            notchHDPE = temp[1].ToString() + ",";
                            break;
                        }
                    case 2:
                        {
                            temp[2] = (trackHelper.DoorPanelWidth * 3.0m) - stileOverLap - jambInset + pockYtrackAdd + endCap + notchHDPEadd;
                            notchHDPE += temp[2].ToString() + ",";
                            break;
                        }
                    case 3:
                        {
                            temp[3] = (trackHelper.DoorPanelWidth * 4.0m) - stileOvrLpX2 - jambInset + pockYtrackAdd + endCap + headHDPEadd + notchHDPEadd;
                            notchHDPE += temp[3].ToString() + ",";
                            break;
                        }

                    default:
                        break;
                }

            }

            // notchHDPE 
            decimal HDPEnotch = trackHelper.DoorPanelWidth + headHDPEadd + notchHDPEadd;


            // HDPEHead ^^
            part = new Part(3454, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * 4.0m) + (doorGap + jambCvrBrz + endCap) - (stileOvrLpX2 - jambInset));
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "Notch @ " + notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 6.125m;

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
                part.PartGroupType = "HDPE_Head-Parts";
                part.PartLabel = "";
                part.PartThick = 0.75m;


                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////



            #endregion


        }


        #endregion

    }


}