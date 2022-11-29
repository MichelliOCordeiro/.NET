using Predio.src.data;
using Predio.src.repositorios;
using Predio.src.repositorios.implementacoes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Predio.src.repositorios.implementations;
using Microsoft.OpenApi.Models;
using Predio.src.service;
using Predio.src.service.implementacoes;

namespace Predio
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();

            services.AddDbContext<PredioContexto>(
            opt => opt.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));  
            
            services.AddScoped<ICondominioRepositorio, CondominioRepositorio>();
            services.AddScoped<IMoradorRepositorio,MoradorRepositorio>();
            services.AddScoped<IFamiliaRepositorio,FamiliaRepositorio>();

            services.AddScoped<ICondominioService, CondominioService>();
            
            services.AddTransient<IFamiliaService, FamiliaService>();
            services.AddTransient<IMoradorService, MoradorService>();
                  
           services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo { Title = "Predio", Version = "V1" });
            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, PredioContexto contexto)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Predio v1"));
            }

            app.UseRouting();

            app.UseCors(c => c
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}