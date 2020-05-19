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
using System.Linq;
using FrameWorks;

namespace FrameWorks.Makes.System2000
{
    
    public class FrameDoorLHR : SubAssemblyBase
    {

        #region Fields

        static int createID;


        #endregion

        #region Constructor

        public FrameDoorLHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys2000-FrameDoorLHR";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;

            #region Frame-Parts


            // JambL -->>  
            decimal doorPanel = decimal.Zero;



            doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;

            part = new Part(2030, "JambL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            decimal step = (doorPanel - 15.0m);
            step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(doorPanel) - 1));
            step = Math.Round(step, 4);
            string msg = "";
            part.PartLabel = "1) MiterTop\r\n" +
                             "2) [3119 .m]Cope Jamb Bottom->\r\n" +
                             "3) Position 0rigin TOU @ ->" + (7.5m + 0.875m).ToString() + "\r\n" +
                             "4) Hinge Backer Prep->[3104.m] "
                   + FrameWorks.Functions.HingeCount(doorPanel).ToString() + "@<" + step.ToString() + ">O.C.";
           
            m_parts.Add(part);



            // JambR -->> 
            part = new Part(2030, "JambR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds\r\n" +
                             "2)[1883.m]Position 0rigin Strike Plate";
           
            m_parts.Add(part);




            // Head ^^
            part = new Part(2030, "Head", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds\r\n" +
                             "2)[1965.m]Position 0rigin Shoot Strike";
           
            m_parts.Add(part);



            // CORNER L-BRACE
            part = new Part(2674, "Corner L-Braces", this, 4, 0.0m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
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

            #region Seal-Parts

            // Weather Seal
            part = new Part(1769, "Weather Seal", this, 1, FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth) - m_subAssemblyWidth);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);




            #endregion

                #region Labor

            part = new LPart("MetalHours",this,8.0m, 80.0m);
            this.m_parts.Add(part);
            //1 Receive: 1 Handle: 1 Cut: 1 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("FinishHours",this, 4.0m, 80.0m);
            this.m_parts.Add(part);
            //2 SandLineGrain: 2 Finish

            part = new LPart("PaintAno",this, (this.Area * 0.05m) + 0.0005m, 80.0m);
            this.m_parts.Add(part);
            // .0005 hours + 0.05 Area

            #endregion






        }

        #endregion


    }
}

