using System;

using App5.ViewModels;

using Windows.UI.Xaml.Controls;

namespace App5.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
