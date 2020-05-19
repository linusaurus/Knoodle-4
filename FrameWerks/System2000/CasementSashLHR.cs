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
using FrameWorks;

namespace FrameWorks.Makes.System2000
{
    
    public class CasementSashLHR : SubAssemblyBase
    {

        #region Fields

        static int createID;


        #endregion

        #region Constructor

        public CasementSashLHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2000-CasementSashLHR";
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

            if (pweight <= 106.0m)
            {
                // Casement Hinge 992 T,991 B
                labelStileR = "";
                labelStileL = "";
                labelTopRail = "M-992";
                labelBotRail = "M-991";

            }
            else if (pweight > 106)
            {

                // Butt Hinge 2982

                labelStileR = "";
                labelStileL = "M-2982";
                labelTopRail = "";
                labelBotRail = "";


            }

            // StileR -->>
            part = new Part(2032, "StileR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR;
           
            m_parts.Add(part);



            // StileL <<--
            part = new Part(2032, "StileL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL;
           
            m_parts.Add(part);



            // RailT ^^
            part = new Part(2032, "RailT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail;
           
            m_parts.Add(part);



            // RailB ||
            part = new Part(2032, "RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail;
           
            m_parts.Add(part);



            #endregion

            #region GlassStop



            // Stop-L #800
            part = new Part(800, "GlassStop-L", this, 1, m_subAssemblyHieght - 2 * 1.2288m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);



            // Stop-R #800
            part = new Part(800, "GlassStop-R", this, 1, m_subAssemblyHieght - 2 * 1.2288m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);



            // Stop-T #800

            part = new Part(800, "GlassStop-T", this, 1, m_subAssemblyWidth - 2 * 1.2288m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);



            // Stop-B #800

            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 2 * 1.2288m);
            part = new Part(800, "GlassStop-B", this, 1, m_subAssemblyWidth - 2 * 1.2288m);
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
            part.PartWidth = m_subAssemblyWidth - (1.53125m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (1.53125m * 2.0m);
           
            m_parts.Add(part);

            #endregion

            #region Seal/Weatherstripping


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //Sash Edge Seal
            part = new Part(1769, "Edge Seal", this, 1, peri * 2.0m);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 1.53125m, m_subAssemblyWidth - 1.53125m);

            //Glazing Seals
            part = new Part(1819, "Glazing Seal", this, 1, peri * 2.0m);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);



            #endregion

            #region Hardware

            if (pweight <= 106.0m)
            {
                // Casement Hinge T
                part = new Part(992, "CasementHingeT", this, 1, 0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";
               
                m_parts.Add(part);


                // Casement Hinge B
                part = new Part(991, "CasementHingeB", this, 1, 0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
               
                m_parts.Add(part);
            }
            else if (pweight > 106.0m)
            {

                // Butt Hinge

                int hcount = FrameWorks.Functions.HingeCount(m_subAssemblyHieght);
                part = new Part(2982, "HD Hinge", this, hcount, 0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
               
                m_parts.Add(part);

            }



            // Track
           
              part = new Part(FrameWorks.Functions.TrackSeries23(SubAssemblyWidth), "Track", this, 1, 0m);
              part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
                
            
            



            // Corner Braces
            part = new Part(2674, "CornerBraces", this, 8, 0.0m);
            part.PartGroupType = "Hardware-Parts";
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
        #endregion

    }




}