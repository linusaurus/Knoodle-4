using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using DataAccess.Entities;

namespace DataAccess.Service
{
    public class SubAssemblyService
    {
        ProductionContext ctx = new ProductionContext();

        public List<SubAssembly> SubAssemblies;
        private Product parent;

        public Product Parent { get => parent; set => parent = value; }

        public SubAssemblyService()
        {

        }

        public List<SubAssembly> GetUnitSubAssemlblies(int productID)
        {
            return ctx.SubAssembly.Where(l => l.ProductID == productID).ToList();
        }
     
       
    }
}
