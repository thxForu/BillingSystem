using System;
using System.Collections.Generic;

namespace ObserverCSharp
{
    public class Subject: ISubject
    {
        public Account account;
        
        private List<IObserver> _observers = new List<IObserver>();


        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void UpdateCash(float cashToAccount)
        {
            account.payment += cashToAccount;
            Console.Write("Paid {0}", cashToAccount);
            Notify();
        }
    }
}