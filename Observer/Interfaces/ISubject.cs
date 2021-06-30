using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface ISubject
    {
        //The observer should subscribe to the subject.
        void Attach(IObserver observer);
        //The observer will get notified about changes.
        void Notify();
    }
}
