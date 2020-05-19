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

namespace FrameWorks.Makes.System2010
{

    public class FixedFcdSilHd : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal aluminumCrnBrk = 0.625m;
        const decimal stopReduceX2 = .96875m * 2.0m;
        const decimal glassReduce = .96875m;



        #endregion

        #region Constructor

        public FixedFcdSilHd()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FixedFcdSilHd";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            var parts = PartsHelper.TrackMaker(new FrameLS_OX(){SubAssemblyWidth=100.0m,SubAssemblyHieght=90.0m,
                                                                Parent=this.Parent},3,3,TrackConfiguration.Telescoping);

            foreach (Part p in parts)
	        {
                p.PartGroupType = "Track-Parts";
                m_parts.Add(p);
	        }
           
            #region FrameAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumFxdFcdSilHd
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4344, "AlumFxdFcdSilHd", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            //AlumGlsStpHz  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4341, "AlumGlsStpHz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            //GlsSpcrBrz 
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4317, "GlsSpcrBrz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Glass


            //Glass Panel

            part = new Part(3300);

            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (glassReduce * 2.0m);
            part.PartLength = m_subAssemblyHieght - (glassReduce * 2.0m);
            part.PartThick = 0.5625m;

            m_parts.Add(part);



            #endregion

            #region GlazingSeal


            for (int i = 0; i < 1; i++)
            {


                //decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                part = new Part(4314, "GlazDartEPDM", this, 1, m_subAssemblyWidth * 2.0m);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            for (int i = 0; i < 1; i++)
            {


                //decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //Glazing Seals
                part = new Part(4399, "GlazWedgEPDM", this, 1, m_subAssemblyWidth * 2.0m);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }



            #endregion

            #region AssyBrackets

            /////////////////////////////////////////////////////////////////////////

            //AglBrktAlum

            for (int i = 0; i < 8; i++)
            {
                part = new Part(3206, "AglBrktAlum", this, 1, aluminumCrnBrk);
                part.PartGroupType = "AssyBrackets";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Angle_1.5";

                m_parts.Add(part);

            }

            //PointSetScrew_1/4_20

            for (int i = 0; i < 32; i++)
            {
                part = new Part(1545, "PointSetScrew_1/4_20", this, 1, 0.0m);
                part.PartGroupType = "AssyBrackets";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "1/4_20x.25";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////

            #endregion



        }



        #endregion


    }
}