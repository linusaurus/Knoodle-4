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

    public class CasementSashRadiusRHR : SubAssemblyBase
    {

        #region Fields

        // Extra Material for Bending
        const decimal strechGrip = 12.0m;
        const decimal stileWidth = 1.375m;
        const decimal sashGap = 0.25m;
        const decimal stopInset = 0.5625m;

        static int createID;


        #endregion

        #region Constructor

        public CasementSashRadiusRHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-CasementSashRadiusRHR";
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


            //Fuction for Radius Top Rail/Stop
            decimal arcLength = FrameWorks.Functions.RadArc(Convert.ToDouble(m_subAssemblyWidth), 90);

            


            #region Sash



            // RailTArch ^^
            part = new Part(3397, "RailTArch", this, 1, arcLength + (sashGap / 2.0m) + strechGrip );
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail = "StrechForm";

            m_parts.Add(part);



            // StileL <<--
            part = new Part(3397, "StileL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR = "1)MiterBotEnd" + "r\n" +
                                           "2)MachineKeeper";
            m_parts.Add(part);


            // StileR -->>
            part = new Part(3397, "StileR", this, 1, (m_subAssemblyHieght - m_subAssemblyWidth + (3.0m * sashGap)));
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL = "1)MiterBottom" + "r\n" +
                                           "2)MachineButtHinge";
                                                  
            m_parts.Add(part);




            // RailB ||
            part = new Part(3397, "RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail = "1)MiterEnds";

            m_parts.Add(part);



            #endregion


            #region Hardware


            int hingecount = FrameWorks.Functions.HingeCount(m_subAssemblyHieght - (m_subAssemblyWidth + sashGap));


            // HingeButt 
            part = new Part(667, "HingeButt", this, hingecount, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion


            #region GlassStop



            // StopTopArched #3396
            part = new Part(3396, "StopTopArched", this, 1, arcLength - sashGap - (2.0m * stopInset) + strechGrip);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "StrechForm";

            m_parts.Add(part);


            // Stop-L #3396
            part = new Part(3396, "GlassStop-L", this, 1, m_subAssemblyHieght  - (2 * stopInset));
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);


            // Stop-R #3396
            part = new Part(3396, "GlassStop-R", this, 1, m_subAssemblyHieght - (2 * stopInset));
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);


            // Stop-B #3396
            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - (2 * stopInset));
            part = new Part(3396, "GlassStop-B", this, 1, m_subAssemblyWidth - (2 * stopInset));
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" + "2)" + crap;

            m_parts.Add(part);


            #endregion


            #region Glass

            //Glass Panel
            part = new Part(3392);
            part.FunctionalName = "PatternGlass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (0.875m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (0.875m * 2.0m);

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


                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - .43491899m, m_subAssemblyWidth - .43491899m);

                //Glazing Seals
                part = new Part(2772, "Glazing Seal", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

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