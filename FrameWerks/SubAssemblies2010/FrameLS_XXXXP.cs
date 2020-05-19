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

namespace FrameWorks.Makes.System2010
{

    public class FrameLS_XXXXP : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 4;
        const decimal faceCapX = 3.625m;
        const decimal facEndCap = 2.875m;
        const decimal facEndAcc = 2.9375m;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.875m;
        const decimal jambDimW2X = 1.5m * 2.0m;
        const decimal jambInset = 0.375m;
        const decimal spltHdRed = 6.9173m;
        const decimal faceMidoor = 2.4375m;
        const decimal faceXdoor = 4.4798m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEadd = 1.0m;
        const decimal calkGap = 0.125m;
        const decimal trackAddPocket = 4.1048m;
        const decimal trackAddOvTrav = 2.5m;


        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_XXXXP()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrameLS_XXXXP";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambReduce2X - doorGap2X, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region TopTrackUni

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackPXXXX
            part = new Part(3406, "TopTrackPXXXX", this, 1, (trackHelper.DoorPanelWidth * 5.0m - stileOvrLpX3) + trackAddPocket + doorGap);
            part.PartGroupType = "TopTrackUni-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackPXXX
            part = new Part(3406, "TopTrackPXXX", this, 1, (trackHelper.DoorPanelWidth * 4.0m - stileOvrLpX2) + trackAddPocket + trackAddOvTrav);
            part.PartGroupType = "TopTrackUni-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackPXX
            part = new Part(3406, "TopTrackPXX", this, 1, (trackHelper.DoorPanelWidth * 3.0m - stileOverLap) + trackAddPocket + trackAddOvTrav);
            part.PartGroupType = "TopTrackUni-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackPX
            part = new Part(3406, "TopTrackPX", this, 1, (trackHelper.DoorPanelWidth * 2.0m + trackAddPocket + trackAddOvTrav));
            part.PartGroupType = "TopTrackUni-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //ShapedYtrackRubber -->> 
            //for (int i = 0; i < 2; i++)
            //{


            //part = new Part(3766, "ShapedYtrackRubber", this, 1, 0.0m);
            //part.PartGroupType = "TopTrackY-Parts";
            //part.PartLabel = "";

            //m_parts.Add(part);

            //}

            //////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Over_Travel

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Left
            for (int i = 0; i < 3; i++)
            {
                part = new Part(5272, "OTB_Left", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Filler
            for (int i = 0; i < 3; i++)
            {
                part = new Part(5271, "OTB_Filler", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //AlumJambXXDoor -->> 
            for (int i = 0; i < 4; i++)
            {

                part = new Part(4357, "AlumJambXXDoor", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // FaciaHeadXXXX ^^
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4362, "FaciaHeadXXXX", this, 1, m_subAssemblyWidth - jambDimW2X);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadExtXXXX ^^
            part = new Part(4362, "FaciaHeadExtXXXX", this, 1, (trackHelper.DoorPanelWidth) - jambInset - spltHdRed);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            ////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadExtXXX ^^
            part = new Part(4362, "FaciaHeadExtXXX", this, 1, (trackHelper.DoorPanelWidth) - faceMidoor);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadExtXX ^^
            part = new Part(4362, "FaciaHeadExtXX", this, 1, (trackHelper.DoorPanelWidth) - faceMidoor);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////


            // FaciaHeadExtX ^^
            part = new Part(4362, "FaciaHeadExtX", this, 1, (trackHelper.DoorPanelWidth) + faceXdoor - jambInset);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            ////////////////////////////////////////////////////////////////////////////////

            // FaciaCapX ^^
            for (int i = 0; i < 3; i++)
            {
                part = new Part(4362, "FaciaCapX", this, 1, faceCapX);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // FaciAccess ^^
            for (int i = 0; i < 3; i++)
            {
                part = new Part(4362, "FaciAccess", this, 1, facEndAcc);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // FacEndCap ^^
            for (int i = 0; i < 3; i++)
            {
                part = new Part(4362, "FacEndCap", this, 1, facEndCap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_LS_Seals

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            for (int i = 0; i < 4; i++)
            {

                part = new Part(4384, "Pile_LS_Seals", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Pile_LS_Seals-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4384, "Pile_LS_Seals", this, 1, m_subAssemblyWidth - jambDimW2X);
                part.PartGroupType = "Pile_LS_Seals-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(4384, "Pile_LS_Seals", this, 1, (trackHelper.DoorPanelWidth) - jambInset - spltHdRed);
            part.PartGroupType = "Pile_LS_Seals-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(4384, "Pile_LS_Seals", this, 1, (trackHelper.DoorPanelWidth) - faceMidoor);
            part.PartGroupType = "Pile_LS_Seals-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            part = new Part(4384, "Pile_LS_Seals", this, 1, (trackHelper.DoorPanelWidth) - faceMidoor);
            part.PartGroupType = "Pile_LS_Seals-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////


            // Pile_LS_Seals ^^
            part = new Part(4384, "Pile_LS_Seals", this, 1, (trackHelper.DoorPanelWidth) + faceXdoor - jambInset);
            part.PartGroupType = "Pile_LS_Seals-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            for (int i = 0; i < 3; i++)
            {
                part = new Part(4384, "Pile_LS_Seals", this, 1, faceCapX);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            for (int i = 0; i < 3; i++)
            {
                part = new Part(4384, "Pile_LS_Seals", this, 1, facEndAcc);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            for (int i = 0; i < 3; i++)
            {
                part = new Part(4384, "Pile_LS_Seals", this, 1, facEndCap);
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
            part = new Part(3442, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * 4.0m) + jambReduce2X + doorGap2X + doorGap);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 2.875m;

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            //for (int i = 0; i < 2; i++)
            //{
            //part = new Part(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
            //part.PartGroupType = "HDPE_Head-Parts";
            //part.PartLabel = "";
            //part.PartThick = 0.75m;
            //part.PartWidth = 2.875m;

            //m_parts.Add(part);

            //}

            //////////////////////////////////////////////////////////////////////////////

            #endregion


        }


        #endregion

    }


}