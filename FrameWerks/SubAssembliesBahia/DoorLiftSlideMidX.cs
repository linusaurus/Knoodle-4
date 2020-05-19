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

    public class DoorLiftSlideMidX  : SubAssemblyBase
    {

        #region Fields

        //Constant values
        const decimal glassVinylDel = 4.875m;



        static int createID;
        Part part;
        string partleader;

        #endregion

        #region Constructor

        public DoorLiftSlideMidX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-DoorLiftSlideMidX";
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



            // StileLead 

            part = new Part(3402, "StileLead", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "1) Miter Ends" + "r\n" +
                             "2) Flush Pull Center Ext" ;

            m_parts.Add(part);



            // StileRear

            part = new Part(3402, "StileRear", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "1) Miter Ends" + "r\n" +
                             "2) Half Gear Lever Center Int" ;

            m_parts.Add(part);



            // RailT ^^

            part = new Part(3402, "RailT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "1) Miter Ends ";

            m_parts.Add(part);



            // RailB ||

            part = new Part(3402, "RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Door-Parts";
            part.PartLabel = "1) Miter Ends ";

            m_parts.Add(part);



            #endregion


            #region HookCap


            // HookCap

            part = new Part(3409, "HookCap", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            part = new Part(3409, "HookCap", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion


            #region GlassStop



            // Stop-L #3403
            part = new Part(3403, "GlassStop-L", this, 1, m_subAssemblyHieght - 2 * 2.28125m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // Stop-R #3403
            part = new Part(3403, "GlassStop-R", this, 1, m_subAssemblyHieght - 2 * 2.28125m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // Stop-T #3403

            part = new Part(3403, "GlassStop-T", this, 1, m_subAssemblyWidth - 2 * 2.28125m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // Stop-B #3403

            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 2 * 2.28125m);
            part = new Part(3403, "GlassStop-B", this, 1, m_subAssemblyWidth - 2 * 2.28125m);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + crap;

            m_parts.Add(part);




            #endregion


            #region Glass

            //Glass Panel
            part = new Part(4393);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (2.625m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (2.625m * 2.0m);
            part.PartThick = 1.0m;

            m_parts.Add(part);

            #endregion


            #region HardWare Logic


            // LiftSlideHalfGear

            part = new Part(3432, "LiftSlideHalfGear", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // CoverExtension

            decimal result = decimal.Zero;
            result = (m_subAssemblyHieght - 44.125m);
            result = decimal.Divide(result, 24.0m);
            int c = Convert.ToInt32 (Math.Round(result, 0));
            part = new Part(3430, "CoverExtension", this, c+1, 24.0m);
               
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // CarrageKit

            part = new Part(3422, "CarrageKit", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // LinkRod


            if (m_subAssemblyWidth >= 25.5m && m_subAssemblyWidth < 130.0m)
            {
                if (m_subAssemblyWidth >= 25.5m && m_subAssemblyWidth <= 50.0m)
                {
                    part = new Part(3423, "LinkRod", this, 1, m_subAssemblyWidth);
                }
                if (m_subAssemblyWidth > 50.0m && m_subAssemblyWidth <= 78.0m)
                {
                    part = new Part(2100, "LinkRod", this, 1, m_subAssemblyWidth);
                }
                if (m_subAssemblyWidth > 78.0m && m_subAssemblyWidth <= 130.0m)
                {
                    part = new Part(3424, "LinkRod", this, 1, m_subAssemblyWidth);
                }

            }
            else
            {
                part = new Part(911, "LinkRod", this, 1, m_subAssemblyWidth);
            }


            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion


            #region Seal/Weatherstripping



            // GlazingEPDM

            for (int i = 0; i < 2; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - glassVinylDel, m_subAssemblyWidth - glassVinylDel);

                part = new Part(1819, "GlazingEPDM", this, 1, peri );
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }


            ////////////////////////////



            // Edge & Bottom Seal
            part = new Part(3408, "Edge Seal", this, 1, m_subAssemblyHieght * 2 + m_subAssemblyWidth * 2);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // Top Seal
            part = new Part(319, "Top Seal", this, 1, m_subAssemblyWidth * 2);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // HookPileT
            part = new Part(1774, "HookPileT", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Seal-Parts";
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