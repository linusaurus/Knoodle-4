/***************************************************************
 * 
 *            Copyright ©  2014  by  Alberto Montibelli
 * 
 * This code, along with any associated article, code and files
 * is licensed under The Code Project Open License (CPOL)
 * 
 * See details at http://www.codeproject.com/info/cpol10.aspx
 *  
 ***************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinPackingCuttingStock
{
    // Method for Non Increasing Sort of Stocks
    public class NonIncreasingSortOnStockSize : IComparer<Stock>
    {
        public int Compare(Stock x, Stock y)
        {
            if (x.Size < y.Size) return 1;
            else if (x.Size > y.Size) return -1;
            else return 0;
        }
    }


    // Method for Non Decreasing Sort of Items
    public class NonDecreasingSortOnItemSize : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            if (x.Size > y.Size) return 1;
            else if (x.Size < y.Size) return -1;
            else return 0;
        }
    }


    // Method for Non Increasing Sort of Items
    public class NonIncreasingSortOnItemSize : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            if (x.Size < y.Size) return 1;
            else if (x.Size > y.Size) return -1;
            else return 0;
        }
    }


    // Method for Non Decreasing Sort on Size of the Branch & Bound List
    public class NonDecreasingSortOnBranchAndBoundSize : IComparer<BranchAndBound.BranchBound>
    {
        public int Compare(BranchAndBound.BranchBound x, BranchAndBound.BranchBound y)
        {
            if (x.Size > y.Size) return 1;
            else if (x.Size < y.Size) return -1;
            else return 0;
        }
    }


    // Method for Non Decreasing Sort on Cost of the Branch & Bound List
    public class NonDecreasingSortOnBranchAndBoundCost : IComparer<BranchAndBound.BranchBound>
    {
        public int Compare(BranchAndBound.BranchBound x, BranchAndBound.BranchBound y)
        {
            if (x.Cost > y.Cost) return 1;
            else if (x.Cost < y.Cost) return -1;
            else return 0;
        }
    }
}
