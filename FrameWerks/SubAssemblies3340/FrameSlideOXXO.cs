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

    public class FrameSlideOXXO : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        // The values we can change for different layouts
        const int panelCount = 4;
        const decimal FaciaCap11 = 3.625m;
        const decimal FaciaCap10 = 2.875m;
        const decimal FaciaCap9 = 2.9375m;
        const decimal stileOverLap = 1.125m;
        const decimal stileOvrLpX2 = 2.0m * 1.125m;
        const decimal stileOvrLpX3 = 3.0m * 1.125m;
        const decimal doorGap = 0.25m;
        const decimal jambDim2X = 1.5m * 2.0m;
        const decimal jambInset = 0.375m;
        const decimal yTrack = 2.1276m;
        const decimal yTrAccess = 4.1276m;
        const decimal accessRed2X = 3.87755m * 2.0m;
        const decimal notchHDPEadd = 4.0275m;
        const decimal headHDPEred2X = 0.125m * 2.0m;
        const decimal headHDPEadd = 1.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;
        const decimal wallFin2X = 1.375m * 2.0m;




        //static int createID;

        #endregion

        #region Constructor

        public FrameSlideOXXO()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3340-FrameSlideOXXO";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - stileOvrLpX3 - doorGap , 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region TopTrackY

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackX
            part = new Part(4447, "TopTrackX", this, 1, (trackHelper.DoorPanelWidth * 4.0m) - wallFin2X);
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // TopTrackO
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4447, "TopTrackO", this, 1, (trackHelper.DoorPanelWidth) + doorGap + yTrack);
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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

            //Jamb_4363_ExtODoor -->> 
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4363, "Jamb_4363_ExtODoor", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //Jamb_4363_IntODoor -->> 
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4363, "Jamb_4363_IntODoor", this, 1, m_subAssemblyHieght - reducHDPE - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // FaciaHd_4364_Int ^^
            part = new Part(4364, "FaciaHd_4364_Int", this, 1, m_subAssemblyWidth - jambDim2X);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaHd_4364_ExtXX ^^
            part = new Part(4364, "FaciaHd_4364_ExtXX", this, 1, (trackHelper.DoorPanelWidth * 2.0m - stileOvrLpX2 - accessRed2X));
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaHd_4364_ExtO ^^
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4364, "FaciaHd_4364_ExtO", this, 1, (trackHelper.DoorPanelWidth) - jambInset + yTrAccess);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            
            ////////////////////////////////////////////////////////////////////////////////

            // Facia_4364_Cap9 ^^
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4364, "Facia_4364_Cap9", this, 1, FaciaCap9);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // Facia_4364_Cap10 ^^
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4364, "Facia_4364_Cap10", this, 1, FaciaCap10);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // Facia_4364_Cap11 ^^
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4364, "Facia_4364_Cap11", this, 1, FaciaCap11);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // Access_4421_Plate ^^
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4421, "Access_4421_Plate", this, 1, FaciaCap11);
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
            part = new Part(3442, "HDPE_Head", this, 1, trackHelper.DoorPanelWidth * 4.0m - headHDPEred2X + doorGap );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 4.125m;

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4453, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
                part.PartGroupType = "HDPE_Head-Parts";
                part.PartLabel = "";
                part.PartThick = 0.75m;
                part.PartWidth = 2.125m;

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion


        }


        #endregion

    }


}