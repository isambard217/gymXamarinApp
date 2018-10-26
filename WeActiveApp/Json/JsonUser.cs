using System;
using WeActiveApp.Models;

namespace WeActiveApp.Json {
    
    public class JsonUser {

			public int Id { get; set; }
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public string Email { get; set; }
			public string Password { get; set; }

			public JsonUser() { }

			public JsonUser(UserModel user) {
            
                FirstName = user.Firstname;
                LastName = user.Lastname;
                Email = user.Email;
				Password = user.Password;

			}
		}

}
