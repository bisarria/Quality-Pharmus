namespace QualityPharmus.Mobile.Base
{
    public abstract class BaseViewModel : NotifyObject
    {
        private string _message ="Aguarde...";
        public string MessageText { get { return _message; } private set { SetProperty(ref _message, value); } }

        private bool _isBusy;
        public bool IsBusy { get { return _isBusy; } set { SetProperty(ref _isBusy, value); } }

        public void Loading(string message = "")
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                message = "Aguarde...";
            }

            MessageText = message;
            IsBusy = true;
        }
    }
}
