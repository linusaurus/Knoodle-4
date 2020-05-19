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
    public class SubFrameSplitPocket : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public SubFrameSplitPocket()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Tiburon-SubFrameSplitPocket";
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


            // SubFrameIntJL <<--
            part = new Part(911, "SubFrameIntJL", this, 1, m_subAssemblyHieght - 1 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameIntJR -->
            part = new Part(911, "SubFrameIntJR", this, 1, m_subAssemblyHieght - 1 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameExtJL <<--
            part = new Part(911, "SubFrameExtJL", this, 1, m_subAssemblyHieght - 1 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameExtJR -->
            part = new Part(911, "SubFrameExtJR", this, 1, m_subAssemblyHieght - 1 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion

            #region SubHeadAssy


            // HDPE <<--
            part = new Part(3117, "HDPE", this, 1, m_subAssemblyWidth );
            part.PartGroupType = "SubHeadAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameHead -->
            part = new Part(3074, "SubHeadAssy", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "SubHeadAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);





            #endregion

            #region PocketTrim


            // Z_FrameIntLeft <<--
            part = new Part(911, "Z_FrameIntLeft", this, 1, m_subAssemblyHieght - 1 * .5m);
            part.PartGroupType = "PocketTrim-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // Z_FrameIntRight -->
            part = new Part(911, "Z_FrameIntRight", this, 1, m_subAssemblyHieght - 1 * .5m);
            part.PartGroupType = "PocketTrim-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // Z_FrameExtLeft <<--
            part = new Part(911, "Z_FrameExtLeft", this, 1, m_subAssemblyHieght - 1 * .5m);
            part.PartGroupType = "PocketTrim-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // Z_FrameExtRight -->
            part = new Part(911, "Z_FrameExtRight", this, 1, m_subAssemblyHieght - 1 * .5m);
            part.PartGroupType = "PocketTrim-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion

            #region CapAssySS


            // CapAssySSOuterLeft <<--
            part = new Part(3128, "CapAssySSExtL", this, 1, m_subAssemblyHieght - 1 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerLeft <<--
            part = new Part(3128, "CapAssySSIntL", this, 1, m_subAssemblyHieght - 1 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterRight -->
            part = new Part(3128, "CapAssySSExtR", this, 1, m_subAssemblyHieght - 1 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerRight -->
            part = new Part(3128, "CapAssySSIntR", this, 1, m_subAssemblyHieght - 1 * .5m);
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