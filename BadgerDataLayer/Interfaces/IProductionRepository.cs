using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entities;

namespace DataLayer.Interfaces
{
    public interface IProductionRepository
    {
       
        Assembly Find(int ProductID);
        void AddNew(Assembly assembly);
        IList<Assembly> GetAssemblies();
        IList<Assembly> GetJobAssemblies(int JobID);
        IList<SubAssembly> GetSubAssemblies(int assemblyID);
        IList<StockBillItem> GetStockBillItems(int productID);
    }
    
    
}
