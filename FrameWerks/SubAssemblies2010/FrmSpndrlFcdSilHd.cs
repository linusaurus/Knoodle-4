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

namespace FrameWorks.Makes.System2010
{

    public class FrmSpndrlFcdSilHd : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal baseReduce = 0.3746m;
        const decimal glasMidRed = 0.125m;
        const decimal glassReduce = 1.03125m;
        const decimal gasketReduce = 1.037m;
        const decimal gasketAdd = 0.2338m;


        #endregion

        #region Constructor

        public FrmSpndrlFcdSilHd()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrmSpndrlFcdSilHd";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region FrameAlum

            // BaseFrameHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4360, "BaseFrameHorz", this, 1, m_subAssemblyWidth - baseReduce);
                part.PartGroupType = "FrameAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "BaseH";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // ClampHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4359, "ClampHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "BaseH";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region CapAlum

            //////////////////////////////////////////////////////////////////////////////

            //CapHz  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4358, "CapHz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "CapAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass

            //Glass Panel

            part = new Part(2989);

            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce + glasMidRed) ;
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 0.25m;

            m_parts.Add(part);

            #endregion

            #region GlazingSeal

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                part = new Part(4314, "GlazDartEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                part = new Part(4399, "GlazWedgEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketAdd, m_subAssemblyWidth - gasketAdd);

                //Glazing Seals
                part = new Part(4399, "GlazWedgEPDM", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            #endregion

        }

        #endregion

    }
}