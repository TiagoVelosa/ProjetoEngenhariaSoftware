using System;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public abstract class BaseHandler : IHandler
    {

        protected IHandler _nextHandler;

        public BaseHandler()
        {
            _nextHandler = null;
        }
        public void SetNext(IHandler handler)
        {
            _nextHandler = handler;
        }

        public virtual object Authenticator(Request request)
        {
            return _nextHandler?.Authenticator(request);
        }
    }
}