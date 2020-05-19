#region Copyright (c) 2012 WeaselWare Software
/************************************************************************************
'
' Copyright  2012 WeaselWare Software 
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
' Portions Copyright 2012 WeaselWare Software
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
using System.Diagnostics;

namespace FrameWorks.Makes.TiburAlum
{

    public class Frame_5_AlumPivt_Pair

        : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal centerReduce = 0.1385125m;
        const decimal frameReduce = 0.672564m;
        const decimal glassReduce = 0.500001m;



        static int createID;

        #endregion

        #region Constructor

        public Frame_5_AlumPivt_Pair

()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "TiburAlum-Frame_5_AlumPivt_Pair";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region Frame-Parts


            // JambL2 <<--
            part = new Part(3618, "JambR2", this, 1, m_subAssemblyHieght - frameReduce);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);



            // JambR2 -->> 
            part = new Part(3618, "JambR2", this, 1, m_subAssemblyHieght - frameReduce);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);




            // Head2 ^^
            part = new Part(3618, "Head2", this, 1, m_subAssemblyWidth - frameReduce * 2.0m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds\r\n" +
                             "2)[1987.m]Position 0rigin Shoot Strike";

            m_parts.Add(part);




            // JambL4 <<--
            part = new Part(3620, "JambL4", this, 1, m_subAssemblyHieght - frameReduce);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterTop";

            m_parts.Add(part);




            // JambR4 -->>
            part = new Part(3620, "JambR4", this, 1, m_subAssemblyHieght - frameReduce);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterTop";

            m_parts.Add(part);




            // Head4 ^^
            part = new Part(3620, "Head4", this, 1, m_subAssemblyWidth - frameReduce * 2.0m);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds";

            m_parts.Add(part);



            #endregion


            #region HardWare



            // ShootStrikeDrPr 
            part = new Part(1985, "ShootStrikeDrPr", this, 2, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);





            #endregion


            #region Seal/Weatherstripping


            //Sash Edge Seal
            part = new Part(2274, "Edge Seal", this, 1, m_subAssemblyHieght * 2 + m_subAssemblyWidth);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            #endregion






        }



        #endregion


    }
}