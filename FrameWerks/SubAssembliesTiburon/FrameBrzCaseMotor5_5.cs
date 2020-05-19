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
    public class FrameBrzCaseMotor5_5 : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public FrameBrzCaseMotor5_5()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Tiburon-FrameBrzCaseMotor5_5";
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



            #region FrameBrzAglCase



            // FrmBrzAglExtL <<--
            part = new Part(3106, "FrmBrzAglExtL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameBrzAglCase-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // FrmBrzAglExtR -->
            part = new Part(3106, "FrmBrzAglExtR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameBrzAglCase-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // FrmBrzAglExtH ^^
            part = new Part(3106, "FrmBrzAglExtH", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameBrzAglCase-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // FrmBrzAglExtS ||
            part = new Part(3106, "FrmBrzAglExtS", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameBrzAglCase-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion


            #region HdpeFrmThrmBrk

            // ThermalBreakL <<--
            part = new Part(3113);
            part.Qnty = 1;
            part.PartGroupType = "HdpeFrmThrmBrk-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght;
            part.FunctionalName = "ThermalBreakL";
            part.PartLabel = "";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);


            // ThermalBreakR -->
            part = new Part(3113);
            part.Qnty = 1;
            part.PartGroupType = "HdpeFrmThrmBrk-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght;
            part.FunctionalName = "ThermalBreakR";
            part.PartLabel = "";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);



            // ThermalBreakH ^^
            part = new Part(3113);
            part.Qnty = 1;
            part.PartGroupType = "HdpeFrmThrmBrk-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth;
            part.FunctionalName = "ThermalBreakH";
            part.PartLabel = "";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);



            // ThermalBreakS ||
            part = new Part(3113);
            part.Qnty = 1;
            part.PartGroupType = "HdpeFrmThrmBrk-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth;
            part.FunctionalName = "ThermalBreakS";
            part.PartLabel = "";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);



            #endregion


            #region FrameBrzAglCaseInt



            // FrmBrzAglIntL <<--
            part = new Part(3363, "FrmBrzAglIntL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameBrzAglCaseInt-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // FrmBrzAglIntR -->
            part = new Part(3363, "FrmBrzAglIntR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FrameBrzAglCaseInt-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // FrmBrzAglIntH ^^
            part = new Part(3363, "FrmBrzAglIntH", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameBrzAglCaseInt-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // FrmBrzAglIntS ||
            part = new Part(3363, "FrmBrzAglIntS", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FrameBrzAglCaseInt-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion


            #region CvrBrzWndwFauxScrnFrm




            // FrameBrzScrnCvrL <<--
            part = new Part(3091, "FrameBrzScrnCvrL", this, 1, m_subAssemblyHieght - 2 * 0.3125m);
            part.PartGroupType = "CvrBrzWndwFauxScrnFrm-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // FrameBrzScrnCvrR -->
            part = new Part(3091, "FrameBrzScrnCvrR", this, 1, m_subAssemblyHieght - 2 * 0.3125m);
            part.PartGroupType = "CvrBrzWndwFauxScrnFrm-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // FrameBrzScrnCvrH ^^
            part = new Part(3091, "FrameBrzScrnCvrH", this, 1, m_subAssemblyWidth - 2 * 2.3125m);
            part.PartGroupType = "CvrBrzWndwFauxScrnFrm-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // FrameBrzScrnCvrS ||
            part = new Part(3091, "FrameBrzScrnCvrS", this, 1, m_subAssemblyWidth - 2 * 2.3125m);
            part.PartGroupType = "CvrBrzWndwFauxScrnFrm-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);




            #endregion


            #region CvrBrzMotor




            // FrameBrzMtrCvrCapL <<--
            part = new Part(3148, "FrameBrzMtrCvrCapL", this, 1, m_subAssemblyHieght - 2 * 0.0625m);
            part.PartGroupType = "CvrBrzMotor-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);




            // FrameBrzMtrCvrFaceL -->
            part = new Part(3149, "FrameBrzMtrCvrFaceL", this, 1, m_subAssemblyHieght - 2 * 0.0625m);
            part.PartGroupType = "CvrBrzMotor-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);




            #endregion


            #region AlumScreenFrame



            // AlumScreenFrameL <<--
            part = new Part(3123, "AlumScreenFrameL", this, 1, m_subAssemblyHieght - 2 * 1.32875m);
            part.PartGroupType = "AlumScreenFrame-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            // AlumScreenFrameR -->
            part = new Part(3123, "AlumScreenFrameR", this, 1, m_subAssemblyHieght - 2 * 1.32875m);
            part.PartGroupType = "AlumScreenFrame-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            // AlumScreenFrameH ^^
            part = new Part(3123, "AlumScreenFrameH", this, 1, m_subAssemblyWidth - 2 * 1.32875m);
            part.PartGroupType = "AlumScreenFrame-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            // AlumScreenFrameS ||
            part = new Part(3123, "AlumScreenFrameS", this, 1, m_subAssemblyWidth - 2 * 1.32875m);
            part.PartGroupType = "AlumScreenFrame-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion


            #region Hardware


            // HingeTop
            part = new Part(1742, "HingeTop", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // HingeBot
            part = new Part(1742, "HingeBot", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // SupportBlock
            part = new Part(2995, "SupportBlock", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // VegaSyncroMotor
            part = new Part(3391, "VegaSyncroMotor", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "CustomOperator";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);


            // Snubber
            part = new Part(911, "Snubber", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "Snubber";
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