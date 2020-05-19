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

    public class DrSwg8LtOvrPanActLHR : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal BrzPanelSwgDr = 30.5m;
        const decimal muntBzPnlRed = 33.32778588m;
        const decimal dlrnPnlRed = 33.29687514m;       
        const decimal muntStileRedX2 = 4.97513836m;
        const decimal muntStileRed = 2.4876918m;
        const decimal dlrnStlRed = 2.42507969m;     
        const decimal muntJuncRed = .15533011m;         
        const decimal coreReduceX2 = 1.25024164m;
        const decimal glassBzPnlRed = 33.4375m;
        const decimal glassUpPnlRed = 15.40117818m;
        const decimal glassMuntRedX2 = .375m;
        const decimal glassDrGap = 2.5625m;
        const decimal epdmReduce = 2.58125m;
        const decimal edgeSealAdd = .28125m;        
        const decimal delrinThick = .09375m;
        const decimal hdpExtnd = 0.15625m;
        const decimal hdpeReduce = .1250m;
        const decimal glassUpper = 12.83867818m;


        //



        //static int createID;
        //Part part;
        //string partleader;

        #endregion

        #region Constructor

        public DrSwg8LtOvrPanActLHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3530-DrSwg8LtOvrPanActLHR";
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



            #region DoorCore



            // StileCoreLeft <<--

            part = new Part(3070, "StileCoreLeft", this, 1, m_subAssemblyHieght - coreReduceX2);
            part.PartGroupType = "DoorCore-Parts";
            decimal step = (m_subAssemblyHieght - 15.0m);
            step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(m_subAssemblyHieght) - 1));
            step = Math.Round(step, 4);
            int msg = FrameWorks.Functions.HingeCount(m_subAssemblyHieght);
            part.PartLabel = "1) Miter Ends" + "\r\n" +
                             "2) Position 0rigin @ " + (7.5m).ToString() + "\r\n" +
                             "3) Tube Backer Prep-> 3123.m"
                + FrameWorks.Functions.HingeCount(m_subAssemblyHieght).ToString() + "@<" + step.ToString() + ">O.C.";

            m_parts.Add(part);



            // StileCoreRight -->>

            part = new Part(3070, "StileCoreRight", this, 1, m_subAssemblyHieght - coreReduceX2);
            part.PartGroupType = "DoorCore-Parts";
            decimal strikeOrigin = m_subAssemblyHieght - 35.875m;
            part.PartLabel = "1) Miter End" + "\r\n" +
                             "2) Position Origin Strike  " + strikeOrigin.ToString() + "\r\n" +
                             "3) Machine 3127.m";

            m_parts.Add(part);



            // RailCoreTop ^^

            part = new Part(3070, "RailCoreTop", this, 1, m_subAssemblyWidth - coreReduceX2);
            part.PartGroupType = "DoorCore-Parts";
            part.PartLabel = "1) Miter Ends " + "\r\n" +
                             "2) Bore Hole for [1932 pn]-";

            m_parts.Add(part);


            // RailCoreB

            part = new Part(3070, "RailCoreB", this, 1, m_subAssemblyWidth - coreReduceX2);
            part.PartGroupType = "DoorCore-Parts";
            part.PartLabel = "1) Miter Ends ";

            m_parts.Add(part);



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

            #region DoorClad


            // StileCladLeft
            for (int i = 0; i < 2; i++)
            {
                part = new Part(3895, "StileCladLeft", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorClad-Parts";
                part.PartLabel = "1) Miter Ends";
                m_parts.Add(part);

            }




            // StileCladRight
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3895, "StileCladRight", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "DoorClad-Parts";
                part.PartLabel = "1) Miter Ends";

                m_parts.Add(part);

            }




            // RailCladT
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3895, "RailCladT", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorClad-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }





            // RailCladB
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3895, "RailCladB", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "DoorClad-Parts";
                part.PartLabel = "1) Miter Ends ";

                m_parts.Add(part);

            }



            #endregion

            #region CladClip


            //CladClipExtHead

            part = new Part(3785, "CladClipExtHead", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "CladClip-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////

            //CladClipTabs

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            for (int i = 0; i < 4; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                part = new Part(3785, "CladClipTabs", this, Convert.ToInt32(this.Perimeter / 12.0m) - 1, 2.0m);
                part.PartGroupType = "CladClip-Parts";
                part.PartLabel = "2 Inch Clip";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////


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
            for (int i = 0 ; i < 2; i++)

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
            for (int i = 0; i < 2; i++)
            {

                //Glass8LiteTop2
                part = new Part(4420);
                part.FunctionalName = "Glass8LiteTop2";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = ((m_subAssemblyWidth - 2.0m * glassDrGap - glassMuntRedX2) / 2);
                part.PartLength = (glassUpper);
                part.PartThick = 1.0m;

                m_parts.Add(part);


            }




            // Eight Glass Panels
            for (int i = 0; i < 6; i++)
            {

                //Glass8Lite
                part = new Part(4420);
                part.FunctionalName = "Glass8LiteBot6";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = ((m_subAssemblyWidth - 2.0m * glassDrGap - glassMuntRedX2) / 2);
                part.PartLength = ((m_subAssemblyHieght - glassBzPnlRed -glassUpPnlRed - 3.0m * glassMuntRedX2) / 3);
                part.PartThick = 1.0m;

                m_parts.Add(part);


            }



            #endregion

            #region HardWare Logic

            // Hinges
            part = new Part(3685, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = ".25_RAD_Corner";

            m_parts.Add(part);


            FrameWorks.Makes.Hardware.Amesbury.Premiere2000.MultipointActive GearAssy =
                new FrameWorks.Makes.Hardware.Amesbury.Premiere2000.MultipointActive(m_subAssemblyHieght, this);
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
                part = new Part(1005, "DoorEdgeSeal", this, 1, peri - m_subAssemblyWidth + 4.0m * edgeSealAdd);
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