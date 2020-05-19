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

namespace FrameWorks.Makes.Bahia
{

    public class FrameLS_PX : SubAssemblyBase
    {

        #region Fields

        static int createID;

        // The values we can change for different layouts
        const int panelCount = 1;
        const decimal endCaps = 2.09375m;
        const decimal stileWidth = 2.23637795m;
        const decimal stileOverLap = stileWidth / 2.0m;
        const decimal doorGap = 0.250m;
        const decimal jamB = 1.0m;
        const decimal jambInset = 0.0m;
        const decimal headInset = 1.43193898m;
        const decimal jambExtend = 0.9015m;
        const decimal pocketInset = 4.0m;
        const decimal yTrack = 0.3438m;
        const decimal beYond = .25m;
        const decimal stileOfst = 0.4688m;
        const decimal floorDep = 0.625m;
        const decimal calkGap = 0.03125m;


        #endregion

        #region Constructor

        public FrameLS_PX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-FrameLS_PX";
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


                //TopTrackYPX
                part = new Part(3406, "TopTrackYPX", this, 1, (trackHelper.DoorPanelWidth * 2) + doorGap - pocketInset);
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


                #endregion


                #region Frame-Parts


                //JambChanl -->>  
                part = new Part(3626, "JambChanl", this, 1, m_subAssemblyHieght + jambExtend + floorDep);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


                //JambAngl -->> 
                part = new Part(3629, "JambAngl", this, 1, m_subAssemblyHieght + jambExtend + floorDep);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                //SplitJambAngl -->>  
                for (int i = 0; i < 2; i++)
                {

                    part = new Part(3410, "SplitJambAngl", this, 1, m_subAssemblyHieght + jambExtend + floorDep);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }


                // HookJamb
                part = new Part(3409, "HookJamb", this, 1, m_subAssemblyHieght + jambExtend + floorDep);
                part.PartGroupType = "CapJamb-Parts";
                part.PartLabel = "Modify";

                m_parts.Add(part);


                // FaciaCaps ^^
               // for (int i = 0; i < 1; i++)
                //{
                    //part = new Part(3404, "FaciaCaps", this, 1, endCaps);
                    //part.PartGroupType = "Frame-Parts";
                    //part.PartLabel = "";

                    //m_parts.Add(part);

                //}



                // FaciaHead ^^
                for (int i = 0; i < 2; i++)
                {

                    part = new Part(3404, "FaciaHead", this, 1, (trackHelper.DoorPanelWidth)  + (jamB) + (doorGap) + (headInset) );
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }




                // HDMPHead ^^
                part = new Part(3467, "HDMPHead", this, 1, (trackHelper.DoorPanelWidth * 2) - (pocketInset) + (jamB) + (doorGap));
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                #endregion


            }

        }



        #endregion


    }
}