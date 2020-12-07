using AutoMapper;
using Mercado.Dominio;
using Mercado.Web.ViewModels.Product;
using Mercado.Web.ViewModels.ProductProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mercado.Web.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ProductViewModel, Product>();
            Mapper.CreateMap<ProductProviderViewModel, ProductProvider>();
        }
    }
}