using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Interfaces;
using System.Linq.Expressions;

namespace DataLayer.Services
{


    public class ClaimService : IClaimService
    {
        BadgerDataModel _ctx = new BadgerDataModel();

        public ClaimService(BadgerDataModel context)
        {
            _ctx = context;

        }
      

        public List<Claim> All => throw new NotImplementedException();

        public List<Claim> AllIncluding(params Expression<Func<Claim, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public List<ClaimItem> ClaimItems(int claimID)
        {
            var result = _ctx.ClaimItem.Where(c => c.ClaimId == claimID).ToList();
            return result;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Claim> EmployeeClaims(int employeeID)
        {
            throw new NotImplementedException();
        }

        public Claim Find(int id)
        {
            
            Claim c = _ctx.Claim.Where(f => f.ClaimId == id).First(); 
            return c;
        }

        public void InsertOrUpdate(Claim claim)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Create a new Claim Document
        /// </summary>
        /// <param name="OrderNum"></param>
        /// <returns>Claim</returns>
        public Claim NewClaim(int OrderNum,int Employee)
        {
            Claim _claim = null;

            if (OrderNum > 0)
            {
             _claim = new Claim();
            _claim.ClaimDate = DateTime.Today;
            _claim.OrderNum = OrderNum;
            _claim.EmployeeId = Employee;

            using (_ctx = new BadgerDataModel())
            {

                var  po = _ctx.PurchaseOrder.Where(p => p.OrderNum == OrderNum).First();
                _claim.SupplierId = po.SupplierId.Value;
                _ctx.Claim.Add(_claim);
                _ctx.SaveChanges();
                int claimID = _claim.ClaimId;
                var lineitem = po.PurchaseLineItem.ToList();

                foreach (PurchaseLineItem l in lineitem)
                {
                    ClaimItem cItem = new ClaimItem();
                    cItem.ClaimId = claimID;
                        
                    cItem.LineID = l.LineID;
                    cItem.PartID = l.PartID;
                    cItem.Bcode = l.Bcode;
                    cItem.Description = l.Description;
                    cItem.TransActionType = 1;
                    _ctx.ClaimItem.Add(cItem);

                 }

                _ctx.SaveChanges();
            }

            }
            return _claim;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Supplier Claims
        /// </summary>
        /// <param name="supplierID"></param>
        /// <returns></returns>
        public List<Claim> SupplierClaims(int supplierID)
        {
            var o = _ctx.Claim.Where(c => c.SupplierId == supplierID).ToList();
            return o;
        }
    }

}