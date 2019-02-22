using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ahbc.SampleLab.eCommerce.Models;
using Ahbc.SampleLab.eCommerce.Repositories;
using Ahbc.SampleLab.eCommerce.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ahbc.SampleLab.eCommerce.UnitTests.Services
{
    [TestClass]
    public class ProductServiceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var sut = new ProductService(new TestProductRepository());

            // Act

            // Assert
        }
    }

    public class TestProductRepository : IProductRepository
    {
        public void Dispose()
        {
        }

        public Task<IEnumerable<Product>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Product> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
