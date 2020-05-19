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

    public class FixedIG4LiteArch : SubAssemblyBase
    {

        #region Fields

        // Extra Material for Bending
        const decimal stopInset = 0.625m;
        //Constant Values
        const decimal muntFrmRedX2 = 1.656m;
        const decimal delReduceX2 = 1.576m;
        const decimal glassReduce = .9375m;
        const decimal glassMuntRedX2 = .375m;
        const decimal gasketReduce = .922m;

        //static int createID;


        #endregion

        #region Constructor

        public FixedIG4LiteArch()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3530-FixedIG4LiteArch";
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
            part = new Part(3892, "BrzStpVertArch", this, 1, arcLength);
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

            #region Muntin

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // BrzMuntinVert
            for (int i = 0; i < 6; i++)
            {
                part = new Part(3893, "BrzMuntinVert", this, 1, (m_subAssemblyHieght - muntFrmRedX2 ) );
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // DelrinDivVert
            for (int i = 0; i < 3; i++)
            {
                part = new Part(911, "DelrinDivVert", this, 1, (m_subAssemblyHieght - delReduceX2 ) );
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass


            /////////////////////////////////////////////////////////////////////////////////////
            // 4 Glass Panels
            for (int i = 0; i < 4; i++)
            {

                // 4 Glass Panels
                part = new Part(4420);

                part.FunctionalName = "Glass";
                part.PartGroupType = "GlassPattern";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = ((m_subAssemblyWidth - 2 * glassReduce - 3.0m * glassMuntRedX2) / 4);
                part.PartLength = ((m_subAssemblyHieght - 2 * glassReduce - glassMuntRedX2) );
                part.PartThick = 1.0m;

                m_parts.Add(part);

            }
            ///////////////////////////////////////////////////////////////////////////////////////



            #endregion

            #region GlazingSeal


            for (int i = 0; i < 2; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                part = new Part(3904, "Glazing Seal", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion



        }
        #endregion

    }




}