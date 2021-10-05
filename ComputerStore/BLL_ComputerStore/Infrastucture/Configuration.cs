using Microsoft.Extensions.DependencyInjection;
using Core_ComputerStore.Context;
using Microsoft.EntityFrameworkCore;
using Domain_ComputerStore.Models;
using Microsoft.AspNetCore.Identity;
using AutoMapper;
using BLL_ComputerStore.Services;

namespace BLL_ComputerStore.Infrastucture
{
    public static class Configuration
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<StoreContext>(option => option
            .UseSqlServer(connectionString));
            services.AddIdentity<User, Role>().AddDefaultTokenProviders().AddEntityFrameworkStores<StoreContext>();
            services.AddTransient<AutoMapper>();
            var mapperConfiguration = new MapperConfiguration(x => x.AddProfile(new AutoMapper()));
            services.AddTransient<IMapper>(x => mapperConfiguration.CreateMapper());
            services.AddTransient<IStoreService, StoreService>();
            services.AddTransient<IUserService, UserService>();
        }
    }
}
