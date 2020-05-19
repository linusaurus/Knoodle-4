#region Copyright (c) 2014 WeaselWare Software
/************************************************************************************
'
' Copyright  2014 WeaselWare Software 
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
' Portions Copyright 2014 WeaselWare Software
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

namespace FrameWorks.Makes.MonacoCoveSS
{

    public class FrameCaseRHR : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal frameRedVertX2 = 1.25m;
        const decimal frameStpRedX2 = 3.5m;
        const decimal gasketReduce = 1.375m;



        static int createID;

        #endregion

        #region Constructor

        public FrameCaseRHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "MonacoCoveSS-FrameCaseRHR";
            this.WrkOrder = new Workorder(this, 1);
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region Frame316SS

            ///////////////////////////////////////////////////////////////////////////////

            // Ext316SSVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4166, "Ext316SSVert", this, 1, m_subAssemblyHieght - frameRedVertX2);
                part.PartGroupType = "Frame316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // Ext316SSHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4166, "Ext316SSHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Frame316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // Int316SSVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4167, "Int316SSVert", this, 1, m_subAssemblyHieght - frameStpRedX2);
                part.PartGroupType = "Frame316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // Int316SSHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4167, "Int316SSHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Frame316SS-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////


            #endregion

            #region FrameEXTIRACore

            ///////////////////////////////////////////////////////////////////////////////

            // ExtiraVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4198, "ExtiraVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "FrameEXTIRACore-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////////////////////////////////

            // ExtiraHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4198, "ExtiraHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "FrameEXTIRACore-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Hardware-Parts

            // Operator Casement

            part = new Part(FrameWorks.Functions.OperatorSeries23(SubAssemblyWidth, "LH"), "OperatorLH", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // FoldingHandle
            part = new Part(318, "FoldingHandle", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // Gasket23

            part = new Part(2652, "Gasket23", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);





            int hardwarecount = 1;
            if (m_subAssemblyHieght < 48.0m)
            {
                hardwarecount = 1;
            }
            else
            {
                hardwarecount = 2;

            }


            // Lock
            part = new Part(1709, "Lock", this, hardwarecount, 0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            //Get the size of the tiebar partNo--
            decimal tieBarLength = FrameWorks.Functions.S2000TieBar(m_subAssemblyHieght);

            //check is sash even requires a tiebar
            if (tieBarLength != 0)
            {
                // Tie Bars
                part = new Part(3625, "Tie Bars", this, 1, tieBarLength);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";

                m_parts.Add(part);
            }


            #endregion

            #region Seal/Weatherstripping


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //FrameSeal
                part = new Part(911, "FrameSeal", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

        }


        #endregion

    }


}