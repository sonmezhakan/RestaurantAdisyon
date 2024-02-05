using Microsoft.Extensions.DependencyInjection;
using RA.Business.DependencyResolvers;
using RA.Business.ManagerService.Abstracts;

namespace RA.WinFormUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Dependency Injection Konteyneri Oluþtur
            IServiceProvider serviceProvider = CreateServiceProvider();

            // Ana Formu Baþlat ve DI Konteynerini Ýlet
            Application.Run(new LoginForm(serviceProvider));

        }
        private static IServiceProvider CreateServiceProvider()
        {
            // Servisleri Kaydet
            var services = new ServiceCollection();
            services.RepositoryService();  // servis kaydýný yapmak için kullanýlýr
                                           // Diðer servis kayýtlarý...

            // DI Konteynerini Oluþtur ve Döndür
            return services.BuildServiceProvider();
        }
    }
}