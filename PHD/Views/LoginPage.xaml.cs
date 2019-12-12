using System;
using System.Collections.Generic;
using Syncfusion.XForms.Graphics;
using Xamarin.Forms;

namespace PHD.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

        }
        async void Handle_Login_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

        async void Handle_ForgotPassword_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ForgotPasswordView());
        }
    }
}
