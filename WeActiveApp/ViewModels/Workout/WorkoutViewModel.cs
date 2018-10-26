using System;
using System.Collections.ObjectModel;
using WeActiveApp.Models;

namespace WeActiveApp.ViewModels.Workout {
    
    public class WorkoutViewModel {

        public ObservableCollection<WorkoutModel> WorkoutList { get; private set; } = new ObservableCollection<WorkoutModel>();

        public WorkoutModel SelectedWorkout { get; set; }


        public void AddWorkout() {
            
			WorkoutList.Add(new WorkoutModel { Name = "test" });

        }

        public void AddWorkout(WorkoutModel workoutmodel) {

            WorkoutList.Add(workoutmodel);

		}



        public void SelectWorkout(WorkoutModel workoutmodel) {

            if (workoutmodel == null)
                return;

            SelectedWorkout = null;

        }


	}
}


