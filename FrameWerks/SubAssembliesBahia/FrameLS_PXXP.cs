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
using System.Linq;
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.Bahia
{

    public class FrameLS_PXXP : SubAssemblyBase
    {

        #region Fields

        static int createID;

        // The values we can change for different layouts
        const int panelCount = 2;
        const decimal doorGap = 0.250m;
        const decimal jamB = 1.00m;
        const decimal pocketInset = 4.0m;
  


        #endregion

        #region Constructor

        public FrameLS_PXXP()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-FrameLS_PXXP";
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


                // TopTrackYPXXP
                part = new Part(3406, "TopTrackYPXXP", this, 1, (trackHelper.DoorPanelWidth * 4)  + doorGap + 2.0m * pocketInset);
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);






                #endregion


                #region Frame-Parts



                //SplitJambAngl -->>  
                for (int i = 0; i < 4; i++)
                {

                    part = new Part(3410, "SplitJambAngl", this, 1, m_subAssemblyHieght);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }


                // HookJamb
                for (int i = 0; i < 2; i++)
                {

                    part = new Part(3409, "HookJamb", this, 1, m_subAssemblyHieght);
                    part.PartGroupType = "CapJamb-Parts";
                    part.PartLabel = "Modify";

                    m_parts.Add(part);


                }

                
 
                // FaciaHeadExtPXXP ^^
                part = new Part(3404, "FaciaHeadExtPXXP", this, 1, (trackHelper.DoorPanelWidth * 2) + (jamB) + (doorGap));
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                // FaciaHeadInt ^^
                part = new Part(3404, "FaciaHeadInt", this, 1, (trackHelper.DoorPanelWidth * 2)  + (jamB) + (doorGap));
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);




                // HDMPHead ^^
                part = new Part(3467, "HDMPHead", this, 1, (trackHelper.DoorPanelWidth * 4) + doorGap + 2.0m * pocketInset);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                #endregion


            }

        }



        #endregion


    }
}