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
using System.Diagnostics;

namespace FrameWorks.Makes.Tiburon
{
    [Serializable()]
    public class FrameSS7DoorRH : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public FrameSS7DoorRH()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Tiburon-FrameSS7DoorRH";
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


            #region FrameAngleDoor



            // FrmAglExtL <<--
            part = new Part(3063, "FrmAglExtL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAngleDoor-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // FrmAglExtR -->
            part = new Part(3063, "FrmAglExtR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameAngleDoor-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // FrmAglExtH ^^
            part = new Part(3063, "FrmAglExtH", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameAngleDoor-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion


            #region FrameFlatDoorInt



            // FrmFltIntL <<--
            part = new Part(3078, "FrmFltIntL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameFlatDoorInt-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // FrmFltIntR -->
            part = new Part(3078, "FrmFltIntR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameFlatDoorInt-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // FrmFltIntH ^^
            part = new Part(3078, "FrmFltIntH", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameFlatDoorInt-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion


            #region Hardware



            // HingePrep
            part = new Part(911, "HingePrep", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);


            // LatchPrep
            part = new Part(911, "LatchPrep", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);



            #endregion


                #region Labor

            part = new LPart("MetalHours", this, 8.0m, 80.0m);
            m_parts.Add(part);
            //1 Receive: 1 Handle: 1 Cut: 1 Machine: 2 Bond & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("FinishHours", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 SandLineGrain: 2 Finish




            #endregion



        }



        #endregion


    }
}