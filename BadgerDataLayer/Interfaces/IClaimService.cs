using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataLayer.Entities;

namespace DataLayer.Interfaces
{
    public interface IClaimService
    {
        List<Claim> All { get; }
        Claim NewClaim(int OrderNum,int EmployeeID);
        List<Claim> AllIncluding(params Expression<Func<Claim, object>>[] includeProperties);
        void Delete(int id);
        List<ClaimItem> ClaimItems(int claimID);
        List<Claim> SupplierClaims(int supplierID);
        List<Claim> EmployeeClaims(int employeeID);
        Claim Find(int id);
        void InsertOrUpdate(Claim claim);
        void Save();
    }


}