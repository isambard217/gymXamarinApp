using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeActiveApp.ViewModels.Services {
    
    public class PageService : IPageService {

        private Page AppMain = Application.Current.MainPage;
        
        public PageService() {
            
        }

        public async Task<bool> DisplayAlert(string title, string message, string ok, string cancel) {

            //This is a reference to the Main Page property on the App.xaml.cs class

            return await AppMain.DisplayAlert(title, message,ok, cancel);
        }

        public async Task PushAsync(Page page) {
            //throw new NotImplementedException();

            await AppMain.Navigation.PushAsync(page); 
        }


        public async Task PopAsync() {

            await AppMain.Navigation.PopAsync();
        }

    }
}
