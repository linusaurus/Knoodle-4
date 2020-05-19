using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;

namespace FrameWerks.Utils
{

    public class Machining
    {
        public Machining()
        {
           
        }


      public static string Machine5x5HingePrep(decimal verticalPlane ,decimal topOffSet)
      {
          int counter;
          StringBuilder sb = new StringBuilder();
          decimal hingeCount = FrameWorks.Functions.HingeCount(verticalPlane);
          counter = System.Convert.ToInt32(hingeCount);

          decimal AdjustedHingeSpace = verticalPlane - (2.0m * 6.5m)-(topOffSet);
          decimal step = AdjustedHingeSpace  / (hingeCount- 1.0m);

          decimal firstStep = 6.5m + topOffSet; 
          for (int i = 1; i <= counter; i++)
		    {
              
              sb.Append(firstStep.ToString() + ";");
              firstStep += step;
			}

            return sb.ToString();


      }
       
        


      
    }
}
