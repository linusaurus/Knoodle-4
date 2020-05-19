#region Copyright (c) 2015 WeaselWare Software
/************************************************************************************
'
' Copyright  2015 WeaselWare Software 
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
' Portions Copyright 2015 WeaselWare Software
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

namespace FrameWorks.Makes.System3340
{

    public class ScreenFrameBrz : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal frameRed2X = 1.3723m * 2.0m;
        



        #endregion

        #region Constructor

        public ScreenFrameBrz()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3340-ScreenFrameBrz";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region ScreenFrmBrz


            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrm_4429_Hz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4429, "ScrnFrm_4429_Hz", this, 1, m_subAssemblyWidth - frameRed2X);
                part.PartGroupType = "ScreenFrmBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // ScrnFrm_4429_Vt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4429, "ScrnFrm_4429_Vt", this, 1, m_subAssemblyHieght - frameRed2X);
                part.PartGroupType = "ScreenFrmBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion


        }



        #endregion


    }
}