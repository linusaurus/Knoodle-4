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

namespace FrameWorks.Makes.System5010
{

    public class FrameLS_OX : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        // The values we can change for different layouts
        const int panelCount = 2;
        const decimal stileOverLap = 2.5625m;
        const decimal doorGap = 0.25m;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.875m;
        const decimal jambDimW = 1.5m;
        const decimal jambInset = 0.375m;
        const decimal cladRed2X = 1.625m * 2.0m;
        const decimal spltHdRed = 6.9173m;
        const decimal spltHdAdd = 4.4798m;
        const decimal yTrack = 1.9798m;
        const decimal yTrAccess = 4.47982m;
        const decimal notchHDPEadd = 4.0587m;
        const decimal headHDPEadd = 1.0m;
        const decimal headHDPEadd2X = 1.0m * 2.0m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;




        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_OX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FrameLS_OX";
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


            //TopTrackYX
            part = new Part(3406, "TopTrackYX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) - stileOverLap + doorGap );
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
            for (int i = 0; i < 2; i++)
            {


                part = new Part(3766, "ShapedYtrackRubber", this, 1, 0.0m);
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Over_Travel

            ////////////////////////////////////////////////////////////////////////////////

            //OTB_OX
            for (int i = 0; i < 1; i++)
            {
                part = new Part(5426, "OTB_OX", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);
            }

            ////////////////////////////////////////////////////////////////////////////////


            //OTB_Filler
            for (int i = 0; i < 1; i++)
            {
                part = new Part(5271, "OTB_Filler", this, 1, 0.0m);
                part.PartGroupType = "Over_Travel";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //BzJambExt -->> 
            for (int i = 0; i < 2; i++)
            {


                part = new Part(4363, "BzJambExt", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            //AlumJambXDoor -->> 
            for (int i = 0; i < 1; i++)
            {


                part = new Part(4357, "AlumJambXDoor", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //AluJambIntODoor -->> 
            for (int i = 0; i < 1; i++)
            {


                part = new Part(4357, "AlumJambIntODoor", this, 1, m_subAssemblyHieght - reducHDPE - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // BrzHeadExtX ^^
            part = new Part(4364, "BrzHeadExtX", this, 1, (trackHelper.DoorPanelWidth) - jambInset - spltHdRed);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////


            // BrzHeadExtO ^^
            part = new Part(4364, "BrzHeadExtO", this, 1, (trackHelper.DoorPanelWidth) - jambInset + spltHdAdd);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            ////////////////////////////////////////////////////////////////////////////////

            //Brz_OX_OTB_EndCap -->> 
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4364, "Brz_OX_OTB_EndCap", this, 1, 0.0m);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";
                part.PartLength = 2.875m;

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // AlumHeadInt ^^
            part = new Part(4362, "AlumHeadInt", this, 1, m_subAssemblyWidth - jambDimW - calkGap);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

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

            for (int i = 0; i < 1; i++)
            {

                part = new Part(3927, "Seal_at_Head", this, 1,  0.0m);
                part.PartGroupType = "Top_Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion

            #region HDPE

            //////////////////////////////////////////////////////////////////////////////

            decimal HDPEnotch = trackHelper.DoorPanelWidth + headHDPEadd + notchHDPEadd;
            string notchHDPE = "notch head @ " + HDPEnotch.ToString();

            // HDPE_Head ^^
            part = new Part(3442, "HDPE_Head", this, 1, (trackHelper.DoorPanelWidth * panelCount) - stileOverLap + headHDPEadd2X);
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 5.75m;

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
                part.PartGroupType = "HDPE-Parts";
                part.PartLabel = "";
                part.PartThick = 0.75m;
                part.PartWidth = 2.875m;

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // HDPE_HeadFiller
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4871, "HDPE_HeadFiller", this, 1, 0.0m );
                part.PartGroupType = "HDPE-Parts";
                part.PartLabel = "";
                part.PartThick = 0.75m;
                part.PartWidth = 1.6875m;
                part.PartLength = 2.4375m;
                

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////



            #endregion


        }


        #endregion

    }


}