using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EfCoreMVC.Data;
using EfCoreMVC.Models;

namespace EfCoreMVC.Data
{
    public class EkipoureDbContext :DbContext
    {
        public DbSet<Student> Students { get; set; }
        
    }
}
