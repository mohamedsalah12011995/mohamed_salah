
using AutoMapper;
using Eservices.Core.Contracts;
using EServices.Core.Common;
using EServices.Infrastructure;
using EServices.Infrastructure.Common;
using EServices.Infrastructure.Services;
using EServices.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EServices.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<ServiceCatalogContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("EServicesCatalogConnection")));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IEntityFieldsService, EntityFieldsService>();
            services.AddScoped<IFieldTypesService, FieldTypeService>();
            services.AddScoped<IFieldLookupsService, FieldLookupService>();
            services.AddScoped<IGroupsService, GroupsService>();
            services.AddScoped<ISectionsService, SectionsService>();
            services.AddScoped<IServicesService, ServicesService>();
            services.AddScoped<IStageActionRolesService, StageActionRolesService>();
            services.AddScoped<IStageActionsService, StageActionsService>();
            services.AddScoped<IStagesService, StagesService>();
            services.AddScoped<IEntityFieldsService, EntityFieldsService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
