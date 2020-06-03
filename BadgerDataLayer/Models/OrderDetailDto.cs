using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using DataLayer.Entities;

namespace DataLayer.Models
{
    public class OrderDetailDto : INotifyPropertyChanged
    {
        private decimal tax;
        private decimal shippingCost;
        private bool taxable;
        private int shipID;
        private string supplierZip;
        private string supplierState;
        private string supplierCity;
        private string supplierAddress;
        private decimal orderTotal;
        private DateTime expectedDate;
        private string orderDate;
        private string purchaser;
        private string supplierFax;
        private string supplierPhone;
        private string supplierName;
        private int supplierID;
        private string jobCostName;
        private string jobName;
        private int jobID;
        private int purchaseOrderID;
        private string memo;
        private int employeeID;
        private string salesRep;
        private decimal subTotal;
 

        public event PropertyChangedEventHandler PropertyChanged;

        // PurchaseOrderID
        [Key]
        public int PurchaseOrderID
        {
            get {return purchaseOrderID ; }
            set 
            {
              purchaseOrderID = value  ;
                OnPropertyChange();
            }
        }
        // JobID
        public int JobID
        {
            get {return jobID; }
            set
            {
                jobID = value ;
                OnPropertyChange();
            } 
        }
        // EmployeeID
        public int EmployeeID
        {
            get { return employeeID; }
            set
            {
                employeeID = value;
                OnPropertyChange();
            }
        }
        // Job Name
        public string JobName
        {
            get {return jobName; }
            set 
            {
                jobName = value;
                OnPropertyChange();
            }
        }
        // Job Cost Name
        public string JobCostName 
        {
            get {return jobCostName; }
            set 
            {
                jobCostName = value;
                OnPropertyChange();
            }
        }
        // SupplierID
        public int SupplierID
        {
            get {return supplierID; }
            set 
            {
                supplierID = value;
                OnPropertyChange();
            }
        }
        // Supplier Name
        public string SupplierName 
        {
            get {return supplierName; }
            set 
            {
                supplierName = value;
                OnPropertyChange();
            }
        } 
        // Supplier Phone
        public string SupplierPhone
        {
            get {return supplierPhone; }
            set 
            {
                supplierPhone = value;
                OnPropertyChange();
            } 
        } 
        // Supplier Fax
        public string SupplierFax
        {
            get {return supplierFax; }
            set 
            {
                supplierFax = value;
                OnPropertyChange();
            }
        }
        // Purchaser
        public string Purchaser
        {
            get {return purchaser; }
            set 
            {
                purchaser = value;
                OnPropertyChange();
            } 
        }
        // SaleRep
        public string SalesRep
        {
            get { return salesRep; }
            set
            {
                salesRep = value;
                OnPropertyChange();
            }
        }
        // Order Date
        public string OrderDate
        {
            get {return orderDate; }
            set
            {
                orderDate = value;
                OnPropertyChange();
            } 
        }
        // Expected Date
        public DateTime ExpectedDate 
        {
            get {return expectedDate; }
            set 
            {
                expectedDate = value;
                OnPropertyChange();
            } 
        }
        // Order Total
        public decimal OrderTotal
        {
            get {return orderTotal; }
            set
            {
                orderTotal = value;
                OnPropertyChange();
            }  
        }
        // SupplierAddress --
        public string SupplierAddress
        {
            get {return supplierAddress; }
            set
            {
                supplierAddress = value;
                OnPropertyChange();
            }
        
        }
        // SupplierCity --
        public string SupplierCity
        {
            get {return supplierCity; }
            set
            {
                supplierCity = value ;
                OnPropertyChange();
            }
        }
        // SuppllierState
        public string SupplierState
        {
            get {return supplierState; }
            set
            {  
                supplierState = value;
                OnPropertyChange();
            }
        }
        // Memo
        public string Memo
        {
            get { return memo; }
            set 
            {
                memo = value;
                OnPropertyChange();
            }
        }
        // SupplierZip
        public string SupplierZip
        {
            get {return supplierZip; }
            set 
            {   
              supplierZip = value  ;
              OnPropertyChange();
            } 
        
        }
        // ShipID --
        public int ShipID
        {
            get {return shipID; }
            set 
            { 
                shipID = value;
                OnPropertyChange();
            } 
        }
        // Taxable--
        public bool Taxable
        {
            get {return taxable; }
            set {
                
                taxable = value;
                Update();
                OnPropertyChange();
            }
        
        }
        // ShippingCost
        public decimal ShippingCost
        {
            get {return shippingCost; }
            set
            {
                shippingCost = value;
                OnPropertyChange();
            }
        }
        // Tax
        public decimal Tax
        {
            get {return tax; }
            set
            {
                tax = value;
                OnPropertyChange();
            } 
        
        }
        // SubTotal
        public decimal SubTotal
        {
            get {return subTotal; }
            set
            {
                subTotal = value;             
                OnPropertyChange();
            }
        }

        public void Update()
        {
            decimal subtotal = decimal.Zero;
            if (LineItems != null && LineItems.Count > 0)
            {
                foreach (LineItemDto item in LineItems)
                {
                    subtotal += item.Price * item.Quantity;
                }
                SubTotal = subtotal;
                if (Taxable) { Tax = subtotal * 0.075m; }else
                { Tax = 0.0m; }

                OrderTotal = SubTotal + tax;
            }
        }
 
        public IList<LineItemDto> LineItems { get; set; } = new List<LineItemDto>();
        public IList<OrderFeeDto> OrderFees { get; set; } = new List<OrderFeeDto>();
        public IList<AttachmentDto> Attachments { get; set; } = new List<AttachmentDto>();
        

        protected void OnPropertyChange([CallerMemberName] string name=null)
        {        
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
