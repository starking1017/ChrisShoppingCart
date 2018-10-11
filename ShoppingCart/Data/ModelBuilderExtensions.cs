using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Pencil",
                    Description = "This is a special Pencil.",
                    PublishDate = DateTime.Now,
                    Price = 8.8m,
                    Status = true,
                    Quantity = 9999,
                    DefaultImageURL = "https://dts0r5oeqkedm.cloudfront.net/2017/10/tsukushi_151101_002-1508897093.jpg"
                },

                new Product
                {
                    Id = 2,
                    Name = "Music box",
                    Description = "This is a awesome music box. You can bring to everywhere.",
                    PublishDate = DateTime.Now,
                    Price = 39.9m,
                    Status = true,
                    Quantity = 9999,
                    DefaultImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRMf5clBbTLqkGG1-p3hLG-5cyzcRpoSwmsjW0OTZhONrjhQ2ss-g"
                },

                new Product
                {
                    Id = 3,
                    Name = "Flower",
                    Description = "Beautiful flower that you can dress you home.",
                    PublishDate = DateTime.Now,
                    Price = 29.1m,
                    Status = true,
                    Quantity = 9999,
                    DefaultImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsfn0jCvhMWH2oBDa8fpMBX2p3xtd8NGCST5fFZkuSGcrnUvobXw"
                },

                new Product
                {
                    Id = 4,
                    Name = "Paint brush",
                    Description = "A paintbrush is a brush used to apply paint or sometimes ink. A paintbrush is usually made by clamping the bristles to a handle with a ferrule.",
                    PublishDate = DateTime.Now,
                    Price = 69.5m,
                    Status = true,
                    Quantity = 9999,
                    DefaultImageURL = "https://cw1.tw/CW/images/article/201802/article-5a93cb421fa60.jpg"
                },

                new Product
                {
                    Id = 5,
                    Name = "Note book",
                    Description = "notepad, writing pad, drawing pad, legal pad) is a small book or binder of paper pages, often ruled, used for purposes such as recording notes or memoranda, writing, drawing or scrapbooking.",
                    PublishDate = DateTime.Now,
                    Price = 3.6m,
                    Status = true,
                    Quantity = 9999,
                    DefaultImageURL = "https://multimedia.bbycastatic.ca/multimedia/products/500x500/800/80045/80045388.jpg"
                },

                new Product
                {
                    Id = 6,
                    Name = "Tape",
                    Description = "A strip of cloth, paper, or plastic with an adhesive surface, used for sealing, binding, or attaching items together",
                    PublishDate = DateTime.Now,
                    Price = 5.9m,
                    Status = true,
                    Quantity = 9999,
                    DefaultImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSZjddkFDYLLkbQrWbssugMePbBo7A_x7FuFXtaO778e_Bj5qOn"
                }
            );
        }
    }
}
