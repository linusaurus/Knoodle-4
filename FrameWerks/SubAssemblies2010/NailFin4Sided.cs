﻿#region Copyright (c) 2015 WeaselWare Software
/************************************************************************************
'
' Copyright  2015 WeaselWare Software 
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
' Portions Copyright 2015 WeaselWare Software
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


namespace FrameWorks.Makes.System2010
{
    [Serializable()]
    public class NailFin4Sided : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal nailFinAd2X = 1.21875m * 2.0m;
        //const decimal NFtab = 3.125m;

        //



        #endregion

        #region Constructor

        public NailFin4Sided()
        {
            subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-NailFin4Sided";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Component Component;

            string Componentleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;


            #region NailFin



            // NailerWidthExt
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4373, "NailerWidthExt", this, 1, m_subAssemblyWidth + nailFinAd2X);
                Component.ComponentGroupType = "NailFin-Components";
                Component.ComponentLabel = "1)MiterEnds";

                m_Components.Add(Component);

            }

            /////////////////////////////////////////////////////////////////////////////////////////

            //NailerVertExt
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4373, "NailerVertExt", this, 1, m_subAssemblyHieght + nailFinAd2X);
                Component.ComponentGroupType = "NailFin-Components";
                Component.ComponentLabel = "1)MiterEnds";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////

            // NailFinTabs

            //Component = new Component(3649, "NailFinTabs3Inch", this, Convert.ToInt32(this.Perimeter / 16.0m + 1.0m), NFtab);
            //Component.ComponentGroupType = "NailFin-Components";
            //Component.ComponentLabel = "CUT_LENGTH_3_INCHES";

            //m_Components.Add(Component);

            /////////////////////////////////////////////////////////////////////////////////////////



            #endregion


        }

        #endregion

    }
}