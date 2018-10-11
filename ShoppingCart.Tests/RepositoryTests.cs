using System;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using ShoppingCart.Data;
using System.Linq;
using ShoppingCart.Models.Product;
using ShoppingCart.Repositories;
using ShoppingCart.Models.Cart;
using Microsoft.AspNetCore.Identity;
using ShoppingCart.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ShoppingCartTest
{
    public class RepositoryTests : BaseServiceCollection<ApplicationDbContext>
    {
        private ServiceProvider _IOC;
        private ApplicationDbContext _context;

        public RepositoryTests()
        {
            // Assign
            CreateDBContext();
            AddRepositoriesToServiceCollection();

            _IOC = ServiceCollection.BuildServiceProvider();
            _context = _IOC.GetService<ApplicationDbContext>();

            InitProductAndProductComment();
            InitOneCartItem();
            InitOneUser();
            InitOrder();
        }

        private void InitOrder()
        {
            var order = new Order()
            {
                Id = 1,
                UserId = "1",
                UserName = "Chris",
                RecieverName = "chris",
                RecieverAddress = "This is address",
                RecieverPhone = "This is phone",
            };

            var orderDetail1 = new OrderDetail()
            {
                Id = 1,
                OrderId = 1,
                Name = "This is a item1.",
                Quantity = 1,
                Price = 1m
            };
            var orderDetail2 = new OrderDetail()
            {
                Id = 2,
                OrderId = 1,
                Name = "This is a item2.",
                Quantity = 1,
                Price = 1m
            };

            _context.Orders.Add(order);
            _context.OrderDetails.Add(orderDetail1);
            _context.OrderDetails.Add(orderDetail2);
            _context.SaveChanges();
        }
        private void InitProductAndProductComment()
        {
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

            _context.Products.Add(product);
            _context.ProductCommets.Add(productComment1);
            _context.ProductCommets.Add(productComment2);
            _context.SaveChanges();

        }
        private void InitOneCartItem()
        {
            var cartItem = new CartItem()
            {
                Id = 1,
                Name = "new Cart Item"
            };

            _context.CartItem.Add(cartItem);
            _context.SaveChanges();

        }
        private void InitOneUser()
        {
            var user = new IdentityUser()
            {
                Id = "1",
                UserName = "Chris",
                Email = "chris@gmail.com"
            };
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        private void AddRepositoriesToServiceCollection()
        {
            ServiceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            ServiceCollection.AddScoped<ICartItemRepository, CartItemRepository>();
            ServiceCollection.AddScoped<IRepositoryBase<IdentityUser>, UserRepository>();

            ServiceCollection.AddScoped<IProductManager, ProductManager>();
            ServiceCollection.AddScoped<IOrderManager, OrderManager>();
            ServiceCollection.AddScoped<ApplicationDbContext, ApplicationDbContext>();
        }

        #region CartItemRepo
        [Fact]
        public void CartItemRespositoryGetAllTest()
        {
            var cartItemRepo = _IOC.GetService<ICartItemRepository>();
            var collection = cartItemRepo.FindAll();

            Assert.NotNull(collection);
            Assert.Single(collection);
        }
        [Fact]
        public void CartItemRespositoryFindByConditionTest()
        {
            var cartItemRepo = _IOC.GetService<ICartItemRepository>();
            var collection = cartItemRepo.FindByCondition(p => p.Id == 1);

            Assert.NotNull(collection);
            Assert.Single(collection);
        }
        [Fact]
        public void CartItemRespositoryInsertTest()
        {
            var cartItemRepo = _IOC.GetService<ICartItemRepository>();
            var cartItem = new CartItem()
            {
                Id = 2,
                Name = "new Cart Item2"
            };
            cartItemRepo.Create(cartItem);

            var cartItemFromContext = cartItemRepo.FindAll();
            Assert.NotNull(cartItemFromContext);
            Assert.Equal(2, cartItemFromContext.Count());
        }
        [Fact]
        public void CartItemRespositoryDeleteTest()
        {
            var cartItemRepo = _IOC.GetService<ICartItemRepository>();

            var cartItem = new CartItem()
            {
                Id = 999,
                Name = "new Cart Item"
            };

            cartItemRepo.Create(cartItem);
            cartItemRepo.Delete(cartItem);

            var result = cartItemRepo.FindByCondition(p => p.Id == 999).FirstOrDefault();

            Assert.Null(result);
        }
        [Fact]
        public void CartItemRespositoryUpdateTest()
        {
            var cartItemRepo = _IOC.GetService<ICartItemRepository>();
            var cartItem = new CartItem()
            {
                Id = 999,
                Name = "new Cart Item"
            };
            cartItemRepo.Create(cartItem);

            var cartItemFromContext = cartItemRepo.FindByCondition(p => p.Id == 999).FirstOrDefault();

            cartItemFromContext.Name = "update new Cart Item";
            cartItemRepo.Update(cartItemFromContext);

            var result = cartItemRepo.FindByCondition(p => p.Id == 999).FirstOrDefault();

            Assert.Equal("update new Cart Item", result.Name);
        }
        #endregion

        #region UserRepo
        [Fact]
        public void UserRespositoryGetAllTest()
        {
            var userRepo = _IOC.GetService<IRepositoryBase<IdentityUser>>();
            var collection = userRepo.FindAll();

            Assert.NotNull(collection);
            Assert.Single(collection);
        }
        [Fact]
        public void UserRespositoryFindByConditionTest()
        {
            var userRepo = _IOC.GetService<IRepositoryBase<IdentityUser>>();
            var collection = userRepo.FindByCondition(p => p.UserName == "Chris");

            Assert.NotNull(collection);
            Assert.Single(collection);
        }
        [Fact]
        public void UserRespositoryInsertTest()
        {
            var userRepo = _IOC.GetService<IRepositoryBase<IdentityUser>>();
            var user = new IdentityUser()
            {
                Id = "2",
                UserName = "Chris2",
                Email = "chris2@gmail.com"
            };
            userRepo.Create(user);

            var cartItemFromContext = userRepo.FindAll();
            Assert.NotNull(cartItemFromContext);
            Assert.Equal(2, cartItemFromContext.Count());
        }
        [Fact]
        public void UserRespositoryDeleteTest()
        {
            var userRepo = _IOC.GetService<IRepositoryBase<IdentityUser>>();

            var user = new IdentityUser()
            {
                Id = "2",
                UserName = "Chris2",
                Email = "chris2@gmail.com"
            };

            userRepo.Create(user);
            userRepo.Delete(user);

            var result = userRepo.FindByCondition(p => p.UserName == "Chris2").FirstOrDefault();

            Assert.Null(result);
        }
        [Fact]
        public void UserRespositoryUpdateTest()
        {
            var userRepo = _IOC.GetService<IRepositoryBase<IdentityUser>>();

            var userFromContext = userRepo.FindByCondition(p => p.UserName == "Chris").FirstOrDefault();
            userFromContext.UserName = "update Chris";

            userRepo.Update(userFromContext);

            var result = userRepo.FindByCondition(p => p.UserName == "update Chris").FirstOrDefault();

            Assert.NotNull(result);
        }

        #endregion

        #region ProductManager
        [Fact]
        public void ProductManagerGetAllTest()
        {
            var productManager = _IOC.GetService<IProductManager>();
            var productCollection = productManager.ProductRepo.FindAll();
            var ProductCommentCollection = productManager.ProductCommentRepo.FindAll();

            Assert.NotNull(productCollection);
            Assert.NotNull(ProductCommentCollection);
            Assert.True(productCollection.Count() > 0, "Did not retrieve all the product");
            Assert.True(ProductCommentCollection.Count() > 0, "Did not retrieve all the ProductComment");
        }

        [Fact]
        public void ProductManagerFindByConditionTest()
        {
            var productManager = _IOC.GetService<IProductManager>();
            var productCollection = productManager.ProductRepo.FindByCondition(p => p.Id == 1);
            var ProductCommentCollection = productManager.ProductCommentRepo.FindByCondition(p => p.ProductId == 1);

            Assert.NotNull(productCollection);
            Assert.NotNull(ProductCommentCollection);
            Assert.True(productCollection.Count() > 0, "Did not retrieve all the product");
            Assert.True(ProductCommentCollection.Count() > 0, "Did not retrieve all the ProductComment");
        }

        [Fact]
        public void ProductManagerInsertTest()
        {
            var productManager = _IOC.GetService<IProductManager>();
            var product = new Product()
            {
                Id = 2,
                Name = "Book",
                Description = "This is a book"
            };

            var productComment1 = new ProductCommet()
            {
                Id = 998,
                ProductId = 2,
                Content = "This is good.",
                CreateDate = DateTime.Now
            };
            var productComment2 = new ProductCommet()
            {
                Id = 999,
                ProductId = 2,
                Content = "This is bad.",
                CreateDate = DateTime.Now
            };

            productManager.ProductRepo.Create(product);
            productManager.ProductCommentRepo.Create(productComment1);
            productManager.ProductCommentRepo.Create(productComment2);

            var result1 = productManager.ProductRepo.FindByCondition(p => p.Id == 2).FirstOrDefault();
            var result2 = productManager.ProductCommentRepo.FindByCondition(p => p.ProductId == 2).FirstOrDefault();

            Assert.NotNull(result1);
            Assert.NotNull(result2);
        }

        [Fact]
        public void ProductManagerDeleteTest()
        {
            var productManager = _IOC.GetService<IProductManager>();

            var product = productManager.ProductRepo.FindAll().FirstOrDefault();
            var productDetail = productManager.ProductCommentRepo.FindByCondition(p => p.ProductId == product.Id);

            productManager.ProductRepo.Delete(product);
            foreach (var detail in productDetail)
            {
                productManager.ProductCommentRepo.Delete(detail);
            }

            var result1 = productManager.ProductRepo.FindAll();
            var result2 = productManager.ProductCommentRepo.FindAll();

            Assert.Empty(result1);
            Assert.Empty(result2);
        }

        [Fact]
        public void ProductManagerUpdateTest()
        {
            var productManager = _IOC.GetService<IProductManager>();

            var productFromContext = productManager.ProductRepo.FindByCondition(p => p.Id == 1).FirstOrDefault();
            productFromContext.Name = "update Book";
            productManager.ProductRepo.Update(productFromContext);
            var result1 = productManager.ProductRepo.FindByCondition(p => p.Id == 1).FirstOrDefault();

            var productCommentFromContext = productManager.ProductCommentRepo.FindByCondition(p => p.Id == 1).FirstOrDefault();
            productCommentFromContext.Content = "update This is good";
            productManager.ProductCommentRepo.Update(productCommentFromContext);
            var result2 = productManager.ProductCommentRepo.FindByCondition(p => p.Id == 1).FirstOrDefault();

            Assert.Equal("update Book", result1.Name);
            Assert.Equal("update This is good", result2.Content);
        }

        #endregion

        #region OrderManager
        [Fact]
        public void OrderManagerGetAllTest()
        {
            var OrderManager = _IOC.GetService<IOrderManager>();
            var orderCollection = OrderManager.OrderRepo.FindAll();
            var orderCommentCollection = OrderManager.OrderDetailRepo.FindAll();

            Assert.NotNull(orderCollection);
            Assert.NotNull(orderCommentCollection);
            Assert.True(orderCollection.Count() > 0, "Did not retrieve all the order");
            Assert.True(orderCommentCollection.Count() > 0, "Did not retrieve all the orderComment");
        }

        [Fact]
        public void OrderManagerFindByConditionTest()
        {
            var OrderManager = _IOC.GetService<IOrderManager>();
            var orderCollection = OrderManager.OrderRepo.FindByCondition(p => p.Id == 1);
            var orderCommentCollection = OrderManager.OrderDetailRepo.FindByCondition(p => p.OrderId == 1);

            Assert.NotNull(orderCollection);
            Assert.NotNull(orderCommentCollection);
            Assert.True(orderCollection.Count() > 0, "Did not retrieve all the order");
            Assert.True(orderCommentCollection.Count() > 0, "Did not retrieve all the orderComment");
        }

        [Fact]
        public void OrderManagerInsertTest()
        {
            var OrderManager = _IOC.GetService<IOrderManager>();
            var order = new Order()
            {
                Id = 2,
                UserName = "chris",
                RecieverName = "chris",
                RecieverAddress = "This is a address",
                RecieverPhone = "This is a phone",
            };

            var orderDetail1 = new OrderDetail()
            {
                Id = 998,
                OrderId = 2,
                Name = "This is a item3.",
                Quantity = 1,
                Price = 1m
            };
            var orderDetail2 = new OrderDetail()
            {
                Id = 999,
                OrderId = 2,
                Name = "This is a item4.",
                Quantity = 1,
                Price = 1m
            };

            OrderManager.OrderRepo.Create(order);
            OrderManager.OrderDetailRepo.Create(orderDetail1);
            OrderManager.OrderDetailRepo.Create(orderDetail2);

            var result1 = OrderManager.OrderRepo.FindByCondition(p => p.Id == 2).FirstOrDefault();
            var result2 = OrderManager.OrderDetailRepo.FindByCondition(p => p.OrderId == 2).FirstOrDefault();

            Assert.NotNull(result1);
            Assert.NotNull(result2);
        }

        [Fact]
        public void OrderManagerDeleteTest()
        {
            var OrderManager = _IOC.GetService<IOrderManager>();

            var order = OrderManager.OrderRepo.FindAll().FirstOrDefault();
            var orderDetil = OrderManager.OrderDetailRepo.FindByCondition(p=>p.OrderId == order.Id);

            OrderManager.OrderRepo.Delete(order);
            foreach (var detail in orderDetil)
            {
                OrderManager.OrderDetailRepo.Delete(detail);
            }

            var result1 = OrderManager.OrderRepo.FindAll();
            var result2 = OrderManager.OrderDetailRepo.FindAll();

            Assert.Empty(result1);
            Assert.Empty(result2);
        }

        [Fact]
        public void OrderManagerUpdateTest()
        {
            var OrderManager = _IOC.GetService<IOrderManager>();

            var orderFromContext = OrderManager.OrderRepo.FindByCondition(p => p.Id == 1).FirstOrDefault();
            orderFromContext.RecieverName = "update Chris";
            OrderManager.OrderRepo.Update(orderFromContext);
            var result1 = OrderManager.OrderRepo.FindByCondition(p => p.Id == 1).FirstOrDefault();

            var orderCommentFromContext = OrderManager.OrderDetailRepo.FindByCondition(p => p.Id == 1).FirstOrDefault();
            orderCommentFromContext.Name = "This is update item.";
            OrderManager.OrderDetailRepo.Update(orderCommentFromContext);
            var result2 = OrderManager.OrderDetailRepo.FindByCondition(p => p.Id == 1).FirstOrDefault();

            Assert.Equal("update Chris", result1.RecieverName);
            Assert.Equal("This is update item.", result2.Name);
        }
        #endregion
    }
}
