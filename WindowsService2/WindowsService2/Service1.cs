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

namespace WindowsService2
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
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Stopped");
        }

        private void eventLog1_EntryWritten(object sender, EntryWrittenEventArgs e)
        {
            eventLog1.WriteEntry("file is created in event");
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("file is changed");
            File.Copy(@"C:\Users\sureshkumar_a\Documents\Visual Studio 2015\Projects\WindowsService2\file1\" + e.Name, @"C:\Users\sureshkumar_a\Documents\Visual Studio 2015\Projects\WindowsService2\backup\" + e.Name, true);

        }

        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("file is created");
            File.Copy(@"C:\Users\sureshkumar_a\Documents\Visual Studio 2015\Projects\WindowsService2\file1\"+e.Name, @"C:\Users\sureshkumar_a\Documents\Visual Studio 2015\Projects\WindowsService2\backup\"+e.Name,true);
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("file is deleted");
        }
    }
}
