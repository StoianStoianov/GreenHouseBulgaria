using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using GreenHouseBulgaria.Models;
using GreenHouseBulgaria.Web.ViewModels;

namespace GreenHouseBulgaria.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static void CreateMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Service, ServiceViewModel>().ForMember(dest => dest.ServicePriceViewModels, opt => opt.MapFrom(src => src.ServicePrices));
                cfg.CreateMap<ServiceViewModel, Service>().ForMember(dest => dest.ServicePrices, opt => opt.MapFrom(src => src.ServicePriceViewModels));
                cfg.CreateMap<ServicePrice, ServicePriceViewModel>().ReverseMap();

            });
        }
    }
}