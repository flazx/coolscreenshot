using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace CoolScreenShot
{
    static class Program
    {
	    //Single instance: http://odetocode.com/blogs/scott/archive/2004/08/20/the-misunderstood-mutex.aspx
        static Mutex mutex = new Mutex(true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04E6BDE8F}");
        [STAThread]
        static void Main()
        {
            CoolShotApplicationContext applicationContext = null;
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                applicationContext = new CoolShotApplicationContext();
                Application.Run(applicationContext);

                mutex.ReleaseMutex();
            }
            else {
                MessageBox.Show("CoolShot is running!");
            }
        }
    }
}