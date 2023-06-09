using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using TestContentControl.Model;
using TestContentControl.UserControls;

namespace TestContentControl.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {

        [ObservableProperty]
        public List<Module> modules = new()
        {
            new Module() { Name = "Module 1" },
            new Module() { Name = "Module 2" },
            new Module() { Name = "Module 3" },
            new Module() { Name = "Module 4" },
        };

        [ObservableProperty]
        public object? page;


        [RelayCommand]
        public void Open(string type)
        {
            //方法一：使用new关键字，每次都会创建新的实例，无法保存页面数据
            //switch (type)
            //{
            //    case "Module 1": Page = new UserControl1(); break;
            //    case "Module 2": Page = new UserControl2(); break;
            //    case "Module 3": Page = new UserControl3(); break;
            //}

            //方法二：使用IoC容器，可以在注册时指定为单列或瞬时，已达到保存页面数据的目的
            switch (type)
            {
                case "Module 1": Page = App.Current.Services.GetService<UserControl1>(); break;
                case "Module 2": Page = App.Current.Services.GetService<UserControl2>(); break;
                case "Module 3": Page = App.Current.Services.GetService<UserControl3>(); break;
            }
        }

    }
}
