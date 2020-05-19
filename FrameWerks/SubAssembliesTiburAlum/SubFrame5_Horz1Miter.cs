
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


namespace FrameWorks.Makes.TiburAlum
{
    [Serializable()]
    public class SubFrame5_Horz1Miter : SubAssemblyBase
    {

        #region Fields 

        //Constant Values
        const decimal subRedVert = .2988m;
        const decimal subRedHorz = .7988m;
        const decimal subRedMiter = .4273m;
        const decimal subRedMid = .25m;
        const decimal capReduce = 1.0975m;
        const decimal capHalfReduce = 0.54875m;
        const decimal capReMiter = 5.0000m;

        static int createID;

        #endregion

        #region Constructor

        public SubFrame5_Horz1Miter()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "TiburAlum-SubFrame5_Horz1Miter";
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
            ///////////////////////////////////////////////////////////////////////////////////////////////


            #region SubFrameAssy



            // SubFrameHorz
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3076, "SubFrameHorz", this, 1, m_subAssemblyWidth - subRedHorz - capHalfReduce);
                part.PartGroupType = "SubFrameAssy-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }




            // SubFrameHorz
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3076, "SubFrameHorz", this, 1, m_subAssemblyDepth - subRedHorz - capHalfReduce);
                part.PartGroupType = "SubFrameAssy-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }




            #endregion

            #region CapAssy



            // CapAlumHorzExt
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3611, "CapAlumHorzExt90B", this, 1, m_subAssemblyWidth - capHalfReduce);
                part.PartGroupType = "CapAssy-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }



            // CapAlumHorzInt
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3611, "CapAlumHorzInt90C", this, 1, m_subAssemblyWidth - capReMiter - capHalfReduce);
                part.PartGroupType = "CapAssy-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }



            // CapAlumHorzExt
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3611, "CapAlumHorzExt90B", this, 1, m_subAssemblyDepth - capHalfReduce);
                part.PartGroupType = "CapAssy-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }



            // CapAlumHorzInt
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3611, "CapAlumHorzInt90C", this, 1, m_subAssemblyDepth - capReMiter - capHalfReduce);
                part.PartGroupType = "CapAssy-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }



            #endregion

            #region CornerBrackets


            // CornerBrackets
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3820, "CornerBrackets", this, 1, 0.0m);
                part.PartGroupType = "CornerBrackets-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion

            #region GeSilpruf



            //GeSilpruf
            for (int i = 0; i < 2; i++)
            {
                part = new Part(759, "GE SilPruf", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "GeSilpruf";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            //GeSilpruf
            for (int i = 0; i < 2; i++)
            {
                part = new Part(759, "GE SilPruf", this, 1, m_subAssemblyDepth);
                part.PartGroupType = "GeSilpruf";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }




            #endregion



        }

        #endregion

    }
}