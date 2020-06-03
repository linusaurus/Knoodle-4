using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace DataLayer.Services {

    public class OrderRecieptService : IDisposable {

        BadgerDataModel context;

        public OrderRecieptService(BadgerDataModel Context) {

            context = Context;
        }

        public bool Exist(int orderRecieptID) {

            bool result = false;
            if (context.OrderReciept.Any(c => c.OrderReceiptId == orderRecieptID))
            {
                result = true;
            }

            return result;
        }

        public OrderReciept Create(int employeeID, int purchaseOrderID = 0)
        {
            
            var result = new OrderReciept
            {
                ReceiptDate = DateTime.Now,
                EmployeeId = employeeID,
                OrderNum = purchaseOrderID,
            };

            context.OrderReciept.Add(result);
            context.SaveChanges();
            return result;

        }

        //public List<>

        public OrderReciept GetReceivedOrderReceipt(int purchaseOrderID) {

            return context.OrderReciept.Where(c => c.OrderNum == purchaseOrderID).FirstOrDefault();
        }

        public OrderReciept GetOrderReciept(int orderRecieptID) {

            return context.OrderReciept.Where(c => c.OrderReceiptId == orderRecieptID).FirstOrDefault();
        }

        public List<OrderReciept> GetAllOrderReciepts() {

            return context.OrderReciept.OrderByDescending(c=> c.OrderReceiptId).ToList();
        }

        public OrderReciept GetOrderRecieptByID(int orderRecieptID) {

            return context.OrderReciept.Find(orderRecieptID);
        }

        public List<OrderReciept> GetJobReciepts(int jobID) {

            List<OrderReciept> result;
            var orderNums = context.PurchaseOrder.Where(c => c.JobId == jobID).Select(p=> p.OrderNum).ToArray();
            var reciepts = from rct in context.OrderReciept where (orderNums.Contains(rct.OrderNum.Value)) select rct;
            result = reciepts.ToList();
            
            return result;
        }

        public List<OrderReciept> GetSupplierReciepts(int supplierID) {

            List<OrderReciept> result;
            var orderNums = context.PurchaseOrder.Where(c => c.SupplierId == supplierID).Select(p => p.OrderNum).ToArray();
            var reciepts = from rct in context.OrderReciept where (orderNums.Contains(rct.OrderNum.Value)) select rct;
            result = reciepts.ToList();

            return result;
        }

        public void InsertOrUpdate(OrderReciept orderReciept) {
            if (orderReciept.OrderReceiptId == default(int))
            {
                
                context.OrderReciept.Add(orderReciept);
            }
            else
            {context.Entry(orderReciept).State = EntityState.Modified;}
        
        }


        public void Save() {

            context.SaveChanges();
        }
        public void Dispose() {

            context.Dispose();
        }
    }
}
