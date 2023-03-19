using Eatable.Data.General;
using Eatable.Data.Store;
using Eatable.Data.User;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.EF
{
    public class EatableContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EatableContext(DbContextOptions<EatableContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<KeyIdentifier> KeyIdentifier { get; set; }
        public DbSet<Translation> Translation { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<ContactInformation> ContactInformation { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Right> Rights { get; set; }


    }
}
