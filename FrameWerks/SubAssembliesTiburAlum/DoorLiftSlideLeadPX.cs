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
using FrameWorks.Makes.TiburAlum;


namespace FrameWorks.Makes.TiburAlum
{

    public class DoorLiftSlideLeadPX : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;
        const decimal doorSpacing = 2.5625m;
        const decimal stileWidth = 3.125m;
        const decimal stileOverLap = stileWidth / 2.0m;
        const decimal coreReduceX2 = 1.2504m;
        const decimal glassReduceX2 = 5.1628m;
        const decimal glassVinylX2 = 5.2500m;



        static int createID;
        Part part;
        string partleader;

        #endregion

        #region Constructor

        public DoorLiftSlideLeadPX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-DoorLiftSlideLeadPX";
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




            #region DoorCore



            // StileCoreLead 

            part = new Part(3070, "StileCoreLead", this, 1, m_subAssemblyHieght - coreReduceX2 );
            part.PartGroupType = "DoorCore-Parts";
            part.PartLabel = "1) Miter Ends" + "r\n" +
                             "2) Gear Lever Center Int" + "\r\n" +
                             "3) Flush Pull Center Ext";

            m_parts.Add(part);



            // StileCoreRear 

            part = new Part(3070, "StileCoreRear", this, 1, m_subAssemblyHieght - coreReduceX2 );
            part.PartGroupType = "DoorCore-Parts";
            part.PartLabel = "1) Miter Ends";

            m_parts.Add(part);



            // RailCoreTop 

            part = new Part(3070, "RailCoreTop", this, 1, m_subAssemblyWidth - coreReduceX2 );
            part.PartGroupType = "DoorCore-Parts";
            part.PartLabel = "1) Miter Ends ";

            m_parts.Add(part);



            // RailCoreB

            part = new Part(3070, "RailCoreB", this, 1, m_subAssemblyWidth - coreReduceX2 );
            part.PartGroupType = "DoorCore-Parts";
            part.PartLabel = "1) Miter Ends ";

            m_parts.Add(part);



            #endregion

            #region HDPE



            // HDPE_LS_LockEdge
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3761, "HDPE_LS_LockEdge", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);
            }




            // HDPETop
            for (int i = 0; i < 1; i++)
            {


                part = new Part(3762, "HDPETop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "";

                m_parts.Add(part);

            }





            #endregion

            #region DoorClad


            // StileCladLead 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3614, "StileCladLead", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorClad-Parts";
                part.PartLabel = "1) Miter Ends" + "r\n" +
                                 "2) Gear Lever Center Int" + "\r\n" +
                                 "3) Flush Pull Center Ext";
                m_parts.Add(part);

            }


            // StileCladRear
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3614, "StileCladRear", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorClad-Parts";
                part.PartLabel = "1) Miter Ends";

                m_parts.Add(part);

            }


            // RailCladT
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3614, "RailCladT", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorClad-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }

            // RailCladB
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3614, "RailCladB", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorClad-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }


            #endregion

            #region CladClip


            //CladClipExtHead

            part = new Part(3785, "CladClipExtHead", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CladClip-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////

            //CladClipTabs

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            for (int i = 0; i < 4; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                part = new Part(3785, "CladClipTabs", this, Convert.ToInt32(this.Perimeter / 12.0m) - 1, 2.0m);
                part.PartGroupType = "CladClip-Parts";
                part.PartLabel = "2 Inch Clip";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Glass

            //Glass Panel
            part = new Part(3473);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduceX2 ;
            part.PartLength = m_subAssemblyHieght - glassReduceX2 ;

            m_parts.Add(part);

            #endregion

            #region Seal/Weatherstripping

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //GlazeDartSeals
            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - glassVinylX2, m_subAssemblyWidth - glassVinylX2);

                part = new Part(3780, "GlazeDartSeals", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //GlazeWedgeSeals
            for (int i = 0; i < 1; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - glassVinylX2, m_subAssemblyWidth - glassVinylX2);

                part = new Part(3781, "GlazeWedgeSeals", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////



            //TopSealLiftSlide
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3783, "TopSeal", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }



            //EdgeBotSeal
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3784, "EdgeBotSeal", this, 1, m_subAssemblyHieght + m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }



            #endregion

            #region HardWare Logic


            // LiftSlideGear

            part = new Part(3421, "LiftSlideGear", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // CoverExtension

            if (m_subAssemblyHieght >= 104.0m)
            {
                int c;
                decimal result = decimal.Zero;
                result = (m_subAssemblyHieght - 104.0m);
                result = decimal.Divide(result, 24.0m);
                if (result > 0.0m && result < 24.0m)
                {
                    c = 1;
                }

                else
                {
                    c = Convert.ToInt32(Math.Round(result, 0)) + 1;
                }

                part = new Part(3430, "CoverExtension", this, c, 24.0m);

                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }
            ///////////////////////


            // Locking Bolts

            part = new Part(3431, "LockingBolts", this, 2, m_subAssemblyHieght);
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
            ////////////////////////////

            // TopGuideFront

            part = new Part(1886, "TopGuideFront", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // TopGuideRearBump

            part = new Part(2480, "TopGuideRearBump", this, 1, m_subAssemblyHieght);
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