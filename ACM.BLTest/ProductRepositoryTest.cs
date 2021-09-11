using ACM.BL;
using System;
using Xunit;

namespace ACM.BLTest
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrievTest()
        {
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Flowerrs good",
                ProductName = "Flowers"
            };
            var actual = productRepository.Retrieve(2);

        }

        [Fact]
        public void SaveTestValid()
        {
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Flowerrs good",
                ProductName = "Flowers",
                HasChanges = true
            };
            var actual = productRepository.Save(updateProduct);

            Assert.True(actual);
        }

        [Fact]
        public void SaveTestValidWOPrice()
        {
            var productRepository = new ProductRepository();
            var updateProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Flowerrs good",
                ProductName = "Flowers",
                HasChanges = true
            };
            var actual = productRepository.Save(updateProduct);

            Assert.False(actual);
        }
    }
}

