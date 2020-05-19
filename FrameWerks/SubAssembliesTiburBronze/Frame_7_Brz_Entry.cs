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
    public class Frame_7_Brz_Entry : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal centerReduce = 0.1385125m;
        const decimal glassReduce = 0.500001m;



        static int createID;

        #endregion

        #region Constructor

        public Frame_7_Brz_Entry()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "TiburBronze-Frame_7_Brz_Entry";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region BrzAgl_7_FixedIG




            // BronzeHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3695, "BronzeHorz", this, 1, m_subAssemblyWidth - centerReduce);
                part.PartGroupType = "BrzAgl_7_FixedIG-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }



            // BronzeVert
            for (int i = 0; i < 4; i++)
            {
                part = new Part(3695, "BronzeVert", this, 1, m_subAssemblyHieght - centerReduce);
                part.PartGroupType = "BrzAgl_7_FixedIG-Parts";
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