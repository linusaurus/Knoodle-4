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
    public class Frame_5_Alum_AwnMotr : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal centerReduce = 0.1385125m;
        const decimal screenReduce = 1.56649272m;



        static int createID;

        #endregion

        #region Constructor

        public Frame_5_Alum_AwnMotr()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "TiburAlum-Frame_5_Alum_AwnMotr";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();




            #region AlumAgl_5_Awning



            // AlumHorzInt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3621, "AlumHorzInt", this, 1, m_subAssemblyWidth - centerReduce * 2.0m);
                part.PartGroupType = "AlumAgl_5_Awning-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }



            // AlumHorzExt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3618, "AlumHorzExt", this, 1, m_subAssemblyWidth - centerReduce * 2.0m);
                part.PartGroupType = "AlumAgl_5_Awning-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }



            // AlumVertInt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3621, "AlumVertInt", this, 1, m_subAssemblyHieght - centerReduce * 2.0m);
                part.PartGroupType = "AlumAgl_5_Awning-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            // AlumVertExt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3618, "AlumVertExt", this, 1, m_subAssemblyHieght - centerReduce * 2.0m);
                part.PartGroupType = "AlumAgl_5_Awning-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }



            #endregion


            #region ScreenFrame



            // ScreenHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3610, "ScreenHorz", this, 1, m_subAssemblyWidth - screenReduce * 2.0m);
                part.PartGroupType = "ScreenFrame-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }



            // ScreenVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3610, "ScreenVert", this, 1, m_subAssemblyHieght - screenReduce * 2.0m);
                part.PartGroupType = "ScreenFrame-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);
            }



            #endregion


            #region Hardware-Parts


            // MotorActuator200mm
            part = new Part(3765, "MotorActuator200mm", this, 1, 0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion

        }

        #endregion

    }
}