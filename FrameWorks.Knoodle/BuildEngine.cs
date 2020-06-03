using System.Collections.Generic;
using DataAccess;
using DataAccess.DTO;
using System.IO;
using FrameWorks;

namespace Weaselware.Knoodle
{

    public class BuildEngine
    {
        private readonly ProductionContext ctx;

        public BuildEngine(ProductionContext context)
        {
            ctx = context;
        }


        public static List<ProductDto>  BuildProducts(List<ProductDto> _products)
        { 
             
            foreach (var productDto in _products)
            {
               

                foreach (var subAssemblyDto in productDto.SubAssemblies)
                {
                    // hydrate a new class based on the makefile name
                    var sub = SubAssemblyBase.FactoryNew(subAssemblyDto.MakeFile,subAssemblyDto.SubAssemblyID);
                    sub.SubAssemblyWidth = subAssemblyDto.W.GetValueOrDefault();
                    sub.SubAssemblyHieght = subAssemblyDto.H.GetValueOrDefault();
                    sub.SubAssemblyDepth = subAssemblyDto.D.GetValueOrDefault();
                    sub.Name = subAssemblyDto.SubAssemblyName;
                    sub.ParentAssembly = productDto;
                    sub.Build();

                   ///TODO  create componentDTO and mapper

                  
                } 
                
           }

            return _products;


        }
    }
}
