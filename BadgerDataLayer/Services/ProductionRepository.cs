/*------------------------------------------
 * Production Repository
 * r.young
 * 2-26-20120
 * Inventory-Ferret
 * --------------------------------------
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer.Entities;
using DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Services
{
    public class ProductionRepository : IProductionRepository
    {
        readonly BadgerDataModel _context;

        public ProductionRepository(BadgerDataModel context)
        {
            _context = context;
        }

        public void AddNew(Assembly assembly)
        {
            _context.Assembly.Add(assembly);          
        }

        public Assembly Find(int productID)
        {
            return _context.Assembly.Include(s => s.SubAssembly).Include(t => t.StockBillItems).Where(p => p.ProductId == productID).Single();
        }

        public IList<Assembly> GetAssemblies()
        {
            return _context.Assembly.AsNoTracking().ToList();
        }

        public IList<Assembly> GetJobAssemblies(int jobID)
        {
           return _context.Assembly.Include(d => d.SubAssembly).Where(r => r.JobID == jobID).ToList();
        }

        public IList<StockBillItem> GetStockBillItems(int productID)
        {
            return _context.StockBillItem.ToList();
        }

        public IList<SubAssembly> GetSubAssemblies(int assemblyID)
        {
           return _context.SubAssembly.AsNoTracking().Where(p => p.AssemblyId == assemblyID).ToList();
        }
    }
}
