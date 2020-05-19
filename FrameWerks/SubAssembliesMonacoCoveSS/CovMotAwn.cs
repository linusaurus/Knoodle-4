#region Copyright (c) 2013 WeaselWare Software
/************************************************************************************
'
' Copyright  2013 WeaselWare Software 
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
' Portions Copyright 2013 WeaselWare Software
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

    public class CovMotAwn : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal frameRedVertX2 = 1.25m;
        const decimal gasketReduce = 1.375m;



        static int createID;

        #endregion

        #region Constructor

        public CovMotAwn()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "MonacoCoveSS-CovMotAwn";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region MotorCoverAwning


            ///////////////////////////////////////////////////////////////////////////////

            // CoverMotor316SSHorz
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4188, "CoverMotor316SSHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "MotorCoverAwning-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////


            #endregion

            #region CoverBracket


            ///////////////////////////////////////////////////////////////////////////////

            // BrketMtrCvr316SS
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4210, "BrketMtrCvr316SS", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "CoverBracket-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////


            #endregion

        }



        #endregion


    }
}