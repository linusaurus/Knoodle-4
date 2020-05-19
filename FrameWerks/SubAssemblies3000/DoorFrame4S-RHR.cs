#region Copyright (c) 2007 WeaselWare Software
/************************************************************************************
'
' Copyright  2007 WeaselWare Software 
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
   
   public class DoorFrame4S_RHR : SubAssemblyBase
   {

      #region Fields

      static int createID;
      Part part;
      string partleader;

      #endregion

      #region Constructor

      public DoorFrame4S_RHR()
      {
         m_subAssemblyID = Guid.NewGuid();
         this.ModelID = "Sys3000-DoorFrame4S-RHR";
        
      }

      #endregion

      #region Error Handling

      System.Exception HardwareApplicationError(string description)
      {

         return new SystemException(description);
      }

      #endregion

      #region Methods

      //Bill of Material
      public override void Build()
      {

         partleader =  this.Parent.UnitID + "." + this.CreateID.ToString();

         #region Door-Frame

         // JambRight
         part = new Part(801, "JambR", this, 1, m_subAssemblyHieght);
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         // JambLeft
         part = new Part(801, "JambL", this, 1, m_subAssemblyHieght);
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "M-Hinges # 655";
         
         m_parts.Add(part);

         // Head
         part = new Part(801, "Head", this, 1, m_subAssemblyWidth );
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

        //Threshold/Sill
         part = new Part(801, "Threshold/Sill", this, 1, m_subAssemblyWidth);
         part.PartGroupType = "Frame-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


        
         #endregion

         #region HardWare Logic

         // Assembly Braces
         part = new Part(1114, "Assembly Braces", this, 4, 0.0m);
         part.PartGroupType = "Hardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         #endregion

         #region WeatherSeals

         //Door Bulb Seals
         decimal peri = m_subAssemblyHieght * 2.0m;
         peri += m_subAssemblyWidth ;
         part = new Part(1005, "Frame Bulb Seal", this, 1, peri);
         part.PartGroupType = "Seals-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         #endregion

            #region Labor


         part = new LPart("MetalHours", this, 10.0m, 80.0m);
         m_parts.Add(part);
         //1 Receive: 1 Handle: 1 Cut: 1 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

         part = new LPart("FinishHours", this, 4.0m, 80.0m);
         m_parts.Add(part);
          //2 SandLineGrain: 2 Finish




         #endregion

      }

         #region Helper Methods
      private int HingeCount(decimal HingeAxisLength)
      {
         int result = 0;

         if (HingeAxisLength < 84.0m)
         {
            result = 3;
         }
         else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength < 114.0m))
         {
            result = 4;
         }
         else if ((HingeAxisLength >= 114.0m) && (HingeAxisLength < 134.0m))
         {
            result = 5;
         }
         else if ((HingeAxisLength >= 134.0m) && (HingeAxisLength < 164.0m))
         {
            result = 6;
         }


         return result;
      }
      private void PickMultiPoint(decimal HingeAxisLength)
      {

         #region Top Extension Logic

         if (HingeAxisLength < 76.61m)
         {

            throw HardwareApplicationError("Multipoint Hinge System exceeds Minumum Size");
           

         }
         else if ((HingeAxisLength > 76.61m) && (HingeAxisLength <= 80.0m))
         {
            //Multipoint Set for 76.61 <<>> 80.00
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778611]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778611]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if ((HingeAxisLength > 80.0m) && (HingeAxisLength <= 83.0m))
         {

            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778615]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778615]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);


         }
         else if ((HingeAxisLength > 83.0m) && (HingeAxisLength <= 86.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778619]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778619]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }

         else if ((HingeAxisLength > 86.0m) && (HingeAxisLength <= 89.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778623]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778623]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }

         else if ((HingeAxisLength > 89.0m) && (HingeAxisLength <= 92.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778627]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778627]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if ((HingeAxisLength > 92.0m) && (HingeAxisLength <= 95.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778631]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778631]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if ((HingeAxisLength > 95.0m) && (HingeAxisLength <= 98.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778611]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778611]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if ((HingeAxisLength > 98.0m) && (HingeAxisLength <= 101.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778615]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778615]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if ((HingeAxisLength > 101.0m) && (HingeAxisLength <= 104.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778619]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778619]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if ((HingeAxisLength > 104.0m) && (HingeAxisLength <= 107.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778623]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778623]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if ((HingeAxisLength > 107.0m) && (HingeAxisLength <= 110.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778627]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778627]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if ((HingeAxisLength > 110.0m) && (HingeAxisLength <= 113.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778631]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778631]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if ((HingeAxisLength > 113.0m) && (HingeAxisLength <= 115.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778611]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778611]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if ((HingeAxisLength > 115.0m) && (HingeAxisLength <= 118.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778615]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778615]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }

         else if ((HingeAxisLength > 118.0m) && (HingeAxisLength <= 121.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778619]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778619]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if ((HingeAxisLength > 121.0m) && (HingeAxisLength <= 124.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778623]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778623]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if ((HingeAxisLength > 124.0m) && (HingeAxisLength <= 127.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778627]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778627]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if ((HingeAxisLength > 127.0m) && (HingeAxisLength <= 130.0m))
         {
            part = new Part(-1, "Top Extension", this, 1, 1.0m);

            part.PartGroupType = "Hardware-Parts";
            part.Source.MaterialDescription = "Hoppe Top Ext [8778631]";
            part.PartName = "Top Ext";
            part.PartLabel = "";
            part.Source.MaterialName = "Hoppe [8778631]";
            part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
            m_parts.Add(part);

         }
         else if (HingeAxisLength >130.0m)
         {
            throw HardwareApplicationError("Door Hieght Exceed Hardware Specs");


         }
         #endregion

         #region Middle Extension Logic
         if (HingeAxisLength > 76.61m)
         {

            if ((HingeAxisLength > 76.61m)&&(HingeAxisLength <= 95.0m))
            {
               part = new Part(-1, "Middle Extension", this, 1, 1.0m);

               part.PartGroupType = "Hardware-Parts";
               part.Source.MaterialDescription = "Hoppe Middle Ext [8778691]";
               part.PartName = "Mid Extension Low";
               part.PartLabel = "";
               part.Source.MaterialName = "Hoppe [8778691]";
               part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
               m_parts.Add(part);

            }
            else if ((HingeAxisLength > 90.0m)&&(HingeAxisLength <= 113.0m))
            {
               part = new Part(-1, "Middle Extension", this, 1, 1.0m);

               part.PartGroupType = "Hardware-Parts";
               part.Source.MaterialDescription = "Hoppe Middle Ext [8778695]";
               part.PartName = "Mid Extension Mid";
               part.PartLabel = "";
               part.Source.MaterialName = "Hoppe [8778695]";
               part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
               m_parts.Add(part);

            }
            else if ((HingeAxisLength > 113.0m)&&(HingeAxisLength <= 130.0m))
            {
               part = new Part(-1, "Middle Extension", this, 1, 1.0m);

               part.PartGroupType = "Hardware-Parts";
               part.Source.MaterialDescription = "Hoppe Middle Ext [8778699]";
               part.PartName = "Mid Extension Large";
               part.PartLabel = "";
               part.Source.MaterialName = "Hoppe [8778695]";
               part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
               m_parts.Add(part);

            }
         }
         #endregion


         part = new Part(-1, "Multipoint Gear", this, 1, 1.0m);

         part.PartGroupType = "Hardware-Parts";
         part.Source.MaterialDescription = "Hoppe Gear [8778343]";
         part.PartName = "Gear";
         part.PartLabel = "";
         part.Source.MaterialName = "Hoppe [8778343]";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


      }
      
         #endregion

      #endregion

   }
}