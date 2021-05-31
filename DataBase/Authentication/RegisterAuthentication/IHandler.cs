namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public interface IHandler
    {
        void SetNext(IHandler handler);

        object Authenticator(Request request);
    }


}