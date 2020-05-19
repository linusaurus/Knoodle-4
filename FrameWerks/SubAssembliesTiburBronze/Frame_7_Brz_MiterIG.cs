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


namespace FrameWorks.Makes.TiburBronze
{
    [Serializable()]
    public class Frame_7_Brz_MiterIG : SubAssemblyBase
    {

        #region Fields


        //Constant Values
        const decimal capWidth = 1.0975m;
        const decimal halfCap = capWidth / 2.0m;
        const decimal finFrmbk = 0.6726m;
        const decimal capHeight = 0.6301m;
        const decimal centerReduce = 0.123813m;
        const decimal capMiteReduce = 0.351451m;
        const decimal frameIntRedMiter = 4.011052m;
        const decimal glassReduce = 0.51375m;
        const decimal glasRdutWide = 2.7075m;
        const decimal glasRdutDepth = 4.6675m;


        static int createID;

        #endregion

        #region Constructor

        public Frame_7_Brz_MiterIG()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "TiburBronze-Frame_7_Brz_MiterIG";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region BrzAgl_7_FixedIG




            // BronzeHorzExt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3695, "BronzeHorzExt<|", this, 1, (m_subAssemblyWidth) - (centerReduce) - (capMiteReduce));
                part.PartGroupType = "BrzAgl_7_FixedIG-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            // BronzeHorzInt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3695, "BronzeHorzInt<|", this, 1, (m_subAssemblyWidth) - (centerReduce) - (frameIntRedMiter));
                part.PartGroupType = "BrzAgl_7_FixedIG-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            // BronzeVert
            for (int i = 0; i < 4; i++)
            {
                part = new Part(3695, "BronzeVert", this, 1, (m_subAssemblyHieght) - (centerReduce * 2.0m));
                part.PartGroupType = "BrzAgl_7_FixedIG-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            // BronzeHorzExt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3695, "BronzeHorzExt<|", this, 1, (m_subAssemblyDepth) - (centerReduce) - (capMiteReduce));
                part.PartGroupType = "BrzAgl_7_FixedIG-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            // BronzeHorzInt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3695, "BronzeHorzInt<|", this, 1, (m_subAssemblyDepth) - (centerReduce) - (frameIntRedMiter));
                part.PartGroupType = "BrzAgl_7_FixedIG-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion


            #region Glass



            //Glass Panel

            part = new Part(3474);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce + glasRdutWide);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);

            m_parts.Add(part);



            //Glass Panel

            part = new Part(3474);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyDepth - (glassReduce + glasRdutDepth);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);

            m_parts.Add(part);



            #endregion


            #region GlazingSeal

            //Glazing Seals
            for (int i = 0; i < 2; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth, m_subAssemblyDepth);

                part = new Part(2772, "Glazing Seal", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion



        }

        #endregion

    }
}