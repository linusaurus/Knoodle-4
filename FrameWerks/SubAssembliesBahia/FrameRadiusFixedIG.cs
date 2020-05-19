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

    public class FrameRadiusFixedIG : SubAssemblyBase
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

        public FrameRadiusFixedIG()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-FrameRadiusFixedIG";
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



            // HeadArched ^^
            //+ (2 * strechGrip)
            part = new Part(3395, "HeadArched", this, 1, arcLength + (2.0m * strechGrip) );
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)StretchForm" + "\r\n" +
                             "2)MachineCenterPN:911";

            m_parts.Add(part);


            // JambL <<-- 
            part = new Part(3395, "JambL", this, 1, m_subAssemblyHieght - m_subAssemblyWidth / 2);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterBottom";

            m_parts.Add(part);


            // JambR -->> 
            part = new Part(3395, "JambR", this, 1, m_subAssemblyHieght - m_subAssemblyWidth / 2);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterBottom";

            m_parts.Add(part);


            // Sill ||
            part = new Part(3395, "Sill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "Machine Center PN:911";

            m_parts.Add(part);





            #endregion


            #region Stops




            // StopTop 
            part = new Part(3396, "StopTop", this, 1, arcLength - (0.625m * 2.0m) + ( 2.0m* strechGrip));
            part.PartGroupType = "Stops-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // StopRight 
            part = new Part(3396, "StopRight", this, 1, m_subAssemblyHieght - (0.625m * 2.0m) - m_subAssemblyWidth / 2);
            part.PartGroupType = "Stops-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // StopLeft 
            part = new Part(3396, "StopLeft", this, 1, m_subAssemblyHieght - (0.625m * 2.0m) - m_subAssemblyWidth / 2);
            part.PartGroupType = "Stops-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);




            // StopBot 
            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 2.0m * .625m);
            part = new Part(3396, "StopBot", this, 1, m_subAssemblyWidth - (0.625m * 2.0m));
            part.PartGroupType = "Stops-Parts";
            part.PartLabel = "1) Miter Ends" + "\r\n" +
                             "2)" + crap;

            m_parts.Add(part);



            #endregion


            #region Glass


            //Glass Panel

            part = new Part(3392);

            part.FunctionalName = "PatternGlass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;

            part.PartWidth = m_subAssemblyWidth - (0.96875m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (0.96875m * 2.0m);

            m_parts.Add(part);



            #endregion


            #region GlazingSeal


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 1, m_subAssemblyWidth - 1);


            //Glazing Seals
            part = new Part(2772, "Glazing Seal", this, 1, peri * 2);
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