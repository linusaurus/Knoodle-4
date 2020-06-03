using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Entities;
using DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.Services {

    public class LineItemsService : ILineItemsService {

        BadgerDataModel context;

        public LineItemsService(BadgerDataModel Context) {

            context = Context;
        }

        public PurchaseLineItem Find(int LineID)
        {
            if (String.IsNullOrEmpty(LineID.ToString()))
            {
                return null;
            }

            return context.PurchaseLineItem.Find(LineID);
           

            ;

        }

        public List<PurchaseLineItem> GetAll() {

            return context.PurchaseLineItem.OrderByDescending(c => c.LineID).ToList();
        }

        public List<PurchaseLineItem> GetJobItems(int JobID, string search) {

            return context.PurchaseLineItem.Where(c => c.JobId == JobID)
                                            .Where(n => n.Description.Contains(search)).ToList();
        }

        public List<PurchaseLineItem> GetOrderItems(int orderNumber) {

            return context.PurchaseLineItem.Where(c=> c.PurchaseOrderId == orderNumber).ToList();
        }



        //public void InsertOrUpdate(Inventory inventory) {
        //     if (inventory.OrderReceiptID == default(int))
        //     {
        //         context.Entry(inventory).State = EntityState.Added;
        //         context.Inventories.Add(inventory);
        //     }
        //     else
        //     {context.Entry(inventory).State = EntityState.Modified;}

        // }


        // public void Save() {

        //     context.SaveChanges();
        // }
        // public void Dispose() {

        //     context.Dispose();
        // }
    }
}
