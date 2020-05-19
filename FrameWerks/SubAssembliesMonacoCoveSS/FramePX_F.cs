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

namespace FrameWorks.Makes.MonacoCoveSS
{

    public class FramePX_F : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const int panelCount = 1;
        const decimal doorSpacing = 1.75m;
        const decimal bridgeLength = 2.25m;
        const decimal stileWidth = 1.1875m;
        const decimal stileOverLap = 1.1875m / 2.0m;
        const decimal doorGap = 0.50m;
        const decimal ajustOpen = 0.0m;
        const decimal trackExtend = 0.0m;
        const decimal jamB = 0.048m;
        const decimal jambFinwall = 0.0m;
        const decimal pocketInset = 0.0m;
        const decimal jambInset = 0.0m;
        const decimal doorTravel = 30.1875m;
        const decimal doorP2 = 54.6625m;
        const decimal doorP3 = 108.2875m;
        const decimal headAdd = 1.2875m;
        const decimal headCap = 1.798m;

        static int createID;

        #endregion

        #region Constructor

        public FramePX_F()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "MonacoCoveSS-FramePX_F";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            TrackHelper trackHelper = new TrackHelper(panelCount, doorTravel, 0);

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region Jamb316SS

            //////////////////////////////////////////////////////////////////////////////

            // Jamb316SSPocket
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4181, "Jamb316SSPocket", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Head316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // Jamb316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4171, "Jamb316SS", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Head316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // Jamb316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4172, "Jamb316SS", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Head316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // Jamb316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4170, "Jamb316SS", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Head316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Head316SS

            //////////////////////////////////////////////////////////////////////////////

            // Head316SSOne
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4178, "Head316SSOne", this, 1, m_subAssemblyWidth + doorTravel);
                part.PartGroupType = "Head316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // Head316SSOne
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4179, "Head316SSOne", this, 1, m_subAssemblyWidth + doorTravel);
                part.PartGroupType = "Head316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // Head316SSOne
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4180, "Head316SSOne", this, 1, m_subAssemblyWidth + doorTravel);
                part.PartGroupType = "Head316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }
   
            //////////////////////////////////////////////////////////////////////////////
            

            #endregion

            #region BottomTrack


            //////////////////////////////////////////////////////////////////////////////

            // BottomAlum1
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4087, "BottomAlum1", this, 1, m_subAssemblyWidth + doorTravel - jamB);
                part.PartGroupType = "BottomTrack-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // 316SSTrackBar1
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4214, "316SSTrackBar1", this, 1, m_subAssemblyWidth + doorTravel - jamB);
                part.PartGroupType = "BottomTrack-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            




            #endregion

            #region BridgeAssemble

            //BridgeAssemble

            //////////////////////////////////////////////////////////////////////////////

            // Bridge
            for (int i = 0; i < 5; i++)
            {
                part = new Part(3445, "Bridge", this, 1, bridgeLength);
                part.PartGroupType = "BottomTrack-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // BridgeClips
            for (int i = 0; i < 10; i++)
            {
                part = new Part(3446, "BridgeClips", this, 1, 0.0m);
                part.PartGroupType = "BottomTrack-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // SSAllThred
            for (int i = 0; i < 10; i++)
            {
                part = new Part(3569, "SSAllThred", this, 1, 2.0m);
                part.PartGroupType = "BottomTrack-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // FlangeNuts
            for (int i = 0; i < 20; i++)
            {
                part = new Part(3450, "FlangeNuts", this, 1, 0.0m);
                part.PartGroupType = "BottomTrack-Parts";
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