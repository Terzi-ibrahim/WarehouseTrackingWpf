using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using WarehouseTrackingWpf.Account;
using WarehouseTrackingWpf.Interface;


namespace WarehouseTrackingWpf
{
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; } = new ServiceCollection().BuildServiceProvider();


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

      
            var services = new ServiceCollection();

            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();
            
            var loginWindow = ServiceProvider.GetRequiredService<Login>();
            loginWindow.Show();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            
            services.AddTransient<Login>();

       
    
            services.AddScoped<ILoginService, LoginService>();

         
        }
    }
}
