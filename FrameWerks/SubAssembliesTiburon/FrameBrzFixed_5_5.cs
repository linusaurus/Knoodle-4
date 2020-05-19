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
    public class FrameBrzFixed_5_5 : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public FrameBrzFixed_5_5()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Tiburon-FrameBrzFixed_5_5";
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



            #region FixedStopAngleBrz


            // FrameExtLeft <<--
            part = new Part(3143, "FrameExtL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FixedStopAngleBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL;

            m_parts.Add(part);


            // FrameIntLeft <<--
            part = new Part(3143, "FrameIntL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FixedStopAngleBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL;

            m_parts.Add(part);


            // FrameExtRight -->
            part = new Part(3143, "FrameExtR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FixedStopAngleBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL;

            m_parts.Add(part);


            // FrameIntRight -->
            part = new Part(3143, "FrameIntR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "FixedStopAngleBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL;

            m_parts.Add(part);


            // FrameExtHead ^^
            part = new Part(3143, "FrameExtH", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FixedStopAngleBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL;

            m_parts.Add(part);


            // FrameIntHead ^^
            part = new Part(3143, "FrameIntH", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FixedStopAngleBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL;

            m_parts.Add(part);


            // FrameExtSill ||
            part = new Part(3143, "FrameExtS", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FixedStopAngleBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL;

            m_parts.Add(part);


            // FrameIntSill ||
            part = new Part(3143, "FrameIntS", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "FixedStopAngleBrz-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL;

            m_parts.Add(part);



            #endregion

            #region Glass



            //Glass Panel

            part = new Part(3116);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (0.25m * 2.0m);
            part.PartLength = m_subAssemblyHieght - -(0.25m * 2.0m);

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