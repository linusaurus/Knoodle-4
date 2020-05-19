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

    public class Casement4LiteSashLHR : SubAssemblyBase
    {

        #region Fields

        const decimal stopInset = 0.5625m;
        const decimal muntThick = .125m;
        const decimal glassMuntGap = 0.40625m;
        const decimal glassSashGap = 0.90625m;




        static int createID;


        #endregion

        #region Constructor

        public Casement4LiteSashLHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-Casement4LiteSashLHR";
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
            part.PartLabel = labelStileL = "MiterEnds";

            m_parts.Add(part);



            // StileR -->>
            part = new Part(3397, "StileR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";

            m_parts.Add(part);



            // RailT ^^
            part = new Part(3397, "RailT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3121Left";

            m_parts.Add(part);


            // RailB ||
            part = new Part(3397, "RailB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3121Left";

            m_parts.Add(part);



            #endregion

            #region Muntins


            // MuntHorz
            part = new Part(3401, "MuntHorz", this, 1, (m_subAssemblyWidth - 2 * stopInset));
            part.PartGroupType = "Muntins";
            part.PartLabel = "";

            m_parts.Add(part);



            // Vertical Muntins 2
            for (int i = 0; i < 2; i++)
            {

                // MuntVert
                part = new Part(3401, "MuntVert", this, 1, (m_subAssemblyHieght - 2 * stopInset - muntThick ) / 2.0m);
                part.PartGroupType = "Muntins";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion

            #region Hardware


            // HingeCaseUL
            part = new Part(3121, "HingeCaseUL", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";

            m_parts.Add(part);


            // HingeCaseLL
            part = new Part(3121, "HingeCaseLL", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion

            #region GlassStop

            for (int i = 0; i < 2; i++)
            {

                // Stop-L #3396
                part = new Part(3396, "GlassStop-L", this, 1, (m_subAssemblyHieght - 2 * stopInset - muntThick) / 2.0m );
                part.PartGroupType = "GlassStop-Parts";
                part.PartLabel = "MiterEnds";

                m_parts.Add(part);

            }

            for (int i = 0; i < 2; i++)
            {

                // Stop-R #3396
                part = new Part(3396, "GlassStop-R", this, 1, (m_subAssemblyHieght - 2 * stopInset - muntThick) / 2.0m );
                part.PartGroupType = "GlassStop-Parts";
                part.PartLabel = "MiterEnds";

                m_parts.Add(part);

            }

            for (int i = 0; i < 2; i++)
            {


                // Stop-T #3396

                part = new Part(3396, "GlassStop-T", this, 1, (m_subAssemblyWidth - 2 * stopInset - muntThick) / 2.0m );
                part.PartGroupType = "GlassStop-Parts";
                part.PartLabel = "MiterEnds";

                m_parts.Add(part);

            }

            for (int i = 0; i < 2; i++)
            {

                // Stop-B #3396

                string crap;
                crap = FrameWorks.Functions.StopWeepMachining((m_subAssemblyWidth - 2 * stopInset - muntThick) / 2.0m);
                part = new Part(3396, "GlassStop-B", this, 1, (m_subAssemblyWidth - 2 * stopInset - muntThick) / 2.0m);
                part.PartGroupType = "GlassStop-Parts";
                part.PartLabel = "1)MiterEnds" + "\r\n" +
                                 "2)" + crap;

                m_parts.Add(part);

            }


            #endregion

            #region Glass

            for (int i = 0; i < 4; i++)
            {

                //Glass Panel
                part = new Part(3392);
                part.FunctionalName = "Glass";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - glassSashGap * 2.0m - glassMuntGap * 2.0m) / 2.0m ;
                part.PartLength = (m_subAssemblyHieght - glassSashGap * 2.0m - glassMuntGap * 2.0m) / 2.0m;

                m_parts.Add(part);

            }

            #endregion

            #region Seal/Weatherstripping


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //Sash Edge Seal
            part = new Part(2274, "Edge Seal", this, 1, peri);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            for (int i = 0; i < 4; i++)
            {

                //GlazingSeals

                decimal rectSeal = decimal.Zero;

                part = new Part(2772);
                part.FunctionalName = "GlazingSeal";
                part.PartGroupType = "GlazingSeal-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;

                rectSeal = (m_subAssemblyWidth - 2 * glassSashGap - 2 * glassMuntGap) / 2.0m * 2.0m;
                rectSeal += (m_subAssemblyHieght - 2 * glassSashGap - 2 * glassMuntGap) / 2.0m * 2.0m;
                rectSeal *= 2.0m;
                part.PartLength = rectSeal;
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