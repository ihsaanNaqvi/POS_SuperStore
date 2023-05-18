using static POS_SuperStore.Service_layer.Response;
using System.Net.Http.Headers;
using System.Net;
using POS_SuperStore.ViewModel;
using POS_SuperStore.Interfaces;

namespace POS_SuperStore.Service_layer
{
    public class INVInventoryDetail : ItemInvdetail
    {
        private readonly IConfiguration _config;
        private readonly ILocalStorageService browserStorage;
        public INVInventoryDetail(IConfiguration config)
        {
            _config = config;
        }

        public async Task<ApiCallResponse> GetFirstItemDetail()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:44381/api/ItemDetail/GetFirtItemDetail");
                //  request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await browserStorage.GetItemAsync<string>("Token"));
                var response = await new HttpClient().SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadFromJsonAsync<InventoryDetailVM>();
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
                return new ApiCallResponse { StatusCode = HttpStatusCode.BadRequest, IsSuccessStatusCode = false, ResultData = new BadRequestResponse { Message = ex.Message, InnerException = ex.InnerException?.Message } };
            }
        }

        public Task<ApiCallResponse> GetItemDetailById(Guid RequestId)
        {
            throw new NotImplementedException();
        }

        //public async Task<ApiCallResponse> GetItemDetailById(Guid RequestId)
        //{
        //    try
        //    {
        //        var request = new HttpRequestMessage(HttpMethod.Get,"https://localhost:44381/api/ItemDetail/GetItemDetailById/" + RequestId);
        //      //  request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", await browserStorage.GetItemAsync<string>("Token"));
        //        var response = await new HttpClient().SendAsync(request);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var content = await response.Content.ReadFromJsonAsync<InventoryDetailVM>();
        //            return new ApiCallResponse { StatusCode = response.StatusCode, IsSuccessStatusCode = response.IsSuccessStatusCode, ResultData = content };
        //        }
        //        else
        //        {
        //            var content = await response.Content.ReadFromJsonAsync<BadRequestResponse>();
        //            return new ApiCallResponse { StatusCode = response.StatusCode, IsSuccessStatusCode = response.IsSuccessStatusCode, ResultData = content };
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return new ApiCallResponse { StatusCode = HttpStatusCode.BadRequest, IsSuccessStatusCode = false, ResultData = new BadRequestResponse { Message = ex.Message, InnerException = ex.InnerException?.Message } };
        //    }
    }
    
}


