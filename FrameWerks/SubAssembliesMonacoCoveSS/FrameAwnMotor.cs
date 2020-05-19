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

    public class FrameAwnMotor : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal frameRedVertX2 = 1.25m;
        const decimal frameStpRedX2 = 3.5m;
        const decimal gasketReduce = 1.375m;



        static int createID;

        #endregion

        #region Constructor

        public FrameAwnMotor()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "MonacoCoveSS-FrameAwnMotor";
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

            // MotorActuator200mm
            part = new Part(3765, "MotorActuator200mm", this, 1, 0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

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