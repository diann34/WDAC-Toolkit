// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// jogeurte 11/19

namespace WDAC_Wizard
{
    partial class SigningRules_Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            label7 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            rulesDataGrid = new System.Windows.Forms.DataGridView();
            column_Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            column_Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column_Files = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column_Exceptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            deleteButton = new System.Windows.Forms.Button();
            label_Error = new System.Windows.Forms.Label();
            addButton = new System.Windows.Forms.Button();
            checkBox_KernelList = new System.Windows.Forms.CheckBox();
            checkBox_UserModeList = new System.Windows.Forms.CheckBox();
            panel_Progress = new System.Windows.Forms.Panel();
            label_Progress = new System.Windows.Forms.Label();
            pictureBox_Progress = new System.Windows.Forms.PictureBox();
            backgroundWorkerRulesDeleter = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)rulesDataGrid).BeginInit();
            panel_Progress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Progress).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(168, 332);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(0, 21);
            label7.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(31, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(114, 29);
            label1.TabIndex = 47;
            label1.Text = "File Rules";
            // 
            // rulesDataGrid
            // 
            rulesDataGrid.AllowUserToDeleteRows = false;
            rulesDataGrid.AllowUserToResizeRows = false;
            rulesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            rulesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            rulesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rulesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { column_Action, column_Level, Column_Name, Column_Files, Column_Exceptions, column_ID });
            rulesDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            rulesDataGrid.EnableHeadersVisualStyles = false;
            rulesDataGrid.Location = new System.Drawing.Point(30, 102);
            rulesDataGrid.Margin = new System.Windows.Forms.Padding(2);
            rulesDataGrid.Name = "rulesDataGrid";
            rulesDataGrid.ReadOnly = true;
            rulesDataGrid.RowHeadersVisible = false;
            rulesDataGrid.RowHeadersWidth = 70;
            rulesDataGrid.RowTemplate.Height = 24;
            rulesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            rulesDataGrid.Size = new System.Drawing.Size(949, 440);
            rulesDataGrid.TabIndex = 92;
            rulesDataGrid.VirtualMode = true;
            rulesDataGrid.CellValueNeeded += RulesDataGrid_CellValueNeeded;
            // 
            // column_Action
            // 
            column_Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            column_Action.HeaderText = "Action";
            column_Action.MinimumWidth = 6;
            column_Action.Name = "column_Action";
            column_Action.ReadOnly = true;
            column_Action.Width = 73;
            // 
            // column_Level
            // 
            column_Level.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            column_Level.HeaderText = "Level";
            column_Level.MinimumWidth = 6;
            column_Level.Name = "column_Level";
            column_Level.ReadOnly = true;
            column_Level.Width = 69;
            // 
            // Column_Name
            // 
            Column_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column_Name.HeaderText = "Name";
            Column_Name.MinimumWidth = 6;
            Column_Name.Name = "Column_Name";
            Column_Name.ReadOnly = true;
            Column_Name.Width = 73;
            // 
            // Column_Files
            // 
            Column_Files.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column_Files.HeaderText = "Associated Files";
            Column_Files.MinimumWidth = 6;
            Column_Files.Name = "Column_Files";
            Column_Files.ReadOnly = true;
            Column_Files.Width = 125;
            // 
            // Column_Exceptions
            // 
            Column_Exceptions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            Column_Exceptions.HeaderText = "Exceptions";
            Column_Exceptions.MinimumWidth = 6;
            Column_Exceptions.Name = "Column_Exceptions";
            Column_Exceptions.ReadOnly = true;
            Column_Exceptions.Width = 102;
            // 
            // column_ID
            // 
            column_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            column_ID.HeaderText = "Rule ID";
            column_ID.MinimumWidth = 8;
            column_ID.Name = "column_ID";
            column_ID.ReadOnly = true;
            column_ID.Width = 74;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(31, 47);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(187, 21);
            label8.TabIndex = 91;
            label8.Text = "Policy Signing Rules List";
            label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(31, 29);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(591, 18);
            label3.TabIndex = 80;
            label3.Text = "Create allow or deny rules for files based on publisher, path, file attributes or hash values.";
            label3.Click += label3_Click;
            // 
            // deleteButton
            // 
            deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            deleteButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            deleteButton.Location = new System.Drawing.Point(837, 547);
            deleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(142, 26);
            deleteButton.TabIndex = 93;
            deleteButton.Text = "- Remove Rule";
            deleteButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // label_Error
            // 
            label_Error.AutoSize = true;
            label_Error.BackColor = System.Drawing.Color.Transparent;
            label_Error.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_Error.ForeColor = System.Drawing.Color.Red;
            label_Error.Location = new System.Drawing.Point(30, 636);
            label_Error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label_Error.Name = "label_Error";
            label_Error.Size = new System.Drawing.Size(648, 18);
            label_Error.TabIndex = 96;
            label_Error.Tag = "IgnoreDarkMode";
            label_Error.Text = "Label_Error: Lorem Ipsum text text text text. Lorum Ipsum text text text text text text text text";
            label_Error.Visible = false;
            // 
            // addButton
            // 
            addButton.Dock = System.Windows.Forms.DockStyle.Right;
            addButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            addButton.Location = new System.Drawing.Point(820, 71);
            addButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            addButton.Name = "addButton";
            addButton.Size = new System.Drawing.Size(159, 26);
            addButton.TabIndex = 97;
            addButton.Text = "+ Add Custom Rule";
            addButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += Label_AddCustomRules_Click;
            // 
            // checkBox_KernelList
            // 
            checkBox_KernelList.AutoSize = true;
            checkBox_KernelList.Location = new System.Drawing.Point(31, 609);
            checkBox_KernelList.Name = "checkBox_KernelList";
            checkBox_KernelList.Size = new System.Drawing.Size(336, 24);
            checkBox_KernelList.TabIndex = 98;
            checkBox_KernelList.Text = "Merge with Recommended Kernel Block Rules";
            checkBox_KernelList.UseVisualStyleBackColor = true;
            checkBox_KernelList.CheckedChanged += CheckBox_KernelList_CheckedChanged;
            // 
            // checkBox_UserModeList
            // 
            checkBox_UserModeList.AutoSize = true;
            checkBox_UserModeList.BackColor = System.Drawing.Color.White;
            checkBox_UserModeList.Location = new System.Drawing.Point(31, 579);
            checkBox_UserModeList.Name = "checkBox_UserModeList";
            checkBox_UserModeList.Size = new System.Drawing.Size(366, 24);
            checkBox_UserModeList.TabIndex = 99;
            checkBox_UserModeList.Text = "Merge with Recommended User Mode Block Rules";
            checkBox_UserModeList.UseVisualStyleBackColor = false;
            checkBox_UserModeList.CheckedChanged += CheckBox_UserModeList_CheckedChanged;
            // 
            // panel_Progress
            // 
            panel_Progress.Controls.Add(label_Progress);
            panel_Progress.Controls.Add(pictureBox_Progress);
            panel_Progress.Location = new System.Drawing.Point(527, 270);
            panel_Progress.Name = "panel_Progress";
            panel_Progress.Size = new System.Drawing.Size(156, 168);
            panel_Progress.TabIndex = 115;
            panel_Progress.Visible = false;
            // 
            // label_Progress
            // 
            label_Progress.AutoSize = true;
            label_Progress.Location = new System.Drawing.Point(23, 2);
            label_Progress.Name = "label_Progress";
            label_Progress.Size = new System.Drawing.Size(115, 20);
            label_Progress.TabIndex = 1;
            label_Progress.Text = "Removing Rules";
            label_Progress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox_Progress
            // 
            pictureBox_Progress.BackColor = System.Drawing.Color.Transparent;
            pictureBox_Progress.Image = Properties.Resources.loading;
            pictureBox_Progress.InitialImage = Properties.Resources.loading;
            pictureBox_Progress.Location = new System.Drawing.Point(14, 32);
            pictureBox_Progress.Name = "pictureBox_Progress";
            pictureBox_Progress.Size = new System.Drawing.Size(128, 128);
            pictureBox_Progress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox_Progress.TabIndex = 0;
            pictureBox_Progress.TabStop = false;
            pictureBox_Progress.Tag = "IgnoreDarkMode";
            // 
            // backgroundWorkerRulesDeleter
            // 
            backgroundWorkerRulesDeleter.DoWork += DoWorkBackgroundWorker;
            backgroundWorkerRulesDeleter.RunWorkerCompleted += FinishedBackgroundWorker;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.944384F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.05562F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(rulesDataGrid, 1, 4);
            tableLayoutPanel1.Controls.Add(label_Error, 1, 8);
            tableLayoutPanel1.Controls.Add(checkBox_KernelList, 1, 7);
            tableLayoutPanel1.Controls.Add(checkBox_UserModeList, 1, 6);
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(label8, 1, 2);
            tableLayoutPanel1.Controls.Add(addButton, 1, 3);
            tableLayoutPanel1.Controls.Add(deleteButton, 1, 5);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(103, 36);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(1002, 686);
            tableLayoutPanel1.TabIndex = 116;
            // 
            // SigningRules_Control
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            BackColor = System.Drawing.Color.White;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel_Progress);
            Controls.Add(label7);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "SigningRules_Control";
            Size = new System.Drawing.Size(1203, 725);
            Load += SigningRules_Control_Load;
            Validated += SigningRules_Control_Validated;
            ((System.ComponentModel.ISupportInitialize)rulesDataGrid).EndInit();
            panel_Progress.ResumeLayout(false);
            panel_Progress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Progress).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView rulesDataGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckBox checkBox_KernelList;
        private System.Windows.Forms.CheckBox checkBox_UserModeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Files;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Exceptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ID;
        private System.Windows.Forms.Panel panel_Progress;
        private System.Windows.Forms.Label label_Progress;
        private System.Windows.Forms.PictureBox pictureBox_Progress;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRulesDeleter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
