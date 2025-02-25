using Microsoft.DataTransformationServices.Controls;
using Microsoft.SqlServer.Dts.Runtime;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LogVariableTaskUI
{
    public class VariablesView : System.Windows.Forms.UserControl, IDTSTaskUIView
    {
        private TableLayoutPanel variablesGridviewTableLayoutPanel;
        private TableLayoutPanel addremovebuttonTableLayoutPanel;
        private DataGridView variablesGridView;
        private Button addVariable;
        private DataGridViewComboBoxColumn VariableName;
        private DataGridViewTextBoxColumn ColumnFill;
        private Button removeVariable;

        public VariablesView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.variablesGridviewTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addremovebuttonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.variablesGridView = new System.Windows.Forms.DataGridView();
            this.addVariable = new System.Windows.Forms.Button();
            this.removeVariable = new System.Windows.Forms.Button();
            this.VariableName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnFill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variablesGridviewTableLayoutPanel.SuspendLayout();
            this.addremovebuttonTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variablesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // variablesGridviewTableLayoutPanel
            // 
            this.variablesGridviewTableLayoutPanel.ColumnCount = 1;
            this.variablesGridviewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.variablesGridviewTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.variablesGridviewTableLayoutPanel.Controls.Add(this.variablesGridView, 0, 0);
            this.variablesGridviewTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.variablesGridviewTableLayoutPanel.Name = "variablesGridviewTableLayoutPanel";
            this.variablesGridviewTableLayoutPanel.RowCount = 1;
            this.variablesGridviewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.variablesGridviewTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 419F));
            this.variablesGridviewTableLayoutPanel.Size = new System.Drawing.Size(471, 419);
            this.variablesGridviewTableLayoutPanel.TabIndex = 0;
            // 
            // addremovebuttonTableLayoutPanel
            // 
            this.addremovebuttonTableLayoutPanel.AutoSize = true;
            this.addremovebuttonTableLayoutPanel.ColumnCount = 2;
            this.addremovebuttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.93976F));
            this.addremovebuttonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.06024F));
            this.addremovebuttonTableLayoutPanel.Controls.Add(this.removeVariable, 1, 0);
            this.addremovebuttonTableLayoutPanel.Controls.Add(this.addVariable, 0, 0);
            this.addremovebuttonTableLayoutPanel.Location = new System.Drawing.Point(142, 448);
            this.addremovebuttonTableLayoutPanel.Name = "addremovebuttonTableLayoutPanel";
            this.addremovebuttonTableLayoutPanel.RowCount = 1;
            this.addremovebuttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.addremovebuttonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.addremovebuttonTableLayoutPanel.Size = new System.Drawing.Size(332, 41);
            this.addremovebuttonTableLayoutPanel.TabIndex = 1;
            // 
            // variablesGridView
            // 
            this.variablesGridView.AllowUserToAddRows = false;
            this.variablesGridView.AllowUserToDeleteRows = false;
            this.variablesGridView.AllowUserToResizeColumns = false;
            this.variablesGridView.AllowUserToResizeRows = false;
            this.variablesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.variablesGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.variablesGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.variablesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.variablesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.variablesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.variablesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VariableName,
            this.ColumnFill});
            this.variablesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.variablesGridView.Location = new System.Drawing.Point(3, 3);
            this.variablesGridView.MultiSelect = false;
            this.variablesGridView.Name = "variablesGridView";
            this.variablesGridView.RowHeadersVisible = false;
            this.variablesGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.variablesGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.variablesGridView.RowTemplate.Height = 28;
            this.variablesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.variablesGridView.Size = new System.Drawing.Size(465, 413);
            this.variablesGridView.TabIndex = 4;
            this.variablesGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.variablesGridView_CellValidating);
            this.variablesGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.variablesGridView_CurrentCellDirtyStateChanged);
            this.variablesGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.variablesGridView_DataBindingComplete);
            this.variablesGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.variablesGridView_DataError);
            this.variablesGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.variablesGridView_EditingControlShowing);
            this.variablesGridView.SelectionChanged += new System.EventHandler(this.variablesGridView_SelectionChanged);
            // 
            // addVariable
            // 
            this.addVariable.AutoSize = true;
            this.addVariable.Location = new System.Drawing.Point(3, 3);
            this.addVariable.Name = "addVariable";
            this.addVariable.Size = new System.Drawing.Size(110, 30);
            this.addVariable.TabIndex = 5;
            this.addVariable.Text = "Add Variable";
            this.addVariable.UseVisualStyleBackColor = true;
            this.addVariable.Click += new System.EventHandler(this.addVariable_Click);
            // 
            // removeVariable
            // 
            this.removeVariable.AutoSize = true;
            this.removeVariable.Location = new System.Drawing.Point(119, 3);
            this.removeVariable.Name = "removeVariable";
            this.removeVariable.Size = new System.Drawing.Size(140, 30);
            this.removeVariable.TabIndex = 6;
            this.removeVariable.Text = "Remove Variable";
            this.removeVariable.UseVisualStyleBackColor = true;
            this.removeVariable.Click += new System.EventHandler(this.removeVariable_Click);
            // 
            // VariableName
            // 
            this.VariableName.HeaderText = "Variable";
            this.VariableName.MinimumWidth = 8;
            this.VariableName.Name = "VariableName";
            ((DataGridViewColumn)VariableName).AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ((DataGridViewColumn)VariableName).DataPropertyName = "VariableName";
            VariableName.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            VariableName.DropDownWidth = 160;
            VariableName.FlatStyle = FlatStyle.Flat;
            VariableName.MaxDropDownItems = 5;            
            ((DataGridViewBand)VariableName).Resizable = DataGridViewTriState.True;
            VariableName.Sorted = true;
            //((DataGridViewColumn)VariableName).Width = (int)(160f * 20f);

            // 
            // ColumnFill
            // 
            this.ColumnFill.HeaderText = "";
            this.ColumnFill.MinimumWidth = 8;
            this.ColumnFill.Name = "ColumnFill";
            this.ColumnFill.ReadOnly = true;
            ((DataGridViewColumn)ColumnFill).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // 
            // VariablesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addremovebuttonTableLayoutPanel);
            this.Controls.Add(this.variablesGridviewTableLayoutPanel);
            this.Name = "VariablesView";
            this.Size = new System.Drawing.Size(951, 595);
            this.variablesGridviewTableLayoutPanel.ResumeLayout(false);
            this.addremovebuttonTableLayoutPanel.ResumeLayout(false);
            this.addremovebuttonTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variablesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void OnCommit(object taskHost)
        {
             
        }

        public void OnInitialize(IDTSTaskUIHost treeHost, TreeNode viewNode, object taskHost, object connections)
        {
     
        }

        public void OnLoseSelection(ref bool bCanLeaveView, ref string reason)
        {
            
        }

        public void OnSelection()
        {
            
        }

        public void OnValidate(ref bool bViewIsValid, ref string reason)
        {
            
        }

        private void removeVariable_Click(object sender, EventArgs e)
        {

        }

        private void addVariable_Click(object sender, EventArgs e)
        {

        }

        private void variablesGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        private void variablesGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }

        private void variablesGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

        }

        private void variablesGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void variablesGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void variablesGridView_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}