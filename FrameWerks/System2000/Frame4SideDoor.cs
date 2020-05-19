#region Copyright (c) 2007 WeaselWare Software
/************************************************************************************
'
' Copyright  2007 WeaselWare Software 
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
' Portions Copyright 2007 WeaselWare Software
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
    
    public class Frame4SideDoor : SubAssemblyBase
    {

        #region Fields

        static int createID;


        #endregion

        #region Constructor

        public Frame4SideDoor()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys2000-Frame4SideDoor";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            



            #region Frame-Parts


            // JambL <<-- 
            part = new Part(2030, "JambL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
           
            m_parts.Add(part);


            // JambR -->> 
            part = new Part(2030, "JambR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
           
            m_parts.Add(part);


            // Head ^^
            part = new Part(2030, "Head", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
           
            m_parts.Add(part);


            // Sill ||
            part = new Part(2030, "Sill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";
           
            m_parts.Add(part);


            #endregion


            #region Hardware-Parts


            // Braces
            part = new Part(2674, "Corner Braces", this, 8, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            #endregion


            #region WeatherSeals


            //Foam Tite Seals
            decimal peri = m_subAssemblyHieght * 2.0m;
            peri += m_subAssemblyWidth * 2.0m;
            part = new Part(1769, "Foam Tite Seals", this, 1, peri);
            part.PartGroupType = "WeatherSeals-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            #endregion


            }

        #endregion


        }
    }
