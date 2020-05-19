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

namespace FrameWorks.Makes.System2000
{
    
    public class FrameCaseRHR : SubAssemblyBase
    {

        #region Fields

        static int createID;


        #endregion

        #region Constructor

        public FrameCaseRHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys2000-FrameCaseRHR";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;


            #region Frame-Parts


            // JambL <<-- 

            part = new Part(2028, "JambL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + FrameWorks.Functions.TieBarLockCenter(this.SubAssemblyHieght);
           
            m_parts.Add(part);



            // JambR -->> 

            part = new Part(2028, "JambR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
           
            m_parts.Add(part);



            // Head ^^

            part = new Part(2028, "Head", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)Machine Right PN:995";
           
            m_parts.Add(part);



            // Sill ||

            part = new Part(2028, "Sill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)Machine Operator Right@" + (6.902m) + "O.C." + "\r\n" +
                             "3)Machine Right PN:996";
           
            m_parts.Add(part);



            #endregion

            #region Hardware-Parts


            // Operator Casement

            part = new Part(FrameWorks.Functions.OperatorSeries23(SubAssemblyWidth, "LH"), "OperatorLH", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // FoldingHandle
            part = new Part(318, "FoldingHandle", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);



            // Gasket23

            part = new Part(2652, "Gasket23", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);





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
            decimal tieBarLength = FrameWorks.Functions.S2000TieBar(m_subAssemblyHieght);

            //check is sash even requires a tiebar
            if (tieBarLength != 0)
            {
                // Tie Bars
                part = new Part(3625, "Tie Bars", this, 1, tieBarLength);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
               
                m_parts.Add(part);
            }



            // Corner Braces

            part = new Part(2674, "CornerBraces", this, 8, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);




            #endregion

                #region Labor

            part = new LPart("MetalHours",this, 8.0m, 80.0m);
            this.m_parts.Add(part);
            //1 Receive: 1 Handle: 1 Cut: 1 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("Finish",this, (this.Area * 0.025m) + 2.0m, 80.0m);
            this.m_parts.Add(part);
            //1.0 Sand Linegrain: 1.0 Finish:

            part = new LPart("PaintAno",this, (this.Area * 0.065m) + 0.0005m, 80.0m);
            this.m_parts.Add(part);
            // .0005 hours + 0.065 Area

            #endregion


            }

        #endregion


        }
    }
