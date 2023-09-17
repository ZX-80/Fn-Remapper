using Microsoft.Win32;
using System.Diagnostics;

/* TODO
 * Allow selecting between Desktop (program), UIAccess (elevated program), and Metro (app)
 *     Apptype = Desktop (1), UIAccess (2), and Metro (3)
 *     Keys = Desktop (File, Parameters), UIAccess (File, Parameters), and Metro (PackageName, URI)
 */

namespace X1EG5_Fn_Key_Remapper {

    public partial class Form1 : Form {

        private readonly Fn F4 = new("Microphone Mute", @"HKEY_LOCAL_MACHINE\SOFTWARE\Lenovo\ShortcutKey\AppLaunch\Ex_1A\Desktop");
        private readonly Fn F5 = new("Decrease Brightness (Cannot be suppressed)", @"HKEY_LOCAL_MACHINE\SOFTWARE\Lenovo\ShortcutKey\AppLaunch\Ex_10\Desktop");
        private readonly Fn F6 = new("Increase Brightness (Cannot be suppressed)", @"HKEY_LOCAL_MACHINE\SOFTWARE\Lenovo\ShortcutKey\AppLaunch\Ex_0F\Desktop");
        private readonly Fn F7 = new("Project Options", @"HKEY_LOCAL_MACHINE\SOFTWARE\Lenovo\ShortcutKey\AppLaunch\7\Desktop");
        private readonly Fn F8 = new("Airplane Mode", @"HKEY_LOCAL_MACHINE\SOFTWARE\Lenovo\ShortcutKey\AppLaunch\5\Desktop");
        private readonly Fn F9 = new("Notifications", @"HKEY_LOCAL_MACHINE\SOFTWARE\Lenovo\ShortcutKey\AppLaunch\Ex_96\Desktop");
        private readonly Fn F10 = new("Answer Teams call", @"HKEY_LOCAL_MACHINE\SOFTWARE\Lenovo\ShortcutKey\AppLaunch\Ex_97\Desktop");
        private readonly Fn F11 = new("Reject Teams call", @"HKEY_LOCAL_MACHINE\SOFTWARE\Lenovo\ShortcutKey\AppLaunch\Ex_98\Desktop");
        private readonly Fn F12 = new("User Defined Function", @"HKEY_LOCAL_MACHINE\SOFTWARE\Lenovo\ShortcutKey\AppLaunch\Ex_90\Desktop");
        private readonly Fn Tab = new("Magnify", @"HKEY_LOCAL_MACHINE\SOFTWARE\Lenovo\ShortcutKey\AppLaunch\Ex_13\UIAccess");

        private Fn CurrentFunction => (Fn)Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag;

        public Form1() {
            InitializeComponent();
            radioButtonF4.Tag = F4;
            radioButtonF5.Tag = F5;
            radioButtonF6.Tag = F6;
            radioButtonF7.Tag = F7;
            radioButtonF8.Tag = F8;
            radioButtonF9.Tag = F9;
            radioButtonF10.Tag = F10;
            radioButtonF11.Tag = F11;
            radioButtonF12.Tag = F12;
            radioButtonTab.Tag = Tab;
            RadioButtonChanged();
        }

        // Registry Functions
        private ActionReg ReadFunctionAction(Fn Function) => new() {
            file = Registry.GetValue(Function.registry, "File", null) as string,
            parameters = Registry.GetValue(Function.registry, "Parameters", null) as string
        };
        private void ModifyFunctionAction(Fn Function, string File, string Parameters) {
            string parentKey = Path.GetDirectoryName(Function.registry);
            if (Registry.GetValue(parentKey, "AppType", null) is null) {
                Registry.SetValue(parentKey, "AppType", 1, RegistryValueKind.DWord);
            }
            Registry.SetValue(Function.registry, "File", File, RegistryValueKind.String);
            Registry.SetValue(Function.registry, "Parameters", Parameters, RegistryValueKind.String);
        }
        private void DeleteFunctionAction(Fn Function) {
            string parentKey = Path.GetDirectoryName(Function.registry);
            Registry.LocalMachine.DeleteSubKeyTree(parentKey.Substring(parentKey.IndexOf(@"\") + 1), false);
        }

        // TextBox functions
        private void setTextBoxes() {
            textBoxFile.Text = "";
            textBoxParam.Text = "";
            textBoxFile.PlaceholderText = "Default";
            textBoxParam.PlaceholderText = "Default";
            buttonApply.Enabled = false;
            buttonDefault.Enabled = false;
        }
        private void setTextBoxes(string file, string parameters, bool modifiedByUser) {
            textBoxFile.Text = file;
            textBoxParam.Text = parameters;
            textBoxFile.PlaceholderText = "";
            textBoxParam.PlaceholderText = "";
            buttonApply.Enabled = modifiedByUser;
            buttonDefault.Enabled = (CurrentFunction != Tab);
        }

        private void textBoxFile_TextChanged(object sender, EventArgs e) {
            setTextBoxes(textBoxFile.Text, textBoxParam.Text, true);
        }

        private void textBoxParam_TextChanged(object sender, EventArgs e) {
            setTextBoxes(textBoxFile.Text, textBoxParam.Text, true);
        }

        // Button Actions
        private void labelRegistryBox_Click(object sender, EventArgs e) {
            var registryLastKey = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Applets\Regedit";
            try {
                if (Registry.GetValue(Path.GetDirectoryName(CurrentFunction.registry), "AppType", null) is null) {
                    Registry.SetValue(registryLastKey, "LastKey", Path.GetDirectoryName(Path.GetDirectoryName(CurrentFunction.registry)));
                } else {
                    Registry.SetValue(registryLastKey, "LastKey", CurrentFunction.registry);
                }
                Process.Start("regedit.exe");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDefault_Click(object sender, EventArgs e) {
            DeleteFunctionAction(CurrentFunction);
            setTextBoxes();
        }

        private void buttonApply_Click(object sender, EventArgs e) {
            ModifyFunctionAction(CurrentFunction, textBoxFile.Text, textBoxParam.Text);
            buttonApply.Enabled = false;
        }

        // Modify display when a key is selected
        private void RadioButtonChanged() {
            ActionReg functionAction = ReadFunctionAction(CurrentFunction);
            if (functionAction.file is null || functionAction.parameters is null) {
                setTextBoxes();
            } else {
                setTextBoxes(functionAction.file, functionAction.parameters, false);
            }
            labelNotesBox.Text = CurrentFunction.note;
            labelRegistryBox.Text = CurrentFunction.registry;
        }

        private void radioButtonTab_CheckedChanged(object sender, EventArgs e) {
            RadioButtonChanged();
        }

        private void radioButtonF4_CheckedChanged(object sender, EventArgs e) {
            RadioButtonChanged();
        }

        private void radioButtonF5_CheckedChanged(object sender, EventArgs e) {
            RadioButtonChanged();
        }

        private void radioButtonF6_CheckedChanged(object sender, EventArgs e) {
            RadioButtonChanged();
        }

        private void radioButtonF7_CheckedChanged(object sender, EventArgs e) {
            RadioButtonChanged();
        }

        private void radioButtonF8_CheckedChanged(object sender, EventArgs e) {
            RadioButtonChanged();
        }

        private void radioButtonF9_CheckedChanged(object sender, EventArgs e) {
            RadioButtonChanged();
        }

        private void radioButtonF10_CheckedChanged(object sender, EventArgs e) {
            RadioButtonChanged();
        }

        private void radioButtonF11_CheckedChanged(object sender, EventArgs e) {
            RadioButtonChanged();
        }
        private void radioButtonF12_CheckedChanged(object sender, EventArgs e) {
            RadioButtonChanged();
        }
    }

    public class Fn {
        public string note;
        public string registry;
        public Fn(string note, string registry) {
            this.note = note;
            this.registry = registry;
        }
    }
    public class ActionReg {
        public string? file;
        public string? parameters;
    }

}