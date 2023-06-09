using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TestContentControl.UserControls;
using TestContentControl.ViewModels;

namespace TestContentControl
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider Services { get; }

        public App()
        {
            Services = ConfigureServices();
        }

        public new static App Current => (App)Application.Current;


        //容器注册
        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<MainWindow>(sp => new MainWindow{ DataContext = sp.GetService<MainWindowViewModel>() });

            //单列
            services.AddSingleton<UserControl1>();
            services.AddSingleton<UserControl2>();
            services.AddSingleton<UserControl3>();

            //瞬时，每次都会创建新的实例
            //services.AddTransient<UserControl1>();
            //services.AddTransient<UserControl2>();
            //services.AddTransient<UserControl3>();

            return services.BuildServiceProvider();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = Services.GetService<MainWindow>();
            mainWindow?.Show();
        }
    }
}
