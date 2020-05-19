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

    public class FrameSlider8 : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal frameRedVertX2 = 1.25m;
        const decimal gasketReduce = 1.375m;
        const decimal headRed1 = 46.4855m;
        const decimal headRed2 = 92.423m;
        const decimal frameThick = 0.048m;
        const decimal pocketDepth = 45.6250m;



        static int createID;

        #endregion

        #region Constructor

        public FrameSlider8()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "MonacoCoveSS-FrameSlider8";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region Frame316SS

            ///////////////////////////////////////////////////////////////////////////////

            // 316SSHeadEXTlead
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4197, "316SSHeadEXTlead", this, 1, 46.48548592m);
                part.PartGroupType = "Frame316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // 316SSHeadEXTmid
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4197, "316SSHeadEXTmid", this, 1, 46.03351013m);
                part.PartGroupType = "Frame316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // 316SSHeadEXTrear
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4197, "316SSHeadEXTrear", this, 1, 48.67301013m);
                part.PartGroupType = "Frame316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // 316SSHeadEXTCap
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4197, "316SSHeadEXTCap", this, 1, 1.84601013m);
                part.PartGroupType = "Frame316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // 316SSHead1
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4196, "316SSHead1", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Frame316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // 316SSHead2
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4196, "316SSHead2", this, 1, m_subAssemblyWidth - headRed1);
                part.PartGroupType = "Frame316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // 316SSHead3
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4196, "316SSHead3", this, 1, m_subAssemblyWidth - headRed2);
                part.PartGroupType = "Frame316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // 316SSjAMB
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4193, "316SSJamb", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Frame316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // 316SSjAMBpoc
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4194, "316SSjAMBpoc", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Frame316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////


            #endregion

            #region TrackHead

            ///////////////////////////////////////////////////////////////////////////////

            // TrackHead1
            for (int i = 0; i < 1; i++)
            {
                part = new Part(1416, "TrackHead1", this, 1, m_subAssemblyWidth - frameThick + pocketDepth);
                part.PartGroupType = "TrackHead-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // TrackHead2
            for (int i = 0; i < 1; i++)
            {
                part = new Part(1416, "TrackHead2", this, 1, m_subAssemblyWidth - headRed1 + pocketDepth);
                part.PartGroupType = "TrackHead-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // TrackHead3
            for (int i = 0; i < 1; i++)
            {
                part = new Part(1416, "TrackHead3", this, 1, m_subAssemblyWidth - headRed2 + pocketDepth);
                part.PartGroupType = "TrackHead-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////

            #endregion

            #region SlotDrain

            ///////////////////////////////////////////////////////////////////////////////

            // SlotDrain1
            for (int i = 0; i < 1; i++)
            {
                part = new Part(215, "SlotDrain1", this, 1, m_subAssemblyWidth - frameThick + pocketDepth);
                part.PartGroupType = "SlotDrain-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // SlotDrain2
            for (int i = 0; i < 1; i++)
            {
                part = new Part(215, "SlotDrain2", this, 1, m_subAssemblyWidth - headRed1 + pocketDepth);
                part.PartGroupType = "SlotDrain-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // SlotDrain3
            for (int i = 0; i < 1; i++)
            {
                part = new Part(215, "SlotDrain3", this, 1, m_subAssemblyWidth - headRed2 + pocketDepth);
                part.PartGroupType = "SlotDrain-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////

            // PileKerFin1
            for (int i = 0; i < 2; i++)
            {
                part = new Part(911, "PileKerFin1", this, 1, m_subAssemblyWidth - frameThick + pocketDepth);
                part.PartGroupType = "PileKerFin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // PileKerFin2
            for (int i = 0; i < 2; i++)
            {
                part = new Part(911, "PileKerFin2", this, 1, m_subAssemblyWidth - headRed1 + pocketDepth);
                part.PartGroupType = "PileKerFin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // PileKerFin3
            for (int i = 0; i < 2; i++)
            {
                part = new Part(911, "PileKerFin3", this, 1, m_subAssemblyWidth - headRed2 + pocketDepth);
                part.PartGroupType = "PileKerFin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////


            #endregion

        }


        #endregion

    }


}