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
' Portions Copyright 2007 WeaselWare Software
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
using System.Runtime;

namespace FrameWorks.Makes.Hardware.Amesbury.Premiere2000
{

    public class MultipointActive
    {

        #region Fields

        private List<Part> m_parts;
        Part part;
        SubAssemblyBase m_parent;


        #endregion

        #region Constructor

        public MultipointActive()
        {
        }

        public MultipointActive(decimal height, SubAssemblyBase parent)
        {
            this.m_parts = new List<Part>();
            this.m_parent = parent;
            PickMultiPoint(height);
        }

        #endregion

        #region Error Handling

        System.Exception HardwareApplicationError(string description)
        {

            return new SystemException(description);
        }

        #endregion

        public List<Part> Parts
        {
            get { return m_parts; }
        }


        private void PickMultiPoint(decimal HingeAxisLength)
        {

            #region TopShootTipLogic
            

            //MP_ShootTip
            part = new Part(3865, "MP_TopShootTip", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartName = "5670-81-ShootTip";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////

            #endregion

            #region MP_UpperAssYLogic

            ///////////////////////////////////////////////////////////////////////////

            if (HingeAxisLength > 69.0m || HingeAxisLength < 121.5m)

            {

                if ((HingeAxisLength > 69.0m) && (HingeAxisLength <= 82.2499m))
                {
                    part = new Part(3861, "MP_UpperAssY", m_parent, 1, 1.0m);
                    part.PartGroupType = "Hardware-Parts";
                    part.PartName = "16-2094-UA";
                    part.PartLabel = "";
                    m_parts.Add(part);

                }
                else if ((HingeAxisLength > 82.25m) && (HingeAxisLength <= 95.2499m))
                {
                    part = new Part(3862, "MP_UpperAssY", m_parent, 1, 1.0m);
                    part.PartGroupType = "Hardware-Parts";
                    part.PartName = "16-2095-UA";
                    part.PartLabel = "";
                    m_parts.Add(part);

                }
                else if ((HingeAxisLength > 95.25m) && (HingeAxisLength <= 108.2499m))
                {
                    part = new Part(3863, "MP_UpperAssY", m_parent, 1, 1.0m);
                    part.PartGroupType = "Hardware-Parts";
                    part.PartName = "16-2096-UA";
                    part.PartLabel = "";
                    m_parts.Add(part);

                }
                else if ((HingeAxisLength > 108.25m) && (HingeAxisLength <= 121.5m))
                {
                    part = new Part(3864, "MP_UpperAssY", m_parent, 1, 1.0m);
                    part.PartGroupType = "Hardware-Parts";
                    part.PartName = "16-2097-UA";
                    part.PartLabel = "";
                    m_parts.Add(part);

                }

            }
            ////////////////////////////////////////////////////////////////////////////

            #endregion

            #region MP_GearActive

            part = new Part(3860, "MP_GearActive", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartName = "8145-2310-81-LA";
            part.PartLabel = "";
            m_parts.Add(part);




            #endregion

        }

    }

    public class MultipointPassive
    {

        #region Fields

        private List<Part> m_parts;
        Part part;
        SubAssemblyBase m_parent;


        #endregion

        #region Constructor

        public MultipointPassive()
        {
        }

        public MultipointPassive(decimal height, SubAssemblyBase parent)
        {
            this.m_parts = new List<Part>();
            this.m_parent = parent;
            PickMultiPoint(height);
        }

        #endregion

        #region Error Handling

        System.Exception HardwareApplicationError(string description)
        {

            return new SystemException(description);
        }

        #endregion

        public List<Part> Parts
        {
            get { return m_parts; }
        }


        private void PickMultiPoint(decimal HingeAxisLength)
        {

            #region TopShootTipLogic


            //MP_ShootTip
            part = new Part(3865, "MP_TopShootTip", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartName = "5670-81-ShootTip";
            part.PartLabel = "";
            m_parts.Add(part);

            /////////////////////////////////////////////////////

            #endregion

            #region MP_UpperAssYLogic

            ///////////////////////////////////////////////////////////////////////////

            if (HingeAxisLength > 69.0m || HingeAxisLength < 121.5m)
            {

                if ((HingeAxisLength > 69.0m) && (HingeAxisLength <= 82.2499m))
                {
                    part = new Part(3867, "MP_UpperAssY", m_parent, 1, 1.0m);
                    part.PartGroupType = "Hardware-Parts";
                    part.PartName = "16-2074-UA";
                    part.PartLabel = "";
                    m_parts.Add(part);

                }
                else if ((HingeAxisLength > 82.25m) && (HingeAxisLength <= 95.2499m))
                {
                    part = new Part(3868, "MP_UpperAssY", m_parent, 1, 1.0m);
                    part.PartGroupType = "Hardware-Parts";
                    part.PartName = "16-2075-UA";
                    part.PartLabel = "";
                    m_parts.Add(part);

                }
                else if ((HingeAxisLength > 95.25m) && (HingeAxisLength <= 108.2499m))
                {
                    part = new Part(3869, "MP_UpperAssY", m_parent, 1, 1.0m);
                    part.PartGroupType = "Hardware-Parts";
                    part.PartName = "16-2076-UA";
                    part.PartLabel = "";
                    m_parts.Add(part);

                }
                else if ((HingeAxisLength > 108.25m) && (HingeAxisLength <= 121.5m))
                {
                    part = new Part(3867, "MP_UpperAssY", m_parent, 1, 1.0m);
                    part.PartGroupType = "Hardware-Parts";
                    part.PartName = "16-2071-UA";
                    part.PartLabel = "";
                    m_parts.Add(part);

                }

            }
            ////////////////////////////////////////////////////////////////////////////

            #endregion

            #region MP_GearPassive

            part = new Part(3866, "MP_GearPassive", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartName = "8145-2070-81-LA";
            part.PartLabel = "";
            m_parts.Add(part);




            #endregion

        }

    }




}
