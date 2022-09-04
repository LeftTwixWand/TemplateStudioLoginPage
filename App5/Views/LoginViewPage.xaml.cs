using System;

using App5.ViewModels;

using Windows.UI.Xaml.Controls;

namespace App5.Views
{
    public sealed partial class LoginViewPage : Page
    {
        public LoginViewViewModel ViewModel { get; } = new LoginViewViewModel();

        public LoginViewPage()
        {
            InitializeComponent();
        }
    }
}
