using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Service;
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

            FrameWorks.Component Component;
            #region Case

            // Left Side
            Component = new Component(2878, "LSide", this, 1, this.SubAssemblyHieght, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);

            // Right Side
            Component = new Component(2878, "RSide", this, 1, this.SubAssemblyHieght, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);

            // Bottom
            Component = new Component(2878, "Bottom ", this, 1, this.SubAssemblyWidth - 1.5m, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);
            //Top
            Component = new Component(2878, "Top", this, 1, this.SubAssemblyWidth - 1.5m, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);
            // Back
            Component = new Component(2880, "Back", this, 1, this.SubAssemblyHieght - 1.0m);
            Component.ComponentWidth = this.SubAssemblyWidth - 1.0m;
            Component.ComponentThick = 0.25m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);

            // Test
            Component = new Component(795, "Extrusion", this, 1, this.SubAssemblyHieght - 1.0m);
            Component.ComponentWidth = this.SubAssemblyWidth - 1.0m;
            Component.ComponentThick = 1.25m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);


            this.Components.Add(new Component(2893, "21-Runner", this, 1, 22.0m));

            #endregion

            #region Labor

            Component = new LComponent("Drafting", this, 1.5m, 85.0m);
            this.Components.Add(Component);
            #endregion

            foreach (FrameWorks.Component p in this.Components)
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

            FrameWorks.Component Component;
            #region Case

            // Left Side
            Component = new Component(2878, "LSide", this, 1, this.SubAssemblyHieght, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);

            // Right Side
            Component = new Component(2878, "RSide", this, 1, this.SubAssemblyHieght, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);

            // Bottom
            Component = new Component(2878, "Bottom ", this, 1, this.SubAssemblyWidth - 1.5m, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);
            //Top
            Component = new Component(2878, "Top", this, 1, this.SubAssemblyWidth - 1.5m, SubAssemblyDepth);
            Component.ComponentThick = 0.75m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);
            // Back
            Component = new Component(2880, "Back", this, 1, this.SubAssemblyHieght - 1.0m);
            Component.ComponentWidth = this.SubAssemblyWidth - 1.0m;
            Component.ComponentThick = 0.25m;
            Component.ComponentGroupType = "Case";
            this.Components.Add(Component);


            this.Components.Add(new Component(2893, "21-Runner", this, 1, 22.0m));

            #endregion

            #region Labor

            Component = new LComponent("Drafting", this, 1.5m, 85.0m);
            this.Components.Add(Component);
            #endregion

            foreach (FrameWorks.Component p in this.Components)
            {
                // needed to tickle the cost forcing calculation
                decimal d = p.Area;
                m_calculatedCost += p.CalculatedCost;
            }

        }
    }



}