using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using DataAccess.Entities;


namespace DataAccess.Service
{
    public class UnitsService
    {
        private readonly ProductionContext ctx;

        public UnitsService(ProductionContext context)
        {
            ctx = context;
        }

       public List<Product> GetJobUnits(int jobID)
        {
            return ctx.Product.Include(p => p.SubAssembly).Where(j => j.JobID == jobID).ToList();
        }

        public Product AddUnit(Product unit)
        {           
            ctx.Add(unit);
            ctx.SaveChanges();        
            return unit;
        }


    }
}
