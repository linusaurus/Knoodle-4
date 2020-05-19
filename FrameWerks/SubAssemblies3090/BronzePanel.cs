#region Copyright (c) 2017 WeaselWare Software
/************************************************************************************
'
' Copyright  2017 WeaselWare Software 
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
' Portions Copyright 2017 WeaselWare Software
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

namespace FrameWorks.Makes.System3090
{

    public class BronzePanel : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal stopReduceX2 = 0.6250m * 2.0m;
        const decimal panelReduce = .96875m;
        const decimal gasketReduce = 1.09375m;


        #endregion

        #region Constructor

        public BronzePanel()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3090-BronzePanel";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();



            #region BrzPFrame


            //////////////////////////////////////////////////////////////////////////////

            // BrzPFrameVert
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5429, "BrzPFrameVert", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "BrzPFrame-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            // BrzPFrameHorz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5429, "BrzPFrameHorz", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "BrzPFrame-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopBrz

            //////////////////////////////////////////////////////////////////////////////

            //BrzGlsStpVt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5316, "BrzGlsStpVt", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////

            //BrzGlsStpHz  
            for (int i = 0; i < 2; i++)
            {
                part = new Part(5316, "BrzGlsStpHz", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region BronzePanelAssy

            //EXTIRA  

            part = new Part(5459);

            part.FunctionalName = "EXTIRA";
            part.PartGroupType = "BronzePanelAssy-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - panelReduce * 2.0m;
            part.PartLength = m_subAssemblyHieght - panelReduce * 2.0m;
            part.PartThick = 0.50m;

            m_parts.Add(part);


            //464Sheet

            for (int i = 0; i < 1; i++)
            {
                part = new Part(5467);

                part.FunctionalName = "464Sheet";
                part.PartGroupType = "BronzePanelAssy-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = m_subAssemblyWidth - (panelReduce * 2.0m);
                part.PartLength = m_subAssemblyHieght - (panelReduce * 2.0m);
                part.PartThick = 0.03196m;

                m_parts.Add(part);

            }

            //Poly_Back

            for (int i = 0; i < 1; i++)
            {
                part = new Part(4581);

                part.FunctionalName = "Poly_Back";
                part.PartGroupType = "BronzePanelAssy-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = m_subAssemblyWidth - (panelReduce * 2.0m);
                part.PartLength = m_subAssemblyHieght - (panelReduce * 2.0m);
                part.PartThick = 0.03196m;

                m_parts.Add(part);

            }


            #endregion

            #region GlazingSeal


            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //GlazePreSet
                part = new Part(4314, "GlazePreSet", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //GlazeWedgeSeals
                part = new Part(4399, "GlazeWedgeSeals", this, 1, peri);
                part.PartGroupType = "GlazingSeal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            #endregion

            #region AsemblHrdwr

            //////////////////////////////////////////////////////////////////////////////

            // BrzCnrBrkt
            //for (int i = 0; i < 8; i++)
            //{
                //part = new Part(4853, "BrzCnrBrkt", this, 1, bronzeCrnBrk);
                //part.PartGroupType = "AsemblHrdwr-Parts";
                //part.PartWidth = part.Source.Width;
                //part.PartThick = part.Source.Height;
                //part.PartLabel = "";

                //m_parts.Add(part);

            //}

            //////////////////////////////////////////////////////////////////////////////

            // SetSocScrew_1/4-20x1/4
            //for (int i = 0; i < 32; i++)
            //{
                //part = new Part(1545, "SetSocScrew_1/4-20x1/4", this, 1, 0.0m);
                //part.PartGroupType = "AsemblHrdwr-Parts";
                //part.PartWidth = part.Source.Width;
                //part.PartThick = part.Source.Height;
                //part.PartLabel = "";

                //m_parts.Add(part);

            //}

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

        }

        #endregion


    }
}