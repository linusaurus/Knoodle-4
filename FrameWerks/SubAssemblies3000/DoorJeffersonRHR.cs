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
   
   public class DoorJeffersonRHR : SubAssemblyBase
   {

      #region Fields

      static int createID;
      Part part;
      string partleader;
      private JeffersonCalc m_jeffersonModel;

      #endregion

      #region Constructor

      public DoorJeffersonRHR()
      {
         m_subAssemblyID = Guid.NewGuid();
         this.ModelID = "Sys3000-DoorJeffersonRHR";

      }

      #endregion



      #region Methods

      //Bill of Material
      public override void Build()
      {

         partleader =  this.Parent.UnitID + "." + this.CreateID.ToString();
         m_jeffersonModel = new JeffersonCalc(m_subAssemblyHieght);

         #region Panel-Frame

         // StileRight
         part = new Part(1167, "StileR", this, 1, m_subAssemblyHieght);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         
       
         m_parts.Add(part);

         // StileLeft
         part = new Part(1167, "StileL", this, 1, m_subAssemblyHieght);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "M-655 Hinge";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // RailTop
         part = new Part(1167, "RailT", this, 1, m_subAssemblyWidth );
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // RailBottom
         part = new Part(1167, "RailB", this, 1, m_subAssemblyWidth );
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Check Rail
         part = new Part(1167, "Check rail", this, 1, m_subAssemblyWidth- (0.3125m * 2.0m));
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "Cut Fin";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Built Out Stile
         part = new Part(1167, "Stile Doubler", this, 1, m_jeffersonModel.BuildOutStile);
         part.PartGroupType = "Panel-Parts";
         part.PartLabel = "Miter Returned";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Handle Edge Return
         part = new Part(1167, "Doubler Return", this, 1, 2.064m);
         part.PartGroupType = "Panel-Parts";;
         part.PartLabel = "Mitre Return";
         
         m_parts.Add(part);


         #endregion

         #region Filler

         part = new Part(1816, "Filler-Top", this, 1, m_subAssemblyWidth + 0.25m);
         part.PartGroupType = "Filler-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         part = new Part(1816, "Filler-Bottom", this, 1, m_subAssemblyWidth + 0.25m);
         part.PartGroupType = "Filler-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         part = new Part(1816, "Filler-Left", this, 1, m_subAssemblyHieght  + 0.25m);
         part.PartGroupType = "Filler-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         part = new Part(1813, "Filler-Right", this, 1, m_subAssemblyHieght  + 0.25m);
         part.PartGroupType = "Filler-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         #endregion

         #region Stop


         
         // StopFrontRightUp
         part = new Part(809, "StopFrontRightUp", this, 1, m_jeffersonModel.UpperSection - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);



         // StopRearRightUp
         part = new Part(809, "StopRearRightUp", this, 1, m_jeffersonModel.UpperSection - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);



         // StopFrontLeftUp
         part = new Part(809, "StopFrontLeftUp", this, 1, m_jeffersonModel.UpperSection - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);



         // StopRearLeftUp
         part = new Part(809, "StopRearLeftUp", this, 1, m_jeffersonModel.UpperSection - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);



         // StopFrontTopUp
         part = new Part(809, "StopFrontTopUp", this, 1, m_subAssemblyWidth - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);



         // StopRearTopUp
         part = new Part(809, "StopRearTopUp", this, 1, m_subAssemblyWidth - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);



         // StopFrontTopLow
         part = new Part(809, "StopFrontTopLow", this, 1, m_subAssemblyWidth - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);



         // StopRearTopLow
         part = new Part(809, "StopRearTopLow", this, 1, m_subAssemblyWidth - (1.3125m * 2.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);



         // StopFrontBotLow
         part = new Part(809, "StopFrontBotLow", this, 1, m_subAssemblyWidth - (1.3125m * 3.0m));
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);



         // StopRearBotLow
         part = new Part(809, "StopRearBotLow", this, 1, (m_subAssemblyHieght - m_jeffersonModel.UpperSection) - 1.3125m);
         part.PartGroupType = "Stop-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);
 

         
         #endregion

         #region HardWare Logic

         PickMultiPoint(m_subAssemblyHieght);

         // Handle Edge Return
         part = new Part(655, "Hinges", this, HingeCount(m_subAssemblyHieght), 0.0m);
         part.PartGroupType = "Hardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);

         // Assembly Braces
         part = new Part(1117, "Assembly Braces", this, 8, 0.0m);
         part.PartGroupType = "Hardware-Parts";
         part.PartLabel = "";
         
         m_parts.Add(part);


         #endregion

         #region WeatherSeals

         //Door Bulb Seals
         part = new Part(1005, "Bulb Seal Door", this, 1, ((m_subAssemblyHieght * 2.0m)+ (m_subAssemblyWidth * 2.0m)));
         part.PartGroupType = "Seals-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Glazing Seal
         decimal peri = m_subAssemblyWidth - (1.3125m * 2.0m);
         peri += m_subAssemblyHieght  - (1.3125m * 2.0m);
         peri *= 2.0m;
         part = new Part(1008, "Glazing Seal", this, 1, peri);
         part.PartGroupType = "Seals-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);

         // Door Bottom Sweep
         part = new Part(1518, "Door Bottom Sweep", this, 1, m_subAssemblyWidth);
         part.PartGroupType = "Seals-Parts";
         part.PartLabel = "";
         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);



         #endregion

         #region Glass


         //Glass Panel
         part = new Part(-1);
         part.FunctionalName = "Door Upper Glass";
         part.PartGroupType = "Glass-Parts";
         part.Qnty = 1;
         part.Source.MaterialDescription = "1.25 Insulated Glass";
         part.PartName = "PartName";
         part.PartLabel = "Notched For Handle";
         part.Source.MaterialName = "1.25 IGU";
         part.ContainerAssembly = this;
         part.PartThick = 1.25m;
         part.PartWidth =  m_jeffersonModel.TopGlassHieght;
         part.PartLength = m_subAssemblyWidth -(1.6003m * 2.0m);
         //part.Source.UOM = (int)FrameWorks.UnitOfMeasure.Foot;

         part.PartIdentifier= partleader + "." + Convert.ToString(createID++);
         m_parts.Add(part);


         #endregion

      }

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


         if (HingeAxisLength < 76.61m)
         {

            //throw HardwareApplicationError("Multipoint Hinge System exceeds Minumum Size");


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
            // throw HardwareApplicationError("Door Hieght Exceed Hardware Specs");


         }


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

   }
}