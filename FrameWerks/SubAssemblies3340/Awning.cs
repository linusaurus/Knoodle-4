﻿

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
using System.Diagnostics;

namespace FrameWorks.Makes.System3340
{

    public class Awning : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal windGrdRed = 0.50m;
        const decimal bronzeCrnBrk = 0.625m;
        const decimal ss304CrnBrk = 0.75m;
        const decimal stopReduceX2 = 1.40625m * 2.0m;
        const decimal glassReduceX2 = 1.75m * 2.0m;
        const decimal gasketReduce = 1.6582m;
        const decimal K_FOLD_Q_Lon = 1.1533m;
        const decimal sashReduceX2 = 0.875m * 2.0m;


        static int createID;

        #endregion

        #region Constructor

        public Awning()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3340-Awning";
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


            #region FrameBrz

            //////////////////////////////////////////////////////////////////////////////

            // Frame_4415_Vert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4415, "Frame_4415_Vert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Frame_4415_Horz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4415, "Frame_4415_Horz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region FrameSeal

            for (int i = 0; i < 1; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - K_FOLD_Q_Lon, m_subAssemblyWidth - K_FOLD_Q_Lon);

                //FrameSeal
                part = new Part(2274, "K_FOLD_Q_Lon", this, 1, peri);
                part.PartGroupType = "FrameSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion

            #region FrameHardware

            //////////////////////////////////////////////////////////////////////////////

            //CornerBrackets
            for (int i = 0; i < 8; i++)
            {
                part = new Part(4265, "CornerBrackets", this, 1, bronzeCrnBrk);
                part.PartGroupType = "FrameHardware-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Sash

            //////////////////////////////////////////////////////////////////////////////

            // Sash_4416_Vert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4416, "Sash_4416_Vert", this, 1, m_subAssemblyHieght - sashReduceX2);
                part.PartGroupType = "Sash-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Sash_4416_Horz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4416, "Sash_4416_Horz", this, 1, m_subAssemblyWidth - sashReduceX2);
                part.PartGroupType = "Sash-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopBrz

            //////////////////////////////////////////////////////////////////////////////

            //GlsStpVt
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

            //BrzGlsStpHz  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4413, "GlsStp_4413_Hz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz1x4-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare Logic


            // Hinges
            decimal _wieght = FrameWorks.Functions.PanelWieghtS3000(SubAssemblyWidth, SubAssemblyHieght);
            decimal hingesize = SubAssemblyHieght;
            string id = this.Parent.UnitID.ToString();
            if (_wieght < 250.0m)
            {

                part = new Part(Functions.S3000AwningHinge(hingesize), "Awning Hinge", this, 2, 0.0m);
                part.PartGroupType = "Hardware-Parts";

                m_parts.Add(part);

            }
            else
            {

                string message = "The Component is too heavy-" + id.ToString();
                Debug.WriteLine(message);
            }

            int hardwarecount = 1;
            if (m_subAssemblyHieght < 48.0m)
            {
                hardwarecount = 1;
            }
            else
            {
                hardwarecount = 2;

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (m_subAssemblyWidth <= 47.9m)
            {

                //HandleCamLH 
                part = new Part(1171, "HandleCamLH", this, 1, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";
                part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
                m_parts.Add(part);


                //StrikeWedge 

                part = new Part(1174, "StrikeWedge", this, 1, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";
                part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
                m_parts.Add(part);

            }
            else
            {


                //HandleCamLH 

                part = new Part(1171, "HandleCamLH", this, 1, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";
                part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
                m_parts.Add(part);


                //HandleCamRH 

                part = new Part(1168, "HandleCamRH", this, 1, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";
                part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
                m_parts.Add(part);


                //StrikeWedge 

                part = new Part(1174, "StrikeWedge", this, 2, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";
                part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
                m_parts.Add(part);



            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////


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



            #endregion

            #region Operator

            // Operator
            int[] Parts = FrameWorks.Functions.OperatorAwningPivotShoeSeries22(this.SubAssemblyWidth);
            for (int i = 0; i < Parts.Length; i++)
            {
                string desc = string.Empty;
                if (i == 0) { desc = "Operator22Series"; }
                else { desc = "Pivot Tracks"; }


                // Operator22Series
                part = new Part(Parts[i], desc, this, 1, 0.0m);
                part.PartGroupType = "Operator-Parts";
                part.PartLabel = "";
                m_parts.Add(part);


            }

            //////////////////////////////////////////////////////////////////////////////////////////////

            // FoldingHandle
            part = new Part(1764, "FoldingHandle", this, 1, 0.0m);
            part.PartGroupType = "Operator-Parts";
            part.PartLabel = "";
            m_parts.Add(part);




            #endregion

            #region Glass

            //Glass Panel

            part = new Part(4212);

            part.FunctionalName = "Glass_0.53125Lami";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduceX2);
            part.PartLength = m_subAssemblyHieght - (glassReduceX2);
            part.PartThick = 0.53125m;

            m_parts.Add(part);

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

            // WindGuard
            for (int i = 0; i < 1; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - windGrdRed, m_subAssemblyWidth - windGrdRed);

                //FrameSeal
                part = new Part(2274, "K_FOLD_Q_Lon", this, 1, peri);
                part.PartGroupType = "FrameSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion



        }

        #endregion

    }
}