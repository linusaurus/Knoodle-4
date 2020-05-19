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
    public class SubFrmM40Horz_7 : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public SubFrmM40Horz_7()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Tiburon-SubFrmM40Horz_7";
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


            // SubFrameAssyHorz1
            part = new Part(3074, "SubFrameAssyHorz1", this, 1, 38.1250m );
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyHorz2
            part = new Part(3074, "SubFrameAssyHorz2", this, 1, 41.75m );
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyHorz3
            part = new Part(3074, "SubFrameAssyHorz3", this, 1, 25.25m );
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyHorz4
            part = new Part(3074, "SubFrameAssyHorz4", this, 1, 31.50m );
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyHorz5
            part = new Part(3074, "SubFrameAssyHorz5", this, 1, 31.50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyHorz6
            part = new Part(3074, "SubFrameAssyHorz6", this, 1, 25.25m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyHorz7
            part = new Part(3074, "SubFrameAssyHorz7", this, 1, 41.75m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion

            #region CapAssySS


            // CapAssySSOuterHorz1
            part = new Part(3128, "CapAssySSOuterHorz1", this, 1, 38.1250m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerHorz1
            part = new Part(3128, "CapAssySSInnerHorz1", this, 1, 38.1250m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterHorz2
            part = new Part(3128, "CapAssySSOuterHorz2", this, 1, 41.75m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerHorz2
            part = new Part(3128, "CapAssySSInnerHorz2", this, 1, 41.75m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterHorz3
            part = new Part(3128, "CapAssySSOuterHorz3", this, 1, 25.25m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerHorz3
            part = new Part(3128, "CapAssySSInnerHorz3", this, 1, 25.25m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterHorz4
            part = new Part(3128, "CapAssySSOuterHorz4", this, 1, 31.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerHorz4
            part = new Part(3128, "CapAssySSInnerHorz4", this, 1, 31.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterHorz5
            part = new Part(3128, "CapAssySSOuterHorz5", this, 1, 31.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerHorz5
            part = new Part(3128, "CapAssySSInnerHorz5", this, 1, 31.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterHorz6
            part = new Part(3128, "CapAssySSOuterHorz6", this, 1, 25.25m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerHorz6
            part = new Part(3128, "CapAssySSInnerHorz6", this, 1, 25.25m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterHorz7
            part = new Part(3128, "CapAssySSOuterHorz7", this, 1, 41.75m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerHorz7
            part = new Part(3128, "CapAssySSInnerHorz7", this, 1, 41.75m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion

            #region GeSilpruf



            //GeSilpruf
            part = new Part(759, "GE SilPruf", this, 1, 235.125m * 2.0m);
            part.PartGroupType = "GeSilpruf";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion

        }

        #endregion

    }
}