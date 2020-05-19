#region Copyright (c) 2017 WeaselWare Software
/************************************************************************************
'
' Copyright  2017 WeaselWare Software 
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
' Portions Copyright 2017 WeaselWare Software
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

namespace FrameWorks
{

    public class TrackHelper
    {

        #region Fields
        //-----------------------------------      
        readonly decimal STILEWIDTH = 2.5625m;
        readonly decimal STILEOVRLP = 2.5625m;   
        readonly decimal MAXDRAINSPACE = 30.0m;
        //-----------------------------------

        private decimal m_decimalPanelCount;
        private decimal m_openingWidth;
        private decimal m_division;
        private decimal m_doorPanelWidth;
        private int m_hasScreen;
        private List<int> m_brackets = new List<int>();
        private List<decimal> m_BridgeLengths = new List<decimal>();

        #endregion

        #region Constructor

        public TrackHelper(int doorCount, decimal openingWidth, int HasScreen) 
        {
            this.m_decimalPanelCount = Convert.ToInt32(doorCount);
            this.m_openingWidth = openingWidth;
            this.m_hasScreen = HasScreen;
        }

        #endregion

        #region Properties





        public List<decimal> BridgeLengths
        {
            get { return m_BridgeLengths; }
        }

        public decimal Division
        {
            get
            {
                m_division = decimal.Zero;
                m_division = (m_openingWidth - STILEWIDTH) / m_decimalPanelCount;
                return Math.Round(m_division, 4);
            }
        }
        public decimal DoorPanelWidth
        {
            get
            {
                m_doorPanelWidth = decimal.Zero;
                m_doorPanelWidth = Division + STILEOVRLP;
                return Math.Round(m_doorPanelWidth, 4);
            }
        }

        public void Calculate()
        {
            if (Division < 16.0000m)
            {
                m_brackets.Add(2);
                m_brackets.Add(2);
                m_brackets.Add(4);
            }
            else
            {
                int temp = Convert.ToInt32(Math.Truncate(Division / 16.0m));
                m_brackets.Add(temp);
                m_brackets.Add(temp);
                m_brackets.Add(temp * 2);

            }

        }
        public int BridgeCount  
        {

            get
            {
                decimal t = (m_openingWidth / 16.0000m) / m_decimalPanelCount + 1.0m;
                int result = Convert.ToInt32(t);
                return result;
            }
        }

        public List<int> Brackets
        {
            get { return m_brackets; }

        }

        public int DrainCount
        {
            get
            {
                int result = 0;
                if ((m_doorPanelWidth % MAXDRAINSPACE) <= decimal.Zero)
                {
                    result = (int)(m_doorPanelWidth / MAXDRAINSPACE);
                }

                else if ((m_doorPanelWidth % MAXDRAINSPACE) > decimal.Zero)
                {
                    result = (int)((m_doorPanelWidth / MAXDRAINSPACE) + 1);
                }

                result *=  (int)m_decimalPanelCount;
                return result;
            }
        }



#endregion



    }
}