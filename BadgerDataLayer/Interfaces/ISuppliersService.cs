using System.Collections.Generic;
//using BadgerData;
using DataLayer.Entities;

namespace DataLayer.Interfaces
{


    public interface ISuppliersService {
        bool Exist(int supplierID);
        List<Supplier> GetAll();
        List<Supplier> Find(string supplierName);
        Supplier Find(int supplierID);
        void InsertOrUpdate(Supplier supplier);
        void Save();
    }
}