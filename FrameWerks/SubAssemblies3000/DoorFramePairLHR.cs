using System;
using System.Collections.Generic;
using System.Text;

namespace FrameWorks.Makes.System3000
{
    
    public class DoorFramePairLHR : SubAssemblyBase
    {

        #region Fields


        Part part;
        string partleader;

        #endregion

        #region Constructor

        public DoorFramePairLHR()
        {
            m_subAssemblyID = Guid.NewGuid();
            this.ModelID = "Sys3000-DoorFramePairLHR";

        }

        #endregion

        #region Error Handling

        System.Exception HardwareApplicationError(string description)
        {

            return new SystemException(description);
        }

        #endregion

        //Methods
        public override void Build()
        {

            partleader = this.Parent.UnitID + "." + this.CreateID.ToString();


            #region Door-Frame

            // JambRight <<--
            part = new Part(801, "JambR", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "M-Hinge # 1775";
            
            m_parts.Add(part);

            // JambLeft -->>
            part = new Part(801, "JambL", this, 1, m_subAssemblyHieght);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "M-Hinge # 1775";
            
            m_parts.Add(part);

            // Head ^^
            part = new Part(801, "Head", this, 1, m_subAssemblyWidth);
            part.PartGroupType = "Frame-Parts";
            part.PartLabel = "M-Shoot Strike # 1986";
            
            m_parts.Add(part);





            #endregion

            #region HardWare


            // Assembly Braces

            part = new Part(1117, "Assembly Braces", this, 4, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // PVC ASTRIGAL

            part = new Part(1901, "PVC Astrigal", this, 1, m_subAssemblyHieght - 1.625m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // BRONZE ASTRIGAL

            part = new Part(2763, "Bronze Astrigal", this, 1, m_subAssemblyHieght - 1.625m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // Plate Backer

            part = new Part(1121, "Plate Backer", this, FrameWorks.Functions.HingeCount(m_subAssemblyHieght), 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // Strike Plate

            part = new Part(1783, "Strike Plate", this, 1, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            // Shoot Strike 

            part = new Part(1986, "Shoot Strike", this, 2, 0.0m);
            part.PartGroupType = "Hardware-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);


            #endregion

            #region WeatherSeals

            //Door Bulb Seals
            decimal peri = m_subAssemblyHieght * 2.0m;
            peri += m_subAssemblyWidth;
            part = new Part(1769, "Frame Bulb Seal", this, 1, peri);
            part.PartGroupType = "Seals-Parts";
            part.PartLabel = "";
            
            m_parts.Add(part);

            #endregion

            #region Labor


            part = new LPart("MetalHours", this, 8.0m, 80.0m);
            m_parts.Add(part);
            //1 Receive: 1 Handle: 1 Cut: 1 Machine: 2 Weld & Assemble: 1 Hardware Prep: 1 NailFin

            part = new LPart("FinishHours", this, 4.0m, 80.0m);
            m_parts.Add(part);
            //2 SandLineGrain: 2 Finish




            #endregion

        }







    }
}
