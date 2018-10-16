using MyAIFService.Interface;
using MyAIFService.MyServicePortServiceReference;
using System;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceProcess;

namespace MyAIFService
{
    public partial class AIFService : ServiceBase
    {
        private ServiceHost host;

        public AIFService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            // To attach a debugger to the service
            Debugger.Launch();

            // Note that all binding, endpoint, service, behavior configuration      
            // for this ServiceHost is located in the app.config     
            host = new ServiceHost(typeof(Service.MyService));
            WriteToEventViewer(string.Format("Opening the Service endpoint connection {0}", host.BaseAddresses[0].ToString()));

            try
            {
                host.Open();
                WriteToEventViewer(string.Format("Listening on: {0}", host.Description.Endpoints.Find(typeof(IMyService)).Address));
            }
            catch (Exception e)
            {
                WriteToEventViewer(e.Message);
            }
        }

        protected override void OnStop()
        {
            if ((null != host) && (host.State == CommunicationState.Opened))
                host.Close();
        }

        private void WriteToEventViewer(string eventMessage)
        {
            string source = "MyService WCF Service";

            if (!EventLog.SourceExists(source)) EventLog.CreateEventSource(source, "Application");

            EventLog.WriteEntry(source, eventMessage, EventLogEntryType.Information);
        }
    }
}
