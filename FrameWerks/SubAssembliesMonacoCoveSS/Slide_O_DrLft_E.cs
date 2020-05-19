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
    public class Slide_O_DrLft_E : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal cladIntRed = .50m;
        const decimal cladReduce = .034m;
        const decimal hookReduce = .375m;
        const decimal glassReduce = .5625m;
        const decimal edgeSealAdd = .50m;


        static int createID;


        #endregion

        #region Constructor

        public Slide_O_DrLft_E()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "MonacoCoveSS-Slide_O_DrLft_E";
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

            // CoreAlum_Stile #4143
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4143, "CoreAlum_Stile", this, 1, m_subAssemblyHieght - cladReduce * 2.0m);
                part.PartGroupType = "CoreAlum-Parts";
                part.PartLabel = "MiterEnds";

                m_parts.Add(part); ;

            }
            ///////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            // CoreAlum_Rails #4143
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4143, "CoreAlum_Rails", this, 1, m_subAssemblyWidth - cladReduce * 2.0m);
                part.PartGroupType = "CoreAlum-Parts";
                part.PartLabel = "MiterEnds";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            // BottomGuide #4161
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4161, "BottomGuide", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "CoreAlum-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////

            #endregion

            #region 316SSClad

            ///////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            // 316SSClad StileLeft 4173

            for (int i = 0; i < 2; i++)
            {
                part = new Part(4173, "StileLeft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "316SSClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "MiterEnds";

                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            // 316SSClad StileExtRight 4174
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4174, "StileExtRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "316SSClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "MiterEnds_NotchTopHook";

                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            // 316SSClad StileIntRight 4175
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4175, "StileIntRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "316SSClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "MiterEnds";

                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            // 316SSClad RailTop 4173 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4173, "RailTop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "316SSClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelTopRail = "MiterEnds";

                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            // 316SSClad RailBottom 4176
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4176, "RailBot", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "316SSClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelTopRail = "MiterEnds";

                m_parts.Add(part);
            }

            ///////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPEGuide

            ///////////////////////////////////////////////////////////////////////////

            // HDPEtopGuide #4216
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4216, "HDPEtopGuide", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "HDPEGuide-Parts";
                part.PartLabel = "";

                m_parts.Add(part); ;

            }

            ///////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////

            // HDPEdgeGuide #4216
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4216, "HDPEdgeGuide", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "HDPEGuide-Parts";
                part.PartLabel = "";

                m_parts.Add(part); ;

            }

            ///////////////////////////////////////////////////////////////////////////

            #endregion

            #region HookInterlock

            ///////////////////////////////////////////////////////////////////////////

            // HookInterlock #4144
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4144, "HookInterlock", this, 1, m_subAssemblyHieght - hookReduce);
                part.PartGroupType = "HookInterlock-Parts";
                part.PartLabel = "";

                m_parts.Add(part); ;

            }

            ///////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass


            //Glass Panel

            part = new Part(4212);

            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce * 2.0m);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = .5625m;
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion

            #region Seal/Weatherstripping


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght + edgeSealAdd, m_subAssemblyWidth + edgeSealAdd);

                // T_BrushFin
                part = new Part(3959, "T_BrushFin", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // T_BrushFin
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3959, "T_BrushFin", this, 1, m_subAssemblyHieght + edgeSealAdd);
                part.PartGroupType = "Seal-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // T_BrushFin
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3959, "T_BrushFin", this, 1, m_subAssemblyWidth + edgeSealAdd);
                part.PartGroupType = "Seal-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region HardWare Logic

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // FixedDoorStand #911
            for (int i = 0; i < 1; i++)
            {
                part = new Part(911, "FixedDoorStand", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "HardWare-Parts";
                part.PartLabel = "";

                m_parts.Add(part); ;

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion


        }


        #endregion

    }




}