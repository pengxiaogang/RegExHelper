using System.Text.RegularExpressions;
using System.Text;
using System.Configuration;
using System.Diagnostics;
namespace RegExHelper
{
    public partial class FormMain : Form
    {
        int LeftSpace = 30;
        int TopSpace = 30;
        int RightSpace = 60;
        int BottomSpace = 90;
        int SpaceBetween = 20;
        int FixedMiddleHeight = 320;
        public FormMain()
        {
            
            InitializeComponent();
            LoadProperties();
            ReArrange();
        }
        public void ReArrange()
        {
            textBoxText.Left = LeftSpace;
            textBoxText.Top = TopSpace;
            textBoxText.Width = (this.Width - LeftSpace - RightSpace)*3/4;
            textBoxText.Height = this.Height-TopSpace-BottomSpace-SpaceBetween-FixedMiddleHeight;
            textBoxOutput.Left = textBoxText.Width+textBoxText.Left+SpaceBetween;
            textBoxOutput.Top = textBoxText.Top;
            textBoxOutput.Width = this.Width-LeftSpace-textBoxText.Width-SpaceBetween-RightSpace;
            textBoxOutput.Height = textBoxText.Height;
            groupBoxOptions.Width = 900;
            groupBoxOptions.Height = FixedMiddleHeight;
            groupBoxOptions.Left = this.Width - RightSpace - groupBoxOptions.Width;
            groupBoxOptions.Top =textBoxOutput.Top+ textBoxOutput.Height+SpaceBetween;
            labelRegexPattern.Top=groupBoxOptions.Top;
            labelRegexPattern.Left =LeftSpace;
            labelRegexPatternEmptyTips.Top=labelRegexPattern.Top;
            labelRegexPatternEmptyTips.Left = labelRegexPattern.Left + labelRegexPattern.Width + SpaceBetween;
            textBoxRegexPattern.Left = LeftSpace;
            textBoxRegexPattern.Top = labelRegexPattern.Top + labelRegexPattern.Height + SpaceBetween;
            textBoxRegexPattern.Width = this.Width - groupBoxOptions.Width - LeftSpace - RightSpace - SpaceBetween;
            textBoxRegexPattern.Height = 50;
            labelMoreAboutRegexPattern.Top=labelRegexPattern.Top;
            labelMoreAboutRegexPattern.Left = textBoxRegexPattern.Width - labelMoreAboutRegexPattern.Width + textBoxRegexPattern.Left;
            labelReplacePattern.Top=textBoxRegexPattern.Top+textBoxRegexPattern.Height+SpaceBetween;
            labelReplacePattern.Left = LeftSpace;
            labelReplacePatternEmptyTips.Top=labelReplacePattern.Top;
            labelReplacePatternEmptyTips.Left=labelReplacePattern.Left+labelReplacePattern.Width+SpaceBetween;
            labelMoreAboutReplacePattern.Top= labelReplacePattern.Top;
            labelMoreAboutReplacePattern.Left = labelMoreAboutRegexPattern.Left;
            textBoxReplacePattern.Top = labelReplacePattern.Top + labelReplacePattern.Height + SpaceBetween;
            textBoxReplacePattern.Left = textBoxRegexPattern.Left;
            textBoxReplacePattern.Width = textBoxRegexPattern.Width;
            textBoxReplacePattern.Height = textBoxRegexPattern.Height;
            buttonMatches.Top=textBoxReplacePattern.Top+textBoxReplacePattern.Height+SpaceBetween+20;
            buttonMatches.Left = LeftSpace;
            buttonMatches.Width = (textBoxReplacePattern.Width - SpaceBetween) / 2;
            buttonReplace.Top = buttonMatches.Top;
            buttonReplace.Left = buttonMatches.Left+buttonMatches.Width+SpaceBetween;
            buttonReplace.Width = buttonMatches.Width;
            /*labelMatches.Left = LeftSpace;
            labelMatches.Top=groupBoxOptions.Top+groupBoxOptions.Height+SpaceBetween;
            labelGroups.Top=labelMatches.Top;
            labelCaptures.Top=labelMatches.Top;
            textBoxMatches.Left=labelMatches.Left;
            textBoxMatches.Top=labelMatches.Top+labelMatches.Height+SpaceBetween;
            textBoxMatches.Width = (this.Width - LeftSpace - RightSpace - SpaceBetween - SpaceBetween) / 3;
            textBoxGroups.Width=textBoxMatches.Width;
            textBoxCaptures.Width=textBoxMatches.Width;
            textBoxGroups.Top = textBoxMatches.Top;
            textBoxCaptures.Top = textBoxMatches.Top;
            textBoxGroups.Left=textBoxMatches.Left+textBoxMatches.Width+SpaceBetween;
            textBoxCaptures.Left=textBoxGroups.Left+textBoxGroups.Width+SpaceBetween;
            textBoxMatches.Height=this.Height-BottomSpace-textBoxMatches.Top;
            textBoxGroups.Height=textBoxMatches.Height;
            textBoxCaptures.Height=textBoxMatches.Height;
            labelGroups.Left = textBoxGroups.Left;
            labelCaptures.Left = textBoxCaptures.Left;*/
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            ReArrange();
        }

        private void checkBoxDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDefault.Checked)
            {
                checkBoxMultiLine.Checked = true;
                checkBoxSingleLine.Checked = false;
                checkBoxCultureInvariant.Checked = false;
                checkBoxECMAScript.Checked = false;
                checkBoxExplicitCapture.Checked = false;
                checkBoxIgnoreCase.Checked = false;
                checkBoxIgnorPatternWhitespace.Checked = false;
                checkBoxRightToLeft.Checked = false;

                checkBoxMultiLine.Enabled = false;
                checkBoxSingleLine.Enabled = false;
                checkBoxRightToLeft.Enabled = false;
                checkBoxIgnorPatternWhitespace.Enabled = false;
                checkBoxIgnoreCase.Enabled = false;
                checkBoxExplicitCapture.Enabled = false;
                checkBoxECMAScript.Enabled = false;
                checkBoxCultureInvariant.Enabled = false;
            }
            else
            {
                checkBoxMultiLine.Enabled = true;
                checkBoxSingleLine.Enabled = true;
                checkBoxRightToLeft.Enabled = true;
                checkBoxIgnorPatternWhitespace.Enabled = true;
                checkBoxIgnoreCase.Enabled = true;
                checkBoxExplicitCapture.Enabled = true;
                checkBoxECMAScript.Enabled = true;
                checkBoxCultureInvariant.Enabled = true;
            }
        }

        private void DoMatch()
        {
            if (textBoxRegexPattern.Text == "" || textBoxText.Text=="")
            {
                labelRegexPatternEmptyTips.Visible=true;
                return;
            }
            
            textBoxOutput.Text = "";
            Regex regex = new Regex(textBoxRegexPattern.Text,
                (checkBoxMultiLine.Checked ? (RegexOptions.Multiline) : RegexOptions.None )|
                (checkBoxSingleLine.Checked? (RegexOptions.Singleline): RegexOptions.None) |
                (checkBoxRightToLeft.Checked?(RegexOptions.RightToLeft): RegexOptions.None) |
                (checkBoxIgnorPatternWhitespace.Checked?(RegexOptions.IgnorePatternWhitespace): RegexOptions.None) |
                (checkBoxIgnoreCase.Checked?(RegexOptions.IgnoreCase): RegexOptions.None) |
                (checkBoxExplicitCapture.Checked?(RegexOptions.ExplicitCapture): RegexOptions.None) |
                (checkBoxECMAScript.Checked?(RegexOptions.ExplicitCapture): RegexOptions.None) |
                (checkBoxCultureInvariant.Checked?(RegexOptions.CultureInvariant): RegexOptions.None));
            MatchCollection matchs=regex.Matches(textBoxText.Text);
            StringBuilder sbm=new StringBuilder();
            sbm.AppendLine("MatchCollection : " + matchs.Count.ToString() + " Matches.");
            for (int i=0; i<matchs.Count;i++)
            {
                sbm.AppendLine("MatchCollection[" + i.ToString() + "]:");
                sbm.Append(ToString(matchs[i],"----"));
                for(int j=0; j < matchs[i].Captures.Count; j++)
                {
                    sbm.AppendLine("----CaptureCollection["+j.ToString()+"]:");
                    sbm.Append(ToString(matchs[i].Captures[j],"--------"));
                }
                for(int k=0; k<matchs[i].Groups.Count; k++)
                {
                    sbm.AppendLine("----GroupCollection[" + k.ToString() + "]:");
                    sbm.Append(ToString(matchs[i].Groups[k],"--------"));
                }
            }
            textBoxOutput.Text=sbm.ToString();
        }
        private void DoReplace()
        {
            if (textBoxRegexPattern.Text == "" || textBoxText.Text == "" || textBoxReplacePattern.Text=="")
            {
                labelReplacePatternEmptyTips.Visible = true;
                return;
            }
            textBoxOutput.Text = "";
            Regex regex = new Regex(textBoxRegexPattern.Text, 
                (checkBoxMultiLine.Checked ? (RegexOptions.Multiline) : RegexOptions.None) |
                (checkBoxSingleLine.Checked ? (RegexOptions.Singleline) : RegexOptions.None) |
                (checkBoxRightToLeft.Checked ? (RegexOptions.RightToLeft) : RegexOptions.None) |
                (checkBoxIgnorPatternWhitespace.Checked ? (RegexOptions.IgnorePatternWhitespace) : RegexOptions.None) |
                (checkBoxIgnoreCase.Checked ? (RegexOptions.IgnoreCase) : RegexOptions.None) |
                (checkBoxExplicitCapture.Checked ? (RegexOptions.ExplicitCapture) : RegexOptions.None) |
                (checkBoxECMAScript.Checked ? (RegexOptions.ExplicitCapture) : RegexOptions.None) |
                (checkBoxCultureInvariant.Checked ? (RegexOptions.CultureInvariant) : RegexOptions.None));
            try
            {
                textBoxOutput.Text = regex.Replace(textBoxText.Text,textBoxReplacePattern.Text);
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = ex.Message;
            }
        }

        private void textBoxRegexPattern_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRegexPattern.Text != "" && textBoxText.Text!="")
                labelRegexPatternEmptyTips.Visible=false;
            if (textBoxReplacePattern.Text != "" && textBoxRegexPattern.Text != "" && textBoxText.Text != "")
                labelReplacePatternEmptyTips.Visible = false;
        }
        private string ToString(Match obj,string pre)
        {
            if (obj == null)
                return "";
            StringBuilder sb=new StringBuilder();
            sb.AppendLine(pre + "Match.Success = " + obj.Success.ToString());
            sb.AppendLine(pre + "Match.Name = " + "\""+ obj.Name + "\"");
            sb.AppendLine(pre + "Match.Value = " + "\"" + obj.Value + "\"");
            sb.AppendLine(pre + "Match.Length = " + obj.Length);
            sb.AppendLine(pre + "Match.Index = " + obj.Index.ToString());
            sb.AppendLine(pre + "Match.ValueSpan = " + obj.ValueSpan.ToString());
            sb.AppendLine(pre + "Match.Groups = " + obj.Groups.Count.ToString()+" Groups");
            sb.AppendLine(pre + "Match.Captures = " + obj.Captures.Count.ToString()+ " Captures");
            return sb.ToString();
        }
        private string ToString(Group obj, string pre)
        {
            if (obj == null)
                return "";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(pre + "Group.Success = " + obj.Success.ToString());
            sb.AppendLine(pre + "Group.Name = " + "\"" + obj.Name + "\"");
            sb.AppendLine(pre + "Group.Value = " + "\"" + obj.Value + "\"");
            sb.AppendLine(pre + "Group.Length = " + obj.Length);
            sb.AppendLine(pre + "Group.Index = " + obj.Index.ToString());
            sb.AppendLine(pre + "Group.ValueSpan = " + "\"" + obj.ValueSpan.ToString()+"\""  );
            sb.AppendLine(pre + "Group.Captures = " + obj.Captures.Count.ToString() + " Captures");
            return sb.ToString();
        }
        private string ToString(Capture obj, string pre)
        {
            if (obj == null)
                return "";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(pre + "Capture.Value = " + "\"" + obj.Value + "\"");
            sb.AppendLine(pre + "Capture.Length = " + obj.Length);
            sb.AppendLine(pre + "Capture.Index = " + obj.Index.ToString());
            sb.AppendLine(pre + "Capture.ValueSpan = "  + "\"" + obj.ValueSpan.ToString() + "\"");
            return sb.ToString();
        }

        private string ToString(Match obj) { return ToString(obj, ""); }
        private string ToString(Group obj) { return ToString(obj, ""); }
        private string ToString(Capture obj) { return ToString(obj, ""); }

        private void buttonMatches_Click(object sender, EventArgs e)
        {
            DoMatch();
        }
        private void LoadProperties()
        {
            textBoxRegexPattern.Text = Properties.Settings.Default.RegexPattern;
            textBoxText.Text = Properties.Settings.Default.UserText;
            textBoxReplacePattern.Text = Properties.Settings.Default.ReplacePattern;
        }
        private void SaveProperties()
        {
            Properties.Settings.Default.RegexPattern = textBoxRegexPattern.Text;
            Properties.Settings.Default.UserText = textBoxText.Text;
            Properties.Settings.Default.ReplacePattern=textBoxReplacePattern.Text;
            Properties.Settings.Default.Save();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveProperties();
        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRegexPattern.Text != "" && textBoxText.Text != "")
                labelRegexPatternEmptyTips.Visible = false;
            if (textBoxReplacePattern.Text != "" && textBoxRegexPattern.Text != "" && textBoxText.Text != "")
                labelReplacePatternEmptyTips.Visible = false;
        }

        private void textBoxReplacePattern_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRegexPattern.Text != "" && textBoxText.Text != "")
                labelRegexPatternEmptyTips.Visible = false;
            if (textBoxReplacePattern.Text != "" && textBoxRegexPattern.Text != "" && textBoxText.Text != "")
                labelReplacePatternEmptyTips.Visible = false;
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            DoReplace();
        }

        private void labelMoreAboutOptions_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("msedge.exe","https://docs.microsoft.com/zh-cn/dotnet/standard/base-types/regular-expression-options");
        }

        private void labelMoreAboutRegexPattern_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("msedge.exe", "https://docs.microsoft.com/zh-cn/dotnet/standard/base-types/regular-expression-language-quick-reference");
        }

        private void labelMoreAboutReplacePattern_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("msedge.exe", "https://docs.microsoft.com/zh-cn/dotnet/standard/base-types/substitutions-in-regular-expressions");

        }
    }
}