using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.DTO;

namespace DataAccess.Models
{
    public class JobListDto
    {
        public int JobID { get; set; }
        public string JobName { get; set; }

        public List<ProductDto> Products { get; set; }
    }
}
