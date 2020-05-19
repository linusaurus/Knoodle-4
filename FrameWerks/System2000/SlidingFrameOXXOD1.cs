﻿#region Copyright (c) 2010 WeaselWare Software
/************************************************************************************
'
' Copyright  2010 WeaselWare Software 
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
' Portions Copyright 2010 WeaselWare Software
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

namespace FrameWorks.Makes.System2000
{
    
    public class SlidingFrameOXXOD1 : SubAssemblyBase
    {


        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public SlidingFrameOXXOD1()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "SlidingFrameOXXOD1";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            System3000.Helper.SliderOXXHelper helper = new System3000.Helper.SliderOXXHelper(3, 1, m_subAssemblyWidth);

            #region Frame


            // TopTrack
            part = new Part(1416, "TopTrack", this, 1, m_subAssemblyWidth -  0.1875m * 2.0m );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // HeadHanger
            part = new Part(2096, "HeadHanger", this, 2, m_subAssemblyWidth - 0.1875m + 1.25m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // SplitHeadIn
            part = new Part(799, "SplitHeadIn", this, 1, m_subAssemblyWidth - 0.0625m - 0.625m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // SplitHeadOut
            part = new Part(799, "SplitHeadOut", this, 1, m_subAssemblyWidth - 0.0625m - 0.625m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // StrikeJambL 
            part = new Part(2304, "StrikeJambL", this, 1, m_subAssemblyHieght + 2.901m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // StrikeJambR 
            part = new Part(2304, "StrikeJambR", this, 1, m_subAssemblyHieght + 2.901m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // JambHangerInL 
            part = new Part(2098, "JambHangerInL", this, 4, m_subAssemblyHieght + 2.901m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // SplitJambOutL
            part = new Part(799, "SplitJambOutL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // SplitJambInR
            part = new Part(799, "SplitJambInR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // SplitJambOutR
            part = new Part(799, "SplitJambOutR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // SplitJamb
            part = new Part(799, "SplitJamb", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            #endregion

            #region Slot Drain


            // SlotDrain
            part = new Part(215, "SlotDrain", this, 1, m_subAssemblyWidth + 1.0m + 1.0m);
            part.PartGroupType = "Drain-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // DrainCaps
            part = new Part(2328, "DrainCaps", this, 2, 0.0m);
            part.PartGroupType = "Drain-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // DrainBlocks
            part = new Part(2085, "DrainBlocks", this, 5, 0.0m);
            part.PartGroupType = "Drain-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            #endregion

            #region Weatherseals


            // PileSH
            part = new Part(978, "PileSH", this, 2, m_subAssemblyWidth - 0.625m - 0.625m);
            part.PartGroupType = "Weatherseals-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // PileSJ 
            part = new Part(978, "PileSJ", this, 4, m_subAssemblyHieght);
            part.PartGroupType = "Weatherseals-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // PileDRN
            part = new Part(978, "PileDRN", this, 2, m_subAssemblyWidth + 1.0m + 1.0m);
            part.PartGroupType = "Weatherseals-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);




            #endregion

            #region Hardware






            #endregion

            #region Labor


            part = new LPart("MetalHours",this, 9.0m, 80.0m);
            this.m_parts.Add(part);
            //1 Receive: 1 Handle: 1.5 Cut: 1.5 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("Finish",this, (this.Area * 0.025m) + 2.0m, 80.0m);
            this.m_parts.Add(part);
            //1.0 Sand Linegrain: 1.0 Finish:

            part = new LPart("PaintAno",this, (this.Area * 0.065m) + 0.0005m, 80.0m);
            this.m_parts.Add(part);
            // .0005 hours + 0.065 Area


            #endregion



        }

        #endregion



    }
}

