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
    
    public class DoorBiFold : SubAssemblyBase
    {

        #region Fields


        Part part;
        string partleader;

        #endregion

        #region Constructor

        public DoorBiFold()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys3000-DoorBiFold";


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


            #region Panel-Frame

            // StileRight -->>
            part = new Part(2813, "StileR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // StileLeft <<--
            part = new Part(2813, "StileL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // RailTop ^^
            part = new Part(2813, "RailT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // RailBottom ||  
            part = new Part(2813, "RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Panel-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);



            #endregion

            #region WeatherSeals

            //WeatherSeal
            part = new Part(2815, "WeatherSeal", this, 1, (m_subAssemblyHieght * 4.0m)) ;
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region Glass


            //Glass Panel

            part = new Part(2828);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (0.25m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (0.25m * 2.0m);
            
            m_parts.Add(part);



            #endregion

                #region Labor

            part = new LPart("Design",this, 4.0m, 80.0m);
            m_parts.Add(part);
            //Measure: Collect Information on Sizes from Contractor: Provide Information for Approval: Samples Correspondence: Ordering: Supervision

            part = new LPart("Draft",this, 3.0m, 80.0m);
            m_parts.Add(part);
            //Typical Drawings: Supervision

            part = new LPart("MetalHours",this, 10.0m, 80.0m);
            m_parts.Add(part);
            //1 Recieve: 1 Handle: 1 CutFrame: 1 CutStop: 1.5 Machine: 1.5 HardwarePrep: 1 MountHardware: 2 Weld: 

            part = new LPart("FinishHours",this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 LinegrainSand: 2 Finish

            part = new LPart("GlazingHours",this, (this.Area * 0.1m) + 4.5m, 80.0m);
            m_parts.Add(part);
            //.5 Recieve: 1.0 InspectReject: .5 StoreHandle: 1.0 GlazeShimCalk: .5 SetGlassStop: 05 InsertGasket 

            part = new LPart("Prehang",this, (this.Area * 0.1m) + 3.0m, 80.0m);
            m_parts.Add(part);
            //2 Fit Sash into Frame: 1 Mount Weather StripSeals

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