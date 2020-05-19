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

    public class FrameSwingPair : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal calkJoint = 0.125m;
        const decimal headReduct = 0.875m;
        const decimal botumRedut = .75m;
        const decimal bronzeCrnBrk = 0.64m;


        #endregion

        #region Constructor

        public FrameSwingPair()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3010-FrameSwingPair";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region Frame-Parts


            // JamBrzPair -->> 

            for (int i = 0; i < 2; i++)
            {
                decimal doorPanel = decimal.Zero;

                doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;

                part = new Part(4306, "JamBrzPair<", this, 1, m_subAssemblyHieght - calkJoint);
                part.PartGroupType = "Frame-Parts";
                decimal step = (doorPanel - 15.0m);
                step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(doorPanel) - 1));
                step = Math.Round(step, 4);
                //string msg = "";
                part.PartLabel = "1) MiterTop\r\n" +
                                 "2) [911.m]Cope Jamb Bottom->\r\n" +
                                 "3) Position 0rigin TOU @ ->" + (7.5m + 0.875m).ToString() + "\r\n" +
                                 "4) Hinge Backer Prep->[1982.m] "
                       + FrameWorks.Functions.HingeCount(doorPanel).ToString() + "@<" + step.ToString() + ">O.C.";

                m_parts.Add(part);


            }



            // HeadBrzPair ^^
            part = new Part(4306, "HeadBrzPair", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds\r\n" +
                             "2)[1987.m]Position 0rigin Shoot Strike";

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

            //////////////////////////////////////////////////////////////////////////////////////////

            // BRZ_ASTGL_COVER
            part = new Part(2972, "BRZ_ASTGL_COVER", this, 1, m_subAssemblyHieght - headReduct - botumRedut);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////

            // PVC ASTRAGAL
            part = new Part(1901, "PVC ASTRAGAL", this, 1, m_subAssemblyHieght - headReduct - botumRedut);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////

            // PairShootStrike 
            part = new Part(1986, "PairShootStrike", this, 2, 0.0m);
            part.PartGroupType = "HardWare-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            //////////////////////////////////////////////////////////////////////////////////////////



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