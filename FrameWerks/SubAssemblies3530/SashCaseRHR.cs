#region Copyright (c) 2013 WeaselWare Software
/************************************************************************************
'
' Copyright  2013 WeaselWare Software 
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
' Portions Copyright 2013 WeaselWare Software
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

namespace FrameWorks.Makes.System3530
{

    public class SashCaseRHR : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal gstopReduce = .5625m;
        const decimal glassReduce = .875m;
        const decimal gasketReduce = .859m;
        const decimal edgeSealAdd = .28125m;

        static int createID;


        #endregion

        #region Constructor

        public SashCaseRHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3530-SashCaseRHR";
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
            part = new Part(3891, "StileBrzL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";

            m_parts.Add(part);


            // StileBrzR -->>
            part = new Part(3891, "StileBrzR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR = "MiterEnds";

            m_parts.Add(part);


            // RailBrzT ^^
            part = new Part(3891, "RailBrzT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3121Right";

            m_parts.Add(part);


            // RailBrzB ||
            part = new Part(3891, "RailBrzB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Sash-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3121Right";

            m_parts.Add(part);



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

            #region GlassStop



            // GlsStopBrzL #3892
            part = new Part(3892, "GlsStopBrzL", this, 1, m_subAssemblyHieght - 2 * gstopReduce);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // GlsStopBrzR #3892
            part = new Part(3892, "GlsStopBrzR", this, 1, m_subAssemblyHieght - 2 * gstopReduce);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // GlsStopBrzT #3892
            part = new Part(3892, "GlsStopBrzT", this, 1, m_subAssemblyWidth - 2 * gstopReduce);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "MiterEnds";

            m_parts.Add(part);



            // GlsStopBrzB #3892
            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 2 * gstopReduce);
            part = new Part(3892, "GlsStopBrzB", this, 1, m_subAssemblyWidth - 2 * gstopReduce);
            part.PartGroupType = "GlassStop-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + crap;

            m_parts.Add(part);




            #endregion

            #region Glass

            //Glass Panel
            part = new Part(4420);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce * 2.0m);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 1.0m;

            m_parts.Add(part);

            #endregion

            #region Seal/Weatherstripping


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght + edgeSealAdd, m_subAssemblyWidth + edgeSealAdd);

                //SashEdgeSeal
                part = new Part(1005, "SashEdgeSeal", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 2; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //GlazingEPDM
                part = new Part(3904, "GlazingEPDM", this, 1, peri);
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