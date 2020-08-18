using CerealECommerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CerealECommerce.Data
{
    public class UserDbContext : IdentityDbContext<Customer>
    {
        public UserDbContext(DbContextOptions<UserDbContext> options): base(options)
        {

        }
    }
}
