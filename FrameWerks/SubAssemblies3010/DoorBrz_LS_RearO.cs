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
using FrameWorks.Makes.System3010;


namespace FrameWorks.Makes.System3010
{

    public class DoorBrz_LS_RearO : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;

        const decimal stopReduceX2 = 2.0m * 2.25m;
        const decimal glassReduceX2 = 2.0m * 2.59375m;


        #endregion

        #region Constructor

        public DoorBrz_LS_RearO()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-DoorBrz_LS_RearO";
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


            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region DoorBzTB



            // StileBTBLeft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4312, "StileBTBLeft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorBzTB-Parts";
                part.PartLabel = "1) Miter Ends";
                m_parts.Add(part);

            }




            // StileBTBRight
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4312, "StileBTBRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorBzTB-Parts";
                part.PartLabel = "1) Miter Ends";

                m_parts.Add(part);

            }




            // RailBTBtop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4312, "RailBTBtop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorBzTB-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }




            // RailBTBbot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4312, "RailBTBbot", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorBzTB-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }




            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region StopBrz


            // BrzGlsStpVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlsStpVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            // BrzGlsStpTopBot
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlsStpTopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////




            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HDPE



            // HDPE_LS_LockEdge
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3761, "HDPE_LS_LockEdge", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);
            }




            // HDPETop
            for (int i = 0; i < 1; i++)
            {


                part = new Part(3762, "HDPETop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "";

                m_parts.Add(part);

            }





            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region AssyBrackets

            //Alum_CornerBrace

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4831, "Alum_CornerBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // SMS_10_1/2_FH

            for (int i = 0; i < 16; i++)
            {
                part = new Part(4832, "SMS_10_1/2_FH", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Alum_CornerBrace

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4830, "Alum_CornerBrace", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // SMS_10_5/8_FH

            for (int i = 0; i < 16; i++)
            {
                part = new Part(4833, "SMS_10_5/8_FH", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            //Blue_CnrBrcSS14ga_0.4662

            for (int i = 0; i < 4; i++)
            {
                part = new Part(4855, "Blue_CnrBrcSS14ga_0.4662", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //Black_CnrBrcSS14ga_0.638

            for (int i = 0; i < 8; i++)
            {
                part = new Part(4854, "Black_CnrBrcSS14ga_0.638", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //MS_FlatHead_8-32x3/16_SS

            for (int i = 0; i < 48; i++)
            {
                part = new Part(4876, "MS_FlatHead_8-32x3/16_SS", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region GuidesTop



            // GuideTop
            for (int i = 0; i < 1; i++)
            {
                part = new Part(2463, "FrontGuideTop", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "GuidesTop-Parts";
                part.PartLabel = "";
                m_parts.Add(part);

            }




            // GuideTop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(2480, "RearGuideTop", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "GuideTop-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region HookCap



            // EndCap

            part = new Part(4498, "EndCap", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // HookStrip

            part = new Part(3710, "HookStrip", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";

            m_parts.Add(part);





            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Glass

            //Glass Panel
            part = new Part(4419);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduceX2;
            part.PartLength = m_subAssemblyHieght - glassReduceX2;
            part.PartThick = 1.25m;

            m_parts.Add(part);

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #region Seal/Weatherstripping



            //GlazePreSet

            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.581266m, m_subAssemblyWidth - 2.581266m);

                part = new Part(4314, "GlazePreSet", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            //GlazeWedgeSeals

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.581266m, m_subAssemblyWidth - 2.581266m);

                part = new Part(4399, "GlazeWedgeSeals", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            //////////////////////////

            // Edge & Bottom Seal

            for (int i = 0; i < 2; i++)
            {

                part = new Part(1005, "Edge & Bottom Seal", this, 1, m_subAssemblyHieght + m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            ///////////////////////////

            // Top Seal

            for (int i = 0; i < 2; i++)
            {


                part = new Part(3783, "Top Seal", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////

            // HookPileT+Fin

            for (int i = 0; i < 1; i++)
            {

                part = new Part(3959, "HookPileT+Fin", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////



            #endregion





        }
        #endregion

    }

}