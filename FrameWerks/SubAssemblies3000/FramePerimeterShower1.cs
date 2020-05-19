#region Copyright (c) 2007 WeaselWare Software
/************************************************************************************
'
' Copyright  2007 WeaselWare Software 
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
' Portions Copyright 2007 WeaselWare Software
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
using System.Runtime;

namespace FrameWorks.Makes.System3000
{
    
    public class FramePerimeterShower : SubAssemblyBase
    {

        #region Fields


        Part part;
        string partleader;

        #endregion

        #region Constructor

        public FramePerimeterShower()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys3000-FramePerimeterShower";

        }

        #endregion

        #region Error Handling

        System.Exception HardwareApplicationError(string description)
        {

            return new SystemException(description);
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region Shower-Frame


            // CornerPost
            part = new Part(2970, "CornerPost", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // MullionV
            part = new Part(2970, "MullionV", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // JambRightW
            part = new Part(2970, "JambRightW", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // JambLeftW
            part = new Part(2970, "JambLeftW", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // JambRightP
            part = new Part(2970, "JambRightP", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // JambLeftP
            part = new Part(2970, "JambRightP", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // MullionH
            part = new Part(2970, "MullionH", this, 1, m_subAssemblyWidth - 12.0m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // HeadD
            part = new Part(2970, "HeadD", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            //Threshold/SillD
            part = new Part(2970, "Threshold/SillD", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // HeadW
            part = new Part(2970, "HeadW", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            //Threshold/SillW
            part = new Part(2970, "Threshold/SillW", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion


                 #region Labor


            part = new LPart("MetalHours", this, 9.0m, 80.0m);
            m_parts.Add(part);
            //1 Receive: 1 Handle: 1.5 Cut: 1.5 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("FinishHours", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 SandLineGrain: 2 Finish




            #endregion

        }

        #endregion

    }
}