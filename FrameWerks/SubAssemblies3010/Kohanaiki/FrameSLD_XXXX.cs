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
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.System3010
{

    public class FrameSLD_XXXX : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        // The values we can change for different layouts
        const int panelCount = 4;
        const decimal doorGap2X = 2.0m * 0.25m;
        const decimal jambReduce2X = 2.0m * 0.87500001m;
        const decimal bridgeLength = 10.5625m;

        const decimal maxsize = 194.00m;



        //static int createID;

        #endregion

        #region Constructor

        public FrameSLD_XXXX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-FrameSLD_XXXX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, m_subAssemblyWidth - jambReduce2X - doorGap2X, 0);

            BridgeGenie bridgeGenie = new BridgeGenie(2.25m);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region Tracks

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackYXXX

            for (int i = 0; i < 4; i++)
            {

                part = new Part(3406, "TopTrackYXXX", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Tracks-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            //FASTrack_INT_X

            for (int i = 0; i < 1; i++)
            {

                part = new Part(3444, "FASTrack_INT_X", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Tracks-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //FASTrack_XXX_EXT

            for (int i = 0; i < 3; i++)
            {

                part = new Part(3444, "FASTrack_XXX_EXT", this, 1, m_subAssemblyWidth - 4.0m);
                part.PartGroupType = "Tracks-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion

            #region BridgeAssemble

            //BridgeAssemble

            /////////////////////////////////////////////////////////////////////////////////////////////

            //Bridge

            for (int i = 1; i < m_subAssemblyWidth / 20.0m + 1; i++)
            {


                part = new Part(3445, "Bridge", this, 1, bridgeLength);
                part.PartGroupType = "BridgeAssemble-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //BridgeClips

            for (int i = 0; i < m_subAssemblyWidth / 20.0m * 2.0m + 1.0m; i++)
            {

                part = new Part(3446, "BridgeClips", this, 1, 0.0m);
                part.PartGroupType = "BridgeAssemble-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            //TrackClips

            for (int i = 0; i < m_subAssemblyWidth / 20.0m * 8.0m + 5.0m; i++)
            {

                part = new Part(3447, "TrackClips", this, 1, 0.0m);
                part.PartGroupType = "BridgeAssemble-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            //NutPlateConnector

            for (int i = 0; i < m_subAssemblyWidth / 20.0m * 2.0m + 1.0m; i++)
            {

                part = new Part(3448, "NutPlateConnector", this, 1, 0.0m);
                part.PartGroupType = "BridgeAssemble-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            //CapScrews

            for (int i = 0; i < m_subAssemblyWidth / 20.0m * 8.0m + 5.0m; i++)
            {

                part = new Part(3449, "CapScrews", this, 1, 0.0m);
                part.PartGroupType = "BridgeAssemble-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

#endregion

            #region Frame

            //FaciaHead

            for (int i = 0; i < 2; i++)
            {

                if (m_subAssemblyWidth > maxsize)
                {
                    part = new Part(4364, "FaciaHead", this, 1, m_subAssemblyWidth - maxsize);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";
                    m_parts.Add(part);

                    part = new Part(4364, "FaciaHead", this, 1, maxsize);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";
                    m_parts.Add(part);
                }
                else
                {
                    part = new Part(4364, "FaciaHead", this, 1, m_subAssemblyWidth);
                    part.PartGroupType = "Frame-Parts";
                    part.PartLabel = "";

                    m_parts.Add(part);

                }
                

            }





            #endregion

            #region HDPE_Head

            //HDPE_Head

            for (int i = 0; i < 1; i++)
            {

                part = new Part(3454, "HDPE_Head", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "HDPE_Head-Parts";
                part.PartLabel = "";
                part.PartThick = 0.75m;
                part.PartWidth = 11.5m;

                m_parts.Add(part);

            }






            #endregion


        }


            #endregion

    }



}