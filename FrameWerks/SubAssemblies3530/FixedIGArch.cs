#region Copyright (c) 2013 WeaselWare Software
/************************************************************************************
'
' Copyright  2013 WeaselWare Software 
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
' Portions Copyright 2013 WeaselWare Software
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

namespace FrameWorks.Makes.System3530
{

    public class FixedIGArch : SubAssemblyBase
    {

        #region Fields

        // Extra Material for Bending
        const decimal stopInset = 0.625m;

        //static int createID;


        #endregion

        #region Constructor

        public FixedIGArch()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3530-FixedIGArch";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;


            //Fuction for Arched Top Rail/Stop
            //decimal arcLength = FrameWorks.Functions.RadArc(Convert.ToDouble(m_subAssemblyWidth), 90);
            decimal arcLength = FrameWorks.Functions.ArcLength(Convert.ToDouble(m_subAssemblyWidth), Convert.ToDouble(m_subAssemblyDepth));



            #region FrameBrz
       
            //////////////////////////////////////////////////////////////////////////////////////////////

            // FrmJmbHdArch ^^

            for (int i = 0; i < 1; i++)
            {

                // FrmJmbHdArch ^^
                part = new Part(3947, "FrmJmbHdArch", this, 1, arcLength);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelTopRail = "StrechForm";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            // FrameJamb ||
            for (int i = 0; i < 1; i++)
            {

                // FrameJamb ||
                part = new Part(3947, "FrameJamb", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelBotRail = "1)MiterEnds";

                m_parts.Add(part);

            }



            //////////////////////////////////////////////////////////////////////////////////////////////////

            // SillBrz ||
            for (int i = 0; i < 1; i++)
            {

                // SillBrz ||
                part = new Part(3947, "SillBrz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelBotRail = "1)MiterEnds";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////

            #endregion


            #region BrzGlsStp

            // BrzStpVertArch #3892
            part = new Part(3892, "BrzStpVertArch", this, 1, arcLength );
            part.PartGroupType = "BrzGlsStp-Parts";
            part.PartLabel = "StrechForm";

            m_parts.Add(part);


            // BrzStpVert #3892
            part = new Part(3892, "BrzStpVert", this, 1, m_subAssemblyHieght - (2 * stopInset));
            part.PartGroupType = "BrzGlsStp-Parts";
            part.PartLabel = "FitTopMiter";

            m_parts.Add(part);


            // Stop-B #3892
            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - (2 * stopInset));
            part = new Part(3892, "GlassStop-B", this, 1, m_subAssemblyWidth - (2 * stopInset));
            part.PartGroupType = "BrzGlsStp-Parts";
            part.PartLabel = "1)MiterEnds" + "\r\n" + "2)" + crap;

            m_parts.Add(part);


            #endregion


            #region Glass

            //Glass Panel
            part = new Part(4420);
            part.FunctionalName = "PatternGlass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (0.875m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (0.875m * 2.0m);

            m_parts.Add(part);

            #endregion


            #region Seal/Weatherstripping


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);




            for (int i = 0; i < 2; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - .43491899m, m_subAssemblyWidth - .43491899m);

                //Glazing Seals
                part = new Part(2772, "Glazing Seal", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }



            #endregion






        }
        #endregion

    }




}