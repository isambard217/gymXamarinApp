using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using WeActiveApp.Service;
using WeActiveApp.Constants;
using WeActiveApp.Json;
using System.Diagnostics;
using WeActiveApp.Models;

namespace WeActiveApp.Manager {


    // A class used for managing Login, Sign-up and Sign-out
    public class UserManager : RestService {

		//private const string UrlRegister = "http://localhost:5000/api/Login/Register";
		private HttpClient _client = new HttpClient();
        
        public UserManager() {
            
        }

        public async Task<Session> Login (UserModel user) {


                // Create Server endpoint
                Uri functionUri = new Uri(Server.BaseUri + Server.LoginEndpoint);


                // Create a json object for session
                JsonSession jsonSession = new JsonSession(user);

                // Serialize object to json
                string json = JsonConvert.SerializeObject(jsonSession);

                // Do post 
                HttpResponseMessage response = await PostAsync(functionUri, json);
                string content = await response.Content.ReadAsStringAsync();

                JsonSession jsonDataBack = new JsonSession();

                if (response.IsSuccessStatusCode)  {

                    // Deserialize response received from Server
                    jsonDataBack = JsonConvert.DeserializeObject<JsonSession>(content);

                    return new Session(jsonDataBack);

                } else {

                    JsonError jsonError = JsonConvert.DeserializeObject<JsonError>(content);
                    //throw new HttpException(jsonError.Code, jsonError.Status, jsonError.Message);

                }

                
             return new Session(new JsonSession());

        }

     		public async Task<bool> SignUp(Models.UserModel user) {
            
			try {
               
				// Create uri for server endpoint
                Uri functionUri = new Uri(Server.BaseUri + Server.SignUpEndpoint);
				//Uri functionUri = new Uri(baseUri, Server.SignUpEndpoint);

				// Create json object for user
				JsonUser jsonUser = new JsonUser(user);

				// serialize object to json
				string json = JsonConvert.SerializeObject(jsonUser);

                // do post get response
                HttpResponseMessage response = await PostAsync(functionUri, json);
              
				if (!response.IsSuccessStatusCode) {
                    
					string content = await response.Content.ReadAsStringAsync();
					JsonError jsonError = JsonConvert.DeserializeObject<JsonError>(content);

                    //throw new HttpException(jsonError.Code, jsonError.Status, jsonError.Message);
                   // throw new Exception();
				}

				return true;

			} catch (Exception e) {

                Debug.WriteLine(e);
                return false;
            }
			
		}

	



    }
}
