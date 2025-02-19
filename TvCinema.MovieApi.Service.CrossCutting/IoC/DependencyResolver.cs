﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TvCinema.MovieApi.Service.Infrastructure.Context;

namespace TvCinema.MovieApi.Service.CrossCutting.IoC
{
    public static class DependencyResolver
    {
        public static void ConfigureDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<ApplicationDbContext>(options => 
            //    options.UseInMemoryDatabase("DBMovies"));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("ConnectionMovies")));
        }
    }
}
