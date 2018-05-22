using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfChat.Autofac.Configuration;
using WpfChat.Business;
using WpfChat.Common;

namespace WpfChat.Presentation.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        private readonly ILoginBusiness _loginBusiness;
        public Login()
        {
            InitializeComponent();
            _loginBusiness = AutofacInjector.ResolveLoginBusiness();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user = new User()
            {
                Nombre = loginTextBox.Text,
                Contraseña = passwordTextBox.Password
            };

            if (_loginBusiness.ExistUser(user))
            {
                labelResult.Content = "OK!!!!";
            }
            else
            {
                labelResult.Content = "Error al Logear";
            }
        }
    }
}
