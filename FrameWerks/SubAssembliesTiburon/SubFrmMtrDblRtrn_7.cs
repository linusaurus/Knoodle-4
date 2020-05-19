#region Copyright (c) 2012 WeaselWare Software
/************************************************************************************
'
' Copyright  2012 WeaselWare Software 
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
' Portions Copyright 2012 WeaselWare Software
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
    public class SubFrmMtrDblRtrn_7 : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public SubFrmMtrDblRtrn_7()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Tiburon-SubFrmMtrDblRtrn_7";
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
            part = new Part(3074, "SubFrameAssyJL", this, 1, m_subAssemblyHieght - 2.0m * 0.50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyRight -->
            part = new Part(3074, "SubFrameAssyJR", this, 1, m_subAssemblyHieght - 2.0m * 0.50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyHead ^^
            part = new Part(3074, "SubFrameAssyHeadFace", this, 1, m_subAssemblyWidth - 2.0m * 0.14477244m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyHead ^^
            part = new Part(3074, "SubFrameAssyHeadDepthL", this, 1, m_subAssemblyDepth - 1.0m * 0.14477244m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyHead ^^
            part = new Part(3074, "SubFrameAssyHeadDepthR", this, 1, m_subAssemblyDepth - 1.0m * 0.14477244m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssySill ||
            part = new Part(3074, "SubFrameAssySill", this, 1, m_subAssemblyWidth - 2.0m * 0.14477244m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssySillDepthL ||
            part = new Part(3074, "SubFrameAssySillDepthL", this, 1, m_subAssemblyDepth - 1.0m * 0.14477244m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssySillDepthR ^^
            part = new Part(3074, "SubFrameAssySillDepthR", this, 1, m_subAssemblyDepth - 1.0m * 0.14477244m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion

            #region CapAssySS


            // CapAssySSOuterLeft <<--
            part = new Part(3128, "CapAssySSExtL", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerLeft <<--
            part = new Part(3128, "CapAssySSIntL", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterRight -->
            part = new Part(3128, "CapAssySSExtR", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerRight -->
            part = new Part(3128, "CapAssySSIntR", this, 1, m_subAssemblyHieght - 2 * .50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterTop ^^
            part = new Part(3128, "CapAssySSOuterTop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerTop ^^
            part = new Part(3128, "CapAssySSInnerTop", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterTopL ^^
            part = new Part(3128, "CapAssySSOuterTopL", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerTopL ^^
            part = new Part(3128, "CapAssySSInnerTopL", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterTopR ^^
            part = new Part(3128, "CapAssySSOuterTopR", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerTopR ^^
            part = new Part(3128, "CapAssySSInnerTopR", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterBot ||
            part = new Part(3128, "CapAssySSExtB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerBot ||
            part = new Part(3128, "CapAssySSIntB", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterBotL ||
            part = new Part(3128, "CapAssySSOuterBotL", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerBotL ||
            part = new Part(3128, "CapAssySSInnerBotL", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterBotR ||
            part = new Part(3128, "CapAssySSOuterBotR", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerBotR ||
            part = new Part(3128, "CapAssySSInnerBotR", this, 1, m_subAssemblyDepth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion

            #region GeSilpruf


            decimal peri = Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyDepth);
            peri += Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);



            //GeSilpruf
            part = new Part(759, "GE SilPruf", this, 4, peri);
            part.PartGroupType = "GeSilpruf";
            part.PartLabel = "";
            part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);


            #endregion

        }

        #endregion

    }
}