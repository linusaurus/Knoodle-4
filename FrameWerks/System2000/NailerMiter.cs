#region Copyright (c) 2010 WeaselWare Software
/************************************************************************************
'
' Copyright  2010 WeaselWare Software 
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
' Portions Copyright 2010 WeaselWare Software
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
    
    public class NailerMiter : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public NailerMiter()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2000-NailerMiter";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            

            #region Nail Fin Perimeter


            // TopNailerW ^^
            part = new Part(922, "TopNailFinW", this, 1, m_subAssemblyWidth + (1.2812m * 1.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // BotNailerW ||
            part = new Part(922, "BottomNailFinW", this, 1, m_subAssemblyWidth + (1.2812m * 1.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // TopNailerD ^^
            part = new Part(922, "TopNailFinD", this, 1, m_subAssemblyDepth + (1.2812m * 1.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // BotNailerD ||
            part = new Part(922, "BottomNailFinD", this, 1, m_subAssemblyDepth + (1.2812m * 1.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // Left Nailer <<--
            part = new Part(922, "Left Nail Fin", this, 1, m_subAssemblyHieght + (1.2812m * 2.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);

            // Right Nailer -->>
            part = new Part(922, "Right Nail Fin", this, 1, m_subAssemblyHieght + (1.2812m * 2.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);



            #endregion





        }



        #endregion


    }
}