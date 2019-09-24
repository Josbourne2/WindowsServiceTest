using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using log4net;

namespace ServiceTestUtil
{
    public class ServiceTestUtil
    {
        static Timer _timer;
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void StartTimer()
        {
            var timer = new Timer(3000);
            timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed);
            timer.Enabled = true;
            _timer = timer;
            while (true)
            {
                System.Threading.Thread.Sleep(2000);
                Logger.Info("WAITING");
            }

        }

        static void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Add DateTime for each timer event.
            Logger.Info("Hoi");            
            
        }


    }

}