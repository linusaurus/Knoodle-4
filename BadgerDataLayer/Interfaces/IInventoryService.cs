using System.Collections.Generic;
//using BadgerData;
using DataLayer.Entities;
using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IInventoryService {
        void Dispose();
        bool Exist(int stockTransActionID);
        Inventory FindByLineItem(int LineID);
        List<InventoryListDto> GetInventoryByPartID(int PartID);
        List<Inventory> GetOrderRecieptItems(int orderRecieptID);
        List<Inventory> GetSupplierInventory(Supplier supplier);
        List<Inventory> GetSupplierInventory(Supplier supplier, string itemName);
        List<Inventory> GetJobInventory(Job job);
        void PushStock(int PartID, decimal qnty,int jobID=106 );
        void PullStock(int PartID, decimal qnty,int employeeID,int  jobID = 106);
        void SetStock(int PartID, decimal qnty, int employeeID);
        void InsertOrUpdate(Inventory inventory);
        decimal StockLevel(int partNum);
        void Save();
    }
}