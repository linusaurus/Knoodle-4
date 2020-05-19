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

    public class FixedIG : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal stopReduceX2 = 1.25m;
        const decimal glassReduce = .9375m;
        const decimal gasketReduce = .922m;

        //static int createID;

        #endregion

        #region Constructor

        public FixedIG()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3530-FixedIG";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region FrameBrz


            //////////////////////////////////////////////////////////////////////////////

            // BrzFixedIGVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4324, "BrzFixedIGVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            // BrzFixedIGHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4324, "BrzFixedIGHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopBrz




            //////////////////////////////////////////////////////////////////////////////

            // BrzGlassStopVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3892, "BrzGlassStopVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            //  
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3892, "BrzGlassStopTop", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }



            // BrzGlassStopBot
            for (int i = 0; i < 1; i++)
            {


                string crap;
                crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - stopReduceX2);
                part = new Part(3892, "BrzGlassStopBot", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "GlassStop-Parts";
                part.PartLabel = "1)MiterEnds" + "\r\n" +
                                 "2)" + crap;

                m_parts.Add(part);


            }








            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Glass

          
            //Glass Panel

            part = new Part(4420);

            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce * 2.0m);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 1.0m;

            m_parts.Add(part);



            #endregion

            #region GlazingSeal


            for (int i = 0; i < 2; i++)
            {


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce , m_subAssemblyWidth - gasketReduce);

                //GlazeWedgeSeals
                part = new Part(3904, "GlazeWedgeSeals", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion

            #region Hardware


            #endregion



        }



        #endregion


    }
}