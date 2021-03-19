﻿using Hermes.Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;


#nullable disable

namespace Hermes.Api.Data
{
    public partial class DataContext : IdentityDbContext<User>

    {

        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }

        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Detallefactura> Detallefacturas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }


    }
}
