using WeActiveApp.View.Workout;
using WeActiveApp.ViewModels;
using WeActiveApp.ViewModels.Workout;
using Xamarin.Forms;

namespace WeActiveApp.View
{

    public partial class MainPage : ContentPage {


        public MainPage() {
            
            InitializeComponent();

            BindingContext = new WorkoutViewModel();
        }

		public async void Join_Workout(object sender, System.EventArgs e) {

          // BindingContext = new WorkoutViewModel();
			
          await Navigation.PushAsync(new WorkoutList());
        }

        public async void Create_Workout(object sender, System.EventArgs e) {
               

           await Navigation.PushAsync(new CreateWorkoutPage());

        }

    }
}
