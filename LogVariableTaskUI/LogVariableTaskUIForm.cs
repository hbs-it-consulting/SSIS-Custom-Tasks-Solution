using Microsoft.DataTransformationServices.Controls;
using Microsoft.SqlServer.Dts.Runtime;
using Microsoft.SqlServer.Dts.Runtime.Design;
using System.Drawing;
using System.Windows.Forms;

namespace LogVariableTaskUI
{
    public class LogVariableTaskUIForm : DTSBaseTaskUI
    {
        private const string Title = "Log Variable Task Editor";
        private const string Description = "This task logs an SSIS package variable in an SSIS execution log.";
        public static Icon taskIcon = new Icon(typeof(LogVariableTask.LogVariableTask), "LogVariableTaskICON.ico");

        public LogVariableTaskUIForm(TaskHost taskHost, object connections) :
         base(Title, taskIcon, Description, taskHost, connections)
        {
            // Add General view
            GeneralView generalView = new GeneralView();
            this.DTSTaskUIHost.AddView("General", generalView, null);/*
            // Add Settings view
            SettingsView settingsView = new SettingsView();
            this.DTSTaskUIHost.AddView("Settings", settingsView, null);*/
        }
    }
}