using System;
namespace WeActiveApp.Models {
    
    public class WorkoutModel {

		public string Name { get; set; }

		public string Duration { get; set; }

		public string Location { get; set; }

		public string WorkOutCreatorName { get; set; }

		public string Equipment { get; set; }

		public Status theStatus;


		public enum Status {

			Active,
			Cancelled
		}

    }

}
