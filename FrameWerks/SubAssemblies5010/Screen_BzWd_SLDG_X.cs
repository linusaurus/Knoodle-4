#region Copyright (c) 2016 WeaselWare Software
/************************************************************************************
'
' Copyright  2016 WeaselWare Software 
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
' Portions Copyright 2016 WeaselWare Software
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
using FrameWorks.Makes.System5010;


namespace FrameWorks.Makes.System5010
{

    public class Screen_BzWd_SLDG_X : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;
        const decimal glassReduceX2 = 2.0m * 2.75m;
        const decimal glassVinylX2 = 2.0m * 2.71875m;


        #endregion

        #region Constructor

        public Screen_BzWd_SLDG_X()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-Screen_BzWd_SLDG_X";
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


            #region DoorBz

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // StileBzLeft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4555, "StileBzLeft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorBz-Parts";
                part.PartLabel = "1) Miter Ends";
                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // StileBzRight
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4555, "StileBzRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorBz-Parts";
                part.PartLabel = "1) Miter Ends";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailBzTop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4555, "RailBzTop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorBz-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailBzBot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4555, "RailBzBot", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorBz-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region DrCldWood

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // StileWdLft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4557, "StileWdLft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DrCldWood-Parts";
                part.PartLabel = "1) Miter Ends";
                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // StileWdRt
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4557, "StileWdRt", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DrCldWood-Parts";
                part.PartLabel = "1) Miter Ends";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailWdTop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4557, "RailWdTop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DrCldWood-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // RailWdBot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4557, "RailWdBot", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorBzAlTB-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Screen


            //Screen Panel
            part = new Part(911);
            part.FunctionalName = "Screen";
            part.PartGroupType = "Screen-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduceX2;
            part.PartLength = m_subAssemblyHieght - glassReduceX2;
            part.PartThick = 1.230m;

            m_parts.Add(part);

            #endregion

            #region HardWare Logic

            //  FFI_TWIN_ROLLER_SS
            for (int i = 0; i < 2; i++)
            {

                part = new Part(5152, "FFI_TWIN_ROLLER_SS", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////

            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - glassVinylX2, m_subAssemblyWidth - glassVinylX2);

            //PreSetEPDM

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - glassVinylX2, m_subAssemblyWidth - glassVinylX2);
                part = new Part(4314, "PreSetEPDM", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            //WedeEPDM

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - glassVinylX2, m_subAssemblyWidth - glassVinylX2);
                part = new Part(4399, "WedeEPDM", this, 1, peri);
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

            for (int i = 0; i < 2; i++)
            {

                part = new Part(3959, "HookPileT+Fin", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////



            #endregion


            ///////////////////////////////////////////////////////////////////////////////////////////////

        }
        #endregion

    }

}