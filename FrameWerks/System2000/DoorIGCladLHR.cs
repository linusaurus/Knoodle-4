
#region Copyright (c) 2011 WeaselWare Software
/************************************************************************************
'
' Copyright  2011 WeaselWare Software 
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
' Portions Copyright 2011 WeaselWare Software
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

    public class DoorIGCladLHR : SubAssemblyBase
    {

        #region Fields

        static int createID;
        Part part;
        string partleader;

        #endregion

        #region Constructor

        public DoorIGCladLHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys2000-DoorIGCladLHR";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {


            partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region Core


            // CoreL <<--

            part = new Part(3152, "CoreL", this, 1, m_subAssemblyHieght - .625m * 2.0m);
            part.PartGroupType = "Core";
            decimal step = (m_subAssemblyHieght - 15.0m);
            step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(m_subAssemblyHieght) - 1));
            step = Math.Round(step, 4);
            int msg = FrameWorks.Functions.HingeCount(m_subAssemblyHieght);
            part.PartLabel = "1) Miter Ends" + "\r\n" +
                             "2) Weld Ends" + "\r\n" +
                             "3) Position 0rigin @ " + (7.5m).ToString() + "\r\n" +
                             "4) Tube Backer Prep-> 3123.m"
            + FrameWorks.Functions.HingeCount(m_subAssemblyHieght).ToString() + "@<" + step.ToString() + ">O.C.";

            m_parts.Add(part);



            // CoreR -->>

            part = new Part(3152, "CoreR", this, 1, m_subAssemblyHieght - .625m * 2.0m);
            part.PartGroupType = "Core";
            decimal strikeOrigin = m_subAssemblyHieght - 35.875m;
            part.PartLabel = "1) Miter Ends " + "\r\n" +
                             "2) Weld" + "\r\n" +
                             "2) Position Origin Strike  " + strikeOrigin.ToString() + "\r\n" +
                             "3) Machine 3127.m"; 
            m_parts.Add(part);



            // CoreT ^^

            part = new Part(3152, "CoreT", this, 1, m_subAssemblyWidth - .625m * 2.0m);
            part.PartGroupType = "Core";
            part.PartLabel = "1) Miter Ends " + "\r\n" +
                             "2) Bore Hole for [1932 pn]" + "\r\n" +
                             "3) Weld";
            m_parts.Add(part);


            // CoreB ||

            part = new Part(3152, "CoreB", this, 1, m_subAssemblyWidth - .625m * 2.0m);
            part.PartGroupType = "Core";
            part.PartLabel = "1) Miter Ends " + "\r\n" +
                             "2) Weld";
            m_parts.Add(part);


            #endregion

            #region CladExt



            // StileExtL <<--

            part = new Part(3150, "StileExtL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "CladExt";
            //decimal step = (m_subAssemblyHieght - 15.0m);
            //step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(m_subAssemblyHieght) - 1));
            //step = Math.Round(step, 4);
            //int msg = FrameWorks.Functions.HingeCount(m_subAssemblyHieght);
            part.PartLabel = "1) Miter Ends" + "\r\n" +
                             "2) Position 0rigin @ " + (7.5m).ToString() + "\r\n" +
                             "3) Tube Backer Prep-> 3123.m";
            //+ FrameWorks.Functions.HingeCount(m_subAssemblyHieght).ToString() //+ "@<" + //step.ToString() + ">O.C.";
            m_parts.Add(part);



            // StileExtR -->>

            part = new Part(3150, "StileExtR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "CladExt";
            part.PartLabel = "1) Miter End" + "\r\n" +
                             "2) Position Origin Strike  " + strikeOrigin.ToString() + "\r\n" +
                             "3) Machine 3127.m";
            m_parts.Add(part);


            // RailExtT ^^

            part = new Part(3150, "RailExtT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CladExt";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);


            // RailExtB ||

            part = new Part(3150, "RailExtB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CladExt";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);



               #endregion

            #region CladInt


            // StileIntL <<--

            part = new Part(3151, "StileIntL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Clad";
            part.PartLabel = "1) Miter End" + "\r\n" +
                             "2) Position Origin Strike  " + strikeOrigin.ToString() + "\r\n" +
                             "3) Machine 3127.m";
            m_parts.Add(part);



            // StileIntR -->>

            part = new Part(3151, "StileIntR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Clad";
            //decimal step = (m_subAssemblyHieght - 15.0m);
            //step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(m_subAssemblyHieght) - 1));
            //step = Math.Round(step, 4);
            //int msg = FrameWorks.Functions.HingeCount(m_subAssemblyHieght);
            part.PartLabel = "1) Miter Ends" + "\r\n" +
                             "2) Position 0rigin @ " + (7.5m).ToString() + "\r\n" +
                             "3) Tube Backer Prep-> 3123.m";
            //+ FrameWorks.Functions.HingeCount(m_subAssemblyHieght).ToString() //+ "@<" //+ //step.ToString() + ">O.C.";
            m_parts.Add(part);


            // RailIntT ^^

            part = new Part(3151, "RailIntT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Clad";
            part.PartLabel = "1) Miter Ends " + "\r\n" +
                             "2) Bore Hole for [1932 pn]-";
            m_parts.Add(part);


            // RailIntB ||

            part = new Part(3151, "RailIntB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Clad";
            part.PartLabel = "1) Miter Ends ";
            m_parts.Add(part);


            #endregion

            #region Edge-Parts


            // Bottom Filler ||

            part = new Part(1817, "HDPE Bottom", this, 1, m_subAssemblyWidth - 1.5m);
            part.PartGroupType = "Edge-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // Hinge EdgeL

            part = new Part(1817, "HDPE EdgeL", this, 1, m_subAssemblyHieght + (0.125m));
            part.PartGroupType = "Edge-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // Lock EdgeR

            part = new Part(1817, "HDPE EdgeR", this, 1, m_subAssemblyHieght + (0.125m));
            part.PartGroupType = "Edge-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // Euro Top ^^

            part = new Part(1817, "HDPE Top", this, 1, m_subAssemblyWidth + (0.125m * 2.0m));
            part.PartGroupType = "Edge-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion

            #region Glass


            //Glass Panel

            part = new Part(1022);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (2.59375m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (2.59375m * 2.0m);

            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
           
            m_parts.Add(part);



            #endregion

            #region Seal-Parts


            // Edge Seal
            part = new Part(759, "Silcone", this, 1, FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth)*2.0m);
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // Edge Seal
            part = new Part(2274, "Silcone", this, 1, FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth) );
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

            #endregion

            #region Multipoint Lock


            //Multipoint Lock
            FrameWorks.Makes.System3000.Hoppe hoppe = new FrameWorks.Makes.System3000.Hoppe(m_subAssemblyHieght, this);
            foreach (Part innerpart in hoppe.Parts)
            {
                //inner
                this.Parts.Add(innerpart);

            }

            #endregion

                #region Labor

            part = new LPart("Design", this, 4.0m, 80.0m);
            this.m_parts.Add(part);
            //Collect Information on Sizes: Measure: Provide Information for Approval: Order: Supervision

            part = new LPart("Draft", this, 3.0m, 80.0m);
            this.m_parts.Add(part);
            //Typical Drawings


            part = new LPart("MetalHours", this, 12.0m, 80.0m);
            this.m_parts.Add(part);
            //1 Recieve: 1 Handle: 1 CutSash: 1 CutGlassStop: 1.5 Machine: 1.5 Hardware Prep: 1 Mount Hardware: 4 Weld:

            part = new LPart("Finish", this, 4.0m, 80.0m);
            this.m_parts.Add(part);
            //2 Sand Linegrain: 2 Finish:


            part = new LPart("PaintAno", this, (this.Area * 0.05m) + 0.0005m, 80.0m);
            this.m_parts.Add(part);
            // .0005 hours + 0.05 Area

            part = new LPart("GlazingHours", this, (this.Area * 0.17m) + 1.5m, 80.0m);
            this.m_parts.Add(part);
            //.5 Recieve: .5 InspectReject: .5 StoreHandle: * .17 Hrs Per Square Ft:

            part = new LPart("Prehang", this, (this.Area * .10m) + 3.0m, 80.0m);
            this.m_parts.Add(part);
            //2 FitSash into Frame: 1 Mount Weather Strips/Seals


            part = new LPart("Stage", this, 1.0m, 80.0m);
            this.m_parts.Add(part);
            //1 Stage

            part = new LPart("Load", this, 1.0m, 80.0m);
            this.m_parts.Add(part);
            //1 Load


            #endregion


        }

        #endregion




    }
}