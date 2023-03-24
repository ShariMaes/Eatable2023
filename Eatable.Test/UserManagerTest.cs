using AutoMapper;
using Eatable.Application.General;
using Eatable.Application.StoreManager;
using Eatable.Application.UserManager;
using Eatable.Common.Enum;
using Eatable.Data.General;
using Eatable.Dto.General;
using Eatable.Dto.Store;
using Eatable.Dto.User;
using Eatable.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Test
{
    [TestClass]
    public class UserManagerTest : BaseSettings
    {
        [TestMethod]
        public async Task AddNewUserTest()
        {
            InitiateServices();
            var userDto = CreateNewUser();

            var manager = _serviceProvider.GetService<IUserManager>();
            var result = manager.AddOrUpdateUser(userDto);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task DeleteUserTest()
        {
            InitiateServices();

            var manager = _serviceProvider.GetService<IUserManager>();
            var userToDelete = GetUserByName("Shari", "Maes").Result;
            var result = manager.DeleteUser(userToDelete);

            Assert.IsNull(result);
        }

        private UserDto CreateNewUser()
        {
            var userDto = new UserDto
            {               
                Role = new RoleDto() { RoleType = UserRoleType.Administrator},
                FirstName = "Shari",
                LastName = "Maes",
                LanguageCode = LanguageCodeType.BE,
                ContactInformation = new List<ContactInformationDto>() {
                    new ContactInformationDto
                    {
                        ContactInfo = "sharimaes@hotmail.com",
                        ContactInformationTypeCode = ContactInformationType.Email
                    },
                     new ContactInformationDto
                     {
                         ContactInfo = "0479 26 73 50",
                         ContactInformationTypeCode = ContactInformationType.Email
                     }
                },
                Address = new AddressDto
                {
                    Street = "Ambroossteenweg",
                    City = "Hofstade",
                    HouseNumber = "130",
                    Postalcode = "1981",
                    CountryCode = CountryCodeType.Belgium
                }
            };

            return userDto;
        }

        private Task<UserDto> GetUserByName(string firstName, string lastName)
        {
            var manager = _serviceProvider.GetService<IUserManager>();
            var userDto = manager.GetUserByName(firstName, lastName);

            return userDto;
        }

    }
}
