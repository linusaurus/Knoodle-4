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
    
    public class FixedIGMiterRight : SubAssemblyBase
    {

        #region Fields



        #endregion

        #region Constructor

        public FixedIGMiterRight()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys3000-FixedIGMiterRight";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
            



            #region Frame



            // JambRight -->>
            part = new Part(804);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght;
            part.FunctionalName = "JambR";
            part.PartLabel = "";
            
            m_parts.Add(part);




            // JambLeft <<--
            part = new Part(804);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght;
            part.FunctionalName = "JambL";
            part.PartLabel = "";
            
            m_parts.Add(part);




            // HeadLeft ^^
            part = new Part(804);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth;
            part.FunctionalName = "HeadLeft";
            part.PartLabel = "VMiter_L_HMiter_R";
            
            m_parts.Add(part);




            // HeadRight ^^
            part = new Part(804);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyDepth;
            part.FunctionalName = "HeadRight";
            part.PartLabel = "VMiter_R_HMiter_L";
            
            m_parts.Add(part);




            // SillLeft ||
            part = new Part(804);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth;
            part.FunctionalName = "SillLeft";
            part.PartLabel = "VMiter_L_HMiter_R";
            
            m_parts.Add(part);




            // SillRight ||
            part = new Part(804);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyDepth;
            part.FunctionalName = "SillRight";
            part.PartLabel = "VMiter_R_HMiter_L";
            
            m_parts.Add(part);




            // ExtCornerCover 
            part = new Part(2799);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght - 1.375m * 2.0m;
            part.FunctionalName = "ExtCornerCover";
            part.PartLabel = "";
            
            m_parts.Add(part);




            // IntCornerCover 
            part = new Part(2798);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght - 1.375m * 2.0m;
            part.FunctionalName = "IntCornerCover";
            part.PartLabel = "";
            
            m_parts.Add(part);




            #endregion

            #region Stop


            // StopRight

            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght - (0.625m * 2.0m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopRight";
            part.PartLabel = "";
            
            m_parts.Add(part);



            // StopLeft

            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght - (0.625m * 2.0m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopLeft";
            part.PartLabel = "";
            
            m_parts.Add(part);



            // StopTopLeft

            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth - 0.625m;
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopTopLeft";
            part.PartLabel = "";
            
            m_parts.Add(part);



            // StopTopRight

            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyDepth - 0.625m;
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopTopRight";
            part.PartLabel = "";
            
            m_parts.Add(part);



            // StopBotLeft

            string crap;
            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyWidth - 0.0625m);
            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth - 0.625m;
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopBotLeft";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + crap;
            
            m_parts.Add(part);



            // StopBotRight


            crap = FrameWorks.Functions.StopWeepMachining(m_subAssemblyDepth - 0.0625m);
            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyDepth - 0.625m;
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopBotRight";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + crap;
            
            m_parts.Add(part);



            #endregion

            #region Glass


            //GlassPanelL

            part = new Part(2828);
            part.FunctionalName = "GlassPanelL";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (0.9375m + 1.625m);
            part.PartLength = m_subAssemblyHieght - (0.9375m * 2.0m);
            
            m_parts.Add(part);



            //GlassPanelR

            part = new Part(2828);
            part.FunctionalName = "GlassPanelR";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyDepth - (0.9375m + 1.625m);
            part.PartLength = m_subAssemblyHieght - (0.9375m * 2.0m);
            
            m_parts.Add(part);




            #endregion

            #region Seal/Weatherstripping


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyDepth);
            peri += FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            peri -= (m_subAssemblyHieght * 2.0m);

            //Glazing Seals
            part = new Part(1819, "Glazing Seal", this, 2, peri);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region Hardware


            // Braces
            part = new Part(1117);
            part.Qnty = 12;
            part.PartGroupType = "Hardware-Parts";
            part.ContainerAssembly = this;
            part.FunctionalName = "Braces";
            part.PartLabel = "";
            
            m_parts.Add(part);





            #endregion

                #region Labor


            part = new LPart("Design", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //Collect Information on Sizes: Measure: Provide Information for Approval: Order: Supervision

            part = new LPart("Draft", this, 3.0m, 80.0m);
            m_parts.Add(part);
            //Typical Drawings

            part = new LPart("MetalHours", this, 12.0m, 80.0m);
            m_parts.Add(part);
            //1 Recieve: 1 Handle: 1 CutSash: 1 CutGlassStop: 1.5 Machine: 1.5 Hardware Prep: 1 Mount Hardware: 4 Weld:

            part = new LPart("Finish", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 Sand Linegrain: 2 Finish:

            part = new LPart("Glazing", this, (this.Area * .10m) + 4.5m, 80.0m);
            m_parts.Add(part);
            //0.5 Order: 0.5 Recieve: 1.0 Inspect/Reject: 0.5 Store/Handle: 0.5 SetGlass/Shim&Calk: 0.5 Set GlassStop: 0.5 GlazingSeals

            part = new LPart("Prehang", this, (this.Area * .10m) + 3.0m, 80.0m);
            m_parts.Add(part);
            //2 FitSash into Frame: 1 Mount Weather Strips/Seals

            part = new LPart("Stage", this, 1.0m, 80.0m);
            m_parts.Add(part);
            //1 Stage

            part = new LPart("Load", this, 1.0m, 80.0m);
            m_parts.Add(part);
            //1 Load


            #endregion


        }



        #endregion


    }
}