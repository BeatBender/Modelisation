using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TrashInc
{
    public partial class Form1 : Form
    {
        Facade f = new Facade();
        Worker worker1;
        Worker worker2;
        Worker worker3;

        Route clonableRoute;

        public Form1()
        {
            InitializeComponent();
            StreamReader google = new StreamReader("../../GoogleMaps.html");
            webBrowser1.DocumentText = google.ReadToEnd();

            worker1 = new Worker(driver1TabPage.Text, drv1NotifBox);
            worker2 = new Worker(driver2TabPage.Text, drv2NotifBox);
            worker3 = new Worker(driver3TabPage.Text, drv3NotifBox);
            clonableRoute = new Route("Saguenay", 1000000, true);

            worker1.addObserver(worker2);
            worker1.addObserver(worker3);

            worker2.addObserver(worker1);
            worker2.addObserver(worker3);

            worker3.addObserver(worker1);
            worker3.addObserver(worker2);

            f.addPointCenter(0, 180);
            f.addPointRoute(0, 180);
        }

        private void drv1BeginBtn_Click(object sender, EventArgs e)
        {
            worker1.BeginRoute(clonableRoute);
        }

        private void drv2BeginBtn_Click(object sender, EventArgs e)
        {
            worker2.BeginRoute((Route)clonableRoute.Clone());
        }

        private void drv3BeginBtn_Click(object sender, EventArgs e)
        {
            worker3.BeginRoute((Route)clonableRoute.Clone());
        }

        private void drv1EndBtn_Click(object sender, EventArgs e)
        {
            worker1.EndRoute();
        }

        private void drv2EndBtn_Click(object sender, EventArgs e)
        {
            worker2.EndRoute();
        }

        private void drv3EndBtn_Click(object sender, EventArgs e)
        {
            worker3.EndRoute();
        }
    }
}
