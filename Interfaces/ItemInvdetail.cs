using POS_SuperStore.ViewModel;
using static POS_SuperStore.Service_layer.Response;

namespace POS_SuperStore.Interfaces
{

    public interface ItemInvdetail
    {
        Task<ApiCallResponse> GetItemDetailById(Guid RequestId);
        Task<ApiCallResponse> GetFirstItemDetail();
    }
}
