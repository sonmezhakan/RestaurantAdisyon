using Microsoft.Extensions.DependencyInjection;
using RA.Business.ManagerService.Abstracts;
using RA.Business.ManagerService.Concretes;
using RA.DataAccess.Concrete;
using RA.DataAccess.Repositories.Abstracts;
using RA.DataAccess.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RA.Business.DependencyResolvers
{
    public static class ServiceInjection
    {
        public static IServiceCollection RepositoryService(this IServiceCollection services)
        {
            services.AddScoped<RestaurantAdisyonContext>();
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IProductDal,ProductDal>();
            services.AddScoped<IProductService,ProductManager>();
            services.AddScoped<IStockDal,StockDal>();
            services.AddScoped<IStockService,StockManager>();
            services.AddScoped<ITableDal,TableDal>();
            services.AddScoped<ITableService,TableManager>();
            services.AddScoped<ICategoryDal,CategoryDal>();
            services.AddScoped<ICategoryService,CategoryManager>();
            services.AddScoped<IOrderDal,OrderDal>();
            services.AddScoped<IOrderService,OrderManager>();
            services.AddScoped<IOrderDetailDal,OrderDetailDal>();
            services.AddScoped<IOrderDetailService,OrderDetailManager>();
            services.AddScoped<IAppUserDal,AppUserDal>();
            services.AddScoped<IAppUserService,AppUserManager>();
            services.AddScoped<IEmployeeDal,EmployeeDal>();
            services.AddScoped<IEmployeeService,EmployeeManager>();
            services.AddScoped<ISupplierDal,SupplierDal>();
            services.AddScoped<ISupplierService,SupplierManager>();

            return services;
        }
    }
}
