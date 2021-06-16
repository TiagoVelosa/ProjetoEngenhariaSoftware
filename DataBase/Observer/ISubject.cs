namespace ClassLibraryEngSoft.Authentication.RegisterAuthentication.Observer
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Notify();
    }
}