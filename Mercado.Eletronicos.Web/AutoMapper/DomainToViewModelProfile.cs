﻿using AutoMapper;
using Mercado.Dominio;
using Mercado.Web.ViewModels.Product;
using Mercado.Web.ViewModels.ProductProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mercado.Web.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Product, ProductIndexViewModel>()
                .ForMember(p => p.Name, opt => {
                    opt.MapFrom(src => string.Format("{0} - {1}", src.Name, src.QuantityInStock.ToString()));
                });
            Mapper.CreateMap<Product, ProductViewModel>();

            Mapper.CreateMap<ProductProvider, ProductProviderIndexViewModel>()
              .ForMember(p => p.ProductName, opt =>
              {
                  opt.MapFrom(src =>
                      src.Product.Name
                  );
              });
            Mapper.CreateMap<ProductProvider, ProductProviderViewModel>();
        }
    }
}