using System;
using WeActiveApp.Json;

namespace WeActiveApp.Models {
    
    public class UserModel {

		public int Id { get; set; }

		public string Firstname { get; set; }

		public string Lastname { get; set; }

		public string Displayname { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string ConfirmPassword { get; set; }

		public string Role { get; set; }

		public bool? Activated { get; set; }

		public int CreateUserId { get; set; }

		public DateTime CreateDateTime { get; set; }

        public UserModel() {
        }

        public UserModel(JsonUser jsonUser){

            Id = jsonUser.Id;
            Firstname = jsonUser.FirstName;
            Lastname = jsonUser.LastName;
            Email = jsonUser.Email;
            Password = jsonUser.Password;
            
        }

    }
}
