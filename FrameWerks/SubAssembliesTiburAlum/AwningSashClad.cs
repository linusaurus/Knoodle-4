
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
using System.Diagnostics;


namespace FrameWorks.Makes.TiburAlum
{

    public class AwningSashClad : SubAssemblyBase
    {

        #region Fields


        // The values we can change for different layouts
        const int panelCount = 1;
        const decimal stileWidth = 2.0000m;
        const decimal stileIntX2 = 3.051m;
        const decimal coreReduceX2 = 0.7500m;
        const decimal cladReduceX2 = 0.94916392m;
        const decimal glassReduceX2 = 2.929998m;
        const decimal glazeVinylX2 = 3.1158225m;    




        static int createID;


        #endregion

        #region Constructor

        public AwningSashClad()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Bahia-AwningSashClad";
            this.WrkOrder = new Workorder(this, 1);
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


            #region SashCore



            // CoreStile
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3077, "CoreStile", this, 1, m_subAssemblyHieght - coreReduceX2 );
                part.PartGroupType = "SashCore-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "1)MiterEnds" + "\r\n" +
                                               "2)MachineHingeAwning";

                m_parts.Add(part);

            }



            // CoreRail
            for (int i = 0; i < 2; i++)
            {


                part = new Part(3077, "CoreRail", this, 1, m_subAssemblyWidth - coreReduceX2);
                part.PartGroupType = "SashCore-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "1)MiterEnds" + "\r\n" +
                                               "2)MachineHingeAwning";

                m_parts.Add(part);

            }



            #endregion

            #region HDPE



            // HDPEStile
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3389, "HDPEStile", this, 1, m_subAssemblyHieght );
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "1)MiterEnds" + "\r\n" +
                                               "2)MachineHingeAwning";

                m_parts.Add(part);

            }



            // HDPERail
            for (int i = 0; i < 2; i++)
            {


                part = new Part(3389, "HDPERail", this, 1, m_subAssemblyWidth );
                part.PartGroupType = "HDPE-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "1)MiterEnds" + "\r\n" +
                                               "2)MachineHingeAwning";

                m_parts.Add(part);

            }



            #endregion

            #region SashClad



            // Clad2Stile
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3613, "Clad2Stile", this, 1, m_subAssemblyHieght);
                part.PartGroupType = "SashClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "1)MiterEnds";

                m_parts.Add(part);

            }



            // Clad2Rail
            for (int i = 0; i < 2; i++)
            {


                part = new Part(3613, "Clad2Rail", this, 1, m_subAssemblyWidth);
                part.PartGroupType = "SashClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "1)MiterEnds";

                m_parts.Add(part);

            }




            // CladIntStile
            for (int i = 0; i < 2; i++)
            {

                part = new Part(3612, "CladIntStile", this, 1, m_subAssemblyHieght - cladReduceX2);
                part.PartGroupType = "SashClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileL = "1)MiterEnds";

                m_parts.Add(part);

            }



            // CladIntRail
            for (int i = 0; i < 2; i++)
            {


                part = new Part(3612, "CladIntRail", this, 1, m_subAssemblyWidth - cladReduceX2);
                part.PartGroupType = "SashClad-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = labelStileR = "1)MiterEnds";

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

            for (int i = 0; i < 3; i++)
            {
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                part = new Part(3785, "CladClipTabs", this, Convert.ToInt32(this.Perimeter / 12.0m) - 1, 2.0m);
                part.PartGroupType = "CladClip-Parts";
                part.PartLabel = "2 Inch Clip";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Glass

            //Glass Panel

            part = new Part(3473);

            part.FunctionalName = "Glass";
            part.PartGroupType = "Glass-Parts";
            part.Qnty = 1;
            part.ContainerAssembly = this;

            part.PartWidth = m_subAssemblyWidth - (glassReduceX2);
            part.PartLength = m_subAssemblyHieght - (glassReduceX2);

            m_parts.Add(part);

            #endregion

            #region Seal/Weatherstripping

            //////////////////////////////////////////////////////////////////////////////////

            //GlazeDartSeals
            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght , m_subAssemblyWidth );

                //GlazeDartSeals
                part = new Part(3780, "GlazeDartSeals", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////

            //GlazeWedgeSeals
            for (int i = 0; i < 1; i++)
            {

                //GlazeWedgeSeals
                part = new Part(3781, "GlazeWedgeSeals", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////

            //SashSeals
            for (int i = 0; i < 2; i++)
            {
                part = new Part(2274, "SashSeals", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region HardWare Logic


            // Hinges
            decimal _wieght = FrameWorks.Functions.PanelWieghtS3000(SubAssemblyWidth, SubAssemblyHieght);
            decimal hingesize = SubAssemblyHieght;
            string id = this.Parent.UnitID.ToString();
            if (_wieght < 250.0m)
            {

                part = new Part(Functions.S3000AwningHinge(hingesize), "Awning Hinge", this, 2, 0.0m);
                part.PartGroupType = "Hardware-Parts";

                m_parts.Add(part);

            }
            else
            {

                string message = "The Component is too heavy-" + id.ToString();
                Debug.WriteLine(message);
            }

            int hardwarecount = 1;
            if (m_subAssemblyHieght < 48.0m)
            {
                hardwarecount = 1;
            }
            else
            {
                hardwarecount = 2;

            }

            /////////////////////////////////////////////////////////////////
            // SashKeepers
            for (int i = 0; i < 2; i++)
            {


                part = new Part(3516, "SashKeepers", this, 1, 0.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////



            #endregion

                #region Labor

            part = new LPart("Design", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //Collect Information on Sizes: Measure: Provide Information for Approval: Order: Supervision

            part = new LPart("Draft", this, 3.0m, 80.0m);
            m_parts.Add(part);
            //Typical Drawings

            part = new LPart("MetalHours", this, 8.0m, 80.0m);
            m_parts.Add(part);
            //1 Recieve: 1 Handle: 1 CutSash: 1 CutGlassStop: 1.5 Machine: 1.5 Hardware Prep: 1 Mount Hardware: 


            part = new LPart("Finish", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 Sand Linegrain: 2 Finish:

            part = new LPart("GlazingHours", this, (this.Area * 0.17m) + 1.5m, 80.0m);
            m_parts.Add(part);
            //.5 Recieve: .5 InspectReject: .5 StoreHandle: * .17 Hrs Per Square Ft: 

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