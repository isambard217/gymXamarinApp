using System;
using System.Collections.Generic;
using WeActiveApp.Models;
using Xamarin.Forms;

namespace WeActiveApp.View.Workout {
    
    public partial class WorkoutDetailPage : ContentPage {
        
        public WorkoutDetailPage() {
            
           
        }

        public WorkoutDetailPage(WorkoutModel workout) {

            if (workout == null)
                throw new ArgumentNullException();

            BindingContext = workout;

			InitializeComponent();
        }
		
        public void Join_Workout(object sender, System.EventArgs ev) {

            // Implement logic to Join workout

        }
    }

}
