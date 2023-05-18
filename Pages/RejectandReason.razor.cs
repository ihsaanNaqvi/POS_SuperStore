using GalaSoft.MvvmLight.Views;
using Microsoft.AspNetCore.Components;
using POS_SuperStore.Data;
using POS_SuperStore.Service_layer;
using Radzen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_SuperStore.Pages
{
    public partial class RejectandReason : ComponentBase
    {
       // public Guid RejectionId { get; private set; }

       private readonly TaskService _taskService;

        [Parameter]
        public dynamic ReferenceId { get; set; } = "123";

        //public RejectandReason(TaskService taskService)
        //{
        //    _taskService = taskService;
        //}

        protected RejectReason rejectReason = new RejectReason();
        //internal object createdby;

        //protected RejectReason GetRejectReason()
        //{
        //    return rejectReason;
        //}

        //public RejectandReason(TaskService taskService)
        //{
        //    _taskService = taskService;
        //}

        protected async Task Form0Submit()
        {
             try
            { 
                

                rejectReason.RejectionId = Guid.NewGuid();
                rejectReason.ReferenceId = ReferenceId;
                var response = await _taskService.RejectReason(rejectReason);
                if (response.IsSuccessStatusCode)
                {
                    var result = (bool)response.ResultData;
                    StateHasChanged();
                    //rejectReason.Reason = "";
                }
            }

             catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }




    }

}    
 
