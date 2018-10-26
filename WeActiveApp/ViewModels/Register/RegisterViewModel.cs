using System;
using System.ComponentModel;
using System.Net.Http;
using System.Windows.Input;
using WeActiveApp.Manager;
using WeActiveApp.Models;
using WeActiveApp.ViewModels.Services;

namespace WeActiveApp.ViewModels.Register {
    
    public class RegisterViewModel : INotifyPropertyChanged {

        // URL endpoints

       // private const string UrlRegister = "http://localhost:5000/api/Login/Register";
       // private HttpClient _client = new HttpClient();

		public event PropertyChangedEventHandler PropertyChanged;

        public UserModel usermodel = new UserModel();

        private string firstname, surname, email, password, confirmPassword;

        public string Firstname { 

            set {   
                    firstname = value;
    				OnPropertyChanged("Firstname");
                    usermodel.Firstname = firstname; 
                } 

            get {

                return firstname;
            }

        }

        public string Surname { 
            set {
                surname = value;
                OnPropertyChanged("Surname");
                usermodel.Lastname = surname;
            }

            get {
    
                return surname;
            } 
        }

        public string Email {
            set {
                email = value;
                OnPropertyChanged("Email");
                usermodel.Email = email;
            }

            get {

                return email;
            }
        }

        public string Password { 
            
            set {
                password = value;
                OnPropertyChanged("Password");
                usermodel.Password = password;
            } 

            get {

                return password;
            }
        
        }

        public string ConfirmPassword { 

            set {
                confirmPassword = value;
                OnPropertyChanged("ConfirmPassword");
                usermodel.ConfirmPassword = confirmPassword;
            } 

            get {
                
                return confirmPassword;
            } 
        }

        public readonly IPageService _pageService;

        public RegisterViewModel() {
            
        }

        public RegisterViewModel(IPageService pageService){

            this._pageService = pageService;
        }

		public ICommand InsertBet;        

        protected virtual void OnPropertyChanged (string propertyName){

			if (PropertyChanged != null) {
                    
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}

        }

        public async void RegisterUser(UserModel usermodel) {

			UserManager um = new UserManager();

            bool success = await um.SignUp(usermodel);

            if (success == false) {


            } else {

                // We need to here pop the page from the stack. 
                // However, it has a dependency to Xamarin so what do we done
                await _pageService.PopAsync();
            }

             //var content = await _client.GetStringAsync(UrlRegister);


        }




    }
}
