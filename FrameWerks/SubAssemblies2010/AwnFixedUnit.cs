#region Copyright (c) 2015 WeaselWare Software
/************************************************************************************
'
' Copyright  2015 WeaselWare Software 
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
' Portions Copyright 2015 WeaselWare Software
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
using System.Diagnostics;
using DataAccess.Service;

namespace FrameWorks.Makes.System2010
{

    public class AwnFixedUnit : SubAssemblyBase
    {

        #region Fields

        //Constant Values
        const decimal frameReduce2X = 0.9375m * 2.0m;
        const decimal gaskFrmReduce = 1.250m;
        const decimal gstopReduce2X = 1.88285m * 2.0m;
        const decimal glassReduce2X = 2.21875m * 2.0m;
        const decimal gaskSashReduce = 2.1875m;
        const decimal edgeSealAdd = 0.375m;

        //static int createID;

        #endregion

        #region Constructor

        public AwnFixedUnit()
        {
            //subAssemblyID = Guid.NewGuid();
            this.ModelID = "System2010-AwnFixedUnit";
            this.WorkOrder = new Workorder(this, 1);
        }

        #endregion

       

        #region Methods

        //Bill of Material
        public override void Build()
        {

            Component Component;
           
            string ComponentPrefix = String.Format("{0}-{1}-{2}",ParentAssembly.JobID, ParentAssembly.ProductID,SubAssemblyID);

            decimal pweight = FrameWorks.Functions.PanelWieghtS2000(m_subAssemblyWidth, m_subAssemblyHieght);

           
            string labelStileR = string.Empty;
            string labelStileL = string.Empty;
            string labelTopRail = string.Empty;
            string labelBotRail = string.Empty;

            #region Frame

            //////////////////////////////////////////////////////////////////////////////

            // AlumWndAwnVert
           
            
                Component = new Component(4347, "AlumWndAwnVert", this, 2, m_subAssemblyHieght);
                Component.ComponentGroupType = "FrameAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            

            //////////////////////////////////////////////////////////////////////////////

            // AlumWndAwnHorz
          
                Component = new Component(4347, "AlumWndAwnHorz", this, 2, m_subAssemblyWidth);
                Component.ComponentGroupType = "FrameAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrFrame


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // AglBrktAlum
      
            
                Component = new Component(3206, "AglBrktAlum", this, 8, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrFrame";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            

            // PointSetScrew
          
                Component = new Component(1545, "PointSetScrew", this, 32, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrFrame";
                Component.ComponentLabel = "";
                m_Components.Add(Component);

            

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Seal/Weatherstripping


            decimal peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
                peri = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskFrmReduce, m_subAssemblyWidth - gaskFrmReduce);

                //FrameSeal
                Component = new Component(2274, "FrameSeal", this, 1, peri);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Sash


            // StileAlumL <<--
            Component = new Component(4350, "StileAlumL", this, 1, m_subAssemblyHieght - frameReduce2X);
            Component.ComponentGroupType = "Sash-Components";
            Component.ComponentWidth = Component.Source.Width;
            Component.ComponentThick = Component.Source.Height;
            Component.ComponentLabel = labelStileL = "MiterEnds";

            m_Components.Add(Component);


            // StileAlumR -->>
            Component = new Component(4350, "StileAlumR", this, 1, m_subAssemblyHieght - frameReduce2X);
            Component.ComponentGroupType = "Sash-Components";
            Component.ComponentWidth = Component.Source.Width;
            Component.ComponentThick = Component.Source.Height;
            Component.ComponentLabel = labelStileR = "1)MiterEnds";

            m_Components.Add(Component);


            // RailAlumT ^^
            Component = new Component(4350, "RailAlumT", this, 1, m_subAssemblyWidth - frameReduce2X);
            Component.ComponentGroupType = "Sash-Components";
            Component.ComponentWidth = Component.Source.Width;
            Component.ComponentThick = Component.Source.Height;
            Component.ComponentLabel = labelTopRail = "1)MiterEnds";

            m_Components.Add(Component);


            // RailAlumB ||
            Component = new Component(4350, "RailAlumB", this, 1, m_subAssemblyWidth - frameReduce2X);
            Component.ComponentGroupType = "Sash-Components";
            Component.ComponentWidth = Component.Source.Width;
            Component.ComponentThick = Component.Source.Height;
            Component.ComponentLabel = labelBotRail = "1)MiterEnds";

            m_Components.Add(Component);



            #endregion

            #region StopAlum

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpVt
                
                Component = new Component(4341, "AlumGlsStpVt", this, 2, m_subAssemblyHieght - gstopReduce2X);
                Component.ComponentGroupType = "StopAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            //////////////////////////////////////////////////////////////////////////////

            // AlumGlsStpHz
        
                Component = new Component(4341, "AlumGlsStpHz", this, 2, m_subAssemblyWidth - gstopReduce2X);
                Component.ComponentGroupType = "StopAlum-Components";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            ////////////////////////////////////////////////////////////////////////////////

            #endregion

            #region AssyHrdwrSash


            //////////////////////////////////////////////////////////////////////////////

            // SS_0.4625_InsetCrnBrace 
 
                Component = new Component(4784, "SS_0.4625_InsetCrnBrace", this, 4, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrSash";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            

            // FlatHead_8-32x3/16_UndercutHead
            for (int i = 0; i < 16; i++)

            {
                Component = new Component(502, "FlatHead_8-32x3/16_UndercutHead", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrSash";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////

            // AlumCnrBrkt
            for (int i = 0; i < 4; i++)

            {
                Component = new Component(3206, "AlumCnrBrkt", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrSash";
                Component.ComponentWidth = Component.Source.Width;
                Component.ComponentThick = Component.Source.Height;
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            // PointSet1/4x20Screw
            for (int i = 0; i < 16; i++)

            {
                Component = new Component(1545, "PointSet1/4x20Screw", this, 1, 0.0m);
                Component.ComponentGroupType = "AssyHrdwrFrame";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }

            ////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Glass


            /////////////////////////////////////////////////////////////////////////////////////////////
            // Glass Panels
            for (int i = 0; i < 1; i++)
            {

                // Glass Panel
                Component = new Component(3300);

                Component.FunctionalName = "GlassLite";
                Component.ComponentGroupType = "Glass-Components";
                Component.Qnty = 1;
                Component.ContainerAssembly = this;
                Component.ComponentWidth = (m_subAssemblyWidth - glassReduce2X);
                Component.ComponentLength = (m_subAssemblyHieght - glassReduce2X);
                Component.ComponentThick = 1.25m;

                m_Components.Add(Component);

            }

            //////////////////////////////////////////////////////////////////////////////////////////////


            #endregion

            #region Seal/Weatherstripping


            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {
                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - edgeSealAdd, m_subAssemblyWidth - edgeSealAdd);

                //SashEdgeSeal
                Component = new Component(2274, "SashEdgeSeal", this, 1, peri);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);

                //GlazPreSetEPDM
                Component = new Component(4314, "GlazPreSetEPDM", this, 1, peri);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 1; i++)
            {

                decimal periSash = FrameWorks.Functions.Perimeter(m_subAssemblyHieght - gaskSashReduce, m_subAssemblyWidth - gaskSashReduce);

                //GlazWedgEPDM
                Component = new Component(4399, "GlazWedgEPDM", this, 1, peri);
                Component.ComponentGroupType = "Seal-Components";
                Component.ComponentLabel = "";

                m_Components.Add(Component);

            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////








            #endregion


        }



        #endregion


    }
}