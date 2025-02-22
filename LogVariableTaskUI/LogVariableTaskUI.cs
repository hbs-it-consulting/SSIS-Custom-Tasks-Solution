using Microsoft.SqlServer.Dts.Runtime;
using Microsoft.SqlServer.Dts.Runtime.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5f4e01d31643cbb4 public key
namespace LogVariableTaskUI
{
    public class LogVariableTaskUI : IDtsTaskUI
    {
        private TaskHost taskHost = null;
        private IDtsConnectionService connectionService = null;

        public void Delete(System.Windows.Forms.IWin32Window parentWindow)
        {
            
        }

        public System.Windows.Forms.ContainerControl GetView()
        {
            return new LogVariableTaskUIForm(taskHost, connectionService);
        }

        public void Initialize(TaskHost taskHost, IServiceProvider serviceProvider)
        {
            this.taskHost = taskHost;
            this.connectionService = serviceProvider.GetService(typeof(IDtsConnectionService)) as IDtsConnectionService;
        }

        public void New(System.Windows.Forms.IWin32Window parentWindow)
        {
             
        }
    }
}
