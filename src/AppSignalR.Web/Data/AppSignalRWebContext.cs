using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppSignalR.Web.Models;

    public class AppSignalRWebContext : DbContext
    {
        public AppSignalRWebContext (DbContextOptions<AppSignalRWebContext> options)
            : base(options)
        {
        }

        public DbSet<AppSignalR.Web.Models.Funcionario> Funcionario { get; set; }
    }
