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

    public class FrameSpndrlParts : SubAssemblyBase
    {

        #region Fields

        //Constant Values



        #endregion

        #region Constructor

        public FrameSpndrlParts()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrameSpndrlParts";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region FrameAlum

            //////////////////////////////////////////////////////////////////////////////

            // BaseFrameVert
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4360, "BaseFrameVert", this, 1, m_subAssemblyHieght );
                part.PartGroupType = "FrameAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "BaseV";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // BaseFrameHorz
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4360, "BaseFrameHorz", this, 1, m_subAssemblyWidth );
                part.PartGroupType = "FrameAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "BaseH";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            // ClampVert
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4359, "ClampVert", this, 1, m_subAssemblyHieght );
                part.PartGroupType = "FrameAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "BaseV";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // ClampHorz
            for (int i = 0; i < 1; i++)
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

            //CapVt
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4358, "CapVt", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "CapAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //CapHz  
            for (int i = 0; i < 1; i++)
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

            #region GlazingSeal

            for (int i = 0; i < 4; i++)
            {

                //decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght + gasketAdd, m_subAssemblyWidth + gasketAdd);

                //Glazing Seals
                part = new Part(4314, "GlazDartEPDM_Vt", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            for (int i = 0; i < 4; i++)
            {

                //decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                part = new Part(4314, "GlazDartEPDM_Hz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }



            #endregion

        }

        #endregion

    }
}