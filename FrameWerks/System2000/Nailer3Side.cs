using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWorks.Makes.System2000
{
    
    public class Nailer3Side : SubAssemblyBase
    {

        #region Fields

        static int createID;

        #endregion

        #region Constructor

        public Nailer3Side()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys2000-Nailer3Side";
        }

        #endregion

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Part part;
          

            #region Nail Fin Perimeter


            // Top Nailer ^^
            part = new Part(922, "Top Nail Fin", this, 1, m_subAssemblyWidth + (1.2812m * 2.0m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";

            m_parts.Add(part);

            // Left Nailer <<--
            part = new Part(922, "Left Nail Fin", this, 1, m_subAssemblyHieght + (1.2812m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
            m_parts.Add(part);

            // Right Nailer -->>
            part = new Part(922, "Right Nail Fin", this, 1, m_subAssemblyHieght + (1.2812m));
            part.PartGroupType = "Nailer-Parts";
            part.PartLabel = "";
            m_parts.Add(part);



            #endregion





        }



        #endregion


    }
}
