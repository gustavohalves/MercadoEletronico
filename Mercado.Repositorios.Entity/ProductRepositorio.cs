﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Mercado.Dados.Entity.Context;
using Mercado.Dominio;
using Mercado.Repositorios.Common.Entity;
using System.Data.Entity;

namespace Mercado.Repositorios.Entity
{
    public class ProductRepositorio : RepositorioGenericoEntity<Product, int>
    {
        public ProductRepositorio(ProductDbContext contexto)
            : base(contexto)
        {

        }

        public override List<Product> Selecionar()
        {
            return _contexto.Set<Product>().Include(p => p.Providers).ToList();
        }

        public override Product SelecionarPorId(int id)
        {
            return _contexto.Set<Product>().Include(p => p.Providers)
                            .SingleOrDefault(a => a.Id == id);
        }
    }
}

