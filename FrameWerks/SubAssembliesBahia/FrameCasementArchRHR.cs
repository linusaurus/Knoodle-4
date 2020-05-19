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

    public class FrameCasementArchRHR : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion


        #region Constructor

        // Extra Material for Bending
        const decimal strechGrip = 12.0m;
        const decimal stileWidth = 1.375m;
        const decimal sashGap = 0.25m;
        const decimal stopInset = 0.5625m;




        public FrameCasementArchRHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-FrameCasementArchRHR";
        }

        #endregion


        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            decimal arcLength = FrameWorks.Functions.ArcLength(Convert.ToDouble(m_subAssemblyWidth),Convert.ToDouble(m_subAssemblyDepth) );




            #region Frame



            // ArchedHead ^^
            part = new Part(3394, "ArchedHead", this, 1, arcLength + ( 2.0m * strechGrip));
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)StretchForm" + "\r\n"+
                             "2)MiterEnds";

            m_parts.Add(part);



            // JambL <<-- 
            part = new Part(3394, "JambR", this, 1, m_subAssemblyHieght - m_subAssemblyDepth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + FrameWorks.Functions.TieBarLockCenter(this.SubAssemblyHieght);

            m_parts.Add(part);



            // JambR -->>
            part = new Part(3394, "JambL", this, 1, m_subAssemblyHieght - m_subAssemblyDepth);
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



            //LockLogic

            int hardwarecount = 1;
            if (m_subAssemblyHieght < 48.0m)
            {
                hardwarecount = 1;
            }
            else
            {
                hardwarecount = 2;

            }


            // Lock
            part = new Part(1709, "Lock", this, hardwarecount, 0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            //Get the size of the tiebar partNo--
            decimal tieBarLenght = FrameWorks.Functions.S2000TieBar(m_subAssemblyHieght);

            //check is sash even requires a tiebar
            if (tieBarLenght != 0)
            {
                // Tie Bars
                part = new Part(3625, "Tie Bars", this, 1, tieBarLenght);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }


            // SupportBlockR
            part = new Part(2995, "SupportBlockR", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
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