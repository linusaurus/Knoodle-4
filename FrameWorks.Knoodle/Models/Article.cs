using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Weaselware.Knoodle.Models
{
    /// <summary>
    /// Master Class for Identify a deliverable product
    /// </summary>
    public class Product 
    {
        [Key]
        public string ProductID { get; set; }
        public string ProductName { get; set;}
        public int JobID { get; set; }
        public int ProductionGroupID { get; set; }    
        public DateTime? ProductionDate { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Depth { get; set; }
        public string ArchRef { get; set; }

        public string Note { get; set; }

        public ICollection<Assembly> Assemblies { get; set; }
    }


    public class Assembly
    {
        [Key]
        public string AssemblyID { get; set; }
        public string AssemblyName { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Depth { get; set; }
        public decimal AssemblyPerimeter { get; set; }
        public decimal AssemblyArea { get; set; }

        public Product Product { get; set; }
        public ICollection<SubAssembly> SubAssemblies { get; set; }
    }
    public class SubAssembly
    {
        [Key]
        public string SubAssemblyID { get; set; }
        public string SubAssemblyName { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Depth { get; set; }
        public ICollection<Part> Parts { get; set; }
    }

    public class Part
    {
        [Key]
        public string PartID { get; set; }
        public string PartName { get; set; }
        public int PartGroup { get; set; }
        public decimal W { get; set; }
        public decimal H { get; set; }
        public decimal D { get; set; }
    }
}
