
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
using System.Runtime;


namespace FrameWorks.Makes.System3000
{

    
    public class FrameShowerLHR : SubAssemblyBase
    {

        #region Fields

        Part part;
        string partleader;

        #endregion

        #region Constructor

        public FrameShowerLHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys3000-FrameShowerLHR";
        }

        #endregion

        #region Error Handling

        System.Exception HardwareApplicationError(string description)
        {

            return new SystemException(description);
        }

        #endregion

        //Methods
        public override void Build()
        {

            partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region Jamb-Frame


            // JambLeft <<--
            part = new Part(1167, "JambLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Jamb-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region DoorStop


            part = new Part(2990, "DoorStop-Top", this, 1, m_subAssemblyWidth + (2.0m * 1.3125m));
            part.PartGroupType = "DoorStop-Parts";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);

            part = new Part(2990, "DoorStop-Left", this, 1, m_subAssemblyHieght + (1.0m * 1.3125m));
            part.PartGroupType = "DoorStop-Parts";
            part.PartLabel = "Miter Top";
            
            m_parts.Add(part);

            part = new Part(2990, "DoorStop-Right", this, 1, m_subAssemblyHieght + (1.0m * 1.3125m));
            part.PartGroupType = "DoorStop-Parts";
            part.PartLabel = "Miter Top";
            
            m_parts.Add(part);


            #endregion

            #region CapBronze


            part = new Part(2972, "CapBronze-Jamb", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "CapBronzeJamb-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

           #region Labor

            part = new LPart("MetalHours",this, 8.0m, 80.0m);
            m_parts.Add(part);
            //1 Receive: 1 Handle: 1 Cut: 1 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("FinishHours",this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 SandLineGrain: 2 Finish

            part = new LPart("Patina", this,(this.Area * 0.05m) + 0.0005m, 80.0m);
            m_parts.Add(part);;
            // .0005 hours + 0.05 Area


            #endregion

        }


    }
}