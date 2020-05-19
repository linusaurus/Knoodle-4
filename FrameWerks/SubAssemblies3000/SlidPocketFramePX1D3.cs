#region Copyright (c) 2007 WeaselWare Software
/************************************************************************************
'
' Copyright  2007 WeaselWare Software 
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
' Portions Copyright 2007 WeaselWare Software
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

namespace FrameWorks.Makes.System3000
{
   
   public class SlidPocketFramePX1D3 : SubAssemblyBase
   {


      #region Fields

      static int createID;

      #endregion

      #region Constructor

      public SlidPocketFramePX1D3()
      {
         m_subAssemblyID = Guid.NewGuid();
         this.ModelID = "SlidPocketFramePX1D3";
      }

      #endregion

      #region Methods

      //Bill of Material
      public override void Build()
      {

         Part part;
         string partleader =  this.Parent.UnitID + "." + this.CreateID.ToString();
         FrameWorks.Makes.System3000.Helper.SliderOXXHelper helper = new FrameWorks.Makes.System3000.Helper.SliderOXXHelper(3, 1, m_subAssemblyWidth);

         #region Frame

         // Split Jamb
         part = new Part(810, "Split Jamb", this, 1, m_subAssemblyHieght * 4.0m);
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Split Head
         part = new Part(810, "Split Head", this,  1, helper.TopTrackLength );
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Bottom Track
         part = new Part(215, "Bottom Track", this, 1, helper.FloorTrackLength);
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Top Track
         part = new Part(1416, "Top Track", this, 1, helper.FloorTrackLength);
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Head Hanger
         part = new Part(2096, "Head Hanger", this, 1, helper.FloorTrackLength * 2.0m);
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);
 



         #endregion

         #region Labor

         part = new LPart("MetalHours",this, 9.0m, 80.0m);
         m_parts.Add(part);
         //1 Receive: 1 Handle: 1.5 Cut: 1.5 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

         part = new LPart("FinishHours",this, 4.0m, 80.0m);
         m_parts.Add(part);
          //2 SandLineGrain: 2 Finish




         #endregion


      }

      #endregion

   }
}  

