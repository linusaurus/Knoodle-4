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

namespace FrameWorks.Makes.System3530
{

    public class FrameSwingFIXED : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal gasketReduce = .9375m;

        //static int createID;

        #endregion

        #region Constructor

        public FrameSwingFIXED()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3530-FrameSwingFIXED";
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
            decimal doorPanel = decimal.Zero;

            doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;
            part = new Part(3948, "JamBrzR_|>", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterTop";

            m_parts.Add(part);


            // JamBrzR -->> 
            part = new Part(3948, "JamBrzR_|>", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterTop";

            m_parts.Add(part);


            // HeadBrz ^^
            part = new Part(3948, "HeadBrz", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);


            #endregion

            #region Seal/Weatherstripping




            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //FrameSeal
                part = new Part(1005, "FrameSeal", this, 1, peri - m_subAssemblyWidth - 4.0m * gasketReduce);
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