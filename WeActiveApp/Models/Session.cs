using System;
using WeActiveApp.Json;

namespace WeActiveApp.Models {
    
    public class Session {

		public int Id { get; set; }
		public string SessionKey { get; set; }
		public UserModel User { get; set; }
		public Device Device { get; set; }

		public Session() { }

		public Session(JsonSession session) {
			Id = session.Id;
			SessionKey = session.SessionKey;
			User = new UserModel(session.User);
		}
        
        
     
    }
}
