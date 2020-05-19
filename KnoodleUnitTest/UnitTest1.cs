using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FrameWorks;
using Microsoft.EntityFrameworkCore;
using Weaselware.FractionalNumbers;
using System.Linq;


namespace KnoodleUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DatabaseConnectionTest()
        {
            DataAccess.ProductionContext ctx = new DataAccess.ProductionContext();

            var unit = ctx.Product.AsNoTracking().ToList();
            Assert.IsTrue(unit.Count > 1);
        }

        [TestMethod]
        public void GetUnitsAndSubAssemblies()
        {
            DataAccess.ProductionContext ctx = new DataAccess.ProductionContext();

            var unit = ctx.Product.Include(c => c.SubAssembly).ToList();
            Assert.IsTrue(unit[1].SubAssembly.Count > 1);
        }

        [TestMethod]
        public void GetSubAssemblies()
        {
            DataAccess.ProductionContext ctx = new DataAccess.ProductionContext();

            var subAssembly = ctx.SubAssembly.AsNoTracking().ToList();
            Assert.IsTrue(subAssembly.Count > 1);
        }

        [TestMethod]
        public void GetProjects()
        {
            DataAccess.ProductionContext ctx = new DataAccess.ProductionContext();

            var projects = ctx.Project.AsNoTracking().ToList();
            Assert.IsTrue(projects.Count > 0);
        }

        [TestMethod]
        public void GetAllSubAssemblyAndParts()
        {
            DataAccess.ProductionContext ctx = new DataAccess.ProductionContext();

            var subAssemblies = ctx.SubAssembly.Include( c => c.Parts).AsNoTracking().ToList();
            Assert.IsTrue(subAssemblies.Count > 0);
            Assert.IsTrue(subAssemblies[1].Parts.Count > 1);
        }

        [TestMethod]
        public void GetSubAssemblyAndParts()
        {
            DataAccess.ProductionContext ctx = new DataAccess.ProductionContext();

            var subAssembly = ctx.SubAssembly.Include(c => c.Parts).AsNoTracking().Where(l => l.SubAssemblyID==3).First();
            Assert.IsTrue(subAssembly != null);
            Assert.IsTrue(subAssembly.Parts.Count > 1);
        }

    }
}
