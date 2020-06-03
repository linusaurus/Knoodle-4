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
            subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrameAlumSlabDoorLH";
        }

        #endregion

        #region Methods


        //Bill of Material
        public override void Build()
        {

            Component Component;

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;

            ///////////////////////////////////////////////////////////////////////////

            #region Frame-Components

            // JamAlumL -->> 
            decimal doorPanel = decimal.Zero;

            doorPanel = this.Parent.SubAssemblies[0].SubAssemblyHieght;

            Component = new Component(4352, "JamAlumL<", this, 1, m_subAssemblyHieght - calkJoint);
            Component.ComponentGroupType = "Frame-Components";
            decimal step = (doorPanel - 15.0m);
            step /= Convert.ToDecimal((FrameWorks.Functions.HingeCount(doorPanel) - 1));
            step = Math.Round(step, 4);
            //string msg = "";
            Component.ComponentLabel = "1) MiterTop\r\n" +
                             "2) [911.m]Cope Jamb Bottom->\r\n" +
                             "3) Position 0rigin TOU @ ->" + (7.5m + 0.875m).ToString() + "\r\n" +
                             "4) Hinge Backer Prep->[1982.m] "
                   + FrameWorks.Functions.HingeCount(doorPanel).ToString() + "@<" + step.ToString() + ">O.C.";

            m_Components.Add(Component);



            // JamAlumR -->>  
            Component = new Component(4352, "JamAlumR|>", this, 1, m_subAssemblyHieght - calkJoint);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "1)MiterTop\r\n" +
                             "2)[1962.m]Position 0rigin Strike Plate";

            m_Components.Add(Component);


            // HeadAlum ^^
            Component = new Component(4352, "HeadAlum", this, 1, m_subAssemblyWidth);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "1)MiterEnds\r\n" +
                             "2)[1987.m]Position 0rigin Shoot Strike";

            m_Components.Add(Component);


            #endregion

            #region AssyHrdwrFrame


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
            for (int i = 0; i < 4; i++)
            {
                Component = new Component(3206, "AglBrktAlum", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrFrame";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            // PointSetScrew
            for (int i = 0; i < 16; i++)
            {
                Component = new Component(1545, "PointSetScrew", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrFrame";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region HardWare

            // HoppeStrikePlate
            Component = new Component(5335, "HoppeStrikePlate", this, 1, 0.0m);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            #endregion

            #region Seal/Weatherstripping

            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - calkJoint, m_subAssemblyWidth);

                //FrameSealKfolD
                Component = new Component(2274, "FrameSealKfolD", this, 1, peri - m_subAssemblyWidth - 4.0m);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

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
                Component = new Component(911);
                Component.FunctionalName = "AlumDoorPanel";
                Component.ComponentGroupType = "AlumDoorPanel-Components";
                Component.Qnty = 1;
                Component.ContainerAssembly = this;
                Component.ComponentWidth = (m_subAssemblyWidth - doorReduceX2 );
                Component.ComponentLength = (m_subAssemblyHieght - doorReduce - doorGapBot);
                Component.ComponentThick = 2.25m;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HardWare Logic

            // Hinges

            Component = new Component(3685, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = ".25_RAD_Corner";

            m_Components.Add(Component);

            // BackerHinge

            Component = new Component(4101, "BackerHinge", this, HingeCount(m_subAssemblyHieght), 0.0m);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            /////////////////////////////////////////////////////////////////////////////////////////////////////

            //HoppeSinglePoint

            Component = new Component(3265, "HoppeSinglePoint", this, 1, 0.0m);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            
            //HoppeCurvedLipStikeORB

            Component = new Component(5442, "HoppeCurvedLipStikeORB", this, 1, 0.0m);
            Component.ComponentGroupType = "Hardware-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);


            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Seal/Weatherstripping


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {
                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //KfolDrEdge
                Component = new Component(2274, "KfolDrEdge", this, 1, periSeal - m_subAssemblyWidth + 4.0m * edgeSealAdd);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //DoorBotPVC

            Component = new Component(1518, "DoorBotPVC", this, 1, m_subAssemblyWidth + 2.0m * hdpExtnd);
            Component.ComponentGroupType = "Seal-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDM_PreSet
                Component = new Component(4314, "EPDM_PreSet", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal periSeal = FrameWorks.Functions.Perimeter(m_subAssemblyHieght, m_subAssemblyWidth);

                //EPDM_Wedge
                Component = new Component(4284, "EPDM_Wedge", this, 1, periSeal - 4.0m * epdmReduce + 4.0m * epdmADD);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

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