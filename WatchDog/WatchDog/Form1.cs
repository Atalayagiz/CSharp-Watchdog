using MonitoredApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchDog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //https://www.turkhackteam.org/uye/endarion.955141/


            //Application Watcher uygulamayı belirtilen intervalda yeniden başlatır.
            ApplicationWatcher applicationWatcher = new ApplicationWatcher("notepad", "WatchDog", 5000);

            //Watchdog Watcher uygulama'nın çalışıp çalışmadığını belirtilen interval'da kontrol eder. Eğer ki çalışıyorsa herhangi bir şey yapmaz. Çalışmıyorsada çalıştırır.
            WatchdogWatcher watchdogWatcher = new WatchdogWatcher("notepad", "notepad.exe", 5000);






        }
    }
}
