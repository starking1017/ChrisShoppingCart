using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Data
{
    public class DefaultUserInitialize
    {
        public static async Task Initialize(ApplicationDbContext context,
                                 UserManager<IdentityUser> userManager,
                                 RoleManager<IdentityRole> roleManager)
        {

            string role1 = "Admin";


            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(role1));


                if (await userManager.FindByNameAsync("admin@gmail.com") == null)
                {
                    var user = new IdentityUser
                    {
                        UserName = "admin@gmail.com",
                        Email = "admin@gmail.com",
                        EmailConfirmed = true,
                    };

                    string password = "admin123";
                    var result = await userManager.CreateAsync(user,password);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, role1);
                    }
                }
            }
        }
    }
}
