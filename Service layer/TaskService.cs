using System.Net.Http.Headers;
using System.Text;
using POS_SuperStore.Data;
using POS_SuperStore.Pages;
using static POS_SuperStore.Service_layer.Response;
 

namespace POS_SuperStore.Service_layer
{
    public class TaskService
    {
        internal readonly object Connection;
        private readonly IConfiguration _config;

        public TaskService(IConfiguration configuration)
        {
            _config = configuration;
           
        }
		// Save Reason For Rejection

		public async Task<ApiCallResponse> RejectReason(RejectReason RejectReason)
		{
            try
            {

                var request = new HttpRequestMessage(HttpMethod.Post,("https://localhost:44381/RejectReason"));
                var postBody = RejectReason;
                request.Content = new StringContent(System.Text.Json.JsonSerializer.Serialize(postBody), Encoding.UTF8, "application/json");
                //request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await _browserStorage.GetItemAsync<string>("Token"));
                var response = await new HttpClient().SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<bool>();
                    return new ApiCallResponse { StatusCode = response.StatusCode, IsSuccessStatusCode = response.IsSuccessStatusCode, ResultData = content };
                }
                else
                {
                    var content = await response.Content.ReadFromJsonAsync<BadRequestResponse>();
                    return new ApiCallResponse { StatusCode = response.StatusCode, IsSuccessStatusCode = response.IsSuccessStatusCode, ResultData = content };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        internal object ConnectAsync()
        {
            throw new NotImplementedException();
        }
    }

	public interface ILocalStorageService
	{
		Task<RejectReason> GetItemAsync<T>(T v);
	}
}



