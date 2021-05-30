using System;

namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public class BaseHandler : IHandler
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

        public virtual void Process(Request request)
        {
            throw new NotImplementedException();
        }
    }
}