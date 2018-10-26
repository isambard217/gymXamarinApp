using System;
namespace WeActiveApp.Constants {

    public class Server {
        
		public static readonly string HTTPBasicUser = "Administrator";
		public static readonly string HTTPBasicPassword = "password";

        public static readonly string BaseUri = "http://localhost:5000";
		//public static readonly string BaseUri = "http://172.17.6.5:5000";

		public static readonly string DeliveriesEndpoint = "/api/deliveries";
		public static readonly string DeliveriesDateEndpoint = "/api/deliveries/date/{0}";
		public static readonly string DeliveryEndpoint = "/api/deliveries/{0}";
		public static readonly string LoginEndpoint = "/api/Login/login";
		public static readonly string LogoutEndpoint = "/api/logout";
        public static readonly string PdfEndpoint = "/api/pdf/{0}";
        public static readonly string EventLogsEndpoint = "/api/log";
        public static readonly string SignUpEndpoint = "/api/Login/Register";
            
		//public static readonly string SignUpEndpoint = "/api/signup";
        //public static readonly string 


		public Server() { }

    }
    
}


