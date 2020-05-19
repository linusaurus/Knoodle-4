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

    public class Frame_7_Alum_Wnd_OX : SubAssemblyBase
    {

        #region Fields

        static int createID;

        // The values we can change for different layouts
        const int panelCount = 2;
        const decimal doorSpacing = 2.875m;
        const decimal stileWidth = 3.1250m;
        const decimal stileOverLap = 2.5294m / 2.0m;
        const decimal doorGap = 0.2500m;
        const decimal ajustOpen = 1.6735m;
        const decimal trackExtend = 0.7296m;
        const decimal headReduce = 0.2748m;
        const decimal unitReduce = 0.798542m;
        const decimal jamB = 0.875m;
        const decimal jambInset = 0.1741m;
        const decimal jambExtend = 1.39898075m;
        const decimal floorDep = 0.625m;

        #endregion

        #region Constructor

        public Frame_7_Alum_Wnd_OX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "TiburAlum-Frame_7_Alum_Wnd_OX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {


            {


                TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - ajustOpen * 2.0m - doorGap * 2.0m, 0);

                Part part;
                string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


                #region TopTrackY


                //TopTrackYO

                part = new Part(3406, "TopTrackYO", this, 1, (trackHelper.DoorPanelWidth + trackExtend + doorGap));
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


                // TopTrackYX

                part = new Part(3406, "TopTrackYX", this, 1, (m_subAssemblyWidth - ajustOpen * 2.0m));
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




                // HDMPSill ^^
                part = new Part(3442, "HDMPSill", this, 1, m_subAssemblyWidth);
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