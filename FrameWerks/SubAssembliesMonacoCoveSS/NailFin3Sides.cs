#region Copyright (c) 2014 WeaselWare Software
/************************************************************************************
'
' Copyright  2014 WeaselWare Software 
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
' Portions Copyright 2014 WeaselWare Software
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

namespace FrameWorks.Makes.MonacoCoveSS
{

    public class Nailer3side : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal frameFinAdd = 1.25m;
        const decimal gasketReduce = 1.375m;

        static int createID;

        #endregion

        #region Constructor

        public Nailer3side()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "MonacoCoveSS-Nailer3side";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region NailFin



            //NailerLeft

            part = new Part(3308, "NailerLeft", this, 1, m_subAssemblyHieght + frameFinAdd);
            part.PartGroupType = "NailFin-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // NailerRight

            part = new Part(3308, "NailerRight", this, 1, m_subAssemblyHieght + frameFinAdd);
            part.PartGroupType = "NailFin-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // NailerTop

            part = new Part(3308, "NailerTop", this, 1, m_subAssemblyWidth + frameFinAdd * 2.0m);
            part.PartGroupType = "NailFin-Parts";
            part.PartLabel = "";

            m_parts.Add(part);





            #endregion



        }



        #endregion


    }
}