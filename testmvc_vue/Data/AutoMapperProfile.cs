﻿using AutoMapper;
using testmvc_vue.Areas.Entities;
using testmvc_vue_core.Models.Users;

namespace testmvc_vue.Data
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}