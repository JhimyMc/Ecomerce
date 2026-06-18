using Xunit;
using ECommerce.Models;

namespace ECommerce.Tests
{
    public class ProductTests
    {
        [Fact]
        public void EstaEnStock_DeberiaRetornarTrue_CuandoStockMayorACero()
        {
            var producto = new Product
            {
                Id = 1,
                Name = "Nike Air Max 90",
                Price = 459.90m,
                Stock = 25
            };

            Assert.True(producto.EstaEnStock());
        }

        [Fact]
        public void EstaEnStock_DeberiaRetornarFalse_CuandoStockEsCero()
        {
            var producto = new Product
            {
                Id = 2,
                Name = "Adidas Ultraboost 22",
                Price = 699.90m,
                Stock = 0
            };

            Assert.False(producto.EstaEnStock());
        }
    }
}
