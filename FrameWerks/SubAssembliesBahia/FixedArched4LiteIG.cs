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

    public class FixedArched4LiteIG : SubAssemblyBase
    {

        #region Fields

        // Extra Material for Bending
        const decimal strechGrip = 12.0m;
        const decimal stopInset = 0.6250m;
        const decimal muntThick = .125m;
        const decimal glassMuntGap = 0.8125m;
        const decimal glassFrameGap = 0.96875m;





        static int createID;

        #endregion

        #region Constructor

        public FixedArched4LiteIG()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-FixedArched4LiteIG";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;

            //Fuction for Arched Top Rail/Stop
            decimal arcLength = FrameWorks.Functions.ArcLength(Convert.ToDouble(m_subAssemblyWidth), Convert.ToDouble(m_subAssemblyDepth));
          


            #region Frame


            // FullArchHead ^^
            part = new Part(3395, "FullArchHead", this, 1, arcLength + 2.0m * strechGrip );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);


            // JambL <<--
            part = new Part(3395, "JambL", this, 1, m_subAssemblyHieght - m_subAssemblyDepth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);


            // JambR -->>
            part = new Part(3395, "JambR", this, 1, m_subAssemblyHieght - m_subAssemblyDepth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);
                    

            // Sill ||
            part = new Part(3395, "Sill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);



            #endregion


            #region Muntins

        

            // Vertical Muntins 3
            for (int i = 0; i < 3; i++)
            {

                // MuntVert
                part = new Part(3401, "MuntVert", this, 1, (m_subAssemblyHieght - 2 * stopInset) );
                part.PartGroupType = "Muntins";
                part.PartLabel = "";

                m_parts.Add(part);

            }




            #endregion


            #region Stops



            // FullArchStop4 ^^
            part = new Part(3396, "FullArchStop4", this, 1, arcLength - (stopInset) + (2.0m * strechGrip));
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);




            // StopOut2
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3396, "StopOut2", this, 1, m_subAssemblyHieght - m_subAssemblyDepth - (2.0m * stopInset));
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "1)MiterEnds";

                m_parts.Add(part);
            }



            // StopMid6
            for (int i = 0; i < 6; i++)
            {
                part = new Part(3396, "StopMid6", this, 1, m_subAssemblyHieght - (2.0m * stopInset));
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "1)MiterEnds";

                m_parts.Add(part);
            }



            // StopSill4 ||
            decimal stopLengthH = ((m_subAssemblyWidth - (stopInset * 2.0m))- (muntThick * 3.0m)) / 4;

            for (int i = 0; i < 4; i++)
            {
                string crap;
                crap = FrameWorks.Functions.StopWeepMachining(stopLengthH);
                part = new Part(3396, "StopSill4", this, 1, stopLengthH);
                part.PartGroupType = "Frame-Parts";
                part.PartLabel = "1) Miter Ends" + "\r\n" +
                                 "2)" + crap;

                m_parts.Add(part);

            }


            #endregion


            #region Glass

            for (int i = 0; i < 4; i++)
            {

                //Four Glass Panels

                part = new Part(3392);

                part.FunctionalName = "PatternGlass4";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;

                part.PartWidth = (m_subAssemblyWidth  - glassMuntGap * 3.0m - glassFrameGap * 2.0m) / 4.0m;
                part.PartLength = m_subAssemblyHieght - (glassFrameGap * 2.0m);

                m_parts.Add(part);



            }


            #endregion


            #region GlazingSeal


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght , m_subAssemblyWidth );


            //Glazing Seals
            part = new Part(2772, "Glazing Seal", this, 1, peri * 4);
            part.PartGroupType = "GlazingSeal-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion


            #region Hardware


            #endregion


                #region Labor

            part = new LPart("Design", this, 4.0m, 80.0m);
            m_parts.Add(part);
            // Measure: Collect Information on Sizes from Contractor:
            // Provide Information for Approval: 
            // Samples Correspondence: Ordering: Supervision

            part = new LPart("Draft", this, 3.0m, 80.0m);
            m_parts.Add(part);
            //Typical Drawings: Supervision

            part = new LPart("MetalHours", this, 8.0m, 80.0m);
            m_parts.Add(part);
            //1 Receive: 1 Handle: 1 Cut: 1 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("GlazingHours", this, (this.Area * 0.1m) + 4.5m, 80.0m);
            m_parts.Add(part);
            //.5 Recieve: 1.0 InspectReject: .5 StoreHandle: 1.0 GlazeShimCalk: .5 SetGlassStop: 05 InsertGasket 

            part = new LPart("FinishHours", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 SandLineGrain: 2 Finish

            part = new LPart("Stage", this, 0.5m, 80.0m);
            m_parts.Add(part);
            //.5 Stage

            part = new LPart("Load", this, 1.0m, 80.0m);
            m_parts.Add(part);
            //1 Load



            #endregion


        }



        #endregion


    }
}