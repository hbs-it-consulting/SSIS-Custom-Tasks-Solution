using Microsoft.SqlServer.Dts.Runtime;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//62b1914e266ec1b3 public key
namespace LogVariableTask
{
    [DtsTask(
        TaskType = "DTS140"
      , DisplayName = "NBK - Log Variable Task"
      , IconResource = "LogVariableTask.LogVariableTaskICON.ico"
      , Description = "This task logs an SSIS package variable in an SSIS execution log."
      , UITypeName = "LogVariableTaskUI.LogVariableTaskUI, LogVariableTaskUI, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=5f4e01d31643cbb4"
      )]
    public class LogVariableTask : Microsoft.SqlServer.Dts.Runtime.Task
    {
        private IDTSComponentEvents componentEvents { get; set; } = null;

        private readonly string _EventName = "Logging Variable : ";

        private IList<string> m_VariablesList = new List<string>();
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        public IList<string> VariablesList
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
            string theString = string.Empty;
            Variables variables = (Variables)null;
            foreach (var selectedvariable in this.VariablesList)
            {
                variableDispenser.LockForRead(selectedvariable);
                variableDispenser.GetVariables(ref variables);
                if (variables[(object)selectedvariable].DataType != TypeCode.String)
                {
                    variables.Unlock();
                    return Microsoft.SqlServer.Dts.Runtime.DTSExecResult.Failure;
                }
                theString = variables[(object)selectedvariable].Value.ToString();
                variables.Unlock();
            }
                return DTSExecResult.Success;
        }

        private void WriteLog(IDTSComponentEvents componentEvents, string eventName, string qualifiedName)
        {
            bool fireAgain = true;
            //componentEvents.FireInformation(messageCode, subComponent, message, "", 0, ref fireAgain);
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
