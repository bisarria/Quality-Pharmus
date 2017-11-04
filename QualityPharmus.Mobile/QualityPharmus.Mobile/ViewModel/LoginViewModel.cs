using QualityPharmus.Mobile.Base;

namespace QualityPharmus.Mobile.ViewModel
{
    public class LoginViewModel: BaseViewModel
    {
        public LoginViewModel()
        {
            
        }

        public string Title { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
