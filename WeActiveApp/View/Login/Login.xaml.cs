using WeActiveApp.ViewModels.Login;
using Xamarin.Forms;

namespace WeActiveApp.View.Login
{

    public partial class Login : ContentPage {


        public Login() {

			BindingContext = new LoginViewModel();

			InitializeComponent();
        }


        public async void Login_Clicked (object sender, System.EventArgs e) {

            // Remove this as it is just a binding 
            var currentPage = (BindingContext as LoginViewModel);

            // currentPage.LoginUserCommand.Execute(e.);

            await currentPage.LoginUser(currentPage.usermodel);

            //currentPage.Handle_Clicked();

            //need to check 
            //currentPage.Email && currentPage.Password
            // if successful then below
            await Navigation.PushAsync(new MainPage());




			
		}

        public async void Register_Clicked (object sender, System.EventArgs e) {

            await Navigation.PushAsync(new Register());
        }

    }
}
