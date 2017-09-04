using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            if (!System.Diagnostics.EventLog.SourceExists("ServiceSource"))
                System.Diagnostics.EventLog.CreateEventSource("ServiceSource", "serviceLog");
            eventLog1.Source = "ServiceSource";
            eventLog1.Log = "serviceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("My service started");
            //System.Timers.Timer timer = new System.Timers.Timer();
            //timer.Interval = 60000;
            //timer.Elapsed += new System.Timers.ElapsedEventHandler(this.onTimer);
            //timer.Start();
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Stopped");
           // eventLog1.WriteEntry("MONITRING THE SYSTEM", EventLogEntryType.Information);
        }
        //public void onTimer(object send,System.Timers.ElapsedEventArgs args)
        //{
        //    eventLog1.WriteEntry("60 sec elapsed", EventLogEntryType.Information);
        //}

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("file is created");
        }
    }
}
