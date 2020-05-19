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

    public class PocketCloseOut : SubAssemblyBase
    {

        #region Fields

        static int createID;
        Part part;
        string partleader;

        #endregion

        #region Constructor

        public PocketCloseOut()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-PocketCloseOut";
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





            #region CloseOut


            // StileCloseOut

            part = new Part(3402, "StileCloseOut", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "CloseOut-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // 5052AngleClsOut  
    
            part = new Part(3438);
            part.FunctionalName = "AlumAngle";
            part.PartGroupType = "CloseOut-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartThick = m_subAssemblyDepth ;
            part.PartWidth = m_subAssemblyWidth ;
            part.PartLength = m_subAssemblyHieght ;
            
            m_parts.Add(part);


            #endregion


            #region CapJamb


            // HookCap

            part = new Part(3409, "HookCap", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "CapJamb-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion


            #region Seal/Weatherstripping




            // HookPileT
            part = new Part(1774, "HookPileT", this, 1, m_subAssemblyHieght);
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