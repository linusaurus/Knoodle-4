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

namespace FrameWorks.Makes.System3530
{

    public class FrameLS_PXXXX : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const int panelCount = 4;
        const decimal endCaps = 3.0625m;
        const decimal AccessPlate = 2.6875m;
        const decimal widthCap = 0.1875m;
        const decimal stileWidth = 2.25295942m;
        const decimal stileOverLap = 2.25295942m;
        const decimal doorGap = 0.25m;
        const decimal jambInset = 0.375m;
        const decimal jambExtend = 1.8125m;
        const decimal headExtend = 4.343629m;
        const decimal jambHDPE = 2.62499152m;
        const decimal headHPDE = 11.4375m;
        const decimal floorDep = 0.0m;
        const decimal pocketClose = 10.875m;

        #endregion

        #region Constructor

        public FrameLS_PXXXX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "3530-FrameLS_PXXXX";
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
                part = new Part(3406, "TopTrackYPX", this, 1, (trackHelper.DoorPanelWidth * 2) );
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


                // TopTrackYPXX
                part = new Part(3406, "TopTrackYPXX", this, 1, (trackHelper.DoorPanelWidth * 3) - (stileOverLap) );
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                //TopTrackYPXXX

                part = new Part(3406, "TopTrackYPXXX", this, 1, (trackHelper.DoorPanelWidth * 4) - (2 * stileOverLap) );
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


                //TopTrackYPXXXX

                part = new Part(3406, "TopTrackYPXXXX", this, 1, (trackHelper.DoorPanelWidth * 5) - (3 * stileOverLap) + (doorGap));
                part.PartGroupType = "TopTrackY-Parts";
                part.PartLabel = "";

                m_parts.Add(part);



                #endregion


                #region Frame-Parts

                /////////////////////////////////////////////////////////////////////////////////////////////

                //BzJamb_Head -->> 

                for (int i = 0; i < 2; i++)
                {

                    part = new Part(4363, "BzJamb_Head", this, 1, m_subAssemblyHieght + jambExtend + floorDep);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

                }

                /////////////////////////////////////////////////////////////////////////////////////////////

                //HDPE_Jamb -->> 
                part = new Part(911, "HDPE_Jamb", this, 1, m_subAssemblyHieght + jambExtend + floorDep , jambHDPE);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);               

                /////////////////////////////////////////////////////////////////////////////////////////////

                //BzSpltJamb -->> 

                for (int i = 0; i < 2; i++)
                {

                    part = new Part(4363, "BzSpltJamb", this, 1, m_subAssemblyHieght + jambExtend + floorDep);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                /////////////////////////////////////////////////////////////////////////////////////////////

                // FaciaCaps ^^
                for (int i = 0; i < 3; i++)
                {
                    part = new Part(4364, "FaciaCaps", this, 1, endCaps);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                /////////////////////////////////////////////////////////////////////////////////////////////

                // AccessPlate ^^
                for (int i = 0; i < 3; i++)
                {
                    part = new Part(911, "AccessPlate", this, 1, AccessPlate);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                /////////////////////////////////////////////////////////////////////////////////////////////

                // FaciaHeadExtPX ^^
                part = new Part(4364, "FaciaHeadExtPX", this, 1, (trackHelper.DoorPanelWidth) - jambInset + headExtend);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

                /////////////////////////////////////////////////////////////////////////////////////////////

                // FaciaHeadExtPXX ^^
                part = new Part(4364, "FaciaHeadExtPXX", this, 1, (trackHelper.DoorPanelWidth) + (widthCap) - (stileOverLap));
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

                /////////////////////////////////////////////////////////////////////////////////////////////

                // FaciaHeadExtPXXX ^^
                part = new Part(4364, "FaciaHeadExtPXXX", this, 1, (trackHelper.DoorPanelWidth) + (widthCap) - (stileOverLap));
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

                /////////////////////////////////////////////////////////////////////////////////////////////

                // FaciaHeadExtPXXXX ^^
                part = new Part(4364, "FaciaHeadExtPXXXX", this, 1, (trackHelper.DoorPanelWidth) + (widthCap) - (stileOverLap) - (headExtend) - (jambInset));
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

                /////////////////////////////////////////////////////////////////////////////////////////////

                // FaciaHeadInt ^^
                part = new Part(4364, "FaciaHeadInt", this, 1, (trackHelper.DoorPanelWidth * 4) - ( 3.0m * stileOverLap) - (2.0m * jambInset));
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

                /////////////////////////////////////////////////////////////////////////////////////////////

                // HDMPHead ^^
                part = new Part(3467, "HDMPHead", this, 1, (trackHelper.DoorPanelWidth * 5) - (3 * stileWidth) + (doorGap), headHPDE);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";
                part.PartThick = 0.75m;

                m_parts.Add(part);

                /////////////////////////////////////////////////////////////////////////////////////////////

                #endregion


                #region Pocket_CloseOut-Parts

                ////////////////////////////////////////////////////////////////////////////////////////////

                //BzCloseOut -->>  
                for (int i = 0; i < 1; i++)
                {

                    part = new Part(911, "BzCloseOut", this, 1, m_subAssemblyHieght, pocketClose);
                    part.PartGroupType = "Pocket_CloseOut-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }

                ////////////////////////////////////////////////////////////////////////////////////////////
                ////////////////////////////////////////////////////////////////////////////////////////////

                // SumChit ^^
                part = new Part(911, "SumChit", this, 1, m_subAssemblyHieght, pocketClose);
                part.PartGroupType = "Pocket_CloseOut-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

                ////////////////////////////////////////////////////////////////////////////////////////////


                #endregion



            }

        }



        #endregion


    }
}