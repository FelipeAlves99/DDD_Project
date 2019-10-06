using DDD.Domain.Interfaces.IRepository;
using DDD.Domain.Interfaces.IService.CompanyServices;
using DDD.Domain.Interfaces.IService.ItemServices;
using DDD.Domain.Interfaces.IService.OrderServices;
using DDD.Domain.Services.CompanyService;
using DDD.Domain.Services.ItemService;
using DDD.Domain.Services.OrderService;
using DDD.Infra.Data.Sql.Data.Context;
using DDD.Infra.Data.Sql.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;

namespace DDD.WebService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<DDDProjectContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            #region Company DI

            services.AddScoped<IAddCompanyService, AddCompanyService>();
            services.AddScoped<IConsultCompanyService, ConsultCompanyService>();
            services.AddScoped<IDeleteCompanyService, DeleteCompanyService>();
            services.AddScoped<IUpdateCompanyService, UpdateCompanyService>();

            #endregion

            #region Item DI

            services.AddScoped<IAddItemService, AddItemService>();
            services.AddScoped<IConsultItemService, ConsultItemService>();
            services.AddScoped<IDeleteItemService, DeleteItemService>();
            services.AddScoped<IUpdateItemService, UpdateItemService>();

            #endregion

            #region Order DI

            services.AddScoped<IAddOrderService, AddOrderService>();
            services.AddScoped<IConsultOrderService, ConsultOrderService>();
            services.AddScoped<IUpdateOrderService, UpdateOrderService>();

            #endregion

            #region External WebServices DI

            //services.AddScoped<IRevenueRepository, RevenueRepository>();

            #endregion

            #region Swagger

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Company Register",
                        Version = "v2",
                        Description = "Simple CRUD with EntityFramework",
                        Contact = new Contact
                        {
                            Name = "Felipe Alves",
                            Url = "https://felipealves99.github.io/"
                        }
                    });

                string applicationPath =
                    PlatformServices.Default.Application.ApplicationBasePath;
                string applicationName =
                    PlatformServices.Default.Application.ApplicationName;
                string xmlDocPath =
                    Path.Combine(applicationPath, $"{applicationName}.xml");

                c.IncludeXmlComments(xmlDocPath);
            });

            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory logger)
        {
            logger.AddConsole(Configuration.GetSection("Logging"));
            logger.AddDebug();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Company Register");
            });
        }
    }
}
