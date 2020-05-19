using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.EuroBox
{
   [Serializable()]
    public class EuroBase : FrameWorks.SubAssemblyBase
    {
       public EuroBase() {}

        public override string ToString()
        {
            return this.Name;
        }

        public override void Build()
        {

            FrameWorks.Part part;

            #region Case

            // Left Side
            part = new Part(2878, "LSide", this, 1, this.SubAssemblyHieght, SubAssemblyDepth);
            part.PartThick = 0.75m;
            part.PartGroupType = "Case";
            this.Parts.Add(part);

            // Right Side
            part = new Part(2878, "RSide", this, 1, this.SubAssemblyHieght, SubAssemblyDepth);
            part.PartThick = 0.75m;
            part.PartGroupType = "Case";
            this.Parts.Add(part);

            // Bottom
            part = new Part(2878, "Bottom ", this, 1, this.SubAssemblyWidth - 1.5m, SubAssemblyDepth);
            part.PartThick = 0.75m;
            part.PartGroupType = "Case";
            this.Parts.Add(part);
            //Top
            part = new Part(2878, "Top", this, 1, this.SubAssemblyWidth - 1.5m, SubAssemblyDepth);
            part.PartThick = 0.75m;
            part.PartGroupType = "Case";
            this.Parts.Add(part);

            part = new Part(2878, "Nailers", this, 2, 4.0m, this.SubAssemblyWidth - 1.5m);
            part.PartThick = 0.75m;
            part.PartGroupType = "Case";
            this.Parts.Add(part);
            // Back
            part = new Part(2880, "Back", this, 1, this.SubAssemblyHieght - 1.0m);
            part.PartWidth = this.SubAssemblyWidth - 1.0m;
            part.PartThick = 0.25m;
            part.PartGroupType = "Case";
            this.Parts.Add(part);

            // Pounds test
            part = new Part(3049, "Nailer", this,2, 2.0m, this.SubAssemblyWidth - 1.5m);
            part.PartThick = 0.75m;
            part.PartGroupType = "Case";
            this.Parts.Add(part);

            // Test
            part = new Part(795, "Extrusion", this, 1, this.SubAssemblyHieght - 1.0m);
            part.PartWidth = this.SubAssemblyWidth - 1.0m;
            part.PartThick = 1.25m;
            part.PartGroupType = "Case";
            this.Parts.Add(part);
            // Glass Door
            part = new Part(3122, "Glass Door", this, 1, this.SubAssemblyHieght );
            part.PartWidth = this.SubAssemblyWidth ;
            part.PartThick = .625m;
            part.PartGroupType = "Glass";
            this.Parts.Add(part);


            this.Parts.Add(new Part(2893, "21-Runner", this, 1, 0.0m));

            #endregion

            #region Labor

            part = new LPart("Drafting", this, 1.5m, 85.0m);
            part.UOM = 11;
            this.Parts.Add(part);

            #endregion

            //refresh internals
            foreach (FrameWorks.Part p in this.Parts)
            {
                // needed to tickle the cost forcing calculation
                decimal d = p.Area;
                m_calculatedCost += p.CalculatedCost;
            }

        }
    }

   


}