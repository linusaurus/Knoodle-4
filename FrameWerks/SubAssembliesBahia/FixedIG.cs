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

    public class FixedIG : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public FixedIG()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-FixedIG";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region Frame


            // JambRight -->>
            part = new Part(3395);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght;
            part.FunctionalName = "JambR";
            part.PartLabel = "";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);


            // JambLeft <<--
            part = new Part(3395);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght;
            part.FunctionalName = "JambL";
            part.PartLabel = "";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);


            // Head ^^
            part = new Part(3395);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth;
            part.FunctionalName = "Head";
            part.PartLabel = "";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);


            // Sill ||
            part = new Part(3395);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth;
            part.FunctionalName = "Sill";
            part.PartLabel = "";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);


            #endregion


            #region Stops

            // StopRight
            part = new Part(3396);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght - (0.625m * 2.0m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopRight";
            part.PartLabel = "Miter Ends";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

            // StopLeft
            part = new Part(3396);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght - (0.625m * 2.0m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopLeft";
            part.PartLabel = "Miter Ends";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

            // StopTop
            part = new Part(3396);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth - (0.625m * 2.0m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopTop";
            part.PartLabel = "Miter Ends";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

            // StopBot
            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 2.0m * .625m);
            part = new Part(3396);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth - (0.625m * 2.0m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopBot";
            part.PartLabel = "1) Miter Ends" + "\r\n" +
                             "2)" + crap;
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

            #endregion


            #region Glass


            //Glass Panel

            part = new Part(3392);

            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;

            part.PartWidth = m_subAssemblyWidth - (0.96875m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (0.96875m * 2.0m);

            m_parts.Add(part);



            #endregion


            #region GlazingSeal


            for (int i = 0; i < 2; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 1, m_subAssemblyWidth - 1);

                //Glazing Seals
                part = new Part(2772, "Glazing Seal", this, 1, peri * 2);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


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