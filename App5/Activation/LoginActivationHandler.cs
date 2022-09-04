using App5.Views;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace App5.Activation
{
    internal class LoginActivationHandler : ActivationHandler
    {
        public override bool CanHandle(object args)
        {
            // если пользователь не авторизирован
            return true;
        }

        public override Task HandleAsync(object args)
        {
            Window.Current.Content = new LoginViewPage();

            return Task.CompletedTask;
        }
    }
}
