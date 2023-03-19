using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Eatable.EF
{
    public class EatableContextFactory : IDesignTimeDbContextFactory<EatableContext>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public EatableContextFactory()
        {

        }

        public EatableContextFactory(IHttpContextAccessor httpContextAccessor) 
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public EatableContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EatableContext>();

            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Eatable-D;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            return new EatableContext(builder.Options, _httpContextAccessor);
        }

    }
}