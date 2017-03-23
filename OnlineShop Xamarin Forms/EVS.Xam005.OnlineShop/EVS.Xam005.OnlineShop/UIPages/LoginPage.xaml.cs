using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EVS.Xam005.OnlineShop.UIPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            logoImage.Source = ImageSource.FromResource("EVS.Xam005.OnlineShop.Images.OnlineMobileShop.png");
            loginButton.Clicked += LoginButton_Clicked;
            signUpButton.Clicked += SignUpButton_Clicked;


            var tapForgotPasswordLabel = new TapGestureRecognizer();

            tapForgotPasswordLabel.Tapped += TapForgotPasswordLabel_Tapped;
            forgotPasswordLabel.GestureRecognizers.Add(tapForgotPasswordLabel);

        }

        private void TapForgotPasswordLabel_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ForgotPasswordPage());
        }

        private void SignUpButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new SignUpPage());
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}
