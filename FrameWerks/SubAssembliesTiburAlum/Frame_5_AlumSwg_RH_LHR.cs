#region Copyright (c) 2012 WeaselWare Software
/************************************************************************************
'
' Copyright  2012 WeaselWare Software 
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
' Portions Copyright 2012 WeaselWare Software
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
using System.Diagnostics;

namespace FrameWorks.Makes.TiburAlum
{

    public class Frame_5_AlumSwg_RH_LHR : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal centerReduce = 0.1385125m;
        const decimal frameReduce = 0.672564m;
        const decimal glassReduce = 0.500001m;



        static int createID;

        #endregion

        #region Constructor

        public Frame_5_AlumSwg_RH_LHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "TiburAlum-Frame_5_AlumSwg_RH_LHR";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region Frame-Parts


            // Head2 ^^
            part = new Part(3618, "Head2", this, 1, m_subAssemblyWidth - frameReduce * 2.0m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds\r\n" +
                             "2)[1987.m]Position 0rigin Shoot Strike";

            m_parts.Add(part);


            // Head3 ^^
            part = new Part(3620, "Head3", this, 1, m_subAssemblyWidth - frameReduce * 2.0m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);
   


            // JambL2 <<--
            decimal doorPanel = decimal.Zero;

            doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;

            part = new Part(3618, "JambL2", this, 1, m_subAssemblyHieght - frameReduce);
            part.PartGroupType = "Frame-Parts";
            decimal step = (doorPanel - 15.0m);
            step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(doorPanel) - 1));
            step = Math.Round(step, 4);
            string msg = "";
            part.PartLabel = "1) MiterTop\r\n" +
                             "2) [911.m]Cope Jamb Bottom->\r\n" +
                             "3) Position 0rigin TOU @ ->" + (7.5m + 0.875m).ToString() + "\r\n" +
                    FrameWorks.Functions.HingeCount(doorPanel).ToString() + "@<" + step.ToString() + ">O.C.";

            m_parts.Add(part);


            // JambR2 -->> 
            part = new Part(3618, "JambR2", this, 1, m_subAssemblyHieght - frameReduce);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterTop\r\n" +
                             "2)[1962.m]Position 0rigin Strike Plate\r\n" +
                             "3)Cope Jamb Bottom";

            m_parts.Add(part);



            // JambL3 <<--
            part = new Part(3620, "JambL3", this, 1, m_subAssemblyHieght - frameReduce);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterTop\r\n" +
                             "2)Cope Jamb Bottom";

            m_parts.Add(part);


            // JambR3 -->>
            part = new Part(3620, "JambR3", this, 1, m_subAssemblyHieght - frameReduce);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterTop\r\n" +
                             "2)Cope Jamb Bottom";

            m_parts.Add(part);




            #endregion


            #region HardWare



            // Strike Plate
            part = new Part(3903, "Strike Plate", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // Shoot Strike 
            part = new Part(1987, "Shoot Strike", this, 2, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);





            #endregion


            #region Seal/Weatherstripping


            //Sash Edge Seal
            part = new Part(2274, "Edge Seal", this, 1, m_subAssemblyHieght * 2 + m_subAssemblyWidth);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion


            #region Labor

            part = new LPart("MetalHours", this, 8.0m, 80.0m);
            this.m_parts.Add(part);
            //1 Receive: 1 Handle: 1 Cut: 1 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("Finish", this, (this.Area * 0.025m) + 2.0m, 80.0m);
            this.m_parts.Add(part);
            //1.0 Sand Linegrain: 1.0 Finish:

            part = new LPart("PaintAno", this, (this.Area * 0.065m) + 0.0005m, 80.0m);
            this.m_parts.Add(part);
            // .0005 hours + 0.065 Area

            #endregion



        }



        #endregion


    }
}