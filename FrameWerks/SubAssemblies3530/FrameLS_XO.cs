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
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.System3530
{

    public class FrameLS_XO : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        // The values we can change for different layouts
        const int panelCount = 2;
        const decimal endCaps = 3.0625m;
        const decimal stileWidth = 2.25295942m;
        const decimal doorGap = 0.25m;
        const decimal jamB = 0.625m;
        const decimal jambExtend = 1.8125m;
        const decimal yTrack = 0.406129m;
        const decimal headHPDE = 11.4375m;
        const decimal beYond = .1250m;
        const decimal calkGap = 0.125m;

        
        #endregion

        #region Constructor

        public FrameLS_XO()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3530-FrameLS_XO";
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



            //TopTrackYX
            part = new Part(3406, "TopTrackYX", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // TopTrackYOX
            part = new Part(3406, "TopTrackYO", this, 1, (trackHelper.DoorPanelWidth) + (doorGap) );
            part.PartGroupType = "TopTrackY-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //BzJambSplit -->> 
            for (int i = 0; i < 4; i++)
            {


                part = new Part(4363, "BzJambSplit", this, 1, m_subAssemblyHieght + jambExtend - calkGap);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            ////////////////////////////////////////////////////////////////////////////////


            // FaciaCaps ^^
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4364, "FaciaCaps", this, 1, endCaps);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadExtOX ^^
            part = new Part(4364, "FaciaHeadExtOX", this, 1, (trackHelper.DoorPanelWidth) + (yTrack) + (beYond));
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////
           

            // FaciaHeadInt ^^
            part = new Part(4364, "FaciaHeadInt", this, 1, (trackHelper.DoorPanelWidth * 2.0m) + (stileWidth) + (jamB) + (doorGap));
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            // HDMPHead ^^
            part = new Part(3467, "HDMPHead", this, 1, (trackHelper.DoorPanelWidth ) + (stileWidth) + (jamB) + (doorGap), headHPDE);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            part.PartThick = 0.75m;

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE_Head


            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Head
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3442, "HDPE_Head", this, 1, m_subAssemblyWidth );
                part.PartGroupType = "HDPE_Head-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////



            #endregion


        }


        #endregion

    }


}