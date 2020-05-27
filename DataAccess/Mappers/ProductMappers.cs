using Boxed;
using Boxed.Mapping;
using DataAccess.Entities;
using DataAccess.DTO;
using System.Security.Cryptography;
using DataAccess.Models;

namespace DataAccess.Mappers
{

    public class JobMapper : IMapper<Job,JobListDto>
    {
        private readonly IMapper<Product, ProductDto> productMappers = new ProductMapper();

        public void Map(Job source, JobListDto destination)
        {
            destination.JobID = source.JobID;
            destination.JobName = source.JobName;
            destination.Products = productMappers.MapList(source.Products);
        }

    }

    public class ProductMapper : IMapper<Product, ProductDto>
    {

       //private readonly IMapper<Product, ProductDto> productMapper = new ProductMapper();
        private readonly IMapper<SubAssembly, SubAssemblyDTO> subAssemblyMapper = new SubAssemblyMapper();



        public void Map(Product source, ProductDto destination)
        {
            destination.ProductID = source.ProductID;
            destination.JobID = source.JobID.GetValueOrDefault();
            destination.ArchDescription = source.ArchDescription;
            destination.ProductionDate = source.ProductionDate.GetValueOrDefault();
            destination.RoomName = source.RoomName;
            destination.UnitID = source.UnitID;
            destination.W = source.W.GetValueOrDefault();
            destination.H = source.H.GetValueOrDefault();
            destination.D = source.D.GetValueOrDefault();
            destination.Delivered = source.Delivered.GetValueOrDefault();
            destination.DeliveryDate = source.DeliveredDate.GetValueOrDefault();
            destination.Make = source.Make.GetValueOrDefault();
            destination.NIC = source.NIC.GetValueOrDefault();
            destination.SubAssemblies = subAssemblyMapper.MapList(source.SubAssembly);
        }
    }

    public class SubAssemblyMapper : IMapper<SubAssembly, SubAssemblyDTO>
        {
            public void Map(SubAssembly source, SubAssemblyDTO destination)
            {
                destination.SubAssemblyID = source.SubAssemblyID;
                destination.SubAssemblyName = source.SubAssemblyName;
                destination.ProductID = source.ProductID;
                destination.MakeFile = source.MakeFile;
                destination.W = source.W.GetValueOrDefault();
                destination.H = source.H.GetValueOrDefault();
                destination.D = source.D.GetValueOrDefault();
                destination.CPD_ID = source.CPD_id.GetValueOrDefault();
                destination.GlassPartID = source.GlassPartID.GetValueOrDefault();
  
            }
        }
    
}
