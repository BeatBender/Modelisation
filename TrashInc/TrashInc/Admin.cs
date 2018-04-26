using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashInc
{
    class Admin : Observer, Observable
    {
        List<Observer> observers;

        private RichTextBox notificationBox;

        public Admin(RichTextBox notificationBox)
        {
            observers = new List<Observer>();
            this.notificationBox = notificationBox;
        }

        public void addObserver(Observer observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void removeObserver(Observer observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void notifyObservers()
        {
            foreach (Observer obs in observers)
            {
                obs.Notify(this);
            }
        }

        public void Notify(Observable obs)
        {
            throw new NotImplementedException();
        }
    }
}
