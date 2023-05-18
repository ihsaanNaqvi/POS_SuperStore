namespace POS_SuperStore.Service_layer
{
    
        public class SpinnerService
        {
            public event Action OnShow;
            public event Action OnHide;

            public void Show()
            {
                OnShow?.Invoke();
            }

            public void Hide()
            {
                OnHide?.Invoke();
            }
        }
    
}
