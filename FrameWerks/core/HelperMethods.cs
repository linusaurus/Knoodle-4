#region Copyright (c) 2120 WeaselWare Software
/************************************************************************************
'
' Copyright  2020 WeaselWare Software 
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
' Portions Copyright 2005 WeaselWare Software
'
' 2. Altered source versions must be plainly marked as such, and must not be 
' misrepresented as being the original software.
'
' 3. This notice may not be removed or altered from any source distribution.
'
'***********************************************************************************/
#endregion

#region Code Info
//
// WeaselWare 2006
// R Young  April-5-2006
// FrameWorks Project
// Helper Classes
#endregion

using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic ;
using System.Diagnostics;

namespace FrameWorks
{

            public enum TrackConfiguration{
                
            Telescoping,
            BiComponenting

            }
    
    public class BridgeGenie
   {

        public List<int> Clips = new List<int>();

        public  List<decimal> result = new List<decimal>();
        public BridgeGenie(decimal DoorThickness)
        {
            if (DoorThickness == 2.25m)
            {

                result.Add(2.625m);
                result.Add(4.8125m);
                result.Add(7.6875m);
                result.Add(10.5625m);
                result.Add(13.4375m);
                result.Add(16.3125m);

                Clips.Add(4233);
                Clips.Add(4233);
                Clips.Add(4233);
                Clips.Add(4233);
                Clips.Add(4233);
                Clips.Add(4233);


            }

            else if (DoorThickness == 2.5m)
            {

                result.Add(2.625m);
                result.Add(5.0625m);
                result.Add(8.1875m);
                result.Add(11.3125m);
                result.Add(14.3750m);
                result.Add(17.4375m);

                Clips.Add(4233);
                Clips.Add(4233);
                Clips.Add(4233);
                Clips.Add(4233);
                Clips.Add(4233);
                Clips.Add(4233);
            }


            else if (DoorThickness == 1.5m)
            {

                result.Add(4.00m);
                result.Add(4.5625m);
                result.Add(6.50m);
                result.Add(9.375m);
                result.Add(12.25m);
                result.Add(15.125m);

                // Just add the proper Component-numbers for the clips
                Clips.Add(4233);
                Clips.Add(4233);
                Clips.Add(4233);
                Clips.Add(4233);
                Clips.Add(4233);
                Clips.Add(4233);

            }



        }
      
         
   }

public class Functions
{
   //public Dim(decimal width, decimal length, decimal thick)
   //{
   //   this.W = width;
   //   this.L = length;
   //   this.T = thick;
   //}


   //public decimal W;
   //public decimal L;
   //public decimal T;
   //public decimal Area
   ////{

   //   get
   //   {
   //      return Math.Round(((this.W * this.L)/144m), 2, MidpointRounding.AwayFromZero);
   //   }
   //}

   #region Error Handling

   System.Exception HardwareApplicationError(string description)
   {

      return new SystemException(description);
   }

   #endregion

   public static int BearingCountByWeight(decimal lbs)
   {
       int result = 0;
       
       // Bearings #4215

       int pounds = Convert.ToInt32(lbs);
       int bearingcount = 4;
       int extraPounds = pounds - 160;
       int extraSetOfBearing = extraPounds / 80;
       bearingcount += (2 * extraSetOfBearing);
       // Test for remaing pounds less than 80
       if ((extraPounds % 80) > 0)
       { bearingcount += 2; }
          
 
       result = bearingcount;
       return result;
   }


   //ALUMINUM
   public static int HingeCountAlum(decimal HingeAxisLength)
   {
      int result = 0;

      if ((HingeAxisLength >= 42.0m) && (HingeAxisLength < 80.0m))
      {
         result = 2;
      }
      else if ((HingeAxisLength >= 80.0m) && (HingeAxisLength < 84.0m))
      {
         result = 3;
      }
      else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength <= 120.0m))
      {
         result = 4;
      }
      else if (HingeAxisLength > 120.0m)
      {
         result = 5;

      }

      return result;
   }


   //BRONZE
   public static int HingeCount2(decimal HingeAxisLength)
   {
       int result = 0;

       if ((HingeAxisLength >= 42.0m) && (HingeAxisLength < 80.0m))
       {
           result = 3;
       }
       else if ((HingeAxisLength >= 80.0m) && (HingeAxisLength < 84.0m))
       {
           result = 4;
       }
       else if ((HingeAxisLength >= 84.0m) && (HingeAxisLength <= 120.0m))
       {
           result = 5;
       }
       else if (HingeAxisLength > 120.0m)
       {
           result = 6;

       }

       return result;
   }


   public static double RadiusOfArch(double sagitta, double widthofArch)

   {

       double result = 0.0;
       double h = Convert.ToDouble(widthofArch);
       double p = Double.Parse("2");

       result = (sagitta / 2.0) + Math.Pow(h, p) / (8.0 * sagitta);

       return result;

   }


   public static double ArcAngle(double chord, double sagitta)
   {

       double result = 0.0;
       double oposite = chord / 2.0;
       double hypotenuse = RadiusOfArch(sagitta, chord );
       double sine =  oposite / hypotenuse;
       result = Math.Asin(sine);
       result = (result *  180)/ Math.PI;
       result = result * 2;
       return result;

   }


   public static double ArcAngleRad(double chord, double sagitta)
   {

       double result = 0.0;
       double oposite = chord / 2.0;
       double hypotenuse = RadiusOfArch(sagitta, chord);
       double sine = oposite / hypotenuse;
       result = Math.Asin(sine);
       result = result * 2;
       return result;

   }


   public static decimal ArcLength(double chord, double sagitta)

   {

       decimal result = 0.0m;
       double angle = ArcAngleRad(chord, sagitta);
       double radius = RadiusOfArch(sagitta, chord);
       double hold = angle * radius;
      
       result = Math.Round(Convert.ToDecimal(hold),4);
   
       return result;

   }


   public static decimal RadArc(double radius, double angle)
   {

       decimal result = 0.0m;
       double radians = angle * (Math.PI / 180);
       result = Convert.ToDecimal(radius * radians); 


    return result;

   }


   public static int OperatorSeries23(decimal UnitWidth, string handing )
   {
       int result = 0;

       if (UnitWidth < 16.8201m  || UnitWidth < 40.0m)
       {
           if (UnitWidth >= 16.8201m  && UnitWidth < 18.8201m)
           {
               if (string.Equals(handing,"RH"))
               {
                    result = 2780;
               }
               else if (string.Equals(handing,"LH"))
               {
                   result = 2774;
               }
               
           }
           else if (UnitWidth >= 18.8201m && UnitWidth < 22.8201m)
           {
               if (string.Equals(handing, "RH"))
               {
                   result = 2781;
               }
               else if (string.Equals(handing , "LH"))
               {
                   result = 2775;
               } 
           }
           else if (UnitWidth >= 22.8201m && UnitWidth < 40.0m)
           {
               if (string.Equals(handing , "RH"))
               {
                   result = 2782;
               }
               else if (string.Equals(handing ,"LH"))
               {
                   result = 2776;
               }
           }


       }
       else
       {
           result = 911;
       }

       return result;
   }


   public static int TrackSeries23(decimal UnitWidth)
   {
       int result = 0;

       if (UnitWidth > 16.8201m && UnitWidth < 40.0m)
       {

       if (UnitWidth >= 16.8201m && UnitWidth < 18.8201m)

       {
           
          result = 2630;

       }
           else if (UnitWidth >= 18.8201m && UnitWidth <= 40.0m)
           {
              
                   result = 2745;
               
           }


       }
       else
       {
           result = 911;
       }

       return result;
   }


   public static int[] OperatorAwningPivotShoeSeries22 (decimal UnitWidth )
    {
        int[] result = new int[3];
        result[0] = 0;
        result[1] = 0;
        result[2] = 0;

        if (UnitWidth > 16.124m && UnitWidth < 60.0m)
        {
            if (UnitWidth > 16.124m && UnitWidth <= 27.0m)
                {
                    result[0] = 990;
                    result[1] = 3134;
                    result[2] = 3134;
                }
                    
                
                else if (UnitWidth > 27.0m && UnitWidth <= 29.0m)
                {
                    result[0] = 3039;
                    result[1] = 3139;
                    result[2] = 3139;
                }

                else if (UnitWidth > 29.0m && UnitWidth <= 60.0m)
                {
                    result[0] = 3038;
                    result[1] = 3120;
                    result[2] = 3120;
                }


                else
                {
                    result[0] = 911;
                    result[1] = 911;
                    result[2] = 911;
                }


        }
        else
        {
            result[0] = 911;
            result[1] = 911;
            result[2] = 911;
        }
        return result;
                
    }

            
   public static string StopWeepMachining(decimal stoplength)
    {

        decimal rightLocation = stoplength - 2.0m;
        string stringOut = string.Empty;
        // stoplength is LESS THEN 40 inches
        if (stoplength < 40.0m)
        {
            
            stringOut =  "M-Weeps-2.0-" + rightLocation.ToString()+ "OC" ;
        }
        else if ((stoplength >= 40.0m ) && (stoplength < 64.0m ) )
        {
            decimal midslot = stoplength / 2.0m;
            stringOut  = "M-Weeps-2.0-" +  midslot + "-" + rightLocation.ToString();
        }
        else if ((stoplength >=  64.0m) && (stoplength < 88.0m))
        {
            decimal midslot1 = Math.Round(((stoplength - 4.0m) / 3.0m ) + 2.0m, 4);
            decimal midslot2 = Math.Round((midslot1 * 2.0m ) + 2.0m, 4);
            stringOut = "M-Weeps-2.0-" + midslot1.ToString()  + "-" + midslot2.ToString() + "-" + rightLocation.ToString();
        }
        else if ((stoplength >= 88.0m) && (stoplength < 112.0m))
        {
            decimal midslot1 = Math.Round(((stoplength - 4.0m ) / 4.0m) + 2.0m,4);
            decimal midslot2 = Math.Round((midslot1 * 2.0m ) + 2.0m, 4);
            decimal midslot3 = Math.Round((midslot1 * 3.0m ) + 2.0m, 4);
            stringOut = "M-Weeps-2.0-" + midslot1.ToString() + "-" + midslot2.ToString() + "-" +  midslot3.ToString()+ "-" + rightLocation.ToString();
        }






        return stringOut;
    }


   public static int AwningHinge(decimal AwningHieght, char handing)
   {
      int HingeComponentNumber = 0;
      if ((handing == 'L') || (handing =='l'))
      {

         if (AwningHieght < 15.75m)
         {

            HingeComponentNumber = 997;
            //(1013);   
            //"Hinge Right";
         }
         //14 Inch
         if (AwningHieght > 15.75m && AwningHieght < 19.75m)
         {
            // Left
            HingeComponentNumber = 710;
            //(710);
            //"Hinge Right";

         }
         //18 Inch
         else if (AwningHieght < 19.75m && AwningHieght < 23.75m)
         {
            //Left 18
            HingeComponentNumber = 1003;


            //(1004);
            //"Hinge Right";
         }
         else if (AwningHieght > 23.75m)
         {
            //Left
            HingeComponentNumber =1013;
            //
            //1014;
            //"Hinge Right";
         }

      }
      else if ((handing == 'R') || (handing =='r'))
      {

         if (AwningHieght < 15.75m)
         {

            HingeComponentNumber = 1000;

         }
         //14 Inch
         if (AwningHieght > 15.75m && AwningHieght < 19.75m)
         {
            // Left
            HingeComponentNumber = 709;
            //(710);
            //"Hinge Right";

         }
         //18 Inch
         else if (AwningHieght > 19.75m && AwningHieght < 23.75m)
         {
            //Right 18
            HingeComponentNumber = 1004;
         }
         else if (AwningHieght > 23.75m)
         {
            //Right
            HingeComponentNumber =1014;

         }

      }


      return HingeComponentNumber;
   }
   

   public static decimal PanelWieghtS3000(decimal w, decimal h)
   {
      decimal result = decimal.Zero;
      decimal peri = decimal.Zero;
      decimal area = decimal.Zero;
      
      peri = ((w * 2.0m) + (h * 2.0m)) /12.0m;
      area = Math.Round(((w - 3.25m) * (h - 3.25m))/144 , 2);
      result = (area * 5.0m) + (peri * 5.0m);

      return System.Math.Round(result);
   
   }


   public static decimal PanelWieghtS2000(decimal w, decimal h)
   {
       decimal result = decimal.Zero;
       decimal peri = decimal.Zero;
       decimal area = decimal.Zero;
       decimal glasssqft = 6.6m;

       peri = ((w * 2.0m) + (h * 2.0m)) / 12.0m;
       area = Math.Round(((w - 3.25m) * (h - 3.25m)) / 144, 2);
       result = (area * glasssqft) + (peri * 1.05m);

       return System.Math.Round(result);

   }


   public static decimal PanelWieghtS4000(decimal w, decimal h)
   {
      decimal result = decimal.Zero;
    
      decimal area = decimal.Zero;

      area = Math.Round(((w ) * (h ))/144, 2);
      result = (area * 5.0m) ;

      return System.Math.Round(result);

  }


   public static decimal PanelWieghtS4000(decimal w, decimal h, decimal sqftWieght)
    {
        decimal result = decimal.Zero;

        decimal area = decimal.Zero;

        area = Math.Round(((w) * (h)) / 144, 2);
        result = (area * sqftWieght);

        return System.Math.Round(result);

    }


   public static int AwningHinge1000(decimal AwningHieght, char handing)
   {
      int HingeComponentNumber = 0;
      if ((handing == 'L') || (handing =='l'))
      {

         if (AwningHieght < 15.75m)
         {

            HingeComponentNumber = 997;
            //(1013);   
            //"Hinge Right";
         }
         //14 Inch
         if (AwningHieght > 15.75m && AwningHieght < 19.75m)
         {
            // Left
            HingeComponentNumber = 710;
            //(710);
            //"Hinge Right";

         }
         //18 Inch
         else if (AwningHieght < 19.75m && AwningHieght < 23.75m)
         {
            //Left 18
            HingeComponentNumber = 1003;


            //(1004);
            //"Hinge Right";
         }
         else if (AwningHieght > 23.75m)
         {
            //Left
            HingeComponentNumber =1013;
            //
            //1014;
            //"Hinge Right";
         }

      }
      else if ((handing == 'R') || (handing =='r'))
      {

         if (AwningHieght < 15.75m)
         {

            HingeComponentNumber = 1000;

         }
         //14 Inch
         if (AwningHieght > 15.75m && AwningHieght < 19.75m)
         {
            // Left
            HingeComponentNumber = 709;
            //(710);
            //"Hinge Right";

         }
         //18 Inch
         else if (AwningHieght > 19.75m && AwningHieght < 23.75m)
         {
            //Right 18
            HingeComponentNumber = 1004;
         }
         else if (AwningHieght > 23.75m)
         {
            //Right
            HingeComponentNumber =1014;

         }

      }


      return HingeComponentNumber;
   }


   public static int S3000AwningHinge(decimal AwningHieght)
   {
      int HingeComponentNumber = 0;

         if (AwningHieght < 9.4999m) 
         {
           System.Exception e = new Exception("Range of Hinge is not workable") ;
           
           throw e;
         }
          //10 Inch
         if ((AwningHieght > 9.4999m) && (AwningHieght <= 12.4999m))
         {
            HingeComponentNumber = 1741;         
         }
         //12 Inch
         else if ((AwningHieght > 12.5m) && (AwningHieght <= 24.9999m))
         {       
            HingeComponentNumber = 1742;        
         }
         //16 Inch
         else if ((AwningHieght > 25.0m) && (AwningHieght <= 33.9999m))
         {
            HingeComponentNumber = 1743;
         }
         //20 Inch
         else if ((AwningHieght > 34.0m) && (AwningHieght <= 52.0m))
         {
            HingeComponentNumber = 1744;
            //}
            //24 Inch ***DISCONTINUED HINGE ***
             //***DISCONTINUED HINGE *** else if ((AwningHieght > 40.0m) && (AwningHieght <= 52.0m))
            // {
           // HingeComponentNumber = 1745;//***DISCONTINUED HINGE ***
         }
         //28 Inch
         else if ((AwningHieght > 50.0m) && (AwningHieght <= 80.0m))
         {
            HingeComponentNumber = 1746;
         }
          //Anything bigger
         else if (AwningHieght > 80.0m) 
         {
            HingeComponentNumber = 1746;
         }
        
        

     
      

      


      return HingeComponentNumber;
   }


   public static int NextBomID()
   {
      int returnvalue = 1;
      SqlConnection cn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BOM;Data Source=ws-1009");
      SqlCommand cmd = cn.CreateCommand();
      cmd.CommandText = "GetIndex";
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.Parameters.Add("@NextBomID",SqlDbType.Int );
      cmd.Parameters["@NextBomID"].Direction = ParameterDirection.Output;
      
      cn.Open();
      cmd.ExecuteNonQuery();
      returnvalue = (int)cmd.Parameters["@NextBomID"].Value;
      cn.Close();
      return returnvalue;
      
      ;
   
   }  
   public static int gCounterTick;


   public static int[]S4000Hinges(decimal wieght)
   {
      int[] hingeset = new int[2];
      
      if(wieght <= 7.0m)
      {
               //hingeset[0] = 997;
               //hingeset[1] = 1000;
      }
      else if ((wieght > 7.0m) && (wieght <= 20.0m))
      {
             //hingeset[0] = 709;
             //hingeset[1] = 710;
      
      }
      else if ((wieght > 20.0m) && (wieght <= 38.0m))
      {
         hingeset[0] = 1003;
         hingeset[1] = 1004;

      }
      else if ((wieght > 38.0m) && (wieght <= 50.0m))
      {
         hingeset[0] = 1013;
         hingeset[1] = 1014;

      }
      else if ((wieght > 50.0m) && (wieght <= 61.0m))
      {
         hingeset[0] = 684;
         hingeset[1] = 685;

      }
      else if (wieght > 61.0m)
      {
         //throw new System.Exception("Awning panel wieght exceeds hinge capability");
         
      }

      return hingeset;
   
   }
   

   public static int S4000TieBar(decimal sashhieght)
   {
      int tiebar = 1;

      
      if ((sashhieght >= 45.75m) && (sashhieght < 61.0m))
      {
         tiebar = 1830;
      }
      else if ((sashhieght >= 61.0m) && (sashhieght < 69.75m))
      {
         tiebar = 880;
      }
      else if ((sashhieght >= 69.75m) && (sashhieght < 77.0m))
      {
         tiebar = 1831;
      }
      else if ((sashhieght >= 77.0m) && (sashhieght < 86.625m))
      {
         tiebar = 1832;
      }
      else if ((sashhieght >= 86.625m) && (sashhieght < 93.75m))
      {
         tiebar = 1833;
      }
      else if ((sashhieght >= 93.75m) && (sashhieght < 102.0m))
      {
         tiebar = 1834;
      }
      else if (sashhieght > 102.0m) 
      {
         tiebar = 1835;
      }


      return tiebar;

   }


   public static decimal S2000TieBar(decimal sashhieght)
   {

       decimal tiebar = decimal.Zero;

       if (sashhieght > 48.0m)
       {
         tiebar =  (sashhieght / 2.0m) + 1.0m;
 
       }
      
           //return zero;
     
      
       return tiebar;

   }


   public static string TieBarLockCenter(decimal  Framehieght)
   {

       string result = "";

       // Sanity Check -----
       if ((Framehieght > 12.0m) && (Framehieght < 96.0m))
       {

                //tiebar = 2768;

           if ((Framehieght >= 48.0m) && (Framehieght < 59.9999m))
           {
               decimal firstcenter = (Framehieght / 2.0m)- 24.0m; 
               decimal secondcenter= firstcenter + 24.0m;
               result = "Lock Centers " + firstcenter.ToString()+ ", "+ secondcenter.ToString();
            }
           else if ((Framehieght >= 60.0m) && (Framehieght < 71.9999m))
           {
               //tiebar = 2769;

               decimal firstcenter = (Framehieght / 2.0m) - 30.0m;
               decimal secondcenter = firstcenter + 30.0m;
               result = "Lock Centers " + firstcenter.ToString() + ", " + secondcenter.ToString();
           }
           else if ((Framehieght >= 72.0m) && (Framehieght < 83.9999m))
           {
               //tiebar = 2770;

               decimal firstcenter = (Framehieght / 2.0m) - 36.0m;
               decimal secondcenter = firstcenter + 36.0m;
               result = "Lock Centers " + firstcenter.ToString() + ", " + secondcenter.ToString();
           }
           else if ((Framehieght >= 84.0m) && (Framehieght < 96.0m))
           {
               //tiebar = 2771;

               decimal firstcenter = (Framehieght / 2.0m) - 42.0m;
               decimal secondcenter = firstcenter + 42.0m;
               result = "Lock Centers " + firstcenter.ToString() + ", " + secondcenter.ToString();
           }

       }
       else
       {
           //return error;
       }

       return result;

   }


   public static int S4000PanelClipCount(decimal w,decimal h)
   {
   
      int result = 0;
      w -= (1.125m * 2.0m);
      h -= (1.125m * 2.0m);
      result += Convert.ToInt32(((w * 2)/12));
      result += Convert.ToInt32(((h * 2)/12));

      w -= (3.0m * 2.0m);
      h -= (3.0m * 2.0m);
      result += Convert.ToInt32(((w * 2)/12));
      result += Convert.ToInt32(((h * 2)/12));
      
      return result;

   }


   public static int GetComponentToWrite(List<AssemblyBase> units)
   {
      int value = 0;
      foreach (AssemblyBase unit in units)
      {
     
         foreach(SubAssemblyBase _sub in unit.SubAssemblies)
         {
               foreach(Component _Component in _sub.Components)
               {
                  value++;
               }
         }
         
      }
      return value;
         
  }
  

   public static decimal Perimeter(decimal width,decimal hieght)
   {
     decimal result = decimal.Zero;
     result = (width * 2.0m)+ (hieght * 2.0m);
     return result;
   }


   public static decimal Perimeter(decimal width, decimal hieght,decimal offset)
   {
      decimal result = decimal.Zero;
      result = ((width- offset) * 2.0m)+ ((hieght - offset) * 2.0m);
      return result;
   }


   public static decimal Perimeter(decimal width, decimal hieght,bool IsThreeSided)
    {
        decimal result = decimal.Zero;
        result = ((width  * 2.0m) + (hieght  * 2.0m) );
        result -= width;
        return result;
    }


   public static decimal MiteredPerimeter(decimal width, decimal hieght,decimal depth, decimal offset)
   {
      decimal result = decimal.Zero;
      
      result = ((width - offset) * 2.0m);
      result += ((hieght - offset)* 2.0m);
      
      result += ((depth - offset) * 2.0m);
      return result;
   }


   public static decimal MiteredFullPerimeter(decimal width, decimal hieght, decimal depth, decimal offset)
   {
      decimal result = decimal.Zero;

      result = ((width - offset) * 2.0m);
      result += ((hieght - offset)* 2.0m);

      result += ((depth - offset) * 4.0m);
      return result;
   }


   public static int HingeCount(decimal HingeAxisLength)
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
}
}