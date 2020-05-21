using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccess;
using DataAccess.Entities;
using DataAccess.DTO;

namespace DataAccess.Service
{
    public class ProductService
    {
        private readonly ProductionContext ctx;

        public ProductService(ProductionContext context)
        {
            ctx = context;
           
        }

       public List<Product> GetJobUnits(int jobID)
        {
            return ctx.Product.Include(p => p.SubAssembly).Where(j => j.JobID == jobID).ToList();
        }

        public List<ProductDto> GetProducts(int jobID)
        {
            var product = ctx.Product.Include(r => r.SubAssembly).Where(p => p.JobID == jobID).Select(d => new ProductDto
            {
                ProductID = d.ProductID,
                ProductionDate = d.ProductionDate.GetValueOrDefault(),
                ArchDescription = d.ArchDescription,
                JobID = d.JobID.GetValueOrDefault(),
                UnitID = d.UnitID,
                UnitName = d.UnitName,
                RoomName = d.RoomName,
                W = d.W.GetValueOrDefault(),
                D = d.D.GetValueOrDefault(),
                H = d.H.GetValueOrDefault(),
                Delivered = d.Delivered.GetValueOrDefault(),
                DeliveryDate = d.DeliveredDate.GetValueOrDefault(),
                Make = d.Make.GetValueOrDefault(),
                NIC = d.NIC.GetValueOrDefault()

            }).ToList() ;

            return product;
        }

        public Product AddUnit(Product unit)
        {           
            ctx.Add(unit);
            ctx.SaveChanges();        
            return unit;
        }

        public void AddOrUpdate(ProductDto productDTO)
        {
            var product = ctx.Product.FirstOrDefault(o => o.ProductID == productDTO.ProductID);

            if (productDTO.IsDeleted == true)
            {
                ctx.Remove(product).State = EntityState.Deleted;
                
                
            }
            if (product == null)
            {
                product = new Product();
                ctx.Product.Add(product);
            }
            
            

            // Map properties
            product.ArchDescription = productDTO.ArchDescription;
            product.ProductionDate = productDTO.ProductionDate;
            product.RoomName = productDTO.RoomName;
            product.Delivered = productDTO.Delivered.GetValueOrDefault();
            product.DeliveredDate = productDTO.DeliveryDate;
            product.JobID = productDTO.JobID;
            product.Make = productDTO.Make;
            product.W = productDTO.W.GetValueOrDefault();
            product.H = productDTO.H.GetValueOrDefault();
            product.D = productDTO.D.GetValueOrDefault();
            product.UnitID = productDTO.UnitID;
            product.UnitName = productDTO.UnitName;
            product.NIC = productDTO.NIC;

           

            ctx.SaveChanges();
        }
       
    }
}
