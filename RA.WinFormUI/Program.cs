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

            // Dependency Injection Konteyneri Olu�tur
            IServiceProvider serviceProvider = CreateServiceProvider();

            // Ana Formu Ba�lat ve DI Konteynerini �let
            Application.Run(new LoginForm(serviceProvider));

        }
        private static IServiceProvider CreateServiceProvider()
        {
            // Servisleri Kaydet
            var services = new ServiceCollection();
            services.RepositoryService();  // servis kayd�n� yapmak i�in kullan�l�r
                                           // Di�er servis kay�tlar�...

            // DI Konteynerini Olu�tur ve D�nd�r
            return services.BuildServiceProvider();
        }
    }
}