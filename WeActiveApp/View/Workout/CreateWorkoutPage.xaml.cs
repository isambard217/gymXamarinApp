using System;
using System.Collections.Generic;
using WeActiveApp.Models;
using WeActiveApp.ViewModels.Workout;
using Xamarin.Forms;
using static WeActiveApp.Models.WorkoutModel;

namespace WeActiveApp.View.Workout {
    
    public partial class CreateWorkoutPage : ContentPage {
        
        public CreateWorkoutPage() {
            
            InitializeComponent();
        }

        public void Submitted_Workout(object sender, System.EventArgs erv) {

            var SubmittedWorkout = BindingContext as WorkoutModel;

            var FinishedSubmission = new WorkoutModel();

            // Validation checks
            if (String.IsNullOrWhiteSpace(SubmittedWorkout.Duration)) {

                DisplayAlert("Error","Please enter duration","");

            }


            if (String.IsNullOrWhiteSpace(SubmittedWorkout.Equipment)) {

				DisplayAlert("Error", "Please enter Equipment", "");
			}

            if (String.IsNullOrWhiteSpace(SubmittedWorkout.Name)) {

                DisplayAlert("Error", "Please enter Name", "");

            }

            if (String.IsNullOrWhiteSpace(SubmittedWorkout.Location)) {

				DisplayAlert("Error", "Please enter Location", "");

			}

            if (String.IsNullOrWhiteSpace(SubmittedWorkout.WorkOutCreatorName)) {

				DisplayAlert("Error", "Please enter Creator Name", "");

			}

            if (Enum.IsDefined(typeof(Status), SubmittedWorkout.theStatus)) {

				DisplayAlert("Error", "Please enter Status", "");

			}

            // Save the data in a database 





        }

    }
}
