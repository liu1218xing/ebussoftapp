using AutoMapper;
using EbusSoft.Base.BusCompanies;
using EbusSoft.Base.BusCompanies.Dto;
using EbusSoft.Provinces;
using EbusSoft.Provinces.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace EbusSoft
{
    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            // Province
            
            configuration.CreateMap<Province, ProvinceListDto>();
            configuration.CreateMap<ProvinceEditDto, Province>().ReverseMap();

            configuration.CreateMap<BusCompanyEditDto, BusCompany>().ReverseMap();
            //configuration.CreateMap<ProvinceEditDto, Province>().ReverseMap();

            //Role
            //configuration.CreateMap<RoleEditDto, Role>().ReverseMap();
            //configuration.CreateMap<Role, RoleListDto>();
            //configuration.CreateMap<UserRole, UserListRoleDto>();

        }
    }
}
