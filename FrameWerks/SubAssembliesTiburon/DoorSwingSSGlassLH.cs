#region Copyright (c) 2011 WeaselWare Software
/************************************************************************************
'
' Copyright  2011 WeaselWare Software 
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
' Portions Copyright 2011 WeaselWare Software
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
using System.Runtime;
using FrameWorks.Makes.System3000;

namespace FrameWorks.Makes.Tiburon
{

    public class DoorSwingSSGlassLH : SubAssemblyBase
    {

        #region Fields

        static int createID;
        Part part;
        string partleader;

        #endregion

        #region Constructor

        public DoorSwingSSGlassLH()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Tiburon-DoorSwingSSGlassLH";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {
            partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region DoorCoreAlum


            // SubStileL <<--
            part = new Part(3070, "SubStileL", this, 1, m_subAssemblyHieght - 2 * .48140111m);
            part.PartGroupType = "DoorCoreAlum-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubStileR -->>
            part = new Part(3070, "SubStileR", this, 1, m_subAssemblyHieght - 2 * .48140111m);
            part.PartGroupType = "DoorCoreAlum-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubRailT ^^
            part = new Part(3070, "SubRailT", this, 1, m_subAssemblyWidth - 2 * .48140111m);
            part.PartGroupType = "DoorCoreAlum-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubRailB ||
            part = new Part(3070, "SubRailB", this, 1, m_subAssemblyWidth - 2 * .48140111m);
            part.PartGroupType = "DoorCoreAlum-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion


            #region ExtCladSS

            // StileExtL <<--
            part = new Part(3093, "StileExtL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "ExtCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // StileExtR -->>
            part = new Part(3093, "StileExtR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "ExtCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // RailExtT ^^
            part = new Part(3093, "RailExtT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "ExtCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // RailExtB ||
            part = new Part(3093, "RailExtB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "ExtCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion


            #region IntCladSS


            // StileIntL <<--
            part = new Part(3093, "StileIntL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "IntCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // StileIntR -->>
            part = new Part(3093, "StileIntR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "IntCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // RailIntT ^^
            part = new Part(3093, "RailIntT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "IntCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // RailIntB ||
            part = new Part(3093, "RailIntB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "IntCladSS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion


            #region HardWare Logic


            // Hinge
            part = new Part(911, "Hinge", this, 3, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // Hoppe9000Gear

            Hoppe hoppe = new Hoppe(m_subAssemblyHieght, this);
            foreach (Part innerpart in hoppe.Parts)
            {
                //inner
                this.Parts.Add(innerpart);

            }





            #endregion


            #region HDPEdge


            part = new Part(3383, "HDPEdgeLeft", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HDPEdge-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            part = new Part(3335, "HDPEdgeRight", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "HDPEdge-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            part = new Part(3383, "HDPEdgeTop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HDPEdge-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            part = new Part(3388, "HDPEdgeBottom", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "HDPEdge-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion


            #region Glass



            //Glass Panel

            part = new Part(3122);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (2.46875m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (2.46875m * 2.0m);

            m_parts.Add(part);



            #endregion


            #region Seal/Weatherstripping


            decimal peri = Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //Sash Edge Seal
            part = new Part(911, "Edge Seal", this, 1, peri * 2.0m);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            peri = Functions.Perimeter(m_subAssemblyHieght - 1.53125m, m_subAssemblyWidth - 1.53125m);

            //Glazing Seals
            part = new Part(911, "Glazing Seal", this, 1, peri * 2.0m);
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

            part = new LPart("MetalHours", this, 12.0m, 80.0m);
            m_parts.Add(part);
            //1 Recieve: 1 Handle: 1 CutSash: 1 CutGlassStop: 1.5 Machine: 1.5 Hardware Prep: 1 Mount Hardware: 4 Weld:

            part = new LPart("Finish", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 Sand Linegrain: 2 Finish:

            part = new LPart("PatinaMat", this, this.m_perimeter, 1.62m);
            m_parts.Add(part);
            //$1.62 per inch

            part = new LPart("Glazing", this, (this.Area * .10m) + 4.5m, 80.0m);
            m_parts.Add(part);
            //0.5 Order: 0.5 Recieve: 1.0 Inspect/Reject: 0.5 Store/Handle: 0.5 SetGlass/Shim&Calk: 0.5 Set GlassStop: 0.5 GlazingSeals

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