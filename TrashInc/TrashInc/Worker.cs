using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrashInc;
using System.Windows.Forms;

namespace TrashInc
{
    class Worker : Observer, Observable
    {
        List<Observer> observers;
        private string name;
        private RichTextBox notificationBox;
        private Route currentRoute;

        private bool isRouteEnded = false;

        public Worker(string name, RichTextBox notificationBox)
        {
            observers = new List<Observer>();
            this.name = name;
            this.notificationBox = notificationBox;
        }

        public void BeginRoute(Route route)
        {
            currentRoute = route;
            isRouteEnded = false;
            notifyObservers();
        }

        public void EndRoute()
        {
            currentRoute = null;
            isRouteEnded = true;
            notifyObservers();
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

        public string GetName()
        {
            return name;
        }

        public void Notify(Observable obs)
        {
            if (obs.GetType() == typeof(Worker))
            {
                Worker worker = obs as Worker;
                if (!worker.isRouteEnded)
                {
                    notificationBox.AppendText("Départ de : " + worker.GetName() + "\n");
                }
                else
                {
                    notificationBox.AppendText("Arrivé de : " + worker.GetName() + "\n");
                }

            }
        }
    }
}
