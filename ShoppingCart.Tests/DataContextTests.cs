using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Data;
using System.Linq;
using Xunit;


namespace ShoppingCartTest
{
    public class DataContextTests : BaseServiceCollection<ApplicationDbContext>
    {

        public DataContextTests()
        {
            base.CreateDBContext();
        }

        [Fact]
        public void CreateContext()
        {
            var IOC = ServiceCollection.BuildServiceProvider();
            var context = IOC.GetService<ApplicationDbContext>();

            Assert.NotNull(context);

        }

        [Fact]
        public void InMemoryDBCreatingTest()
        {
            var IOC = ServiceCollection.BuildServiceProvider();
            var context = IOC.GetService<ApplicationDbContext>();

            context.Database.EnsureCreated();
            var Count = context.Products.Count();

            Assert.True(Count > 0, "There are no products available!");
        }
    }
}



