namespace ObserverCSharp
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}