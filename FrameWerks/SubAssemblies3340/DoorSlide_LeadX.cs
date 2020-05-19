#region Copyright (c) 2015 WeaselWare Software
/************************************************************************************
'
' Copyright  2015 WeaselWare Software 
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
' Portions Copyright 2015 WeaselWare Software
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

namespace FrameWorks.Makes.System3340
{

    public class DoorSlide_LeadX : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal ss304CrnBrk = 0.75m;
        const decimal stopReduceX2 = 0.53125m * 2.0m;
        const decimal glassReduceX2 = 0.875m * 2.0m;
        const decimal gasketReduce = .776m;

        #endregion

        #region Constructor

        public DoorSlide_LeadX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3340-DoorSlide_LeadX";
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


            #region Door

            ////////////////////////////////////////////////////////////////////////////////

            // Door_4416_Horz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4416, "Door_4416_Horz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Door-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Door_4416_Vert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4416, "Door_4416_Vert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Door-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Hook_4432_Cap
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4432, "Hook_4432_Cap", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Door-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Rear";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // FlushPull_Int

            part = new Part(4449, "FlushPull_Int", this, 1, 19.8875m);
            part.PartGroupType = "Door-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);

            // FlushPull_Ext

            part = new Part(4450, "FlushPull_Ext", this, 1, 19.8875m);
            part.PartGroupType = "Door-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region SS_Edge_Stiffeners

            ////////////////////////////////////////////////////////////////////////////////

            // Stiffener_1
            for (int i = 0; i < 5; i++)
            {
                part = new Part(4451, "Stiffener_1", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "SS_Edge_Stiffeners";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "RearLeadX";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // Stiffener_2
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4452, "Stiffener_2", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "SS_Edge_Stiffeners";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "RearLeadX";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopBrz

            //////////////////////////////////////////////////////////////////////////////

            //GlsStp_4413_Vt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4413, "GlsStp_4413_Vt", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //GlsStp_4413_Hz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4413, "GlsStp_4413_Hz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //////////////////////////////////////////////////////////////////////////////

            //Glass Panel
            part = new Part(4212);

            part.FunctionalName = "Glass_0.53125Lami";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduceX2);
            part.PartLength = m_subAssemblyHieght - (glassReduceX2);
            part.PartThick = 0.53125m;
            part.PartLabel = "CLEAR";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region GlazingSeal

            //////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                part = new Part(4436, "GlazPreSetEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                part = new Part(3904, "GlazWedgEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // EdgeSeal

            for (int i = 0; i < 2; i++)
            {

                part = new Part(1005, "EdgeSeal", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // BotPileSeal

            for (int i = 0; i < 2; i++)
            {

                part = new Part(4462, "BotPileSeal", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "OAG_.53125";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // HookPileT+Fin

            for (int i = 0; i < 1; i++)
            {

                part = new Part(3959, "HookPileT+Fin", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "OAG_0.281";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare Logic

            //////////////////////////////////////////////////////////////////////////////

            // SashBrackets
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4441, "CornerBrackets", this, 1, ss304CrnBrk);
                part.PartGroupType = "Hardware-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "SS_Angle";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // BearingCarriage #4161
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4161, "BearingCarriage", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "HardWare-Parts";
                part.PartLabel = "BearingCarriage";

                m_parts.Add(part); ;

            }

            //////////////////////////////////////////////////////////////////////////////

            //for (int i = 0; i < bearingcount; i++)

             //{

            part = new Part(4215, "Bearings", this, FrameWorks.Functions.BearingCountByWeight(Wieght), 0.0m);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "Bearings";

            m_parts.Add(part);

             //}

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

        }




        #endregion

    }
}