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
    public class SubFrmTenVerts5_5 : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public SubFrmTenVerts5_5()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Tiburon-SubFrmTenVerts5_5";
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


            // SubFrameAssyVertDiv ||
            part = new Part(3076, "SubFrameAssyVertDiv", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVertDiv ||
            part = new Part(3076, "SubFrameAssyVertDiv", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVertDiv ||
            part = new Part(3076, "SubFrameAssyVertDiv", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVertDiv ||
            part = new Part(3076, "SubFrameAssyVertDiv", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVertDiv ||
            part = new Part(3076, "SubFrameAssyVertDiv", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVertDiv ||
            part = new Part(3076, "SubFrameAssyVertDiv", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVertDiv ||
            part = new Part(3076, "SubFrameAssyVertDiv", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVertDiv ||
            part = new Part(3076, "SubFrameAssyVertDiv", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            // SubFrameAssyVertDiv ||
            part = new Part(3076, "SubFrameAssyVertDiv", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrameAssyVertDiv ||
            part = new Part(3076, "SubFrameAssyVertDiv", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion


            #region CapAssySS



            // CapAssySSOuterVertD1
            part = new Part(3128, "CapAssySSOuterVertD1", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerVertD1
            part = new Part(3128, "CapAssySSInnerVertD1", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterVertD2 
            part = new Part(3128, "CapAssySSOuterVertD2", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerVertD2 
            part = new Part(3128, "CapAssySSInnerVertD2", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterVertD3
            part = new Part(3128, "CapAssySSOuterVertD3", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerVertD3 
            part = new Part(3128, "CapAssySSInnerVertD3", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterVertD4 
            part = new Part(3128, "CapAssySSOuterVertD4", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerVertD4 
            part = new Part(3128, "CapAssySSInnerVertD4", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterVertD5 
            part = new Part(3128, "CapAssySSOuterVertD5", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerVertD5 
            part = new Part(3128, "CapAssySSInnerVertD5", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            // CapAssySSOuterVertD6
            part = new Part(3128, "CapAssySSOuterVertD6", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerVertD6 
            part = new Part(3128, "CapAssySSInnerVertD6", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuterVertD7 
            part = new Part(3128, "CapAssySSOuterVertD7", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerVertD7 
            part = new Part(3128, "CapAssySSInnerVertD7", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            // CapAssySSOuterVertD8 
            part = new Part(3128, "CapAssySSOuterVertD8", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerVertD8 
            part = new Part(3128, "CapAssySSInnerVertD8", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            // CapAssySSOuterVertD9 
            part = new Part(3128, "CapAssySSOuterVertD9", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerVertD9 
            part = new Part(3128, "CapAssySSInnerVertD9", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);



            // CapAssySSOuterVertD10
            part = new Part(3128, "CapAssySSOuterVertD10", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInnerVertD10 
            part = new Part(3128, "CapAssySSInnerVertD10", this, 1, m_subAssemblyHieght - 2 * .5m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);




            #endregion


            #region GeSilpruf



            //GeSilpruf
            part = new Part(759, "GE SilPruf", this, 1, m_subAssemblyHieght + 10 * 2.0m);
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