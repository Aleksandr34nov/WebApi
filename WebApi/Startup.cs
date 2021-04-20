using DataLayer;
using DataLayer.Implementations;
using DataLayer.Interfaces;
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
using BusinessLayer.Implementations;
using BusinessLayer.Interfaces;

namespace WebApi
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
            var connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ASContext>(options => options.UseSqlServer(connection, b => b.MigrationsAssembly("DataLayer")));
            services.AddTransient<ISRepo, SongDataAccess>();
            services.AddTransient<IARepo, AlbumDataAccess>();
            services.AddTransient<ISongGetAllService, SongGetAllService>();
            services.AddTransient<ISongGetByIdService, SongGetByIdService>();
            services.AddTransient<ISongAddService, SongAddService>();
            services.AddTransient<ISongDeleteService, SongDeleteService>();
            services.AddTransient<ISongUpdateService, SongUpdateService>();
            services.AddTransient<IAlbumGetAllService, AlbumGetAllService>();
            services.AddTransient<IAlbumGetByIdService, AlbumGetByIdService>();
            services.AddTransient<IAlbumAddService, AlbumAddService>();
            services.AddTransient<IAlbumDeleteService, AlbumDeleteService>();
            services.AddTransient<IAlbumUpdateService, AlbumUpdateService>();

            services.AddScoped<AlbumGetAllService>();
            services.AddScoped<AlbumGetByIdService>();
            services.AddScoped<AlbumAddService>();
            services.AddScoped<AlbumDeleteService>();
            services.AddScoped<AlbumUpdateService>();
            services.AddScoped<SongGetAllService>();
            services.AddScoped<SongGetByIdService>();
            services.AddScoped<SongAddService>();
            services.AddScoped<SongDeleteService>();
            services.AddScoped<SongUpdateService>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
