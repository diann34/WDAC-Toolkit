// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// jogeurte 11/19

namespace WDAC_Wizard
{
    partial class SettingsPage
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
            appVersion_Label = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            terms_Label = new System.Windows.Forms.Label();
            privacy_Label = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            useDefaultStrings_CheckBox = new System.Windows.Forms.PictureBox();
            useDarkMode_Checkbox = new System.Windows.Forms.PictureBox();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label_DriverBlock = new System.Windows.Forms.Label();
            label_UsermodeBlock = new System.Windows.Forms.Label();
            useUsermodeBlockRules_CheckBox = new System.Windows.Forms.PictureBox();
            useDriverBlockRules_CheckBox = new System.Windows.Forms.PictureBox();
            convertPolicyToBinary_CheckBox = new System.Windows.Forms.PictureBox();
            label7 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            useEnvVars_CheckBox = new System.Windows.Forms.PictureBox();
            label8 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            Update_Label = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            resetButton = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)useDefaultStrings_CheckBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)useDarkMode_Checkbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)useUsermodeBlockRules_CheckBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)useDriverBlockRules_CheckBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)convertPolicyToBinary_CheckBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)useEnvVars_CheckBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // appVersion_Label
            // 
            appVersion_Label.AutoSize = true;
            appVersion_Label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            appVersion_Label.ForeColor = System.Drawing.SystemColors.ControlDark;
            appVersion_Label.Location = new System.Drawing.Point(218, 514);
            appVersion_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            appVersion_Label.Name = "appVersion_Label";
            appVersion_Label.Size = new System.Drawing.Size(168, 21);
            appVersion_Label.TabIndex = 2;
            appVersion_Label.Text = "App Version 1.903.22";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            label3.Location = new System.Drawing.Point(218, 557);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(243, 42);
            label3.TabIndex = 3;
            label3.Text = "2019 Microsoft Corporation ©\r\nJordan.Geurten@microsoft.com";
            // 
            // terms_Label
            // 
            terms_Label.AutoSize = true;
            terms_Label.BackColor = System.Drawing.Color.Transparent;
            terms_Label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            terms_Label.ForeColor = System.Drawing.Color.FromArgb(16, 110, 190);
            terms_Label.Image = Properties.Resources.external_link_symbol_highlight;
            terms_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            terms_Label.Location = new System.Drawing.Point(218, 620);
            terms_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            terms_Label.Name = "terms_Label";
            terms_Label.Size = new System.Drawing.Size(129, 21);
            terms_Label.TabIndex = 4;
            terms_Label.Tag = "IgnoreDarkMode";
            terms_Label.Text = "Terms of Use    ";
            terms_Label.Click += Terms_Label_Click;
            // 
            // privacy_Label
            // 
            privacy_Label.AutoSize = true;
            privacy_Label.BackColor = System.Drawing.Color.Transparent;
            privacy_Label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            privacy_Label.ForeColor = System.Drawing.Color.FromArgb(16, 110, 190);
            privacy_Label.Image = Properties.Resources.external_link_symbol_highlight;
            privacy_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            privacy_Label.Location = new System.Drawing.Point(218, 649);
            privacy_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            privacy_Label.Name = "privacy_Label";
            privacy_Label.Size = new System.Drawing.Size(164, 21);
            privacy_Label.TabIndex = 5;
            privacy_Label.Tag = "IgnoreDarkMode";
            privacy_Label.Text = "Privacy Statement    ";
            privacy_Label.Click += Privacy_Label_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Tahoma", 11F);
            label4.Location = new System.Drawing.Point(218, 365);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(863, 49);
            label4.TabIndex = 6;
            label4.Text = "Defaults";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(218, 414);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(285, 21);
            label5.TabIndex = 7;
            label5.Text = "Autofill text fields with default values";
            // 
            // useDefaultStrings_CheckBox
            // 
            useDefaultStrings_CheckBox.BackgroundImage = Properties.Resources.check_box_checked;
            useDefaultStrings_CheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            useDefaultStrings_CheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            useDefaultStrings_CheckBox.Location = new System.Drawing.Point(189, 368);
            useDefaultStrings_CheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            useDefaultStrings_CheckBox.Name = "useDefaultStrings_CheckBox";
            useDefaultStrings_CheckBox.Size = new System.Drawing.Size(25, 43);
            useDefaultStrings_CheckBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            useDefaultStrings_CheckBox.TabIndex = 8;
            useDefaultStrings_CheckBox.TabStop = false;
            useDefaultStrings_CheckBox.Tag = "Checked";
            useDefaultStrings_CheckBox.Click += DefaultString_CheckBox_Click;
            useDefaultStrings_CheckBox.MouseLeave += SettingCheckBox_Leave;
            useDefaultStrings_CheckBox.MouseHover += SettingCheckBox_Hover;
            // 
            // useDarkMode_Checkbox
            // 
            useDarkMode_Checkbox.BackgroundImage = Properties.Resources.check_box_unchecked;
            useDarkMode_Checkbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            useDarkMode_Checkbox.Dock = System.Windows.Forms.DockStyle.Right;
            useDarkMode_Checkbox.Location = new System.Drawing.Point(189, 325);
            useDarkMode_Checkbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            useDarkMode_Checkbox.Name = "useDarkMode_Checkbox";
            useDarkMode_Checkbox.Size = new System.Drawing.Size(25, 37);
            useDarkMode_Checkbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            useDarkMode_Checkbox.TabIndex = 28;
            useDarkMode_Checkbox.TabStop = false;
            useDarkMode_Checkbox.Tag = "Checked";
            useDarkMode_Checkbox.Click += DarkMode_CheckBox_Click;
            useDarkMode_Checkbox.MouseLeave += SettingCheckBox_Leave;
            useDarkMode_Checkbox.MouseHover += SettingCheckBox_Hover;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = System.Windows.Forms.DockStyle.Fill;
            label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.Black;
            label10.Location = new System.Drawing.Point(218, 322);
            label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(863, 43);
            label10.TabIndex = 27;
            label10.Text = "Use the Wizard in Dark Mode";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = System.Windows.Forms.DockStyle.Fill;
            label11.Font = new System.Drawing.Font("Tahoma", 11F);
            label11.Location = new System.Drawing.Point(218, 269);
            label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(863, 53);
            label11.TabIndex = 26;
            label11.Text = "Interface";
            // 
            // label_DriverBlock
            // 
            label_DriverBlock.AutoSize = true;
            label_DriverBlock.BackColor = System.Drawing.Color.Transparent;
            label_DriverBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            label_DriverBlock.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_DriverBlock.ForeColor = System.Drawing.Color.FromArgb(16, 110, 190);
            label_DriverBlock.Image = Properties.Resources.external_link_symbol_highlight;
            label_DriverBlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label_DriverBlock.Location = new System.Drawing.Point(218, 223);
            label_DriverBlock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label_DriverBlock.Name = "label_DriverBlock";
            label_DriverBlock.Size = new System.Drawing.Size(863, 46);
            label_DriverBlock.TabIndex = 25;
            label_DriverBlock.Tag = "IgnoreDarkMode";
            label_DriverBlock.Text = "Create policies with Microsoft's Recommended Driver Block Rules    ";
            label_DriverBlock.Click += LabelDriverBlock_Click;
            // 
            // label_UsermodeBlock
            // 
            label_UsermodeBlock.AutoSize = true;
            label_UsermodeBlock.BackColor = System.Drawing.Color.Transparent;
            label_UsermodeBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            label_UsermodeBlock.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label_UsermodeBlock.ForeColor = System.Drawing.Color.FromArgb(16, 110, 190);
            label_UsermodeBlock.Image = Properties.Resources.external_link_symbol_highlight;
            label_UsermodeBlock.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            label_UsermodeBlock.Location = new System.Drawing.Point(218, 177);
            label_UsermodeBlock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label_UsermodeBlock.Name = "label_UsermodeBlock";
            label_UsermodeBlock.Size = new System.Drawing.Size(863, 46);
            label_UsermodeBlock.TabIndex = 24;
            label_UsermodeBlock.Tag = "IgnoreDarkMode";
            label_UsermodeBlock.Text = "Create policies with Microsoft's Recommended Block Rules    ";
            label_UsermodeBlock.Click += Label_UsermodeBlock_Click;
            // 
            // useUsermodeBlockRules_CheckBox
            // 
            useUsermodeBlockRules_CheckBox.BackgroundImage = Properties.Resources.check_box_unchecked;
            useUsermodeBlockRules_CheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            useUsermodeBlockRules_CheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            useUsermodeBlockRules_CheckBox.Location = new System.Drawing.Point(189, 180);
            useUsermodeBlockRules_CheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            useUsermodeBlockRules_CheckBox.Name = "useUsermodeBlockRules_CheckBox";
            useUsermodeBlockRules_CheckBox.Size = new System.Drawing.Size(25, 40);
            useUsermodeBlockRules_CheckBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            useUsermodeBlockRules_CheckBox.TabIndex = 23;
            useUsermodeBlockRules_CheckBox.TabStop = false;
            useUsermodeBlockRules_CheckBox.Tag = "Unchecked";
            useUsermodeBlockRules_CheckBox.Click += UsermodeRecList_checkBox_Click;
            useUsermodeBlockRules_CheckBox.MouseLeave += SettingCheckBox_Leave;
            useUsermodeBlockRules_CheckBox.MouseHover += SettingCheckBox_Hover;
            // 
            // useDriverBlockRules_CheckBox
            // 
            useDriverBlockRules_CheckBox.BackColor = System.Drawing.Color.White;
            useDriverBlockRules_CheckBox.BackgroundImage = Properties.Resources.check_box_unchecked;
            useDriverBlockRules_CheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            useDriverBlockRules_CheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            useDriverBlockRules_CheckBox.Location = new System.Drawing.Point(189, 226);
            useDriverBlockRules_CheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            useDriverBlockRules_CheckBox.Name = "useDriverBlockRules_CheckBox";
            useDriverBlockRules_CheckBox.Size = new System.Drawing.Size(25, 40);
            useDriverBlockRules_CheckBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            useDriverBlockRules_CheckBox.TabIndex = 21;
            useDriverBlockRules_CheckBox.TabStop = false;
            useDriverBlockRules_CheckBox.Tag = "Unchecked";
            useDriverBlockRules_CheckBox.Click += KernelmodeRecList_checkBox_Click;
            useDriverBlockRules_CheckBox.MouseLeave += SettingCheckBox_Leave;
            useDriverBlockRules_CheckBox.MouseHover += SettingCheckBox_Hover;
            // 
            // convertPolicyToBinary_CheckBox
            // 
            convertPolicyToBinary_CheckBox.BackgroundImage = Properties.Resources.check_box_unchecked;
            convertPolicyToBinary_CheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            convertPolicyToBinary_CheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            convertPolicyToBinary_CheckBox.Location = new System.Drawing.Point(189, 134);
            convertPolicyToBinary_CheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            convertPolicyToBinary_CheckBox.Name = "convertPolicyToBinary_CheckBox";
            convertPolicyToBinary_CheckBox.Size = new System.Drawing.Size(25, 40);
            convertPolicyToBinary_CheckBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            convertPolicyToBinary_CheckBox.TabIndex = 19;
            convertPolicyToBinary_CheckBox.TabStop = false;
            convertPolicyToBinary_CheckBox.Tag = "Unchecked";
            convertPolicyToBinary_CheckBox.Click += ConvertPolicy_CheckBox_Click;
            convertPolicyToBinary_CheckBox.MouseLeave += SettingCheckBox_Leave;
            convertPolicyToBinary_CheckBox.MouseHover += SettingCheckBox_Hover;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(218, 131);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(863, 46);
            label7.TabIndex = 18;
            label7.Text = "Convert policy to binary after xml creation";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = System.Windows.Forms.DockStyle.Fill;
            label9.Font = new System.Drawing.Font("Tahoma", 11F);
            label9.Location = new System.Drawing.Point(218, 29);
            label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(863, 56);
            label9.TabIndex = 15;
            label9.Text = "Policy";
            // 
            // useEnvVars_CheckBox
            // 
            useEnvVars_CheckBox.BackgroundImage = Properties.Resources.check_box_checked;
            useEnvVars_CheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            useEnvVars_CheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            useEnvVars_CheckBox.Location = new System.Drawing.Point(189, 88);
            useEnvVars_CheckBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            useEnvVars_CheckBox.Name = "useEnvVars_CheckBox";
            useEnvVars_CheckBox.Size = new System.Drawing.Size(25, 40);
            useEnvVars_CheckBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            useEnvVars_CheckBox.TabIndex = 14;
            useEnvVars_CheckBox.TabStop = false;
            useEnvVars_CheckBox.Tag = "Checked";
            useEnvVars_CheckBox.Click += EnvVar_CheckBox_Click;
            useEnvVars_CheckBox.MouseLeave += SettingCheckBox_Leave;
            useEnvVars_CheckBox.MouseHover += SettingCheckBox_Hover;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(218, 85);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(863, 46);
            label8.TabIndex = 13;
            label8.Text = "Use environment variables in filepath rules where possible";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(218, 0);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(178, 29);
            label1.TabIndex = 13;
            label1.Text = "Wizard Settings";
            // 
            // Update_Label
            // 
            Update_Label.AutoSize = true;
            Update_Label.Font = new System.Drawing.Font("Tahoma", 10F);
            Update_Label.ForeColor = System.Drawing.Color.Black;
            Update_Label.Location = new System.Drawing.Point(218, 681);
            Update_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            Update_Label.Name = "Update_Label";
            Update_Label.Size = new System.Drawing.Size(135, 21);
            Update_Label.TabIndex = 15;
            Update_Label.Text = "Saving Setting ...";
            Update_Label.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(resetButton, 3, 15);
            tableLayoutPanel1.Controls.Add(useDarkMode_Checkbox, 1, 7);
            tableLayoutPanel1.Controls.Add(Update_Label, 2, 15);
            tableLayoutPanel1.Controls.Add(useEnvVars_CheckBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label5, 2, 9);
            tableLayoutPanel1.Controls.Add(label10, 2, 7);
            tableLayoutPanel1.Controls.Add(label8, 2, 2);
            tableLayoutPanel1.Controls.Add(label11, 2, 6);
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Controls.Add(useDriverBlockRules_CheckBox, 1, 5);
            tableLayoutPanel1.Controls.Add(label_DriverBlock, 2, 5);
            tableLayoutPanel1.Controls.Add(label9, 2, 1);
            tableLayoutPanel1.Controls.Add(label_UsermodeBlock, 2, 4);
            tableLayoutPanel1.Controls.Add(useUsermodeBlockRules_CheckBox, 1, 4);
            tableLayoutPanel1.Controls.Add(label7, 2, 3);
            tableLayoutPanel1.Controls.Add(convertPolicyToBinary_CheckBox, 1, 3);
            tableLayoutPanel1.Controls.Add(privacy_Label, 2, 14);
            tableLayoutPanel1.Controls.Add(terms_Label, 2, 13);
            tableLayoutPanel1.Controls.Add(label3, 2, 12);
            tableLayoutPanel1.Controls.Add(appVersion_Label, 2, 11);
            tableLayoutPanel1.Controls.Add(label4, 2, 8);
            tableLayoutPanel1.Controls.Add(useDefaultStrings_CheckBox, 1, 8);
            tableLayoutPanel1.Controls.Add(label2, 2, 10);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 16;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5899782F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.3857975F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.3867321F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.3867321F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.3867321F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.9743528F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.715041F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.0706291F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1040106F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1446, 729);
            tableLayoutPanel1.TabIndex = 16;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // resetButton
            // 
            resetButton.Location = new System.Drawing.Point(1086, 684);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(94, 29);
            resetButton.TabIndex = 17;
            resetButton.Text = "button1";
            resetButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Tahoma", 11F);
            label2.Location = new System.Drawing.Point(218, 472);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(863, 42);
            label2.TabIndex = 29;
            label2.Text = "About";
            // 
            // SettingsPage
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            AutoSize = true;
            BackColor = System.Drawing.Color.White;
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Name = "SettingsPage";
            Size = new System.Drawing.Size(1446, 729);
            Load += SettingsPage_Load;
            ((System.ComponentModel.ISupportInitialize)useDefaultStrings_CheckBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)useDarkMode_Checkbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)useUsermodeBlockRules_CheckBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)useDriverBlockRules_CheckBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)convertPolicyToBinary_CheckBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)useEnvVars_CheckBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label appVersion_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label terms_Label;
        private System.Windows.Forms.Label privacy_Label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox useDefaultStrings_CheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox useEnvVars_CheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Update_Label;
        private System.Windows.Forms.PictureBox convertPolicyToBinary_CheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox useUsermodeBlockRules_CheckBox;
        private System.Windows.Forms.PictureBox useDriverBlockRules_CheckBox;
        private System.Windows.Forms.Label label_DriverBlock;
        private System.Windows.Forms.Label label_UsermodeBlock;
        private System.Windows.Forms.PictureBox useDarkMode_Checkbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetButton;
    }
}
