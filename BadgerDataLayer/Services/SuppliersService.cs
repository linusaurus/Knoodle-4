using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DataLayer.Interfaces;
using DataLayer.Entities;

namespace DataLayer.Services
{

    public class SuppliersService : ISuppliersService {

        BadgerDataModel _context;

        public SuppliersService(BadgerDataModel Context) {

            _context = Context;
        }

        public List<Supplier> GetAll()
        {
            return _context.Supplier.ToList();
        }

        public bool Exist(int supplierID) {
                       
            return _context.Supplier.Any(c => c.SupplierId == supplierID);          
        }

        public Supplier Find(int supplierID) {

            return _context.Supplier.Where(c => c.SupplierId == supplierID).FirstOrDefault();
        }

        public List<Supplier> Find(string supplierName) {

            List<Supplier> result;
            result = _context.Supplier.Where(c => c.SupplierName.StartsWith(supplierName)).ToList();        
            return result;
        }

        public List<Supplier> SuppliersWithOpenOrders()
        {
            return _context.Supplier.FromSqlRaw("select * FROM Supplier WHERE SupplierID IN (SELECT supplierID from PurchaseOrder WHERE RECIEVED = 0)").ToList();
        }

        public void InsertOrUpdate(Supplier supplier) {

            if (supplier.SupplierId == default(int))
            {
                //_context.Entry(supplier).State = EntityState.Added;
                _context.Supplier.Add(supplier);
            }
            else
            {
                _context.Supplier.Attach(supplier);
            }
        }

        public void Save() { _context.SaveChanges(); }


    }
}
