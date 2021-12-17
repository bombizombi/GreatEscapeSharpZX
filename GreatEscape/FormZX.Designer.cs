namespace GreatEscape
{
    partial class FormZX
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
            this.components = new System.ComponentModel.Container();
            this.pictureScreen = new System.Windows.Forms.PictureBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonStep = new System.Windows.Forms.Button();
            this.buttonLoopSteps = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPC = new System.Windows.Forms.TextBox();
            this.checkBoxKey1 = new System.Windows.Forms.CheckBox();
            this.buttonDebugAtribs = new System.Windows.Forms.Button();
            this.buttonLoop10k = new System.Windows.Forms.Button();
            this.checkBoxKey2 = new System.Windows.Forms.CheckBox();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBoxY = new System.Windows.Forms.CheckBox();
            this.buttonLoopSmall = new System.Windows.Forms.Button();
            this.textBoxRez = new System.Windows.Forms.TextBox();
            this.checkBoxKeySpace = new System.Windows.Forms.CheckBox();
            this.checkBoxBreak = new System.Windows.Forms.CheckBox();
            this.buttonLoop10 = new System.Windows.Forms.Button();
            this.buttonLoop100 = new System.Windows.Forms.Button();
            this.buttonLoop1000 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonLogInstructions = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxTimerEnabled = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureScreen
            // 
            this.pictureScreen.BackColor = System.Drawing.SystemColors.Window;
            this.pictureScreen.Location = new System.Drawing.Point(0, 51);
            this.pictureScreen.Name = "pictureScreen";
            this.pictureScreen.Size = new System.Drawing.Size(1019, 778);
            this.pictureScreen.TabIndex = 0;
            this.pictureScreen.TabStop = false;
            this.pictureScreen.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureScreen_Paint);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(5, 12);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 23);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonStep
            // 
            this.buttonStep.Location = new System.Drawing.Point(83, 11);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(75, 23);
            this.buttonStep.TabIndex = 2;
            this.buttonStep.Text = "Step";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // buttonLoopSteps
            // 
            this.buttonLoopSteps.Location = new System.Drawing.Point(163, 10);
            this.buttonLoopSteps.Name = "buttonLoopSteps";
            this.buttonLoopSteps.Size = new System.Drawing.Size(75, 23);
            this.buttonLoopSteps.TabIndex = 3;
            this.buttonLoopSteps.Text = "loop steps";
            this.buttonLoopSteps.UseVisualStyleBackColor = true;
            this.buttonLoopSteps.Click += new System.EventHandler(this.buttonLoopSteps_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "PC:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPC
            // 
            this.textBoxPC.Location = new System.Drawing.Point(276, 10);
            this.textBoxPC.Name = "textBoxPC";
            this.textBoxPC.Size = new System.Drawing.Size(58, 23);
            this.textBoxPC.TabIndex = 5;
            this.textBoxPC.TextChanged += new System.EventHandler(this.textBoxPC_TextChanged);
            // 
            // checkBoxKey1
            // 
            this.checkBoxKey1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxKey1.Location = new System.Drawing.Point(511, 7);
            this.checkBoxKey1.Name = "checkBoxKey1";
            this.checkBoxKey1.Size = new System.Drawing.Size(27, 41);
            this.checkBoxKey1.TabIndex = 7;
            this.checkBoxKey1.Text = "1";
            this.checkBoxKey1.UseVisualStyleBackColor = true;
            this.checkBoxKey1.CheckedChanged += new System.EventHandler(this.checkBoxKey1_CheckedChanged);
            // 
            // buttonDebugAtribs
            // 
            this.buttonDebugAtribs.Location = new System.Drawing.Point(944, 22);
            this.buttonDebugAtribs.Name = "buttonDebugAtribs";
            this.buttonDebugAtribs.Size = new System.Drawing.Size(75, 23);
            this.buttonDebugAtribs.TabIndex = 8;
            this.buttonDebugAtribs.Text = "dbg attribs";
            this.buttonDebugAtribs.UseVisualStyleBackColor = true;
            this.buttonDebugAtribs.Click += new System.EventHandler(this.buttonDebugAtribs_Click);
            // 
            // buttonLoop10k
            // 
            this.buttonLoop10k.Location = new System.Drawing.Point(765, 4);
            this.buttonLoop10k.Name = "buttonLoop10k";
            this.buttonLoop10k.Size = new System.Drawing.Size(75, 44);
            this.buttonLoop10k.TabIndex = 9;
            this.buttonLoop10k.Text = "loop 10k";
            this.buttonLoop10k.UseVisualStyleBackColor = true;
            this.buttonLoop10k.Click += new System.EventHandler(this.buttonLoop10k_Click);
            // 
            // checkBoxKey2
            // 
            this.checkBoxKey2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxKey2.Location = new System.Drawing.Point(544, 7);
            this.checkBoxKey2.Name = "checkBoxKey2";
            this.checkBoxKey2.Size = new System.Drawing.Size(26, 41);
            this.checkBoxKey2.TabIndex = 10;
            this.checkBoxKey2.Text = "2";
            this.checkBoxKey2.UseVisualStyleBackColor = true;
            this.checkBoxKey2.CheckedChanged += new System.EventHandler(this.checkBoxKey2_CheckedChanged);
            // 
            // checkBox0
            // 
            this.checkBox0.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox0.Location = new System.Drawing.Point(717, 4);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(26, 41);
            this.checkBox0.TabIndex = 11;
            this.checkBox0.Text = "0";
            this.checkBox0.UseVisualStyleBackColor = true;
            this.checkBox0.CheckedChanged += new System.EventHandler(this.checkBox0_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.Location = new System.Drawing.Point(576, 8);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(26, 41);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.Location = new System.Drawing.Point(608, 7);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(26, 41);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBoxY
            // 
            this.checkBoxY.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxY.Location = new System.Drawing.Point(650, 7);
            this.checkBoxY.Name = "checkBoxY";
            this.checkBoxY.Size = new System.Drawing.Size(26, 41);
            this.checkBoxY.TabIndex = 14;
            this.checkBoxY.Text = "Y";
            this.checkBoxY.UseVisualStyleBackColor = true;
            this.checkBoxY.CheckedChanged += new System.EventHandler(this.checkBoxY_CheckedChanged);
            // 
            // buttonLoopSmall
            // 
            this.buttonLoopSmall.Location = new System.Drawing.Point(354, 13);
            this.buttonLoopSmall.Name = "buttonLoopSmall";
            this.buttonLoopSmall.Size = new System.Drawing.Size(39, 23);
            this.buttonLoopSmall.TabIndex = 15;
            this.buttonLoopSmall.Text = "sml";
            this.buttonLoopSmall.UseVisualStyleBackColor = true;
            this.buttonLoopSmall.Click += new System.EventHandler(this.buttonLoopSmall_Click);
            // 
            // textBoxRez
            // 
            this.textBoxRez.Location = new System.Drawing.Point(1035, 17);
            this.textBoxRez.Multiline = true;
            this.textBoxRez.Name = "textBoxRez";
            this.textBoxRez.Size = new System.Drawing.Size(318, 129);
            this.textBoxRez.TabIndex = 16;
            // 
            // checkBoxKeySpace
            // 
            this.checkBoxKeySpace.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxKeySpace.Location = new System.Drawing.Point(443, 14);
            this.checkBoxKeySpace.Name = "checkBoxKeySpace";
            this.checkBoxKeySpace.Size = new System.Drawing.Size(62, 27);
            this.checkBoxKeySpace.TabIndex = 17;
            this.checkBoxKeySpace.Text = "space";
            this.checkBoxKeySpace.UseVisualStyleBackColor = true;
            this.checkBoxKeySpace.CheckedChanged += new System.EventHandler(this.checkBoxKeySpace_CheckedChanged);
            // 
            // checkBoxBreak
            // 
            this.checkBoxBreak.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxBreak.Location = new System.Drawing.Point(399, 15);
            this.checkBoxBreak.Name = "checkBoxBreak";
            this.checkBoxBreak.Size = new System.Drawing.Size(41, 27);
            this.checkBoxBreak.TabIndex = 18;
            this.checkBoxBreak.Text = "brk";
            this.checkBoxBreak.UseVisualStyleBackColor = true;
            this.checkBoxBreak.CheckedChanged += new System.EventHandler(this.checkBoxBreak_CheckedChanged);
            // 
            // buttonLoop10
            // 
            this.buttonLoop10.Location = new System.Drawing.Point(1035, 178);
            this.buttonLoop10.Name = "buttonLoop10";
            this.buttonLoop10.Size = new System.Drawing.Size(44, 41);
            this.buttonLoop10.TabIndex = 19;
            this.buttonLoop10.Text = "10";
            this.buttonLoop10.UseVisualStyleBackColor = true;
            this.buttonLoop10.Click += new System.EventHandler(this.buttonLoop10_Click);
            // 
            // buttonLoop100
            // 
            this.buttonLoop100.Location = new System.Drawing.Point(1085, 178);
            this.buttonLoop100.Name = "buttonLoop100";
            this.buttonLoop100.Size = new System.Drawing.Size(44, 41);
            this.buttonLoop100.TabIndex = 20;
            this.buttonLoop100.Text = "100";
            this.buttonLoop100.UseVisualStyleBackColor = true;
            this.buttonLoop100.Click += new System.EventHandler(this.buttonLoop100_Click);
            // 
            // buttonLoop1000
            // 
            this.buttonLoop1000.Location = new System.Drawing.Point(1135, 178);
            this.buttonLoop1000.Name = "buttonLoop1000";
            this.buttonLoop1000.Size = new System.Drawing.Size(44, 41);
            this.buttonLoop1000.TabIndex = 21;
            this.buttonLoop1000.Text = "1000";
            this.buttonLoop1000.UseVisualStyleBackColor = true;
            this.buttonLoop1000.Click += new System.EventHandler(this.buttonLoop100_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1185, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "10000";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonLoop100_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1241, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 41);
            this.button2.TabIndex = 23;
            this.button2.Text = "100000";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonLoop100_Click);
            // 
            // buttonLogInstructions
            // 
            this.buttonLogInstructions.Location = new System.Drawing.Point(1038, 245);
            this.buttonLogInstructions.Name = "buttonLogInstructions";
            this.buttonLogInstructions.Size = new System.Drawing.Size(129, 23);
            this.buttonLogInstructions.TabIndex = 24;
            this.buttonLogInstructions.Text = "start instruction log";
            this.buttonLogInstructions.UseVisualStyleBackColor = true;
            this.buttonLogInstructions.Click += new System.EventHandler(this.buttonLogInstructions_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1173, 245);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1242, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 24);
            this.button4.TabIndex = 26;
            this.button4.Text = "rom";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBoxTimerEnabled
            // 
            this.checkBoxTimerEnabled.AutoSize = true;
            this.checkBoxTimerEnabled.Location = new System.Drawing.Point(1043, 290);
            this.checkBoxTimerEnabled.Name = "checkBoxTimerEnabled";
            this.checkBoxTimerEnabled.Size = new System.Drawing.Size(101, 19);
            this.checkBoxTimerEnabled.TabIndex = 27;
            this.checkBoxTimerEnabled.Text = "Timer enabled";
            this.checkBoxTimerEnabled.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1038, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 35);
            this.button5.TabIndex = 28;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FormZX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 853);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBoxTimerEnabled);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonLogInstructions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLoop1000);
            this.Controls.Add(this.buttonLoop100);
            this.Controls.Add(this.buttonLoop10);
            this.Controls.Add(this.checkBoxBreak);
            this.Controls.Add(this.checkBoxKeySpace);
            this.Controls.Add(this.textBoxRez);
            this.Controls.Add(this.buttonLoopSmall);
            this.Controls.Add(this.checkBoxY);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox0);
            this.Controls.Add(this.checkBoxKey2);
            this.Controls.Add(this.buttonLoop10k);
            this.Controls.Add(this.buttonDebugAtribs);
            this.Controls.Add(this.checkBoxKey1);
            this.Controls.Add(this.textBoxPC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoopSteps);
            this.Controls.Add(this.buttonStep);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.pictureScreen);
            this.KeyPreview = true;
            this.Name = "FormZX";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormZX_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormZX_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureScreen;
        private Button buttonDraw;
        private Button buttonStep;
        private Button buttonLoopSteps;
        private Label label1;
        private TextBox textBoxPC;
        private CheckBox checkBoxKey1;
        private Button buttonDebugAtribs;
        private Button buttonLoop10k;
        private CheckBox checkBoxKey2;
        private CheckBox checkBox0;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBoxY;
        private Button buttonLoopSmall;
        private TextBox textBoxRez;
        private CheckBox checkBoxKeySpace;
        private CheckBox checkBoxBreak;
        private Button buttonLoop10;
        private Button buttonLoop100;
        private Button buttonLoop1000;
        private Button button1;
        private Button button2;
        private Button buttonLogInstructions;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer timer1;
        private CheckBox checkBoxTimerEnabled;
        private Button button5;
    }
}