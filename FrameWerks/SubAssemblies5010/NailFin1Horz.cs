#region Copyright (c) 2016 WeaselWare Software
/************************************************************************************
'
' Copyright  2016 WeaselWare Software 
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
' Portions Copyright 2016 WeaselWare Software
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


namespace FrameWorks.Makes.System5010
{
    [Serializable()]
    public class NailFin1Horz : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        




        #endregion

        #region Constructor

        public NailFin1Horz()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-NailFin1Horz";
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


            #region NailFin

            // NailerWidthExt
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4501, "NailerWidthExt", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "NailFin-Parts";
                part.PartLabel = "1)MiterEnds";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////

            //NailerVertExt
            //for (int i = 0; i < 2; i++)
            //{
            //part = new Part(4501, "NailerVertExt", this, 1, m_subAssemblyHieght + nailFinAd * 2.0m);
            //part.PartGroupType = "NailFin-Parts";
            //part.PartLabel = "1)MiterEnds";

            //m_parts.Add(part);

            //}

            //////////////////////////////////////////////////////////////////////////////////////////

            #endregion


        }

        #endregion

    }
}