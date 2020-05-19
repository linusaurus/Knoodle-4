


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

    
    public class DoorFrameRH : SubAssemblyBase
    {

        #region Fields

        Part part;
        string partleader;

        #endregion

        #region Constructor

        public DoorFrameRH()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys3000-DoorFrameRH";
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

            #region Door-Frame





            // JambLeft <<--
            decimal doorPanel = decimal.Zero;
            doorPanel = 97.5m;
            //doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;
            part = new Part(801, "JambL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            decimal leverheight = 0.875m + doorPanel - 35.8750m;
            part.PartLabel = "1) MiterTop ->\r\n" +
                             "2) [????.m]Cope Jamb Bottom ->\r\n" +
                             "3) [3102.m]Position Origin TOU @ < " + leverheight.ToString() + " >O.C.";
            
            m_parts.Add(part);
 


            
            // JambRight -->>
            part = new Part(801, "JambR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            decimal step = (doorPanel - 15.0m);
            step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(doorPanel) - 1));
            step = Math.Round(step, 4);
            //string msg = "";
            part.PartLabel = "1) MiterTop\r\n" +
                              "2) [????.m]Cope Jamb Bottom->\r\n" +
                              "3) Position 0rigin TOU @ < " + (7.5m + 0.875m).ToString() + " > O.C. " + "\r\n" +
                              "4) Backers->3104.m " + FrameWorks.Functions.HingeCount(doorPanel).ToString() + " @<" + step.ToString() + ">O.C.";
            
            m_parts.Add(part);
            
            
            
            // Head ^^
            part = new Part(801, "Head", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1) MiterEnds <-->\r\n" +
                             "2) [3100 .m]Position 0rigin Shoot Strike";
            
            m_parts.Add(part);





            #endregion

            #region HardWare

            // Assembly Braces
            part = new Part(1117, "Assembly Braces", this, 4, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // Plate Backer
            part = new Part(1121, "Plate Backer", this, FrameWorks.Functions.HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // Strike Plate
            part = new Part(1781, "Strike Plate", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // Shoot Strike
            part = new Part(1988, "Shoot Strike ", this, 2, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            #endregion

            #region WeatherSeals

            //Door Bulb Seals
            decimal peri = m_subAssemblyHieght * 2.0m;
            peri += m_subAssemblyWidth;
            part = new Part(1769, "Frame Bulb Seal", this, 1, peri);
            part.PartGroupType = "Seals-Parts";
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







    }
}