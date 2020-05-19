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

    public class Frame_5_AlumLS_PXXP : SubAssemblyBase
    {

        #region Fields

        static int createID;

        // The values we can change for different layouts
        const int panelCount = 2;
        const decimal endCaps = 3.2451m;
        const decimal stileWidth = 3.1250m;
        const decimal stileOverLap = 3.4887m / 2.0m;
        const decimal doorGap = 0.25m;
        const decimal jambReduce = 0.6726m;
        const decimal jamB = 0.75m;
        const decimal jambInset = 0.1741m;
        const decimal jambExtend = 0.9015m;
        const decimal capWidth = 1.0975m;
        const decimal channelHeight = 1.00m;
        const decimal yTrack = 0.3438m;
        const decimal stileOfst = 0.4688m;
        const decimal floorDep = 0.625m;
        const decimal calkGap = 0.1250m;


        #endregion

        #region Constructor

        public Frame_5_AlumLS_PXXP()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "TiburAlum-Frame_5_AlumLS_PXXP";
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



                //TopTrackYPXXP
                part = new Part(3406, "TopTrackYPXXP", this, 1, (trackHelper.DoorPanelWidth * 4) - (stileWidth *3.0m));
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                #endregion

                #region HDPE-Parts


                // HDMPHead ^^
                part = new Part(3659, "HDMPHead", this, 1, (trackHelper.DoorPanelWidth * 4)- stileWidth * 2.0m );
                part.PartGroupType = "HDPE-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                // HDMPShim ^^
                part = new Part(3763, "HDMPShim", this, 1, (trackHelper.DoorPanelWidth * 4) - stileWidth * 2.0m);
                part.PartGroupType = "HDPE-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                // HDMPShim ^^
                part = new Part(3763, "HDMPShim", this, 1,  m_subAssemblyHieght * 4.0m );
                part.PartGroupType = "HDPE-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


                #endregion

                #region Cap

                //CapAlumVert
                for (int i = 0; i < 4; i++)
                {

                    part = new Part(3611, "CapAlumVert", this, 1, m_subAssemblyHieght - capWidth);
                    part.PartGroupType = "Cap-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }



                //CapAlumHorz
                for (int i = 0; i < 2; i++)
                {

                    part = new Part(3656, "CapAlumHorz", this, 1, m_subAssemblyWidth);
                    part.PartGroupType = "Cap-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }



                #endregion

                #region Frame-Parts



                //SplitJambAngl -->>  
                for (int i = 0; i < 4; i++)
                {

                    part = new Part(3657, "SplitJambAngl", this, 1, m_subAssemblyHieght - jambReduce);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }


                //RectagleBarJamb
                for (int i = 0; i < 4; i++)
                {
                    part = new Part(3658, "RectagleBarJamb", this, 1, m_subAssemblyHieght - jambReduce );
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }



                //RectagleBarHead
                for (int i = 0; i < 2; i++)
                {
                    part = new Part(3658, "RectagleBarHead", this, 1, m_subAssemblyWidth - jambReduce * 2.0m);
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