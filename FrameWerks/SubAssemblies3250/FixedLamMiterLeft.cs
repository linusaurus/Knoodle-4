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

namespace FrameWorks.Makes.System3250
{

    public class FixedLamMiterLeft : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public FixedLamMiterLeft()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3250-FixedLamMiterLeft";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;




            #region Frame


            // JambLeft <<--
            part = new Part(2940);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght;
            part.FunctionalName = "JambL";
            part.PartLabel = "";

            m_parts.Add(part);


            // JambRight -->>
            part = new Part(2940);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght;
            part.FunctionalName = "JambR";
            part.PartLabel = "";

            m_parts.Add(part);


            // HeadLeft ^^
            part = new Part(2940);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyDepth;
            part.FunctionalName = "HeadLeft";
            part.PartLabel = "VMiter_L_HMiter_R";

            m_parts.Add(part);


            // HeadRight ^^
            part = new Part(2940);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth;
            part.FunctionalName = "HeadRight";
            part.PartLabel = "VMiter_R_HMiter_L";

            m_parts.Add(part);


            // SillLeft ||
            part = new Part(2940);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyDepth;
            part.FunctionalName = "SillLeft";
            part.PartLabel = "VMiter_L_HMiter_R";

            m_parts.Add(part);


            // SillRight ||
            part = new Part(2940);
            part.Qnty = 1;
            part.PartGroupType = "Frame-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth;
            part.FunctionalName = "SillRight";
            part.PartLabel = "VMiter_R_HMiter_L";

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
            part.PartLength = m_subAssemblyDepth - (0.625m + 0.25m);
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
            part.PartLength = m_subAssemblyWidth - (0.625m + 0.25m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopTopRight";
            part.PartLabel = "";

            m_parts.Add(part);



            // StopBotLeft
            string crap;
            crap = Functions.StopWeepMachining(m_subAssemblyWidth - 0.0625m);
            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyDepth - (0.625m + 0.25m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopBotLeft";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + crap;

            m_parts.Add(part);



            // StopBotRight
            crap = Functions.StopWeepMachining(m_subAssemblyDepth - 0.0625m);
            part = new Part(809);
            part.Qnty = 1;
            part.PartGroupType = "Stop-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth - (0.625m + 0.25m);
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.FunctionalName = "StopBotRight";
            part.PartLabel = "1)MiterEnds" + "\r\n" +
                             "2)" + crap;

            m_parts.Add(part);



            #endregion

            #region FillerBrz


            // FillerBrzLeft <<--
            part = new Part(2664);
            part.Qnty = 1;
            part.PartGroupType = "FillerBrz-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght - (0.625m + 0.25m);
            part.FunctionalName = "FillerBrzL";
            part.PartLabel = "";

            m_parts.Add(part);


            // FillerBrzRight -->>
            part = new Part(2664);
            part.Qnty = 1;
            part.PartGroupType = "FillerBrz-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyHieght - (0.625m + 0.25m);
            part.FunctionalName = "FillerBrzR";
            part.PartLabel = "";

            m_parts.Add(part);


            // FillerBrzLeft ^^
            part = new Part(2664);
            part.Qnty = 1;
            part.PartGroupType = "FillerBrz-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyDepth - (0.625m + 0.25m);
            part.FunctionalName = "FillerBrzHeadLeft";
            part.PartLabel = "VMiter_L_HMiter_R";

            m_parts.Add(part);


            // FillerBrzRight ^^
            part = new Part(2664);
            part.Qnty = 1;
            part.PartGroupType = "FillerBrz-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth - (0.625m + 0.25m);
            part.FunctionalName = "FillerBrzHeadRight";
            part.PartLabel = "VMiter_R_HMiter_L";

            m_parts.Add(part);


            // FillerBrzLeft ||
            part = new Part(2664);
            part.Qnty = 1;
            part.PartGroupType = "FillerBrz-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyDepth - (0.625m + 0.25m);
            part.FunctionalName = "FillerBrzSillLeft";
            part.PartLabel = "VMiter_L_HMiter_R";

            m_parts.Add(part);


            // FillerBrzRight ||
            part = new Part(2664);
            part.Qnty = 1;
            part.PartGroupType = "FillerBrz-Parts";
            part.ContainerAssembly = this;
            part.PartLength = m_subAssemblyWidth - (0.625m + 0.25m);
            part.FunctionalName = "FillerBrzSillRight";
            part.PartLabel = "VMiter_R_HMiter_L";

            m_parts.Add(part);


            #endregion

            #region Glass


            //LAM_CornerWR
            part = new Part(3067);
            part.FunctionalName = "LAM_MiterHLeft";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "MiterHeightLeft";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - (0.9375m + 0.5m);
            part.PartLength = m_subAssemblyHieght - (0.9375m * 2.0m);

            m_parts.Add(part);


            //LAM_CornerDL
            part = new Part(3067);
            part.FunctionalName = "LAM_MiterHRight";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.PartName = "PartName";
            part.PartLabel = "MiterHeightRight";
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyDepth - (0.9375m + 0.5m);
            part.PartLength = m_subAssemblyHieght - (0.9375m * 2.0m);

            m_parts.Add(part);


            #endregion

            #region Seal/Weatherstripping


            decimal peri = Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyDepth);
            peri += Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            peri -= (m_subAssemblyHieght * 2.0m);

            //Glazing Seals
            part = new Part(2772, "Glazing Seal", this, 2, peri);
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


        }



        #endregion


    }
}