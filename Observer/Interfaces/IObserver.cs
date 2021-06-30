using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    interface IObserver
    {
        //The observer should update the last status of subject
        void Update(ISubject subject);
    }
}
