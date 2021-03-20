namespace SqlManagmentStudio.Windows
{
    partial class SqlManagerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hierarchy_TreeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectToServer_Btn = new System.Windows.Forms.Button();
            this.executeQuery_Btn = new System.Windows.Forms.Button();
            this.databases_combo = new System.Windows.Forms.ComboBox();
            this.selectedDatabase_Label = new System.Windows.Forms.Label();
            this.sqlEditorPage = new System.Windows.Forms.TabPage();
            this.sqlEditor_TextBox = new System.Windows.Forms.TextBox();
            this.sqlQueryResult_GridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.queryExecutionState_Label = new System.Windows.Forms.Label();
            this.elapsedTime_Label = new System.Windows.Forms.Label();
            this.rowsCount_Label = new System.Windows.Forms.Label();
            this.sqlQueryControl = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.sqlEditorPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlQueryResult_GridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.sqlQueryControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // hierarchy_TreeView
            // 
            this.hierarchy_TreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.hierarchy_TreeView.Enabled = false;
            this.hierarchy_TreeView.Location = new System.Drawing.Point(0, 0);
            this.hierarchy_TreeView.Name = "hierarchy_TreeView";
            this.hierarchy_TreeView.Size = new System.Drawing.Size(251, 727);
            this.hierarchy_TreeView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.connectToServer_Btn);
            this.panel1.Controls.Add(this.executeQuery_Btn);
            this.panel1.Controls.Add(this.databases_combo);
            this.panel1.Controls.Add(this.selectedDatabase_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(251, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 41);
            this.panel1.TabIndex = 2;
            // 
            // connectToServer_Btn
            // 
            this.connectToServer_Btn.Location = new System.Drawing.Point(326, 9);
            this.connectToServer_Btn.Name = "connectToServer_Btn";
            this.connectToServer_Btn.Size = new System.Drawing.Size(83, 24);
            this.connectToServer_Btn.TabIndex = 3;
            this.connectToServer_Btn.Text = "Connect ";
            this.connectToServer_Btn.UseVisualStyleBackColor = true;
            this.connectToServer_Btn.Click += new System.EventHandler(this.connectToServer_Btn_Click);
            // 
            // executeQuery_Btn
            // 
            this.executeQuery_Btn.Enabled = false;
            this.executeQuery_Btn.Location = new System.Drawing.Point(246, 9);
            this.executeQuery_Btn.Name = "executeQuery_Btn";
            this.executeQuery_Btn.Size = new System.Drawing.Size(75, 24);
            this.executeQuery_Btn.TabIndex = 2;
            this.executeQuery_Btn.Text = "Execute";
            this.executeQuery_Btn.UseVisualStyleBackColor = true;
            this.executeQuery_Btn.Click += new System.EventHandler(this.executeQuery_Btn_Click);
            // 
            // databases_combo
            // 
            this.databases_combo.Enabled = false;
            this.databases_combo.FormattingEnabled = true;
            this.databases_combo.Location = new System.Drawing.Point(119, 10);
            this.databases_combo.Name = "databases_combo";
            this.databases_combo.Size = new System.Drawing.Size(121, 23);
            this.databases_combo.TabIndex = 1;
            // 
            // selectedDatabase_Label
            // 
            this.selectedDatabase_Label.AutoSize = true;
            this.selectedDatabase_Label.Location = new System.Drawing.Point(12, 13);
            this.selectedDatabase_Label.Name = "selectedDatabase_Label";
            this.selectedDatabase_Label.Size = new System.Drawing.Size(101, 15);
            this.selectedDatabase_Label.TabIndex = 0;
            this.selectedDatabase_Label.Text = "Selected database";
            // 
            // sqlEditorPage
            // 
            this.sqlEditorPage.Controls.Add(this.sqlEditor_TextBox);
            this.sqlEditorPage.Controls.Add(this.sqlQueryResult_GridView);
            this.sqlEditorPage.Controls.Add(this.panel2);
            this.sqlEditorPage.Location = new System.Drawing.Point(4, 24);
            this.sqlEditorPage.Name = "sqlEditorPage";
            this.sqlEditorPage.Padding = new System.Windows.Forms.Padding(3);
            this.sqlEditorPage.Size = new System.Drawing.Size(843, 658);
            this.sqlEditorPage.TabIndex = 0;
            this.sqlEditorPage.Text = "Sql Editor";
            this.sqlEditorPage.UseVisualStyleBackColor = true;
            // 
            // sqlEditor_TextBox
            // 
            this.sqlEditor_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlEditor_TextBox.Enabled = false;
            this.sqlEditor_TextBox.Location = new System.Drawing.Point(3, 3);
            this.sqlEditor_TextBox.Multiline = true;
            this.sqlEditor_TextBox.Name = "sqlEditor_TextBox";
            this.sqlEditor_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sqlEditor_TextBox.Size = new System.Drawing.Size(837, 262);
            this.sqlEditor_TextBox.TabIndex = 3;
            // 
            // sqlQueryResult_GridView
            // 
            this.sqlQueryResult_GridView.AllowUserToAddRows = false;
            this.sqlQueryResult_GridView.AllowUserToDeleteRows = false;
            this.sqlQueryResult_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sqlQueryResult_GridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.sqlQueryResult_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlQueryResult_GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sqlQueryResult_GridView.Location = new System.Drawing.Point(3, 265);
            this.sqlQueryResult_GridView.Name = "sqlQueryResult_GridView";
            this.sqlQueryResult_GridView.ReadOnly = true;
            this.sqlQueryResult_GridView.RowTemplate.Height = 25;
            this.sqlQueryResult_GridView.Size = new System.Drawing.Size(837, 377);
            this.sqlQueryResult_GridView.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.queryExecutionState_Label);
            this.panel2.Controls.Add(this.elapsedTime_Label);
            this.panel2.Controls.Add(this.rowsCount_Label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 642);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 13);
            this.panel2.TabIndex = 1;
            // 
            // queryExecutionState_Label
            // 
            this.queryExecutionState_Label.AutoSize = true;
            this.queryExecutionState_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.queryExecutionState_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.queryExecutionState_Label.Location = new System.Drawing.Point(0, 0);
            this.queryExecutionState_Label.Name = "queryExecutionState_Label";
            this.queryExecutionState_Label.Size = new System.Drawing.Size(0, 15);
            this.queryExecutionState_Label.TabIndex = 2;
            // 
            // elapsedTime_Label
            // 
            this.elapsedTime_Label.AutoSize = true;
            this.elapsedTime_Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.elapsedTime_Label.Location = new System.Drawing.Point(666, 0);
            this.elapsedTime_Label.Name = "elapsedTime_Label";
            this.elapsedTime_Label.Size = new System.Drawing.Size(124, 15);
            this.elapsedTime_Label.TabIndex = 1;
            this.elapsedTime_Label.Text = "Elapsed Time: 00:00:00";
            // 
            // rowsCount_Label
            // 
            this.rowsCount_Label.AutoSize = true;
            this.rowsCount_Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.rowsCount_Label.Location = new System.Drawing.Point(790, 0);
            this.rowsCount_Label.Name = "rowsCount_Label";
            this.rowsCount_Label.Size = new System.Drawing.Size(47, 15);
            this.rowsCount_Label.TabIndex = 0;
            this.rowsCount_Label.Text = "Rows: 0";
            // 
            // sqlQueryControl
            // 
            this.sqlQueryControl.Controls.Add(this.sqlEditorPage);
            this.sqlQueryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlQueryControl.Location = new System.Drawing.Point(251, 41);
            this.sqlQueryControl.Name = "sqlQueryControl";
            this.sqlQueryControl.SelectedIndex = 0;
            this.sqlQueryControl.Size = new System.Drawing.Size(851, 686);
            this.sqlQueryControl.TabIndex = 4;
            // 
            // SqlManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 727);
            this.Controls.Add(this.sqlQueryControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hierarchy_TreeView);
            this.Name = "SqlManagerForm";
            this.Text = "SQL Managment Studio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sqlEditorPage.ResumeLayout(false);
            this.sqlEditorPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlQueryResult_GridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sqlQueryControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView hierarchy_TreeView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label selectedDatabase_Label;
        private System.Windows.Forms.ComboBox databases_combo;
        private System.Windows.Forms.Button executeQuery_Btn;
        private System.Windows.Forms.TabPage sqlEditorPage;
        private System.Windows.Forms.DataGridView sqlQueryResult_GridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl sqlQueryControl;
        private System.Windows.Forms.TextBox sqlEditor_TextBox;
        private System.Windows.Forms.Label rowsCount_Label;
        private System.Windows.Forms.Label elapsedTime_Label;
        private System.Windows.Forms.Label queryExecutionState_Label;
        private System.Windows.Forms.Button connectToServer_Btn;
    }
}

