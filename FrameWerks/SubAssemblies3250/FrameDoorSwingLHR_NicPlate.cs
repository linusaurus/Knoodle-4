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

namespace FrameWorks.System3250
{
    
    public class FrameDoorSwingLHR_NicPlate : SubAssemblyBase
    {

        #region Fields

        static int createID;


        #endregion

        #region Constructor

        public FrameDoorSwingLHR_NicPlate()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3250-FrameDoorSwingLHR_NicPlate";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            


            #region Frame-Parts


            // JambL <<-- 
            part = new Part(2952, "JambL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
            
            m_parts.Add(part);


            // JambR -->> 
            part = new Part(2952, "JambR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
            
            m_parts.Add(part);


            // Head ^^
            part = new Part(2952, "Head", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
            
            m_parts.Add(part);


            // Sill ||
            part = new Part(2952, "Sill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
            
            m_parts.Add(part);


            #endregion

            #region HardWare


            // HingeTop
            part = new Part(2982, "HingeTop", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // HingeMid
            part = new Part(2982, "HingeMid", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // HingeBot
            part = new Part(2982, "HingeBot", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // Hinge Backer
            part = new Part(3003, "HingeBacker", this, 3, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // Hinge Backer
            part = new Part(3004, "HingeBacker", this, 3, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // StrikePlate
            part = new Part(1781, "StrikePlate", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // ShootBltStk
            part = new Part(1988, "ShootBltStk", this, 2, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // BRNZ L-BRACE
            part = new Part(1115, "BRNZ L-BRACE", this, 8, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region WeatherSeals


            //FrameSeal
            part = new Part(2274, "FrameSeal", this, 1, ((m_subAssemblyHieght * 2.0m) + (m_subAssemblyWidth * 2.0m)));
            part.PartGroupType = "WeatherSeals-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region Labor

            part = new LPart("MetalHours", this, 9.0m, 80.0m);
            m_parts.Add(part);
            //1 Receive: 1 Handle: 1.5 Cut: 1.5 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("SandLineGrain", this, 2.0m, 80.0m);
            m_parts.Add(part);
            //2 SandLineGrain: 

            #endregion



        }

        #endregion



    }
}
