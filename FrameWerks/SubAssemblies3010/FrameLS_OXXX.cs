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

namespace FrameWorks.Makes.System3010
{

    public class FrameLS_OXXX : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        // The values we can change for different layouts
        const int panelCount = 4;
        const decimal FaciaCap11 = 3.625m;
        const decimal FaciaCap10 = 2.875m;
        const decimal FaciaCap9 = 2.9375m;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal stileOvrLpX3 = 3.0m * 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.875m;
        const decimal jambDimW = 1.5m;
        const decimal jambToFW = 1.1250m;
        const decimal jambInset = 0.375m;
        const decimal spltHdRed = 6.965m;
        const decimal spltMdidRed = 2.4375m;
        const decimal yTrack = 2.0m;
        const decimal yTrAccess = 4.1525m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEadd = 1.0m;
        const decimal headHDPEadd2X = 1.0m * 2.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;




        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_OXXX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-FrameLS_OXXX";
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


            //TopTrackYXXX
            part = new Part(3406, "TopTrackYXXX", this, 1, (trackHelper.DoorPanelWidth * 4.0m) - stileOvrLpX3 + doorGap);
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            //TopTrackYXX
            part = new Part(3406, "TopTrackYXX", this, 1, (trackHelper.DoorPanelWidth * 3.0m) - stileOvrLpX2 + yTrAccess - yTrack);
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            //TopTrackYX
            part = new Part(3406, "TopTrackYX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - stileOverLap + yTrAccess - yTrack);
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // TopTrackYOX
            part = new Part(3406, "TopTrackYO", this, 1, (trackHelper.DoorPanelWidth) + doorGap + yTrAccess - yTrack);
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            //ShapedYtrackRubber -->> 
            for (int i = 0; i < 6; i++)
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

            //BzJambXDoor -->> 
            for (int i = 0; i < 2; i++)
            {


                part = new Part(4363, "BzJambXDoor", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //BzJambIntODoor -->> 
            for (int i = 0; i < 1; i++)
            {


                part = new Part(4363, "BzJambIntODoor", this, 1, m_subAssemblyHieght - reducHDPE - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //BzJambExtODoor -->> 
            for (int i = 0; i < 1; i++)
            {


                part = new Part(4363, "BzJambExtODoor", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // FaciaHeadInt ^^
            part = new Part(4364, "FaciaHeadInt", this, 1, m_subAssemblyWidth - jambDimW - jambToFW);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadExtXXX ^^
            part = new Part(4364, "FaciaHeadExtXXX", this, 1, (trackHelper.DoorPanelWidth ) - spltHdRed  );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadExtXX ^^
            part = new Part(4364, "FaciaHeadExtXX", this, 1, (trackHelper.DoorPanelWidth  ) - spltMdidRed );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadExtX ^^
            part = new Part(4364, "FaciaHeadExtX", this, 1, (trackHelper.DoorPanelWidth ) - spltMdidRed);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadExtO ^^
            part = new Part(4364, "FaciaHeadExtO", this, 1, (trackHelper.DoorPanelWidth) - jambInset + yTrAccess);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaCap9 ^^
            for (int i = 0; i < 3; i++)
            {
                part = new Part(4364, "FaciaCap9", this, 1, FaciaCap9);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaCap10 ^^
            for (int i = 0; i < 3; i++)
            {
                part = new Part(4364, "FaciaCap10", this, 1, FaciaCap10);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaCap11 ^^
            for (int i = 0; i < 3; i++)
            {
                part = new Part(4364, "FaciaCap11", this, 1, FaciaCap11);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // AccessPlate ^^
            for (int i = 0; i < 3; i++)
            {
                part = new Part(4421, "AccessPlate", this, 1, FaciaCap11);
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


            // HDPEHead ^^
            part = new Part(3454, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * panelCount) - stileOvrLpX3 + headHDPEadd2X);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "Notch @ " + notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 11.5m;

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            for (int i = 0; i < 2; i++)
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