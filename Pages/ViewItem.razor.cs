using Azure.Core;
using Microsoft.AspNetCore.Components;
using POS_SuperStore.Service_layer;
using POS_SuperStore.ViewModel;
using Radzen.Blazor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_SuperStore.Pages
{
    public partial class ViewItem : ComponentBase
    {
        [Parameter]
        public dynamic RequestId { get; set; }


        public InventoryDetailVM inventoryDetailVM = new InventoryDetailVM();
        //InventoryDetailVM inventoryDetailVM = new();
        IEnumerable<InventoryDetailVM> inventoryDetailVMs;
        protected RadzenDataGrid<InventoryDetailVM> RequestGrid;
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
        #region Redirect Function
        private void GoBackDashboard()
        {
           // navigationManager.NavigateTo("/dashboard");
            
        }


        private void GoBackHomeScreen()
        {
            //navigationManager.NavigateTo("/index");
        }
        #endregion
    }
}

#endregion
