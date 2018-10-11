using Microsoft.AspNetCore.Identity;
using ShoppingCart.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Utilities;

namespace ShoppingCart.Repositories
{
    public class UserRepository : RepositoryBase<IdentityUser>
    {
        public UserRepository(ApplicationDbContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }

}
