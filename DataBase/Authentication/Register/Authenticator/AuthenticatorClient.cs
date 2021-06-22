using DataBase.Modules;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class AuthenticatorClient : Authenticator
    {
        public AuthenticatorClient(Client client)
        {
            _request.Data = client;
        }

        public string AuthenticateClient()
        {
            var NameHandler = new NameHandler();
            var PhoneHandler = new PhoneNumberHandler();
            var BirthdateHandler = new BirthDateHandler();

            NameHandler.SetNext(PhoneHandler);
            PhoneHandler.SetNext(BirthdateHandler);

            NameHandler.Authenticator(_request);

            if (_request.ErrorMessage.Length != 0)
            {
                return _request.ErrorMessage.ToString();
            }
            else
            {
                return "Sucesso!";
            }
        }
    }
}