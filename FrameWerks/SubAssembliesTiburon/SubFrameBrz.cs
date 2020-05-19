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
    public class SubFrameBrz : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public SubFrameBrz()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Tiburon-SubFrameBrz";
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


            // SubFrameAssyLeft <<--
            part = new Part(3076, "SubFrameAssyJL", this, 1, m_subAssemblyHieght - 2 * .375m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyRight -->
            part = new Part(3076, "SubFrameAssyJR", this, 1, m_subAssemblyHieght - 2 * .375m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyHead ^^
            part = new Part(3076, "SubFrameAssyH", this, 1, m_subAssemblyWidth);
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
            part = new Part(759, "GE SilPruf", this, 2, peri);
            part.PartGroupType = "GeSilpruf";
            part.PartLabel = "";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);


            #endregion

        }

        #endregion

    }
}