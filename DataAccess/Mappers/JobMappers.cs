using Boxed;
using Boxed.Mapping;
using DataAccess.Entities;
using DataAccess.DTO;
using System.Security.Cryptography;

namespace DataAccess.Mappers
{
    public class ProductMapper : IMapper<Product, ProductDto>
    {
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
        }
    }
}
