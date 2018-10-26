using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using WeActiveApp.Models;
using WeActiveApp.ViewModels;
using WeActiveApp.ViewModels.Workout;

namespace WeActiveApp.View.Workout {
    
    public partial class WorkoutList : ContentPage {
        
        public WorkoutList() {

            BindingContext = new WorkoutViewModel();
            
            InitializeComponent();

        }

        protected override void OnAppearing() {
            

            base.OnAppearing();

        }

        public void OnAddPlaylist(object sender, System.EventArgs evr) {
             

            (BindingContext as WorkoutViewModel).AddWorkout();


        }

        public void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs evr){

            (BindingContext as WorkoutViewModel).SelectWorkout(evr.SelectedItem as WorkoutModel);
        }


		// A method which returns the Xaml code
		// tightly bounded to a ViewModel 
		private WorkoutViewModel BoundViewModel {

			get { return BindingContext as WorkoutViewModel; }
			set { BindingContext = value; }
		}


    }
}
