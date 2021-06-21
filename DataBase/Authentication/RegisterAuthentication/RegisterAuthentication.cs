using DataBase.Modules;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class RegisterAuthentication
    {
        private readonly Request _request;

        public RegisterAuthentication(Doctor doctor)
        {
            _request.Data = doctor;

        }

        public string AuthenticateDoctor()
        {
            var NameHandler = new NameDoctorHandler();
            var PhoneHandler = new PhoneNumberDoctor();
            var SalaryHandler = new SalaryHandler();
            var BirthdateHandler = new BirthDateDoctorHandler();

            NameHandler.SetNext(PhoneHandler);
            PhoneHandler.SetNext(SalaryHandler);
            SalaryHandler.SetNext(BirthdateHandler);

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