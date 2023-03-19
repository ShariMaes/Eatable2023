using AutoMapper;
using Eatable.Data.General;
using Eatable.Data.Store;
using Eatable.Dto.General;
using Eatable.Dto.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eatable.Application.Automapper
{
    public class BaseProfile: Profile
    {
        public BaseProfile()
        {
            CreateMap<AddressDto, Address>();
            CreateMap<ContactInformationDto, ContactInformation>();
            CreateMap<TranslationDto, Translation>();
            CreateMap<KeyIdentifierDto, KeyIdentifier>();

            CreateMap<Address, AddressDto>();
            CreateMap<ContactInformation, ContactInformationDto>();
            CreateMap<Translation, TranslationDto>();
            CreateMap<KeyIdentifier, KeyIdentifierDto>();
        }
    }
}
