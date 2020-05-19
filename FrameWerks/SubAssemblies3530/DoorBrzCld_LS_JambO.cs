#region Copyright (c) 2012 WeaselWare Software
/************************************************************************************
'
' Copyright  2012 WeaselWare Software 
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
' Portions Copyright 2012 WeaselWare Software
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

    public class DoorBrzCld_LS_JambO : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;
        const decimal coreReduceX2 = 1.250242m;
        const decimal glassReduceX2 = 5.1875m;



        //static int createID;
        //Part part;
        //string partleader;

        #endregion

        #region Constructor

        public DoorBrzCld_LS_JambO()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System3530-DoorBrzCld_LS_JambO";
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


            // StileCoreLead 

            part = new Part(3070, "StileCoreLead", this, 1, m_subAssemblyHieght - coreReduceX2);
            part.PartGroupType = "DoorCore-Parts";
            part.PartLabel = "1) Miter Ends" + "r\n" +
                             "2) Gear Lever Center Int" + "\r\n" +
                             "3) Flush Pull Center Ext";

            m_parts.Add(part);


            // StileCoreRear 

            part = new Part(3070, "StileCoreRear", this, 1, m_subAssemblyHieght - coreReduceX2);
            part.PartGroupType = "DoorCore-Parts";
            part.PartLabel = "1) Miter End";

            m_parts.Add(part);


            // RailCoreTop ^^

            part = new Part(3070, "RailCoreTop", this, 1, m_subAssemblyWidth - coreReduceX2);
            part.PartGroupType = "DoorCore-Parts";
            part.PartLabel = "1) Miter Ends ";

            m_parts.Add(part);


            // RailCoreB

            part = new Part(3070, "RailCoreB", this, 1, m_subAssemblyWidth - coreReduceX2);
            part.PartGroupType = "DoorCore-Parts";
            part.PartLabel = "1) Miter Ends ";

            m_parts.Add(part);



            #endregion

            #region HDPE



            // HDPE_LS_LockEdge
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3761, "HDPE_LS_LockEdge", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "";

                m_parts.Add(part);
            }




            // HDPETop
            for (int i = 0; i < 1; i++)
            {


                part = new Part(3762, "HDPETop", this, 1, m_subAssemblyWidth);
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

            #region BraceCorner

            /////////////////////////////////////////////////////////////////////////////////////////////////

            // BraceCorner 
            for (int i = 0; i < 16; i++)
            {
                part = new Part(4246, "BraceCorner", this, 1, 0.0m );
                part.PartGroupType = "BraceCorner-Parts";
                part.PartLabel = "1) Miter Ends";
                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////

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

            #region GuidesTop



            // GuideTop
            for (int i = 0; i < 1; i++)
            {
                part = new Part(2463, "FrontGuideTop", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "GuidesTop-Parts";
                part.PartLabel = "";
                m_parts.Add(part);

            }




            // GuideTop
            for (int i = 0; i < 1; i++)
            {

                part = new Part(2463, "RearGuideTop", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "GuideTop-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }


            #endregion

            #region HookCap



            // EndCap

            part = new Part(3938, "EndCap", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";

            m_parts.Add(part);



            // HookStrip

            part = new Part(3710, "HookStrip", this, 1, m_subAssemblyHieght + 0.0625m);
            part.PartGroupType = "HookCap-Parts";
            part.PartLabel = "";

            m_parts.Add(part);





            #endregion

            #region Glass


            //Glass Panel
            part = new Part(4420);
            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;
            part.PartWidth = m_subAssemblyWidth - glassReduceX2;
            part.PartLength = m_subAssemblyHieght - glassReduceX2;
            part.PartThick = 1.0m;

            m_parts.Add(part);

            #endregion

            #region Seal/Weatherstripping



            //GlazeWedgeSeals

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.581266m, m_subAssemblyWidth - 2.581266m);
                part = new Part(3904, "GlazeWedgeSeals", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////

            //GlazeWedgeSeals

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - 2.581266m, m_subAssemblyWidth - 2.581266m);
                part = new Part(3904, "GlazeWedgeSeals", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            //////////////////////////

            // Edge & Bottom Seal

            for (int i = 0; i < 2; i++)
            {

                part = new Part(1005, "Edge & Bottom Seal", this, 1, m_subAssemblyHieght + m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            ///////////////////////////

            // Top Seal

            for (int i = 0; i < 2; i++)
            {


                part = new Part(3783, "Top Seal", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);


            }

            /////////////////////////

            // HookPileT+Fin

            for (int i = 0; i < 1; i++)
            {

                part = new Part(3959, "HookPileT+Fin", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////



            #endregion





        }
        #endregion

    }

}