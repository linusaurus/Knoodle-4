#region Copyright (c) 2012 WeaselWare Software
/************************************************************************************
'
' Copyright  2012 WeaselWare Software 
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
' Portions Copyright 2012 WeaselWare Software
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

namespace FrameWorks.Makes.TiburAlum
{

    public class Frame_7_Alum_LS_PXS : SubAssemblyBase
    {

        #region Fields

        static int createID;

        // The values we can change for different layouts
        const int panelCount = 1;
        const decimal endCaps = 2.09375m;
        const decimal stileWidth = 3.1250m;
        const decimal stileOverLap = 3.4887m / 2.0m;
        const decimal doorGap = 0.15625m;
        const decimal jamB = 1.125m;
        const decimal jambInset = 0.875m;
        const decimal jambExtend = 0.2744m;
        const decimal pocketInset = 0.7923m;
        const decimal jambFinwall = .5759m;
        const decimal yTrack = 0.3438m;
        const decimal beYond = .1250m;
        const decimal stileOfst = 0.4688m;
        const decimal floorDep = 0.625m;
        const decimal calkGap = 0.03125m;

        #endregion

        #region Math Functions



        #endregion

        #region Constructor

        public Frame_7_Alum_LS_PXS()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "TiburAlum-Frame_7_Alum_LS_PXS";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region TopTrackY


            //TopTrackYPX

            part = new Part(3406, "TopTrackYPX", this, 1, trackHelper.DoorPanelWidth * panelCount);
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // TopTrackYPS

            part = new Part(3406, "TopTrackYPS", this, 1, trackHelper.DoorPanelWidth * panelCount);
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion

            #region HDPE-Parts

            // HDMPHead ^^
            part = new Part(3442, "HDMPHead", this, 1, (trackHelper.DoorPanelWidth * 2));
            part.PartGroupType = "HDPE-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion

            #region Frame-Parts


            //JambAngl -->> 
            for (int i = 0; i < 4; i++)
            {

                part = new Part(3712, "JambAngl", this, 1, m_subAssemblyHieght + jambExtend);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //*****************************************************************************************

            // HeadAngl ^^
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3711, "HeadAngl", this, 1, (trackHelper.DoorPanelWidth * 2));
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //******************************************************************************************





            #endregion




        }

    }

        #endregion


}