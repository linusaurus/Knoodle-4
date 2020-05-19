#region Copyright (c) 2017 WeaselWare Software
/************************************************************************************
'
' Copyright  2017 WeaselWare Software 
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
' Portions Copyright 2017 WeaselWare Software
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
using FrameWorks.Makes.System2010;


namespace FrameWorks.Makes.System2010
{

    public class FrameAlumSlabDoorLH : SubAssemblyBase
    {

        #region Fields

        // The values we can change for different layouts
        const decimal doorReduceX2 = 0.875m * 2.0m;
        const decimal doorReduce = 0.875m;
        const decimal doorGapBot = 0.75m;
        const decimal epdmReduce = 2.73129921m;
        const decimal epdmADD = 2.375m;
        const decimal edgeSealAdd = .390m;
        const decimal hdpExtnd = 0.1250m;
        const decimal calkJoint = 0.125m;


        //



        #endregion

        #region Constructor

        public FrameAlumSlabDoorLH()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrameAlumSlabDoorLH";
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

            ///////////////////////////////////////////////////////////////////////////

            #region Frame-Parts

            // JamAlumL -->> 
            decimal doorPanel = decimal.Zero;

            doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;

            part = new Part(4352, "JamAlumL<", this, 1, m_subAssemblyHieght - calkJoint);
            part.PartGroupType = "Frame-Parts";
            decimal step = (doorPanel - 15.0m);
            step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(doorPanel) - 1));
            step = Math.Round(step, 4);
            //string msg = "";
            part.PartLabel = "1) MiterTop\r\n" +
                             "2) [911.m]Cope Jamb Bottom->\r\n" +
                             "3) Position 0rigin TOU @ ->" + (7.5m + 0.875m).ToString() + "\r\n" +
                             "4) Hinge Backer Prep->[1982.m] "
                   + FrameWorks.Functions.HingeCount(doorPanel).ToString() + "@<" + step.ToString() + ">O.C.";

            m_parts.Add(part);



            // JamAlumR -->>  
            part = new Part(4352, "JamAlumR|>", this, 1, m_subAssemblyHieght - calkJoint);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterTop\r\n" +
                             "2)[1962.m]Position 0rigin Strike Plate";

            m_parts.Add(part);


            // HeadAlum ^^
            part = new Part(4352, "HeadAlum", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "1)MiterEnds\r\n" +
                             "2)[1987.m]Position 0rigin Shoot Strike";

            m_parts.Add(part);


            #endregion

            #region AssyHrdwrFrame


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            for (int i = 0; i < 4; i++)
            {
                part = new Part(3206, "AglBrktAlum", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrFrame";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            // PointSetScrew
            for (int i = 0; i < 16; i++)
            {
                part = new Part(1545, "PointSetScrew", this, 1, 0.0m);
                part.PartGroupType = "AssyHrdwrFrame";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region HardWare

            // HoppeStrikePlate
            part = new Part(5335, "HoppeStrikePlate", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - calkJoint, m_subAssemblyWidth);

                //FrameSealKfolD
                part = new Part(2274, "FrameSealKfolD", this, 1, peri - m_subAssemblyWidth - 4.0m);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            #region AlumDoorPanel

            ////////////////////////////////////////////////////////////////////////////////////

            // AlumDoorPanel
            for (int i = 0; i < 1; i++)
            {
                //AlumDoorPanel
                part = new Part(911);
                part.FunctionalName = "AlumDoorPanel";
                part.PartGroupType = "AlumDoorPanel-Parts";
                part.Qnty = 1;
                part.ContainerAssembly = this;
                part.PartWidth = (m_subAssemblyWidth - doorReduceX2 );
                part.PartLength = (m_subAssemblyHieght - doorReduce - doorGapBot);
                part.PartThick = 2.25m;
                part.PartLabel = "";

                m_parts.Add(part);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare Logic

            // Hinges

            part = new Part(3685, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = ".25_RAD_Corner";

            m_parts.Add(part);

            // BackerHinge

            part = new Part(4101, "BackerHinge", this, HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //HoppeSinglePoint

            part = new Part(3265, "HoppeSinglePoint", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            
            //HoppeCurvedLipStikeORB

            part = new Part(5442, "HoppeCurvedLipStikeORB", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //KfolDrEdge
                part = new Part(2274, "KfolDrEdge", this, 1, periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //DoorBotPVC

            part = new Part(1518, "DoorBotPVC", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
            part.PartGroupType = "Seal-Parts";
            part.PartLabel = "";

            m_parts.Add(part);


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDM_PreSet
                part = new Part(4314, "EPDM_PreSet", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDM_Wedge
                part = new Part(4284, "EPDM_Wedge", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                part.PartGroupType = "Seal-Parts";
                part.PartLabel = "";

                m_parts.Add(part);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////





            #endregion

        }

        private int HingeCount(decimal HingeAxisLength)
        {
            int result = 0;

            if (HingeAxisLength < 84.0m)
            {
                result = 3;
            }
            else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 108.0m))
            {
                result = 4;
            }
            else if ((HingeAxisLength >= 108.0m) && (HingeAxisLength < 134.0m))
            {
                result = 5;
            }
            else if ((HingeAxisLength >= 134.0m) && (HingeAxisLength < 164.0m))
            {
                result = 6;
            }


            return result;
        }




        #endregion

    }




}