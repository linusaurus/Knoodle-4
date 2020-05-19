#region Copyright (c) 2011 WeaselWare Software
/************************************************************************************
'
' Copyright  2011 WeaselWare Software 
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
' Portions Copyright 2011 WeaselWare Software
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
using System.Runtime;

namespace FrameWorks.Makes.System3250
{


    public class RigletVertExt : SubAssemblyBase
    {

        #region Fields

        static int createID;
        Part part;
        string partleader;

        #endregion

        #region Constructor

        public RigletVertExt()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3250-RigletExt";
        }

        #endregion

        #region Error Handling

        System.Exception HardwareApplicationError(string description)
        {

            return new SystemException(description);
        }

        #endregion

        //Methods
        public override void Build()
        {

            partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region RigletExt


            // RigletVertExt
            part = new Part(2993, "RigletVertExt", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            // RigletVertExt
            part = new Part(2993, "RigletExt", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            #endregion

                #region Labor

            part = new LPart("MetalHours", this, 8.0m, 80.0m);
            m_parts.Add(part);
            //1 Receive: 1 Handle: 1 Cut: 1 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("FinishHours", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 SandLineGrain: 2 Finish


            part = new LPart("PatinaMat", this, this.m_perimeter, 0.41m);
            m_parts.Add(part);
            //$0.41 per inch

            #endregion


        }







    }
}