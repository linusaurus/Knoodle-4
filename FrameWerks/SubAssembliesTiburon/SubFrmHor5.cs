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
    public class SubFrmHor5 : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public SubFrmHor5()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Tiburon-SubFrmHor5";
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


            // SubFrameAssyHorz
            part = new Part(3076, "SubFrameAssyHorz", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion


            #region CapAssySS


            // CapAssySSOuterHorz
            part = new Part(3128, "CapAssySSExtHorz", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerHorz ^^
            part = new Part(3128, "CapAssySSIntHorz", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion


            #region GeSilpruf



            //GeSilpruf
            part = new Part(759, "GE SilPruf", this, 1, m_subAssemblyWidth + 2 * 2.0m);
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