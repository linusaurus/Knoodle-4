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
    public class SubFrameBrzDivEight5_5 : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public SubFrameBrzDivEight5_5()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Tiburon-SubFrameBrzDivEight5_5";
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



            #region SubFrameAssy


            // SubFrameAssyHead ^^
            part = new Part(3076, "SubFrameAssyH", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyLeft <<--
            part = new Part(3076, "SubFrameAssyJL", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVert1 ||
            part = new Part(3076, "SubFrameAssyVert1", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVert2 ||
            part = new Part(3076, "SubFrameAssyVert2", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVert3 ||
            part = new Part(3076, "SubFrameAssyVert3", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVert4 ||
            part = new Part(3076, "SubFrameAssyVert4", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVert5 ||
            part = new Part(3076, "SubFrameAssyVert5", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVert6 ||
            part = new Part(3076, "SubFrameAssyVert6", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVert7 ||
            part = new Part(3076, "SubFrameAssyVert7", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyRight -->
            part = new Part(3076, "SubFrameAssyJR", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssySill ||
            part = new Part(3076, "SubFrameAssyS", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion



            #region CapAssyBrz


            // CapAssyBrzOuterTop ^^
            part = new Part(3140, "CapAssyBrzExtT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzInnerTop ^^
            part = new Part(3140, "CapAssyBrzIntT", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzOuterLeft <<--
            part = new Part(3140, "CapAssyBrzExtL", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzInnerLeft <<--
            part = new Part(3140, "CapAssyBrzIntL", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzOuterVert1 |
            part = new Part(3140, "CapAssyBrzOuterVert1", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzInnerVert1 |
            part = new Part(3140, "CapAssyBrzInnerVert1", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzOuterVert2 |
            part = new Part(3140, "CapAssyBrzOuterVert2", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzInnerVert2 |
            part = new Part(3140, "CapAssyBrzInnerVert2", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzOuterVert3 |
            part = new Part(3140, "CapAssyBrzOuterVert3", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzInnerVert3 |
            part = new Part(3140, "CapAssyBrzInnerVert3", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzOuterVert4 |
            part = new Part(3140, "CapAssyBrzOuterVert4", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzInnerVert4 |
            part = new Part(3140, "CapAssyBrzInnerVert4", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzOuterVert5 |
            part = new Part(3140, "CapAssyBrzOuterVert5", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzInnerVert5 |
            part = new Part(3140, "CapAssyBrzInnerVert5", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzOuterVert6 |
            part = new Part(3140, "CapAssyBrzOuterVert6", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzInnerVert6 |
            part = new Part(3140, "CapAssyBrzInnerVert6", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzOuterVert7 |
            part = new Part(3140, "CapAssyBrzOuterVert7", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzInnerVert7 |
            part = new Part(3140, "CapAssyBrzInnerVert7", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzOuterRight -->
            part = new Part(3140, "CapAssyBrzExtR", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzInnerRight -->
            part = new Part(3140, "CapAssyBrzIntR", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzOuterBot ||
            part = new Part(3140, "CapAssyBrzExtB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssyBrzInnerBot ||
            part = new Part(3140, "CapAssyBrzIntB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CapAssyBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion



            #region GeSilpruf


            decimal peri = Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyDepth);
            peri += Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);



            //GeSilpruf
            part = new Part(759, "GE SilPruf", this, 6, peri);
            part.PartGroupType = "GeSilpruf";
            part.PartLabel = "";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);


            #endregion



        }

        #endregion

    }
}