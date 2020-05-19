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
using System.Runtime;

namespace FrameWorks.Makes.System3000
{
   
   public class JeffersonCalc 
   {
 
    readonly decimal RAIL_WIDTH = 2.064m;
    readonly decimal MULLION_WIDTH = 1.0m;
    readonly decimal AWNING_LAP = 1.0m * 2.0m;
   
    private decimal m_h;
    private decimal m_winSpace;
    private decimal m_topGlassHeight;
    private decimal m_bottomGlassHieght;
    private decimal m_buildOutStile;
    private decimal m_upperSection;
   
      
      public JeffersonCalc(decimal H)
      {
         m_h = H;
               
      }
      
      public Decimal WindowSpace
      {
         get{
               decimal windowSpace = 0.0m;
               decimal mullionSpace = 0.0m;
               mullionSpace = decimal.Multiply(RAIL_WIDTH ,5.0m);
               mullionSpace += MULLION_WIDTH ;
               mullionSpace -= AWNING_LAP;
               windowSpace = decimal.Subtract(m_h,mullionSpace);
               m_winSpace = windowSpace/3.0m;
               return Math.Round(m_winSpace,4);
         }
      
      }
      
      public Decimal UpperSection
      {
         get{
               m_upperSection = Decimal.Zero;
               m_upperSection = (this.WindowSpace * 2.0m) +(RAIL_WIDTH * 2.0m)+ MULLION_WIDTH;
               return Math.Round( m_upperSection,4) ;
         
         }
         
      
      }
      public Decimal TopGlassHieght
      {
         get{
            m_topGlassHeight = decimal.Zero;
            m_topGlassHeight =(this.WindowSpace * 2.0m) +(RAIL_WIDTH * 2.0m)+ MULLION_WIDTH;
            m_topGlassHeight -= (1.6m * 2.0m);
            return Math.Round(m_topGlassHeight,4);
         }
      }
      public decimal BottomGlassHeight
      {
      
         get{
            m_bottomGlassHieght  = decimal.Zero ;
            m_bottomGlassHieght = this.WindowSpace + (0.462m * 2.0m);
            return Math.Round(m_bottomGlassHieght,4);
         }
      }
      
      public decimal BuildOutStile
      {
         get{
            m_buildOutStile = decimal.Zero;
            decimal result =(this.WindowSpace * 2.0m) +(RAIL_WIDTH * 2.0m)+ MULLION_WIDTH;
            m_buildOutStile = m_h - result;
            //m_buildOutStile += 1.3125m;
            return Math.Round(m_buildOutStile,4);                         
         }
      }

      
      
     
   
   }
}