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

namespace FrameWorks.Makes.Bahia
{

    public class FrameLS_OXXX : SubAssemblyBase
    {

        #region Fields

        static int createID;

        // The values we can change for different layouts
        const int panelCount = 4;
        const decimal endCaps = 2.09375m;
        const decimal stileWidth = 2.2364m;
        const decimal stileOverLap = stileWidth / 2.0m;
        const decimal doorGap = 0.16725m;
        const decimal jamB = 0.75m;
        const decimal jambInset = 0.1741m;
        const decimal jambExtend = 0.9015m;
        const decimal pocketInset = 0.7923m;
        const decimal jambFinwall = .5759m;
        const decimal yTrack = 0.3438m;
        const decimal beYond = .1250m;
        const decimal stileOfst = 0.4688m;
        const decimal floorDep = 0.625m;
        const decimal calkGap = 0.03125m;

        #endregion

        #region Constructor

        public FrameLS_OXXX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-FrameLS_OXXX";
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



                //TopTrackYO

                part = new Part(3406, "TopTrackYO", this, 1, (trackHelper.DoorPanelWidth) + (yTrack) + (doorGap));
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                //TopTrackYOX

                part = new Part(3406, "TopTrackYOX", this, 1, (trackHelper.DoorPanelWidth * 2.0m ) - (stileWidth)  - (jambInset) + (yTrack) + (jamB)+ (doorGap) );
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);






                //TopTrackYOXX

                part = new Part(3406, "TopTrackYOXX", this, 1, (trackHelper.DoorPanelWidth * 3) - (2 * stileWidth) - (jambInset) + (yTrack) + (jamB) + (doorGap));
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);





                //TopTrackYOXXX

                part = new Part(3406, "TopTrackYOXXX", this, 1, (trackHelper.DoorPanelWidth * 4) - (3 * stileWidth) - (jambInset) + (jamB) + (doorGap * 2));
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                #endregion


                #region Frame-Parts


                //JambChanl -->>  
                for (int i = 0; i < 2; i++)

                {

                    part = new Part(3626, "JambChanl", this, 1, m_subAssemblyHieght + jambExtend + floorDep);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }


                //JambAngl -->> 
                for (int i = 0; i < 2; i++)

                {

                    part = new Part(3629, "JambAngl", this, 1, m_subAssemblyHieght + jambExtend + floorDep);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }


                // FaciaCaps ^^
                for (int i = 0; i < 3; i++)
                {
                    part = new Part(3404, "FaciaCaps", this, 1, endCaps);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }



                // FaciaHeadExtO ^^
                part = new Part(3404, "FaciaHeadExtO", this, 1, (trackHelper.DoorPanelWidth) + (jamB) + (yTrack) + (doorGap) + (beYond) );
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


                // FaciaHeadExtOX ^^
                part = new Part(3404, "FaciaHeadExtOX", this, 1, (trackHelper.DoorPanelWidth ) - (stileWidth) - (stileOfst)  + (yTrack) + (2.0m *  beYond) - (calkGap));
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


                // FaciaHeadExtOXX ^^
                part = new Part(3404, "FaciaHeadExtOXX", this, 1, (trackHelper.DoorPanelWidth) - (stileWidth) - (stileOfst) + (yTrack) + (2.0m * beYond) - (calkGap));
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                // FaciaHeadExtOXXX ^^
                part = new Part(3404, "FaciaHeadExtOXXX", this, 1, (trackHelper.DoorPanelWidth ) - (stileWidth) - (stileOfst) + (jamB) + (doorGap) + (beYond) - (calkGap));
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                // FaciaHeadInt ^^
                part = new Part(3404, "FaciaHeadInt", this, 1, (trackHelper.DoorPanelWidth * 4) - (stileWidth * 3) + (jamB * 2) + ( doorGap * 2) );
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


                // HDMPHead ^^
                part = new Part(3467, "HDMPHead", this, 1, (m_subAssemblyWidth) + (2* jamB) + (doorGap * 2) );
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                #endregion


            }

        }



        #endregion


    }
}