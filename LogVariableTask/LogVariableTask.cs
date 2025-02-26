using Microsoft.SqlServer.Dts.Runtime;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
//62b1914e266ec1b3 public key
namespace LogVariableTask
{
    [DtsTask(
        TaskType = "DTS140"
      , DisplayName = "Log Variable Task"
      , IconResource = "LogVariableTask.LogVariableTaskICON.ico"
      , Description = "This task logs an SSIS package variable in an SSIS execution log."
      , UITypeName = "LogVariableTaskUI.LogVariableTaskUI, LogVariableTaskUI, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=5f4e01d31643cbb4"
      )]
    public class LogVariableTask : Microsoft.SqlServer.Dts.Runtime.Task, IDTSComponentPersist
    {
        private IDTSComponentEvents componentEvents { get; set; } = null;

        private readonly string _EventName = "Logging Variable : ";

        private StringCollection m_VariablesList = new StringCollection();
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        [Editor("Microsoft.DataTransformationServices.Controls.StringCollectionEditor, Microsoft.DataTransformationServices.Controls, Version=15.0.0.0, Culture=Neutral, PublicKeyToken=89845dcd8080cc91", "System.Drawing.Design.UITypeEditor,System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
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
            string SelectedVariableValue = string.Empty;
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
                SelectedVariableValue = variables[(object)selectedvariable].Value.ToString();
                WriteLog(componentEvents,_EventName, selectedvariable, SelectedVariableValue);
                variables.Unlock();
            }
                return DTSExecResult.Success;
        }

        private void WriteLog(IDTSComponentEvents componentEvents, string eventName, string selectedvariable, string VariableValue)
        {
            bool fireAgain = true;
            string message = "The value of the " + selectedvariable + "is " + VariableValue;
            componentEvents.FireInformation(0, eventName, message, string.Empty, 0, ref fireAgain);
        }

        public override void InitializeTask(Connections connections, VariableDispenser variableDispenser, IDTSInfoEvents events, IDTSLogging log, EventInfos eventInfos, LogEntryInfos logEntryInfos, ObjectReferenceTracker refTracker)
        {

        }
        public override DTSExecResult Validate(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log)
        {
            this.componentEvents = componentEvents;
            return DTSExecResult.Success;
        }

        public void SaveToXML(XmlDocument doc, IDTSInfoEvents infoEvents)
        {
            throw new NotImplementedException();
        }

        public void LoadFromXML(XmlElement node, IDTSInfoEvents infoEvents)
        {
            throw new NotImplementedException();
        }
    }
}
