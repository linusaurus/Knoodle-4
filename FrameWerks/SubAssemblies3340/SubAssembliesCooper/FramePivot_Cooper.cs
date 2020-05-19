#region Copyright (c) 2015 WeaselWare Software
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

namespace FrameWorks.Makes.System3340
{

    public class FramePivot_Cooper : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal calkGap = 0.1250m;



        #endregion

        #region Constructor

        public FramePivot_Cooper()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3340-FramePivot_Cooper";
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



            #region FrameBrz

            //////////////////////////////////////////////////////////////////////////////

            // Frame_4364Vert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4364, "Frame_4364Vert", this, 1, m_subAssemblyHieght - calkGap);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "90°BotCut_LH_Swing";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Frame_4364_Head
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4364, "Frame_4364_Head", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "LH_Swing";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion



        }

        #endregion
    }
}