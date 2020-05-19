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

    public class FrameFixedIG_Arc_2Lite : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal strechGrip = 12.0m;
        const decimal stileWidth = 1.375m;
        const decimal sashGap = 0.25m;
        const decimal stopInset = 0.625m;
        const decimal muntThick = .125m;
        const decimal glassMuntGap = 0.8125m;
        const decimal glassFrameGap = 0.96875m;

        static int createID;

        #endregion


        #region Constructor





        public FrameFixedIG_Arc_2Lite()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-FrameFixedIG_Arc_2Lite";
        }

        #endregion


        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            decimal arcLength = FrameWorks.Functions.ArcLength(Convert.ToDouble(m_subAssemblyWidth), Convert.ToDouble(m_subAssemblyDepth));


            #region Frame


            // ArchedHead ^^
            part = new Part(3395, "ArchedHead", this, 1, arcLength + (2.0m * strechGrip));
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)StretchForm" + "\r\n" +
                             "2)MiterEnds";

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


            #region Muntin



            // Vertical Muntin 1
            for (int i = 0; i < 1; i++)
            {

                // MuntVert
                part = new Part(3401, "MuntVert", this, 1, (m_subAssemblyHieght - 2 * stopInset));
                part.PartGroupType = "Muntin";
                part.PartLabel = "";

                m_parts.Add(part);

            }




            #endregion


            #region Stops

            for (int i = 0; i < 2; i++)
            {

                // FullArchStop2 ^^
                part = new Part(3396, "FullArchStop2", this, 1, arcLength - (stopInset) - (muntThick) + (2.0m * strechGrip) / 2.0m);
                part.PartGroupType = "Stops-Parts";
                part.PartLabel = "1)MiterEnds";

                m_parts.Add(part);

            }


            // StopOut2
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3396, "StopOut2", this, 1, m_subAssemblyHieght - m_subAssemblyDepth - (2.0m * stopInset));
                part.PartGroupType = "Stops-Parts";
                part.PartLabel = "1)MiterEnds";

                m_parts.Add(part);
            }




            // StopSill2 ||
            decimal stopLengthH = ((m_subAssemblyWidth - stopInset * 2.0m - muntThick) / 2.0m);

            for (int i = 0; i < 2; i++)
            {
                string crap;
                crap = FrameWorks.Functions.StopWeepMachining(stopLengthH);
                part = new Part(3396, "StopSill2", this, 1, stopLengthH);
                part.PartGroupType = "Stops-Parts";
                part.PartLabel = "1) Miter Ends" + "\r\n" +
                                 "2)" + crap;

                m_parts.Add(part);

            }


            #endregion


            #region Glass

            for (int i = 0; i < 2; i++)
            {

                //Four Glass Panels

                part = new Part(3392);

                part.FunctionalName = "PatternGlass2";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;

                part.PartWidth = (m_subAssemblyWidth - glassMuntGap  - glassFrameGap * 2.0m) / 2.0m;
                part.PartLength = m_subAssemblyHieght - (glassFrameGap * 2.0m);

                m_parts.Add(part);



            }


            #endregion


                #region Labor

            part = new LPart("MetalHours", this, 8.0m, 80.0m);
            this.m_parts.Add(part);
            //1 Receive: 1 Handle: 1 Cut: 1 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("Finish", this, (this.Area * 0.025m) + 2.0m, 80.0m);
            this.m_parts.Add(part);
            //1.0 Sand Linegrain: 1.0 Finish:

            part = new LPart("PaintAno", this, (this.Area * 0.065m) + 0.0005m, 80.0m);
            this.m_parts.Add(part);
            // .0005 hours + 0.065 Area

            #endregion



        }



        #endregion


    }
}