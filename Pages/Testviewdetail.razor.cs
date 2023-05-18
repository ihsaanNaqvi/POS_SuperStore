using Microsoft.AspNetCore.Components;
using POS.Model;
using POS_SuperStore.Interfaces;
using POS_SuperStore.Service_layer;
using POS_SuperStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.Blazor.Components;

namespace POS_SuperStore.Pages
{
    public partial class Testviewdetail : ComponentBase
    {

        

            [Parameter]
            public dynamic RequestId { get; set; }
        public List<InventoryDetailVM> inventoryDetailVMs;

 
        public InventoryDetailVM inventoryDetailVM = new InventoryDetailVM();

        #region On Load Component
        protected override async Task OnInitializedAsync()
        {
             inventoryDetailVMs = await HttpClient.GetJsonAsync<List<InventoryDetailVM>>("https://localhost:44381/api/GetAllItem");
        }
        //SpinnerService.Show();
        protected async Task Onclick(string text)
        {
            //inventoryDetailVM = (InventoryDetailVM)args.Item;
            //var result = await _ItemInvdetail.GetItemDetailById(Guid.Parse(RequestId));
            var result = await iNVInventoryDetail.GetFirstItemDetail();
                if (result.IsSuccessStatusCode)
                {
                inventoryDetailVM = (InventoryDetailVM)result.ResultData;

               }
               else
               {
             //await ReturnBadRequestNotification(result);
               }

            //    // SpinnerService.Hide();
            //}
        }


    }
    }
#endregion