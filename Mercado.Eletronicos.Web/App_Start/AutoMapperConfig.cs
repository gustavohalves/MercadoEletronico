using AutoMapper;
using Mercado.Web.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mercado.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configurar ()
        {
            Mapper.AddProfile<DomainToViewModelProfile>();
            Mapper.AddProfile<ViewModelToDomain>();
        }
    }
}