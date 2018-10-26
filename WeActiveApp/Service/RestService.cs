using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeActiveApp.Constants;

namespace WeActiveApp.Service {
    
    public class RestService {
		
        HttpClient client;
        
        public RestService() {
            client = new HttpClient();
        }

		public RestService(string sessionKey = null) {
			CreateClient(sessionKey);
		}

		protected void CreateClient(string sessionKey = null) {
            
			if (client != null) {
				client.Dispose();
			}

			var authHeader = string.Format("{0}:{1}", Server.HTTPBasicUser, Server.HTTPBasicPassword);
			var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authHeader));

			client = new HttpClient();
			client.MaxResponseContentBufferSize = 256000;
			client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);

			if (!string.IsNullOrEmpty(sessionKey)) {
				client.DefaultRequestHeaders.Add("X-SessionKey", sessionKey);
			}
		}

		public async Task<HttpResponseMessage> GetAsync(Uri uri) {
            
			return await client.GetAsync(uri);
		}

		public async Task<HttpResponseMessage> PostAsync(Uri uri, string json = null) {
            
			if (string.IsNullOrEmpty(json)) {
                
				json = JsonConvert.SerializeObject(string.Empty);
			}

			var content = new StringContent(json, Encoding.UTF8, "application/json");

			return await client.PostAsync(uri, content);
		}

		public void Dispose() {
            
			try {
                
				if (client != null) {
                    
					client.Dispose();
				}

			} catch (Exception e) { }

		}


    }


    public interface IRestService {

		Task<HttpResponseMessage> GetAsync(Uri uri);

		Task<HttpResponseMessage> PostAsync(Uri uri, string json);

    }
}
