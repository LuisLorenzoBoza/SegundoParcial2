using Microsoft.VisualStudio.TestTools.UnitTesting;
using SegundoParcial.BLL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcialUnitTestProject.BLL
{
    [TestClass()]
    public class RepositoryBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Vendedor vendedor = new Vendedor();
            vendedor.IDVendedor = 1;
            vendedor.Nombre = "Lorenzo";
            vendedor.Retecion = 25;
            vendedor.Sueldo = 5000;
            vendedor.Total = 23321;
            RepositoryBase<Vendedor> repository;
            repository = new RepositoryBase<Vendedor>();
            Assert.IsTrue(repository.Guardar(vendedor));
        }
    }
}
