using Microsoft.SqlServer.Dts.Runtime;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogVariableTask
{
    public class LogVariableTask : Microsoft.SqlServer.Dts.Runtime.Task
    {
        private IDTSComponentEvents componentEvents { get; set; } = null;

        private readonly string _EventName = "Logging Variable : ";

        private StringCollection m_VariablesList = new StringCollection();
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        public StringCollection VariablesList
        {
            get
            {
                return m_VariablesList;
            }
            set
            {
                m_VariablesList = value;
            }
        }
        public override DTSExecResult Execute(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log, object transaction)
        {
             
           variableDispenser.LockForRead("");

           Variables variables = null;
           variableDispenser.GetVariables(ref variables);
           VariableEnumerator enumerator = variables.GetEnumerator();
           // WriteLog(componentEvents, _EventName,"No of variables - " + variables.Count.ToString());
           while (((DtsEnumerator)enumerator).MoveNext())
           {
               string qualifiedName = enumerator.Current.Value.ToString();
               //WriteLog(componentEvents, _EventName, qualifiedName);

           }
           variables.Unlock(); 
            return DTSExecResult.Success;
        }


        public override void InitializeTask(Connections connections, VariableDispenser variableDispenser, IDTSInfoEvents events, IDTSLogging log, EventInfos eventInfos, LogEntryInfos logEntryInfos, ObjectReferenceTracker refTracker)
        {

        }
        public override DTSExecResult Validate(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log)
        {
            this.componentEvents = componentEvents;
            return DTSExecResult.Success;
        }
    }
}
