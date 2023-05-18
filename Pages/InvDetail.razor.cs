using Azure.Core;
using Microsoft.AspNetCore.Components;
using POS_SuperStore.Interfaces;
using POS_SuperStore.Repository;
using POS_SuperStore.Service_layer;
using POS_SuperStore.ViewModel;
using Radzen.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_SuperStore.Pages
{
    public partial class InvDetail : ComponentBase
    {
        
        [Parameter]
        public dynamic RequestId { get; set; }
        

        public InventoryDetailVM inventoryDetailVM = new InventoryDetailVM();
        //private readonly ItemInvdetail iNVInventoryDetail;       
        #region On Load Component
        protected override async Task OnInitializedAsync()
        {
            //SpinnerService.Show();
            //var result = await iNVInventoryDetail.GetItemDetailById(Guid.Parse(RequestId));
            var result = await iNVInventoryDetail.GetFirstItemDetail();
            if (result.IsSuccessStatusCode)
            {
                inventoryDetailVM = (InventoryDetailVM)result.ResultData;

            }
            else
            {
              // await ReturnBadRequestNotification(result);
            }

           // SpinnerService.Hide();
        }

    }
} 
#endregion