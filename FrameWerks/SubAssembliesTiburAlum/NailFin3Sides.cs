#region Copyright (c) 2012 WeaselWare Software
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


namespace FrameWorks.Makes.TiburAlum
{
    [Serializable()]
    public class NailFin3Sides : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal subReduce = .29875m;
        const decimal capReduce = 1.0975m;
        const decimal nailFinAd = 0.9513m;


        static int createID;

        #endregion

        #region Constructor

        public NailFin3Sides()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "TiburAlum-NailFin3Sides";
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
                part = new Part(3308, "NailerWidthExt", this, 1, m_subAssemblyWidth + nailFinAd * 2.0m);
                part.PartGroupType = "NailFin-Parts";
                part.PartLabel = "1)MiterEnds";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////

            //NailerVertExt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3308, "NailerVertExt", this, 1, m_subAssemblyHieght + nailFinAd );
                part.PartGroupType = "NailFin-Parts";
                part.PartLabel = "1)MiterEnds";

                m_parts.Add(part);

            }


            //////////////////////////////////////////////////////////////////////////////////////////



            // NailFinTabs
            part = new Part(3308, "NailFinTabs", this, Convert.ToInt32((this.Perimeter - m_subAssemblyWidth) / 16.0m) - 1, 3.125m);
            part.PartGroupType = "NailFin-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);


            /////////////////////////////////////////////////////////////////////////////////////////



            #endregion






        }

        #endregion

    }
}