﻿
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
    
    public class DoorDoubleLatchNarrowRHR : SubAssemblyBase
    {

        #region Fields

        static int createID;
        Part part;
        string partleader;

        #endregion

        #region Constructor

        public DoorDoubleLatchNarrowRHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys2000-DoorDoubleLatchNarrowRHR";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {


            partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region Door-Parts

            // StileL <<--
            part = new Part(2688, "StileL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Door-Parts";
            decimal strikeOrigin = m_subAssemblyHieght - 35.875m;
            part.PartLabel = "1) Miter End" + "\r\n" +
                             "2) Position Origin Strike  " + strikeOrigin.ToString() + "\r\n" +
                             "3) Machine 3127.m";
           
            m_parts.Add(part);


            // StileR -->>
            part = new Part(2688, "StileR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Door-Parts";
            decimal step = (m_subAssemblyHieght - 15.0m);
            step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(m_subAssemblyHieght) - 1));
            step = Math.Round(step, 4);
            int msg = FrameWorks.Functions.HingeCount(m_subAssemblyHieght);
            part.PartLabel = "1) Miter Ends" + "\r\n" +
                             "2) Position 0rigin @ " + (7.5m).ToString() + "\r\n" +
                             "3) Tube Backer Prep-> 3123.m"
                + FrameWorks.Functions.HingeCount(m_subAssemblyHieght).ToString() + "@<" + step.ToString() + ">O.C.";
           
            m_parts.Add(part);



            // RailT ^^
            part = new Part(2688, "RailT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "1) Miter Ends " + "\r\n" +
                             "2) Bore Hole for [1932 pn]-";
           
            m_parts.Add(part);


            // RailB ||
            part = new Part(2688, "RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "1) Miter Ends ";
           
            m_parts.Add(part);


            // Latch Build-out
            part = new Part(2688, "Latch Build-out", this, 1, m_subAssemblyHieght - 2.0m * 1.3125m );
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);



            #endregion

            #region GlassStop-Parts


            // StopL #800
            part = new Part(800, "StopL", this, 1, m_subAssemblyHieght - 2.0m * 1.3125m );
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "1) MiterEnds";
           
            m_parts.Add(part);


            // StopT #800
            part = new Part(800, "StopsT", this, 1, m_subAssemblyWidth - 3.0m * 1.3125m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "1) MiterEnds";
           
            m_parts.Add(part);


            // StopB #800
            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 3.0m * 1.3125m);
            part = new Part(800, "StopB", this, 1, m_subAssemblyWidth - 3.0m * 1.3125m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "1) Miter Ends" + "\r\n" +
                             "2)" + crap;
           
            m_parts.Add(part);


            // StopR #800
            part = new Part(800, "StopR", this, 1, m_subAssemblyHieght - 2.0m * 1.3125m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "1) MiterEnds";
           
            m_parts.Add(part);


            #endregion

            #region Assembly_Hardware-Parts


            //CORNER L-BRACE
            part = new Part(2674, "Corner L-Brace", this, 8, 0.0m);
            part.PartGroupType = "Assembly_Hardware-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            #endregion

            #region Edge-Parts


            // Bottom Filler ||

            part = new Part(1817, "Foam Bottom", this, 1, m_subAssemblyWidth - 1.5m);
            part.PartGroupType = "Edge-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // Hinge EdgeL

            part = new Part(2034, "Hinge EdgeL", this, 1, m_subAssemblyHieght + (0.125m));
            part.PartGroupType = "Edge-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // Hinge EdgeR

            part = new Part(2035, "Euro EdgeR", this, 1, m_subAssemblyHieght + (0.125m));
            part.PartGroupType = "Edge-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            // Euro Top ^^

            part = new Part(2035, "Euro Top", this, 1, m_subAssemblyWidth + (0.125m * 2.0m));
            part.PartGroupType = "Edge-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);





            #endregion

            #region Glass-Parts

            //Glass Panel

            part = new Part(1022);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (1.625m + 2.9375m);
            part.PartLength = m_subAssemblyHieght - (1.625m * 2.0m);
           
            m_parts.Add(part);


            #endregion

            #region Seal-Parts


            // Edge Seal
            part = new Part(1769, "Edge Seal", this, 1, FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth) - m_subAssemblyHieght);
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            //Front Edge Seal
            part = new Part(1829, "Front Edge Seal", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            #endregion

            #region Hardware-Parts


            //DOOR CORNER LEVELER

            part = new Part(1932, "Corner Leveler", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);




            #region Multipoint Lock


            //Multipoint Lock
            FrameWorks.Makes.System3000.Hoppe hoppe = new FrameWorks.Makes.System3000.Hoppe(m_subAssemblyHieght, this);
            foreach (Part innerpart in hoppe.Parts)
            {
               //inner
                this.Parts.Add(innerpart);

            }

            #endregion





            #endregion

                #region Labor


            part = new LPart("Design", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //Collect Information on Sizes: Measure: Provide Information for Approval: Order: Supervision

            part = new LPart("Draft", this, 3.0m, 80.0m);
            m_parts.Add(part);
            //Typical Drawings

            part = new LPart("MetalHours", this, 8.0m, 80.0m);
            m_parts.Add(part);
            //1 Recieve: 1 Handle: 1 CutSash: 1 CutGlassStop: 1.5 Machine: 1.5 Hardware Prep: 1 Mount Hardware: 


            part = new LPart("Finish", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 Sand Linegrain: 2 Finish:

            part = new LPart("GlazingHours", this, (this.Area * 0.17m) + 1.5m, 80.0m);
            m_parts.Add(part);
            //.5 Recieve: .5 InspectReject: .5 StoreHandle: * .17 Hrs Per Square Ft: 

            part = new LPart("Prehang", this, (this.Area * .10m) + 3.0m, 80.0m);
            m_parts.Add(part);
            //2 FitSash into Frame: 1 Mount Weather Strips/Seals

            part = new LPart("Stage", this, 1.0m, 80.0m);
            m_parts.Add(part);
            //1 Stage

            part = new LPart("Load", this, 1.0m, 80.0m);
            m_parts.Add(part);
            //1 Load



            #endregion


        }

        #endregion




    }
}