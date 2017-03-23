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
                cfg.CreateMap<Service, ServiceViewModel>().ForMember(dest => dest.ServicePriceViewModels, opt => opt.MapFrom(src => src.ServicePrices)).MaxDepth(2);
                cfg.CreateMap<ServiceViewModel, Service>().ForMember(dest => dest.ServicePrices, opt => opt.MapFrom(src => src.ServicePriceViewModels)).MaxDepth(2);

                cfg.CreateMap<ServicePrice, ServicePriceViewModel>().ForMember(dest => dest.ServiceViewModel, opt => opt.MapFrom(src => src.Service)).MaxDepth(2);
                cfg.CreateMap<ServicePriceViewModel, ServicePrice>().ForMember(dest => dest.Service, opt => opt.MapFrom(src => src.ServiceViewModel)).MaxDepth(2);


                cfg.CreateMap<Subscription, SubscriptionViewModel>().ReverseMap();

                


            });
        }
    }
}