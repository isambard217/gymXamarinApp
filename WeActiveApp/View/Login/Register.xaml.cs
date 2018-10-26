using System;
using System.Collections.Generic;
using WeActiveApp.ViewModels.Register;
using Xamarin.Forms;
using WeActiveApp.Manager;

namespace WeActiveApp.View.Login {
    
    public partial class Register : ContentPage {

        private const string Url = "http://localhost:5000/api/Login/test";

        public Register() {

            BindingContext = new RegisterViewModel();

            InitializeComponent();
        }

		public void Register_User(object sender, System.EventArgs e) {

           var registerPage = (BindingContext as RegisterViewModel);

           registerPage.RegisterUser(registerPage.usermodel);



           //var confirmpasswordentry = registerPage.ConfirmPassword;

			
		}

    }
}
