namespace X1EG5_Fn_Key_Remapper {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxKeyMap = new System.Windows.Forms.GroupBox();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.labelRegistryBox = new System.Windows.Forms.Label();
            this.labelRegistry = new System.Windows.Forms.Label();
            this.labelNotesBox = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.textBoxParam = new System.Windows.Forms.TextBox();
            this.labelParam = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.radioButtonF1 = new System.Windows.Forms.RadioButton();
            this.radioButtonF2 = new System.Windows.Forms.RadioButton();
            this.radioButtonF3 = new System.Windows.Forms.RadioButton();
            this.radioButtonF4 = new System.Windows.Forms.RadioButton();
            this.radioButtonF5 = new System.Windows.Forms.RadioButton();
            this.radioButtonF6 = new System.Windows.Forms.RadioButton();
            this.radioButtonF7 = new System.Windows.Forms.RadioButton();
            this.radioButtonF8 = new System.Windows.Forms.RadioButton();
            this.radioButtonF9 = new System.Windows.Forms.RadioButton();
            this.radioButtonF10 = new System.Windows.Forms.RadioButton();
            this.radioButtonF11 = new System.Windows.Forms.RadioButton();
            this.radioButtonF12 = new System.Windows.Forms.RadioButton();
            this.radioButtonTab = new System.Windows.Forms.RadioButton();
            this.groupBoxKeyMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKeyMap
            // 
            this.groupBoxKeyMap.Controls.Add(this.buttonDefault);
            this.groupBoxKeyMap.Controls.Add(this.labelRegistryBox);
            this.groupBoxKeyMap.Controls.Add(this.labelRegistry);
            this.groupBoxKeyMap.Controls.Add(this.labelNotesBox);
            this.groupBoxKeyMap.Controls.Add(this.labelNotes);
            this.groupBoxKeyMap.Controls.Add(this.textBoxParam);
            this.groupBoxKeyMap.Controls.Add(this.labelParam);
            this.groupBoxKeyMap.Controls.Add(this.labelFile);
            this.groupBoxKeyMap.Controls.Add(this.textBoxFile);
            this.groupBoxKeyMap.Controls.Add(this.buttonApply);
            this.groupBoxKeyMap.Location = new System.Drawing.Point(12, 53);
            this.groupBoxKeyMap.Name = "groupBoxKeyMap";
            this.groupBoxKeyMap.Size = new System.Drawing.Size(1068, 181);
            this.groupBoxKeyMap.TabIndex = 17;
            this.groupBoxKeyMap.TabStop = false;
            this.groupBoxKeyMap.Text = "Key Map";
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(832, 138);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(112, 34);
            this.buttonDefault.TabIndex = 15;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // labelRegistryBox
            // 
            this.labelRegistryBox.AutoSize = true;
            this.labelRegistryBox.Location = new System.Drawing.Point(108, 147);
            this.labelRegistryBox.Name = "labelRegistryBox";
            this.labelRegistryBox.Size = new System.Drawing.Size(470, 25);
            this.labelRegistryBox.TabIndex = 7;
            this.labelRegistryBox.Text = "HKLM\\SOFTWARE\\Lenovo\\ShortcutKey\\AppLaunch\\Ex_98";
            this.labelRegistryBox.Click += new System.EventHandler(this.labelRegistryBox_Click);
            // 
            // labelRegistry
            // 
            this.labelRegistry.AutoSize = true;
            this.labelRegistry.Location = new System.Drawing.Point(6, 147);
            this.labelRegistry.Name = "labelRegistry";
            this.labelRegistry.Size = new System.Drawing.Size(79, 25);
            this.labelRegistry.TabIndex = 6;
            this.labelRegistry.Text = "Registry:";
            // 
            // labelNotesBox
            // 
            this.labelNotesBox.AutoSize = true;
            this.labelNotesBox.Location = new System.Drawing.Point(108, 110);
            this.labelNotesBox.Name = "labelNotesBox";
            this.labelNotesBox.Size = new System.Drawing.Size(363, 25);
            this.labelNotesBox.TabIndex = 5;
            this.labelNotesBox.Text = "Decrease Brightness (Cannot be deactivated)";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(6, 110);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(96, 25);
            this.labelNotes.TabIndex = 4;
            this.labelNotes.Text = "Key Notes:";
            // 
            // textBoxParam
            // 
            this.textBoxParam.Location = new System.Drawing.Point(115, 70);
            this.textBoxParam.Name = "textBoxParam";
            this.textBoxParam.Size = new System.Drawing.Size(947, 31);
            this.textBoxParam.TabIndex = 14;
            this.textBoxParam.TextChanged += new System.EventHandler(this.textBoxParam_TextChanged);
            // 
            // labelParam
            // 
            this.labelParam.AutoSize = true;
            this.labelParam.Location = new System.Drawing.Point(6, 73);
            this.labelParam.Name = "labelParam";
            this.labelParam.Size = new System.Drawing.Size(103, 25);
            this.labelParam.TabIndex = 1;
            this.labelParam.Text = "Parameters:";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(6, 36);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(42, 25);
            this.labelFile.TabIndex = 2;
            this.labelFile.Text = "File:";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(115, 33);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(947, 31);
            this.textBoxFile.TabIndex = 13;
            this.textBoxFile.TextChanged += new System.EventHandler(this.textBoxFile_TextChanged);
            // 
            // buttonApply
            // 
            this.buttonApply.Enabled = false;
            this.buttonApply.Location = new System.Drawing.Point(950, 138);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(112, 34);
            this.buttonApply.TabIndex = 16;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // radioButtonF1
            // 
            this.radioButtonF1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonF1.Enabled = false;
            this.radioButtonF1.Location = new System.Drawing.Point(162, 12);
            this.radioButtonF1.Name = "radioButtonF1";
            this.radioButtonF1.Size = new System.Drawing.Size(60, 35);
            this.radioButtonF1.TabIndex = 1;
            this.radioButtonF1.Text = "F1";
            this.radioButtonF1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonF1.UseVisualStyleBackColor = true;
            // 
            // radioButtonF2
            // 
            this.radioButtonF2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonF2.Enabled = false;
            this.radioButtonF2.Location = new System.Drawing.Point(228, 12);
            this.radioButtonF2.Name = "radioButtonF2";
            this.radioButtonF2.Size = new System.Drawing.Size(60, 35);
            this.radioButtonF2.TabIndex = 2;
            this.radioButtonF2.Text = "F2";
            this.radioButtonF2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonF2.UseVisualStyleBackColor = true;
            // 
            // radioButtonF3
            // 
            this.radioButtonF3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonF3.Enabled = false;
            this.radioButtonF3.Location = new System.Drawing.Point(294, 12);
            this.radioButtonF3.Name = "radioButtonF3";
            this.radioButtonF3.Size = new System.Drawing.Size(60, 35);
            this.radioButtonF3.TabIndex = 3;
            this.radioButtonF3.Text = "F3";
            this.radioButtonF3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonF3.UseVisualStyleBackColor = true;
            // 
            // radioButtonF4
            // 
            this.radioButtonF4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonF4.Location = new System.Drawing.Point(360, 12);
            this.radioButtonF4.Name = "radioButtonF4";
            this.radioButtonF4.Size = new System.Drawing.Size(60, 35);
            this.radioButtonF4.TabIndex = 4;
            this.radioButtonF4.Text = "F4";
            this.radioButtonF4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonF4.UseVisualStyleBackColor = true;
            this.radioButtonF4.CheckedChanged += new System.EventHandler(this.radioButtonF4_CheckedChanged);
            // 
            // radioButtonF5
            // 
            this.radioButtonF5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonF5.Location = new System.Drawing.Point(492, 12);
            this.radioButtonF5.Name = "radioButtonF5";
            this.radioButtonF5.Size = new System.Drawing.Size(60, 35);
            this.radioButtonF5.TabIndex = 5;
            this.radioButtonF5.Text = "F5";
            this.radioButtonF5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonF5.UseVisualStyleBackColor = true;
            this.radioButtonF5.CheckedChanged += new System.EventHandler(this.radioButtonF5_CheckedChanged);
            // 
            // radioButtonF6
            // 
            this.radioButtonF6.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonF6.Location = new System.Drawing.Point(558, 12);
            this.radioButtonF6.Name = "radioButtonF6";
            this.radioButtonF6.Size = new System.Drawing.Size(60, 35);
            this.radioButtonF6.TabIndex = 6;
            this.radioButtonF6.Text = "F6";
            this.radioButtonF6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonF6.UseVisualStyleBackColor = true;
            this.radioButtonF6.CheckedChanged += new System.EventHandler(this.radioButtonF6_CheckedChanged);
            // 
            // radioButtonF7
            // 
            this.radioButtonF7.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonF7.Location = new System.Drawing.Point(624, 12);
            this.radioButtonF7.Name = "radioButtonF7";
            this.radioButtonF7.Size = new System.Drawing.Size(60, 35);
            this.radioButtonF7.TabIndex = 7;
            this.radioButtonF7.Text = "F7";
            this.radioButtonF7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonF7.UseVisualStyleBackColor = true;
            this.radioButtonF7.CheckedChanged += new System.EventHandler(this.radioButtonF7_CheckedChanged);
            // 
            // radioButtonF8
            // 
            this.radioButtonF8.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonF8.Location = new System.Drawing.Point(690, 12);
            this.radioButtonF8.Name = "radioButtonF8";
            this.radioButtonF8.Size = new System.Drawing.Size(60, 35);
            this.radioButtonF8.TabIndex = 8;
            this.radioButtonF8.Text = "F8";
            this.radioButtonF8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonF8.UseVisualStyleBackColor = true;
            this.radioButtonF8.CheckedChanged += new System.EventHandler(this.radioButtonF8_CheckedChanged);
            // 
            // radioButtonF9
            // 
            this.radioButtonF9.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonF9.Location = new System.Drawing.Point(822, 12);
            this.radioButtonF9.Name = "radioButtonF9";
            this.radioButtonF9.Size = new System.Drawing.Size(60, 35);
            this.radioButtonF9.TabIndex = 9;
            this.radioButtonF9.Text = "F9";
            this.radioButtonF9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonF9.UseVisualStyleBackColor = true;
            this.radioButtonF9.CheckedChanged += new System.EventHandler(this.radioButtonF9_CheckedChanged);
            // 
            // radioButtonF10
            // 
            this.radioButtonF10.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonF10.Location = new System.Drawing.Point(888, 12);
            this.radioButtonF10.Name = "radioButtonF10";
            this.radioButtonF10.Size = new System.Drawing.Size(60, 35);
            this.radioButtonF10.TabIndex = 10;
            this.radioButtonF10.Text = "F10";
            this.radioButtonF10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonF10.UseVisualStyleBackColor = true;
            this.radioButtonF10.CheckedChanged += new System.EventHandler(this.radioButtonF10_CheckedChanged);
            // 
            // radioButtonF11
            // 
            this.radioButtonF11.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonF11.Location = new System.Drawing.Point(954, 12);
            this.radioButtonF11.Name = "radioButtonF11";
            this.radioButtonF11.Size = new System.Drawing.Size(60, 35);
            this.radioButtonF11.TabIndex = 11;
            this.radioButtonF11.Text = "F11";
            this.radioButtonF11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonF11.UseVisualStyleBackColor = true;
            this.radioButtonF11.CheckedChanged += new System.EventHandler(this.radioButtonF11_CheckedChanged);
            // 
            // radioButtonF12
            // 
            this.radioButtonF12.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonF12.Checked = true;
            this.radioButtonF12.Location = new System.Drawing.Point(1020, 12);
            this.radioButtonF12.Name = "radioButtonF12";
            this.radioButtonF12.Size = new System.Drawing.Size(60, 35);
            this.radioButtonF12.TabIndex = 12;
            this.radioButtonF12.TabStop = true;
            this.radioButtonF12.Text = "F12";
            this.radioButtonF12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonF12.UseVisualStyleBackColor = true;
            this.radioButtonF12.CheckedChanged += new System.EventHandler(this.radioButtonF12_CheckedChanged);
            // 
            // radioButtonTab
            // 
            this.radioButtonTab.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonTab.Location = new System.Drawing.Point(12, 12);
            this.radioButtonTab.Name = "radioButtonTab";
            this.radioButtonTab.Size = new System.Drawing.Size(78, 35);
            this.radioButtonTab.TabIndex = 0;
            this.radioButtonTab.Text = "Tab";
            this.radioButtonTab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonTab.UseVisualStyleBackColor = true;
            this.radioButtonTab.CheckedChanged += new System.EventHandler(this.radioButtonTab_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1090, 244);
            this.Controls.Add(this.radioButtonTab);
            this.Controls.Add(this.radioButtonF12);
            this.Controls.Add(this.radioButtonF11);
            this.Controls.Add(this.radioButtonF10);
            this.Controls.Add(this.radioButtonF9);
            this.Controls.Add(this.radioButtonF8);
            this.Controls.Add(this.radioButtonF7);
            this.Controls.Add(this.radioButtonF6);
            this.Controls.Add(this.radioButtonF5);
            this.Controls.Add(this.radioButtonF4);
            this.Controls.Add(this.radioButtonF3);
            this.Controls.Add(this.radioButtonF2);
            this.Controls.Add(this.radioButtonF1);
            this.Controls.Add(this.groupBoxKeyMap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1112, 300);
            this.MinimumSize = new System.Drawing.Size(1112, 300);
            this.Name = "Form1";
            this.Text = "Fn Remapper (X1 Extreme Gen 5)";
            this.groupBoxKeyMap.ResumeLayout(false);
            this.groupBoxKeyMap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxKeyMap;
        private TextBox textBoxParam;
        private Label labelParam;
        private Label labelFile;
        private TextBox textBoxFile;
        private Button buttonApply;
        private RadioButton radioButtonF1;
        private RadioButton radioButtonF2;
        private RadioButton radioButtonF3;
        private RadioButton radioButtonF4;
        private RadioButton radioButtonF5;
        private RadioButton radioButtonF6;
        private RadioButton radioButtonF7;
        private RadioButton radioButtonF8;
        private RadioButton radioButtonF9;
        private RadioButton radioButtonF10;
        private RadioButton radioButtonF11;
        private RadioButton radioButtonF12;
        private Label labelNotes;
        private Label labelRegistryBox;
        private Label labelRegistry;
        private Label labelNotesBox;
        private Button buttonDefault;
        private RadioButton radioButtonTab;
    }
}