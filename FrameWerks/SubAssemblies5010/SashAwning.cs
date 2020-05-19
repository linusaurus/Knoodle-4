#region Copyright (c) 2014 WeaselWare Software
/************************************************************************************
'
' Copyright  2014 WeaselWare Software 
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
' Portions Copyright 2014 WeaselWare Software
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

namespace FrameWorks.Makes.System5010
{

    public class SashAwning : SubAssemblyBase
    {

        #region Fields


        //Constant Values
        const decimal cnrBrktAlum = 0.44m;
        const decimal gstopReduce = .9375m;
        const decimal sashWdCldred = .58634341m;
        const decimal glassReduce = 1.28125m;
        const decimal gasketReduce = 1.41875m;
        const decimal edgeSealAdd = .390m;





        static int createID;


        #endregion

        #region Constructor

        public SashAwning()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System5010-SashAwning";
            this.WrkOrder = new Workorder(this, 1);
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;

            string partleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;




            #region SashBzAl


            // StileBzAl_L <<--
            part = new Part(4862, "StileBzAl_L", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "SashBzAl-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL = "MiterEnds";

            m_parts.Add(part);


            // StileBzAl_R -->>
            part = new Part(4862, "StileBzAl_R", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "SashBzAl-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR = "1)MiterEnds" + "r\n" +
                                           "2)MachineKeeper";

            m_parts.Add(part);


            // RailBzAl_T ^^
            part = new Part(4862, "RailBzAl_T", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "SashBzAl-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3121Left";

            m_parts.Add(part);


            // RailBzAl_B ||
            part = new Part(4862, "RailBzAl_B", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "SashBzAl-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail = "1)MiterEnds" + "\r\n" +
                                            "2)Machine3121Left";

            m_parts.Add(part);



            #endregion

            #region WoodClad


            // StileWoodL <<--
            part = new Part(4872, "StileWoodL", this, 1, m_subAssemblyHieght - sashWdCldred);
            part.PartGroupType = "WoodClad-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileL = "";

            m_parts.Add(part);


            // StileWoodR -->>
            part = new Part(4872, "StileWoodR", this, 1, m_subAssemblyHieght - sashWdCldred);
            part.PartGroupType = "WoodClad-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelStileR = "";

            m_parts.Add(part);


            // RailWoodT ^^
            part = new Part(4872, "RailWoodT", this, 1, m_subAssemblyWidth - sashWdCldred);
            part.PartGroupType = "WoodClad-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelTopRail = "";

            m_parts.Add(part);


            // RailWoodB ||
            part = new Part(4872, "RailWoodB", this, 1, m_subAssemblyWidth - sashWdCldred);
            part.PartGroupType = "WoodClad-Parts";
            part.PartWidth = part.Source.Width;
            part.PartThick = part.Source.Height;
            part.PartLabel = labelBotRail = "";

            m_parts.Add(part);



            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpVt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4327, "AlumGlsStpVt", this, 1, m_subAssemblyHieght - 2 * gstopReduce);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpHz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4327, "AlumGlsStpHz", this, 1, m_subAssemblyWidth - 2 * gstopReduce);
                part.PartGroupType = "StopAlum-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region StopWdCld

            //////////////////////////////////////////////////////////////////////////////

            // WoodGlsStpVt
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4331, "WoodGlsStpVt", this, 1, m_subAssemblyHieght - 2 * gstopReduce);
                part.PartGroupType = "StopWdCld-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////

            //////////////////////////////////////////////////////////////////////////////

            // WoodGlsStpHz
            for (int i = 0; i < 2; i++)
            {
                part = new Part(4331, "WoodGlsStpHz", this, 1, m_subAssemblyWidth - 2 * gstopReduce);
                part.PartGroupType = "StopWdCld-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }


            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region AssemblyHdw

            //////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum_0.44
            for (int i = 0; i < 4; i++)
            {
                part = new Part(5374, "AglBrktAlum_0.44", this, 1, cnrBrktAlum);
                part.PartGroupType = "AssemblyHdw-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////

            // SocSetScrw.25_20
            for (int i = 0; i < 16; i++)
            {
                part = new Part(1545, "SocSetScrw.25_20", this, 1, 0.0m);
                part.PartGroupType = "AssemblyHdw-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////

            //CornerBraceSS
            for (int i = 0; i < 4; i++)
            {
                part = new Part(4855, "CornerBraceSS", this, 1, 0.0m);
                part.PartGroupType = "AssemblyHdw-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////

            // MS_FlatHead_8-32x3/16_SS
            for (int i = 0; i < 16; i++)
            {
                part = new Part(4876, "MS_FlatHead_8-32x3/16_SS", this, 1, 0.0m);
                part.PartGroupType = "AsemblHrdwr-Parts";
                part.PartWidth = part.Source.Width;
                part.PartThick = part.Source.Height;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////

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
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (m_subAssemblyWidth <= 47.9m)
            {

                //HandleCamLH 
                part = new Part(1171, "HandleCamLH", this, 1, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";
                part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
                m_parts.Add(part);


                //StrikeWedge 

                part = new Part(1174, "StrikeWedge", this, 1, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";
                part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
                m_parts.Add(part);

            }
            else
            {


                //HandleCamLH 

                part = new Part(1171, "HandleCamLH", this, 1, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";
                part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
                m_parts.Add(part);


                //HandleCamRH 

                part = new Part(1168, "HandleCamRH", this, 1, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";
                part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
                m_parts.Add(part);


                //StrikeWedge 

                part = new Part(1174, "StrikeWedge", this, 2, 0.0m);
                part.PartGroupType = "Hardware";
                part.PartLabel = "";
                part.PartIdentifier = partleader + "." + Convert.ToString(createID++);
                m_parts.Add(part);



            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////



            #endregion

            #region Glass


            /////////////////////////////////////////////////////////////////////////////////////////////
            // Glass Panels
            for (int i = 0; i < 1; i++)
            {

                // Glass Panel
                part = new Part(4550);

                part.FunctionalName = "Glass";
                part.PartGroupType = "Glass-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - 2 * glassReduce);
                part.PartLength = (m_subAssemblyHieght - 2 * glassReduce);
                part.PartThick = 1.230m;

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Seal/Weatherstripping


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {
                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght + edgeSealAdd, m_subAssemblyWidth + edgeSealAdd);

                //SashEdgeSeal
                part = new Part(2274, "SashEdgeSeal", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //GlazDartEPDM
                part = new Part(4314, "GlazDartEPDM", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gasketReduce, m_subAssemblyWidth - gasketReduce);

                //GlazWedgEPDM
                part = new Part(4284, "GlazWedgEPDM", this, 1, peri);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////








            #endregion






        }
        #endregion

    }




}