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

namespace FrameWorks.Makes.System2010
{

    public class FrameLS_WND_VW_OX : SubAssemblyBase
    {

        #region Fields

        //Constant Values

        const int panelCount = 2;
        const decimal FaciaCap10 = 2.9375m;
        const decimal fastRacRed2X = 0.3125m * 2.0m;
        const decimal jambDimW = 1.6875m;
        const decimal jambDimWX2 = 2.0m * 1.6875m;
        const decimal headCentRed = 2.0111m;
        const decimal jambLockDel = 1.0625m;
        const decimal jambBumpDel = 1.6875m;
        const decimal headCvrJmbRed = 1.5738m;
        const decimal headCvrMidRed = 2.1361m;
        const decimal sillReduceInt = 2.875m;
        const decimal sillReduceExt = 1.75m;
        const decimal widthRedHDPE = 0.625m;
        const decimal yTrAccess = 3.78125m;
        const decimal reducHDPEsill = 2.375m;
        const decimal reducHDPE = 0.75m;
        const decimal calkJoint = 0.125m;



        //static int createID;

        #endregion

        #region Constructor

        public FrameLS_WND_VW_OX()
        {
            subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-FrameLS_WND_VW_OX";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Component Component;
            string Componentleader = this.Parent.UnitID + "." + this.CreateID.ToString();

            #region Track

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //TopTrackX
            Component = new Component(3406, "TopTrackX", this, 1, m_subAssemblyWidth - jambLockDel - jambBumpDel);
            Component.ComponentGroupType = "TopTrackY-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // TopTrackO
            Component = new Component(3406, "TopTrackO", this, 1, (m_subAssemblyWidth / 2.0m) + yTrAccess - jambLockDel);
            Component.ComponentGroupType = "Track-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //ShapedYtrackRubber -->> 
            for (int i = 0; i < 2; i++)
            {


                Component = new Component(3766, "ShapedYtrackRubber", this, 1, 0.0m);
                Component.ComponentGroupType = "Track-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            //SS_Blade
            Component = new Component(3444, "SS_Blade", this, 1, m_subAssemblyWidth - fastRacRed2X);
            Component.ComponentGroupType = "Track-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            //////////////////////////////////////////////////////////////////////////////

            //AngleStand_O
            Component = new Component(267, "AngleStand_O", this, 1, (m_subAssemblyWidth / 2.0m) + 0.21875m);
            Component.ComponentGroupType = "Track-Components";
            Component.ComponentLabel = "";
            Component.ComponentThick = 0.375m;
            Component.ComponentWidth = 0.75m;

            m_Components.Add(Component);

            //////////////////////////////////////////////////////////////////////////////

            //HDPE_Stand_O
            Component = new Component(3528, "HDPE_Stand_LS_O", this, 1, (m_subAssemblyWidth / 2.0m) + 0.21875m);
            Component.ComponentGroupType = "Track-Components";
            Component.ComponentLabel = "";
            Component.ComponentThick = 0.8709m;
            Component.ComponentWidth = 0.9142m;

            m_Components.Add(Component);

            //////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Over_Travel

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Right
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(5216, "OTB_Right", this, 1, 0.0m);
                Component.ComponentGroupType = "Over_Travel";
                Component.ComponentLabel = "";

                m_Components.Add(Component);
            }

            //////////////////////////////////////////////////////////////////////////////

            //OTB_Filler
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(5271, "OTB_Filler", this, 1, 0.0m);
                Component.ComponentGroupType = "Over_Travel";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            #endregion

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            //AlumJambOWndExt -->> 
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4362, "AlumJambOWndExt", this, 1, m_subAssemblyHieght - sillReduceExt - calkJoint);
                Component.ComponentGroupType = "Frame-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            //AlumJambXWndCenter -->> 
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4362, "AlumJambXWndCenter", this, 1, m_subAssemblyHieght - sillReduceExt - calkJoint - reducHDPE);
                Component.ComponentGroupType = "Frame-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////


            //AlumJambXWndInt -->> 
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4362, "AlumJambXWndInt", this, 1, m_subAssemblyHieght - sillReduceInt);
                Component.ComponentGroupType = "Frame-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            // FaciaHeadWndInt ^^
            Component = new Component(4362, "FaciaHeadWndInt", this, 1, m_subAssemblyWidth - jambDimWX2);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadWndExtX ^^
            Component = new Component(4362, "FaciaHeadWndExtX", this, 1, (m_subAssemblyWidth / 2.0m) - headCvrJmbRed - headCentRed);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaHeadWndExtO ^^
            Component = new Component(4362, "FaciaHeadWndExtO", this, 1, m_subAssemblyWidth - jambDimWX2);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            ////////////////////////////////////////////////////////////////////////////////

            // FaciaCap10 ^^
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4362, "FaciaCap10", this, 1, FaciaCap10);
                Component.ComponentGroupType = "Frame-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }


            // AglOWndJambCover ^^
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4490, "AglOWndJambCover", this, 1, m_subAssemblyHieght - reducHDPE - sillReduceExt - calkJoint);
                Component.ComponentGroupType = "Frame-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }


            ////////////////////////////////////////////////////////////////////////////////

            // AglOWndHeadCover ^^
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4490, "AglOWndHeadCover", this, 1, (m_subAssemblyWidth / 2.0m) - headCvrJmbRed - headCvrMidRed);
                Component.ComponentGroupType = "Frame-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////

            // SillAngleWnd_VW_Ext ^^
            Component = new Component(4468, "SillAngleWnd_VW_Ext", this, 1, m_subAssemblyWidth);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "";
            Component.ComponentThick = 1.75m;
            Component.ComponentWidth = 4.125m;

            m_Components.Add(Component);

            ////////////////////////////////////////////////////////////////////////////////

            // SillAngleWndInt ^^
            Component = new Component(4469, "SillAngleWndInt", this, 1, m_subAssemblyWidth);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "";
            Component.ComponentThick = 0.50m;
            Component.ComponentWidth = 1.25m;

            m_Components.Add(Component);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region Pile_LS_Seals

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4384, "Pile_LS_Seals", this, 1, m_subAssemblyHieght - sillReduceExt - calkJoint);
                Component.ComponentGroupType = "Pile_LS_Seals-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            //Pile_LS_Seals -->> 
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4384, "Pile_LS_Seals", this, 1, m_subAssemblyHieght - sillReduceExt - calkJoint - reducHDPE);
                Component.ComponentGroupType = "Pile_LS_Seals-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////


            //Pile_LS_Seals -->> 
            for (int i = 0; i < 2; i++)
            {

                Component = new Component(4384, "Pile_LS_Seals", this, 1, m_subAssemblyHieght - sillReduceInt);
                Component.ComponentGroupType = "Pile_LS_Seals-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            Component = new Component(4384, "Pile_LS_Seals", this, 1, m_subAssemblyWidth - jambDimWX2);
            Component.ComponentGroupType = "Pile_LS_Seals-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            Component = new Component(4384, "Pile_LS_Seals", this, 1, (m_subAssemblyWidth / 2.0m) - jambDimW - headCentRed);
            Component.ComponentGroupType = "Pile_LS_Seals-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            Component = new Component(4384, "Pile_LS_Seals", this, 1, m_subAssemblyWidth - jambDimWX2);
            Component.ComponentGroupType = "Pile_LS_Seals-Components";
            Component.ComponentLabel = "";

            m_Components.Add(Component);

            ////////////////////////////////////////////////////////////////////////////////

            // Pile_LS_Seals ^^
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4384, "Pile_LS_Seals", this, 1, FaciaCap10);
                Component.ComponentGroupType = "Frame-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region HDPE_Head

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Head ^^
            Component = new Component(3442, "HDPE_Head", this, 1, m_subAssemblyWidth - widthRedHDPE);
            Component.ComponentGroupType = "Frame-Components";
            Component.ComponentLabel = "";
            Component.ComponentThick = 0.75m;
            Component.ComponentWidth = 5.75m;

            m_Components.Add(Component);

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Jamb
            for (int i = 0; i < 2; i++)
            {
                Component = new Component(4400, "HDPE_Jamb", this, 1, m_subAssemblyHieght - reducHDPE - reducHDPEsill);
                Component.ComponentGroupType = "HDPE_Head-Components";
                Component.ComponentLabel = "";
                Component.ComponentThick = 0.75m;
                Component.ComponentWidth = 2.875m;

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            // HDPE_Sill
            for (int i = 0; i < 1; i++)
            {
                Component = new Component(4400, "HDPE_Sill", this, 1, m_subAssemblyWidth);
                Component.ComponentGroupType = "HDPE_Head-Components";
                Component.ComponentLabel = "";
                Component.ComponentThick = 1.5m;
                Component.ComponentWidth = 5.5m;

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            #endregion


        }


        #endregion

    }


}