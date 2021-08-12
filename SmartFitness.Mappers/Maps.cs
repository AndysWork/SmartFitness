using AutoMapper;
using SmartFitness.DataLayer.Models;
using SmartFitness.DataLayer.ViewModels;
using System;

namespace SmartFitness.Mappers
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
}
