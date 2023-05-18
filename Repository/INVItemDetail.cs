using Microsoft.EntityFrameworkCore;
using POS_SuperStore.Data;
using POS_SuperStore.Interfaces;
using POS_SuperStore.Service_layer;
using POS_SuperStore.ViewModel;

namespace POS_SuperStore.Repository
{
    public class INVItemDetail
    {
        private readonly POSDBContext _dbContext;
        private InventoryDetailVM _ItemDetailVM = new();
        public INVItemDetail(POSDBContext dbContextClass)
        {
            _dbContext = dbContextClass;
        }
        public async Task<InventoryDetailVM> GetItemDetailById(Guid requestId)
        {
            try
            {
                var res = await _dbContext.InventoryDetails.FirstOrDefaultAsync(x => x.RequestId == requestId);
                if (res != null)
                {
                    _ItemDetailVM = res;
                }
                return _ItemDetailVM;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }

}

