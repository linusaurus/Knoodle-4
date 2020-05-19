﻿#region Copyright (c) 2012 WeaselWare Software
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

    public class Frame_7_Alum_Wnd_OXXO : SubAssemblyBase
    {

        #region Fields

        static int createID;

        // The values we can change for different layouts
        const int panelCount = 4;
        const decimal doorSpacing = 2.875m;
        const decimal stileWidth = 3.726m;
        const decimal stileOverLap = 3.4887m;
        const decimal doorGap = 0.16725m;
        const decimal jamB = 0.875m;
        const decimal jambInset = 0.1741m;
        const decimal jambExtend = 1.39898075m;
        const decimal floorDep = 0.625m;

        #endregion

        #region Constructor

        public Frame_7_Alum_Wnd_OXXO()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-Frame_7_Alum_Wnd_OXXO";
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


                //TopTrackYOLeft

                part = new Part(3406, "TopTrackYOLeft", this, 1, (trackHelper.DoorPanelWidth) - (stileOverLap));
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


                // TopTrackYYXX

                part = new Part(3406, "TopTrackYYXX", this, 1, (m_subAssemblyWidth) - 2 * jamB);
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


                //TopTrackYORight

                part = new Part(3406, "TopTrackYORight", this, 1, (trackHelper.DoorPanelWidth) - (stileOverLap));
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                #endregion

                #region HDPE-Parts



                // HDMPHead ^^
                part = new Part(3442, "HDMPHead", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "HDPE-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                // HDMPJamb ^^
                for (int i = 0; i < 2; i++)
                {

                    part = new Part(3442, "HDMPJamb", this, 1, m_subAssemblyHieght);
                    part.PartGroupType = "HDPE-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }



                #endregion

                #region Frame-Parts


                //JambAng4Int -->>  
                for (int i = 0; i < 2; i++)
                {

                    part = new Part(3712, "JambAng4Int", this, 1, m_subAssemblyHieght);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }
                //*********************************************************************

                //JambAngExt -->> 
                for (int i = 0; i < 2; i++)
                {

                    part = new Part(3712, "JambAngExt", this, 1, m_subAssemblyHieght);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }
                //*********************************************************************


                //HeadAng -->> 
                for (int i = 0; i < 2; i++)
                {

                    part = new Part(3711, "HeadAng", this, 1, m_subAssemblyWidth);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }
                //*********************************************************************

                //HeadAngFill -->> 
                for (int i = 0; i < 2; i++)
                {

                    part = new Part(3712, "HeadAngFill", this, 1, (trackHelper.DoorPanelWidth) - (stileOverLap));
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }




                #endregion




            }

        }



        #endregion


    }
}