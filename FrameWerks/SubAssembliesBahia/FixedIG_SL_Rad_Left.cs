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

    public class FixedIG_SL_Rad_Left : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        // Extra Material for Bending
        const decimal strechGrip = 12.0m;
        const decimal stileWidth = 1.375m;
        const decimal sashGap = 0.25m;
        const decimal stopInset = 0.5625m;
        const decimal fixFrame = 0.625m;
        const decimal muntThick = .125m;     
        const decimal glassMuntGap = 0.8125m;
        const decimal glassFrameGap = 0.96875m;


        static int createID;



        #endregion

        #region Constructor

        public FixedIG_SL_Rad_Left()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-FixedIG_SL_Rad_Left";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            //Fuction for Radius Top Rail/Stop
            decimal arcLength = FrameWorks.Functions.RadArc(Convert.ToDouble(m_subAssemblyWidth), 90);


            #region Frame



            // HeadArc 
            part = new Part(3395, "HeadArc", this, 1, 51.0705m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)StretchForm";

            m_parts.Add(part);



            // Jamb 
            part = new Part(3395, "Jamb", this, 1, m_subAssemblyHieght - m_subAssemblyDepth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterBottom";

            m_parts.Add(part);


            // Jamb
            part = new Part(3395, "Jamb", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterBottom";

            m_parts.Add(part);


            // Sill ||
            part = new Part(3395, "Sill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);



            #endregion


            #region Stops


            // StopV
            part = new Part(3396, "StopV", this, 1, m_subAssemblyHieght - (0.625m * 2.0m));
            part.PartGroupType = "Stops-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);


            // StopV
            part = new Part(3396, "StopV", this, 1, m_subAssemblyHieght - m_subAssemblyDepth - (0.625m));
            part.PartGroupType = "Stops-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);


            // StopArc
            part = new Part(3396, "StopArc", this, 1, 51.0705m - 0.625m);
            part.PartGroupType = "Stops-Parts";
            part.PartLabel = "1)StretchForm";

            m_parts.Add(part);


            // StopBot
            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 2.0m * .625m);
            part = new Part(3396, "StopBot", this, 1, m_subAssemblyWidth - 2.0m * .625m);
            part.PartGroupType = "Stops-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);



            #endregion


            #region Muntins
            //Horizontal Muntins 3
            for (int i = 0; i < 3; i++)
            {

                // MuntHorz
                part = new Part(3401, "MuntHorz", this, 1, (m_subAssemblyWidth - 2 * fixFrame));
                part.PartGroupType = "Muntins";
                part.PartLabel = "";

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

                part.PartWidth = m_subAssemblyWidth - glassFrameGap * 2.0m;
                part.PartLength =((m_subAssemblyHieght - glassFrameGap * 2.0m - glassMuntGap * 3.0m) / 4.0m);

                m_parts.Add(part);



            }


            #endregion


            #region GlazingSeal




            for (int i = 0; i < 4; i++)


            {

                //GlazingSeals

                decimal rectSeal = decimal.Zero;

                part = new Part(2772);
                part.FunctionalName = "GlazingSeal";
                part.PartGroupType = "GlazingSeal-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;

                rectSeal = (m_subAssemblyWidth - glassFrameGap * 2.0m) * 2.0m;
                rectSeal +=(m_subAssemblyHieght - glassFrameGap * 2.0m - glassMuntGap * 3.0m) / 4.0m * 2.0m;
                rectSeal *= 2.0m;

                part.PartLength = rectSeal;
                m_parts.Add(part); 
                
                

            }




            #endregion


            #region Hardware


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