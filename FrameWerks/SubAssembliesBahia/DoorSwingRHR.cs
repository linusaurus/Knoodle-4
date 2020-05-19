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
using FrameWorks.Makes.System3000;


namespace FrameWorks.Makes.Bahia
{

    public class DoorSwingRHR : SubAssemblyBase
    {

        #region Fields

        static int createID;
        Part part;
        string partleader;

        #endregion

        #region Constructor

        public DoorSwingRHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-DoorSwingRHR";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;



            #region DoorPanel



            // StileL <<--


            part = new Part(3400, "StileL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Door-Parts";
            decimal strikeOrigin = m_subAssemblyHieght - 35.875m;
            part.PartLabel = "1) Miter End" + "\r\n" +
                             "2) Position Origin Strike  " + strikeOrigin.ToString() + "\r\n" +
                             "3) Machine 3127.m";

            m_parts.Add(part);



            // StileR -->>

            part = new Part(3400, "StileR", this, 1, m_subAssemblyHieght);
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

            part = new Part(3400, "RailT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "1) Miter Ends " + "\r\n" +
                             "2) Bore Hole for [1932 pn]-";

            m_parts.Add(part);




            // RailB ||

            part = new Part(3400, "RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "1) Miter Ends ";

            m_parts.Add(part);




            #endregion


            #region GlassStop



            // Stop-L #3396
            part = new Part(3396, "GlassStop-L", this, 1, m_subAssemblyHieght - 2 * 2.6875m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // Stop-R #3396
            part = new Part(3396, "GlassStop-R", this, 1, m_subAssemblyHieght - 2 * 2.6875m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // Stop-T #3396

            part = new Part(3396, "GlassStop-T", this, 1, m_subAssemblyWidth - 2 * 2.6875m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // Stop-B #3396

            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 2 * 2.6875m);
            part = new Part(3396, "GlassStop-B", this, 1, m_subAssemblyWidth - 2 * 2.6875m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + crap;

            m_parts.Add(part);




            #endregion


            #region Glass

            //Glass Panel
            part = new Part(1022);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (3.00m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (3.00m * 2.0m);
            part.PartThick = 1.25m;

            m_parts.Add(part);

            #endregion


            #region HardWare Logic



            // Hinges
            part = new Part(1879, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // Tube Backer
            part = new Part(1640, "Tube Backer", this, HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            Hoppe hoppe = new Hoppe(m_subAssemblyHieght, this);
            foreach (Part innerpart in hoppe.Parts)
            {
                //inner
                this.Parts.Add(innerpart);

            }

            #endregion


            #region Seal/Weatherstripping


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //Sash Edge Seal
            part = new Part(2274, "Edge Seal", this, 1, peri);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            for (int i = 0; i < 2; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 3.03125m, m_subAssemblyWidth - 3.03125m);

                //Glazing Seals
                part = new Part(2772, "Glazing Seal", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }



            // Door Bottom
            part = new Part(1518, "Door Bottom", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



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

        private int HingeCount(decimal HingeAxisLength)
        {
            int result = 0;

            if (HingeAxisLength < 84.0m)
            {
                result = 3;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 114.0m))
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 114.0m) && (HingeAxisLength < 134.0m))
            {
                result = 5;
            }
            else if ((HingeAxisLength >= 134.0m) && (HingeAxisLength < 164.0m))
            {
                result = 6;
            }


            return result;
        }

        // private void PickMultiPoint(decimal HingeAxisLength)
        //{


        //    if (HingeAxisLength < 76.61m)
        //    {

        //      //throw HardwareApplicationError("Multipoint Hinge System exceeds Minumum Size");


        //    }
        //    else if ((HingeAxisLength > 76.61m) && (HingeAxisLength <= 80.0m))
        //    {
        //       //Multipoint Set for 76.61 <<>> 80.00
        //       part = new Part(-1,"Top Extension",this,1,1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778611]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778611]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 80.0m) && (HingeAxisLength <= 83.0m))
        //    {

        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778615]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778615]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);


        //    }
        //    else if ((HingeAxisLength > 83.0m) && (HingeAxisLength <= 86.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778619]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778619]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }

        //    else if ((HingeAxisLength > 86.0m) && (HingeAxisLength <= 89.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778623]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778623]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }

        //    else if ((HingeAxisLength > 89.0m) && (HingeAxisLength <= 92.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778627]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778627]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 92.0m) && (HingeAxisLength <= 95.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778631]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778631]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 95.0m) && (HingeAxisLength <= 98.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778611]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778611]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 98.0m) && (HingeAxisLength <= 101.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778615]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778615]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 101.0m) && (HingeAxisLength <= 104.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778619]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778619]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 104.0m) && (HingeAxisLength <= 107.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778623]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778623]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 107.0m) && (HingeAxisLength <= 110.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778627]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778627]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 110.0m) && (HingeAxisLength <= 113.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778631]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778631]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 113.0m) && (HingeAxisLength <= 115.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778611]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778611]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 115.0m) && (HingeAxisLength <= 118.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778615]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778615]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }

        //    else if ((HingeAxisLength > 118.0m) && (HingeAxisLength <= 121.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778619]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778619]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 121.0m) && (HingeAxisLength <= 124.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778623]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778623]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 124.0m) && (HingeAxisLength <= 127.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778627]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778627]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 127.0m) && (HingeAxisLength <= 130.0m))
        //    {
        //       part = new Part(-1, "Top Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Top Ext [8778631]";
        //       part.PartName = "Top Ext";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778631]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if (HingeAxisLength >130.0m) 
        //    {
        //      // throw HardwareApplicationError("Door Hieght Exceed Hardware Specs");


        //    }


        //    if(HingeAxisLength > 76.61m)
        //    {

        //    if ((HingeAxisLength > 76.61m)&&(HingeAxisLength <= 95.0m))
        //    {
        //       part = new Part(-1, "Middle Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Middle Ext [8778691]";
        //       part.PartName = "Mid Extension Low";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778691]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 95.0m)&&(HingeAxisLength <= 113.0m))
        //    {
        //       part = new Part(-1, "Middle Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Middle Ext [8778695]";
        //       part.PartName = "Mid Extension Mid";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778695]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    else if ((HingeAxisLength > 113.0m)&&(HingeAxisLength <= 130.0m))
        //    {
        //       part = new Part(-1, "Middle Extension", this, 1, 1.0m);

        //       part.PartGroupType = "Hardware-Parts";
        //       part.Source.MaterialDescription = "Hoppe Middle Ext [8778699]";
        //       part.PartName = "Mid Extension Large";
        //       part.PartLabel = "";
        //       part.Source.MaterialName = "Hoppe [8778695]";
        //       part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //       m_parts.Add(part);

        //    }
        //    }



        //    part = new Part(-1, "Multipoint Gear", this, 1, 1.0m);

        //    part.PartGroupType = "Hardware-Parts";
        //    part.Source.MaterialDescription = "Hoppe Gear [8778343]";
        //    part.PartName = "Gear";
        //    part.PartLabel = "";
        //    part.Source.MaterialName = "Hoppe [8778343]";
        //    part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
        //    m_parts.Add(part);


        // }


        #endregion

    }




}