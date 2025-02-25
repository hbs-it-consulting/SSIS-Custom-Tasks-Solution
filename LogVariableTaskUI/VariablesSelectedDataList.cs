using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace LogVariableTaskUI
{
    public class VariablesSelectedDataList : BindingList<string>
    {
        private IList<string> variables;

        public VariablesSelectedDataList(IList<string> m_variables)
        {
            base.AllowNew = true;
            base.AllowEdit = true;
            variables = m_variables;
        }

        public void InitList()
        {
            int count = variables.Count;
            for (int i = 0; i < count; i++)
            {
                string item = variables[i].ToString();
                Add(item);
            }
        }
        public void CommitList()
        {
             
            variables.Clear();
            int num2 = 0;
            foreach (string item in base.Items)
            {
                variables.Add(item);
                num2++;
            }
        }
    }
}