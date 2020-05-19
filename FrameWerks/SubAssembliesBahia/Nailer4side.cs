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

    public class Nailer4side : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public Nailer4side()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-Nailer4side";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region NailFin


            // NailerTop

            part = new Part(3308, "NailerTop", this, 1, m_subAssemblyWidth + 1.250m * 2.0m);
            part.PartGroupType = "NailFin-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);


            //NailerLeft

            part = new Part(3308, "NailerLeft", this, 1, m_subAssemblyHieght + 1.250m * 2.0m);
            part.PartGroupType = "NailFin-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);



            // NailerRight

            part = new Part(3308, "NailerRight", this, 1, m_subAssemblyHieght + 1.250m * 2.0m);
            part.PartGroupType = "NailFin-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);




            // NailFinBot

            part = new Part(3308, "NailerTop", this, 1, m_subAssemblyWidth + 1.250m * 2.0m);
            part.PartGroupType = "NailFin-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);



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