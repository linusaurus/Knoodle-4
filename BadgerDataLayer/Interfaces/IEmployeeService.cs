using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DataLayer.Models;
using DataLayer.Entities;

namespace DataLayer.Interfaces
{

    public interface IEmployeeService {
        List<EmployeeListDto> All() ; 
        String FullName(int EmpID);
        List<Employee> AllIncluding(params Expression<Func<Employee, object>>[] includeProperties);
        void Delete(int id);
        List<PurchaseOrder> EmployeeOrders(int employeeID);
        List<OrderReciept> EmployeeReciepts(int employeeID);
        Employee Find(string firstName);
        Employee Find(int id);
        void InsertOrUpdate(Employee employee);
        void Save();
    }
}