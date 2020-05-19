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
    public class Frame_5_Alum_FixIG2Vrts : SubAssemblyBase
    {


        #region Fields

        //Constant Values
        const decimal capWidth = 1.0975m;
        const decimal halfCap = capWidth / 2.0m;
        const decimal centerReduce = 0.1385125m;
        const decimal glassReduce = 0.51375m;
        const decimal gasketReduce = 0.6250m;



        static int createID;

        #endregion

        #region Constructor

        public Frame_5_Alum_FixIG2Vrts()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "TiburAlum-Frame_5_Alum_FixIG2Vrts";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region Frame_5_Alum_FixedIG



            // AlumVert
            for (int i = 0; i < 4; i++)
            {
                part = new Part(3615, "AlumVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "AlumAgl_7_FixedIG-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }



            #endregion



            #region GlazingSeal

            //Glazing Seals
            for (int i = 0; i < 4; i++)
            {


                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce * 2, m_subAssemblyWidth - gasketReduce * 2);

                part = new Part(2772, "Glazing Seal", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion





        }

        #endregion

    }
}