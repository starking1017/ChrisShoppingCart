using System.Linq;
using ShoppingCart.Models.Product;
using ShoppingCart.Repositories;
using ShoppingCart.Models.Cart;
using Microsoft.AspNetCore.Identity;
using ShoppingCart.Data;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Controllers;
using Xunit;
using ShoppingCart.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Carts.Controllers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Moq;

namespace ShoppingCartTest
{
    public class ControllerTests : BaseServiceCollection<ApplicationDbContext>
    {
        private ServiceProvider _IOC;

        public ControllerTests()
        {
            base.CreateDBContext();
            AddRepositoriesToServiceCollection();

            _IOC = ServiceCollection.BuildServiceProvider();

            Operation.Configure(_IOC.GetService<IHttpContextAccessor>(), _IOC.GetService<ApplicationDbContext>());

            InitProductAndComment();
            InitOrderAndOrderDetail();
            InitUser();
        }



        private void InitProductAndComment()
        {
            var productManager = _IOC.GetService<IProductManager>();

            var product = new Product()
            {
                Id = 1,
                Name = "Book",
                Description = "This is a book"
            };

            var productComment1 = new ProductCommet()
            {
                Id = 1,
                ProductId = 1,
                Content = "This is good.",
                CreateDate = DateTime.Now
            };
            var productComment2 = new ProductCommet()
            {
                Id = 2,
                ProductId = 1,
                Content = "This is bad.",
                CreateDate = DateTime.Now
            };

            productManager.ProductRepo.Create(product);
            productManager.ProductCommentRepo.Create(productComment1);
            productManager.ProductCommentRepo.Create(productComment2);
        }
        private void InitOrderAndOrderDetail()
        {
            var OrderManager = _IOC.GetService<IOrderManager>();

            var order = new Order()
            {
                Id = 1,
                UserId = "1",
                UserName = "Chris",
                RecieverName = "tester",
                RecieverAddress = "Canada",
                RecieverPhone = "585984551"
            };

            var orderDetail1 = new OrderDetail()
            {
                Id = 1,
                OrderId = 1,
                Price = 1m,
                Quantity = 1
            };
            var orderDetail2 = new OrderDetail()
            {
                Id = 2,
                OrderId = 1,
                Price = 1m,
                Quantity = 1
            };

            OrderManager.OrderRepo.Create(order);
            OrderManager.OrderDetailRepo.Create(orderDetail1);
            OrderManager.OrderDetailRepo.Create(orderDetail2);
        }
        private void InitUser()
        {
            var userManager = _IOC.GetService<IRepositoryBase<IdentityUser>>();

            var user = new IdentityUser()
            {
                Id = "1",
                Email = "chris@gmail.com",
                UserName = "Chris"
            };

            userManager.Create(user);
        }
        private void AddRepositoriesToServiceCollection()
        {
            ServiceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            ServiceCollection.AddScoped<ICartItemRepository, CartItemRepository>();
            ServiceCollection.AddScoped<IRepositoryBase<IdentityUser>, UserRepository>();

            ServiceCollection.AddScoped<IProductManager, ProductManager>();
            ServiceCollection.AddScoped<IOrderManager, OrderManager>();
        }


        #region HomeController
        [Fact]
        public void HomeControllerIndexTest()
        {
            var productManager = _IOC.GetService<IProductManager>();
            HomeController home = new HomeController(productManager);

            ViewResult result = home.Index() as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Product>>(result.ViewData.Model);
            Assert.Single(model);
        }

        [Fact]
        public void HomeControllerIndexProductSearchTest()
        {
            var productManager = _IOC.GetService<IProductManager>();
            HomeController home = new HomeController(productManager);

            ViewResult result = home.Index("Book") as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Product>>(result.ViewData.Model);
            Assert.Single(model);
        }

        [Fact]
        public void HomeControllerDetailOfProductTest()
        {
            var productManager = _IOC.GetService<IProductManager>();
            HomeController home = new HomeController(productManager);

            ViewResult result = home.Details(1) as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<Product>(result.ViewData.Model);
            Assert.NotNull(model);
        }
        #endregion

        #region OrderController
        [Fact]
        public void OrderControllerIndexTest()
        {
            var orderManager = _IOC.GetService<IOrderManager>();
            OrderController order = new OrderController(orderManager);

            ViewResult result = order.Index() as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        #endregion

        #region CartController
        [Fact]
        public void CartControllerIndexTest()
        {
            var cartRepo = _IOC.GetService<ICartItemRepository>();
            CartController order = new CartController(cartRepo);

            ViewResult result = order.Index() as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void CartControllerGetCartTest()
        {
            var cartRepo = _IOC.GetService<ICartItemRepository>();
            CartController order = new CartController(cartRepo);

            PartialViewResult result = order.GetCart() as PartialViewResult;

            Assert.NotNull(result);
            Assert.IsType<PartialViewResult>(result);
        }

        #endregion

        #region ProductController
        [Fact]
        public void ProductControllerIndexTest()
        {
            var productManager = _IOC.GetService<IProductManager>();
            ProductController product = new ProductController(productManager);

            var httpContext = new DefaultHttpContext();
            product.TempData = new TempDataDictionary(httpContext, Mock.Of<ITempDataProvider>());
            ViewResult result = product.Index() as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<Product>>(result.ViewData.Model);
            Assert.Single(model);
        }

        [Fact]
        public void ProductControllerCreateTest()
        {
            var productManager = _IOC.GetService<IProductManager>();
            ProductController product = new ProductController(productManager);

            ViewResult result = product.Create() as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void ProductControllerCreateWithProductTest()
        {
            var productManager = _IOC.GetService<IProductManager>();
            ProductController product = new ProductController(productManager);

            var newProduct = new Product()
            {
                Id = 2,
                Name = "Test Product",
                Description = "This is a book"
            };

            var httpContext = new DefaultHttpContext();
            product.TempData = new TempDataDictionary(httpContext, Mock.Of<ITempDataProvider>());

            var result = product.Create(newProduct);
            Assert.Equal(2, productManager.ProductRepo.FindAll().Count());
        }

        [Fact]
        public void ProductControllerEditProductTest()
        {
            var productManager = _IOC.GetService<IProductManager>();
            ProductController product = new ProductController(productManager);


            var httpContext = new DefaultHttpContext();
            product.TempData = new TempDataDictionary(httpContext, Mock.Of<ITempDataProvider>());

            ViewResult result = product.Edit(1) as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void ProductControllerEditAndUpateProductTest()
        {
            var productManager = _IOC.GetService<IProductManager>();
            ProductController product = new ProductController(productManager);


            var httpContext = new DefaultHttpContext();
            product.TempData = new TempDataDictionary(httpContext, Mock.Of<ITempDataProvider>());

            var currectProduct = productManager.ProductRepo.FindAll().FirstOrDefault();
            currectProduct.Name = "Update Book";
            ViewResult result = product.Edit(currectProduct) as ViewResult;

            Assert.Equal("Update Book", productManager.ProductRepo.FindAll().FirstOrDefault().Name);
        }

        [Fact]
        public void ProductControllerDeleteProductTest()
        {
            var productManager = _IOC.GetService<IProductManager>();
            ProductController product = new ProductController(productManager);

            var httpContext = new DefaultHttpContext();
            product.TempData = new TempDataDictionary(httpContext, Mock.Of<ITempDataProvider>());

            var currectProduct = productManager.ProductRepo.FindAll().FirstOrDefault();
            ViewResult result = product.Delete(1) as ViewResult;

            Assert.Empty(productManager.ProductRepo.FindAll());
        }
        #endregion

        #region ManagerOrderController
        [Fact]
        public void ManagerOrderControllerIndexTest()
        {
            var orderManager = _IOC.GetService<IOrderManager>();
            ManageOrderController managerOrder = new ManageOrderController(orderManager);

            ViewResult result = managerOrder.Index() as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void ManagerOrderControllerOrderDetailTest()
        {
            var orderManager = _IOC.GetService<IOrderManager>();
            ManageOrderController managerOrder = new ManageOrderController(orderManager);

            ViewResult result = managerOrder.Details(1) as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void ManagerOrderControllerSearchOrderByNameTest()
        {
            var orderManager = _IOC.GetService<IOrderManager>();
            ManageOrderController managerOrder = new ManageOrderController(orderManager);

            ViewResult result = managerOrder.SerachByUserName("tester") as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);

            var model = result.Model as IEnumerable<Order>;
            Assert.Single(model);
        }
        #endregion

        #region ManageUserController
        [Fact]
        public void ManageUserControllerIndexTest()
        {
            var userRepo = _IOC.GetService<IRepositoryBase<IdentityUser>>();
            ManageUserController managerUser = new ManageUserController(userRepo);

            var httpContext = new DefaultHttpContext();
            managerUser.TempData = new TempDataDictionary(httpContext, Mock.Of<ITempDataProvider>());

            ViewResult result = managerUser.Index() as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void ManageUserControllerEditTest()
        {
            var userRepo = _IOC.GetService<IRepositoryBase<IdentityUser>>();
            ManageUserController managerUser = new ManageUserController(userRepo);

            var httpContext = new DefaultHttpContext();
            managerUser.TempData = new TempDataDictionary(httpContext, Mock.Of<ITempDataProvider>());

            ViewResult result = managerUser.Edit("1") as ViewResult;

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);

            var model = result.Model as IdentityUser;
            Assert.Equal("Chris",model.UserName);
        }

        [Fact]
        public void ManageUserControllerUpdateUserTest()
        {
            var userRepo = _IOC.GetService<IRepositoryBase<IdentityUser>>();
            ManageUserController managerUser = new ManageUserController(userRepo);

            var httpContext = new DefaultHttpContext();
            managerUser.TempData = new TempDataDictionary(httpContext, Mock.Of<ITempDataProvider>());

            var currentUser = userRepo.FindAll().FirstOrDefault();
            currentUser.UserName = "New Chris";

            ViewResult result = managerUser.Edit(currentUser) as ViewResult;

            var newUser = userRepo.FindAll().FirstOrDefault();
            Assert.Equal("New Chris", newUser.UserName);
        }
        #endregion

    }
}
