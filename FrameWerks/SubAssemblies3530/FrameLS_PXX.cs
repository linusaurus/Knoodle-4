#region Copyright (c) 2014 WeaselWare Software
/************************************************************************************
'
' Copyright  2014 WeaselWare Software 
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
' Portions Copyright 2014 WeaselWare Software
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

namespace FrameWorks.Makes.System3530
{

    public class FrameLS_PXX : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const int panelCount = 2;
        const decimal faceCapX = 3.625m;
        const decimal facEndCap = 2.875m;
        const decimal facEndAcc = 2.9375m;
        const decimal stileOverLap = 2.2530m;
        const decimal stileOvrLpX2 = 2.2530m * 2.50m;
        const decimal doorGap = 0.25m;
        const decimal jambDimW = 1.5m;
        const decimal jambInset = 0.375m;
        const decimal spltHdRed = 6.5275m;
        const decimal faceXdoor = 4.1525m;
        const decimal pockYtrackAdd = 4.0m;
        const decimal yTrAccess = 2.1525m;
        const decimal notchHDPEadd = 4.0587m;
        const decimal headHDPEadd = 1.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;
        const decimal pocketClose = 3.063m;

        #endregion

        #region Constructor

        public FrameLS_PXX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "3530-FrameLS_PXX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {


            {


                TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth, 0);

                Part part;
                string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



                #region TopTrackY

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                //TopTrackYXX
                part = new Part(3406, "TopTrackYXX", this, 1, (trackHelper.DoorPanelWidth * 3.0m) - stileOvrLpX2 + pockYtrackAdd + doorGap);
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

                //TopTrackYX
                part = new Part(3406, "TopTrackYX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - stileOverLap + pockYtrackAdd + yTrAccess);
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

                //////////////////////////////////////////////////////////////////////////////

                //ShapedYtrackRubber -->> 
                for (int i = 0; i < 2; i++)
                {


                    part = new Part(3766, "ShapedYtrackRubber", this, 1, 0.0m);
                    part.PartGroupType = "TopTrackY-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                //////////////////////////////////////////////////////////////////////////////

                #endregion


                #region Frame-Parts

                //////////////////////////////////////////////////////////////////////////////

                //BzJambXDoor -->> 
                for (int i = 0; i < 2; i++)
                {


                    part = new Part(4363, "BzJambXDoor", this, 1, m_subAssemblyHieght - calkGap);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                //////////////////////////////////////////////////////////////////////////////

                //BzJambPoc -->> 
                for (int i = 0; i < 2; i++)
                {


                    part = new Part(4363, "BzJambPoc", this, 1, m_subAssemblyHieght - calkGap);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                ////////////////////////////////////////////////////////////////////////////////

                // FaciaHeadInt ^^
                part = new Part(4364, "FaciaHeadInt", this, 1, m_subAssemblyWidth - jambDimW - jambDimW);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

                ////////////////////////////////////////////////////////////////////////////////

                // FaciaHeadExtXX ^^
                part = new Part(4364, "FaciaHeadExtXX", this, 1, (trackHelper.DoorPanelWidth) - jambInset - spltHdRed);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

                ////////////////////////////////////////////////////////////////////////////////

                // FaciaHeadExtX ^^
                part = new Part(4364, "FaciaHeadExtX", this, 1, (trackHelper.DoorPanelWidth) + faceXdoor - jambInset);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

                ////////////////////////////////////////////////////////////////////////////////

                // FaciaCapX ^^
                for (int i = 0; i < 1; i++)
                {
                    part = new Part(4364, "FaciaCapX", this, 1, faceCapX);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                ////////////////////////////////////////////////////////////////////////////////

                // FaciAccess ^^
                for (int i = 0; i < 1; i++)
                {
                    part = new Part(4364, "FaciAccess", this, 1, facEndAcc);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                ////////////////////////////////////////////////////////////////////////////////

                // FacEndCap ^^
                for (int i = 0; i < 1; i++)
                {
                    part = new Part(4364, "FacEndCap", this, 1, facEndCap);
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
                                temp[1] = trackHelper.DoorPanelWidth * 2.0m + pockYtrackAdd + notchHDPEadd;
                                notchHDPE = temp[1].ToString() + ",";
                                break;
                            }
                        case 2:
                            {
                                temp[2] = (trackHelper.DoorPanelWidth * 3.0m) - stileOverLap + pockYtrackAdd + notchHDPEadd;
                                notchHDPE += temp[2].ToString() + ",";
                                break;
                            }
                        case 3:
                            {
                                temp[3] = (trackHelper.DoorPanelWidth * 4.0m) - stileOverLap * 2.0m + pockYtrackAdd + headHDPEadd + notchHDPEadd;
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
                part = new Part(3454, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * 3.0m) - stileOverLap + pockYtrackAdd + doorGap + headHDPEadd);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "Notch @ " + notchHDPE;
                part.PartThick = 0.75m;
                part.PartWidth = 5.75m;

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


                #region Pocket_CloseOut-Parts

                ////////////////////////////////////////////////////////////////////////////////////////////

                //BzCloseOut -->>  
                for (int i = 0; i < 1; i++)
                {

                    part = new Part(911, "BzCloseOut", this, 1, m_subAssemblyHieght, pocketClose);
                    part.PartGroupType = "Pocket_CloseOut-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                ////////////////////////////////////////////////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////////////////////

                // SumChit ^^
                part = new Part(911, "SumChit", this, 1, m_subAssemblyHieght, pocketClose);
                part.PartGroupType = "Pocket_CloseOut-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

                ////////////////////////////////////////////////////////////////////////////////////////////


                #endregion



            }

        }



        #endregion


    }
}