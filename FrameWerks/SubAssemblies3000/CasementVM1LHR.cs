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

namespace FrameWorks.Makes.System3000
{
    
    public class CasementVM1LHR : SubAssemblyBase
    {

        #region Fields




        #endregion

        #region Constructor

        public CasementVM1LHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3000-CasementVM1LHR";
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
                // Casement Hinge 995 T,996 B
                labelStileR = "";
                labelStileL = "";
                labelTopRail = "M-996";
                labelBotRail = "M-995";

            }
            else if (pweight > 106)
            {

                // Butt Hinge 665

                labelStileR = "";
                labelStileL = "M-665";
                labelTopRail = "";
                labelBotRail = "";


            }

            // StileR -->>
            part = new Part(1167, "StileR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR;
            
            m_parts.Add(part);



            // StileL <<--
            part = new Part(1167, "StileL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL;
            
            m_parts.Add(part);



            // RailT ^^
            part = new Part(1167, "RailT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail;
            
            m_parts.Add(part);



            // RailB ||
            part = new Part(1167, "RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail;
            
            m_parts.Add(part);



            #endregion

            #region Stop



            // StopFrontLeft
            part = new Part(809, "StopFrontLeft", this, 1, m_subAssemblyHieght - 2 * 1.3125m);
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "MiterEnds";
            
            m_parts.Add(part);



            // StopRearLeft 
            part = new Part(809, "StopRearLeft", this, 1, m_subAssemblyHieght - 2 * 1.3125m);
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "MiterEnds";
            
            m_parts.Add(part);



            // StopFrontRight
            part = new Part(809, "StopFrontRight", this, 1, m_subAssemblyHieght - 2 * 1.3125m);
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "MiterEnds";
            
            m_parts.Add(part);



            // StopRearRight
            part = new Part(809, "StopRearRight", this, 1, m_subAssemblyHieght - 2 * 1.3125m);
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "MiterEnds";
            
            m_parts.Add(part);



            // StopFrontTop
            part = new Part(809, "StopFrontTop", this, 1, m_subAssemblyWidth - 2 * 1.3125m);
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "MiterEnds";
            
            m_parts.Add(part);



            // StopRearTop
            part = new Part(809, "StopRearTop", this, 1, m_subAssemblyWidth - 2 * 1.3125m);
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "MiterEnds";
            
            m_parts.Add(part);



            // StopFrontBot
            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 2 * 1.3125m);
            part = new Part(809, "StopFrontBot", this, 1, m_subAssemblyWidth - 2 * 1.3125m);
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + crap;
            
            m_parts.Add(part);



            // StopRearBot
            part = new Part(809, "StopRearBot", this, 1, m_subAssemblyWidth - 2 * 1.3125m);
            part.PartGroupType = "Stop-Parts";
            part.PartLabel = "MiterEnds";
            
            m_parts.Add(part);



            #endregion

            #region Muntin

            // Muntin Bar ||
            part = new Part(1862, "MuntinBarExtV", this, 1, m_subAssemblyHieght - 2.0m * 2.0625m);
            part.PartGroupType = "Muntin-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);



            // Muntin Bar ||
            part = new Part(1862, "MuntinBarIntV", this, 1, m_subAssemblyHieght - 2.0m * 2.0625m);
            part.PartGroupType = "Muntin-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);










            #endregion

            #region FoamTape

            // Foam Tape Vertical ||  #2808
            part = new Part(2808, "FoamTape", this, 2, m_subAssemblyHieght - 2.0m * 2.0625m);
            part.PartGroupType = "FoamTape-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            #endregion

            #region Glass

            //Glass Panel
            part = new Part(2828);

            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (1.625m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (1.625m * 2.0m);
            
            m_parts.Add(part);

            #endregion

            #region Seal/Weatherstripping


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //Sash Edge Seal
            part = new Part(1769, "Edge Seal", this, 1, peri * 2.0m);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 1.625822m, m_subAssemblyWidth - 1.625822m);

            //Glazing Seals
            part = new Part(1819, "Glazing Seal", this, 1, peri * 2.0m);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region Hardware


            if (pweight <= 106.0m)
            {
                // Casement Hinge
                part = new Part(995, "Casement Hinge", this, 1, 0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";
                
                m_parts.Add(part);


                // Casement Hinge
                part = new Part(996, "Casement Hinge", this, 1, 0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                
                m_parts.Add(part);
            }
            else if (pweight > 106.0m)
            {

                // Butt Hinge

                int hcount = FrameWorks.Functions.HingeCount(m_subAssemblyHieght);
                part = new Part(665, "HD Hinge", this, hcount, 0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                
                m_parts.Add(part);

            }



    
            //LeverHoppe  
            FrameWorks.Makes.System3000.HoppeCasement hoppe = new FrameWorks.Makes.System3000.HoppeCasement(m_subAssemblyHieght, this);
            foreach (Part innerpart in hoppe.Parts)
            {
               //inner
                this.Parts.Add(innerpart);

            }

            

  
            #endregion

                #region Labor



            part = new LPart("Design", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //Collect Information on Sizes: Measure: Provide Information for Approval: Order: Supervision

            part = new LPart("Draft", this, 3.0m, 80.0m);
            m_parts.Add(part);
            //Typical Drawings

            part = new LPart("MetalHours", this, 12.0m, 80.0m);
            m_parts.Add(part);
            //1 Recieve: 1 Handle: 1 CutSash: 1 CutGlassStop: 1.5 Machine: 1.5 Hardware Prep: 1 Mount Hardware: 4 Weld:

            part = new LPart("Finish", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 Sand Linegrain: 2 Finish:

            part = new LPart("Glazing", this, (this.Area * .10m) + 4.5m, 80.0m);
            m_parts.Add(part);
            //0.5 Order: 0.5 Recieve: 1.0 Inspect/Reject: 0.5 Store/Handle: 0.5 SetGlass/Shim&Calk: 0.5 Set GlassStop: 0.5 GlazingSeals

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