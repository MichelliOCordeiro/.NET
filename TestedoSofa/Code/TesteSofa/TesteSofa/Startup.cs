using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using TesteSofa.src.data;
using TesteSofa.src.repositorios;
using TesteSofa.src.repositorios.implementacoes;

namespace TesteSofa
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
            services.AddDbContext<SofaContexto>(
            opt => opt.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));  
            
            services.AddScoped<IUsuario, UsuarioRepositorio>();
            services.AddScoped<ISofa,SofaRepositorio>();
            
            services.AddCors();
            services.AddControllers();
                  
           services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo { Title = "Sofa", Version = "V1" });
            });
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, SofaContexto contexto)
        {
            if (env.IsDevelopment())
            {
                contexto.Database.EnsureCreated();
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Sofa v1"));
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