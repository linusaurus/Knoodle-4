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
    
    public class SlidingFrameOXD2 : SubAssemblyBase
    {


        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public SlidingFrameOXD2()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "SlidingFrameOXD2";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            
            System3000.Helper.SliderOXXHelper helper = new System3000.Helper.SliderOXXHelper(3, 2, m_subAssemblyWidth);



            #region Frame


            // TopTrack
            part = new Part(1416, "TopTrack", this, 1, m_subAssemblyWidth + 4.625m - 0.191m );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // HeadHanger
            part = new Part(2096, "HeadHanger", this, 2, m_subAssemblyWidth + 1.25m );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // SplitHeadIn
            part = new Part(799, "SplitHeadIn", this, 1, m_subAssemblyWidth  + 4.0m );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // SplitHeadOut
            part = new Part(799, "SplitHeadOut", this, 1, m_subAssemblyWidth + 4.0m );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // PVC EndCapHanger
            part = new Part(2319, "EndCapHanger", this, 2, 3.125m );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // EndCap
            part = new Part(2321, "EndCap", this, 2, 3.125m );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);



            #endregion

            #region Slot Drain



            // SlotDrain
            part = new Part(215, "SlotDrain", this, 1, m_subAssemblyWidth + 5.625m + 1.25m );
            part.PartGroupType = "Drain-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // DrainCaps
            part = new Part(2328, "DrainCaps", this, 2, 0.0m );
            part.PartGroupType = "Drain-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // DrainBlocks
            part = new Part(2085, "DrainBlocks", this, 2, 0.0m );
            part.PartGroupType = "Drain-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            #endregion

            #region Pile Seals


            // PileSH
            part = new Part(978, "PileSH", this, 2, m_subAssemblyWidth + 4.625m - 0.625m );
            part.PartGroupType = "Pile-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // PileSD
            part = new Part(978, "PileSD", this, 2, m_subAssemblyWidth + 5.625m + 1.25m );
            part.PartGroupType = "Pile-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // PileEC
            part = new Part(978, "EndCapPile", this, 2, 3.125m);
            part.PartGroupType = "Pile-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);



            #endregion

            #region Hardware


            // CornerBrace
            part = new Part(2313, "CornerBrace", this, 4, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // BHScrews
            part = new Part(1439, "BHScrews", this, 8, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            #endregion

            #region Labor

            part = new LPart("MetalHours",this, 9.0m, 80.0m);
            m_parts.Add(part);
            //1 Receive: 1 Handle: 1.5 Cut: 1.5 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("FinishHours",this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 SandLineGrain: 2 Finish

            part = new LPart("PaintAno",this, (this.Area * 0.05m) + 0.0005m, 40.0m);
            m_parts.Add(part);
            // .0005 hours + 0.05 Area







            #endregion


        }

        #endregion

    }
}

