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

namespace FrameWorks.Makes.System3000
{
    
    public class NailerMiter : SubAssemblyBase
    {

        #region Fields



        #endregion

        #region Constructor

        public NailerMiter()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys3000-NailerMiter";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            

            #region Nail Fin Perimeter


            // Top Nailer ^^
            part = new Part(922, "Top Nail Fin", this, 1, m_subAssemblyWidth + (1.280m * 2.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // Bot Nailer ||
            part = new Part(922, "Bottom Nail Fin", this, 1, m_subAssemblyWidth + (1.280m * 2.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // Left Nailer <<--
            part = new Part(922, "Left Nail Fin", this, 1, m_subAssemblyHieght + (1.280m * 2.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // Right Nailer -->>
            part = new Part(922, "Right Nail Fin", this, 1, m_subAssemblyHieght + (1.280m * 2.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // Top Miter Nailer ^^
            part = new Part(922, "Top M1 Nail Fin", this, 1, m_subAssemblyDepth + (1.280m * 2.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // Bot Miter Nailer ||
            part = new Part(922, "Bottom M1 Nail Fin", this, 1, m_subAssemblyDepth + (1.280m * 2.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // Top Miter Nailer ^^
            part = new Part(922, "Top M2 Nail Fin", this, 1, m_subAssemblyDepth + (1.280m * 2.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            // Bot Miter Nailer ||
            part = new Part(922, "Bottom M2 Nail Fin", this, 1, m_subAssemblyDepth + (1.280m * 2.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);
            #endregion



            #region Labor

            part = new LPart("AttachmentHours",this, 0.0m, 80.0m);
            m_parts.Add(part);
            //0 Attachment

            #endregion


        }



        #endregion


    }
}