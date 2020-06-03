using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;


namespace DataLayer.Services {
    public class EmployeeService : IEmployeeService {

        BadgerDataModel context = new BadgerDataModel();

        public EmployeeService(BadgerDataModel Context) {

            context = Context;
        }

        public List<EmployeeListDto> All()
        {
            var _emps = context.Employee.AsNoTracking().OrderBy(p => p.Lastname).Select(d => new EmployeeListDto
            {
                EmployeeID = d.EmployeeId,
                FullName = String.Format("{0} {1}",d.Firstname, d.Lastname)

            }).ToList();
            return _emps; 
        }

        public List<Employee> AllIncluding(params System.Linq.Expressions.Expression<Func<Employee, object>>[] includeProperties) {
            throw new NotImplementedException();
        }

        public Employee Find(int id) {
            return context.Employee.Find(id);
        }

        public List<PurchaseOrder> EmployeeOrders(int employeeID) {

            return context.PurchaseOrder.Where(e => e.EmployeeId == employeeID).ToList();
        }

        public List<OrderReciept> EmployeeReciepts(int employeeID) {

            return context.OrderReciept.Where(e => e.EmployeeId == employeeID).ToList();
        }

        public Employee Find(string firstName) {

            return context.Employee.Where(e => e.Firstname.Contains(firstName)).FirstOrDefault();
        }

        public void InsertOrUpdate(Employee employee) {
            if (employee.EmployeeId == default(int))
            { context.Entry(employee).State = EntityState.Added; }

            else
            { context.Entry(employee).State = EntityState.Modified; }

        }

        public void Delete(int id) {
            var employee = context.Employee.Find(id);
            context.Employee.Remove(employee);
        }

        public void Save() {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context = null;
            this.Dispose();
        }

        public string FullName(int EmpID)
        {
            Employee emp =  context.Employee.Find(EmpID);
            return emp.Firstname + " " + emp.Lastname;
        }

       
    }
}
