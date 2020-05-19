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

namespace FrameWorks.Makes.System3010
{

    public class FrameSwingFX : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal bronzeCrnBrk = 0.64m;
        const decimal calkJoint = 0.125m;
        const decimal NFtab = 3.125m;


        #endregion

        #region Constructor

        public FrameSwingFX()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-FrameSwingFX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region Frame-Parts


            // JamBrzL -->> 
            part = new Part(4306, "JamBrzL|>", this, 1, m_subAssemblyHieght - calkJoint);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterTop";

            m_parts.Add(part);



            // JamBrzR -->>  
            part = new Part(4306, "JamBrzR|>", this, 1, m_subAssemblyHieght - calkJoint);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterTop";

            m_parts.Add(part);


            // HeadBrz ^^
            part = new Part(4306, "HeadBrz", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);


            #endregion

            #region AsemblHrdwr

            //////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4265, "BrzCnrBrkt", this, 1, bronzeCrnBrk);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            // SetSocScrew_1/4-20x1/4
            for (int i = 0; i < 16; i++)
            {
                part = new Part(1545, "SetSocScrew_1/4-20x1/4", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare



            // FIXED_STAND
            part = new Part(911, "FIXED_STAND", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // TABS

            part = new Part(3649, "TABS", this, Convert.ToInt32(this.Perimeter / 16.0m + 1.0m), NFtab);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "CUT_LENGTH_3_INCHES";

            m_parts.Add(part);




            #endregion

            #region Seal/Weatherstripping




            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - calkJoint, m_subAssemblyWidth);

                //FrameSealKfolD
                part = new Part(2274, "FrameSealKfolD", this, 1, peri - m_subAssemblyWidth - 4.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////





            #endregion










        }



        #endregion


    }
}