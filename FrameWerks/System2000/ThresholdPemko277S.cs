#region Copyright (c) 2011 WeaselWare Software
/************************************************************************************
'
' Copyright  2011 WeaselWare Software 
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
' Portions Copyright 2011 WeaselWare Software
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

namespace FrameWorks.Makes.System2000
{

    public class ThresholdPemko277S : SubAssemblyBase
    {

        #region Fields

        static int createID;


        #endregion

        #region Constructor

        public ThresholdPemko277S()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys2000-ThresholdPemko277S";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;


            #region HardWare


            // ThresholdPemko277_S
            part = new Part(2696, "Pemko277_S", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion


        }

        #endregion


    }
}


