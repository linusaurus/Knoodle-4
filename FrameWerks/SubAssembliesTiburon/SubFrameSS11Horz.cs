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
    public class SubFrameSS11Horz : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public SubFrameSS11Horz()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Tiburon-SubFrameSS11Horz";
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


            // SubFrame1of11Horz
            part = new Part(3076, "SubFrame1of11Horz", this, 1, 39.50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrame2of11Horz
            part = new Part(3076, "SubFrame2of11Horz", this, 1, 40.00m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrame3of11Horz
            part = new Part(3076, "SubFrame3of11Horz", this, 1, 42.75m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrame4of11Horz
            part = new Part(3076, "SubFrame4of11Horz", this, 1, 30.25m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrame5of11Horz
            part = new Part(3076, "SubFrame5of11Horz", this, 1, 29.50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrame6of11Horz
            part = new Part(3076, "SubFrame6of11Horz", this, 1, 69.50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrame7of11Horz
            part = new Part(3076, "SubFrame7of11Horz", this, 1, 29.50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrame8of11Horz
            part = new Part(3076, "SubFrame8of11Horz", this, 1, 30.25m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrame9of11Horz
            part = new Part(3076, "SubFrame9of11Horz", this, 1, 42.75m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrame10of11Horz
            part = new Part(3076, "SubFrame10of11Horz", this, 1, 40.00m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // SubFrame11of11Horz
            part = new Part(3076, "SubFrame11of11Horz", this, 1, 39.50m);
            part.PartGroupType = "SubFrameAssy-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion


            #region CapAssySS


            // CapAssySSOuter1of11Horz
            part = new Part(3128, "CapAssySSOuter1of11Horz", this, 1, 39.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInner1of11Horz ^^
            part = new Part(3128, "CapAssySSInner1of11Horz", this, 1, 39.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuter2of11Horz
            part = new Part(3128, "CapAssySSOuter2of11Horz", this, 1, 40.00m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInner2of11Horz ^^
            part = new Part(3128, "CapAssySSInner2of11Horz", this, 1, 40.00m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuter3of11Horz
            part = new Part(3128, "CapAssySSOuter3of11Horz", this, 1, 42.75m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInner3of11Horz ^^
            part = new Part(3128, "CapAssySSInner3of11Horz", this, 1, 42.75m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuter4of11Horz
            part = new Part(3128, "CapAssySSOuter4of11Horz", this, 1, 30.25m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInner4of11Horz ^^
            part = new Part(3128, "CapAssySSInner4of11Horz", this, 1, 30.25m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuter5of11Horz
            part = new Part(3128, "CapAssySSOuter5of11Horz", this, 1, 29.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInner5of11Horz ^^
            part = new Part(3128, "CapAssySSInner5of11Horz", this, 1, 29.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuter6of11Horz
            part = new Part(3128, "CapAssySSOuter6of11Horz", this, 1, 69.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInner6of11Horz ^^
            part = new Part(3128, "CapAssySSInner6of11Horz", this, 1, 69.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuter7of11Horz
            part = new Part(3128, "CapAssySSOuter7of11Horz", this, 1, 29.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInner7of11Horz ^^
            part = new Part(3128, "CapAssySSInner7of11Horz", this, 1, 29.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuter8of11Horz
            part = new Part(3128, "CapAssySSOuter8of11Horz", this, 1, 30.25m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInner8of11Horz ^^
            part = new Part(3128, "CapAssySSInner8of11Horz", this, 1, 30.25m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuter9of11Horz
            part = new Part(3128, "CapAssySSOuter9of11Horz", this, 1, 42.75m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInner9of11Horz ^^
            part = new Part(3128, "CapAssySSInner9of11Horz", this, 1, 42.75m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuter10of11Horz
            part = new Part(3128, "CapAssySSOuter10of11Horz", this, 1, 40.00m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInner10of11Horz ^^
            part = new Part(3128, "CapAssySSInner10of11Horz", this, 1, 40.00m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSOuter11of11Horz
            part = new Part(3128, "CapAssySSOuter11of11Horz", this, 1, 39.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            // CapAssySSInner11of11Horz ^^
            part = new Part(3128, "CapAssySSInner11of11Horz", this, 1, 39.50m);
            part.PartGroupType = "CapAssySS-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion


            #region GeSilpruf



            //GeSilpruf
            part = new Part(759, "GE SilPruf", this, 1, 440m * 2.0m);
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