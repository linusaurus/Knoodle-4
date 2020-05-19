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

namespace FrameWorks.Makes.System3000
{
    
    public class Hoppe 
    {

        #region Fields

        private List<Part> m_parts;
        Part part;
        SubAssemblyBase m_parent;


        #endregion

        #region Constructor

        public Hoppe()
        {
        }

        public Hoppe(decimal height,SubAssemblyBase parent)
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
            get {return m_parts  ;}
        }

       
        private void PickMultiPoint(decimal HingeAxisLength)
        {

            #region Top Extension Logic
            //Minimum is 76.61
            
            if (HingeAxisLength < 36.61m)
            {

                //throw HardwareApplicationError("Multipoint Hinge System exceeds Minumum Size");


            }
            else if ((HingeAxisLength > 76.61m) && (HingeAxisLength <= 80.06m))
            {
                //Multipoint Set for 76.61 <<>> 80.06
                part = new Part(1972, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartName = "Top Ext";
                part.PartLabel = "";                
                m_parts.Add(part);

            }
            else if ((HingeAxisLength > 80.06m) && (HingeAxisLength <= 83.01m))
            {

                part = new Part(1971, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartName = "Top Ext";
                part.PartLabel = "";                               
                m_parts.Add(part);


            }
            else if ((HingeAxisLength > 83.01m) && (HingeAxisLength <= 85.96m))
            {
                part = new Part(1973, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartName = "Top Ext";
                part.PartLabel = "";                                
                m_parts.Add(part);

            }

            else if ((HingeAxisLength > 85.96m) && (HingeAxisLength <= 88.92m))
            {
                part = new Part(2704, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartName = "Top Ext";
                part.PartLabel = "";                                
                m_parts.Add(part);

            }

            else if ((HingeAxisLength > 88.92m) && (HingeAxisLength <= 91.87m))
            {
                part = new Part(2134, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartName = "Top Ext";
                part.PartLabel = "";                                
                m_parts.Add(part);

            }
            else if ((HingeAxisLength > 91.87m) && (HingeAxisLength <= 94.82m))
            {
                part = new Part(2117, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";               
                part.PartName = "Top Ext";
                part.PartLabel = "";                                
                m_parts.Add(part);

            }
            else if ((HingeAxisLength > 94.82m) && (HingeAxisLength <= 97.775m))
            {
                part = new Part(1972, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartName = "Top Ext";
                part.PartLabel = "";                                
                m_parts.Add(part);

            }
            else if ((HingeAxisLength > 97.775m) && (HingeAxisLength <= 100.73m))
            {
                part = new Part(1971, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartName = "Top Ext";
                part.PartLabel = "";                              
                m_parts.Add(part);

            }
            else if ((HingeAxisLength > 100.73m) && (HingeAxisLength <= 103.68m))
            {
                part = new Part(1973, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";               
                part.PartName = "Top Ext";
                part.PartLabel = "";                              
                m_parts.Add(part);

            }
            else if ((HingeAxisLength > 103.68m) && (HingeAxisLength <= 106.635m))
            {
                part = new Part(2704, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";               
                part.PartName = "Top Ext";
                part.PartLabel = "";                             
                m_parts.Add(part);

            }
            else if ((HingeAxisLength > 106.635m) && (HingeAxisLength <= 109.585m))
            {
                part = new Part(2134, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";             
                part.PartName = "Top Ext";
                part.PartLabel = "";                            
                m_parts.Add(part);

            }
            else if ((HingeAxisLength > 109.585m) && (HingeAxisLength <= 112.54m))
            {
                part = new Part(2117, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartName = "Top Ext";
                part.PartLabel = "";                            
                m_parts.Add(part);

            }
            else if ((HingeAxisLength > 112.54m) && (HingeAxisLength <= 115.49m))
            {
                part = new Part(1972, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartName = "Top Ext";
                part.PartLabel = "";                              
                m_parts.Add(part);

            }
            else if ((HingeAxisLength > 115.49m) && (HingeAxisLength <= 118.445m))
            {
                part = new Part(1971, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";             
                part.PartName = "Top Ext";
                part.PartLabel = "";                           
                m_parts.Add(part);

            }

            else if ((HingeAxisLength > 118.445m) && (HingeAxisLength <= 121.4m))
            {
                part = new Part(1973, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";              
                part.PartName = "Top Ext";
                part.PartLabel = "";                           
                m_parts.Add(part);

            }
            else if ((HingeAxisLength > 121.4m) && (HingeAxisLength <= 124.35m))
            {
                part = new Part(2704, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartName = "Top Ext";
                part.PartLabel = "";                             
                m_parts.Add(part);

            }
            else if ((HingeAxisLength > 124.35m) && (HingeAxisLength <= 127.305m))
            {
                part = new Part(2134, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartName = "Top Ext";
                part.PartLabel = "";                              
                m_parts.Add(part);

            }
            else if ((HingeAxisLength > 127.305m) && (HingeAxisLength <= 130.75m))
            {
                part = new Part(2117, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartName = "Top Ext";
                part.PartLabel = "";                
                m_parts.Add(part);

            }
            else if (HingeAxisLength > 130.0m)
            {
                //throw HardwareApplicationError("Door Hieght Exceed Hardware Specs");

                part = new Part(2117, "Top Extension", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartName = "Top Ext";
                part.PartLabel = "EXCEEDSMAXHEIGHT";
                m_parts.Add(part);



            }
            #endregion

            #region Middle Extension Logic
            if (HingeAxisLength > 76.61m)
            {

                if ((HingeAxisLength > 76.61m) && (HingeAxisLength <= 94.82m))
                {
                    part = new Part(1974, "Middle Extension", m_parent, 1, 1.0m);
                    part.PartGroupType = "Hardware-Parts";                   
                    part.PartName = "Mid Extension Low";
                    part.PartLabel = "";                                      
                    m_parts.Add(part);

                }
                else if ((HingeAxisLength > 94.82m) && (HingeAxisLength <= 112.54m))
                {
                    part = new Part(1975, "Middle Extension", m_parent, 1, 1.0m);
                    part.PartGroupType = "Hardware-Parts";                    
                    part.PartName = "Mid Extension Mid";
                    part.PartLabel = "";                                       
                    m_parts.Add(part);

                }
                else if ((HingeAxisLength > 112.54m) && (HingeAxisLength <= 130.75m))
                {
                    part = new Part(1976, "Middle Extension", m_parent, 1, 1.0m);
                    part.PartGroupType = "Hardware-Parts";                   
                    part.PartName = "Mid Extension Large";
                    part.PartLabel = "";                                       
                    m_parts.Add(part);

                }
            }


            #endregion

            #region Gear

            part = new Part(1776, "Multipoint Gear", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";         
            part.PartName = "Gear";
            part.PartLabel = "";          
            m_parts.Add(part);

           
            

            #endregion

        } 

    }


    public class HoppeCasement
    {

        #region Fields

        private List<Part> m_parts;
        Part part;
        SubAssemblyBase m_parent;


        #endregion

        #region Constructor

        public HoppeCasement()
        {
        }

        public HoppeCasement(decimal height, SubAssemblyBase parent)
        {
            this.m_parts = new List<Part>();
            this.m_parent = parent;
            Build(height);
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


        private void Build(decimal HingeAxisLength)
        {

            #region Casement Linkage Logic
            //Minimum is 23.465
            if (HingeAxisLength < 23.125m)
            {

                throw HardwareApplicationError("Casement exceeds Minumum Size");


            }
            
            else if ((HingeAxisLength > 43.307m) && (HingeAxisLength <= 52.362m))
            {
                part = new Part(2286, "Linkage230", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartLabel = "";
                m_parts.Add(part);
            }

            else if ((HingeAxisLength > 52.362m) && (HingeAxisLength <= 61.417m))
            {
                part = new Part(2285, "Linkage460", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartLabel = "";
                m_parts.Add(part);

            }

            else if ((HingeAxisLength > 61.417m) && (HingeAxisLength <= 70.472m))
            {
                part = new Part(2285, "Linkage460", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";               
                part.PartLabel = "";
                m_parts.Add(part);
                                                                                                                 
                part = new Part(2286, "Linkage230", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";              
                part.PartLabel = "";
                m_parts.Add(part);
            }

            else if ((HingeAxisLength > 70.472m) && (HingeAxisLength <= 79.527m))
            {
                part = new Part(2285, "Linkage460", m_parent, 2, 1.0m);
                part.PartGroupType = "Hardware-Parts";                
                part.PartLabel = "";
                m_parts.Add(part);

            }

            else if ((HingeAxisLength > 79.527m) && (HingeAxisLength <= 88.582m))
            {
                part = new Part(2285, "Linkage460", m_parent, 2, 1.0m);
                part.PartGroupType = "Hardware-Parts";              
                part.PartLabel = "";
                m_parts.Add(part);

                part = new Part(2286, "Linkage230", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            else if ((HingeAxisLength > 88.582m) && (HingeAxisLength <= 97.637m))
            {
                part = new Part(2285, "Linkage460", m_parent, 3, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            else if (HingeAxisLength > 97.637m)
            {
               // throw HardwareApplicationError("Sash Hieght Exceed Hardware Specs");
                part = new Part(2285, "Linkage460", m_parent, 3, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "EXCEEDSMAXHEIGHT";
                m_parts.Add(part);
            }
           
            //Multipoint Set for 23.465 <<>> 43.307
            part = new Part(2719, "MultiCaseGear", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //TopShootBolt
            part = new Part(2283, "TopShootBolt", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //BottomReverseBolt
            part = new Part(2284, "BotRevBolt", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion



        }

    }



    public class HoppeCasement45mm
    {

        #region Fields

        private List<Part> m_parts;
        Part part;
        SubAssemblyBase m_parent;


        #endregion

        #region Constructor

        public HoppeCasement45mm()
        {
        }

        public HoppeCasement45mm(decimal height, SubAssemblyBase parent)
        {
            this.m_parts = new List<Part>();
            this.m_parent = parent;
            Build(height);
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


        private void Build(decimal HingeAxisLength)
        {

            #region Casement Linkage Logic
            //Minimum is 23.465
            if (HingeAxisLength < 23.465m)
            {

                throw HardwareApplicationError("Casement exceeds Minumum Size");


            }

            else if ((HingeAxisLength > 43.307m) && (HingeAxisLength <= 52.362m))
            {
                part = new Part(2286, "Linkage230", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            else if ((HingeAxisLength > 52.362m) && (HingeAxisLength <= 61.417m))
            {
                part = new Part(2285, "Linkage460", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);

            }

            else if ((HingeAxisLength > 61.417m) && (HingeAxisLength <= 70.472m))
            {
                part = new Part(2285, "Linkage460", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);

                part = new Part(2286, "Linkage230", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            else if ((HingeAxisLength > 70.472m) && (HingeAxisLength <= 79.527m))
            {
                part = new Part(2285, "Linkage460", m_parent, 2, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);

            }

            else if ((HingeAxisLength > 79.527m) && (HingeAxisLength <= 88.582m))
            {
                part = new Part(2285, "Linkage460", m_parent, 2, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);

                part = new Part(2286, "Linkage230", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            else if ((HingeAxisLength > 88.582m) && (HingeAxisLength <= 97.637m))
            {
                part = new Part(2285, "Linkage460", m_parent, 3, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            else if (HingeAxisLength > 97.637m)
            {
                
                
                part = new Part(2285, "Linkage460", m_parent, 3, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "EXCEEDSMAXHEIGHT";
                m_parts.Add(part);
                
                
                
                
                //throw HardwareApplicationError("Sash Hieght Exceed Hardware Specs");
            }

            //Multipoint Set for 23.465 <<>> 43.307
            part = new Part(2282, "MultiCaseGear", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //TopShootBolt
            part = new Part(2283, "TopShootBolt", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //BottomReverseBolt
            part = new Part(2284, "BotRevBolt", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion



        }

    }




    public class HoppeCasement25mm
    {

        #region Fields

        private List<Part> m_parts;
        Part part;
        SubAssemblyBase m_parent;


        #endregion

        #region Constructor

        public HoppeCasement25mm()
        {
        }

        public HoppeCasement25mm(decimal height, SubAssemblyBase parent)
        {
            this.m_parts = new List<Part>();
            this.m_parent = parent;
            Build(height);
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


        private void Build(decimal HingeAxisLength)
        {

            #region Casement Linkage Logic
            //Minimum is 23.465
            if (HingeAxisLength < 23.0m)
            {

                throw HardwareApplicationError("Casement exceeds Minumum Size");


            }

            else if ((HingeAxisLength > 43.307m) && (HingeAxisLength <= 52.362m))
            {
                part = new Part(2286, "Linkage230", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            else if ((HingeAxisLength > 52.362m) && (HingeAxisLength <= 61.417m))
            {
                part = new Part(2285, "Linkage460", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);

            }

            else if ((HingeAxisLength > 61.417m) && (HingeAxisLength <= 70.472m))
            {
                part = new Part(2285, "Linkage460", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);

                part = new Part(2286, "Linkage230", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            else if ((HingeAxisLength > 70.472m) && (HingeAxisLength <= 79.527m))
            {
                part = new Part(2285, "Linkage460", m_parent, 2, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);

            }

            else if ((HingeAxisLength > 79.527m) && (HingeAxisLength <= 88.582m))
            {
                part = new Part(2285, "Linkage460", m_parent, 2, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);

                part = new Part(2286, "Linkage230", m_parent, 1, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            else if ((HingeAxisLength > 88.582m) && (HingeAxisLength <= 97.637m))
            {
                part = new Part(2285, "Linkage460", m_parent, 3, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "";
                m_parts.Add(part);
            }

            else if (HingeAxisLength > 97.637m)
            {


                part = new Part(2285, "Linkage460", m_parent, 3, 1.0m);
                part.PartGroupType = "Hardware-Parts";
                part.PartLabel = "EXCEEDSMAXHEIGHT";
                m_parts.Add(part);




                //throw HardwareApplicationError("Sash Hieght Exceed Hardware Specs");
            }

            //Multipoint Set for 23.465 <<>> 43.307
            part = new Part(2719, "MultiCaseGear", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //TopShootBolt
            part = new Part(2283, "TopShootBolt", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            //BottomReverseBolt
            part = new Part(2284, "BotRevBolt", m_parent, 1, 1.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            #endregion



        }

    }




}
