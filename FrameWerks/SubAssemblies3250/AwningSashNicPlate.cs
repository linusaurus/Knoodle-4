#region Copyright (c) 2010 WeaselWare Software
/************************************************************************************
'
' Copyright  2010 WeaselWare Software 
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
' Portions Copyright 2010 WeaselWare Software
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


namespace FrameWorks.System3250
{
    
    public class AwningSashNicPlate : SubAssemblyBase
    {

        #region Fields

        static int createID;


        #endregion

        #region Constructor

        public AwningSashNicPlate()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3250-WindowFrameAwning";
        }

        public AwningSashNicPlate(decimal w, decimal h, decimal d)
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3250-AwningSashNicPlate";
            this.m_subAssemblyWidth = w;
            this.m_subAssemblyHieght = h;
            this.m_subAssemblyDepth = d;
        }
        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {
            Part part;
            



            #region Sash


            // StileL <<--
            part = new Part(2951);
            part.Qnty = 1;
            part.PartGroupType = "Sash-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght;
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StileL";
            part.PartLabel = "Mach Hinge-";// + Functions.S3000AwningHinge(m_subAssemblyHieght).ToString();
            
            m_parts.Add(part);


            // StileR -->>
            part = new Part(2951);
            part.Qnty = 1;
            part.PartGroupType = "Sash-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght;
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StileR";
            part.PartLabel = "Mach Hinge-";// + Functions.S3000AwningHinge(m_subAssemblyHieght).ToString();
            
            m_parts.Add(part);


            // RailT ^^
            part = new Part(2951);
            part.Qnty = 1;
            part.PartGroupType = "Sash-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth;
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "RailT";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // RailB ||
            part = new Part(2951);
            part.Qnty = 1;
            part.PartGroupType = "Sash-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth;
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "RailB";
            part.PartLabel = "";
            
            m_parts.Add(part);



            #endregion

            #region Filler

            //Top Filler
            part = new Part(2975);
            part.Qnty = 1;
            part.FunctionalName = "Top Filler";
            part.PartGroupType = "Filler-Parts";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartThick = .75m;
            part.PartWidth = 1.814m;
            part.PartLength = m_subAssemblyWidth;
            
            m_parts.Add(part);


            //Bottom Filler
            part = new Part(2975);
            part.Qnty = 1;
            part.FunctionalName = "Bottom Filler";
            part.PartGroupType = "Filler-Parts";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartThick = .75m;
            part.PartWidth = 1.814m;
            part.PartLength = m_subAssemblyWidth;
            
            m_parts.Add(part);


            //Right Filler
            part = new Part(2975);
            part.Qnty = 1;
            part.FunctionalName = "Right Filler";
            part.PartGroupType = "Filler-Parts";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartThick = .75m;
            part.PartWidth = 1.814m;
            part.PartLength = m_subAssemblyHieght;
            
            m_parts.Add(part);


            //Left Filler
            part = new Part(2975);
            part.Qnty = 1;
            part.FunctionalName = "Left Filler";
            part.PartGroupType = "Filler-Parts";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartThick = .75m;
            part.PartWidth = 1.814m;
            part.PartLength = m_subAssemblyHieght;
            
            m_parts.Add(part);


            #endregion

            #region Glass

            //Glass Panel

            part = new Part(3013);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (1.625m * 2.0m);
            part.PartLength = m_subAssemblyHieght - (1.625m * 2.0m);
            
            m_parts.Add(part);

            #endregion

            #region Stops
            // StopT-Front
            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth - (1.3125m * 2.0m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopT-Front";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);

            // StopT-Rear
            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth - (1.3125m * 2.0m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopT-Rear";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);

            // StopB-Rear
            part = new Part(809);
            part.Qnty = 1;
            part.FunctionalName = "StopB-Rear";
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth - (1.3125m + 1.3125m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);

            // StopB-Front
            string crap;
            crap = Functions.StopWeepMachining(m_subAssemblyWidth - 2.0m * .625m);
            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth - (1.3125m + 1.3125m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopB-Front";
            part.PartLabel = "1) Miter Ends" + "\r\n" +
                             "2)" + crap;
            
            m_parts.Add(part);

            // StopL-Rear
            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght - (1.3125m + 1.3125m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopL-Rear";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);

            // StopL-Front
            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght - (1.3125m + 1.3125m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopL-Front";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);

            // StopR-Rear
            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght - (1.3125m + 1.3125m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopR-Rear";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);

            // StopR-Front
            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght - (1.3125m + 1.3125m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopR-Front";
            part.PartLabel = "Miter Ends";
            
            m_parts.Add(part);


            #endregion

            #region HardWare Logic


            // Assembly Braces
            part = new Part(1117, "Assembly Braces", this, 8, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            //LockHoppe  
            FrameWorks.Makes.System3000.HoppeCasement25mm hoppe = new FrameWorks.Makes.System3000.HoppeCasement25mm(m_subAssemblyWidth, this);
            foreach (Part innerpart in hoppe.Parts)
            {
               //inner
                this.Parts.Add(innerpart);

            }



            #endregion

            #region Seals


            //Sash Weatherstip

            part = new Part(2274);
            part.Qnty = 1;
            part.FunctionalName = "Sash Weatherstip";
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
            part.ContainerAssembly = this;
            part.PartLength = (m_subAssemblyHieght + m_subAssemblyWidth) * 2.0m;
            
            m_parts.Add(part);


            // Glazing Seal

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyWidth - (1.3125m * 2.0m), m_subAssemblyHieght - (1.3125m * 2.0m));
            part = new Part(2772, "Glazing Seal", this, 1, peri *= 2.0m);
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

                #region Labor


            part = new LPart("Design", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //Measure: Collect Information on Sizes from Contractor: Provide Information for Approval: Samples Correspondence: Ordering: Supervision

            part = new LPart("Draft", this, 3.0m, 80.0m);
            m_parts.Add(part);
            //Typical Drawings: Supervision

            part = new LPart("MetalHours", this, 10.0m, 80.0m);
            m_parts.Add(part);
            //1 Recieve: 1 Handle: 1 CutFrame: 1 CutStop: 1.5 Machine: 1.5 HardwarePrep: 1 MountHardware: 2 Weld: 

            part = new LPart("FinishHours", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 LinegrainSand: 2 Finish

            part = new LPart("PatinaMat", this, this.m_perimeter, 0.41m);
            m_parts.Add(part);
            //$0.41 per inch

            part = new LPart("GlazingHours", this, (this.Area * 0.1m) + 4.5m, 80.0m);
            m_parts.Add(part);
            //.5 Recieve: 1.0 InspectReject: .5 StoreHandle: 1.0 GlazeShimCalk: .5 SetGlassStop: 05 InsertGasket 

            part = new LPart("Prehang", this, (this.Area * 0.1m) + 3.0m, 80.0m);
            m_parts.Add(part);
            //2 Fit Sash into Frame: 1 Mount Weather StripSeals

            part = new LPart("Stage", this, 1.0m, 80.0m);
            m_parts.Add(part);
            //1 Stage

            part = new LPart("Load", this, 1.0m, 80.0m);
            m_parts.Add(part);
            //1 Load

            #endregion


        #endregion

        }



    }
}