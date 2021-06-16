using ClassLibraryEngSoft.Authentication.RegisterAuthentication;

namespace ClassLibraryEngSoft.ValidatorPrescription
{
    public class BaseHandlerPrescription : IHandlerPrescription
    {

        protected IHandlerPrescription _nextHandler;

        public BaseHandlerPrescription()
        {
            _nextHandler = null;
        }
        public void setNext(IHandlerPrescription next)
        {
            _nextHandler = next;
        }

        public virtual object Validator(Request data)
        {
            return _nextHandler?.Validator(data);
        }
    }
}