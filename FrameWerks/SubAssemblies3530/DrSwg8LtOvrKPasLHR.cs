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
using FrameWorks.Makes.System3000;


namespace FrameWorks.Makes.System3530
{

    public class DrSwg8LtOvrKPasLHR : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal BrzPanelSwgDr = 6.1875m;
        const decimal muntBzPnlRed = 6.56249974m;
        const decimal dlrnPnlRed = 6.42187474m;
        const decimal muntStileRedX2 = 1.53062108m;
        const decimal muntStileRed = 0.76531054m;
        const decimal dlrnStlRed = 0.7255m;
        const decimal muntJuncRed = .15533011m;
        const decimal glassBzPnlRed = 7.06249974m;
        const decimal glassMuntRedX2 = .375m;
        const decimal glassDrGap = 0.875m;
        const decimal epdmReduce = 0.8125m;
        const decimal edgeSealAdd = .28125m;
        const decimal delrinThick = .09375m;
        const decimal hdpExtnd = 0.15625m;
        const decimal hdpeReduce = .1250m;
        const decimal stopReduceX2 = 1.125m;
        const decimal stopReduce = 0.5625m;
        const decimal brzLowproStep = 0.81252409m;
        const decimal muntStepRed = 0.250m;
        const decimal brzLowPanRed = 6.31247563m;


        //



        //static int createID;
        //Part part;
        //string partleader;

        #endregion

        #region Constructor

        public DrSwg8LtOvrKPasLHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3530-DrSwg8LtOvrKPasLHR";
        }

        #endregion

        #region Methods


        //Bill of Material
        public override void Build()
        {

            Part part;

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;


            #region Brz385_LowP


            ////////////////////////////////////////////////////////////////////////////////////

            // StileLeft
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4072, "StileLeft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Brz385_LowP";
                part.PartLabel = "1) Miter_Ends";
                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////


            // StileRight
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4072, "StileRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Brz385_LowP";
                part.PartLabel = "1) Miter_Ends";

                m_parts.Add(part);

            }


            //////////////////////////////////////////////////////////////////////////////////

            // RailTop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4072, "RailTop", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Brz385_LowP";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////


            // RailBot
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4072, "RailBot", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Brz385_LowP";
                part.PartLabel = "1) Miter_Ends ";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Brz385_HrdwrBump


            ////////////////////////////////////////////////////////////////////////////////////

            // VertBump
            for (int i = 0; i < 1; i++)
            {
                part = new Part(4072, "VertBump", this, 1, (m_subAssemblyHieght - brzLowPanRed - 2 * brzLowproStep - 5 * muntStepRed) / 5);
                part.PartGroupType = "Brz385_HrdwrBump";
                part.PartLabel = "1) Miter_Ends";
                m_parts.Add(part);

            }




            // HorzBump
            for (int i = 0; i < 2; i++)
            {

                part = new Part(4072, "HorzBump", this, 1, 2.96623231m);
                part.PartGroupType = "Brz385_HrdwrBump";
                part.PartLabel = "1) Miter_<-Out->In";

                m_parts.Add(part);

            }






            ////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopBrz


            // BrzGlsStpUpVert
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3892, "BrzGlsStpUpVert", this, 1, m_subAssemblyHieght - stopReduce - 44.17685m);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpHDWbmp
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3892, "BrzGlsStpHDWbmp", this, 1, 16.211875m);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////// 

            // BrzGlsStpBmpOUT
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3892, "BrzGlsStpBmpOUT", this, 1, 2.306644m);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "Inside<Outside^Miters";

                m_parts.Add(part);

            }


            /////////////////////////////////////////////////////////////////////////////

            // BrzGlsStpLowVert
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3892, "BrzGlsStpLowVert", this, 1, 26.902451m);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }



            //////////////////////////////////////////////////////////////////////////////



            // BrzGlsStpVert
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3892, "BrzGlassStopVert", this, 1, m_subAssemblyHieght - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////


            // BrzGlassStopTop
            for (int i = 0; i < 1; i++)
            {
                part = new Part(3892, "BrzGlassStopTop", this, 1, m_subAssemblyWidth - stopReduceX2);
                part.PartGroupType = "StopBrz-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////

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

            #region HDPE



            // HDPELockEdge
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4037, "HDPELockEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);

            }



            // HDPEHingEdge
            for (int i = 0; i < 1; i++)
            {

                part = new Part(4038, "HDPEHingEdge", this, 1, m_subAssemblyHieght + hdpExtnd);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);

            }



            // HDPETop
            for (int i = 0; i < 1; i++)
            {


                part = new Part(4037, "HDPETop", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd - hdpeReduce);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "";

                m_parts.Add(part);

            }


            // HDPEBot
            for (int i = 0; i < 1; i++)
            {


                part = new Part(4039, "HDPEBot", this, 1, m_subAssemblyWidth - hdpeReduce);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "";

                m_parts.Add(part);

            }



            #endregion

            #region PanelBrz


            // ExtiraPanel ^^
            part = new Part(4043);
            part.FunctionalName = "ExtiraPanel";
            part.PartGroupType = "PanelBrz";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = (m_subAssemblyWidth - 2 * glassDrGap);
            part.PartLength = (BrzPanelSwgDr);

            m_parts.Add(part);


            /////////////////////////////////////////////////////////////////////////////////////////////////


            // BrassC464
            for (int i = 0; i < 2; i++)
            {

                // BrassC464
                part = new Part(4042);
                part.FunctionalName = "BrassC464";
                part.PartGroupType = "PanelBrz";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - 2 * glassDrGap);
                part.PartLength = (BrzPanelSwgDr);

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Muntin


            ///////////////////////////////////////////////////////////////////////////////////////

            // BrzMntVrt8Lt
            for (int i = 0; i < 8; i++)
            {
                part = new Part(3893, "BrzMntVrt8Lt", this, 1, (m_subAssemblyHieght - muntBzPnlRed - muntStileRed - 3.0m * muntJuncRed) / 4.0m);
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////

            // DlrnDivVrt8Lt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(911, "DlrnDivVrt8Lt", this, 1, (m_subAssemblyHieght - dlrnPnlRed - dlrnStlRed - 3.0m * delrinThick) / 4.0m);
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////

            // BrzMntHrz8Lt
            for (int i = 0; i < 8; i++)
            {
                part = new Part(3893, "BrzMntHrz8Lt", this, 1, m_subAssemblyWidth - muntStileRedX2);
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////

            // DlrnDivHrz8Lt
            for (int i = 0; i < 4; i++)
            {
                part = new Part(911, "DlrnDivHrz8Lt", this, 1, m_subAssemblyWidth - dlrnStlRed * 2.0m);
                part.PartGroupType = "Muntin-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            ///////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Glass


            // Eight Glass Panels
            for (int i = 0; i < 7; i++)
            {

                //Glass8Lite5Lower
                part = new Part(4420);
                part.FunctionalName = "Glass8Lite7of";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = ((m_subAssemblyWidth - 2.0m * glassDrGap - glassMuntRedX2) / 2);
                part.PartLength = ((m_subAssemblyHieght - glassBzPnlRed - glassDrGap - 4.0m * glassMuntRedX2) / 4);
                part.PartThick = 1.0m;

                m_parts.Add(part);


            }

            ////////////////////////////////////////////////////////////////////////////////////////

           
            // Glass8Lite1HDWbump
            for (int i = 0; i < 1; i++)
            {

                //Glass8Lite
                part = new Part(4420);
                part.FunctionalName = "Glass8Lite1HDWbump";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (13.17387963m);
                part.PartLength = ((m_subAssemblyHieght - glassBzPnlRed - glassDrGap - 4.0m * glassMuntRedX2) / 4);
                part.PartThick = 1.0m;
                part.PartLabel = "Glass8Lite1HDWbump";

                m_parts.Add(part);


            }

            ////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region HardWare Logic

            // Hinges
            part = new Part(3685, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = ".25_RAD_Corner";

            m_parts.Add(part);

            ////////////////////////////////////////////////////////////////////////////////////////////////////

            //MultipointPassive
            FrameWorks.Makes.Hardware.Amesbury.Premiere2000.MultipointPassive GearAssy =
                new FrameWorks.Makes.Hardware.Amesbury.Premiere2000.MultipointPassive(m_subAssemblyHieght, this);
            foreach (Part innerpart in GearAssy.Parts)
            {
                //inner
                this.Parts.Add(innerpart);

            }

            #endregion

            #region Seal/Weatherstripping


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //DoorEdgeSeal
                part = new Part(1005, "DoorEdgeSeal", this, 1, periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 2; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //GlazingEPDM
                part = new Part(3904, "GlazingEPDM", this, 1, periSeal - 4.0m * epdmReduce);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //DoorBottom

            part = new Part(1518, "DoorBottom", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion


        }

        private int HingeCount(decimal HingeAxisLength)
        {
            int result = 0;

            if (HingeAxisLength < 84.0m)
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 114.0m))
            {
                result = 5;
            }
            else if ((HingeAxisLength >= 114.0m) && (HingeAxisLength < 134.0m))
            {
                result = 6;
            }
            else if ((HingeAxisLength >= 134.0m) && (HingeAxisLength < 164.0m))
            {
                result = 7;
            }


            return result;
        }




        #endregion

    }




}