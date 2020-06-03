using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
//using BadgerData;
using DataLayer.Entities;
using DataLayer.Interfaces;
using DataLayer.Models;
using System.Runtime.InteropServices.ComTypes;

namespace DataLayer.Services {

    public class OrdersService : IDisposable, IOrdersService {

        private readonly BadgerDataModel context;
        IPartsService _partService;

        public OrdersService(BadgerDataModel Context) {
            
            context = Context;
            _partService = new PartsService(context);
        }

        public OrderDetailDto GetOrderDTO(int orderID)
        {
            var _order = context.PurchaseOrder.Include(r => r.PurchaseLineItem).Include(s => s.Supplier).Where(p => p.OrderNum == orderID).Select(d => new OrderDetailDto
            {
                PurchaseOrderID = d.OrderNum,
                OrderDate = d.OrderDate.Value.ToShortDateString(),
                OrderTotal = d.OrderTotal.Value,
                ExpectedDate = d.ExpectedDate.Value,
                JobCostName = d.Job.Jobdesc,
                JobName = d.Job.Jobname,
                JobID = d.JobId.Value,
                Purchaser = d.Employee.Firstname + " " + d.Employee.Lastname,
                ShippingCost = d.ShippingCost.HasValue ? d.ShippingCost.Value : Decimal.Zero,
                SubTotal = d.SubTotal.HasValue ? d.SubTotal.Value : Decimal.Zero,
                ShipID= d.ShipId.Value,
                SupplierAddress = d.Supplier.Address1,
                SupplierCity = d.Supplier.City,
                SupplierName = d.Supplier.SupplierName,
                SupplierState = d.Supplier.State,
                SupplierID = d.SupplierId.HasValue ? d.SupplierId.Value : 0,
                SupplierPhone = d.Supplier.Phone,
                SupplierZip = d.Supplier.Zip,
                SupplierFax = d.Supplier.Fax,
                Tax = d.Tax.HasValue ? d.Tax.Value : Decimal.Zero,
                Taxable = d.SuppressTax.HasValue ? d.SuppressTax.Value : false,
                //LineItems = d.PurchaseLineItem

            });
            return _order.FirstOrDefault();
        }

        public List<LineItemDto> GetLineItems(int orderID)
        {
            var _lineItems = context.PurchaseLineItem.Where(f => f.PurchaseOrderId == orderID).Select(d => new LineItemDto
            {
                Description = d.Description,
                LineID = d.LineID,
                Quantity = d.Qnty.Value,
                Price = d.UnitCost.Value,
                Extended = d.Extended.Value,
                PartID = d.PartID.GetValueOrDefault(),
                PurchaseOrderID = d.PurchaseOrderId.Value,
            });
            return _lineItems.ToList();
        }

        public void SaveOrder(OrderDetailDto order)
        {

        }

        public bool Exist(int orderID) {

            bool result = false;
            if (context.PurchaseOrder.Any(c=> c.OrderNum == orderID))
            {
                result = true;
            }

            return result;
        }

        public BindingList<PurchaseLineItem> OrderLineItems(int purchaseOrderID)
        {
            BindingList<PurchaseLineItem> result = new BindingList<PurchaseLineItem>(context.PurchaseLineItem.Where(w => w.PurchaseOrderId == purchaseOrderID).ToList());
            return  result;
          
           
        }

        public PurchaseOrder GetOrderByID(int orderNum) {

            return context.PurchaseOrder
                .Include(path => path.PurchaseLineItem)
                .Include(j => j.Job)
                .Include(s => s.Supplier)
                .Include(t => t.Attachment)
                .Include(p => p.OrderFee)
                .Include(e => e.Employee).Where(c => c.OrderNum == orderNum).FirstOrDefault();
                
        }

        public List<PurchaseOrder> GetAllOrders() {

            return context.PurchaseOrder.ToList();
        }

        public List<PurchaseOrder> GetSupplierOrders(int supplierID)
        {

            return context.PurchaseOrder.Where(c => c.SupplierId == supplierID).OrderByDescending(d => d.OrderDate).ToList();
        }

        public List<PurchaseOrder> GetJobOrders(int jobID)
        {

            return context.PurchaseOrder.Where(c => c.JobId == jobID).ToList();
        }

        public void InsertOrUpdate(PurchaseOrder order) {

            if (order.OrderNum == default(int))
            {
                context.Entry(order).State = EntityState.Added ;
                context.PurchaseOrder.Add(order);
            }
            else
            {
                context.PurchaseOrder.Attach(order);
            }
        }

        public PurchaseOrder NewDefault(int employee, int supplierId, int jobID) {

            PurchaseOrder po = new PurchaseOrder();
            po.EmployeeId = employee;
            po.SupplierId = supplierId;
            po.DateAdded = DateTime.Today;
            po.OrderDate = DateTime.Today;
            po.ExpectedDate = DateTime.Today;
            po.IsBackOrder = false;
            po.JobId = jobID;
            po.Memo = " ";
            po.OrderState = 0;
            po.OrderTotal = 0.00m;
            po.SalesRep = "";
            po.ShipId = 1;
            po.ShippingCost = 0.00m;
            po.SuppressTax = false;
            po.SubTotal = 0.00m;
            po.Recieved = false;
            po.Tax = 0.00m;
            po.OrderFormat = "Standard";
            po.AddedBy = context.Employee.Find(employee).Firstname + " " + context.Employee.Find(employee).Lastname;
            po.OrderState = 1;
            return po;
        }

        public void Delete(int orderID) {

            PurchaseOrder po = context.PurchaseOrder.Where(c => c.OrderNum == orderID).FirstOrDefault();
            context.Entry(po).State = EntityState.Deleted;
            context.PurchaseOrder.Remove(po);

        }
        //Recieve Order --
        public OrderReciept RecievedOrder(PurchaseOrder order, int employeeID) {

            // Build and save OrderReceipt --
            OrderReciept oreciept = new OrderReciept();
            oreciept.OrderNum = order.OrderNum;
            oreciept.EmployeeId = employeeID;
            oreciept.ReceiptDate = DateTime.Now;
            context.OrderReciept.Add(oreciept);
            context.SaveChanges();
            List<ClaimItem> claimItems = new List<ClaimItem>();

            foreach (PurchaseLineItem item in order.PurchaseLineItem)
            {

                Inventory inv = new Inventory();
                inv.DateStamp = DateTime.Now;
                inv.Description = item.Description.ToString().TrimEnd();
                inv.JobId = order.JobId;
                inv.LineID = item.LineID;
                inv.Location = string.Empty;
                inv.Note = item.Note;
                inv.OrderReceiptID = oreciept.OrderReceiptId;
                inv.UnitOfMeasure = item.Uom ?? 1;
                inv.Qnty = item.Qnty ?? 0;      
                item.Recieved = true;
                item.OrderReceiptId = oreciept.OrderReceiptId;
                inv.PartID = item.PartID ?? null;
                if (!(item.Description.Length == 0) && !(item.Qnty == default(decimal)) )
                {
                    context.Entry(inv).State = EntityState.Added;
                    context.Inventory.Add(inv);
                    context.Entry(item).State = EntityState.Modified;
                    if (item.Rejected == true)
                    {
                        var c = new ClaimItem
                        {
                            LineID = item.LineID,
                            Description = item.Description,
                            Bcode = item.Bcode,
                            PartID = item.PartID
                        };
                        claimItems.Add(c);
                    }

                }
               
               
            }
            order.Recieved = true;
            order.RecievedDate = DateTime.Today;
            if (claimItems.Count > 0)
            {
                //ClaimService claimService = new ClaimService(context);
                //var newClaim = claimService.NewClaim(order.OrderNum, Globals.CurrentLoggedUserID);

                //foreach (ClaimItem clm in claimItems)
                //{
                //    newClaim.ClaimItem.Add(clm);
                //}
                context.SaveChanges();
            }

            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                string err = ex.InnerException.ToString();
                Console.Write(err);
                throw;
            }
            return oreciept;
        
        }

        public void Save() {

            context.SaveChanges();
        }

        public void Dispose() {

            context.Dispose();
        }

        public List<SupplierOrderDTO> GetSupplierOrdersDTO(int SupplierID)
        {
            List<SupplierOrderDTO> result = new List<SupplierOrderDTO>();
            SupplierOrderDTO dto;

            using (BadgerDataModel ctx = new BadgerDataModel())
            {
            // Get all the Suppliers Orders --
            var pOrders = ctx.PurchaseOrder.Where(p => p.SupplierId == SupplierID).ToList();

                foreach (var P in pOrders)
                {
                dto = new SupplierOrderDTO();
                dto.PurchaserName = P.Employee.Lastname;
                    if(P.Job != null)
                    { dto.JobName = P.Job.Jobname; }
               
                dto.OrderDate = P.OrderDate;
                dto.OrderNum = P.OrderNum;
                dto.Received = P.Recieved;
                dto.SupplierName = P.Supplier.SupplierName;
                dto.ReceiveStatus = "none";
                result.Add(dto);

                }
             }
            
            return result;           
        }

        public List<SupplierLineItemDto> GetSupplierLineItems(int supplierID)
        {
            string id = supplierID.ToString();
            
            string sql = @"select Description,PartID,LineID,Qnty,UnitCost,PurchaseOrderID FROM PurchaseLineItem " +
                          " WHERE OrderReceiptID IN(SELECT OrderReceiptID FROM OrderReciept WHERE OrderNum IN " +
                          "(SELECT OrderNum FROM PurchaseOrder WHERE SupplierID = {0}))";

            ///TODO pass a parameter to the sql
            var result = context.PurchaseLineItem.FromSqlRaw(sql, id).Select(d => new SupplierLineItemDto
            {
                Description = d.Description,
                LineID = d.LineID,
                PartID = d.PartID.GetValueOrDefault(),
                UnitCost = d.UnitCost.GetValueOrDefault(),
                OrderNum = d.PurchaseOrderId.GetValueOrDefault()
            })
                .ToList();
            return result;
        }

        public List<UnitOfMeasure> GetUnits()
        {
          return context.UnitOfMeasure.AsNoTracking().ToList() ;
        }
        /// <summary>
        /// TODO this need to be much more expanded and use a composite Order DTO
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public PurchaseOrder Add(PurchaseOrder order)
        {
            context.PurchaseOrder.Add(order);
            context.SaveChanges();
            return order;
        }

        public void CreateOrUpdateOrder(OrderDetailDto orderDTO)
        {
           var ctx = context;
           var order = ctx.PurchaseOrder.FirstOrDefault(o => o.OrderNum == orderDTO.PurchaseOrderID);
            if (order == null)
            {
                order = new PurchaseOrder();
                ctx.PurchaseOrder.Add(order);
            }

            //Map properties
            order.OrderDate = DateTime.Parse(orderDTO.OrderDate);
            order.OrderTotal = orderDTO.OrderTotal;
            order.ExpectedDate = orderDTO.ExpectedDate;
            order.JobId = orderDTO.JobID;
            order.Memo = orderDTO.Memo;
           
            order.SalesRep = orderDTO.SalesRep;
            order.EmployeeId = orderDTO.EmployeeID;
            order.OrderNum = orderDTO.PurchaseOrderID;
            order.ShipId = orderDTO.ShipID;
            order.ShippingCost = orderDTO.ShippingCost;
            order.SubTotal = orderDTO.SubTotal;
            order.SupplierId = orderDTO.SupplierID;
            order.SuppressTax = orderDTO.Taxable;
            
            order.Tax = orderDTO.Tax;


            //remove deleted details -
            order.PurchaseLineItem
            .Where(d => !orderDTO.LineItems.Any(LineItemDto => LineItemDto.LineID == d.LineID)).ToList()
            .ForEach(deleted => ctx.PurchaseLineItem.Remove(deleted));

            //update or add details
            orderDTO.LineItems.ToList().ForEach(detailDTO =>
            {
                var detail = order.PurchaseLineItem.FirstOrDefault(d => d.LineID == detailDTO.LineID);
                if (detail == null)
                {
                    detail = new PurchaseLineItem();
                    order.PurchaseLineItem.Add(detail);
                }
                detail.JobId = detailDTO.JobID;
                detail.Qnty = detailDTO.Quantity;
                detail.Description = detailDTO.Description;
                detail.PurchaseOrderId = detailDTO.PurchaseOrderID;
                detail.PartID = detailDTO.PartID;
                detail.UnitCost = detailDTO.Price;
                detail.Uom = detailDTO.UiD;
                detail.Extended = detailDTO.Extended;

            });

            //remove deleted orderfees -
            order.OrderFee
                .Where(d => !orderDTO.OrderFees.Any(OrderFeeDto => OrderFeeDto.OrderFeeID == d.OrderfeeID)).ToList()
                .ForEach(deleted => ctx.OrderFee.Remove(deleted));

            //update or add OrderFees
            orderDTO.OrderFees.ToList().ForEach(od =>
            {
                var orderfee = order.OrderFee.FirstOrDefault(r => r.OrderfeeID == od.OrderFeeID);
                if (orderfee == null)
                {
                    orderfee = new OrderFee();
                    order.OrderFee.Add(orderfee);
                }
                orderfee.PurchaseOrderID = order.OrderNum;
                orderfee.FeeName = od.FeeName;
                orderfee.Cost = od.Cost;
                orderfee.Extension = od.Extension;
                orderfee.Qnty = od.Qnty;
            });

            //remove deleted attachments -
            order.Attachment
                .Where(a => !orderDTO.Attachments.Any(attachDTO => attachDTO.AttachmentID == a.AttachmentId)).ToList()
                .ForEach(deleted => ctx.Attachment.Remove(deleted));
            //update or add Attachments
            orderDTO.Attachments.ToList().ForEach(ad =>
            {
                var attachmnt = order.Attachment.FirstOrDefault(r => r.AttachmentId == ad.AttachmentID);
                if (attachmnt ==null)
                {
                    attachmnt = new Attachment();
                    order.Attachment.Add(attachmnt);
                }

                attachmnt.OrderNum = ad.OrderNum;
                attachmnt.Filesource = ad.FileSource;
                attachmnt.AttachmentDescription = ad.AttachmentDescription;
                attachmnt.Ext = ad.Ext;
                attachmnt.Src = ad.Src;
                attachmnt.FileSize = ad.FileSize;
                attachmnt.Creator = ad.Creator;
                attachmnt.CreateDate = ad.CreatedDate;
            });

            context.SaveChanges();
        }

        public List<OrderListDto> FindSupplierOrders(int supplierID)
        {
            return context.PurchaseOrder
                .Include(j => j.Job)
                .Include(e => e.Employee)
                .Include(s => s.Supplier).OrderByDescending(r => r.OrderDate).Where(c => c.SupplierId == supplierID).AsNoTracking().Select(d => new OrderListDto
            {
                OrderNum = d.OrderNum,
                JobName = d.Job.Jobname,
                Purchaser = d.Employee.Firstname,
                OrderDate = d.OrderDate.GetValueOrDefault(),
                OrderTotal = d.OrderTotal.GetValueOrDefault(),
                Recieved = d.Recieved.GetValueOrDefault(),
                Supplier = d.Supplier.SupplierName
                

            }).ToList();

                
                
                
            
        }

        public List<OrderListDto> GetMyOrders(int employeeID,bool ShowRecieved)
        {

            if (ShowRecieved == true)
            {


                return context.PurchaseOrder
                   .Include(j => j.Job)
                   .Include(e => e.Employee)
                   .Include(s => s.Supplier).Where(c => c.EmployeeId == employeeID).Where(r => r.Recieved == true).OrderByDescending(r => r.OrderDate)
                   .AsNoTracking().Select(d => new OrderListDto
                   {
                       OrderNum = d.OrderNum,
                       JobName = d.Job.Jobname,
                       Purchaser = d.Employee.Firstname,
                       OrderDate = d.OrderDate.GetValueOrDefault(),
                       OrderTotal = d.OrderTotal.GetValueOrDefault(),
                       Recieved = d.Recieved.GetValueOrDefault(),
                       Supplier = d.Supplier.SupplierName

                   }).ToList();

            }
            else
            {
                return context.PurchaseOrder
                   .Include(j => j.Job)
                   .Include(e => e.Employee)
                   .Include(s => s.Supplier).Where(c => c.EmployeeId == employeeID).Where(r => r.Recieved == false).OrderByDescending(r => r.OrderDate)
                   .AsNoTracking().Select(d => new OrderListDto
                   {
                       OrderNum = d.OrderNum,
                       JobName = d.Job.Jobname,
                       Purchaser = d.Employee.Firstname,
                       OrderDate = d.OrderDate.GetValueOrDefault(),
                       OrderTotal = d.OrderTotal.GetValueOrDefault(),
                       Recieved = d.Recieved.GetValueOrDefault(),
                       Supplier = d.Supplier.SupplierName

                   }).ToList();
            }
        }
    }
}
