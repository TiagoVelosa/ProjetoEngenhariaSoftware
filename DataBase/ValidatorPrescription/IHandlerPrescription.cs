
using ClassLibraryEngSoft.Authentication.RegisterAuthentication;

namespace ClassLibraryEngSoft.ValidatorPrescription
{
    public interface IHandlerPrescription
    {
        void setNext(IHandlerPrescription next);

        object Validator(Request data);
    }
}