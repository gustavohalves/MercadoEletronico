using Mercado.Dados.Generica.Entity;
using Mercado.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado.Dados.Entity.TypeConfiguration
{
    class ProductProviderTypeConfiguration : MercadoEntityAbstractConfig<ProductProvider>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdProvider)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(p => p.ProviderName)
                .HasColumnName("ProviderName")
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.IdProduct)
                .HasColumnName("IdProduct")
                .IsRequired();
        }

        protected override void ConfigurarChaveEstrangeira()
        {
            HasRequired(p => p.Product)
                .WithMany(p => p.Providers)
                .HasForeignKey(fk => fk.IdProduct);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.IdProvider);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("ProductProvider");
        }
    }
}
