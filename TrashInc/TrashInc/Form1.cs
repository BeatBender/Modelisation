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
        public Form1()
        {
            InitializeComponent();
            StreamReader google = new StreamReader("../../GoogleMaps.html");
            webBrowser1.DocumentText = google.ReadToEnd();
            f.ajouterPointCentre(0, 180);
            f.ajouterPointChemin(0, 180);
            
        }

        //
    }
}
