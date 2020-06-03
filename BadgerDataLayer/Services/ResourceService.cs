using DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entities;
using DataLayer.Models;
using System.Linq;

namespace DataLayer.Services
{
    public class ResourceService 
    {

        private readonly BadgerDataModel ctx;

        // Constructor ----------------------
        public ResourceService(BadgerDataModel Context)
        { ctx = Context;}

        public void CreateOrUpdateOrder(ResourceDto resourceDTO)
        {            
            var resource = ctx.Resource.FirstOrDefault(o => o.ResourceID == resourceDTO.ResourceID);
            if (resource == null)
            {
                resource = new Resource();               
                ctx.Resource.Add(resource);
                // Save to DB to get the new ID --

                ctx.SaveChanges();
             }
            //Map properties --------------------------------------------------
            resource.Createdby = resourceDTO.Createdby;
            resource.CurrentVersion = resourceDTO.CurrentVersion;
            resource.ResourceDescription = resourceDTO.ResourceDescription;
            //resource.ResourceID = resourceDTO.ResourceID;

            //remove deleted details -
            resource.Versions
            .Where(d => !resourceDTO.Versions.Any(ResourceVersionDto => ResourceVersionDto.ResourceVersionID == d.ResourceVersionID)).ToList()
            .ForEach(deleted => ctx.ResourceVersion.Remove(deleted));

            //update or add details
            resourceDTO.Versions.ToList().ForEach(ResourceVersionDTO =>
            {
                var detail = resource.Versions.FirstOrDefault(d => d.ResourceVersionID == ResourceVersionDTO.ResourceVersionID);
                if (detail == null)
                {
                    detail = new ResourceVersion();
                    resource.Versions.Add(detail);
                }

                detail.ResourceID = resource.ResourceID;
                detail.Resource = ResourceVersionDTO.Resource;
                //detail.ResourceVersionID = ResourceVersionDTO.ResourceVersionID;
                detail.RVersion = ResourceVersionDTO.RVersion;

            });


            ctx.SaveChanges();
        }
    }
}
