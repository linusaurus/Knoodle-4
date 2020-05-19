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

namespace FrameWorks.Makes.System3000
{

   public class SliderPXPHelper
   {

      #region Fields
      //-----------------------------------
      readonly decimal STILEWIDTH = 2.0625m;
      readonly decimal CENTER_GAP = 0.1875m;
      //-----------------------------------
      
      private decimal m_decimalPanelCount;
      private decimal m_adjustedHalfOpening;
      private decimal m_openingWidth;
      private decimal m_panelWidth;
      private decimal m_doorPosition;
      private decimal m_division;
      private decimal m_floorTrackLength;
      private decimal m_topTrackLength;

      
      #endregion

      #region Constructor

      public SliderPXPHelper(int doorCount, int doorPosition, decimal openingWidth)
      {
         this.m_decimalPanelCount = Convert.ToInt32(doorCount);
         this.m_doorPosition = Convert.ToInt32(doorPosition);
         this.m_openingWidth = openingWidth;
         this.m_adjustedHalfOpening = (m_openingWidth - CENTER_GAP)/ 2.0m  ;

      }

      #endregion

      #region Properties

      public decimal Division
      {
         get
         {
            m_division = decimal.Zero;
            m_division = DoorPanelSize - STILEWIDTH;
            return Math.Round(m_division, 4);
         }

      }

      public decimal DoorPanelSize
      {
         get
         {
            m_panelWidth = decimal.Zero;
            m_panelWidth = m_adjustedHalfOpening;
            m_panelWidth += (((m_decimalPanelCount/2.0m) -1)* STILEWIDTH);
            m_panelWidth /= (m_decimalPanelCount / 2.0m);
            return Math.Round(m_panelWidth, 4);

         }

      }
     /// <summary>
     /// Floor Track Length
     /// </summary>
      public decimal FloorTrackLength
      {

         get
         {
            m_floorTrackLength = decimal.Zero;
            if (m_doorPosition  == 1)
            {
                  m_floorTrackLength = m_adjustedHalfOpening + (CENTER_GAP / 2.0m) + DoorPanelSize - 0.625m;
            }
               else
               {
                  decimal trackMultiplier = ((m_decimalPanelCount /2.0m) + 1)- m_doorPosition ;
                  m_floorTrackLength = (trackMultiplier * Division ) + STILEWIDTH;
                  m_floorTrackLength += DoorPanelSize ;
                  m_floorTrackLength -= 1.25m;
                  
  
               }
               
               return Math.Round(m_floorTrackLength, 4);

         }

      }
      public decimal Head
      {
         get
         {
            decimal m_head = decimal.Zero;
            
            if (m_doorPosition  == 1)
            {
               m_head = m_adjustedHalfOpening + (CENTER_GAP / 2.0m) + DoorPanelSize + 0.625m;
            }
               else
               {
                  decimal trackMultiplier = ((m_decimalPanelCount /2.0m) + 1)- m_doorPosition ;
                  m_head = (trackMultiplier * Division) + STILEWIDTH;
                  m_head += DoorPanelSize;
                  m_head += 1.25m;
                  
  
               }

               return Math.Round(m_head, 4);

         }

      }
      public decimal TopTrackLength
      {
         get
         {
            m_topTrackLength = decimal.Zero;

            decimal position = Convert.ToDecimal(m_doorPosition);
            

            if (m_doorPosition == 1)
            {
               m_topTrackLength = ((m_openingWidth / 2.0m) + DoorPanelSize);
            }
            else
            {
               decimal trackMultiplier = ((m_decimalPanelCount /2.0m) + 1)- m_doorPosition;
               m_topTrackLength  = (trackMultiplier * Division) + STILEWIDTH;
              
               m_topTrackLength += DoorPanelSize;
               
            }


            return Math.Round(m_topTrackLength, 4);

         }

      }

      #endregion


   }
}