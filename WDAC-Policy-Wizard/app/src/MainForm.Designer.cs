// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// jogeurte 11/19

namespace WDAC_Wizard
{
    partial class MainWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            label_Welcome = new System.Windows.Forms.Label();
            button_New = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button_Edit = new System.Windows.Forms.Button();
            button_Merge = new System.Windows.Forms.Button();
            control_Panel = new System.Windows.Forms.Panel();
            workflow_Label = new System.Windows.Forms.Label();
            page5_Button = new System.Windows.Forms.Button();
            page4_Button = new System.Windows.Forms.Button();
            page3_Button = new System.Windows.Forms.Button();
            page2_Button = new System.Windows.Forms.Button();
            page1_Button = new System.Windows.Forms.Button();
            controlHighlight_Panel = new System.Windows.Forms.Panel();
            home_Button = new System.Windows.Forms.Button();
            settings_Button = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutControl = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            button_Next = new System.Windows.Forms.Button();
            label_Info = new System.Windows.Forms.Label();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            control_Panel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutControl.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label_Welcome
            // 
            label_Welcome.AutoSize = true;
            label_Welcome.BackColor = System.Drawing.Color.Transparent;
            label_Welcome.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_Welcome.ForeColor = System.Drawing.Color.Black;
            label_Welcome.Location = new System.Drawing.Point(3, 17);
            label_Welcome.Name = "label_Welcome";
            label_Welcome.Size = new System.Drawing.Size(115, 30);
            label_Welcome.TabIndex = 3;
            label_Welcome.Text = "Welcome";
            // 
            // button_New
            // 
            button_New.BackColor = System.Drawing.Color.Transparent;
            button_New.Dock = System.Windows.Forms.DockStyle.Fill;
            button_New.FlatAppearance.BorderSize = 0;
            button_New.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            button_New.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            button_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_New.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button_New.Image = Properties.Resources.newPolicy;
            button_New.Location = new System.Drawing.Point(136, 76);
            button_New.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button_New.Name = "button_New";
            button_New.Size = new System.Drawing.Size(260, 245);
            button_New.TabIndex = 10;
            button_New.Text = "Policy Creator";
            button_New.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button_New.UseVisualStyleBackColor = false;
            button_New.Click += Button_New_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
            // 
            // button_Edit
            // 
            button_Edit.BackColor = System.Drawing.Color.Transparent;
            button_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            button_Edit.FlatAppearance.BorderSize = 0;
            button_Edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            button_Edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Edit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button_Edit.Image = Properties.Resources.tools;
            button_Edit.Location = new System.Drawing.Point(402, 76);
            button_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new System.Drawing.Size(260, 245);
            button_Edit.TabIndex = 25;
            button_Edit.Text = "Policy Editor";
            button_Edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button_Edit.UseVisualStyleBackColor = false;
            button_Edit.Click += Button_Edit_Click;
            // 
            // button_Merge
            // 
            button_Merge.BackColor = System.Drawing.Color.Transparent;
            button_Merge.Dock = System.Windows.Forms.DockStyle.Fill;
            button_Merge.FlatAppearance.BorderSize = 0;
            button_Merge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            button_Merge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            button_Merge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button_Merge.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            button_Merge.Image = Properties.Resources.merge;
            button_Merge.Location = new System.Drawing.Point(668, 76);
            button_Merge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button_Merge.Name = "button_Merge";
            button_Merge.Size = new System.Drawing.Size(260, 245);
            button_Merge.TabIndex = 26;
            button_Merge.Text = "Policy Merger";
            button_Merge.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button_Merge.UseVisualStyleBackColor = false;
            button_Merge.Click += Button_Merge_Click;
            // 
            // control_Panel
            // 
            control_Panel.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            control_Panel.Controls.Add(workflow_Label);
            control_Panel.Controls.Add(page5_Button);
            control_Panel.Controls.Add(page4_Button);
            control_Panel.Controls.Add(page3_Button);
            control_Panel.Controls.Add(page2_Button);
            control_Panel.Controls.Add(page1_Button);
            control_Panel.Controls.Add(controlHighlight_Panel);
            control_Panel.Controls.Add(home_Button);
            control_Panel.Controls.Add(settings_Button);
            control_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            control_Panel.ForeColor = System.Drawing.SystemColors.ControlText;
            control_Panel.Location = new System.Drawing.Point(3, 2);
            control_Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            control_Panel.Name = "control_Panel";
            control_Panel.Size = new System.Drawing.Size(148, 699);
            control_Panel.TabIndex = 30;
            // 
            // workflow_Label
            // 
            workflow_Label.AutoSize = true;
            workflow_Label.BackColor = System.Drawing.Color.Transparent;
            workflow_Label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            workflow_Label.Location = new System.Drawing.Point(12, 162);
            workflow_Label.Name = "workflow_Label";
            workflow_Label.Size = new System.Drawing.Size(79, 21);
            workflow_Label.TabIndex = 40;
            workflow_Label.Text = "Workflow";
            workflow_Label.Visible = false;
            // 
            // page5_Button
            // 
            page5_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            page5_Button.BackColor = System.Drawing.Color.Transparent;
            page5_Button.Enabled = false;
            page5_Button.FlatAppearance.BorderSize = 0;
            page5_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            page5_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            page5_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            page5_Button.Font = new System.Drawing.Font("Tahoma", 9.5F);
            page5_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            page5_Button.Location = new System.Drawing.Point(15, 400);
            page5_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            page5_Button.Name = "page5_Button";
            page5_Button.Size = new System.Drawing.Size(146, 45);
            page5_Button.TabIndex = 39;
            page5_Button.Text = "Page 5";
            page5_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            page5_Button.UseVisualStyleBackColor = false;
            page5_Button.Visible = false;
            page5_Button.Click += PageNButton_Click;
            // 
            // page4_Button
            // 
            page4_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            page4_Button.BackColor = System.Drawing.Color.Transparent;
            page4_Button.Enabled = false;
            page4_Button.FlatAppearance.BorderSize = 0;
            page4_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            page4_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            page4_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            page4_Button.Font = new System.Drawing.Font("Tahoma", 9.5F);
            page4_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            page4_Button.Location = new System.Drawing.Point(15, 350);
            page4_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            page4_Button.Name = "page4_Button";
            page4_Button.Size = new System.Drawing.Size(146, 45);
            page4_Button.TabIndex = 38;
            page4_Button.Text = "Page 4";
            page4_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            page4_Button.UseVisualStyleBackColor = false;
            page4_Button.Visible = false;
            page4_Button.Click += PageNButton_Click;
            // 
            // page3_Button
            // 
            page3_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            page3_Button.BackColor = System.Drawing.Color.Transparent;
            page3_Button.Enabled = false;
            page3_Button.FlatAppearance.BorderSize = 0;
            page3_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            page3_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            page3_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            page3_Button.Font = new System.Drawing.Font("Tahoma", 9.5F);
            page3_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            page3_Button.Location = new System.Drawing.Point(15, 300);
            page3_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            page3_Button.Name = "page3_Button";
            page3_Button.Size = new System.Drawing.Size(146, 45);
            page3_Button.TabIndex = 37;
            page3_Button.Text = "Page 3";
            page3_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            page3_Button.UseVisualStyleBackColor = false;
            page3_Button.Visible = false;
            page3_Button.Click += PageNButton_Click;
            // 
            // page2_Button
            // 
            page2_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            page2_Button.BackColor = System.Drawing.Color.Transparent;
            page2_Button.Enabled = false;
            page2_Button.FlatAppearance.BorderSize = 0;
            page2_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            page2_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            page2_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            page2_Button.Font = new System.Drawing.Font("Tahoma", 9.5F);
            page2_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            page2_Button.Location = new System.Drawing.Point(15, 250);
            page2_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            page2_Button.Name = "page2_Button";
            page2_Button.Size = new System.Drawing.Size(146, 45);
            page2_Button.TabIndex = 36;
            page2_Button.Text = "Page 2";
            page2_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            page2_Button.UseVisualStyleBackColor = false;
            page2_Button.Visible = false;
            page2_Button.Click += PageNButton_Click;
            // 
            // page1_Button
            // 
            page1_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            page1_Button.BackColor = System.Drawing.Color.Transparent;
            page1_Button.Enabled = false;
            page1_Button.FlatAppearance.BorderSize = 0;
            page1_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            page1_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            page1_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            page1_Button.Font = new System.Drawing.Font("Tahoma", 9.5F);
            page1_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            page1_Button.Location = new System.Drawing.Point(15, 200);
            page1_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            page1_Button.Name = "page1_Button";
            page1_Button.Size = new System.Drawing.Size(146, 45);
            page1_Button.TabIndex = 35;
            page1_Button.Text = "Page 1";
            page1_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            page1_Button.UseVisualStyleBackColor = false;
            page1_Button.Visible = false;
            page1_Button.Click += PageNButton_Click;
            // 
            // controlHighlight_Panel
            // 
            controlHighlight_Panel.BackColor = System.Drawing.Color.CornflowerBlue;
            controlHighlight_Panel.Location = new System.Drawing.Point(0, 96);
            controlHighlight_Panel.Name = "controlHighlight_Panel";
            controlHighlight_Panel.Size = new System.Drawing.Size(8, 35);
            controlHighlight_Panel.TabIndex = 33;
            controlHighlight_Panel.Tag = "IgnoreDarkMode";
            // 
            // home_Button
            // 
            home_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            home_Button.BackColor = System.Drawing.Color.Transparent;
            home_Button.FlatAppearance.BorderSize = 0;
            home_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            home_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            home_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            home_Button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            home_Button.Image = (System.Drawing.Image)resources.GetObject("home_Button.Image");
            home_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            home_Button.Location = new System.Drawing.Point(15, 92);
            home_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            home_Button.Name = "home_Button";
            home_Button.Size = new System.Drawing.Size(129, 45);
            home_Button.TabIndex = 32;
            home_Button.Text = "     Home";
            home_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            home_Button.UseVisualStyleBackColor = false;
            home_Button.Click += Home_Button_Click;
            // 
            // settings_Button
            // 
            settings_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            settings_Button.BackColor = System.Drawing.Color.Transparent;
            settings_Button.FlatAppearance.BorderSize = 0;
            settings_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            settings_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 30, 144, 255);
            settings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            settings_Button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            settings_Button.Image = Properties.Resources.gear;
            settings_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            settings_Button.Location = new System.Drawing.Point(15, 647);
            settings_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            settings_Button.Name = "settings_Button";
            settings_Button.Size = new System.Drawing.Size(129, 45);
            settings_Button.TabIndex = 31;
            settings_Button.Text = "     Settings";
            settings_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            settings_Button.UseVisualStyleBackColor = false;
            settings_Button.Click += Settings_Button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Tahoma", 9F);
            label4.Location = new System.Drawing.Point(667, 323);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(262, 99);
            label4.TabIndex = 35;
            label4.Text = "Merge two existing policies into one\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Font = new System.Drawing.Font("Tahoma", 9F);
            label2.Location = new System.Drawing.Point(135, 323);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(262, 36);
            label2.TabIndex = 33;
            label2.Text = "Create a new base or supplemental policy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Tahoma", 9F);
            label3.Location = new System.Drawing.Point(401, 323);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(262, 99);
            label3.TabIndex = 34;
            label3.Text = "Edit an existing policy on disk or convert event logs to a policy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Tahoma", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(3, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(311, 24);
            label1.TabIndex = 32;
            label1.Text = "Select a task below to get started";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            tableLayoutPanel1.Controls.Add(control_Panel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutControl, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1232, 703);
            tableLayoutPanel1.TabIndex = 36;
            // 
            // tableLayoutControl
            // 
            tableLayoutControl.ColumnCount = 1;
            tableLayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutControl.Controls.Add(label1, 0, 2);
            tableLayoutControl.Controls.Add(label_Welcome, 0, 1);
            tableLayoutControl.Controls.Add(tableLayoutPanel2, 0, 4);
            tableLayoutControl.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutControl.Location = new System.Drawing.Point(157, 3);
            tableLayoutControl.Name = "tableLayoutControl";
            tableLayoutControl.RowCount = 6;
            tableLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            tableLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            tableLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            tableLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.5F));
            tableLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            tableLayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.5F));
            tableLayoutControl.Size = new System.Drawing.Size(1072, 697);
            tableLayoutControl.TabIndex = 31;
            tableLayoutControl.Paint += tableLayoutPanel2_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button_Next, 1, 0);
            tableLayoutPanel2.Controls.Add(label_Info, 0, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 629);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(1066, 46);
            tableLayoutPanel2.TabIndex = 36;
            // 
            // button_Next
            // 
            button_Next.Dock = System.Windows.Forms.DockStyle.Right;
            button_Next.Location = new System.Drawing.Point(951, 2);
            button_Next.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button_Next.Name = "button_Next";
            button_Next.Size = new System.Drawing.Size(112, 42);
            button_Next.TabIndex = 37;
            button_Next.Text = "Next";
            button_Next.UseVisualStyleBackColor = true;
            button_Next.Visible = false;
            button_Next.Click += Button_Next_Click;
            // 
            // label_Info
            // 
            label_Info.AutoSize = true;
            label_Info.BackColor = System.Drawing.Color.Transparent;
            label_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            label_Info.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_Info.ForeColor = System.Drawing.Color.DodgerBlue;
            label_Info.Location = new System.Drawing.Point(3, 0);
            label_Info.Name = "label_Info";
            label_Info.Size = new System.Drawing.Size(527, 46);
            label_Info.TabIndex = 36;
            label_Info.Tag = "IgnoreDarkMode";
            label_Info.Text = "Info Text";
            label_Info.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            tableLayoutPanel3.Controls.Add(button_Merge, 3, 1);
            tableLayoutPanel3.Controls.Add(label4, 3, 2);
            tableLayoutPanel3.Controls.Add(button_Edit, 2, 1);
            tableLayoutPanel3.Controls.Add(label3, 2, 2);
            tableLayoutPanel3.Controls.Add(button_New, 1, 1);
            tableLayoutPanel3.Controls.Add(label2, 1, 2);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(3, 124);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            tableLayoutPanel3.Size = new System.Drawing.Size(1066, 499);
            tableLayoutPanel3.TabIndex = 37;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1232, 703);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            HelpButton = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "MainWindow";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "App Control Policy Wizard";
            FormClosing += FormClosing_Event;
            Load += MainWindow_Load;
            control_Panel.ResumeLayout(false);
            control_Panel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutControl.ResumeLayout(false);
            tableLayoutControl.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label label_Welcome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private EditWorkflow editWorkflow1;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Merge;
        private System.Windows.Forms.Panel control_Panel;
        private System.Windows.Forms.Button settings_Button;
        private System.Windows.Forms.Button home_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel controlHighlight_Panel;
        private System.Windows.Forms.Button page3_Button;
        private System.Windows.Forms.Button page2_Button;
        private System.Windows.Forms.Button page4_Button;
        public System.Windows.Forms.Button page1_Button;
        private System.Windows.Forms.Button page5_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label workflow_Label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

