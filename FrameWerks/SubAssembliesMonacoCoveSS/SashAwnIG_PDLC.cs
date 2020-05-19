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
using System.Diagnostics;


namespace FrameWorks.Makes.MonacoCoveSS
{

    public class SashAwnIG_PDLC : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal cladIntRed = .50m;
        const decimal glassReduce = .71875m;
        const decimal edgeSealAdd = .390m;


        static int createID;


        #endregion

        #region Constructor

        public SashAwnIG_PDLC()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "MonacoCoveSS-SashAwnIG_PDLC";
            this.WrkOrder = new Workorder(this, 1);
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


            #region CoreAlum

            ///////////////////////////////////////////////////////////////////////////

            // CoreAlum_Stile #4086
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4086, "CoreAlum_Stile", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "CoreAlum-Parts";
                part.PartLabel = "MiterEnds";

                m_parts.Add(part); ;

            }
            ///////////////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////////////

            // CoreAlum_Rails #4086
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4086, "CoreAlum_Rails", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "CoreAlum-Parts";
                part.PartLabel = "MiterEnds";

                m_parts.Add(part);

            }
            ///////////////////////////////////////////////////////////////////////////

            #endregion

            #region 316SSClad

            ///////////////////////////////////////////////////////////////////////////

            // 316SSClad StileExt 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4168, "StileExt", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "316SSClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "1)MiterEnds" + "\r\n" +
                                               "2)MachineHingeAwning";

                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            // 316SSClad RailExt 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4168, "RailExt", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "316SSClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelTopRail;

                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            // 316SSClad StileInt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4169, "StileInt", this, 1, m_subAssemblyHieght - 2.0m * cladIntRed);
                part.PartGroupType = "316SSClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "1)MiterEnds" + "\r\n" +
                                               "2)MachineHingeAwning";

                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            // 316SSClad RailInt 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4169, "RailInt", this, 1, m_subAssemblyWidth - 2.0m * cladIntRed);
                part.PartGroupType = "316SSClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelTopRail;

                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////


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

            //if (m_subAssemblyWidth <= 47.9m)
            //{

            //HandleCamLH 
            //part = new Part(1171, "HandleCamLH", this, 1, 0.0m);
            //part.PartGroupType = "Hardware";
            //part.PartLabel = "";
            //part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            //m_parts.Add(part);


            //StrikeWedge 

            //part = new Part(1174, "StrikeWedge", this, 1, 0.0m);
            //part.PartGroupType = "Hardware";
            //part.PartLabel = "";
            //part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            //m_parts.Add(part);

            //}
            //else
            //{


            //HandleCamLH 

            //part = new Part(1171, "HandleCamLH", this, 1, 0.0m);
            //part.PartGroupType = "Hardware";
            //part.PartLabel = "";
            //part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            //m_parts.Add(part);


            //HandleCamRH 

            //part = new Part(1168, "HandleCamRH", this, 1, 0.0m);
            //part.PartGroupType = "Hardware";
            //part.PartLabel = "";
            //part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            //m_parts.Add(part);


            //StrikeWedge 

            //part = new Part(1174, "StrikeWedge", this, 2, 0.0m);
            //part.PartGroupType = "Hardware";
            //part.PartLabel = "";
            //part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            //m_parts.Add(part);



            //}
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////



            #endregion

            #region Glass


            //Glass Panel

            part = new Part(4221);

            part.FunctionalName = "IG_PDLC";
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
                part = new Part(2274, "SashEdgeSeal", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

        }


        #endregion

    }




}