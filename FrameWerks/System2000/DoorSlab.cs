
#region Copyright (c) 2010 WeaselWare Software
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
    
    public class DoorSlab : SubAssemblyBase
    {

        #region Fields

        static int createID;
        Part part;
        string partleader;

        #endregion

        #region Constructor

        public DoorSlab()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys2000-DoorSlab";
            this.WrkOrder = new Workorder(this,1);
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {


           



            #region Door-Parts


            // StileL <<--
            part = new Part(2931, "StileL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Door-Parts";
            decimal strikeOrigin = m_subAssemblyHieght - 0.0m;
            part.PartLabel = "";
           
            m_parts.Add(part);


            // StileR -->>
            part = new Part(2931, "StileR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Door-Parts";
            decimal step = (m_subAssemblyHieght - 15.0m);
            step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(m_subAssemblyHieght) - 1));
            step = Math.Round(step, 4);
            int msg = FrameWorks.Functions.HingeCount(m_subAssemblyHieght);
            part.PartLabel = ""
                + FrameWorks.Functions.HingeCount(m_subAssemblyHieght).ToString() + "@<" + step.ToString() + ">O.C.";
           
            m_parts.Add(part);


            // RailT ^^
            part = new Part(2571, "RailT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // RailB ||
            part = new Part(2571, "RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // Core []
            part = new Part(2933, "Core", this, 1, m_subAssemblyHieght);
            part.PartWidth = m_subAssemblyWidth;
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "1)M Plow";
           
            m_parts.Add(part);


            //1/4 MDF Side 1
            part = new Part(2884, "MDF1", this, 1, m_subAssemblyHieght);
            part.PartWidth = m_subAssemblyWidth;
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "1)M Plow";
           
            m_parts.Add(part);


            //1/4 MDF Side 2
            part = new Part(2884, "MDF2", this, 1, m_subAssemblyHieght);
            part.PartWidth = m_subAssemblyWidth;
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "1)M Plow";
           
            m_parts.Add(part);


            #endregion

            #region Seal-Parts


            // Edge Seal
            part = new Part(1769, "Edge Seal", this, 1, FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth) - m_subAssemblyHieght);
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            #endregion

             #region Labor

            part = new LPart("Design",this, 4.0m, 80.0m);
            m_parts.Add(part);
            //Collect Information on Sizes: Measure: Provide Information for Approval: Order: Supervision

            part = new LPart("Draft",this, 3.0m, 80.0m);
            m_parts.Add(part);
            //Typical Drawings

            part = new LPart("WoodHours",this, 9.0m, 80.0m);
            m_parts.Add(part);
            //1 Recieve: 1 Handle: 1 CutBand: 1 Laminate: 1.5 Machine: 1.5 Hardware Prep: 1 Mount Hardware: 1 Mill:

            part = new LPart("Finish",this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 Sand Linegrain: 2 Finish:

            part = new LPart("Prehang",this, (this.Area * .10m) + 3.0m, 80.0m);
            m_parts.Add(part);
            //2 FitSash into Frame: 1 Mount Weather Strips/Seals

            part = new LPart("Stage",this, 1.0m, 80.0m);
            m_parts.Add(part);
            //1 Stage

            part = new LPart("Load",this, 1.0m, 80.0m);
            m_parts.Add(part);
            //1 Load


            #endregion


        }

        #endregion






    }
}