using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWatch1
{
    public partial class Service1 : ServiceBase
    {
        
        public Service1()
        {
            InitializeComponent();

            if (!System.Diagnostics.EventLog.SourceExists("Mylog"))
                System.Diagnostics.EventLog.CreateEventSource("Mylog", "log1");
            eventLog1.Source = "Mylog";
            eventLog1.Log = "log1";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("event started");
        }

        protected override void OnStop()
        {
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("file created");
           
        }

        private void eventLog1_EntryWritten(object sender, EntryWrittenEventArgs e)
        {

        }
    }
}
