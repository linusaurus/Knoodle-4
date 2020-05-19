using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrameWorks;

namespace FrameWorks.Makes.EuroBox
{
    [Serializable]
    public class FrameCab : FrameWorks.SubAssemblyBase
    {
        public FrameCab() { }

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
            // Back
            part = new Part(2880, "Back", this, 1, this.SubAssemblyHieght - 1.0m);
            part.PartWidth = this.SubAssemblyWidth - 1.0m;
            part.PartThick = 0.25m;
            part.PartGroupType = "Case";
            this.Parts.Add(part);

            // Test
            part = new Part(795, "Extrusion", this, 1, this.SubAssemblyHieght - 1.0m);
            part.PartWidth = this.SubAssemblyWidth - 1.0m;
            part.PartThick = 1.25m;
            part.PartGroupType = "Case";
            this.Parts.Add(part);


            this.Parts.Add(new Part(2893, "21-Runner", this, 1, 22.0m));

            #endregion

            #region Labor

            part = new LPart("Drafting", this, 1.5m, 85.0m);
            this.Parts.Add(part);
            #endregion

            foreach (FrameWorks.Part p in this.Parts)
            {
                // needed to tickle the cost forcing calculation
                decimal d = p.Area;
                m_calculatedCost += p.CalculatedCost;
            }

        }
    }
    [Serializable]
    public class EuroCab : FrameWorks.SubAssemblyBase
    {
        public EuroCab() { }

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
            // Back
            part = new Part(2880, "Back", this, 1, this.SubAssemblyHieght - 1.0m);
            part.PartWidth = this.SubAssemblyWidth - 1.0m;
            part.PartThick = 0.25m;
            part.PartGroupType = "Case";
            this.Parts.Add(part);


            this.Parts.Add(new Part(2893, "21-Runner", this, 1, 22.0m));

            #endregion

            #region Labor

            part = new LPart("Drafting", this, 1.5m, 85.0m);
            this.Parts.Add(part);
            #endregion

            foreach (FrameWorks.Part p in this.Parts)
            {
                // needed to tickle the cost forcing calculation
                decimal d = p.Area;
                m_calculatedCost += p.CalculatedCost;
            }

        }
    }



}