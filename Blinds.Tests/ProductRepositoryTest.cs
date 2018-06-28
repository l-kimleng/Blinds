using System;
using System.Threading.Tasks;
using Blinds.Core.Models;
using Blinds.Core.Persistences;
using Blinds.Core.Persistences.Repositories;
using NUnit.Framework;

namespace Blinds.Tests
{
    [TestFixture]
    public class ProductRepositoryTest
    {
        private BlindsDbContext _context;

        [SetUp]
        public void Setup()
        {
            _context = BlindsDbContext.Create();
        }

        private IProductRepository _productRepository;

        public IProductRepository ProductRepository
        {
            get
            {
                if (_productRepository == null)
                {
                    return _productRepository = new ProductRepository(_context);
                }
                return _productRepository;
            }
        }

        [Test]
        public async Task ProductRepository_Get_OrderAscendingByPrice()
        {
            var query = new ProductQuery
            {
                Name = "",
                BrandId = -1,
                IsSortAscending = true,
                Page = 1,
                PageSize = 10
            };

            var result = await ProductRepository.Get(query);

            Assert.That(result, Is.Ordered.By("Price"));
        }
    }
}
