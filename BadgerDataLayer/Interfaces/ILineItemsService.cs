using System.Collections.Generic;
using DataLayer.Entities;

namespace DataLayer.Interfaces
{

    public interface ILineItemsService {

        PurchaseLineItem Find(int LineID);
        List<PurchaseLineItem> GetAll();
        List<PurchaseLineItem> GetJobItems(int JobID, string search);
        List<PurchaseLineItem> GetOrderItems(int orderNumber);
    }
}