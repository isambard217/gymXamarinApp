using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using WeActiveApp.Manager;
using WeActiveApp.Models;
using WeActiveApp.ViewModels.Services;
using Xamarin.Forms;

namespace WeActiveApp.ViewModels.Login {

    public class LoginViewModel : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand LoginUserCommand { get; private set; }

		public UserModel usermodel = new UserModel();

        public string email, password;

        public string Email {
            
            set {
                
                email = value;
                OnPropertyChanged("Firstname");
                usermodel.Firstname = email;
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


        public readonly IPageService _pageService;


        public LoginViewModel() {
            
        }

        public LoginViewModel(IPageService pageService) {

            this._pageService = pageService;
            //LoginUserCommand = new Command(LoginUser);
            LoginUserCommand = new Command<UserModel>(async vm => await LoginUser(vm));
        }


        public async Task LoginUser(UserModel usermodel) {

            UserManager dm = new UserManager();

            Session session = await dm.Login(usermodel);

            if (session != null) {

              //  _pageService.

            }
             

		}


        public ICommand InsertBet;

        protected virtual void OnPropertyChanged(string propertyName) {

            if (PropertyChanged != null) {

                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }

        }

    } // end class

} // end namespace



