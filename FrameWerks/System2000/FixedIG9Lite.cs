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
    
    public class FixedIG9Lite : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public FixedIG9Lite()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys2000-FixedIG9Lite";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            

            #region Frame



            // JambLeft <<-- #2031
            part = new Part(2031, "JambL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);


            // JambRight -->> #2031
            part = new Part(2031, "JambR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);


            // Head ^^ #2031
            part = new Part(2031, "Head", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);


            // Sill || #2031
            part = new Part(2031, "Sill", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);


            // Mullion Vert #2675
            part = new Part (2675, "MullionV", this, 2, m_subAssemblyHieght - (0.625m * 2.0m ));
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "CopeEnds";
           
            m_parts.Add(part);


            // Mullion Horizontal #2675
            part = new Part(2675, "MullionH", this, 6, (m_subAssemblyWidth - 1.75m) / 3.0m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "CopeEnds";
           
            m_parts.Add(part);


            // Corner Brace #2674 
            part = new Part(2674, "BraceCorners", this, 8, decimal.Zero);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);



            #endregion


            #region GlassStop


            // StopL #800
            part = new Part(800, "StopL", this, 1, m_subAssemblyHieght - 2.0m * .625m);
            part.PartGroupType = "GlassStop";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);


            // StopR #800
            part = new Part(800, "StopR", this, 1, m_subAssemblyHieght - 2.0m * .625m);
            part.PartGroupType = "GlassStop";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);


            // StopT #800
            part = new Part(800, "StopT", this, 1, m_subAssemblyWidth - 2.0m * .625m);
            part.PartGroupType = "GlassStop";
            part.PartLabel = "MiterEnds";
           
            m_parts.Add(part);


            // StopB #800
            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 2.0m * .625m);
            part = new Part(800, "StopB", this, 1, m_subAssemblyWidth - 2.0m * .625m);
            part.PartGroupType = "GlassStop";
            part.PartLabel = "1) Miter Ends" + "\r\n" +
                             "2)" + crap;
           
            m_parts.Add(part);

            #endregion


            #region Glass

            decimal glassPerimeter = decimal.Zero;

            //Glass Panel
            part = new Part(-1);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 9;
            part.Source.MaterialDescription = "1.25 Insulated Glass";
            part.PartName = "PartName";
            part.PartLabel = "Phantom Part";
            part.Source.MaterialName = "1.25 IGU";
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - 3.625m) / 3.0m;
            part.PartLength = (m_subAssemblyHieght - 3.625m) / 3.0m;
            part.Source.UOM = 9;

           
            m_parts.Add(part);

            glassPerimeter = (part.PartLength * 2.0m) + (part.PartWidth * 2.0m);

            #endregion


            #region WeatherSeals


            // Glazing Seal

            part = new Part(1819, "Glazing Seal", this, 1, glassPerimeter * 9.0m);
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
           
            m_parts.Add(part);


            #endregion  


            #region Hardware


            #endregion

        }



        #endregion


    }
}