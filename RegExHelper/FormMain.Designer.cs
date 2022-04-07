namespace RegExHelper
{
    partial class FormMain
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
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxRegexPattern = new System.Windows.Forms.TextBox();
            this.labelRegexPattern = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxSingleLine = new System.Windows.Forms.CheckBox();
            this.checkBoxMultiLine = new System.Windows.Forms.CheckBox();
            this.labelMoreAboutOptions = new System.Windows.Forms.Label();
            this.checkBoxExplicitCapture = new System.Windows.Forms.CheckBox();
            this.checkBoxCultureInvariant = new System.Windows.Forms.CheckBox();
            this.checkBoxECMAScript = new System.Windows.Forms.CheckBox();
            this.checkBoxRightToLeft = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnorPatternWhitespace = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnoreCase = new System.Windows.Forms.CheckBox();
            this.checkBoxDefault = new System.Windows.Forms.CheckBox();
            this.labelReplacePattern = new System.Windows.Forms.Label();
            this.textBoxReplacePattern = new System.Windows.Forms.TextBox();
            this.buttonMatches = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.labelMoreAboutRegexPattern = new System.Windows.Forms.Label();
            this.labelMoreAboutReplacePattern = new System.Windows.Forms.Label();
            this.labelRegexPatternEmptyTips = new System.Windows.Forms.Label();
            this.labelReplacePatternEmptyTips = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxText
            // 
            this.textBoxText.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxText.Location = new System.Drawing.Point(35, 26);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxText.Size = new System.Drawing.Size(2174, 244);
            this.textBoxText.TabIndex = 1;
            this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            // 
            // textBoxRegexPattern
            // 
            this.textBoxRegexPattern.Font = new System.Drawing.Font("Microsoft YaHei Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRegexPattern.Location = new System.Drawing.Point(35, 621);
            this.textBoxRegexPattern.Name = "textBoxRegexPattern";
            this.textBoxRegexPattern.Size = new System.Drawing.Size(1260, 40);
            this.textBoxRegexPattern.TabIndex = 2;
            this.textBoxRegexPattern.TextChanged += new System.EventHandler(this.textBoxRegexPattern_TextChanged);
            // 
            // labelRegexPattern
            // 
            this.labelRegexPattern.AutoSize = true;
            this.labelRegexPattern.Location = new System.Drawing.Point(35, 576);
            this.labelRegexPattern.Name = "labelRegexPattern";
            this.labelRegexPattern.Size = new System.Drawing.Size(342, 31);
            this.labelRegexPattern.TabIndex = 0;
            this.labelRegexPattern.Text = "正则表达式 (RegEx Pattern)：";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.checkBoxSingleLine);
            this.groupBoxOptions.Controls.Add(this.checkBoxMultiLine);
            this.groupBoxOptions.Controls.Add(this.labelMoreAboutOptions);
            this.groupBoxOptions.Controls.Add(this.checkBoxExplicitCapture);
            this.groupBoxOptions.Controls.Add(this.checkBoxCultureInvariant);
            this.groupBoxOptions.Controls.Add(this.checkBoxECMAScript);
            this.groupBoxOptions.Controls.Add(this.checkBoxRightToLeft);
            this.groupBoxOptions.Controls.Add(this.checkBoxIgnorPatternWhitespace);
            this.groupBoxOptions.Controls.Add(this.checkBoxIgnoreCase);
            this.groupBoxOptions.Controls.Add(this.checkBoxDefault);
            this.groupBoxOptions.Location = new System.Drawing.Point(1315, 558);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(900, 320);
            this.groupBoxOptions.TabIndex = 4;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "选项 (Options)";
            // 
            // checkBoxSingleLine
            // 
            this.checkBoxSingleLine.AutoSize = true;
            this.checkBoxSingleLine.Location = new System.Drawing.Point(558, 54);
            this.checkBoxSingleLine.Name = "checkBoxSingleLine";
            this.checkBoxSingleLine.Size = new System.Drawing.Size(320, 35);
            this.checkBoxSingleLine.TabIndex = 3;
            this.checkBoxSingleLine.Text = "单行模式 ( SingleLine: s )";
            this.checkBoxSingleLine.UseVisualStyleBackColor = true;
            // 
            // checkBoxMultiLine
            // 
            this.checkBoxMultiLine.AutoSize = true;
            this.checkBoxMultiLine.Checked = true;
            this.checkBoxMultiLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMultiLine.Location = new System.Drawing.Point(224, 54);
            this.checkBoxMultiLine.Name = "checkBoxMultiLine";
            this.checkBoxMultiLine.Size = new System.Drawing.Size(320, 35);
            this.checkBoxMultiLine.TabIndex = 3;
            this.checkBoxMultiLine.Text = "多行模式 ( MultiLine: m )";
            this.checkBoxMultiLine.UseVisualStyleBackColor = true;
            // 
            // labelMoreAboutOptions
            // 
            this.labelMoreAboutOptions.AutoSize = true;
            this.labelMoreAboutOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMoreAboutOptions.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMoreAboutOptions.Location = new System.Drawing.Point(591, 272);
            this.labelMoreAboutOptions.Name = "labelMoreAboutOptions";
            this.labelMoreAboutOptions.Size = new System.Drawing.Size(287, 31);
            this.labelMoreAboutOptions.TabIndex = 2;
            this.labelMoreAboutOptions.Text = "More About Options......";
            this.labelMoreAboutOptions.Click += new System.EventHandler(this.labelMoreAboutOptions_Click);
            // 
            // checkBoxExplicitCapture
            // 
            this.checkBoxExplicitCapture.AutoSize = true;
            this.checkBoxExplicitCapture.Location = new System.Drawing.Point(404, 106);
            this.checkBoxExplicitCapture.Name = "checkBoxExplicitCapture";
            this.checkBoxExplicitCapture.Size = new System.Drawing.Size(449, 35);
            this.checkBoxExplicitCapture.TabIndex = 0;
            this.checkBoxExplicitCapture.Text = "不捕获未命名组 ( ExplicitCapture: n )";
            this.checkBoxExplicitCapture.UseVisualStyleBackColor = true;
            // 
            // checkBoxCultureInvariant
            // 
            this.checkBoxCultureInvariant.AutoSize = true;
            this.checkBoxCultureInvariant.Location = new System.Drawing.Point(18, 267);
            this.checkBoxCultureInvariant.Name = "checkBoxCultureInvariant";
            this.checkBoxCultureInvariant.Size = new System.Drawing.Size(459, 35);
            this.checkBoxCultureInvariant.TabIndex = 0;
            this.checkBoxCultureInvariant.Text = "忽略语言区域差异 ( CultureInvariant )";
            this.checkBoxCultureInvariant.UseVisualStyleBackColor = true;
            // 
            // checkBoxECMAScript
            // 
            this.checkBoxECMAScript.AutoSize = true;
            this.checkBoxECMAScript.Location = new System.Drawing.Point(404, 212);
            this.checkBoxECMAScript.Name = "checkBoxECMAScript";
            this.checkBoxECMAScript.Size = new System.Drawing.Size(382, 35);
            this.checkBoxECMAScript.TabIndex = 0;
            this.checkBoxECMAScript.Text = "启用ECMA规范 ( ECMAScript )";
            this.checkBoxECMAScript.UseVisualStyleBackColor = true;
            // 
            // checkBoxRightToLeft
            // 
            this.checkBoxRightToLeft.AutoSize = true;
            this.checkBoxRightToLeft.Location = new System.Drawing.Point(18, 212);
            this.checkBoxRightToLeft.Name = "checkBoxRightToLeft";
            this.checkBoxRightToLeft.Size = new System.Drawing.Size(312, 35);
            this.checkBoxRightToLeft.TabIndex = 0;
            this.checkBoxRightToLeft.Text = "从右向左 ( RightToLeft )";
            this.checkBoxRightToLeft.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnorPatternWhitespace
            // 
            this.checkBoxIgnorPatternWhitespace.AutoSize = true;
            this.checkBoxIgnorPatternWhitespace.Location = new System.Drawing.Point(18, 156);
            this.checkBoxIgnorPatternWhitespace.Name = "checkBoxIgnorPatternWhitespace";
            this.checkBoxIgnorPatternWhitespace.Size = new System.Drawing.Size(688, 35);
            this.checkBoxIgnorPatternWhitespace.TabIndex = 0;
            this.checkBoxIgnorPatternWhitespace.Text = "忽略模式空白，启用＃注释 ( IgnorePatternWhitespace: x )";
            this.checkBoxIgnorPatternWhitespace.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnoreCase
            // 
            this.checkBoxIgnoreCase.AutoSize = true;
            this.checkBoxIgnoreCase.Location = new System.Drawing.Point(18, 105);
            this.checkBoxIgnoreCase.Name = "checkBoxIgnoreCase";
            this.checkBoxIgnoreCase.Size = new System.Drawing.Size(361, 35);
            this.checkBoxIgnoreCase.TabIndex = 0;
            this.checkBoxIgnoreCase.Text = "不区分大小写 ( IgnorCase: i )";
            this.checkBoxIgnoreCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxDefault
            // 
            this.checkBoxDefault.AutoSize = true;
            this.checkBoxDefault.Location = new System.Drawing.Point(18, 54);
            this.checkBoxDefault.Name = "checkBoxDefault";
            this.checkBoxDefault.Size = new System.Drawing.Size(200, 35);
            this.checkBoxDefault.TabIndex = 0;
            this.checkBoxDefault.Text = "默认 (Default)";
            this.checkBoxDefault.UseVisualStyleBackColor = true;
            this.checkBoxDefault.CheckedChanged += new System.EventHandler(this.checkBoxDefault_CheckedChanged);
            // 
            // labelReplacePattern
            // 
            this.labelReplacePattern.AutoSize = true;
            this.labelReplacePattern.Location = new System.Drawing.Point(35, 701);
            this.labelReplacePattern.Name = "labelReplacePattern";
            this.labelReplacePattern.Size = new System.Drawing.Size(331, 31);
            this.labelReplacePattern.TabIndex = 0;
            this.labelReplacePattern.Text = "替换表达式 (Replacement)：";
            // 
            // textBoxReplacePattern
            // 
            this.textBoxReplacePattern.Font = new System.Drawing.Font("Microsoft YaHei Mono", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxReplacePattern.Location = new System.Drawing.Point(35, 744);
            this.textBoxReplacePattern.Name = "textBoxReplacePattern";
            this.textBoxReplacePattern.Size = new System.Drawing.Size(1260, 40);
            this.textBoxReplacePattern.TabIndex = 2;
            this.textBoxReplacePattern.TextChanged += new System.EventHandler(this.textBoxReplacePattern_TextChanged);
            // 
            // buttonMatches
            // 
            this.buttonMatches.Location = new System.Drawing.Point(35, 811);
            this.buttonMatches.Name = "buttonMatches";
            this.buttonMatches.Size = new System.Drawing.Size(653, 50);
            this.buttonMatches.TabIndex = 5;
            this.buttonMatches.Text = "匹配&捕获 ( Matches... )";
            this.buttonMatches.UseVisualStyleBackColor = true;
            this.buttonMatches.Click += new System.EventHandler(this.buttonMatches_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Location = new System.Drawing.Point(748, 811);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(547, 50);
            this.buttonReplace.TabIndex = 6;
            this.buttonReplace.Text = "替换 ( Replace... )";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // labelMoreAboutRegexPattern
            // 
            this.labelMoreAboutRegexPattern.AutoSize = true;
            this.labelMoreAboutRegexPattern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMoreAboutRegexPattern.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMoreAboutRegexPattern.Location = new System.Drawing.Point(1022, 576);
            this.labelMoreAboutRegexPattern.Name = "labelMoreAboutRegexPattern";
            this.labelMoreAboutRegexPattern.Size = new System.Drawing.Size(273, 31);
            this.labelMoreAboutRegexPattern.TabIndex = 2;
            this.labelMoreAboutRegexPattern.Text = "More About RegEx ......";
            this.labelMoreAboutRegexPattern.Click += new System.EventHandler(this.labelMoreAboutRegexPattern_Click);
            // 
            // labelMoreAboutReplacePattern
            // 
            this.labelMoreAboutReplacePattern.AutoSize = true;
            this.labelMoreAboutReplacePattern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMoreAboutReplacePattern.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMoreAboutReplacePattern.Location = new System.Drawing.Point(1009, 701);
            this.labelMoreAboutReplacePattern.Name = "labelMoreAboutReplacePattern";
            this.labelMoreAboutReplacePattern.Size = new System.Drawing.Size(286, 31);
            this.labelMoreAboutReplacePattern.TabIndex = 2;
            this.labelMoreAboutReplacePattern.Text = "More About Replace......";
            this.labelMoreAboutReplacePattern.Click += new System.EventHandler(this.labelMoreAboutReplacePattern_Click);
            // 
            // labelRegexPatternEmptyTips
            // 
            this.labelRegexPatternEmptyTips.AutoSize = true;
            this.labelRegexPatternEmptyTips.ForeColor = System.Drawing.Color.Red;
            this.labelRegexPatternEmptyTips.Location = new System.Drawing.Point(383, 576);
            this.labelRegexPatternEmptyTips.Name = "labelRegexPatternEmptyTips";
            this.labelRegexPatternEmptyTips.Size = new System.Drawing.Size(398, 31);
            this.labelRegexPatternEmptyTips.TabIndex = 7;
            this.labelRegexPatternEmptyTips.Text = "正则表达式或待匹配正文不能为空！";
            this.labelRegexPatternEmptyTips.Visible = false;
            // 
            // labelReplacePatternEmptyTips
            // 
            this.labelReplacePatternEmptyTips.AutoSize = true;
            this.labelReplacePatternEmptyTips.ForeColor = System.Drawing.Color.Red;
            this.labelReplacePatternEmptyTips.Location = new System.Drawing.Point(383, 701);
            this.labelReplacePatternEmptyTips.Name = "labelReplacePatternEmptyTips";
            this.labelReplacePatternEmptyTips.Size = new System.Drawing.Size(542, 31);
            this.labelReplacePatternEmptyTips.TabIndex = 7;
            this.labelReplacePatternEmptyTips.Text = "正则表达式、替换表达式或待匹配正文不能为空！";
            this.labelReplacePatternEmptyTips.Visible = false;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxOutput.Location = new System.Drawing.Point(35, 289);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(2174, 263);
            this.textBoxOutput.TabIndex = 1;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2255, 1584);
            this.Controls.Add(this.labelReplacePatternEmptyTips);
            this.Controls.Add(this.labelRegexPatternEmptyTips);
            this.Controls.Add(this.labelMoreAboutReplacePattern);
            this.Controls.Add(this.labelMoreAboutRegexPattern);
            this.Controls.Add(this.buttonReplace);
            this.Controls.Add(this.buttonMatches);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.textBoxReplacePattern);
            this.Controls.Add(this.textBoxRegexPattern);
            this.Controls.Add(this.labelReplacePattern);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.labelRegexPattern);
            this.Name = "FormMain";
            this.Text = "正则表达式测试工具 (RegEx Helper)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxText;
        private TextBox textBoxRegexPattern;
        private Label labelRegexPattern;
        private GroupBox groupBoxOptions;
        private CheckBox checkBoxExplicitCapture;
        private CheckBox checkBoxCultureInvariant;
        private CheckBox checkBoxECMAScript;
        private CheckBox checkBoxRightToLeft;
        private CheckBox checkBoxIgnorPatternWhitespace;
        private CheckBox checkBoxIgnoreCase;
        private CheckBox checkBoxDefault;
        private Label labelReplacePattern;
        private TextBox textBoxReplacePattern;
        private Button buttonMatches;
        private Button buttonReplace;
        private Label labelMoreAboutOptions;
        private Label labelMoreAboutRegexPattern;
        private Label labelMoreAboutReplacePattern;
        private Label labelRegexPatternEmptyTips;
        private Label labelReplacePatternEmptyTips;
        private TextBox textBoxOutput;
        private CheckBox checkBoxSingleLine;
        private CheckBox checkBoxMultiLine;
    }
}