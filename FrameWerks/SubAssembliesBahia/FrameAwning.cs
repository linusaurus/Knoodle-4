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

namespace FrameWorks.Makes.Bahia
{

    public class FrameAwning : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public FrameAwning()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-FrameAwning";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region Frame


            // JambL <<-- 

            part = new Part(3394, "JambL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)MachineAwningHinge";
            m_parts.Add(part);



            // JambR -->> 

            part = new Part(3394, "JambR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)MachineAwningHinge";
            m_parts.Add(part);



            // Head ^^

            part = new Part(3394, "Head", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);



            // Sill ||

            part = new Part(3394, "Sill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
            m_parts.Add(part);



            #endregion


            #region Hardware-Parts


            // LockLeft
            part = new Part(1709, "LockLeft", this, 1, 0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";


            // LockRight
            part = new Part(1709, "LockRight", this, 1, 0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";



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