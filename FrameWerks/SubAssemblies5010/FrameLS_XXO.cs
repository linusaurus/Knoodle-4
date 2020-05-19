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

namespace FrameWorks.Makes.System5010
{

    public class FrameLS_XXO : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        // The values we can change for different layouts
        const int panelCount = 3;
        const decimal stileOverLap = 2.5625m;
        const decimal stileOvrLpX2 = 2.0m * 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.875m;
        const decimal jambDimW = 1.5m;        
        const decimal jambInset = 0.375m;
        const decimal cladRed2X = 1.625m * 2.0m;
        const decimal spltHdRed = 6.9173m;
        const decimal faceMidoor = 2.4375m;
        const decimal spltHdAdd = 4.4798m;
        const decimal yTrackAdd = 2.5m;
        const decimal notchHDPEadd = 4.0587m;
        const decimal headHDPEadd = 1.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;




        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_XXO()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FrameLS_XXO";
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


            //TopTrackYXX
            part = new Part(3406, "TopTrackYXX", this, 1, (trackHelper.DoorPanelWidth * 3.0m) - stileOvrLpX2 + doorGap);
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            //TopTrackYX
            part = new Part(3406, "TopTrackYX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - stileOverLap  + yTrackAdd );
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // TopTrackYOX
            part = new Part(3406, "TopTrackYO", this, 1, (trackHelper.DoorPanelWidth) + yTrackAdd + doorGap);
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

            #region Over_Travel

            //////////////////////////////////////////////////////////////////////////////

            //OTB_XXO
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5425, "OTB_XXO", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Filler
            for (int i = 0; i < 2; i++)
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

            //BzJamb -->> 
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4363, "BzJamb", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //AlumJambIntODoor -->> 
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4357, "AlumJambIntODoor", this, 1, m_subAssemblyHieght - reducHDPE - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //AlumJambIntXDoor -->> 
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4357, "AlumJambIntXDoor", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // AlumHeadInt ^^
            part = new Part(4362, "AlumHeadInt", this, 1, m_subAssemblyWidth - jambDimW - calkGap);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // BrzHead3ExtX ^^
            part = new Part(4364, "BrzHead3ExtX", this, 1, (trackHelper.DoorPanelWidth) - jambInset - spltHdRed);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            ////////////////////////////////////////////////////////////////////////////////

            // BrzHead2ExtXX ^^
            part = new Part(4364, "BrzHead2ExtXX", this, 1, (trackHelper.DoorPanelWidth) - faceMidoor);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // BrzHead1ExtO ^^
            part = new Part(4364, "BrzHead1ExtO", this, 1, (trackHelper.DoorPanelWidth) - jambInset + spltHdAdd);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            //Brz_XXO_OTB_EndCap -->> 
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4364, "Brz_XXO_OTB_EndCap", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel-Parts";
                part.PartLabel = "";
                part.PartLength = 2.875m;

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region WoodClad

            ////////////////////////////////////////////////////////////////////////////////

            // WoodCladLSJamb -->> 
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4339, "WoodCladLSJamb", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "WoodClad-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////

            // WoodCladLSHead ^^
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4339, "WoodCladLSHead", this, 1, m_subAssemblyWidth - cladRed2X);
                part.PartGroupType = "WoodClad-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Top_Seal

            for (int i = 0; i < 2; i++)
            {

                part = new Part(3927, "Seal_at_Head", this, 1, 0.0m);
                part.PartGroupType = "Top_Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion

            #region HDPE_Head



            //////////////////////////////////////////////////////////////////////////////


            string notchHDPE = string.Empty;
            decimal[] temp = new decimal[panelCount + 1];

            for (int i = 1; i < panelCount ; i++)
            {
                
                switch (i)
                {
                    case 1:
                        {
                            temp[1] =  trackHelper.DoorPanelWidth + headHDPEadd + notchHDPEadd;
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
                            temp[3] = (trackHelper.DoorPanelWidth * 3.0m)  -  stileOverLap * 2.0m + headHDPEadd + notchHDPEadd;
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
            part = new Part(3454, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * panelCount) - stileOverLap * 2.0m + headHDPEadd);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "Notch @ " + notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 8.625m;

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
            //////////////////////////////////////////////////////////////////////////////

            // HDPE_HeadFiller
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4874, "HDPE_HeadFiller", this, 1, 0.0m);
                part.PartGroupType = "HDPE_Head-Parts";
                part.PartLabel = "";
                part.PartThick = 0.75m;
                part.PartWidth = 1.6875m;
                part.PartLength = 5.25m;


                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////



            #endregion


        }


        #endregion

    }


}