using System.Collections.Generic;
using System.ComponentModel;
using DataLayer.Entities;
using DataLayer.Models;


namespace DataLayer.Interfaces
{
    public interface IOrdersService {
        void Delete(int orderID);
        void Dispose();
        bool Exist(int orderID);
        PurchaseOrder Add(PurchaseOrder order);
        List<PurchaseOrder> GetAllOrders();
        List<UnitOfMeasure> GetUnits();
        BindingList<PurchaseLineItem> OrderLineItems(int purchaseOrderID);
        List<SupplierOrderDTO> GetSupplierOrdersDTO(int SupplierID);
        List<PurchaseOrder> GetJobOrders(int jobID);
        PurchaseOrder GetOrderByID(int orderNum);
        List<PurchaseOrder> GetSupplierOrders(int supplierID);
        List<OrderListDto> FindSupplierOrders(int supplierID);
        List<OrderListDto> GetMyOrders(int employeeID,bool showRecieved = false);
        List<SupplierLineItemDto> GetSupplierLineItems(int supplierID);
        void InsertOrUpdate(PurchaseOrder order);
        PurchaseOrder NewDefault(int employee, int supplierId, int jobID);
        OrderReciept RecievedOrder(PurchaseOrder order, int employeeID);
        OrderDetailDto GetOrderDTO(int orderID);
        List<LineItemDto> GetLineItems(int orderID);
        void CreateOrUpdateOrder(OrderDetailDto orderDTO);
        void Save();
    }
}