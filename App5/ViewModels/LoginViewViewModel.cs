using App5.Services;
using App5.Views;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace App5.ViewModels
{
    public class LoginViewViewModel : ObservableObject
    {
        public LoginViewViewModel()
        {
            LogInCommand = new RelayCommand(OnLogin);
        }

        public ICommand LogInCommand { get; }

        private void OnLogin()
        {
            // Если авторизирован
            if (true)
            {
                Window.Current.Content = new ShellPage();
            }
        }
    }
}
