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

    public class FrameLS_XP : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        // The values we can change for different layouts
        const int panelCount = 1;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.875m;
        const decimal jambDimW = 1.5m;
        const decimal cladRed2X = 1.625m * 2.0m;
        const decimal notchHDPEadd = 4.0587m;
        const decimal yTrackAdd = 3.5m;
        const decimal headHDPEadd = 1.0m;
        const decimal headHDPEpocAdd = 3.875m;
        const decimal reducHDPE = 0.75m;
        const decimal calkGap = 0.125m;

        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_XP()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-FrameLS_XP";
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

            //////////////////////////////////////////////////////////////////////////////

            //TopTrackYX
            part = new Part(3406, "TopTrackYX", this, 1, (trackHelper.DoorPanelWidth * 2.0m) + yTrackAdd );
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

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

            //AlumJambInt -->> 
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4357, "AlumJambInt", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////

            // BrzSpltHead ^^
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4364, "BrzSpltHead", this, 1, m_subAssemblyWidth - jambDimW * 2.0m);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // AlumSpltHead ^^
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4362, "AlumSpltHead", this, 1, m_subAssemblyWidth - jambDimW * 2.0m);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

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

            #region PocketGuides

            //////////////////////////////////////////////////////////////////////////////

            // PocketGuides
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5151, "PocketGuides", this, 1, 0.0m );
                part.PartGroupType = "PocketGuides-Parts";
                part.PartLabel = "";
                part.PartThick = 0.405m;
                part.PartWidth = 1.4715m;
                part.PartLength = 5.0m;

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE



            //////////////////////////////////////////////////////////////////////////////

            decimal HDPEnotch = trackHelper.DoorPanelWidth + headHDPEadd + notchHDPEadd;
            string notchHDPE = "notch head @ " + HDPEnotch.ToString();

            // HDPE_Head_XP ^^
            part = new Part(4400, "HDPE_Head_XP", this, 1, trackHelper.DoorPanelWidth * 2.0m + headHDPEadd + headHDPEpocAdd);
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = notchHDPE;
            part.PartThick = 0.75m;
            part.PartWidth = 2.875m;

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - calkGap - reducHDPE);
                part.PartGroupType = "HDPE-Parts";
                part.PartLabel = "";
                part.PartThick = 0.75m;
                part.PartWidth = 2.875m;


                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////



            #endregion

        }


        #endregion

    }


}