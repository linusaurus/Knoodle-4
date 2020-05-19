#region Copyright (c) 2014 WeaselWare Software
/************************************************************************************
'
' Copyright  2014 WeaselWare Software 
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
' Portions Copyright 2014 WeaselWare Software
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

namespace FrameWorks.Makes.System3010
{

    public class SashCaseHZ2Lt_RHR : SubAssemblyBase
    {

        #region Fields


        //Constant Values
        const decimal bronzeCrnBrk = 0.64m;
        const decimal braceCornerSS_Yellow = 0.4625m;
        const decimal gstopReduce = .9375m;
        const decimal glassReduce = 1.28125m;
        const decimal gasketReduce = 1.41875m;
        const decimal edgeSealAdd = .390m;
        const decimal muntSashRedX2 = 2.0m * 1.8125m;



        static int createID;


        #endregion

        #region Constructor

        public SashCaseHZ2Lt_RHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-SashCaseHZ2Lt_RHR";
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


            #region Sash


            // StileBrzL <<--
            part = new Part(4305, "StileBrzL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";

            m_parts.Add(part);


            // StileBrzR -->>
            part = new Part(4305, "StileBrzR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR = "MiterEnds";

            m_parts.Add(part);


            // RailBrzT ^^
            part = new Part(4305, "RailBrzT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3627Right";

            m_parts.Add(part);


            // RailBrzB ||
            part = new Part(4305, "RailBrzB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3627Right";

            m_parts.Add(part);



            #endregion

            #region Muntin

            //////////////////////////////////////////////////////////////////////////////

            // BrzMntHrz2Lt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4313, "BrzMntHrz2Lt", this, 1, m_subAssemblyWidth - muntSashRedX2);
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region StopBrz


            //////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpVt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlsStpVt", this, 1, m_subAssemblyHieght - 2 * gstopReduce);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpHz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4298, "BrzGlsStpHz", this, 1, m_subAssemblyWidth - 2 * gstopReduce);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            ////////////////////////////////////////////////////////////////////////////////



            #endregion

            #region AsemblHrdwr

            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4525_YELLOW 
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4784, "SS_0.4525_YELLOW", this, 1, braceCornerSS_Yellow);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4265, "BrzCnrBrkt", this, 1, bronzeCrnBrk);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // MS_FlatHead_8-32x3/16_SS
            for (int i = 0; i < 16; i++)
            {
                part = new Part(4876, "MS_FlatHead_8-32x3/16_SS", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // SetSocScrew_1/4-20x1/4
            for (int i = 0; i < 16; i++)
            {
                part = new Part(1545, "SetSocScrew_1/4-20x1/4", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Hardware


            // HingeCaseUR
            part = new Part(3627, "HingeCaseUR", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";

            m_parts.Add(part);


            // HingeCaseLR
            part = new Part(3627, "HingeCaseLR", this, 1, 0.0m);
            part.PartGroupType = "Hardware";
            part.PartLabel = "";

            m_parts.Add(part);


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (m_subAssemblyHieght <= 47.99m)
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


                //HandleCamLH 

                part = new Part(1171, "HandleCamLH", this, 1, 0.0m);
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



            #endregion

            #region Glass


            /////////////////////////////////////////////////////////////////////////////////////////////
            // Glass Panel
            for (int i = 0; i < 1; i++)
            {

                // Glass Panel
                part = new Part(4419);

                part.FunctionalName = "Gls2SDLite";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - 2 * glassReduce);
                part.PartLength = (m_subAssemblyHieght - 2 * glassReduce);
                part.PartThick = 1.25m;

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Seal/Weatherstripping


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght + edgeSealAdd, m_subAssemblyWidth + edgeSealAdd);

                //SashEdgeSeal
                part = new Part(2274, "SashEdgeSeal", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //GlazePreSet
                part = new Part(4314, "GlazePreSet", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //GlazeWedgeSeals
                part = new Part(4399, "GlazeWedgeSeals", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            #endregion






        }
        #endregion

    }




}