using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWorks
{
   
   public class RectSize
   {
      public decimal W;
      public decimal H;
   }
   
   
   
   public class PartsHelper
   {
     
   

      public static List<Part> TrackMaker(SubAssemblyBase subassembly, int PanelCount,int positions, TrackConfiguration configuration)
       {
            List<Part> result = new List<Part>();

            switch (configuration)
	        {
		    case TrackConfiguration.Telescoping:
            
            #region Track Blades
                    
            for (int i = 0; i < PanelCount; i++)
			{
            
            Part p = new Part(3345,"Blade-" + i.ToString(),subassembly,1,subassembly.SubAssemblyWidth + 3.0m);
            result.Add(p);
			}
                    
                    
            #endregion

           

            break;

            case TrackConfiguration.BiParting:
            break;

            default:
            break;
	        }


            return result;
       }


      
   }
}
