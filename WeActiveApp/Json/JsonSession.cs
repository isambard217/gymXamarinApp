using System;
using WeActiveApp.Models;

namespace WeActiveApp.Json {
    
    public class JsonSession {

		public int Id { get; set; }
		public string SessionKey { get; set; }
		public JsonUser User { get; set; }
		//public JsonDevice Device { get; set; }

        public JsonSession() {}

        public JsonSession(UserModel user) {

            User = new JsonUser();

        }

        public JsonSession(Session session) {

            User = new JsonUser(session.User);
        }
    }
}
