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
    
    public class FixedIGJambOnly : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public FixedIGJambOnly()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys2000-FixedIGJambOnly";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            


            #region Frame


            // JambLeft <<-- #2031
            part = new Part(2031, "JambL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);


            // JambRight -->> #2031
            part = new Part(2031, "JambR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);



            // Head
            part = new Part(926, "Head", this, 1, m_subAssemblyWidth + (2.5625m * 2.0m));
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // Sill
            part = new Part(926, "Sill", this, 1, m_subAssemblyWidth + (2.5625m * 2.0m));
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);




            #endregion

            #region GlassStop



            // StopL #800
            part = new Part(800, "StopL", this, 1, m_subAssemblyHieght - 2.0m * .625m);
            part.PartGroupType = "GlassStop";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);


            // StopR #800
            part = new Part(800, "StopR", this, 1, m_subAssemblyHieght - 2.0m * .625m);
            part.PartGroupType = "GlassStop";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);


            #endregion

            #region Glass


            //Glass Panel
            part = new Part(1022);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.Source.MaterialDescription = "1.25 Insulated Glass";
            part.PartName = "PartName";
            part.PartLabel = "";
            part.Source.MaterialName = "1.25 IGU";
            part.ContainerAssembly = this;

            part.PartWidth = m_subAssemblyWidth - (0.9375m * 2.0m);
            part.PartLength = m_subAssemblyHieght + (0.625m * 2.0m);
            part.Source.UOM = 9;

           
            m_parts.Add(part);



            #endregion

            #region WeatherSeals


            // Glazing Seal
            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyWidth - (0.9375m * 2.0m),
             m_subAssemblyHieght - (0.0m * 0.0m));
            part = new Part(1819, "Glazing Seal", this, 1, peri *= 2.0m);
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            #endregion

            #region Hardware


            #endregion

             #region Labor


            part = new LPart("Design",this, 4.0m, 80.0m);
            this.m_parts.Add(part);
            //Measure: Collect Information on Sizes from Contractor: 
            //Provide Information for Approval:
            //Samples Correspondence: Ordering: Supervision

            part = new LPart( "Draft",this, 3.0m, 80.0m);
            this.m_parts.Add(part);
            //Typical Drawings: Supervision

            part = new LPart("MetalHours",this,8.0m, 80.0m);
            this.m_parts.Add(part);
            //1 Receive: 1 Handle: 1 Cut: 1 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("GlazingHours",this, (this.Area * 0.17m) + 1.5m, 80.0m);
            this.m_parts.Add(part);
            //.5 Recieve: .5 InspectReject: .5 StoreHandle: * .17 Hrs Per Square Ft: 

            part = new LPart("Finish",this, (this.Area * 0.025m) + 2.0m, 80.0m);
            this.m_parts.Add(part);
            //1.0 Sand Linegrain: 1.0 Finish:

            part = new LPart("PaintAno",this, (this.Area * 0.065m) + 0.0005m, 80.0m);
            this.m_parts.Add(part);
            // .0005 hours + 0.065 Area

            part = new LPart("Stage",this, 0.5m, 80.0m);
            this.m_parts.Add(part);
            //.5 Stage

            part = new LPart("Load",this, 1.0m, 80.0m);
            this.m_parts.Add(part);
            //1 Load


            #endregion



        }



        #endregion


    }
}