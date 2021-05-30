namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication
{
    public interface IHandler
    {
        void SetNext(IHandler handler);

        void Process(Request request);
    }


}