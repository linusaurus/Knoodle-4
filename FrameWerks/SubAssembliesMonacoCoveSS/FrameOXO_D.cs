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

    public class FrameOXO_D : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const int panelCount = 3;
        const decimal doorSpacing = 1.75m;
        const decimal bridgeLength = 2.4375m;
        const decimal stileWidth = 1.1875m;
        const decimal stileOverLap = 1.1875m / 2.0m;
        const decimal doorGap = 0.50m;
        const decimal ajustOpen = 0.0m;
        const decimal trackExtend = 0.0m;
        const decimal trackReduce = 43.173m;
        const decimal trackRedMid = 92.31255m;
        const decimal jamB = 0.048m;
        const decimal jambFinwall = 0.0m;
        const decimal pocketInset = 0.0m;
        const decimal jambInset = 0.0m;
        const decimal doorTravel = 59.46875m;
        const decimal doorP2 = 44.875m;
        const decimal doorP3 = 108.2875m;
        const decimal headAdd = 1.2875m;
        const decimal headCap = 1.846m;
        const decimal midJamAdd = 1.702m;
        const decimal midSpan = 91.0625m;

        static int createID;

        #endregion

        #region Constructor

        public FrameOXO_D()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "MonacoCoveSS-FrameOXO_D";
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

            // JambL316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4170, "JambL316SS", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Jamb316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////

            // JambL316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4172, "JambL316SS", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Jamb316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////

            // JambL316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4171, "JambL316SS", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Jamb316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // JambR316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4178, "JambR316SS", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Jamb316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////

            // JambR316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4179, "JambR316SS", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Jamb316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////

            // JambR316SS
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4180, "JambR316SS", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Jamb316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Head316SS

            //////////////////////////////////////////////////////////////////////////////

            // Head316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4178, "Head316SS", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Head316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // Head316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4179, "Head316SS", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Head316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // Head316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4180, "Head316SS", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Head316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // Head316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4180, "Head316SS", this, 1, m_subAssemblyWidth - midSpan);
                part.PartGroupType = "Head316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // Head316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4178, "Head316SS", this, 1, m_subAssemblyWidth - midSpan);
                part.PartGroupType = "Head316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            #endregion

            #region HeadCaps316SS

            //////////////////////////////////////////////////////////////////////////////

            // HeadCaps316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4178, "HeadCaps316SS", this, 1, headCap);
                part.PartGroupType = "HeadCaps316SS-Parts";
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
                part = new Part(4087, "BottomAlum1", this, 1, m_subAssemblyWidth - jamB);
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
                part = new Part(4214, "316SSTrackBar1", this, 1, m_subAssemblyWidth - jamB);
                part.PartGroupType = "BottomTrack-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // BottomAlum2
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4087, "BottomAlum2n3", this, 1, m_subAssemblyWidth - trackRedMid - jamB);
                part.PartGroupType = "BottomTrack-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // 316SSTrackBar2
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4214, "316SSTrackBar2n3", this, 1, m_subAssemblyWidth - trackRedMid - jamB);
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
            for (int i = 0; i < 4; i++)
            {
                part = new Part(3445, "Bridge", this, 1, 4.1875m);
                part.PartGroupType = "BottomTrack-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // Bridge
            for (int i = 0; i < 7; i++)
            {
                part = new Part(3445, "Bridge", this, 1, 2.4375m);
                part.PartGroupType = "BottomTrack-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // BridgeClips
            for (int i = 0; i < 22; i++)
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
            for (int i = 0; i < 22; i++)
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
            for (int i = 0; i < 44; i++)
            {
                part = new Part(3450, "FlangeNuts", this, 1, 0.0m);
                part.PartGroupType = "BottomTrack-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // CapNuts
            for (int i = 0; i < 26; i++)
            {
                part = new Part(3449, "CapNuts", this, 1, 0.0m);
                part.PartGroupType = "BottomTrack-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////

            // NutPlate
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3448, "NutPlate", this, 1, 0.0m);
                part.PartGroupType = "BottomTrack-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////////////////////////////////



            #endregion


        }


        #endregion

    }


}