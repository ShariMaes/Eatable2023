using Eatable.Common.Enum;
using Eatable.Data.User;
using Eatable.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Eatable.Importer.Importers
{
    public class RoleImporter : BaseImporter, IRoleImporter
    {

        private readonly DbContextOptionsBuilder<EatableContext> _builder = new DbContextOptionsBuilder<EatableContext>();
        public RoleImporter(IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _builder = new DbContextOptionsBuilder<EatableContext>();
            _builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Eatable-D;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public async Task ProcessAsync()
        {
            using var eatableContext = new EatableContext(_builder.Options, _httpContextAccessor);

            var data = CreateRolesWithRights();

            await eatableContext.AddRangeAsync(data);

            await eatableContext.SaveChangesAsync();
        }

        private List<Role> CreateRolesWithRights()
        {
            var list = new List<Role>();

            var roleAdmin = new Role
            {
                RoleType = UserRoleType.Administrator,
                Rights = new List<Right>
                {
                    new Right
                    {
                        ObjectCodeType = ObjectCodeType.Store,
                        Read = true,
                        Write = true,
                        Edit = true,
                        Delete = true
                    },
                    new Right
                    {
                        ObjectCodeType = ObjectCodeType.Product,
                        Read = true,
                        Write = true,
                        Edit = true,
                        Delete = true
                    },
                    new Right
                    {
                        ObjectCodeType = ObjectCodeType.User,
                        Read = true,
                        Write = true,
                        Edit = true,
                        Delete = true
                    }
                }
            };
            var rolePremium = new Role
            {
                RoleType = UserRoleType.Premium,
                Rights = new List<Right>
                {
                    new Right
                    {
                        ObjectCodeType = ObjectCodeType.Store,
                        Read = true,
                        Write = true,
                        Edit = true,
                        Delete = false
                    },
                    new Right
                    {
                        ObjectCodeType = ObjectCodeType.Product,
                        Read = true,
                        Write = true,
                        Edit = true,
                        Delete = false
                    },
                    new Right
                    {
                        ObjectCodeType = ObjectCodeType.User,
                        Read = true,
                        Write = false,
                        Edit = false,
                        Delete = false
                    }
                }
            };
            var roleExt = new Role
            {
                RoleType = UserRoleType.Extended,
                Rights = new List<Right>
                {
                    new Right
                    {
                        ObjectCodeType = ObjectCodeType.Store,
                        Read = true,
                        Write = true,
                        Edit = true,
                        Delete = false
                    },
                    new Right
                    {
                        ObjectCodeType = ObjectCodeType.Product,
                        Read = true,
                        Write = true,
                        Edit = true,
                        Delete = false
                    },
                    new Right
                    {
                        ObjectCodeType = ObjectCodeType.User,
                        Read = true,
                        Write = false,
                        Edit = false,
                        Delete = false
                    }
                }
            };
            var roleBasic = new Role
            {
                RoleType = UserRoleType.Basic,
                Rights = new List<Right>
                {
                    new Right
                    {
                        ObjectCodeType = ObjectCodeType.Store,
                        Read = true,
                        Write = false,
                        Edit = false,
                        Delete = false
                    },
                    new Right
                    {
                        ObjectCodeType = ObjectCodeType.Product,
                        Read = true,
                        Write = false,
                        Edit = false,
                        Delete = false
                    },
                    new Right
                    {
                        ObjectCodeType = ObjectCodeType.User,
                        Read = true,
                        Write = false,
                        Edit = false,
                        Delete = false
                    }
                }
            };

            list.Add(roleAdmin);
            list.Add(rolePremium);
            list.Add(roleExt);
            list.Add(roleBasic);

            return list;
        }
    }
}
