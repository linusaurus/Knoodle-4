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


namespace FrameWorks.Makes.Bahia
{

    public class AwningSash : SubAssemblyBase
    {

        #region Fields

        //static int createID;


        #endregion

        #region Constructor

        public AwningSash()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-AwningSash";
            this.WrkOrder = new Workorder(this, 1);
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


            #region Sash


            // StileL <<--
            part = new Part(3397, "StileL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL = "1)MiterEnds" + "\r\n" +
                                           "2)MachineHingeAwning";

            m_parts.Add(part);



            // StileR -->>
            part = new Part(3397, "StileR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR = "1)MiterEnds" + "\r\n" +
                                           "2)MachineHingeAwning";

            m_parts.Add(part);



            // RailT ^^
            part = new Part(3397, "RailT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail;

            m_parts.Add(part);



            // RailB ||
            part = new Part(3397, "RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail;

            m_parts.Add(part);



            #endregion

            #region GlassStop



            // Stop-L #3396
            part = new Part(3396, "GlassStop-L", this, 1, m_subAssemblyHieght - 2 * .5625m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // Stop-R #3396
            part = new Part(3396, "GlassStop-R", this, 1, m_subAssemblyHieght - 2 * .5625m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // Stop-T #3396
            part = new Part(3396, "GlassStop-T", this, 1, m_subAssemblyWidth - 2 * .5625m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // Stop-B #3396
            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 2 * .5625m);
            part = new Part(3396, "GlassStop-B", this, 1, m_subAssemblyWidth - 2 * .5625m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + crap;

            m_parts.Add(part);




            #endregion

            #region Glass

            //Glass Panel

            part = new Part(3392);

            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;

            part.PartWidth = m_subAssemblyWidth - (.875m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (.875m * 2.0m);

            m_parts.Add(part);

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

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 0.435618m, m_subAssemblyWidth - 0.435618m);

                //Glazing Seals
                part = new Part(2772, "Glazing Seal", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion

            #region HardWare Logic


            // Hinges
            decimal _wieght = FrameWorks.Functions.PanelWieghtS3000(SubAssemblyWidth, SubAssemblyHieght);
            decimal hingesize = SubAssemblyHieght;
            string id = this.Parent.UnitID.ToString();
            if (_wieght < 250.0m)
            {

                part = new Part(Functions.S3000AwningHinge(hingesize), "Awning Hinge", this, 2, 0.0m);
                part.PartGroupType = "Hardware-Parts";

                m_parts.Add(part);

            }
            else
            {

                string message = "The Component is too heavy-" + id.ToString();
                Debug.WriteLine(message);
            }

            int hardwarecount = 1;
            if (m_subAssemblyHieght < 48.0m)
            {
                hardwarecount = 1;
            }
            else
            {
                hardwarecount = 2;

            }


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