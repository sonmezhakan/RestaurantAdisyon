using Microsoft.Extensions.DependencyInjection;
using RA.Business.ManagerService.Abstracts;
using RA.Business.ManagerService.Concretes;
using RA.DataAccess.Repositories.Abstracts;
using RA.DataAccess.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Business.DependencyResolvers
{
    public static class RepositoryManagerServiceInjection
    {
        public static IServiceCollection AddRepositoryManagerService(this IServiceCollection services)
        {
            /*services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));*/
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<IProductManager,ProductManager>();
            services.AddScoped<IStockRepository,StockRepository>();
            services.AddScoped<IStockManager,IStockManager>();
            services.AddScoped<ITableRepository,ITableRepository>();
            services.AddScoped<ITableManager,ITableManager>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<ICategoryManager,CategoryManager>();
            services.AddScoped<IOrderRepository,IOrderRepository>();
            services.AddScoped<IOrderManager,IOrderManager>();
            services.AddScoped<IOrderDetailRepository,IOrderDetailRepository>();
            services.AddScoped<IOrderDetailManager,IOrderDetailManager>();
            services.AddScoped<IAppUserRepository,AppUserRepository>();
            services.AddScoped<IAppUserManager,AppUserManager>();
            services.AddScoped<IEmployeeRepository,IEmployeeRepository>();
            services.AddScoped<IEmployeeManager,IEmployeeManager>();
            services.AddScoped<ISupplierRepository,ISupplierRepository>();
            services.AddScoped<ISupplierManager,ISupplierManager>();

            return services;
        }
    }
}
